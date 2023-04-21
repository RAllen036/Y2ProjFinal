Public Class FRMlogBook
    Private Sub FRMlobBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet.LogBook' table. You can move, or remove it, as needed.
        Me.LogBookTableAdapter.Fill(Me.DBDataSet.LogBook)

        DGVLogBook.Font = fType()

        DGVLogBook.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DGVLogBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        ' Search through the userid, actions and dates for every unique one

        For Each item In DBDataSet.LogBook.Rows
            If Not CBOAction.Items.Contains(item.Action) Then
                CBOAction.Items.Add(item.Action)
            End If
            If Not CBOUserID.Items.Contains(item.UserID) Then
                CBOUserID.Items.Add(item.UserID)
            End If
            If Not CBODate.Items.Contains(item._Date) Then
                CBODate.Items.Add(item._Date)
            End If
        Next

    End Sub

    Private Sub BTNFilter_Click(sender As Object, e As EventArgs) Handles BTNFilter.Click

        LogBook.RemoveFilter()

        ' Puts a filter on the Bindingsource depending on which has been selected

        If CBOUserID.SelectedItem IsNot Nothing Then
            Try
                LogBook.Filter = $"UserID = {CInt(CBOUserID.SelectedItem)}"
                Exit Sub
            Catch ex As Exception

            End Try
        End If

        If CBOAction.SelectedItem IsNot Nothing Then
            Try
                LogBook.Filter = $"Action LIKE '%{CBOAction.SelectedItem}%'"
                Exit Sub
            Catch ex As Exception

            End Try
        End If

        If CBODate.SelectedItem IsNot Nothing Then
            Try
                LogBook.Filter = $"[Date] = #{CDate(CBODate.SelectedItem).ToString("yyyy-MM-dd")}#"
                Exit Sub
            Catch ex As Exception

            End Try
        End If

    End Sub
End Class