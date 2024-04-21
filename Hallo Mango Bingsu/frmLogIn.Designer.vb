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
        TextBox1 = New TextBox()
        Button1 = New Button()
        CheckBox1 = New CheckBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        TextBox2 = New TextBox()
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
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Gainsboro
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Font = New Font("Gotham", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.ForeColor = SystemColors.WindowFrame
        TextBox1.Location = New Point(437, 406)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(350, 36)
        TextBox1.TabIndex = 10
        TextBox1.Text = "Username"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(243), CByte(196), CByte(68))
        Button1.FlatAppearance.BorderColor = Color.White
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Gotham", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(503, 613)
        Button1.Name = "Button1"
        Button1.Size = New Size(160, 50)
        Button1.TabIndex = 13
        Button1.Text = "Log In"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.White
        CheckBox1.Font = New Font("Gotham", 7.79999971F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBox1.Location = New Point(437, 510)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(130, 19)
        CheckBox1.TabIndex = 14
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = False
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
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.Gainsboro
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Font = New Font("Gotham", 19.7999973F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.ForeColor = SystemColors.WindowFrame
        TextBox2.Location = New Point(437, 468)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(350, 36)
        TextBox2.TabIndex = 17
        TextBox2.Text = "Password"
        ' 
        ' frmLogIn
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(243), CByte(196), CByte(68))
        ClientSize = New Size(1182, 753)
        Controls.Add(TextBox2)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(CheckBox1)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmLogIn"
        Text = "Hallo Mango Bingsu - Daet Inventory System"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox2 As TextBox

End Class
