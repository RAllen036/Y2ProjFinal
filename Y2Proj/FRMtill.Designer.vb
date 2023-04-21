<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMtill
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.TBCtill = New System.Windows.Forms.TabControl()
        Me.TBPTill = New System.Windows.Forms.TabPage()
        Me.TBPTillUp = New System.Windows.Forms.TabPage()
        Me.DGVTransactionTillUp = New System.Windows.Forms.DataGridView()
        Me.TransactionID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransactionTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVPotTillUp = New System.Windows.Forms.DataGridView()
        Me.PotName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoneyTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBPStats = New System.Windows.Forms.TabPage()
        Me.CHRTStats = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TillRollLog = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBDataSet = New Y2Proj.DBDataSet()
        Me.Settings = New System.Windows.Forms.BindingSource(Me.components)
        Me.SettingsTableAdapter = New Y2Proj.DBDataSetTableAdapters.SettingsTableAdapter()
        Me.ItemTillLookup = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemTIllLookupTableAdapter = New Y2Proj.DBDataSetTableAdapters.ItemTIllLookupTableAdapter()
        Me.TillRollLogTableAdapter = New Y2Proj.DBDataSetTableAdapters.TillRollLogTableAdapter()
        Me.TBCtill.SuspendLayout()
        Me.TBPTillUp.SuspendLayout()
        CType(Me.DGVTransactionTillUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVPotTillUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TBPStats.SuspendLayout()
        CType(Me.CHRTStats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TillRollLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Settings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemTillLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBCtill
        '
        Me.TBCtill.Controls.Add(Me.TBPTill)
        Me.TBCtill.Controls.Add(Me.TBPTillUp)
        Me.TBCtill.Controls.Add(Me.TBPStats)
        Me.TBCtill.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBCtill.Location = New System.Drawing.Point(12, 12)
        Me.TBCtill.Name = "TBCtill"
        Me.TBCtill.SelectedIndex = 0
        Me.TBCtill.Size = New System.Drawing.Size(961, 571)
        Me.TBCtill.TabIndex = 0
        '
        'TBPTill
        '
        Me.TBPTill.BackColor = System.Drawing.Color.LimeGreen
        Me.TBPTill.Location = New System.Drawing.Point(4, 35)
        Me.TBPTill.Name = "TBPTill"
        Me.TBPTill.Padding = New System.Windows.Forms.Padding(3)
        Me.TBPTill.Size = New System.Drawing.Size(953, 532)
        Me.TBPTill.TabIndex = 0
        Me.TBPTill.Text = "Till"
        '
        'TBPTillUp
        '
        Me.TBPTillUp.BackColor = System.Drawing.Color.LimeGreen
        Me.TBPTillUp.Controls.Add(Me.DGVTransactionTillUp)
        Me.TBPTillUp.Controls.Add(Me.DGVPotTillUp)
        Me.TBPTillUp.Location = New System.Drawing.Point(4, 35)
        Me.TBPTillUp.Name = "TBPTillUp"
        Me.TBPTillUp.Padding = New System.Windows.Forms.Padding(3)
        Me.TBPTillUp.Size = New System.Drawing.Size(953, 532)
        Me.TBPTillUp.TabIndex = 1
        Me.TBPTillUp.Text = "Till Up"
        '
        'DGVTransactionTillUp
        '
        Me.DGVTransactionTillUp.AllowUserToAddRows = False
        Me.DGVTransactionTillUp.AllowUserToDeleteRows = False
        Me.DGVTransactionTillUp.AllowUserToResizeColumns = False
        Me.DGVTransactionTillUp.AllowUserToResizeRows = False
        Me.DGVTransactionTillUp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVTransactionTillUp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVTransactionTillUp.BackgroundColor = System.Drawing.Color.Green
        Me.DGVTransactionTillUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTransactionTillUp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionID, Me.TransactionDay, Me.PaymentType, Me.TransactionTotal})
        Me.DGVTransactionTillUp.Location = New System.Drawing.Point(6, 263)
        Me.DGVTransactionTillUp.Name = "DGVTransactionTillUp"
        Me.DGVTransactionTillUp.ReadOnly = True
        Me.DGVTransactionTillUp.Size = New System.Drawing.Size(921, 255)
        Me.DGVTransactionTillUp.TabIndex = 1
        '
        'TransactionID
        '
        Me.TransactionID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TransactionID.HeaderText = "ID"
        Me.TransactionID.Name = "TransactionID"
        Me.TransactionID.ReadOnly = True
        Me.TransactionID.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TransactionID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TransactionID.Width = 42
        '
        'TransactionDay
        '
        Me.TransactionDay.HeaderText = "Day Of Transaction"
        Me.TransactionDay.Name = "TransactionDay"
        Me.TransactionDay.ReadOnly = True
        Me.TransactionDay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TransactionDay.Width = 173
        '
        'PaymentType
        '
        Me.PaymentType.HeaderText = "Payment Type"
        Me.PaymentType.Name = "PaymentType"
        Me.PaymentType.ReadOnly = True
        Me.PaymentType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PaymentType.Width = 126
        '
        'TransactionTotal
        '
        Me.TransactionTotal.HeaderText = "Total"
        Me.TransactionTotal.Name = "TransactionTotal"
        Me.TransactionTotal.ReadOnly = True
        Me.TransactionTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.TransactionTotal.Width = 64
        '
        'DGVPotTillUp
        '
        Me.DGVPotTillUp.AllowUserToAddRows = False
        Me.DGVPotTillUp.AllowUserToDeleteRows = False
        Me.DGVPotTillUp.AllowUserToResizeColumns = False
        Me.DGVPotTillUp.AllowUserToResizeRows = False
        Me.DGVPotTillUp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVPotTillUp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVPotTillUp.BackgroundColor = System.Drawing.Color.Green
        Me.DGVPotTillUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPotTillUp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PotName, Me.Amount, Me.Price, Me.MoneyTotal})
        Me.DGVPotTillUp.Location = New System.Drawing.Point(6, 6)
        Me.DGVPotTillUp.Name = "DGVPotTillUp"
        Me.DGVPotTillUp.ReadOnly = True
        Me.DGVPotTillUp.Size = New System.Drawing.Size(921, 255)
        Me.DGVPotTillUp.TabIndex = 0
        '
        'PotName
        '
        Me.PotName.HeaderText = "Pot Name"
        Me.PotName.Name = "PotName"
        Me.PotName.ReadOnly = True
        Me.PotName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.PotName.Width = 102
        '
        'Amount
        '
        Me.Amount.HeaderText = "Quantity"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        Me.Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Amount.Width = 95
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Price.Width = 61
        '
        'MoneyTotal
        '
        Me.MoneyTotal.HeaderText = "Total"
        Me.MoneyTotal.Name = "MoneyTotal"
        Me.MoneyTotal.ReadOnly = True
        Me.MoneyTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.MoneyTotal.Width = 64
        '
        'TBPStats
        '
        Me.TBPStats.BackColor = System.Drawing.Color.LimeGreen
        Me.TBPStats.Controls.Add(Me.CHRTStats)
        Me.TBPStats.Location = New System.Drawing.Point(4, 35)
        Me.TBPStats.Name = "TBPStats"
        Me.TBPStats.Size = New System.Drawing.Size(953, 532)
        Me.TBPStats.TabIndex = 2
        Me.TBPStats.Text = "Statistics"
        '
        'CHRTStats
        '
        ChartArea1.Name = "CHAMain"
        Me.CHRTStats.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.CHRTStats.Legends.Add(Legend1)
        Me.CHRTStats.Location = New System.Drawing.Point(18, 19)
        Me.CHRTStats.Name = "CHRTStats"
        Series1.BorderWidth = 5
        Series1.ChartArea = "CHAMain"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Legend = "Legend1"
        Series1.Name = "Profit"
        Series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.YValuesPerPoint = 2
        Me.CHRTStats.Series.Add(Series1)
        Me.CHRTStats.Size = New System.Drawing.Size(721, 570)
        Me.CHRTStats.TabIndex = 0
        Me.CHRTStats.Text = "CHRStats"
        Title1.Name = "TMoney"
        Title1.Text = "Money earned per day"
        Me.CHRTStats.Titles.Add(Title1)
        '
        'TillRollLog
        '
        Me.TillRollLog.DataMember = "TillRollLog"
        Me.TillRollLog.DataSource = Me.DBDataSet
        '
        'DBDataSet
        '
        Me.DBDataSet.DataSetName = "DBDataSet"
        Me.DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ItemTillLookup
        '
        Me.ItemTillLookup.DataMember = "ItemTIllLookup"
        Me.ItemTillLookup.DataSource = Me.DBDataSet
        '
        'ItemTIllLookupTableAdapter
        '
        Me.ItemTIllLookupTableAdapter.ClearBeforeFill = True
        '
        'TillRollLogTableAdapter
        '
        Me.TillRollLogTableAdapter.ClearBeforeFill = True
        '
        'FRMtill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(985, 654)
        Me.Controls.Add(Me.TBCtill)
        Me.Name = "FRMtill"
        Me.Text = "Till"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TBCtill.ResumeLayout(False)
        Me.TBPTillUp.ResumeLayout(False)
        CType(Me.DGVTransactionTillUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVPotTillUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TBPStats.ResumeLayout(False)
        CType(Me.CHRTStats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TillRollLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Settings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemTillLookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TBCtill As TabControl
    Friend WithEvents TBPTill As TabPage
    Friend WithEvents TBPTillUp As TabPage
    Friend WithEvents Settings As BindingSource
    Friend WithEvents DBDataSet As DBDataSet
    Friend WithEvents SettingsTableAdapter As DBDataSetTableAdapters.SettingsTableAdapter
    Friend WithEvents ItemTillLookup As BindingSource
    Friend WithEvents ItemTIllLookupTableAdapter As DBDataSetTableAdapters.ItemTIllLookupTableAdapter
    Friend WithEvents TillRollLog As BindingSource
    Friend WithEvents TillRollLogTableAdapter As DBDataSetTableAdapters.TillRollLogTableAdapter
    Friend WithEvents TBPStats As TabPage
    Friend WithEvents DGVPotTillUp As DataGridView
    Friend WithEvents DGVTransactionTillUp As DataGridView
    Friend WithEvents TransactionID As DataGridViewTextBoxColumn
    Friend WithEvents TransactionDay As DataGridViewTextBoxColumn
    Friend WithEvents PaymentType As DataGridViewTextBoxColumn
    Friend WithEvents TransactionTotal As DataGridViewTextBoxColumn
    Friend WithEvents PotName As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents MoneyTotal As DataGridViewTextBoxColumn
    Friend WithEvents CHRTStats As DataVisualization.Charting.Chart
End Class
