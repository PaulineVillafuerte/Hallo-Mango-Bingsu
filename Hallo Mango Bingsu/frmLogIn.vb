Public Class frmLogIn
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim frmMainMenu As New frmMainMenu()

        Try
            If String.IsNullOrWhiteSpace(usernametxt.Text) AndAlso String.IsNullOrWhiteSpace(passtxt.Text) Then
                MessageBox.Show("Username and password is empty. Please try again.")
            ElseIf String.IsNullOrWhiteSpace(usernametxt.Text) Then
                MessageBox.Show("Username is empty. Please try again.")
            ElseIf String.IsNullOrWhiteSpace(passtxt.Text) Then
                MessageBox.Show("Password is empty. Please try again.")
            Else
                If usernametxt.Text.Trim = "superadmin" And passtxt.Text.Trim = "superadmin123" Then
                    usernametxt.Clear()
                    passtxt.Clear()
                    frmMainMenu.Show()
                    Me.Hide()
                ElseIf usernametxt.Text.Trim = "admin" And passtxt.Text.Trim = "admin123" Then
                    usernametxt.Clear()
                    passtxt.Clear()
                    frmMainMenu.Show()
                    Me.Hide()
                ElseIf usernametxt.Text.Trim = "staff" And passtxt.Text.Trim = "staff123" Then
                    usernametxt.Clear()
                    passtxt.Clear()
                    ' disable yung staff button
                    frmMainMenu.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Incorrect username or password. Please try again.")
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub showpass_CheckedChanged(sender As Object, e As EventArgs) Handles showpass.CheckedChanged
        If showpass.Checked Then
            passtxt.UseSystemPasswordChar = False
        Else
            passtxt.UseSystemPasswordChar = True
        End If

    End Sub
End Class
