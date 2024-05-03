Imports MySql.Data.MySqlClient

Public Class frmMainMenu

    Public Sub disableStaffBtn(bool As Boolean)
        staffbtn.Visible = False
    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    ' WELCOME PANEL
    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) 'Handles MyBase.Load
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

    Private Sub LoadCategory(sender As Object, e As EventArgs) 'Handles MyBase.Load
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

    Private Sub category_searchbtn_Click(sender As Object, e As EventArgs) Handles category_searchbtn.Click
        Dim str As String = "SELECT * FROM product_category WHERE category_name LIKE '%" + searchbox.Text + "%' OR category_desc LIKE '%" + searchbox.Text + "%'"
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

            productincategorydg.Rows.Clear()

            Dim sql As String = "SELECT category_id, product_name, quantity_in_stock FROM product, product_category WHERE category_id = category AND category_id = @categoryId ORDER BY product_name LIMIT 1"
            Try
                Using conn As New MySqlConnection(strconn)
                    conn.Open()
                    Using cmd As New MySqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@categoryId", selectedCategoryId)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                productincategorydg.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2))
                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub



    ' PRODUCT PANEL - SEARCH - ADD - UPDATE
    Private Sub productbtn_Click(sender As Object, e As EventArgs) Handles productbtn.Click
        For Each panel As Panel In {welcomepanel, dashboardpanel, categorypanel}
            panel.Visible = False
        Next
        productpanel1.Visible = True
    End Sub

    Private Sub LoadProduct(sender As Object, e As EventArgs) Handles MyBase.Load 'Handles MyBase.Load
        LoadProductList()
    End Sub

    Private Sub LoadProductList()
        Dim sql As String = "Select * from product"
        Try
            productlistdg.Rows.Clear()
            readquery(sql)
            With cmdread
                While .Read
                    productlistdg.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), .GetValue(4), .GetValue(5), .GetValue(6), .GetValue(7))
                End While
            End With
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            cmdread.Close()
        End Try
    End Sub

    Private Sub product_searchbtn_Click(sender As Object, e As EventArgs) Handles product_searchbtn.Click
        Dim str As String = "SELECT * FROM product WHERE product_id LIKE '%" + productsearchtxt.Text + "%' OR product_name LIKE '%" + productsearchtxt.Text + "%' OR product_quantity LIKE '%" + productsearchtxt.Text + "%' OR quantity_in_stock LIKE '%" + productsearchtxt.Text + "%' OR last_restocked_date LIKE '%" + productsearchtxt.Text + "%'  OR expiration_date LIKE '%" + productsearchtxt.Text + "%'"
        Try
            productlistdg.Rows.Clear()
            readquery(str)
            With cmdread
                While .Read
                    productlistdg.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2), .GetValue(3), .GetValue(4), .GetValue(5), .GetValue(6), .GetValue(7))
                End While
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub product_addbtn_Click(sender As Object, e As EventArgs) Handles product_addbtn.Click
        Dim productName As String = productnametxt.Text.Trim()
        Dim category As String = categorytxt.Text.Trim()
        Dim qty As String = qtytxt.Text.Trim()
        Dim qtyInStock As String = qtyinstocktxt.Text.Trim()
        Dim unitPrice As String = unitpricetxt.Text.Trim()
        Dim restockedDate As String = restockdatedtp.Value.ToString("yyyy-MM-dd")
        Dim expirationDate As String = expirationdatedtp.Value.ToString("yyyy-MM-dd")

        If String.IsNullOrWhiteSpace(productName) OrElse String.IsNullOrWhiteSpace(category) OrElse String.IsNullOrWhiteSpace(qty) OrElse String.IsNullOrWhiteSpace(qtyInStock) OrElse String.IsNullOrWhiteSpace(unitPrice) Then
            MessageBox.Show("There is/are missing information. Please try again.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim checkQuery As String = "SELECT COUNT(*) FROM product WHERE product_name = '" & productName & "' AND product_quantity = '" & qty & "' AND unit_price = '" & unitPrice & "' AND last_restocked_date = '" & restockedDate & "' AND expiration_date = '" & expirationDate & "'"
        Dim dataExists As Boolean = False

        Try
            readquery(checkQuery)
            If cmdread.HasRows Then
                cmdread.Read()
                productnametxt.Clear()
                categorytxt.Clear()
                qtytxt.Clear()
                qtyinstocktxt.Clear()
                unitpricetxt.Clear()
                Dim count As Integer = CInt(cmdread(0))
                dataExists = count > 0
            End If
            cmdread.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            Return
        End Try

        If dataExists Then
            MessageBox.Show("Product with the same details already exists. Please try again.", "Duplicate Category", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim insertQuery As String = "INSERT INTO product(category, product_name, product_quantity, quantity_in_stock, last_restocked_date, expiration_date, unit_price) VALUES ('" & category & "', '" & productName & "', '" & qty & "', '" & qtyInStock & "', '" & restockedDate & "', '" & expirationDate & "', '" & unitPrice & "')"
        Try
            readquery(insertQuery)
            productnametxt.Clear()
            categorytxt.Clear()
            qtytxt.Clear()
            qtyinstocktxt.Clear()
            unitpricetxt.Clear()
            MessageBox.Show("New product has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCategoryList()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub product_updatebtn_Click(sender As Object, e As EventArgs) Handles product_updatebtn.Click
        Dim restockDate As String = restockdatedtp.Value.ToString("yyyy-MM-dd HH:mm:ss")
        Dim expirationDate As String = expirationdatedtp.Value.ToString("yyyy-MM-dd HH:mm:ss")
        Dim str As String = "UPDATE product SET product_name = '" & productnametxt.Text & "', category = '" & categorytxt.Text & "', quantity = '" & qtytxt.Text & "', quantity_in_stock = '" & qtyinstocktxt.Text & "', unit_price = '" & unitpricetxt.Text & "', last_restocked_date = '" & restockDate & "', expiration_date = '" & expirationDate & "' WHERE category_id =  '" & selectedProductId & "'"
        If String.IsNullOrWhiteSpace(productnametxt.Text) OrElse String.IsNullOrWhiteSpace(categorytxt.Text) OrElse String.IsNullOrWhiteSpace(qtytxt.Text) OrElse String.IsNullOrWhiteSpace(qtyinstocktxt.Text) OrElse String.IsNullOrWhiteSpace(unitpricetxt.Text) Then
            MessageBox.Show("Please fill out all needed information.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Try
            readquery(str)
            MessageBox.Show("Product information has been updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCategoryList()
            productnametxt.Clear()
            categorytxt.Clear()
            qtytxt.Clear()
            qtyinstocktxt.Clear()
            unitpricetxt.Clear()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private selectedProductId As Integer

    Private Sub productlistdg_SelectionChanged(sender As Object, e As EventArgs) Handles productlistdg.SelectionChanged
        If productlistdg.SelectedRows.Count > 0 Then
            Dim selectedRow = productlistdg.SelectedRows(0)
            selectedProductId = Convert.ToInt32(selectedRow.Cells(0).Value)
            productnametxt.Text = selectedRow.Cells(1).Value.ToString()
            categorytxt.Text = selectedRow.Cells(2).Value.ToString()
            qtytxt.Text = selectedRow.Cells(3).Value.ToString()
            qtyinstocktxt.Text = selectedRow.Cells(4).Value.ToString()
            categorytxt.Text = selectedRow.Cells(5).Value.ToString()
            qtytxt.Text = selectedRow.Cells(6).Value.ToString()
            unitpricetxt.Text = selectedRow.Cells(7).Value.ToString()


            Dim sql As String = "SELECT product_id, product_name, category, product_quantity, quantity_instock, product_unit_price, last_restocked_date, expiration_date FROM product WHERE category_id = category AND category_id = @categoryId ORDER BY product_name LIMIT 1"
            Try
                Using conn As New MySqlConnection(strconn)
                    conn.Open()
                    Using cmd As New MySqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@categoryId", selectedCategoryId)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                productincategorydg.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2))
                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub


    Private Sub product_deletebutton_Click(sender As Object, e As EventArgs) Handles product_deletebutton.Click

    End Sub
End Class