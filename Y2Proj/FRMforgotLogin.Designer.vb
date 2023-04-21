<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMforgotLogin
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
        Me.TBCemail = New System.Windows.Forms.TabControl()
        Me.TBPSendEmail = New System.Windows.Forms.TabPage()
        Me.BTNsendEmail = New System.Windows.Forms.Button()
        Me.LBLusername = New System.Windows.Forms.Label()
        Me.TXTusername = New System.Windows.Forms.TextBox()
        Me.TBPRecieveEmail = New System.Windows.Forms.TabPage()
        Me.LBLNewPassword = New System.Windows.Forms.Label()
        Me.TXTNewPassword = New System.Windows.Forms.TextBox()
        Me.BTNResetPassword = New System.Windows.Forms.Button()
        Me.LBLCode = New System.Windows.Forms.Label()
        Me.TXTCode = New System.Windows.Forms.TextBox()
        Me.TMRattemptReset = New System.Windows.Forms.Timer(Me.components)
        Me.Users = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBDataSet = New Y2Proj.DBDataSet()
        Me.UsersTableAdapter = New Y2Proj.DBDataSetTableAdapters.UsersTableAdapter()
        Me.TBCemail.SuspendLayout()
        Me.TBPSendEmail.SuspendLayout()
        Me.TBPRecieveEmail.SuspendLayout()
        CType(Me.Users, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBCemail
        '
        Me.TBCemail.Controls.Add(Me.TBPSendEmail)
        Me.TBCemail.Controls.Add(Me.TBPRecieveEmail)
        Me.TBCemail.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCemail.Location = New System.Drawing.Point(12, 12)
        Me.TBCemail.Name = "TBCemail"
        Me.TBCemail.SelectedIndex = 0
        Me.TBCemail.Size = New System.Drawing.Size(667, 339)
        Me.TBCemail.TabIndex = 0
        '
        'TBPSendEmail
        '
        Me.TBPSendEmail.BackColor = System.Drawing.Color.LawnGreen
        Me.TBPSendEmail.Controls.Add(Me.BTNsendEmail)
        Me.TBPSendEmail.Controls.Add(Me.LBLusername)
        Me.TBPSendEmail.Controls.Add(Me.TXTusername)
        Me.TBPSendEmail.Location = New System.Drawing.Point(4, 35)
        Me.TBPSendEmail.Name = "TBPSendEmail"
        Me.TBPSendEmail.Padding = New System.Windows.Forms.Padding(3)
        Me.TBPSendEmail.Size = New System.Drawing.Size(659, 300)
        Me.TBPSendEmail.TabIndex = 0
        Me.TBPSendEmail.Text = "Send email"
        '
        'BTNsendEmail
        '
        Me.BTNsendEmail.BackColor = System.Drawing.Color.LimeGreen
        Me.BTNsendEmail.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNsendEmail.Location = New System.Drawing.Point(255, 173)
        Me.BTNsendEmail.Name = "BTNsendEmail"
        Me.BTNsendEmail.Size = New System.Drawing.Size(119, 91)
        Me.BTNsendEmail.TabIndex = 7
        Me.BTNsendEmail.Text = "Send password reset email"
        Me.BTNsendEmail.UseVisualStyleBackColor = False
        '
        'LBLusername
        '
        Me.LBLusername.AutoSize = True
        Me.LBLusername.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLusername.Location = New System.Drawing.Point(188, 47)
        Me.LBLusername.Name = "LBLusername"
        Me.LBLusername.Size = New System.Drawing.Size(259, 26)
        Me.LBLusername.TabIndex = 6
        Me.LBLusername.Text = "Please enter your username:"
        '
        'TXTusername
        '
        Me.TXTusername.BackColor = System.Drawing.Color.LimeGreen
        Me.TXTusername.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTusername.Location = New System.Drawing.Point(188, 88)
        Me.TXTusername.Name = "TXTusername"
        Me.TXTusername.Size = New System.Drawing.Size(245, 37)
        Me.TXTusername.TabIndex = 5
        '
        'TBPRecieveEmail
        '
        Me.TBPRecieveEmail.BackColor = System.Drawing.Color.LawnGreen
        Me.TBPRecieveEmail.Controls.Add(Me.LBLNewPassword)
        Me.TBPRecieveEmail.Controls.Add(Me.TXTNewPassword)
        Me.TBPRecieveEmail.Controls.Add(Me.BTNResetPassword)
        Me.TBPRecieveEmail.Controls.Add(Me.LBLCode)
        Me.TBPRecieveEmail.Controls.Add(Me.TXTCode)
        Me.TBPRecieveEmail.Location = New System.Drawing.Point(4, 35)
        Me.TBPRecieveEmail.Name = "TBPRecieveEmail"
        Me.TBPRecieveEmail.Padding = New System.Windows.Forms.Padding(3)
        Me.TBPRecieveEmail.Size = New System.Drawing.Size(659, 300)
        Me.TBPRecieveEmail.TabIndex = 1
        Me.TBPRecieveEmail.Text = "Recieve email"
        '
        'LBLNewPassword
        '
        Me.LBLNewPassword.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNewPassword.Location = New System.Drawing.Point(364, 28)
        Me.LBLNewPassword.Name = "LBLNewPassword"
        Me.LBLNewPassword.Size = New System.Drawing.Size(259, 61)
        Me.LBLNewPassword.TabIndex = 12
        Me.LBLNewPassword.Text = "Please enter your new password:"
        Me.LBLNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTNewPassword
        '
        Me.TXTNewPassword.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNewPassword.Location = New System.Drawing.Point(369, 92)
        Me.TXTNewPassword.Name = "TXTNewPassword"
        Me.TXTNewPassword.Size = New System.Drawing.Size(245, 37)
        Me.TXTNewPassword.TabIndex = 11
        '
        'BTNResetPassword
        '
        Me.BTNResetPassword.BackColor = System.Drawing.Color.LimeGreen
        Me.BTNResetPassword.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNResetPassword.Location = New System.Drawing.Point(254, 171)
        Me.BTNResetPassword.Name = "BTNResetPassword"
        Me.BTNResetPassword.Size = New System.Drawing.Size(119, 91)
        Me.BTNResetPassword.TabIndex = 10
        Me.BTNResetPassword.Text = "Confirm password reset"
        Me.BTNResetPassword.UseVisualStyleBackColor = False
        '
        'LBLCode
        '
        Me.LBLCode.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCode.Location = New System.Drawing.Point(21, 28)
        Me.LBLCode.Name = "LBLCode"
        Me.LBLCode.Size = New System.Drawing.Size(259, 61)
        Me.LBLCode.TabIndex = 9
        Me.LBLCode.Text = "Please enter the code sent to your email:"
        Me.LBLCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TXTCode
        '
        Me.TXTCode.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCode.Location = New System.Drawing.Point(26, 92)
        Me.TXTCode.Name = "TXTCode"
        Me.TXTCode.Size = New System.Drawing.Size(245, 37)
        Me.TXTCode.TabIndex = 8
        '
        'TMRattemptReset
        '
        Me.TMRattemptReset.Interval = 120000
        '
        'Users
        '
        Me.Users.DataMember = "Users"
        Me.Users.DataSource = Me.DBDataSet
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
        'FRMforgotLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(691, 365)
        Me.Controls.Add(Me.TBCemail)
        Me.Name = "FRMforgotLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRMforgotLogin"
        Me.TBCemail.ResumeLayout(False)
        Me.TBPSendEmail.ResumeLayout(False)
        Me.TBPSendEmail.PerformLayout()
        Me.TBPRecieveEmail.ResumeLayout(False)
        Me.TBPRecieveEmail.PerformLayout()
        CType(Me.Users, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TBCemail As TabControl
    Friend WithEvents TBPSendEmail As TabPage
    Friend WithEvents BTNsendEmail As Button
    Friend WithEvents LBLusername As Label
    Friend WithEvents TXTusername As TextBox
    Friend WithEvents TBPRecieveEmail As TabPage
    Friend WithEvents BTNResetPassword As Button
    Friend WithEvents LBLCode As Label
    Friend WithEvents TXTCode As TextBox
    Friend WithEvents Users As BindingSource
    Friend WithEvents DBDataSet As DBDataSet
    Friend WithEvents LBLNewPassword As Label
    Friend WithEvents TXTNewPassword As TextBox
    Friend WithEvents UsersTableAdapter As DBDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents TMRattemptReset As Timer
End Class
