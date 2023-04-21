<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMtimetable
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
        Me.DGVRequestData = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormalDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ImportanceRankDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameOfSenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameOfRequestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionOfRequestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequestLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBDataSet = New Y2Proj.DBDataSet()
        Me.DGVtimetable = New System.Windows.Forms.DataGridView()
        Me.Sunday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tuesday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wednesday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Thursday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Friday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saturday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RequestLogTableAdapter = New Y2Proj.DBDataSetTableAdapters.RequestLogTableAdapter()
        Me.RequestLookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequestLookupTableAdapter = New Y2Proj.DBDataSetTableAdapters.RequestLookupTableAdapter()
        Me.BTNLeftArrow = New System.Windows.Forms.Button()
        Me.BTNRightArrow = New System.Windows.Forms.Button()
        Me.LBLWeek = New System.Windows.Forms.Label()
        CType(Me.DGVRequestData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVtimetable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestLookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVRequestData
        '
        Me.DGVRequestData.AllowUserToAddRows = False
        Me.DGVRequestData.AllowUserToDeleteRows = False
        Me.DGVRequestData.AutoGenerateColumns = False
        Me.DGVRequestData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVRequestData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVRequestData.BackgroundColor = System.Drawing.Color.LimeGreen
        Me.DGVRequestData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRequestData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FormalDataGridViewCheckBoxColumn, Me.ImportanceRankDataGridViewTextBoxColumn, Me.UsernameOfSenderDataGridViewTextBoxColumn, Me.NameOfRequestDataGridViewTextBoxColumn, Me.DescriptionOfRequestDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.DueDateDataGridViewTextBoxColumn, Me.LocationDataGridViewTextBoxColumn})
        Me.DGVRequestData.DataSource = Me.RequestLogBindingSource
        Me.DGVRequestData.GridColor = System.Drawing.Color.Gainsboro
        Me.DGVRequestData.Location = New System.Drawing.Point(12, 418)
        Me.DGVRequestData.Name = "DGVRequestData"
        Me.DGVRequestData.ReadOnly = True
        Me.DGVRequestData.Size = New System.Drawing.Size(1814, 460)
        Me.DGVRequestData.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 43
        '
        'FormalDataGridViewCheckBoxColumn
        '
        Me.FormalDataGridViewCheckBoxColumn.DataPropertyName = "Formal"
        Me.FormalDataGridViewCheckBoxColumn.HeaderText = "Formal"
        Me.FormalDataGridViewCheckBoxColumn.Name = "FormalDataGridViewCheckBoxColumn"
        Me.FormalDataGridViewCheckBoxColumn.ReadOnly = True
        Me.FormalDataGridViewCheckBoxColumn.Width = 44
        '
        'ImportanceRankDataGridViewTextBoxColumn
        '
        Me.ImportanceRankDataGridViewTextBoxColumn.DataPropertyName = "ImportanceRank"
        Me.ImportanceRankDataGridViewTextBoxColumn.HeaderText = "ImportanceRank"
        Me.ImportanceRankDataGridViewTextBoxColumn.Name = "ImportanceRankDataGridViewTextBoxColumn"
        Me.ImportanceRankDataGridViewTextBoxColumn.ReadOnly = True
        Me.ImportanceRankDataGridViewTextBoxColumn.Width = 111
        '
        'UsernameOfSenderDataGridViewTextBoxColumn
        '
        Me.UsernameOfSenderDataGridViewTextBoxColumn.DataPropertyName = "usernameOfSender"
        Me.UsernameOfSenderDataGridViewTextBoxColumn.HeaderText = "usernameOfSender"
        Me.UsernameOfSenderDataGridViewTextBoxColumn.Name = "UsernameOfSenderDataGridViewTextBoxColumn"
        Me.UsernameOfSenderDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsernameOfSenderDataGridViewTextBoxColumn.Width = 123
        '
        'NameOfRequestDataGridViewTextBoxColumn
        '
        Me.NameOfRequestDataGridViewTextBoxColumn.DataPropertyName = "NameOfRequest"
        Me.NameOfRequestDataGridViewTextBoxColumn.HeaderText = "NameOfRequest"
        Me.NameOfRequestDataGridViewTextBoxColumn.Name = "NameOfRequestDataGridViewTextBoxColumn"
        Me.NameOfRequestDataGridViewTextBoxColumn.ReadOnly = True
        Me.NameOfRequestDataGridViewTextBoxColumn.Width = 111
        '
        'DescriptionOfRequestDataGridViewTextBoxColumn
        '
        Me.DescriptionOfRequestDataGridViewTextBoxColumn.DataPropertyName = "DescriptionOfRequest"
        Me.DescriptionOfRequestDataGridViewTextBoxColumn.HeaderText = "DescriptionOfRequest"
        Me.DescriptionOfRequestDataGridViewTextBoxColumn.Name = "DescriptionOfRequestDataGridViewTextBoxColumn"
        Me.DescriptionOfRequestDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriptionOfRequestDataGridViewTextBoxColumn.Width = 136
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.StatusDataGridViewTextBoxColumn.Width = 60
        '
        'DueDateDataGridViewTextBoxColumn
        '
        Me.DueDateDataGridViewTextBoxColumn.DataPropertyName = "Due date"
        Me.DueDateDataGridViewTextBoxColumn.HeaderText = "Due date"
        Me.DueDateDataGridViewTextBoxColumn.Name = "DueDateDataGridViewTextBoxColumn"
        Me.DueDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.DueDateDataGridViewTextBoxColumn.Width = 76
        '
        'LocationDataGridViewTextBoxColumn
        '
        Me.LocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
        Me.LocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.LocationDataGridViewTextBoxColumn.Name = "LocationDataGridViewTextBoxColumn"
        Me.LocationDataGridViewTextBoxColumn.ReadOnly = True
        Me.LocationDataGridViewTextBoxColumn.Width = 73
        '
        'RequestLogBindingSource
        '
        Me.RequestLogBindingSource.DataMember = "RequestLog"
        Me.RequestLogBindingSource.DataSource = Me.DBDataSet
        '
        'DBDataSet
        '
        Me.DBDataSet.DataSetName = "DBDataSet"
        Me.DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DGVtimetable
        '
        Me.DGVtimetable.AllowUserToAddRows = False
        Me.DGVtimetable.AllowUserToDeleteRows = False
        Me.DGVtimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVtimetable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVtimetable.BackgroundColor = System.Drawing.Color.LimeGreen
        Me.DGVtimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVtimetable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sunday, Me.Monday, Me.Tuesday, Me.Wednesday, Me.Thursday, Me.Friday, Me.Saturday})
        Me.DGVtimetable.GridColor = System.Drawing.Color.Gainsboro
        Me.DGVtimetable.Location = New System.Drawing.Point(88, 49)
        Me.DGVtimetable.Name = "DGVtimetable"
        Me.DGVtimetable.ReadOnly = True
        Me.DGVtimetable.Size = New System.Drawing.Size(1343, 317)
        Me.DGVtimetable.TabIndex = 1
        '
        'Sunday
        '
        Me.Sunday.HeaderText = "Sunday"
        Me.Sunday.Name = "Sunday"
        Me.Sunday.ReadOnly = True
        Me.Sunday.Width = 68
        '
        'Monday
        '
        Me.Monday.HeaderText = "Monday"
        Me.Monday.Name = "Monday"
        Me.Monday.ReadOnly = True
        Me.Monday.Width = 70
        '
        'Tuesday
        '
        Me.Tuesday.HeaderText = "Tuesday"
        Me.Tuesday.Name = "Tuesday"
        Me.Tuesday.ReadOnly = True
        Me.Tuesday.Width = 73
        '
        'Wednesday
        '
        Me.Wednesday.HeaderText = "Wednesday"
        Me.Wednesday.Name = "Wednesday"
        Me.Wednesday.ReadOnly = True
        Me.Wednesday.Width = 89
        '
        'Thursday
        '
        Me.Thursday.HeaderText = "Thursday"
        Me.Thursday.Name = "Thursday"
        Me.Thursday.ReadOnly = True
        Me.Thursday.Width = 76
        '
        'Friday
        '
        Me.Friday.HeaderText = "Friday"
        Me.Friday.Name = "Friday"
        Me.Friday.ReadOnly = True
        Me.Friday.Width = 60
        '
        'Saturday
        '
        Me.Saturday.HeaderText = "Saturday"
        Me.Saturday.Name = "Saturday"
        Me.Saturday.ReadOnly = True
        Me.Saturday.Width = 74
        '
        'RequestLogTableAdapter
        '
        Me.RequestLogTableAdapter.ClearBeforeFill = True
        '
        'RequestLookupBindingSource
        '
        Me.RequestLookupBindingSource.DataMember = "RequestLookup"
        Me.RequestLookupBindingSource.DataSource = Me.DBDataSet
        '
        'RequestLookupTableAdapter
        '
        Me.RequestLookupTableAdapter.ClearBeforeFill = True
        '
        'BTNLeftArrow
        '
        Me.BTNLeftArrow.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLeftArrow.Location = New System.Drawing.Point(12, 115)
        Me.BTNLeftArrow.Name = "BTNLeftArrow"
        Me.BTNLeftArrow.Size = New System.Drawing.Size(60, 60)
        Me.BTNLeftArrow.TabIndex = 2
        Me.BTNLeftArrow.UseVisualStyleBackColor = True
        '
        'BTNRightArrow
        '
        Me.BTNRightArrow.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRightArrow.Location = New System.Drawing.Point(12, 49)
        Me.BTNRightArrow.Name = "BTNRightArrow"
        Me.BTNRightArrow.Size = New System.Drawing.Size(60, 60)
        Me.BTNRightArrow.TabIndex = 3
        Me.BTNRightArrow.UseVisualStyleBackColor = True
        '
        'LBLWeek
        '
        Me.LBLWeek.AutoSize = True
        Me.LBLWeek.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLWeek.Location = New System.Drawing.Point(83, 9)
        Me.LBLWeek.Name = "LBLWeek"
        Me.LBLWeek.Size = New System.Drawing.Size(195, 29)
        Me.LBLWeek.TabIndex = 4
        Me.LBLWeek.Text = "Week commencing:"
        '
        'FRMtimetable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(1398, 731)
        Me.Controls.Add(Me.LBLWeek)
        Me.Controls.Add(Me.BTNRightArrow)
        Me.Controls.Add(Me.BTNLeftArrow)
        Me.Controls.Add(Me.DGVtimetable)
        Me.Controls.Add(Me.DGVRequestData)
        Me.Name = "FRMtimetable"
        Me.Text = "FRMtimetable"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVRequestData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVtimetable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestLookupBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DBDataSet As DBDataSet
    Friend WithEvents RequestLogBindingSource As BindingSource
    Friend WithEvents RequestLogTableAdapter As DBDataSetTableAdapters.RequestLogTableAdapter
    Friend WithEvents DGVRequestData As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FormalDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ImportanceRankDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameOfSenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameOfRequestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionOfRequestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DueDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DGVtimetable As DataGridView
    Friend WithEvents Sunday As DataGridViewTextBoxColumn
    Friend WithEvents Monday As DataGridViewTextBoxColumn
    Friend WithEvents Tuesday As DataGridViewTextBoxColumn
    Friend WithEvents Wednesday As DataGridViewTextBoxColumn
    Friend WithEvents Thursday As DataGridViewTextBoxColumn
    Friend WithEvents Friday As DataGridViewTextBoxColumn
    Friend WithEvents Saturday As DataGridViewTextBoxColumn
    Friend WithEvents RequestLookupBindingSource As BindingSource
    Friend WithEvents RequestLookupTableAdapter As DBDataSetTableAdapters.RequestLookupTableAdapter
    Friend WithEvents BTNLeftArrow As Button
    Friend WithEvents BTNRightArrow As Button
    Friend WithEvents LBLWeek As Label
End Class
