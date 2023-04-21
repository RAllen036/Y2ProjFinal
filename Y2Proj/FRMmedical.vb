Public Class FRMmedical
    Private Sub FRMmedical_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.DBDataSet.Users)
        'TODO: This line of code loads data into the 'DBDataSet.Medical' table. You can move, or remove it, as needed.
        Me.MedicalTableAdapter.Fill(Me.DBDataSet.Medical)

        With DGVmedical
            .Font = fType(FontSize:=30)
        End With

        GetUserCol()

    End Sub

    Sub GetUserCol()

        Dim tempID As Integer
        ' Looks for the user in the medical table and displays all relevant rows to the data grid view
        For row = 0 To DBDataSet.Medical.Rows.Count - 1
            ' Colours every other row different to the previous
            If row Mod 2 = 0 Then
                DGVmedical.Rows(row).DefaultCellStyle.BackColor = Color.LimeGreen
            Else
                DGVmedical.Rows(row).DefaultCellStyle.BackColor = Color.YellowGreen
            End If
            ' Displays the users details
            tempID = CInt(DBDataSet.Medical.Item(row).UserID)

            For i = 0 To DBDataSet.Users.Rows.Count - 1

                If DBDataSet.Users.Rows(i)(0) = tempID Then

                    DGVmedical.Item(1, row).Value = DBDataSet.Users.Item(i).FullName

                End If

            Next

        Next
    End Sub
End Class