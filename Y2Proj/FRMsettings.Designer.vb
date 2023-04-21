<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMsettings
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
        Me.components = New System.ComponentModel.Container()
        Me.TBCmain = New System.Windows.Forms.TabControl()
        Me.TBPUserDetails = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LBLAddress = New System.Windows.Forms.Label()
        Me.TXTAddress = New System.Windows.Forms.TextBox()
        Me.LBLEmail = New System.Windows.Forms.Label()
        Me.TXTEmail = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBLNextOfKinName = New System.Windows.Forms.Label()
        Me.LBLNextOfKinContactInfo = New System.Windows.Forms.Label()
        Me.TXTNextOfKinContactINfo = New System.Windows.Forms.TextBox()
        Me.TXTNextOfKinName = New System.Windows.Forms.TextBox()
        Me.PNLUserContainer = New System.Windows.Forms.Panel()
        Me.BTNShowPassword = New System.Windows.Forms.Button()
        Me.LBLPassword = New System.Windows.Forms.Label()
        Me.LBLUsername = New System.Windows.Forms.Label()
        Me.TXTUsername = New System.Windows.Forms.TextBox()
        Me.LBLFullName = New System.Windows.Forms.Label()
        Me.TXTFullName = New System.Windows.Forms.TextBox()
        Me.TXTPassword = New System.Windows.Forms.TextBox()
        Me.BTNAmend = New System.Windows.Forms.Button()
        Me.TBPTillOptions = New System.Windows.Forms.TabPage()
        Me.BTNsaveOptions = New System.Windows.Forms.Button()
        Me.DGVTillOptions = New System.Windows.Forms.DataGridView()
        Me.CLMItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLMRow = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLMColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNLoptionContainer = New System.Windows.Forms.Panel()
        Me.LBOptions = New System.Windows.Forms.ListBox()
        Me.LBLlistBoxDescription = New System.Windows.Forms.Label()
        Me.TBPSidebarOptions = New System.Windows.Forms.TabPage()
        Me.BTNSaveSidebarOptions = New System.Windows.Forms.Button()
        Me.PNLSidebarDisplay = New System.Windows.Forms.Panel()
        Me.LBLOptionSeven = New System.Windows.Forms.Label()
        Me.LBLOptionSix = New System.Windows.Forms.Label()
        Me.LBLOptionFive = New System.Windows.Forms.Label()
        Me.LBLOptionFour = New System.Windows.Forms.Label()
        Me.LBLOptionThree = New System.Windows.Forms.Label()
        Me.LBLOptionTwo = New System.Windows.Forms.Label()
        Me.LBLOptionOne = New System.Windows.Forms.Label()
        Me.PCBOptionSeven = New System.Windows.Forms.PictureBox()
        Me.PCBOptionSix = New System.Windows.Forms.PictureBox()
        Me.PCBOptionFive = New System.Windows.Forms.PictureBox()
        Me.PCBOptionFour = New System.Windows.Forms.PictureBox()
        Me.PCBOptionThree = New System.Windows.Forms.PictureBox()
        Me.PCBOptionTwo = New System.Windows.Forms.PictureBox()
        Me.PCBOptionOne = New System.Windows.Forms.PictureBox()
        Me.PCBIcon = New System.Windows.Forms.PictureBox()
        Me.LBLIcon = New System.Windows.Forms.Label()
        Me.DGVSidebarOptions = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNLSidebarOptions = New System.Windows.Forms.Panel()
        Me.LBSidebarOptions = New System.Windows.Forms.ListBox()
        Me.LBLOptions = New System.Windows.Forms.Label()
        Me.BSSettings = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBDataSet = New Y2Proj.DBDataSet()
        Me.SettingsTableAdapter = New Y2Proj.DBDataSetTableAdapters.SettingsTableAdapter()
        Me.BSUsers = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New Y2Proj.DBDataSetTableAdapters.UsersTableAdapter()
        Me.TMRPassword = New System.Windows.Forms.Timer(Me.components)
        Me.TBCmain.SuspendLayout()
        Me.TBPUserDetails.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PNLUserContainer.SuspendLayout()
        Me.TBPTillOptions.SuspendLayout()
        CType(Me.DGVTillOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNLoptionContainer.SuspendLayout()
        Me.TBPSidebarOptions.SuspendLayout()
        Me.PNLSidebarDisplay.SuspendLayout()
        CType(Me.PCBOptionSeven, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCBOptionSix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCBOptionFive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCBOptionFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCBOptionThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCBOptionTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCBOptionOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCBIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVSidebarOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNLSidebarOptions.SuspendLayout()
        CType(Me.BSSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBCmain
        '
        Me.TBCmain.Controls.Add(Me.TBPUserDetails)
        Me.TBCmain.Controls.Add(Me.TBPTillOptions)
        Me.TBCmain.Controls.Add(Me.TBPSidebarOptions)
        Me.TBCmain.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCmain.Location = New System.Drawing.Point(50, 50)
        Me.TBCmain.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBCmain.Name = "TBCmain"
        Me.TBCmain.SelectedIndex = 0
        Me.TBCmain.Size = New System.Drawing.Size(1447, 770)
        Me.TBCmain.TabIndex = 0
        '
        'TBPUserDetails
        '
        Me.TBPUserDetails.BackColor = System.Drawing.Color.LimeGreen
        Me.TBPUserDetails.Controls.Add(Me.Panel2)
        Me.TBPUserDetails.Controls.Add(Me.Panel1)
        Me.TBPUserDetails.Controls.Add(Me.PNLUserContainer)
        Me.TBPUserDetails.Controls.Add(Me.BTNAmend)
        Me.TBPUserDetails.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPUserDetails.Location = New System.Drawing.Point(4, 32)
        Me.TBPUserDetails.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBPUserDetails.Name = "TBPUserDetails"
        Me.TBPUserDetails.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBPUserDetails.Size = New System.Drawing.Size(1439, 734)
        Me.TBPUserDetails.TabIndex = 0
        Me.TBPUserDetails.Text = "User Details"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel2.Controls.Add(Me.LBLAddress)
        Me.Panel2.Controls.Add(Me.TXTAddress)
        Me.Panel2.Controls.Add(Me.LBLEmail)
        Me.Panel2.Controls.Add(Me.TXTEmail)
        Me.Panel2.Location = New System.Drawing.Point(693, 32)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(391, 212)
        Me.Panel2.TabIndex = 19
        '
        'LBLAddress
        '
        Me.LBLAddress.AutoSize = True
        Me.LBLAddress.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLAddress.Location = New System.Drawing.Point(159, 19)
        Me.LBLAddress.Name = "LBLAddress"
        Me.LBLAddress.Size = New System.Drawing.Size(96, 29)
        Me.LBLAddress.TabIndex = 12
        Me.LBLAddress.Text = "Address"
        '
        'TXTAddress
        '
        Me.TXTAddress.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTAddress.Location = New System.Drawing.Point(34, 52)
        Me.TXTAddress.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTAddress.Name = "TXTAddress"
        Me.TXTAddress.Size = New System.Drawing.Size(332, 37)
        Me.TXTAddress.TabIndex = 13
        '
        'LBLEmail
        '
        Me.LBLEmail.AutoSize = True
        Me.LBLEmail.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLEmail.Location = New System.Drawing.Point(172, 111)
        Me.LBLEmail.Name = "LBLEmail"
        Me.LBLEmail.Size = New System.Drawing.Size(65, 29)
        Me.LBLEmail.TabIndex = 10
        Me.LBLEmail.Text = "Email"
        '
        'TXTEmail
        '
        Me.TXTEmail.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTEmail.Location = New System.Drawing.Point(34, 144)
        Me.TXTEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTEmail.Name = "TXTEmail"
        Me.TXTEmail.Size = New System.Drawing.Size(332, 37)
        Me.TXTEmail.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel1.Controls.Add(Me.LBLNextOfKinName)
        Me.Panel1.Controls.Add(Me.LBLNextOfKinContactInfo)
        Me.Panel1.Controls.Add(Me.TXTNextOfKinContactINfo)
        Me.Panel1.Controls.Add(Me.TXTNextOfKinName)
        Me.Panel1.Location = New System.Drawing.Point(684, 349)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 212)
        Me.Panel1.TabIndex = 18
        '
        'LBLNextOfKinName
        '
        Me.LBLNextOfKinName.AutoSize = True
        Me.LBLNextOfKinName.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNextOfKinName.Location = New System.Drawing.Point(100, 25)
        Me.LBLNextOfKinName.Name = "LBLNextOfKinName"
        Me.LBLNextOfKinName.Size = New System.Drawing.Size(194, 29)
        Me.LBLNextOfKinName.TabIndex = 8
        Me.LBLNextOfKinName.Text = "Next Of Kin Name"
        '
        'LBLNextOfKinContactInfo
        '
        Me.LBLNextOfKinContactInfo.AutoSize = True
        Me.LBLNextOfKinContactInfo.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNextOfKinContactInfo.Location = New System.Drawing.Point(30, 108)
        Me.LBLNextOfKinContactInfo.Name = "LBLNextOfKinContactInfo"
        Me.LBLNextOfKinContactInfo.Size = New System.Drawing.Size(341, 29)
        Me.LBLNextOfKinContactInfo.TabIndex = 6
        Me.LBLNextOfKinContactInfo.Text = "Next Of Kin Contact Information"
        '
        'TXTNextOfKinContactINfo
        '
        Me.TXTNextOfKinContactINfo.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNextOfKinContactINfo.Location = New System.Drawing.Point(35, 141)
        Me.TXTNextOfKinContactINfo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTNextOfKinContactINfo.Name = "TXTNextOfKinContactINfo"
        Me.TXTNextOfKinContactINfo.Size = New System.Drawing.Size(329, 37)
        Me.TXTNextOfKinContactINfo.TabIndex = 7
        '
        'TXTNextOfKinName
        '
        Me.TXTNextOfKinName.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNextOfKinName.Location = New System.Drawing.Point(35, 58)
        Me.TXTNextOfKinName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTNextOfKinName.Name = "TXTNextOfKinName"
        Me.TXTNextOfKinName.Size = New System.Drawing.Size(329, 37)
        Me.TXTNextOfKinName.TabIndex = 9
        '
        'PNLUserContainer
        '
        Me.PNLUserContainer.BackColor = System.Drawing.Color.LawnGreen
        Me.PNLUserContainer.Controls.Add(Me.BTNShowPassword)
        Me.PNLUserContainer.Controls.Add(Me.LBLPassword)
        Me.PNLUserContainer.Controls.Add(Me.LBLUsername)
        Me.PNLUserContainer.Controls.Add(Me.TXTUsername)
        Me.PNLUserContainer.Controls.Add(Me.LBLFullName)
        Me.PNLUserContainer.Controls.Add(Me.TXTFullName)
        Me.PNLUserContainer.Controls.Add(Me.TXTPassword)
        Me.PNLUserContainer.Location = New System.Drawing.Point(147, 32)
        Me.PNLUserContainer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PNLUserContainer.Name = "PNLUserContainer"
        Me.PNLUserContainer.Size = New System.Drawing.Size(467, 263)
        Me.PNLUserContainer.TabIndex = 17
        '
        'BTNShowPassword
        '
        Me.BTNShowPassword.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNShowPassword.Location = New System.Drawing.Point(274, 148)
        Me.BTNShowPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNShowPassword.Name = "BTNShowPassword"
        Me.BTNShowPassword.Size = New System.Drawing.Size(137, 92)
        Me.BTNShowPassword.TabIndex = 19
        Me.BTNShowPassword.Text = "Show Password"
        Me.BTNShowPassword.UseVisualStyleBackColor = True
        '
        'LBLPassword
        '
        Me.LBLPassword.AutoSize = True
        Me.LBLPassword.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPassword.Location = New System.Drawing.Point(286, 26)
        Me.LBLPassword.Name = "LBLPassword"
        Me.LBLPassword.Size = New System.Drawing.Size(103, 29)
        Me.LBLPassword.TabIndex = 4
        Me.LBLPassword.Text = "Password"
        '
        'LBLUsername
        '
        Me.LBLUsername.AutoSize = True
        Me.LBLUsername.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUsername.Location = New System.Drawing.Point(56, 26)
        Me.LBLUsername.Name = "LBLUsername"
        Me.LBLUsername.Size = New System.Drawing.Size(108, 29)
        Me.LBLUsername.TabIndex = 0
        Me.LBLUsername.Text = "Username"
        '
        'TXTUsername
        '
        Me.TXTUsername.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTUsername.Location = New System.Drawing.Point(27, 64)
        Me.TXTUsername.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTUsername.Name = "TXTUsername"
        Me.TXTUsername.ReadOnly = True
        Me.TXTUsername.Size = New System.Drawing.Size(185, 37)
        Me.TXTUsername.TabIndex = 1
        '
        'LBLFullName
        '
        Me.LBLFullName.AutoSize = True
        Me.LBLFullName.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFullName.Location = New System.Drawing.Point(56, 152)
        Me.LBLFullName.Name = "LBLFullName"
        Me.LBLFullName.Size = New System.Drawing.Size(110, 29)
        Me.LBLFullName.TabIndex = 2
        Me.LBLFullName.Text = "Full Name"
        '
        'TXTFullName
        '
        Me.TXTFullName.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFullName.Location = New System.Drawing.Point(27, 189)
        Me.TXTFullName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTFullName.Name = "TXTFullName"
        Me.TXTFullName.Size = New System.Drawing.Size(185, 37)
        Me.TXTFullName.TabIndex = 3
        '
        'TXTPassword
        '
        Me.TXTPassword.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPassword.Location = New System.Drawing.Point(257, 64)
        Me.TXTPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTPassword.Name = "TXTPassword"
        Me.TXTPassword.Size = New System.Drawing.Size(185, 37)
        Me.TXTPassword.TabIndex = 5
        '
        'BTNAmend
        '
        Me.BTNAmend.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAmend.Location = New System.Drawing.Point(278, 362)
        Me.BTNAmend.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNAmend.Name = "BTNAmend"
        Me.BTNAmend.Size = New System.Drawing.Size(212, 154)
        Me.BTNAmend.TabIndex = 16
        Me.BTNAmend.Text = "Amend"
        Me.BTNAmend.UseVisualStyleBackColor = True
        '
        'TBPTillOptions
        '
        Me.TBPTillOptions.BackColor = System.Drawing.Color.LimeGreen
        Me.TBPTillOptions.Controls.Add(Me.BTNsaveOptions)
        Me.TBPTillOptions.Controls.Add(Me.DGVTillOptions)
        Me.TBPTillOptions.Controls.Add(Me.PNLoptionContainer)
        Me.TBPTillOptions.Location = New System.Drawing.Point(4, 32)
        Me.TBPTillOptions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBPTillOptions.Name = "TBPTillOptions"
        Me.TBPTillOptions.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBPTillOptions.Size = New System.Drawing.Size(1439, 734)
        Me.TBPTillOptions.TabIndex = 1
        Me.TBPTillOptions.Text = "Till Otions"
        '
        'BTNsaveOptions
        '
        Me.BTNsaveOptions.BackColor = System.Drawing.Color.LawnGreen
        Me.BTNsaveOptions.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNsaveOptions.Location = New System.Drawing.Point(642, 404)
        Me.BTNsaveOptions.Name = "BTNsaveOptions"
        Me.BTNsaveOptions.Size = New System.Drawing.Size(293, 144)
        Me.BTNsaveOptions.TabIndex = 4
        Me.BTNsaveOptions.Text = "Save options"
        Me.BTNsaveOptions.UseVisualStyleBackColor = False
        '
        'DGVTillOptions
        '
        Me.DGVTillOptions.AllowUserToAddRows = False
        Me.DGVTillOptions.AllowUserToDeleteRows = False
        Me.DGVTillOptions.AllowUserToResizeColumns = False
        Me.DGVTillOptions.AllowUserToResizeRows = False
        Me.DGVTillOptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVTillOptions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVTillOptions.BackgroundColor = System.Drawing.Color.LawnGreen
        Me.DGVTillOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTillOptions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLMItemName, Me.CLMRow, Me.CLMColumn})
        Me.DGVTillOptions.Location = New System.Drawing.Point(58, 53)
        Me.DGVTillOptions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGVTillOptions.Name = "DGVTillOptions"
        Me.DGVTillOptions.Size = New System.Drawing.Size(540, 495)
        Me.DGVTillOptions.TabIndex = 0
        '
        'CLMItemName
        '
        Me.CLMItemName.HeaderText = "Item Name"
        Me.CLMItemName.Name = "CLMItemName"
        Me.CLMItemName.Width = 115
        '
        'CLMRow
        '
        Me.CLMRow.HeaderText = "Row"
        Me.CLMRow.Name = "CLMRow"
        Me.CLMRow.Width = 65
        '
        'CLMColumn
        '
        Me.CLMColumn.HeaderText = "Column"
        Me.CLMColumn.Name = "CLMColumn"
        Me.CLMColumn.Width = 85
        '
        'PNLoptionContainer
        '
        Me.PNLoptionContainer.BackColor = System.Drawing.Color.Lime
        Me.PNLoptionContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PNLoptionContainer.Controls.Add(Me.LBOptions)
        Me.PNLoptionContainer.Controls.Add(Me.LBLlistBoxDescription)
        Me.PNLoptionContainer.Location = New System.Drawing.Point(629, 53)
        Me.PNLoptionContainer.Name = "PNLoptionContainer"
        Me.PNLoptionContainer.Size = New System.Drawing.Size(316, 326)
        Me.PNLoptionContainer.TabIndex = 3
        '
        'LBOptions
        '
        Me.LBOptions.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.LBOptions.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.LBOptions.FormattingEnabled = True
        Me.LBOptions.ItemHeight = 26
        Me.LBOptions.Items.AddRange(New Object() {"Electric", "Pitch Fee", "Misc.", "Gas Bottle", "Rent / Lettings", "Electric", "Paid Out", "Suggest Other"})
        Me.LBOptions.Location = New System.Drawing.Point(13, 38)
        Me.LBOptions.Name = "LBOptions"
        Me.LBOptions.Size = New System.Drawing.Size(293, 264)
        Me.LBOptions.TabIndex = 1
        '
        'LBLlistBoxDescription
        '
        Me.LBLlistBoxDescription.AutoSize = True
        Me.LBLlistBoxDescription.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLlistBoxDescription.Location = New System.Drawing.Point(76, 9)
        Me.LBLlistBoxDescription.Name = "LBLlistBoxDescription"
        Me.LBLlistBoxDescription.Size = New System.Drawing.Size(157, 26)
        Me.LBLlistBoxDescription.TabIndex = 2
        Me.LBLlistBoxDescription.Text = "Add option to till"
        '
        'TBPSidebarOptions
        '
        Me.TBPSidebarOptions.BackColor = System.Drawing.Color.LimeGreen
        Me.TBPSidebarOptions.Controls.Add(Me.BTNSaveSidebarOptions)
        Me.TBPSidebarOptions.Controls.Add(Me.PNLSidebarDisplay)
        Me.TBPSidebarOptions.Controls.Add(Me.DGVSidebarOptions)
        Me.TBPSidebarOptions.Controls.Add(Me.PNLSidebarOptions)
        Me.TBPSidebarOptions.Location = New System.Drawing.Point(4, 32)
        Me.TBPSidebarOptions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TBPSidebarOptions.Name = "TBPSidebarOptions"
        Me.TBPSidebarOptions.Size = New System.Drawing.Size(1439, 734)
        Me.TBPSidebarOptions.TabIndex = 2
        Me.TBPSidebarOptions.Text = "Sidebar Options"
        '
        'BTNSaveSidebarOptions
        '
        Me.BTNSaveSidebarOptions.BackColor = System.Drawing.Color.LawnGreen
        Me.BTNSaveSidebarOptions.Font = New System.Drawing.Font("Comic Sans MS", 24.0!)
        Me.BTNSaveSidebarOptions.Location = New System.Drawing.Point(616, 416)
        Me.BTNSaveSidebarOptions.Name = "BTNSaveSidebarOptions"
        Me.BTNSaveSidebarOptions.Size = New System.Drawing.Size(195, 114)
        Me.BTNSaveSidebarOptions.TabIndex = 3
        Me.BTNSaveSidebarOptions.Text = "Save"
        Me.BTNSaveSidebarOptions.UseVisualStyleBackColor = False
        '
        'PNLSidebarDisplay
        '
        Me.PNLSidebarDisplay.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PNLSidebarDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PNLSidebarDisplay.Controls.Add(Me.LBLOptionSeven)
        Me.PNLSidebarDisplay.Controls.Add(Me.LBLOptionSix)
        Me.PNLSidebarDisplay.Controls.Add(Me.LBLOptionFive)
        Me.PNLSidebarDisplay.Controls.Add(Me.LBLOptionFour)
        Me.PNLSidebarDisplay.Controls.Add(Me.LBLOptionThree)
        Me.PNLSidebarDisplay.Controls.Add(Me.LBLOptionTwo)
        Me.PNLSidebarDisplay.Controls.Add(Me.LBLOptionOne)
        Me.PNLSidebarDisplay.Controls.Add(Me.PCBOptionSeven)
        Me.PNLSidebarDisplay.Controls.Add(Me.PCBOptionSix)
        Me.PNLSidebarDisplay.Controls.Add(Me.PCBOptionFive)
        Me.PNLSidebarDisplay.Controls.Add(Me.PCBOptionFour)
        Me.PNLSidebarDisplay.Controls.Add(Me.PCBOptionThree)
        Me.PNLSidebarDisplay.Controls.Add(Me.PCBOptionTwo)
        Me.PNLSidebarDisplay.Controls.Add(Me.PCBOptionOne)
        Me.PNLSidebarDisplay.Controls.Add(Me.PCBIcon)
        Me.PNLSidebarDisplay.Controls.Add(Me.LBLIcon)
        Me.PNLSidebarDisplay.Location = New System.Drawing.Point(3, 3)
        Me.PNLSidebarDisplay.Name = "PNLSidebarDisplay"
        Me.PNLSidebarDisplay.Size = New System.Drawing.Size(265, 684)
        Me.PNLSidebarDisplay.TabIndex = 2
        '
        'LBLOptionSeven
        '
        Me.LBLOptionSeven.AutoSize = True
        Me.LBLOptionSeven.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.LBLOptionSeven.Location = New System.Drawing.Point(70, 298)
        Me.LBLOptionSeven.Name = "LBLOptionSeven"
        Me.LBLOptionSeven.Size = New System.Drawing.Size(75, 23)
        Me.LBLOptionSeven.TabIndex = 16
        Me.LBLOptionSeven.Text = "Option 7"
        '
        'LBLOptionSix
        '
        Me.LBLOptionSix.AutoSize = True
        Me.LBLOptionSix.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.LBLOptionSix.Location = New System.Drawing.Point(70, 349)
        Me.LBLOptionSix.Name = "LBLOptionSix"
        Me.LBLOptionSix.Size = New System.Drawing.Size(75, 23)
        Me.LBLOptionSix.TabIndex = 15
        Me.LBLOptionSix.Text = "Option 6"
        '
        'LBLOptionFive
        '
        Me.LBLOptionFive.AutoSize = True
        Me.LBLOptionFive.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.LBLOptionFive.Location = New System.Drawing.Point(70, 406)
        Me.LBLOptionFive.Name = "LBLOptionFive"
        Me.LBLOptionFive.Size = New System.Drawing.Size(75, 23)
        Me.LBLOptionFive.TabIndex = 14
        Me.LBLOptionFive.Text = "Option 5"
        '
        'LBLOptionFour
        '
        Me.LBLOptionFour.AutoSize = True
        Me.LBLOptionFour.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.LBLOptionFour.Location = New System.Drawing.Point(70, 460)
        Me.LBLOptionFour.Name = "LBLOptionFour"
        Me.LBLOptionFour.Size = New System.Drawing.Size(75, 23)
        Me.LBLOptionFour.TabIndex = 13
        Me.LBLOptionFour.Text = "Option 4"
        '
        'LBLOptionThree
        '
        Me.LBLOptionThree.AutoSize = True
        Me.LBLOptionThree.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.LBLOptionThree.Location = New System.Drawing.Point(70, 520)
        Me.LBLOptionThree.Name = "LBLOptionThree"
        Me.LBLOptionThree.Size = New System.Drawing.Size(75, 23)
        Me.LBLOptionThree.TabIndex = 12
        Me.LBLOptionThree.Text = "Option 3"
        '
        'LBLOptionTwo
        '
        Me.LBLOptionTwo.AutoSize = True
        Me.LBLOptionTwo.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.LBLOptionTwo.Location = New System.Drawing.Point(70, 576)
        Me.LBLOptionTwo.Name = "LBLOptionTwo"
        Me.LBLOptionTwo.Size = New System.Drawing.Size(44, 23)
        Me.LBLOptionTwo.TabIndex = 11
        Me.LBLOptionTwo.Text = "Help"
        '
        'LBLOptionOne
        '
        Me.LBLOptionOne.AutoSize = True
        Me.LBLOptionOne.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.LBLOptionOne.Location = New System.Drawing.Point(70, 630)
        Me.LBLOptionOne.Name = "LBLOptionOne"
        Me.LBLOptionOne.Size = New System.Drawing.Size(71, 23)
        Me.LBLOptionOne.TabIndex = 10
        Me.LBLOptionOne.Text = "Settings"
        '
        'PCBOptionSeven
        '
        Me.PCBOptionSeven.BackColor = System.Drawing.Color.ForestGreen
        Me.PCBOptionSeven.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PCBOptionSeven.Location = New System.Drawing.Point(14, 281)
        Me.PCBOptionSeven.Name = "PCBOptionSeven"
        Me.PCBOptionSeven.Size = New System.Drawing.Size(50, 50)
        Me.PCBOptionSeven.TabIndex = 9
        Me.PCBOptionSeven.TabStop = False
        '
        'PCBOptionSix
        '
        Me.PCBOptionSix.BackColor = System.Drawing.Color.ForestGreen
        Me.PCBOptionSix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PCBOptionSix.Location = New System.Drawing.Point(14, 337)
        Me.PCBOptionSix.Name = "PCBOptionSix"
        Me.PCBOptionSix.Size = New System.Drawing.Size(50, 50)
        Me.PCBOptionSix.TabIndex = 8
        Me.PCBOptionSix.TabStop = False
        '
        'PCBOptionFive
        '
        Me.PCBOptionFive.BackColor = System.Drawing.Color.ForestGreen
        Me.PCBOptionFive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PCBOptionFive.Location = New System.Drawing.Point(14, 393)
        Me.PCBOptionFive.Name = "PCBOptionFive"
        Me.PCBOptionFive.Size = New System.Drawing.Size(50, 50)
        Me.PCBOptionFive.TabIndex = 7
        Me.PCBOptionFive.TabStop = False
        '
        'PCBOptionFour
        '
        Me.PCBOptionFour.BackColor = System.Drawing.Color.ForestGreen
        Me.PCBOptionFour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PCBOptionFour.Location = New System.Drawing.Point(14, 449)
        Me.PCBOptionFour.Name = "PCBOptionFour"
        Me.PCBOptionFour.Size = New System.Drawing.Size(50, 50)
        Me.PCBOptionFour.TabIndex = 6
        Me.PCBOptionFour.TabStop = False
        '
        'PCBOptionThree
        '
        Me.PCBOptionThree.BackColor = System.Drawing.Color.ForestGreen
        Me.PCBOptionThree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PCBOptionThree.Location = New System.Drawing.Point(14, 505)
        Me.PCBOptionThree.Name = "PCBOptionThree"
        Me.PCBOptionThree.Size = New System.Drawing.Size(50, 50)
        Me.PCBOptionThree.TabIndex = 5
        Me.PCBOptionThree.TabStop = False
        '
        'PCBOptionTwo
        '
        Me.PCBOptionTwo.BackColor = System.Drawing.Color.ForestGreen
        Me.PCBOptionTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PCBOptionTwo.Location = New System.Drawing.Point(14, 561)
        Me.PCBOptionTwo.Name = "PCBOptionTwo"
        Me.PCBOptionTwo.Size = New System.Drawing.Size(50, 50)
        Me.PCBOptionTwo.TabIndex = 4
        Me.PCBOptionTwo.TabStop = False
        '
        'PCBOptionOne
        '
        Me.PCBOptionOne.BackColor = System.Drawing.Color.ForestGreen
        Me.PCBOptionOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PCBOptionOne.Location = New System.Drawing.Point(14, 617)
        Me.PCBOptionOne.Name = "PCBOptionOne"
        Me.PCBOptionOne.Size = New System.Drawing.Size(50, 50)
        Me.PCBOptionOne.TabIndex = 3
        Me.PCBOptionOne.TabStop = False
        '
        'PCBIcon
        '
        Me.PCBIcon.BackColor = System.Drawing.Color.ForestGreen
        Me.PCBIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PCBIcon.Location = New System.Drawing.Point(14, 14)
        Me.PCBIcon.Name = "PCBIcon"
        Me.PCBIcon.Size = New System.Drawing.Size(50, 50)
        Me.PCBIcon.TabIndex = 2
        Me.PCBIcon.TabStop = False
        '
        'LBLIcon
        '
        Me.LBLIcon.AutoSize = True
        Me.LBLIcon.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.LBLIcon.Location = New System.Drawing.Point(70, 28)
        Me.LBLIcon.Name = "LBLIcon"
        Me.LBLIcon.Size = New System.Drawing.Size(80, 23)
        Me.LBLIcon.TabIndex = 1
        Me.LBLIcon.Text = "Username"
        '
        'DGVSidebarOptions
        '
        Me.DGVSidebarOptions.AllowUserToAddRows = False
        Me.DGVSidebarOptions.AllowUserToDeleteRows = False
        Me.DGVSidebarOptions.AllowUserToResizeColumns = False
        Me.DGVSidebarOptions.AllowUserToResizeRows = False
        Me.DGVSidebarOptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVSidebarOptions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVSidebarOptions.BackgroundColor = System.Drawing.Color.LawnGreen
        Me.DGVSidebarOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSidebarOptions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1})
        Me.DGVSidebarOptions.Location = New System.Drawing.Point(327, 34)
        Me.DGVSidebarOptions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGVSidebarOptions.Name = "DGVSidebarOptions"
        Me.DGVSidebarOptions.ReadOnly = True
        Me.DGVSidebarOptions.Size = New System.Drawing.Size(388, 375)
        Me.DGVSidebarOptions.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Index"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 59
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sidebar Option"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 130
        '
        'PNLSidebarOptions
        '
        Me.PNLSidebarOptions.BackColor = System.Drawing.Color.LawnGreen
        Me.PNLSidebarOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PNLSidebarOptions.Controls.Add(Me.LBSidebarOptions)
        Me.PNLSidebarOptions.Controls.Add(Me.LBLOptions)
        Me.PNLSidebarOptions.Location = New System.Drawing.Point(721, 35)
        Me.PNLSidebarOptions.Name = "PNLSidebarOptions"
        Me.PNLSidebarOptions.Size = New System.Drawing.Size(399, 374)
        Me.PNLSidebarOptions.TabIndex = 1
        '
        'LBSidebarOptions
        '
        Me.LBSidebarOptions.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBSidebarOptions.FormattingEnabled = True
        Me.LBSidebarOptions.ItemHeight = 29
        Me.LBSidebarOptions.Items.AddRange(New Object() {"Request", "Till", "Timetable", "Lookup", "Medical"})
        Me.LBSidebarOptions.Location = New System.Drawing.Point(31, 61)
        Me.LBSidebarOptions.Name = "LBSidebarOptions"
        Me.LBSidebarOptions.Size = New System.Drawing.Size(343, 294)
        Me.LBSidebarOptions.TabIndex = 1
        '
        'LBLOptions
        '
        Me.LBLOptions.AutoSize = True
        Me.LBLOptions.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLOptions.Location = New System.Drawing.Point(121, 15)
        Me.LBLOptions.Name = "LBLOptions"
        Me.LBLOptions.Size = New System.Drawing.Size(184, 29)
        Me.LBLOptions.TabIndex = 0
        Me.LBLOptions.Text = "Available Options"
        '
        'BSSettings
        '
        Me.BSSettings.DataMember = "Settings"
        Me.BSSettings.DataSource = Me.DBDataSet
        '
        'DBDataSet
        '
        Me.DBDataSet.DataSetName = "DBDataSet"
        Me.DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SettingsTableAdapter
        '
        Me.SettingsTableAdapter.ClearBeforeFill = True
        '
        'BSUsers
        '
        Me.BSUsers.DataMember = "Users"
        Me.BSUsers.DataSource = Me.DBDataSet
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'TMRPassword
        '
        Me.TMRPassword.Interval = 30000
        '
        'FRMsettings
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1496, 840)
        Me.Controls.Add(Me.TBCmain)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 11.0!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FRMsettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TBCmain.ResumeLayout(False)
        Me.TBPUserDetails.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PNLUserContainer.ResumeLayout(False)
        Me.PNLUserContainer.PerformLayout()
        Me.TBPTillOptions.ResumeLayout(False)
        CType(Me.DGVTillOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNLoptionContainer.ResumeLayout(False)
        Me.PNLoptionContainer.PerformLayout()
        Me.TBPSidebarOptions.ResumeLayout(False)
        Me.PNLSidebarDisplay.ResumeLayout(False)
        Me.PNLSidebarDisplay.PerformLayout()
        CType(Me.PCBOptionSeven, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCBOptionSix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCBOptionFive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCBOptionFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCBOptionThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCBOptionTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCBOptionOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCBIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVSidebarOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNLSidebarOptions.ResumeLayout(False)
        Me.PNLSidebarOptions.PerformLayout()
        CType(Me.BSSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TBCmain As TabControl
    Friend WithEvents TBPUserDetails As TabPage
    Friend WithEvents TBPTillOptions As TabPage
    Friend WithEvents PNLUserContainer As Panel
    Friend WithEvents LBLPassword As Label
    Friend WithEvents LBLUsername As Label
    Friend WithEvents TXTUsername As TextBox
    Friend WithEvents LBLFullName As Label
    Friend WithEvents TXTFullName As TextBox
    Friend WithEvents TXTPassword As TextBox
    Friend WithEvents BTNAmend As Button
    Friend WithEvents TXTAddress As TextBox
    Friend WithEvents LBLAddress As Label
    Friend WithEvents TXTEmail As TextBox
    Friend WithEvents LBLEmail As Label
    Friend WithEvents TXTNextOfKinName As TextBox
    Friend WithEvents LBLNextOfKinName As Label
    Friend WithEvents TXTNextOfKinContactINfo As TextBox
    Friend WithEvents LBLNextOfKinContactInfo As Label
    Friend WithEvents TBPSidebarOptions As TabPage
    Friend WithEvents BSSettings As BindingSource
    Friend WithEvents DBDataSet As DBDataSet
    Friend WithEvents SettingsTableAdapter As DBDataSetTableAdapters.SettingsTableAdapter
    Friend WithEvents BSUsers As BindingSource
    Friend WithEvents UsersTableAdapter As DBDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTNShowPassword As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DGVTillOptions As DataGridView
    Friend WithEvents CLMItemName As DataGridViewTextBoxColumn
    Friend WithEvents CLMRow As DataGridViewTextBoxColumn
    Friend WithEvents CLMColumn As DataGridViewTextBoxColumn
    Friend WithEvents LBOptions As ListBox
    Friend WithEvents PNLoptionContainer As Panel
    Friend WithEvents LBLlistBoxDescription As Label
    Friend WithEvents BTNsaveOptions As Button
    Friend WithEvents PNLSidebarOptions As Panel
    Friend WithEvents PNLSidebarDisplay As Panel
    Friend WithEvents LBLOptionSeven As Label
    Friend WithEvents LBLOptionSix As Label
    Friend WithEvents LBLOptionFive As Label
    Friend WithEvents LBLOptionFour As Label
    Friend WithEvents LBLOptionThree As Label
    Friend WithEvents LBLOptionTwo As Label
    Friend WithEvents LBLOptionOne As Label
    Friend WithEvents PCBOptionSeven As PictureBox
    Friend WithEvents PCBOptionSix As PictureBox
    Friend WithEvents PCBOptionFive As PictureBox
    Friend WithEvents PCBOptionFour As PictureBox
    Friend WithEvents PCBOptionThree As PictureBox
    Friend WithEvents PCBOptionTwo As PictureBox
    Friend WithEvents PCBOptionOne As PictureBox
    Friend WithEvents PCBIcon As PictureBox
    Friend WithEvents LBLIcon As Label
    Friend WithEvents DGVSidebarOptions As DataGridView
    Friend WithEvents LBLOptions As Label
    Friend WithEvents LBSidebarOptions As ListBox
    Friend WithEvents BTNSaveSidebarOptions As Button
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TMRPassword As Timer
End Class
