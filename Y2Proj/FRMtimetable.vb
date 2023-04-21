Public Class FRMtimetable

    ReadOnly UserID As Integer = FRMlogin.ID

    Dim StoredWeekStart As Date

    Private Sub FRMtimetable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet.RequestLookup' table. You can move, or remove it, as needed.
        Me.RequestLookupTableAdapter.Fill(Me.DBDataSet.RequestLookup)
        'TODO: This line of code loads data into the 'DBDataSet.RequestLog' table. You can move, or remove it, as needed.
        Me.RequestLogTableAdapter.Fill(Me.DBDataSet.RequestLog)

        'Settings up some features 
        With DGVRequestData
            .Font = fType()
            .Location = New Point(10, 522)
        End With

        With DGVtimetable
            .Font = fType()
            .Location = New Point(100, 50)
            .Size = New Size(1100, 300)
            .ColumnCount = 7
        End With

        With BTNLeftArrow
            .Image = Image.FromFile($"{AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 21)}Images\LeftArrow.png")
            .BackgroundImageLayout = ImageLayout.Zoom
            .Size = New Size(60, 60)
        End With

        With BTNRightArrow
            .Image = Image.FromFile($"{AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 21)}Images\RightArrow.png")
            .BackgroundImageLayout = ImageLayout.Zoom
            .Size = New Size(60, 60)
        End With

        ' Gets the correct date for the label

        StoredWeekStart = BeginningOfWeek(Today)

        GetWeeksActivities()

    End Sub

    Private Sub DGVtimetable_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVtimetable.CellMouseClick
        Dim RequestID As Integer = -1

        Try
            RequestID = CInt(InputBox($"Please enter the request ID to add an event to {DGVtimetable.Columns(e.ColumnIndex).HeaderText}."))
        Catch ex As Exception
            MsgBox("You did not enter a number.")
            Exit Sub
        End Try

        If RequestID = -1 Then
            Exit Sub
        End If
        ' If the user has selected a reqeust it will link the reqeust to the user
        DBDataSet.RequestLookup.Rows.Add()

        Dim LastRow As Integer = DBDataSet.RequestLookup.Rows.Count - 1

        If LastRow = -1 Then
            LastRow = 0
        End If

        With DBDataSet.RequestLookup
            .Item(LastRow).RequestID = RequestID
            .Item(LastRow).UserID = UserID
            .Item(LastRow).ConfirmedEndDate = StoredWeekStart.AddDays(e.ColumnIndex).ToString("d") ' Gets the day that the user selected
        End With

        Me.RequestLookupTableAdapter.Update(Me.DBDataSet.RequestLookup)
        Me.RequestLookupTableAdapter.Fill(Me.DBDataSet.RequestLookup)
        'Finds the request name and logs it with the user
        For i = 0 To DBDataSet.RequestLog.Rows.Count - 1
            If RequestID = DBDataSet.RequestLog.Item(i).ID Then
                FRMlogin.LogAction($"Linking user to request: {DBDataSet.RequestLog.Item(i).NameOfRequest}", Me.Name)
                Exit For
            End If
        Next

        GetWeeksActivities()

    End Sub

    Sub UpdateWeek(Optional Forward As Boolean = True)
        ' Moves through the weeks
        Dim Negative As Integer = -1

        If Forward Then
            Negative = 1
        End If

        StoredWeekStart = StoredWeekStart.AddDays(Negative * 7)

        LBLWeek.Text = $"Week commencing: {StoredWeekStart.ToString("D")}"

        Application.DoEvents()

    End Sub

    Sub CreateNewRow(Day As Integer)
        ' Creates a new blank row
        DGVtimetable.Rows.Add(New String() {"", "", "", "", "", "", ""})
        ' Selects a backcolor based on if the row is divisible by 2 wholey
        If DGVtimetable.Rows.Count Mod 2 = 0 Then
            DGVtimetable.Rows(DGVtimetable.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Aquamarine
        Else
            DGVtimetable.Rows(DGVtimetable.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Lime
        End If
    End Sub

    Sub GetWeeksActivities()

        DGVtimetable.Rows.Clear()

        Application.DoEvents()

        For day = 0 To 6
            For Each row In DBDataSet.RequestLookup
                If row.ConfirmedEndDate = StoredWeekStart.AddDays(day).ToString("d") Then
                    For Each item In DBDataSet.RequestLog
                        If item.ID = row.RequestID And row.UserID = UserID Then
                            ' Creates a new row only if needed / there is not enough space on that day
                            If (DGVtimetable.Rows.Count = 0) Then
                                CreateNewRow(day)
                            ElseIf (DGVtimetable.Item(day, DGVtimetable.Rows.Count - 1).Value <> "") Then
                                CreateNewRow(day)
                            End If

                            Dim ARLL As Integer = 0

                            For i = 0 To DGVtimetable.Rows.Count - 1
                                If DGVtimetable.Item(day, i).Value = "" Then
                                    ARLL = i
                                    i = DGVtimetable.Rows.Count - 1
                                End If
                            Next
                            ' Puts the data in the highest available space
                            DGVtimetable.Item(day, ARLL).Value = $"{item.NameOfRequest}"

                            Application.DoEvents()
                        End If
                    Next
                End If
            Next
        Next

    End Sub

    Private Sub BTNRightArrow_Click(sender As Object, e As EventArgs) Handles BTNRightArrow.Click

        UpdateWeek(Forward:=True)

        GetWeeksActivities()

    End Sub

    Private Sub BTNLeftArrow_Click(sender As Object, e As EventArgs) Handles BTNLeftArrow.Click

        UpdateWeek(Forward:=False)

        GetWeeksActivities()

    End Sub

    Private Sub FRMtimetable_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class