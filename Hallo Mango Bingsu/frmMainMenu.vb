Imports MySql.Data.MySqlClient

Public Class frmMainMenu

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    ' WELCOME PANEL
    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) 'Handles MyBase.Load
        welcomepanel_Load
    End Sub

    Public Sub welcomepanel_Load()
        For Each panel As Panel In {dashboardpanel, categorypanel, productpanel1}
            panel.Visible = False
        Next
        welcomepanel.Visible = True
    End Sub


    ' DASHBOARD PANEL
    Private Sub dashboardbtn_Click(sender As Object, e As EventArgs) Handles dashboardbtn.Click
        For Each panel As Panel In {welcomepanel, categorypanel, productpanel1}
            panel.Visible = False
        Next
        dashboardpanel.Visible = True
    End Sub


    ' CATEGORY PANEL - SEARCH - ADD - UPDATE - DELETE
    Private Sub categorybtn_Click(sender As Object, e As EventArgs) Handles categorybtn.Click
        For Each panel As Panel In {welcomepanel, dashboardpanel, productpanel1}
            panel.Visible = False
        Next
        categorypanel.Visible = True
    End Sub

    Private Sub LoadCategory(sender As Object, e As EventArgs) 'Handles MyBase.Load
        LoadCategoryList
    End Sub

    Private Sub LoadCategoryList()
        Dim sql As String = "Select * from product_category"
        Try
            categorylistdg.Rows.Clear()
            readquery(sql)
            With cmdread
                While .Read
                    categorylistdg.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2))
                End While
            End With
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cmdread.Close()
        End Try
    End Sub

    Private Sub category_searchbtn_Click(sender As Object, e As EventArgs) Handles category_searchbtn.Click
        Dim str As String = "SELECT * FROM product_category WHERE category_name LIKE '%" + searchbox.Text + "%' OR category_desc LIKE '&" + searchbox.Text + "&'"
        Try
            categorylistdg.Rows.Clear()
            readquery(str)
            With cmdread
                While .Read
                    categorylistdg.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2))
                End While
            End With
        Catch ex As Exception

        End Try
    End Sub


    Private Sub category_addbtn_Click(sender As Object, e As EventArgs) Handles category_addbtn.Click
        Dim categoryName As String = categorynametxt.Text.Trim()
        Dim categoryDesc As String = categorydesctxt.Text.Trim()

        If String.IsNullOrWhiteSpace(categoryName) OrElse String.IsNullOrWhiteSpace(categoryDesc) Then
            MessageBox.Show("Please enter both category name and description.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Check if the data already exists
        Dim checkQuery As String = "SELECT COUNT(*) FROM product_category WHERE category_name = '" & categoryName & "' AND category_desc = '" & categoryDesc & "'"
        Dim dataExists As Boolean = False

        Try
            readquery(checkQuery)
            If cmdread.HasRows Then
                cmdread.Read()
                categorynametxt.Clear()
                categorydesctxt.Clear()
                Dim count As Integer = CInt(cmdread(0))
                dataExists = count > 0
            End If
            cmdread.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            Return
        End Try

        If dataExists Then
            MessageBox.Show("Category with the same name and description already exists.", "Duplicate Category", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Proceed with insertion if data is unique
        Dim insertQuery As String = "INSERT INTO product_category(category_name, category_desc) VALUES ('" & categoryName & "', '" & categoryDesc & "')"
        Try
            readquery(insertQuery)
            categorynametxt.Clear()
            categorydesctxt.Clear()
            MessageBox.Show("New category has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCategoryList()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub category_updatebtn_Click(sender As Object, e As EventArgs) Handles category_updatebtn.Click
        Dim str As String = "UPDATE product_category SET category_name = '" & categorynametxt.Text & "', category_desc = '" & categorydesctxt.Text & "' WHERE category_id =  '" & selectedCategoryId & "'"
        If String.IsNullOrWhiteSpace(categorynametxt.Text) OrElse String.IsNullOrWhiteSpace(categorydesctxt.Text) Then
            MessageBox.Show("Please enter both category name and description.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Try
            readquery(str)
            MessageBox.Show("Category has been updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCategoryList()
            categorynametxt.Clear()
            categorydesctxt.Clear()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub category_deletebtn_Click(sender As Object, e As EventArgs) Handles category_deletebtn.Click

    End Sub

    Private selectedCategoryId As Integer
    Private Sub categorylistdg_SelectionChanged(sender As Object, e As EventArgs) Handles categorylistdg.SelectionChanged
        If categorylistdg.SelectedRows.Count > 0 Then
            Dim selectedRow = categorylistdg.SelectedRows(0)
            selectedCategoryId = Convert.ToInt32(selectedRow.Cells(0).Value)
            categorynametxt.Text = selectedRow.Cells(1).Value.ToString()
            categorydesctxt.Text = selectedRow.Cells(2).Value.ToString()
        End If
    End Sub



    ' PRODUCT PANEL
    Private Sub productbtn_Click(sender As Object, e As EventArgs) Handles productbtn.Click
        For Each panel As Panel In {welcomepanel, dashboardpanel, categorypanel}
            panel.Visible = False
        Next
        productpanel1.Visible = True
    End Sub

    Private Sub LoadProduct(sender As Object, e As EventArgs) Handles MyBase.Load 'FUNCTION TO LOAD DATA 
        LoadProductList()
    End Sub

    Private Sub LoadProductList()
        Dim sql As String = "Select * from product"
        Try
            productlistdg.Rows.Clear()
            readquery(sql)
            With cmdread
                While .Read
                    productlistdg.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), .GetValue(4), .GetValue(5), .GetValue(6))
                End While
            End With
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cmdread.Close()
        End Try
    End Sub

    Private Sub product_searchbtn_Click(sender As Object, e As EventArgs) Handles product_searchbtn.Click
        Dim str = "SELECT * FROM product WHERE category_id LIKE '%" + searchbox.Text + "%' OR category_name LIKE '&" + searchbox.Text + "&'"
        Try
            categorylistdg.Rows.Clear()
            readquery(str)
            With cmdread
                While .Read
                    categorylistdg.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2))
                End While
            End With
        Catch ex As Exception

        End Try
    End Sub


End Class