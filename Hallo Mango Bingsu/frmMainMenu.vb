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

    ' SHOWING TABS
    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        welcomepanel_Load()
    End Sub

    Public Sub welcomepanel_Load()
        For Each panel As Panel In {welcomepanel, dashboardpanel, categorypanel}
            panel.Visible = False
        Next
        welcomepanel.Visible = True
    End Sub

    Private Sub dashboardbtn_Click(sender As Object, e As EventArgs) Handles dashboardbtn.Click
        For Each panel As Panel In {welcomepanel, dashboardpanel, categorypanel}
            panel.Visible = False
        Next
        welcomepanel.Visible = True
        dashboardpanel.Visible = True
    End Sub

    Private Sub categorybtn_Click(sender As Object, e As EventArgs) Handles categorybtn.Click
        For Each panel As Panel In {welcomepanel, dashboardpanel, categorypanel}
            panel.Visible = False
        Next
        welcomepanel.Visible = True
        dashboardpanel.Visible = True
        categorypanel.Visible = True
    End Sub

End Class