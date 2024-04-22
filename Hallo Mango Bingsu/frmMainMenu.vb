Public Class frmMainMenu
    'Public Sub New()
    '    InitializeComponent()
    '    Me.StartPosition = FormStartPosition.CenterScreen
    '    Me.WindowState = FormWindowState.Maximized
    'End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    ' WELCOME PANEL
    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Handles MyBase.Load
        welcomepanel_Load()
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

    Private Sub LoadCategory(sender As Object, e As EventArgs) Handles MyBase.Load 'FUNCTION TO LOAD DATA 
        LoadCategoryList()
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

    Private Sub searchbtn_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
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
        Dim str As String = "INSERT INTO product_category(category_name, category_desc) VALUES ('" & categorynametxt.Text & "', '" & categorydesctxt.Text & "')"
        If String.IsNullOrWhiteSpace(categorynametxt.Text) OrElse String.IsNullOrWhiteSpace(categorydesctxt.Text) Then
            MessageBox.Show("Please enter both category name and description.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Try
            readquery(str)
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
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub category_deletebtn_Click(sender As Object, e As EventArgs) Handles category_deletebtn.Click
        Dim str As String = "DELETE FROM product_category WHERE category_id =  '" & selectedCategoryId & "'"
        If String.IsNullOrWhiteSpace(categorynametxt.Text) OrElse String.IsNullOrWhiteSpace(categorydesctxt.Text) Then
            MessageBox.Show("Please enter both category name and description.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            readquery(str)
            MessageBox.Show("Category has been deleted.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCategoryList()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
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

End Class