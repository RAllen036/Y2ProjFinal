<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMlogBook
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
        Me.DGVLogBook = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogBook = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBDataSet = New Y2Proj.DBDataSet()
        Me.LogBookTableAdapter = New Y2Proj.DBDataSetTableAdapters.LogBookTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CBOUserID = New System.Windows.Forms.ComboBox()
        Me.CBOAction = New System.Windows.Forms.ComboBox()
        Me.BTNFilter = New System.Windows.Forms.Button()
        Me.LBLUserID = New System.Windows.Forms.Label()
        Me.LBLAction = New System.Windows.Forms.Label()
        Me.LBLDate = New System.Windows.Forms.Label()
        Me.CBODate = New System.Windows.Forms.ComboBox()
        CType(Me.DGVLogBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVLogBook
        '
        Me.DGVLogBook.AllowUserToAddRows = False
        Me.DGVLogBook.AllowUserToDeleteRows = False
        Me.DGVLogBook.AllowUserToResizeColumns = False
        Me.DGVLogBook.AllowUserToResizeRows = False
        Me.DGVLogBook.AutoGenerateColumns = False
        Me.DGVLogBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVLogBook.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ActionDataGridViewTextBoxColumn, Me.UserIDDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn})
        Me.DGVLogBook.DataSource = Me.LogBook
        Me.DGVLogBook.Location = New System.Drawing.Point(12, 12)
        Me.DGVLogBook.Name = "DGVLogBook"
        Me.DGVLogBook.ReadOnly = True
        Me.DGVLogBook.Size = New System.Drawing.Size(937, 740)
        Me.DGVLogBook.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActionDataGridViewTextBoxColumn
        '
        Me.ActionDataGridViewTextBoxColumn.DataPropertyName = "Action"
        Me.ActionDataGridViewTextBoxColumn.HeaderText = "Action"
        Me.ActionDataGridViewTextBoxColumn.Name = "ActionDataGridViewTextBoxColumn"
        Me.ActionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LogBook
        '
        Me.LogBook.DataMember = "LogBook"
        Me.LogBook.DataSource = Me.DBDataSet
        '
        'DBDataSet
        '
        Me.DBDataSet.DataSetName = "DBDataSet"
        Me.DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LogBookTableAdapter
        '
        Me.LogBookTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CBODate)
        Me.Panel1.Controls.Add(Me.LBLDate)
        Me.Panel1.Controls.Add(Me.LBLAction)
        Me.Panel1.Controls.Add(Me.LBLUserID)
        Me.Panel1.Controls.Add(Me.BTNFilter)
        Me.Panel1.Controls.Add(Me.CBOAction)
        Me.Panel1.Controls.Add(Me.CBOUserID)
        Me.Panel1.Location = New System.Drawing.Point(973, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(617, 405)
        Me.Panel1.TabIndex = 2
        '
        'DBDataSetBindingSource
        '
        Me.DBDataSetBindingSource.DataSource = Me.DBDataSet
        Me.DBDataSetBindingSource.Position = 0
        '
        'CBOUserID
        '
        Me.CBOUserID.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOUserID.FormattingEnabled = True
        Me.CBOUserID.Location = New System.Drawing.Point(181, 61)
        Me.CBOUserID.Name = "CBOUserID"
        Me.CBOUserID.Size = New System.Drawing.Size(231, 37)
        Me.CBOUserID.TabIndex = 0
        '
        'CBOAction
        '
        Me.CBOAction.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBOAction.FormattingEnabled = True
        Me.CBOAction.Location = New System.Drawing.Point(26, 155)
        Me.CBOAction.Name = "CBOAction"
        Me.CBOAction.Size = New System.Drawing.Size(568, 37)
        Me.CBOAction.TabIndex = 1
        '
        'BTNFilter
        '
        Me.BTNFilter.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNFilter.Location = New System.Drawing.Point(221, 319)
        Me.BTNFilter.Name = "BTNFilter"
        Me.BTNFilter.Size = New System.Drawing.Size(182, 53)
        Me.BTNFilter.TabIndex = 3
        Me.BTNFilter.Text = "Filter"
        Me.BTNFilter.UseVisualStyleBackColor = True
        '
        'LBLUserID
        '
        Me.LBLUserID.AutoSize = True
        Me.LBLUserID.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUserID.Location = New System.Drawing.Point(230, 29)
        Me.LBLUserID.Name = "LBLUserID"
        Me.LBLUserID.Size = New System.Drawing.Size(131, 29)
        Me.LBLUserID.TabIndex = 4
        Me.LBLUserID.Text = "Pick UserID"
        '
        'LBLAction
        '
        Me.LBLAction.AutoSize = True
        Me.LBLAction.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLAction.Location = New System.Drawing.Point(243, 123)
        Me.LBLAction.Name = "LBLAction"
        Me.LBLAction.Size = New System.Drawing.Size(124, 29)
        Me.LBLAction.TabIndex = 5
        Me.LBLAction.Text = "Pick Action"
        '
        'LBLDate
        '
        Me.LBLDate.AutoSize = True
        Me.LBLDate.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDate.Location = New System.Drawing.Point(255, 220)
        Me.LBLDate.Name = "LBLDate"
        Me.LBLDate.Size = New System.Drawing.Size(106, 29)
        Me.LBLDate.TabIndex = 6
        Me.LBLDate.Text = "Pick Date"
        '
        'CBODate
        '
        Me.CBODate.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBODate.FormattingEnabled = True
        Me.CBODate.Location = New System.Drawing.Point(26, 252)
        Me.CBODate.Name = "CBODate"
        Me.CBODate.Size = New System.Drawing.Size(568, 37)
        Me.CBODate.TabIndex = 7
        '
        'FRMlogBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.ClientSize = New System.Drawing.Size(1602, 764)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DGVLogBook)
        Me.Name = "FRMlogBook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log Book"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVLogBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVLogBook As DataGridView
    Friend WithEvents LogBook As BindingSource
    Friend WithEvents DBDataSet As DBDataSet
    Friend WithEvents LogBookTableAdapter As DBDataSetTableAdapters.LogBookTableAdapter
    Friend WithEvents TimeOfDayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DBDataSetBindingSource As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CBOAction As ComboBox
    Friend WithEvents CBOUserID As ComboBox
    Friend WithEvents BTNFilter As Button
    Friend WithEvents LBLDate As Label
    Friend WithEvents LBLAction As Label
    Friend WithEvents LBLUserID As Label
    Friend WithEvents CBODate As ComboBox
End Class
