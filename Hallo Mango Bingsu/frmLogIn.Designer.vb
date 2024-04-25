<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogIn))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        usernametxt = New TextBox()
        loginbtn = New Button()
        showpass = New CheckBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        passtxt = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(153, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(820, 700)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Gotham", 34.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(243), CByte(196), CByte(68))
        Label1.Location = New Point(457, 275)
        Label1.Name = "Label1"
        Label1.Size = New Size(240, 66)
        Label1.TabIndex = 4
        Label1.Text = "LOG IN"
        ' 
        ' usernametxt
        ' 
        usernametxt.BackColor = Color.Gainsboro
        usernametxt.BorderStyle = BorderStyle.None
        usernametxt.Font = New Font("Gotham", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        usernametxt.ForeColor = SystemColors.WindowFrame
        usernametxt.Location = New Point(437, 406)
        usernametxt.Name = "usernametxt"
        usernametxt.PlaceholderText = "Username"
        usernametxt.Size = New Size(350, 36)
        usernametxt.TabIndex = 10
        ' 
        ' loginbtn
        ' 
        loginbtn.BackColor = Color.FromArgb(CByte(243), CByte(196), CByte(68))
        loginbtn.FlatAppearance.BorderColor = Color.White
        loginbtn.FlatAppearance.BorderSize = 0
        loginbtn.FlatStyle = FlatStyle.Flat
        loginbtn.Font = New Font("Gotham", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        loginbtn.Location = New Point(503, 613)
        loginbtn.Name = "loginbtn"
        loginbtn.Size = New Size(160, 50)
        loginbtn.TabIndex = 13
        loginbtn.Text = "Log In"
        loginbtn.UseVisualStyleBackColor = False
        ' 
        ' showpass
        ' 
        showpass.AutoSize = True
        showpass.BackColor = Color.White
        showpass.Font = New Font("Gotham", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        showpass.Location = New Point(437, 510)
        showpass.Name = "showpass"
        showpass.Size = New Size(130, 19)
        showpass.TabIndex = 14
        showpass.Text = "Show Password"
        showpass.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(371, 402)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(40, 40)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 15
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.White
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(371, 464)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(40, 40)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 16
        PictureBox3.TabStop = False
        ' 
        ' passtxt
        ' 
        passtxt.BackColor = Color.Gainsboro
        passtxt.BorderStyle = BorderStyle.None
        passtxt.Font = New Font("Gotham", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        passtxt.ForeColor = SystemColors.WindowFrame
        passtxt.Location = New Point(437, 468)
        passtxt.Name = "passtxt"
        passtxt.PlaceholderText = "Password"
        passtxt.Size = New Size(350, 36)
        passtxt.TabIndex = 17
        passtxt.UseSystemPasswordChar = True
        ' 
        ' frmLogIn
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(196), CByte(68))
        ClientSize = New Size(1182, 753)
        Controls.Add(passtxt)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(showpass)
        Controls.Add(loginbtn)
        Controls.Add(usernametxt)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmLogIn"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hallo Mango Bingsu - Daet Inventory System"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents usernametxt As TextBox
    Friend WithEvents loginbtn As Button
    Friend WithEvents showpass As CheckBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents passtxt As TextBox

End Class
