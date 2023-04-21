<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMaddUser
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
        Me.TXTFirstName = New System.Windows.Forms.TextBox()
        Me.TXTPhoneNumber = New System.Windows.Forms.TextBox()
        Me.TXTaddress = New System.Windows.Forms.TextBox()
        Me.TXTNextOfKin = New System.Windows.Forms.TextBox()
        Me.TXTNextOfKinContact = New System.Windows.Forms.TextBox()
        Me.CMBaccessLevel = New System.Windows.Forms.ComboBox()
        Me.LBLFirstName = New System.Windows.Forms.Label()
        Me.LBLPhoneNumber = New System.Windows.Forms.Label()
        Me.LBLAddress = New System.Windows.Forms.Label()
        Me.LBLNextOfKinName = New System.Windows.Forms.Label()
        Me.LBLNextOfKinNumber = New System.Windows.Forms.Label()
        Me.TXTPassword = New System.Windows.Forms.TextBox()
        Me.LBLPassword = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TXTLastName = New System.Windows.Forms.TextBox()
        Me.LBLLastName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LBLAccessLevel = New System.Windows.Forms.Label()
        Me.BTNconfirm = New System.Windows.Forms.Button()
        Me.BSusers = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBDataSet = New Y2Proj.DBDataSet()
        Me.UsersTableAdapter = New Y2Proj.DBDataSetTableAdapters.UsersTableAdapter()
        Me.Settings = New System.Windows.Forms.BindingSource(Me.components)
        Me.SettingsTableAdapter = New Y2Proj.DBDataSetTableAdapters.SettingsTableAdapter()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.BSusers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Settings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXTFirstName
        '
        Me.TXTFirstName.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFirstName.Location = New System.Drawing.Point(51, 61)
        Me.TXTFirstName.Name = "TXTFirstName"
        Me.TXTFirstName.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TXTFirstName.Size = New System.Drawing.Size(169, 34)
        Me.TXTFirstName.TabIndex = 0
        '
        'TXTPhoneNumber
        '
        Me.TXTPhoneNumber.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPhoneNumber.Location = New System.Drawing.Point(250, 136)
        Me.TXTPhoneNumber.Name = "TXTPhoneNumber"
        Me.TXTPhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TXTPhoneNumber.Size = New System.Drawing.Size(169, 34)
        Me.TXTPhoneNumber.TabIndex = 1
        '
        'TXTaddress
        '
        Me.TXTaddress.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTaddress.Location = New System.Drawing.Point(251, 61)
        Me.TXTaddress.Name = "TXTaddress"
        Me.TXTaddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TXTaddress.Size = New System.Drawing.Size(169, 34)
        Me.TXTaddress.TabIndex = 2
        '
        'TXTNextOfKin
        '
        Me.TXTNextOfKin.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNextOfKin.Location = New System.Drawing.Point(61, 50)
        Me.TXTNextOfKin.Name = "TXTNextOfKin"
        Me.TXTNextOfKin.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TXTNextOfKin.Size = New System.Drawing.Size(169, 34)
        Me.TXTNextOfKin.TabIndex = 3
        '
        'TXTNextOfKinContact
        '
        Me.TXTNextOfKinContact.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNextOfKinContact.Location = New System.Drawing.Point(61, 127)
        Me.TXTNextOfKinContact.Name = "TXTNextOfKinContact"
        Me.TXTNextOfKinContact.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TXTNextOfKinContact.Size = New System.Drawing.Size(169, 34)
        Me.TXTNextOfKinContact.TabIndex = 4
        '
        'CMBaccessLevel
        '
        Me.CMBaccessLevel.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBaccessLevel.FormattingEnabled = True
        Me.CMBaccessLevel.Items.AddRange(New Object() {"Admin", "Director", "Employee", "Resident"})
        Me.CMBaccessLevel.Location = New System.Drawing.Point(22, 64)
        Me.CMBaccessLevel.Name = "CMBaccessLevel"
        Me.CMBaccessLevel.Size = New System.Drawing.Size(169, 34)
        Me.CMBaccessLevel.TabIndex = 5
        Me.CMBaccessLevel.Text = "Resident"
        '
        'LBLFirstName
        '
        Me.LBLFirstName.AutoSize = True
        Me.LBLFirstName.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFirstName.Location = New System.Drawing.Point(37, 8)
        Me.LBLFirstName.Name = "LBLFirstName"
        Me.LBLFirstName.Size = New System.Drawing.Size(123, 29)
        Me.LBLFirstName.TabIndex = 6
        Me.LBLFirstName.Text = "First Name"
        '
        'LBLPhoneNumber
        '
        Me.LBLPhoneNumber.AutoSize = True
        Me.LBLPhoneNumber.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPhoneNumber.Location = New System.Drawing.Point(213, 82)
        Me.LBLPhoneNumber.Name = "LBLPhoneNumber"
        Me.LBLPhoneNumber.Size = New System.Drawing.Size(145, 29)
        Me.LBLPhoneNumber.TabIndex = 7
        Me.LBLPhoneNumber.Text = "Phone number"
        '
        'LBLAddress
        '
        Me.LBLAddress.AutoSize = True
        Me.LBLAddress.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLAddress.Location = New System.Drawing.Point(221, 8)
        Me.LBLAddress.Name = "LBLAddress"
        Me.LBLAddress.Size = New System.Drawing.Size(132, 29)
        Me.LBLAddress.TabIndex = 8
        Me.LBLAddress.Text = "Access level"
        '
        'LBLNextOfKinName
        '
        Me.LBLNextOfKinName.AutoSize = True
        Me.LBLNextOfKinName.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNextOfKinName.Location = New System.Drawing.Point(26, 18)
        Me.LBLNextOfKinName.Name = "LBLNextOfKinName"
        Me.LBLNextOfKinName.Size = New System.Drawing.Size(236, 29)
        Me.LBLNextOfKinName.TabIndex = 9
        Me.LBLNextOfKinName.Text = "Next Of Kin Full Name"
        '
        'LBLNextOfKinNumber
        '
        Me.LBLNextOfKinNumber.AutoSize = True
        Me.LBLNextOfKinNumber.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNextOfKinNumber.Location = New System.Drawing.Point(4, 95)
        Me.LBLNextOfKinNumber.Name = "LBLNextOfKinNumber"
        Me.LBLNextOfKinNumber.Size = New System.Drawing.Size(271, 29)
        Me.LBLNextOfKinNumber.TabIndex = 10
        Me.LBLNextOfKinNumber.Text = "Next Of Kin Phone number"
        '
        'TXTPassword
        '
        Me.TXTPassword.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPassword.Location = New System.Drawing.Point(6, 190)
        Me.TXTPassword.Name = "TXTPassword"
        Me.TXTPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTPassword.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TXTPassword.Size = New System.Drawing.Size(169, 34)
        Me.TXTPassword.TabIndex = 11
        '
        'LBLPassword
        '
        Me.LBLPassword.AutoSize = True
        Me.LBLPassword.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPassword.Location = New System.Drawing.Point(37, 159)
        Me.LBLPassword.Name = "LBLPassword"
        Me.LBLPassword.Size = New System.Drawing.Size(103, 29)
        Me.LBLPassword.TabIndex = 12
        Me.LBLPassword.Text = "Password"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel1.Controls.Add(Me.TXTLastName)
        Me.Panel1.Controls.Add(Me.TXTPassword)
        Me.Panel1.Controls.Add(Me.LBLLastName)
        Me.Panel1.Controls.Add(Me.LBLPassword)
        Me.Panel1.Controls.Add(Me.LBLFirstName)
        Me.Panel1.Controls.Add(Me.LBLPhoneNumber)
        Me.Panel1.Controls.Add(Me.LBLAddress)
        Me.Panel1.Location = New System.Drawing.Point(37, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 240)
        Me.Panel1.TabIndex = 13
        '
        'TXTLastName
        '
        Me.TXTLastName.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTLastName.Location = New System.Drawing.Point(6, 114)
        Me.TXTLastName.Name = "TXTLastName"
        Me.TXTLastName.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TXTLastName.Size = New System.Drawing.Size(169, 34)
        Me.TXTLastName.TabIndex = 17
        '
        'LBLLastName
        '
        Me.LBLLastName.AutoSize = True
        Me.LBLLastName.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLLastName.Location = New System.Drawing.Point(37, 83)
        Me.LBLLastName.Name = "LBLLastName"
        Me.LBLLastName.Size = New System.Drawing.Size(117, 29)
        Me.LBLLastName.TabIndex = 13
        Me.LBLLastName.Text = "Last Name"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel2.Controls.Add(Me.LBLNextOfKinName)
        Me.Panel2.Controls.Add(Me.TXTNextOfKin)
        Me.Panel2.Controls.Add(Me.TXTNextOfKinContact)
        Me.Panel2.Controls.Add(Me.LBLNextOfKinNumber)
        Me.Panel2.Location = New System.Drawing.Point(485, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(284, 174)
        Me.Panel2.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel3.Controls.Add(Me.LBLAccessLevel)
        Me.Panel3.Controls.Add(Me.CMBaccessLevel)
        Me.Panel3.Location = New System.Drawing.Point(546, 266)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(223, 120)
        Me.Panel3.TabIndex = 15
        '
        'LBLAccessLevel
        '
        Me.LBLAccessLevel.AutoSize = True
        Me.LBLAccessLevel.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLAccessLevel.Location = New System.Drawing.Point(48, 26)
        Me.LBLAccessLevel.Name = "LBLAccessLevel"
        Me.LBLAccessLevel.Size = New System.Drawing.Size(138, 29)
        Me.LBLAccessLevel.TabIndex = 16
        Me.LBLAccessLevel.Text = "Access Level"
        '
        'BTNconfirm
        '
        Me.BTNconfirm.BackColor = System.Drawing.Color.LimeGreen
        Me.BTNconfirm.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNconfirm.Location = New System.Drawing.Point(45, 308)
        Me.BTNconfirm.Name = "BTNconfirm"
        Me.BTNconfirm.Size = New System.Drawing.Size(150, 78)
        Me.BTNconfirm.TabIndex = 16
        Me.BTNconfirm.Text = "Confirm"
        Me.BTNconfirm.UseVisualStyleBackColor = False
        '
        'BSusers
        '
        Me.BSusers.DataMember = "Users"
        Me.BSusers.DataSource = Me.DBDataSet
        '
        'DBDataSet
        '
        Me.DBDataSet.DataSetName = "DBDataSet"
        Me.DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'Settings
        '
        Me.Settings.DataMember = "Settings"
        Me.Settings.DataSource = Me.DBDataSet
        '
        'SettingsTableAdapter
        '
        Me.SettingsTableAdapter.ClearBeforeFill = True
        '
        'FRMaddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(781, 407)
        Me.Controls.Add(Me.BTNconfirm)
        Me.Controls.Add(Me.TXTaddress)
        Me.Controls.Add(Me.TXTPhoneNumber)
        Me.Controls.Add(Me.TXTFirstName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FRMaddUser"
        Me.Text = "FRMaddUser"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.BSusers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Settings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTFirstName As TextBox
    Friend WithEvents TXTPhoneNumber As TextBox
    Friend WithEvents TXTaddress As TextBox
    Friend WithEvents TXTNextOfKin As TextBox
    Friend WithEvents TXTNextOfKinContact As TextBox
    Friend WithEvents CMBaccessLevel As ComboBox
    Friend WithEvents LBLFirstName As Label
    Friend WithEvents LBLPhoneNumber As Label
    Friend WithEvents LBLAddress As Label
    Friend WithEvents LBLNextOfKinName As Label
    Friend WithEvents LBLNextOfKinNumber As Label
    Friend WithEvents TXTPassword As TextBox
    Friend WithEvents LBLPassword As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LBLAccessLevel As Label
    Friend WithEvents BTNconfirm As Button
    Friend WithEvents BSusers As BindingSource
    Friend WithEvents DBDataSet As DBDataSet
    Friend WithEvents UsersTableAdapter As DBDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents TXTLastName As TextBox
    Friend WithEvents LBLLastName As Label
    Friend WithEvents Settings As BindingSource
    Friend WithEvents SettingsTableAdapter As DBDataSetTableAdapters.SettingsTableAdapter
End Class
