<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMlogin
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
        Me.components = New System.ComponentModel.Container()
        Me.TXTusername = New System.Windows.Forms.TextBox()
        Me.TXTpassword = New System.Windows.Forms.TextBox()
        Me.LBLusername = New System.Windows.Forms.Label()
        Me.LBLpassword = New System.Windows.Forms.Label()
        Me.BTNlogin = New System.Windows.Forms.Button()
        Me.BSusers = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBDataSet = New Y2Proj.DBDataSet()
        Me.UsersTableAdapter = New Y2Proj.DBDataSetTableAdapters.UsersTableAdapter()
        Me.BTNforgotLogin = New System.Windows.Forms.Button()
        Me.LogBook = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogBookTableAdapter = New Y2Proj.DBDataSetTableAdapters.LogBookTableAdapter()
        CType(Me.BSusers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXTusername
        '
        Me.TXTusername.BackColor = System.Drawing.Color.LawnGreen
        Me.TXTusername.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTusername.Location = New System.Drawing.Point(56, 63)
        Me.TXTusername.Name = "TXTusername"
        Me.TXTusername.Size = New System.Drawing.Size(245, 41)
        Me.TXTusername.TabIndex = 0
        '
        'TXTpassword
        '
        Me.TXTpassword.BackColor = System.Drawing.Color.LawnGreen
        Me.TXTpassword.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTpassword.Location = New System.Drawing.Point(56, 178)
        Me.TXTpassword.Name = "TXTpassword"
        Me.TXTpassword.Size = New System.Drawing.Size(245, 41)
        Me.TXTpassword.TabIndex = 1
        '
        'LBLusername
        '
        Me.LBLusername.AutoSize = True
        Me.LBLusername.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLusername.Location = New System.Drawing.Point(51, 24)
        Me.LBLusername.Name = "LBLusername"
        Me.LBLusername.Size = New System.Drawing.Size(251, 33)
        Me.LBLusername.TabIndex = 2
        Me.LBLusername.Text = "Enter your username:"
        '
        'LBLpassword
        '
        Me.LBLpassword.AutoSize = True
        Me.LBLpassword.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLpassword.Location = New System.Drawing.Point(51, 142)
        Me.LBLpassword.Name = "LBLpassword"
        Me.LBLpassword.Size = New System.Drawing.Size(251, 33)
        Me.LBLpassword.TabIndex = 3
        Me.LBLpassword.Text = "Enter your password:"
        '
        'BTNlogin
        '
        Me.BTNlogin.BackColor = System.Drawing.Color.LawnGreen
        Me.BTNlogin.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNlogin.Location = New System.Drawing.Point(371, 46)
        Me.BTNlogin.Name = "BTNlogin"
        Me.BTNlogin.Size = New System.Drawing.Size(120, 58)
        Me.BTNlogin.TabIndex = 4
        Me.BTNlogin.Text = "Login"
        Me.BTNlogin.UseVisualStyleBackColor = False
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
        'BTNforgotLogin
        '
        Me.BTNforgotLogin.BackColor = System.Drawing.Color.LawnGreen
        Me.BTNforgotLogin.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNforgotLogin.Location = New System.Drawing.Point(371, 128)
        Me.BTNforgotLogin.Name = "BTNforgotLogin"
        Me.BTNforgotLogin.Size = New System.Drawing.Size(120, 91)
        Me.BTNforgotLogin.TabIndex = 6
        Me.BTNforgotLogin.Text = "Forgot Login"
        Me.BTNforgotLogin.UseVisualStyleBackColor = False
        '
        'LogBook
        '
        Me.LogBook.DataMember = "LogBook"
        Me.LogBook.DataSource = Me.DBDataSet
        '
        'LogBookTableAdapter
        '
        Me.LogBookTableAdapter.ClearBeforeFill = True
        '
        'FRMlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(537, 263)
        Me.Controls.Add(Me.BTNforgotLogin)
        Me.Controls.Add(Me.BTNlogin)
        Me.Controls.Add(Me.LBLpassword)
        Me.Controls.Add(Me.LBLusername)
        Me.Controls.Add(Me.TXTpassword)
        Me.Controls.Add(Me.TXTusername)
        Me.Name = "FRMlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login Screen"
        CType(Me.BSusers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTusername As TextBox
    Friend WithEvents TXTpassword As TextBox
    Friend WithEvents LBLusername As Label
    Friend WithEvents LBLpassword As Label
    Friend WithEvents BTNlogin As Button
    Friend WithEvents BSusers As BindingSource
    Friend WithEvents DBDataSet As DBDataSet
    Friend WithEvents UsersTableAdapter As DBDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents BTNforgotLogin As Button
    Friend WithEvents LogBook As BindingSource
    Friend WithEvents LogBookTableAdapter As DBDataSetTableAdapters.LogBookTableAdapter
End Class
