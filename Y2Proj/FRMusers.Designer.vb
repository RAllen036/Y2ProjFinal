<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMusers
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
        Me.Settings = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBDataSet = New Y2Proj.DBDataSet()
        Me.SettingsTableAdapter = New Y2Proj.DBDataSetTableAdapters.SettingsTableAdapter()
        Me.BSusers = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New Y2Proj.DBDataSetTableAdapters.UsersTableAdapter()
        Me.BTNaddUser = New System.Windows.Forms.Button()
        CType(Me.Settings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSusers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Settings
        '
        Me.Settings.DataMember = "Settings"
        Me.Settings.DataSource = Me.DBDataSet
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
        'BSusers
        '
        Me.BSusers.DataMember = "Users"
        Me.BSusers.DataSource = Me.DBDataSet
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'BTNaddUser
        '
        Me.BTNaddUser.BackColor = System.Drawing.Color.LawnGreen
        Me.BTNaddUser.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNaddUser.Location = New System.Drawing.Point(404, 293)
        Me.BTNaddUser.Name = "BTNaddUser"
        Me.BTNaddUser.Size = New System.Drawing.Size(180, 41)
        Me.BTNaddUser.TabIndex = 0
        Me.BTNaddUser.Text = "Add a new user"
        Me.BTNaddUser.UseVisualStyleBackColor = False
        Me.BTNaddUser.Visible = False
        '
        'FRMusers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(900, 506)
        Me.Controls.Add(Me.BTNaddUser)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FRMusers"
        Me.Text = "User Form"
        CType(Me.Settings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSusers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Settings As BindingSource
    Friend WithEvents DBDataSet As DBDataSet
    Friend WithEvents SettingsTableAdapter As DBDataSetTableAdapters.SettingsTableAdapter
    Friend WithEvents BSusers As BindingSource
    Friend WithEvents UsersTableAdapter As DBDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents BTNaddUser As Button
End Class
