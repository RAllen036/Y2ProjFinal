<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMmedical
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
        Me.DGVmedical = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComplicationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBDataSet = New Y2Proj.DBDataSet()
        Me.MedicalTableAdapter = New Y2Proj.DBDataSetTableAdapters.MedicalTableAdapter()
        Me.BSusers = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersTableAdapter = New Y2Proj.DBDataSetTableAdapters.UsersTableAdapter()
        CType(Me.DGVmedical, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSusers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVmedical
        '
        Me.DGVmedical.AllowUserToAddRows = False
        Me.DGVmedical.AllowUserToDeleteRows = False
        Me.DGVmedical.AutoGenerateColumns = False
        Me.DGVmedical.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGVmedical.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVmedical.BackgroundColor = System.Drawing.Color.Green
        Me.DGVmedical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVmedical.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FullName, Me.ComplicationDataGridViewTextBoxColumn, Me.UserIDDataGridViewTextBoxColumn})
        Me.DGVmedical.DataSource = Me.MedicalBindingSource
        Me.DGVmedical.Location = New System.Drawing.Point(355, 184)
        Me.DGVmedical.Name = "DGVmedical"
        Me.DGVmedical.ReadOnly = True
        Me.DGVmedical.Size = New System.Drawing.Size(1350, 665)
        Me.DGVmedical.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.IDDataGridViewTextBoxColumn.Width = 24
        '
        'FullName
        '
        Me.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.FullName.HeaderText = "Name"
        Me.FullName.Name = "FullName"
        Me.FullName.ReadOnly = True
        Me.FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.FullName.Width = 41
        '
        'ComplicationDataGridViewTextBoxColumn
        '
        Me.ComplicationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ComplicationDataGridViewTextBoxColumn.DataPropertyName = "Complication"
        Me.ComplicationDataGridViewTextBoxColumn.HeaderText = "Complication"
        Me.ComplicationDataGridViewTextBoxColumn.Name = "ComplicationDataGridViewTextBoxColumn"
        Me.ComplicationDataGridViewTextBoxColumn.ReadOnly = True
        Me.ComplicationDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ComplicationDataGridViewTextBoxColumn.Width = 73
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.UserIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.UserIDDataGridViewTextBoxColumn.Width = 46
        '
        'MedicalBindingSource
        '
        Me.MedicalBindingSource.DataMember = "Medical"
        Me.MedicalBindingSource.DataSource = Me.DBDataSet
        '
        'DBDataSet
        '
        Me.DBDataSet.DataSetName = "DBDataSet"
        Me.DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedicalTableAdapter
        '
        Me.MedicalTableAdapter.ClearBeforeFill = True
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
        'FRMmedical
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1519, 587)
        Me.Controls.Add(Me.DGVmedical)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FRMmedical"
        Me.Text = "Medical Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVmedical, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSusers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVmedical As DataGridView
    Friend WithEvents DBDataSet As DBDataSet
    Friend WithEvents MedicalBindingSource As BindingSource
    Friend WithEvents MedicalTableAdapter As DBDataSetTableAdapters.MedicalTableAdapter
    Friend WithEvents BSusers As BindingSource
    Friend WithEvents UsersTableAdapter As DBDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullName As DataGridViewTextBoxColumn
    Friend WithEvents ComplicationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
