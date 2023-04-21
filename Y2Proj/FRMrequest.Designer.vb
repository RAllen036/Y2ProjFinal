<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMrequest
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
        Me.TBCuser = New System.Windows.Forms.TabControl()
        Me.TBPAddRequest = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DBDataSet = New Y2Proj.DBDataSet()
        Me.BSrequestLog = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequestLogTableAdapter = New Y2Proj.DBDataSetTableAdapters.RequestLogTableAdapter()
        Me.BSRequestLookup = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequestLookupTableAdapter = New Y2Proj.DBDataSetTableAdapters.RequestLookupTableAdapter()
        Me.BSusers = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New Y2Proj.DBDataSetTableAdapters.UsersTableAdapter()
        Me.TBCuser.SuspendLayout()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSrequestLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSRequestLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSusers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBCuser
        '
        Me.TBCuser.Controls.Add(Me.TBPAddRequest)
        Me.TBCuser.Controls.Add(Me.TabPage2)
        Me.TBCuser.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCuser.Location = New System.Drawing.Point(12, 12)
        Me.TBCuser.Name = "TBCuser"
        Me.TBCuser.SelectedIndex = 0
        Me.TBCuser.Size = New System.Drawing.Size(1300, 740)
        Me.TBCuser.TabIndex = 0
        '
        'TBPAddRequest
        '
        Me.TBPAddRequest.BackColor = System.Drawing.Color.LimeGreen
        Me.TBPAddRequest.Location = New System.Drawing.Point(4, 38)
        Me.TBPAddRequest.Name = "TBPAddRequest"
        Me.TBPAddRequest.Padding = New System.Windows.Forms.Padding(3)
        Me.TBPAddRequest.Size = New System.Drawing.Size(1292, 698)
        Me.TBPAddRequest.TabIndex = 0
        Me.TBPAddRequest.Text = "Add Request"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LimeGreen
        Me.TabPage2.Location = New System.Drawing.Point(4, 38)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1292, 698)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'DBDataSet
        '
        Me.DBDataSet.DataSetName = "DBDataSet"
        Me.DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BSrequestLog
        '
        Me.BSrequestLog.DataMember = "RequestLog"
        Me.BSrequestLog.DataSource = Me.DBDataSet
        '
        'RequestLogTableAdapter
        '
        Me.RequestLogTableAdapter.ClearBeforeFill = True
        '
        'BSRequestLookup
        '
        Me.BSRequestLookup.DataMember = "RequestLookup"
        Me.BSRequestLookup.DataSource = Me.DBDataSet
        '
        'RequestLookupTableAdapter
        '
        Me.RequestLookupTableAdapter.ClearBeforeFill = True
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
        'FRMrequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1536, 793)
        Me.Controls.Add(Me.TBCuser)
        Me.Name = "FRMrequest"
        Me.Text = "FRMrequest"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TBCuser.ResumeLayout(False)
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSrequestLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSRequestLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSusers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TBCuser As TabControl
    Friend WithEvents TBPAddRequest As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DBDataSet As DBDataSet
    Friend WithEvents BSrequestLog As BindingSource
    Friend WithEvents RequestLogTableAdapter As DBDataSetTableAdapters.RequestLogTableAdapter
    Friend WithEvents BSRequestLookup As BindingSource
    Friend WithEvents RequestLookupTableAdapter As DBDataSetTableAdapters.RequestLookupTableAdapter
    Friend WithEvents BSusers As BindingSource
    Friend WithEvents UsersTableAdapter As DBDataSetTableAdapters.UsersTableAdapter
End Class
