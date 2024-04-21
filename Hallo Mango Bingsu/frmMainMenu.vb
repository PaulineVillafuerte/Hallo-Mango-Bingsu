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

    Private Sub dashboardbtn_Click(sender As Object, e As EventArgs) Handles dashboardbtn.Click
        For Each panel As Panel In {welcomepanel, dashboardpanel, categorypanel}
            panel.Visible = False
        Next
        dashboardpanel.Visible = True
        dashboardpanel.Visible = True
    End Sub

    Private Sub LoadCategory(sender As Object, e As EventArgs) Handles MyBase.Load 'FUNCTION TO LOAD DATA 
        LoadCategoryList()
    End Sub

    Private Sub LoadCategoryList()
        Dim sql As String = "Select * from product_category"
        Try
            categorytable.Rows.Clear()
            readquery(sql)
            With cmdread
                While .Read
                    categorytable.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2))
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
            categorytable.Rows.Clear()
            readquery(str)
            With cmdread
                While .Read
                    categorytable.Rows.Add(.GetValue(0), .GetValue(1), .GetValue(2))
                End While
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub category_addbtn_Click(sender As Object, e As EventArgs) Handles category_addbtn.Click
        Dim str As String = "INSERT INTO product_category(category_name, category_desc) VALUES ('" & categorynametxt.Text & "', '" & categorydesctxt.Text & "')"
        Try
            readquery(str)
            categorynametxt.Clear()
            categorydesctxt.Clear()
            MessageBox.Show("New category das been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadCategoryList()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


End Class