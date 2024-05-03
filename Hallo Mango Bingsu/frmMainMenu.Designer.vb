<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Panel1 = New Panel()
        logoutbtn = New Button()
        Panel2 = New Panel()
        staffbtn = New Button()
        supplierbtn = New Button()
        menuitembtn = New Button()
        productbtn = New Button()
        categorybtn = New Button()
        dashboardbtn = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Panel3 = New Panel()
        Label10 = New Label()
        welcomepanel = New Panel()
        PictureBox2 = New PictureBox()
        welcomelabel = New Label()
        dashboardpanel = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        DataGridView3 = New DataGridView()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn6 = New DataGridViewTextBoxColumn()
        DataGridView2 = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Panel7 = New Panel()
        Label9 = New Label()
        Panel6 = New Panel()
        Label8 = New Label()
        Panel5 = New Panel()
        Label7 = New Label()
        Panel4 = New Panel()
        Label6 = New Label()
        categorypanel = New Panel()
        category_searchbtn = New Button()
        searchbox = New TextBox()
        Label11 = New Label()
        GroupBox2 = New GroupBox()
        category_updatebtn = New Button()
        category_deletebtn = New Button()
        categorydesctxt = New TextBox()
        Label16 = New Label()
        categorynametxt = New TextBox()
        Label15 = New Label()
        category_addbtn = New Button()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        productincategorydg = New DataGridView()
        DataGridViewTextBoxColumn7 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn8 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        categorylistdg = New DataGridView()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        productpanel1 = New Panel()
        GroupBox1 = New GroupBox()
        unitpricetxt = New TextBox()
        Label26 = New Label()
        expirationdatedtp = New DateTimePicker()
        Label25 = New Label()
        restockdatedtp = New DateTimePicker()
        Label24 = New Label()
        qtyinstocktxt = New TextBox()
        Label23 = New Label()
        qtytxt = New TextBox()
        Label22 = New Label()
        product_updatebtn = New Button()
        product_deletebutton = New Button()
        categorytxt = New TextBox()
        Label19 = New Label()
        productnametxt = New TextBox()
        Label20 = New Label()
        product_addbtn = New Button()
        Label21 = New Label()
        Label18 = New Label()
        productlistdg = New DataGridView()
        Column8 = New DataGridViewTextBoxColumn()
        Column15 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column13 = New DataGridViewTextBoxColumn()
        Column14 = New DataGridViewTextBoxColumn()
        Label17 = New Label()
        product_searchbtn = New Button()
        productsearchtxt = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        welcomepanel.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        dashboardpanel.SuspendLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        categorypanel.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(productincategorydg, ComponentModel.ISupportInitialize).BeginInit()
        CType(categorylistdg, ComponentModel.ISupportInitialize).BeginInit()
        productpanel1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(productlistdg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(243), CByte(196), CByte(68))
        Panel1.Controls.Add(logoutbtn)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(staffbtn)
        Panel1.Controls.Add(supplierbtn)
        Panel1.Controls.Add(menuitembtn)
        Panel1.Controls.Add(productbtn)
        Panel1.Controls.Add(categorybtn)
        Panel1.Controls.Add(dashboardbtn)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(350, 953)
        Panel1.TabIndex = 0
        ' 
        ' logoutbtn
        ' 
        logoutbtn.BackColor = Color.White
        logoutbtn.FlatAppearance.BorderColor = Color.White
        logoutbtn.FlatAppearance.BorderSize = 0
        logoutbtn.FlatStyle = FlatStyle.Flat
        logoutbtn.Font = New Font("Gotham", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        logoutbtn.Image = CType(resources.GetObject("logoutbtn.Image"), Image)
        logoutbtn.ImageAlign = ContentAlignment.MiddleLeft
        logoutbtn.Location = New Point(85, 869)
        logoutbtn.Name = "logoutbtn"
        logoutbtn.Padding = New Padding(10, 0, 0, 0)
        logoutbtn.Size = New Size(160, 50)
        logoutbtn.TabIndex = 14
        logoutbtn.Text = "Log Out"
        logoutbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        logoutbtn.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Location = New Point(0, 300)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(350, 3)
        Panel2.TabIndex = 1
        ' 
        ' staffbtn
        ' 
        staffbtn.BackColor = Color.FromArgb(CByte(243), CByte(196), CByte(68))
        staffbtn.FlatAppearance.BorderSize = 0
        staffbtn.FlatStyle = FlatStyle.Flat
        staffbtn.Font = New Font("Gotham", 16.2F, FontStyle.Bold)
        staffbtn.Image = CType(resources.GetObject("staffbtn.Image"), Image)
        staffbtn.ImageAlign = ContentAlignment.MiddleLeft
        staffbtn.Location = New Point(0, 703)
        staffbtn.Name = "staffbtn"
        staffbtn.Padding = New Padding(20, 0, 0, 0)
        staffbtn.Size = New Size(350, 80)
        staffbtn.TabIndex = 8
        staffbtn.Text = "Staff"
        staffbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        staffbtn.UseVisualStyleBackColor = False
        ' 
        ' supplierbtn
        ' 
        supplierbtn.BackColor = Color.FromArgb(CByte(243), CByte(196), CByte(68))
        supplierbtn.FlatAppearance.BorderSize = 0
        supplierbtn.FlatStyle = FlatStyle.Flat
        supplierbtn.Font = New Font("Gotham", 16.2F, FontStyle.Bold)
        supplierbtn.Image = CType(resources.GetObject("supplierbtn.Image"), Image)
        supplierbtn.ImageAlign = ContentAlignment.MiddleLeft
        supplierbtn.Location = New Point(0, 623)
        supplierbtn.Name = "supplierbtn"
        supplierbtn.Padding = New Padding(20, 0, 0, 0)
        supplierbtn.Size = New Size(350, 80)
        supplierbtn.TabIndex = 7
        supplierbtn.Text = "Supplier"
        supplierbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        supplierbtn.UseVisualStyleBackColor = False
        ' 
        ' menuitembtn
        ' 
        menuitembtn.BackColor = Color.FromArgb(CByte(243), CByte(196), CByte(68))
        menuitembtn.FlatAppearance.BorderSize = 0
        menuitembtn.FlatStyle = FlatStyle.Flat
        menuitembtn.Font = New Font("Gotham", 16.2F, FontStyle.Bold)
        menuitembtn.Image = CType(resources.GetObject("menuitembtn.Image"), Image)
        menuitembtn.ImageAlign = ContentAlignment.MiddleLeft
        menuitembtn.Location = New Point(0, 543)
        menuitembtn.Name = "menuitembtn"
        menuitembtn.Padding = New Padding(20, 0, 0, 0)
        menuitembtn.Size = New Size(350, 80)
        menuitembtn.TabIndex = 6
        menuitembtn.Text = "Menu Item"
        menuitembtn.TextImageRelation = TextImageRelation.ImageBeforeText
        menuitembtn.UseVisualStyleBackColor = False
        ' 
        ' productbtn
        ' 
        productbtn.BackColor = Color.FromArgb(CByte(243), CByte(196), CByte(68))
        productbtn.FlatAppearance.BorderSize = 0
        productbtn.FlatStyle = FlatStyle.Flat
        productbtn.Font = New Font("Gotham", 16.2F, FontStyle.Bold)
        productbtn.Image = CType(resources.GetObject("productbtn.Image"), Image)
        productbtn.ImageAlign = ContentAlignment.MiddleLeft
        productbtn.Location = New Point(0, 463)
        productbtn.Name = "productbtn"
        productbtn.Padding = New Padding(20, 0, 0, 0)
        productbtn.Size = New Size(350, 80)
        productbtn.TabIndex = 5
        productbtn.Text = "Product"
        productbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        productbtn.UseVisualStyleBackColor = False
        ' 
        ' categorybtn
        ' 
        categorybtn.BackColor = Color.FromArgb(CByte(243), CByte(196), CByte(68))
        categorybtn.FlatAppearance.BorderSize = 0
        categorybtn.FlatStyle = FlatStyle.Flat
        categorybtn.Font = New Font("Gotham", 16.2F, FontStyle.Bold)
        categorybtn.Image = CType(resources.GetObject("categorybtn.Image"), Image)
        categorybtn.ImageAlign = ContentAlignment.MiddleLeft
        categorybtn.Location = New Point(0, 383)
        categorybtn.Name = "categorybtn"
        categorybtn.Padding = New Padding(20, 0, 0, 0)
        categorybtn.Size = New Size(350, 80)
        categorybtn.TabIndex = 4
        categorybtn.Text = "Product Category"
        categorybtn.TextImageRelation = TextImageRelation.ImageBeforeText
        categorybtn.UseVisualStyleBackColor = False
        ' 
        ' dashboardbtn
        ' 
        dashboardbtn.BackColor = Color.FromArgb(CByte(243), CByte(196), CByte(68))
        dashboardbtn.FlatAppearance.BorderSize = 0
        dashboardbtn.FlatStyle = FlatStyle.Flat
        dashboardbtn.Font = New Font("Gotham", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dashboardbtn.Image = CType(resources.GetObject("dashboardbtn.Image"), Image)
        dashboardbtn.ImageAlign = ContentAlignment.MiddleLeft
        dashboardbtn.Location = New Point(0, 303)
        dashboardbtn.Name = "dashboardbtn"
        dashboardbtn.Padding = New Padding(20, 0, 0, 0)
        dashboardbtn.Size = New Size(350, 80)
        dashboardbtn.TabIndex = 1
        dashboardbtn.Text = "Dashboard"
        dashboardbtn.TextImageRelation = TextImageRelation.ImageBeforeText
        dashboardbtn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gotham", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(67, 240)
        Label1.Name = "Label1"
        Label1.Size = New Size(205, 37)
        Label1.TabIndex = 3
        Label1.Text = "Staff Name"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(67, 17)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 200)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Gotham", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(104, 217)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 26)
        Label2.TabIndex = 2
        Label2.Text = "Welcome!"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Black
        Panel3.Controls.Add(Label10)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(350, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1132, 70)
        Panel3.TabIndex = 1
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Gotham", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.White
        Label10.Location = New Point(920, 17)
        Label10.Name = "Label10"
        Label10.Size = New Size(200, 37)
        Label10.TabIndex = 1
        Label10.Text = "date | time"
        ' 
        ' welcomepanel
        ' 
        welcomepanel.Controls.Add(PictureBox2)
        welcomepanel.Controls.Add(welcomelabel)
        welcomepanel.ForeColor = Color.Black
        welcomepanel.Location = New Point(356, 76)
        welcomepanel.Name = "welcomepanel"
        welcomepanel.Size = New Size(1130, 870)
        welcomepanel.TabIndex = 1
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(338, 115)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(500, 500)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' welcomelabel
        ' 
        welcomelabel.AutoSize = True
        welcomelabel.Font = New Font("Gotham", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        welcomelabel.Location = New Point(176, 648)
        welcomelabel.Name = "welcomelabel"
        welcomelabel.Size = New Size(860, 45)
        welcomelabel.TabIndex = 0
        welcomelabel.Text = "Inventory Database Management System"
        ' 
        ' dashboardpanel
        ' 
        dashboardpanel.Controls.Add(productpanel1)
        dashboardpanel.Controls.Add(categorypanel)
        dashboardpanel.Controls.Add(Label5)
        dashboardpanel.Controls.Add(Label4)
        dashboardpanel.Controls.Add(Label3)
        dashboardpanel.Controls.Add(DataGridView3)
        dashboardpanel.Controls.Add(DataGridView2)
        dashboardpanel.Controls.Add(DataGridView1)
        dashboardpanel.Controls.Add(Panel7)
        dashboardpanel.Controls.Add(Panel6)
        dashboardpanel.Controls.Add(Panel5)
        dashboardpanel.Controls.Add(Panel4)
        dashboardpanel.Location = New Point(356, 76)
        dashboardpanel.Name = "dashboardpanel"
        dashboardpanel.Size = New Size(1130, 883)
        dashboardpanel.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Black
        Label5.Font = New Font("Gotham", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(750, 337)
        Label5.Margin = New Padding(2)
        Label5.Name = "Label5"
        Label5.Padding = New Padding(94, 10, 94, 10)
        Label5.Size = New Size(350, 43)
        Label5.TabIndex = 9
        Label5.Text = "Dili ko pa alam"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Black
        Label4.Font = New Font("Gotham", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(389, 337)
        Label4.Margin = New Padding(2)
        Label4.Name = "Label4"
        Label4.Padding = New Padding(96, 10, 95, 10)
        Label4.Size = New Size(350, 43)
        Label4.TabIndex = 8
        Label4.Text = "Soon to Expire"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Black
        Label3.Font = New Font("Gotham", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(29, 337)
        Label3.Margin = New Padding(2)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(88, 10, 87, 10)
        Label3.Size = New Size(350, 43)
        Label3.TabIndex = 7
        Label3.Text = "Low Stock Level"
        ' 
        ' DataGridView3
        ' 
        DataGridView3.AllowUserToAddRows = False
        DataGridView3.AllowUserToDeleteRows = False
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5, DataGridViewTextBoxColumn6})
        DataGridView3.Location = New Point(750, 380)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.ReadOnly = True
        DataGridView3.RowHeadersVisible = False
        DataGridView3.RowHeadersWidth = 51
        DataGridView3.Size = New Size(350, 450)
        DataGridView3.TabIndex = 6
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn4.FillWeight = 98.9899F
        DataGridViewTextBoxColumn4.HeaderText = "ID"
        DataGridViewTextBoxColumn4.MinimumWidth = 6
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        DataGridViewTextBoxColumn4.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn5
        ' 
        DataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn5.FillWeight = 101.264534F
        DataGridViewTextBoxColumn5.HeaderText = "Product Name"
        DataGridViewTextBoxColumn5.MinimumWidth = 6
        DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        DataGridViewTextBoxColumn5.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn6
        ' 
        DataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn6.FillWeight = 99.74557F
        DataGridViewTextBoxColumn6.HeaderText = "Expiration Date"
        DataGridViewTextBoxColumn6.MinimumWidth = 6
        DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        DataGridViewTextBoxColumn6.ReadOnly = True
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3})
        DataGridView2.Location = New Point(389, 380)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowHeadersVisible = False
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(350, 450)
        DataGridView2.TabIndex = 5
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn1.FillWeight = 98.9899F
        DataGridViewTextBoxColumn1.HeaderText = "ID"
        DataGridViewTextBoxColumn1.MinimumWidth = 6
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn2.FillWeight = 101.264534F
        DataGridViewTextBoxColumn2.HeaderText = "Product Name"
        DataGridViewTextBoxColumn2.MinimumWidth = 6
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn3.FillWeight = 99.74557F
        DataGridViewTextBoxColumn3.HeaderText = "Expiration Date"
        DataGridViewTextBoxColumn3.MinimumWidth = 6
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.ReadOnly = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        DataGridView1.Location = New Point(29, 380)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(350, 450)
        DataGridView1.TabIndex = 4
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.FillWeight = 98.9899F
        Column1.HeaderText = "ID"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column2.FillWeight = 101.264534F
        Column2.HeaderText = "Product Name"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.FillWeight = 99.74557F
        Column3.HeaderText = "Quantity In Stock"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(48), CByte(76), CByte(153))
        Panel7.Controls.Add(Label9)
        Panel7.Location = New Point(850, 52)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(250, 250)
        Panel7.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Gotham", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(59, 34)
        Label9.Name = "Label9"
        Label9.Size = New Size(137, 26)
        Label9.TabIndex = 3
        Label9.Text = "Total Staff"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(139), CByte(47), CByte(153))
        Panel6.Controls.Add(Label8)
        Panel6.Location = New Point(578, 52)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(250, 250)
        Panel6.TabIndex = 2
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Gotham", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(19, 34)
        Label8.Name = "Label8"
        Label8.Size = New Size(215, 26)
        Label8.TabIndex = 2
        Label8.Text = "Total Menu Items"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(237), CByte(152), CByte(84))
        Panel5.Controls.Add(Label7)
        Panel5.Location = New Point(304, 52)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(250, 250)
        Panel5.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Gotham", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(34, 34)
        Label7.Name = "Label7"
        Label7.Size = New Size(185, 26)
        Label7.TabIndex = 1
        Label7.Text = "Total Products"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(72), CByte(163), CByte(165))
        Panel4.Controls.Add(Label6)
        Panel4.Location = New Point(29, 52)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(250, 250)
        Panel4.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Gotham", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(23, 34)
        Label6.Name = "Label6"
        Label6.Size = New Size(209, 26)
        Label6.TabIndex = 0
        Label6.Text = "Total Categories"
        ' 
        ' categorypanel
        ' 
        categorypanel.BackColor = SystemColors.Control
        categorypanel.Controls.Add(category_searchbtn)
        categorypanel.Controls.Add(searchbox)
        categorypanel.Controls.Add(Label11)
        categorypanel.Controls.Add(GroupBox2)
        categorypanel.Controls.Add(Label13)
        categorypanel.Controls.Add(Label12)
        categorypanel.Controls.Add(productincategorydg)
        categorypanel.Controls.Add(categorylistdg)
        categorypanel.Location = New Point(16, 12)
        categorypanel.Name = "categorypanel"
        categorypanel.Size = New Size(1130, 883)
        categorypanel.TabIndex = 3
        ' 
        ' category_searchbtn
        ' 
        category_searchbtn.BackColor = SystemColors.Window
        category_searchbtn.FlatAppearance.BorderSize = 0
        category_searchbtn.FlatStyle = FlatStyle.Flat
        category_searchbtn.Image = CType(resources.GetObject("category_searchbtn.Image"), Image)
        category_searchbtn.ImageAlign = ContentAlignment.MiddleRight
        category_searchbtn.Location = New Point(1057, 38)
        category_searchbtn.Name = "category_searchbtn"
        category_searchbtn.Size = New Size(25, 25)
        category_searchbtn.TabIndex = 7
        category_searchbtn.TextImageRelation = TextImageRelation.TextBeforeImage
        category_searchbtn.UseVisualStyleBackColor = False
        ' 
        ' searchbox
        ' 
        searchbox.BorderStyle = BorderStyle.FixedSingle
        searchbox.Font = New Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        searchbox.ForeColor = Color.DimGray
        searchbox.Location = New Point(497, 35)
        searchbox.Name = "searchbox"
        searchbox.PlaceholderText = "Search"
        searchbox.Size = New Size(600, 29)
        searchbox.TabIndex = 9
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Gotham", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.FromArgb(CByte(243), CByte(196), CByte(68))
        Label11.Location = New Point(42, 22)
        Label11.Name = "Label11"
        Label11.Size = New Size(352, 42)
        Label11.TabIndex = 8
        Label11.Text = "Product Category"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(category_updatebtn)
        GroupBox2.Controls.Add(category_deletebtn)
        GroupBox2.Controls.Add(categorydesctxt)
        GroupBox2.Controls.Add(Label16)
        GroupBox2.Controls.Add(categorynametxt)
        GroupBox2.Controls.Add(Label15)
        GroupBox2.Controls.Add(category_addbtn)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.FlatStyle = FlatStyle.Flat
        GroupBox2.Location = New Point(42, 559)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1055, 278)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        ' 
        ' category_updatebtn
        ' 
        category_updatebtn.BackColor = Color.FromArgb(CByte(243), CByte(196), CByte(68))
        category_updatebtn.FlatAppearance.BorderSize = 0
        category_updatebtn.FlatStyle = FlatStyle.Flat
        category_updatebtn.Font = New Font("Gotham", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        category_updatebtn.ForeColor = Color.White
        category_updatebtn.Location = New Point(409, 212)
        category_updatebtn.Name = "category_updatebtn"
        category_updatebtn.Size = New Size(220, 40)
        category_updatebtn.TabIndex = 7
        category_updatebtn.Text = "UPDATE"
        category_updatebtn.UseVisualStyleBackColor = False
        ' 
        ' category_deletebtn
        ' 
        category_deletebtn.BackColor = Color.FromArgb(CByte(243), CByte(196), CByte(68))
        category_deletebtn.FlatAppearance.BorderSize = 0
        category_deletebtn.FlatStyle = FlatStyle.Flat
        category_deletebtn.Font = New Font("Gotham", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        category_deletebtn.ForeColor = Color.White
        category_deletebtn.Location = New Point(649, 212)
        category_deletebtn.Name = "category_deletebtn"
        category_deletebtn.Size = New Size(220, 40)
        category_deletebtn.TabIndex = 6
        category_deletebtn.Text = "DELETE"
        category_deletebtn.UseVisualStyleBackColor = False
        ' 
        ' categorydesctxt
        ' 
        categorydesctxt.BackColor = Color.WhiteSmoke
        categorydesctxt.BorderStyle = BorderStyle.FixedSingle
        categorydesctxt.Font = New Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        categorydesctxt.Location = New Point(369, 145)
        categorydesctxt.Name = "categorydesctxt"
        categorydesctxt.Size = New Size(500, 29)
        categorydesctxt.TabIndex = 5
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(170, 151)
        Label16.Name = "Label16"
        Label16.Size = New Size(123, 23)
        Label16.TabIndex = 4
        Label16.Text = "Description"
        ' 
        ' categorynametxt
        ' 
        categorynametxt.BackColor = Color.WhiteSmoke
        categorynametxt.BorderStyle = BorderStyle.FixedSingle
        categorynametxt.Font = New Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        categorynametxt.Location = New Point(369, 96)
        categorynametxt.Name = "categorynametxt"
        categorynametxt.Size = New Size(500, 29)
        categorynametxt.TabIndex = 3
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(170, 102)
        Label15.Name = "Label15"
        Label15.Size = New Size(168, 23)
        Label15.TabIndex = 2
        Label15.Text = "Category Name"
        ' 
        ' category_addbtn
        ' 
        category_addbtn.BackColor = Color.FromArgb(CByte(243), CByte(196), CByte(68))
        category_addbtn.FlatAppearance.BorderSize = 0
        category_addbtn.FlatStyle = FlatStyle.Flat
        category_addbtn.Font = New Font("Gotham", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        category_addbtn.ForeColor = Color.White
        category_addbtn.Location = New Point(170, 212)
        category_addbtn.Name = "category_addbtn"
        category_addbtn.Size = New Size(220, 40)
        category_addbtn.TabIndex = 1
        category_addbtn.Text = "ADD"
        category_addbtn.UseVisualStyleBackColor = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Gotham", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(33, 30)
        Label14.Name = "Label14"
        Label14.Size = New Size(267, 32)
        Label14.TabIndex = 0
        Label14.Text = "Manage Category"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Black
        Label13.Font = New Font("Gotham", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.White
        Label13.Location = New Point(697, 101)
        Label13.Name = "Label13"
        Label13.Padding = New Padding(69, 5, 69, 5)
        Label13.Size = New Size(400, 36)
        Label13.TabIndex = 5
        Label13.Text = "Products in Category"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.BackColor = Color.Black
        Label12.Font = New Font("Gotham", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.White
        Label12.Location = New Point(42, 101)
        Label12.Name = "Label12"
        Label12.Padding = New Padding(164, 5, 164, 5)
        Label12.Size = New Size(600, 36)
        Label12.TabIndex = 4
        Label12.Text = "Product Category List"
        ' 
        ' productincategorydg
        ' 
        productincategorydg.AllowUserToAddRows = False
        productincategorydg.AllowUserToDeleteRows = False
        productincategorydg.BackgroundColor = Color.White
        productincategorydg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        productincategorydg.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn7, DataGridViewTextBoxColumn8, Column7})
        productincategorydg.Location = New Point(697, 137)
        productincategorydg.Name = "productincategorydg"
        productincategorydg.ReadOnly = True
        productincategorydg.RowHeadersVisible = False
        productincategorydg.RowHeadersWidth = 51
        productincategorydg.Size = New Size(400, 400)
        productincategorydg.TabIndex = 3
        ' 
        ' DataGridViewTextBoxColumn7
        ' 
        DataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewTextBoxColumn7.HeaderText = "ID"
        DataGridViewTextBoxColumn7.MinimumWidth = 6
        DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        DataGridViewTextBoxColumn7.ReadOnly = True
        DataGridViewTextBoxColumn7.Width = 53
        ' 
        ' DataGridViewTextBoxColumn8
        ' 
        DataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn8.HeaderText = "Product Name"
        DataGridViewTextBoxColumn8.MinimumWidth = 6
        DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        DataGridViewTextBoxColumn8.ReadOnly = True
        ' 
        ' Column7
        ' 
        Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column7.HeaderText = "Quantity In Stock"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        ' 
        ' categorylistdg
        ' 
        categorylistdg.AllowUserToAddRows = False
        categorylistdg.AllowUserToDeleteRows = False
        categorylistdg.AllowUserToResizeRows = False
        categorylistdg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        categorylistdg.BackgroundColor = Color.White
        categorylistdg.ColumnHeadersHeight = 29
        categorylistdg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        categorylistdg.Columns.AddRange(New DataGridViewColumn() {Column4, Column5, Column6})
        categorylistdg.Location = New Point(42, 137)
        categorylistdg.Name = "categorylistdg"
        categorylistdg.RowHeadersVisible = False
        categorylistdg.RowHeadersWidth = 51
        categorylistdg.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        categorylistdg.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        categorylistdg.Size = New Size(600, 400)
        categorylistdg.TabIndex = 0
        ' 
        ' Column4
        ' 
        Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column4.HeaderText = "ID"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column5.HeaderText = "Category Name"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' Column6
        ' 
        Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column6.HeaderText = "Description"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        ' 
        ' productpanel1
        ' 
        productpanel1.Controls.Add(GroupBox1)
        productpanel1.Controls.Add(Label18)
        productpanel1.Controls.Add(productlistdg)
        productpanel1.Controls.Add(Label17)
        productpanel1.Controls.Add(product_searchbtn)
        productpanel1.Controls.Add(productsearchtxt)
        productpanel1.Location = New Point(10, 15)
        productpanel1.Name = "productpanel1"
        productpanel1.Size = New Size(1120, 883)
        productpanel1.TabIndex = 4
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(unitpricetxt)
        GroupBox1.Controls.Add(Label26)
        GroupBox1.Controls.Add(expirationdatedtp)
        GroupBox1.Controls.Add(Label25)
        GroupBox1.Controls.Add(restockdatedtp)
        GroupBox1.Controls.Add(Label24)
        GroupBox1.Controls.Add(qtyinstocktxt)
        GroupBox1.Controls.Add(Label23)
        GroupBox1.Controls.Add(qtytxt)
        GroupBox1.Controls.Add(Label22)
        GroupBox1.Controls.Add(product_updatebtn)
        GroupBox1.Controls.Add(product_deletebutton)
        GroupBox1.Controls.Add(categorytxt)
        GroupBox1.Controls.Add(Label19)
        GroupBox1.Controls.Add(productnametxt)
        GroupBox1.Controls.Add(Label20)
        GroupBox1.Controls.Add(product_addbtn)
        GroupBox1.Controls.Add(Label21)
        GroupBox1.FlatStyle = FlatStyle.Flat
        GroupBox1.Location = New Point(42, 467)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1055, 376)
        GroupBox1.TabIndex = 15
        GroupBox1.TabStop = False
        ' 
        ' unitpricetxt
        ' 
        unitpricetxt.BackColor = Color.WhiteSmoke
        unitpricetxt.BorderStyle = BorderStyle.FixedSingle
        unitpricetxt.Font = New Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        unitpricetxt.Location = New Point(727, 198)
        unitpricetxt.Name = "unitpricetxt"
        unitpricetxt.Size = New Size(300, 29)
        unitpricetxt.TabIndex = 20
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label26.Location = New Point(555, 204)
        Label26.Name = "Label26"
        Label26.Size = New Size(105, 23)
        Label26.TabIndex = 19
        Label26.Text = "Unit Price"
        ' 
        ' expirationdatedtp
        ' 
        expirationdatedtp.Location = New Point(727, 152)
        expirationdatedtp.Name = "expirationdatedtp"
        expirationdatedtp.Size = New Size(300, 27)
        expirationdatedtp.TabIndex = 18
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label25.Location = New Point(554, 154)
        Label25.Name = "Label25"
        Label25.Size = New Size(164, 23)
        Label25.TabIndex = 17
        Label25.Text = "Expiration Date"
        ' 
        ' restockdatedtp
        ' 
        restockdatedtp.Location = New Point(727, 103)
        restockdatedtp.Name = "restockdatedtp"
        restockdatedtp.Size = New Size(300, 27)
        restockdatedtp.TabIndex = 16
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(554, 105)
        Label24.Name = "Label24"
        Label24.Size = New Size(143, 23)
        Label24.TabIndex = 12
        Label24.Text = "Restock Date"
        ' 
        ' qtyinstocktxt
        ' 
        qtyinstocktxt.BackColor = Color.WhiteSmoke
        qtyinstocktxt.BorderStyle = BorderStyle.FixedSingle
        qtyinstocktxt.Font = New Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        qtyinstocktxt.Location = New Point(221, 246)
        qtyinstocktxt.Name = "qtyinstocktxt"
        qtyinstocktxt.Size = New Size(300, 29)
        qtyinstocktxt.TabIndex = 11
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(27, 252)
        Label23.Name = "Label23"
        Label23.Size = New Size(182, 23)
        Label23.TabIndex = 10
        Label23.Text = "Quantity In Stock"
        ' 
        ' qtytxt
        ' 
        qtytxt.BackColor = Color.WhiteSmoke
        qtytxt.BorderStyle = BorderStyle.FixedSingle
        qtytxt.Font = New Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        qtytxt.Location = New Point(221, 198)
        qtytxt.Name = "qtytxt"
        qtytxt.Size = New Size(300, 29)
        qtytxt.TabIndex = 9
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(28, 204)
        Label22.Name = "Label22"
        Label22.Size = New Size(96, 23)
        Label22.TabIndex = 8
        Label22.Text = "Quantity"
        ' 
        ' product_updatebtn
        ' 
        product_updatebtn.BackColor = Color.FromArgb(CByte(243), CByte(196), CByte(68))
        product_updatebtn.FlatAppearance.BorderSize = 0
        product_updatebtn.FlatStyle = FlatStyle.Flat
        product_updatebtn.Font = New Font("Gotham", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        product_updatebtn.ForeColor = Color.White
        product_updatebtn.Location = New Point(423, 313)
        product_updatebtn.Name = "product_updatebtn"
        product_updatebtn.Size = New Size(220, 40)
        product_updatebtn.TabIndex = 7
        product_updatebtn.Text = "UPDATE"
        product_updatebtn.UseVisualStyleBackColor = False
        ' 
        ' product_deletebutton
        ' 
        product_deletebutton.BackColor = Color.FromArgb(CByte(243), CByte(196), CByte(68))
        product_deletebutton.FlatAppearance.BorderSize = 0
        product_deletebutton.FlatStyle = FlatStyle.Flat
        product_deletebutton.Font = New Font("Gotham", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        product_deletebutton.ForeColor = Color.White
        product_deletebutton.Location = New Point(663, 313)
        product_deletebutton.Name = "product_deletebutton"
        product_deletebutton.Size = New Size(220, 40)
        product_deletebutton.TabIndex = 6
        product_deletebutton.Text = "DELETE"
        product_deletebutton.UseVisualStyleBackColor = False
        ' 
        ' categorytxt
        ' 
        categorytxt.BackColor = Color.WhiteSmoke
        categorytxt.BorderStyle = BorderStyle.FixedSingle
        categorytxt.Font = New Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        categorytxt.Location = New Point(221, 148)
        categorytxt.Name = "categorytxt"
        categorytxt.Size = New Size(300, 29)
        categorytxt.TabIndex = 5
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(27, 154)
        Label19.Name = "Label19"
        Label19.Size = New Size(103, 23)
        Label19.TabIndex = 4
        Label19.Text = "Category"
        ' 
        ' productnametxt
        ' 
        productnametxt.BackColor = Color.WhiteSmoke
        productnametxt.BorderStyle = BorderStyle.FixedSingle
        productnametxt.Font = New Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        productnametxt.Location = New Point(221, 103)
        productnametxt.Name = "productnametxt"
        productnametxt.Size = New Size(300, 29)
        productnametxt.TabIndex = 3
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(27, 109)
        Label20.Name = "Label20"
        Label20.Size = New Size(153, 23)
        Label20.TabIndex = 2
        Label20.Text = "Product Name"
        ' 
        ' product_addbtn
        ' 
        product_addbtn.BackColor = Color.FromArgb(CByte(243), CByte(196), CByte(68))
        product_addbtn.FlatAppearance.BorderSize = 0
        product_addbtn.FlatStyle = FlatStyle.Flat
        product_addbtn.Font = New Font("Gotham", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        product_addbtn.ForeColor = Color.White
        product_addbtn.Location = New Point(184, 313)
        product_addbtn.Name = "product_addbtn"
        product_addbtn.Size = New Size(220, 40)
        product_addbtn.TabIndex = 1
        product_addbtn.Text = "ADD"
        product_addbtn.UseVisualStyleBackColor = False
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Gotham", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(23, 38)
        Label21.Name = "Label21"
        Label21.Size = New Size(247, 32)
        Label21.TabIndex = 0
        Label21.Text = "Manage Product"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.BackColor = Color.Black
        Label18.Font = New Font("Gotham", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.ForeColor = Color.White
        Label18.Location = New Point(42, 105)
        Label18.Name = "Label18"
        Label18.Padding = New Padding(450, 5, 450, 5)
        Label18.Size = New Size(1055, 36)
        Label18.TabIndex = 14
        Label18.Text = "Product List"
        ' 
        ' productlistdg
        ' 
        productlistdg.AllowUserToAddRows = False
        productlistdg.AllowUserToDeleteRows = False
        productlistdg.BackgroundColor = Color.White
        productlistdg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        productlistdg.Columns.AddRange(New DataGridViewColumn() {Column8, Column15, Column9, Column10, Column11, Column12, Column13, Column14})
        productlistdg.Location = New Point(42, 141)
        productlistdg.Name = "productlistdg"
        productlistdg.ReadOnly = True
        productlistdg.RowHeadersVisible = False
        productlistdg.RowHeadersWidth = 51
        productlistdg.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        productlistdg.Size = New Size(1055, 300)
        productlistdg.TabIndex = 13
        ' 
        ' Column8
        ' 
        Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column8.HeaderText = "ID"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 53
        ' 
        ' Column15
        ' 
        Column15.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column15.HeaderText = "Category"
        Column15.MinimumWidth = 6
        Column15.Name = "Column15"
        Column15.ReadOnly = True
        ' 
        ' Column9
        ' 
        Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column9.HeaderText = "Product Name"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        ' 
        ' Column10
        ' 
        Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column10.HeaderText = "Quantity"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        ' 
        ' Column11
        ' 
        Column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column11.HeaderText = "Unit Price"
        Column11.MinimumWidth = 6
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        ' 
        ' Column12
        ' 
        Column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column12.HeaderText = "Quantity In Stock"
        Column12.MinimumWidth = 6
        Column12.Name = "Column12"
        Column12.ReadOnly = True
        ' 
        ' Column13
        ' 
        Column13.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column13.HeaderText = "Restocked Date"
        Column13.MinimumWidth = 6
        Column13.Name = "Column13"
        Column13.ReadOnly = True
        ' 
        ' Column14
        ' 
        Column14.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column14.HeaderText = "Expiration Date"
        Column14.MinimumWidth = 6
        Column14.Name = "Column14"
        Column14.ReadOnly = True
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Gotham", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.ForeColor = Color.FromArgb(CByte(243), CByte(196), CByte(68))
        Label17.Location = New Point(33, 28)
        Label17.Name = "Label17"
        Label17.Size = New Size(167, 42)
        Label17.TabIndex = 12
        Label17.Text = "Product"
        ' 
        ' product_searchbtn
        ' 
        product_searchbtn.BackColor = SystemColors.Window
        product_searchbtn.FlatAppearance.BorderSize = 0
        product_searchbtn.FlatStyle = FlatStyle.Flat
        product_searchbtn.Image = CType(resources.GetObject("product_searchbtn.Image"), Image)
        product_searchbtn.ImageAlign = ContentAlignment.MiddleRight
        product_searchbtn.Location = New Point(1056, 40)
        product_searchbtn.Name = "product_searchbtn"
        product_searchbtn.Size = New Size(25, 25)
        product_searchbtn.TabIndex = 10
        product_searchbtn.TextImageRelation = TextImageRelation.TextBeforeImage
        product_searchbtn.UseVisualStyleBackColor = False
        ' 
        ' productsearchtxt
        ' 
        productsearchtxt.BorderStyle = BorderStyle.FixedSingle
        productsearchtxt.Font = New Font("Gotham", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        productsearchtxt.ForeColor = Color.DimGray
        productsearchtxt.Location = New Point(496, 37)
        productsearchtxt.Name = "productsearchtxt"
        productsearchtxt.PlaceholderText = "Search"
        productsearchtxt.Size = New Size(600, 29)
        productsearchtxt.TabIndex = 11
        ' 
        ' frmMainMenu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1482, 953)
        Controls.Add(dashboardpanel)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(welcomepanel)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmMainMenu"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Main Menu"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        welcomepanel.ResumeLayout(False)
        welcomepanel.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        dashboardpanel.ResumeLayout(False)
        dashboardpanel.PerformLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        categorypanel.ResumeLayout(False)
        categorypanel.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(productincategorydg, ComponentModel.ISupportInitialize).EndInit()
        CType(categorylistdg, ComponentModel.ISupportInitialize).EndInit()
        productpanel1.ResumeLayout(False)
        productpanel1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(productlistdg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dashboardbtn As Button
    Friend WithEvents categorybtn As Button
    Friend WithEvents staffbtn As Button
    Friend WithEvents supplierbtn As Button
    Friend WithEvents menuitembtn As Button
    Friend WithEvents productbtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents logoutbtn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dashboardpanel As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents welcomepanel As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents welcomelabel As Label
    Friend WithEvents categorypanel As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents categorylistdg As DataGridView
    Friend WithEvents categorytxt As TextBox
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents productincategorydg As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents category_addbtn As Button
    Friend WithEvents categorynametxt As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents category_updatebtn As Button
    Friend WithEvents category_deletebtn As Button
    Friend WithEvents categorydesctxt As TextBox
    Friend WithEvents category_searchbtn As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents searchbox As TextBox
    Friend WithEvents productpanel1 As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents product_searchbtn As Button
    Friend WithEvents productsearchtxt As TextBox
    Friend WithEvents productlistdg As DataGridView
    Friend WithEvents product_updatebtn As Button
    Friend WithEvents product_deletebutton As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents productnametxt As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents product_addbtn As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents qtyinstocktxt As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents qtytxt As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents expirationdatedtp As DateTimePicker
    Friend WithEvents Label25 As Label
    Friend WithEvents restockdatedtp As DateTimePicker
    Friend WithEvents unitpricetxt As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
