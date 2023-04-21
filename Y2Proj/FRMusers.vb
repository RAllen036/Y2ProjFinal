Public Class FRMusers
    ReadOnly sideBar As New Sidebar
    ReadOnly User As String = FRMlogin.user
    ReadOnly ID As Integer = FRMlogin.ID

    Private Sub FRMusers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.DBDataSet.Users)

        'TODO: This line of code loads data into the 'DBDataSet.Settings' table. You can move, or remove it, as needed.
        Me.SettingsTableAdapter.Fill(Me.DBDataSet.Settings)

        '

        Me.WindowState = FormWindowState.Maximized

        ' Gets the settings associated with the user
        Dim Settings(6) As String

        Dim SettingsLocation As Integer

        For x = 0 To DBDataSet.Settings.Count - 1
            If DBDataSet.Settings.Item(x).UserID = ID Then
                SettingsLocation = x
                Exit For
            End If
        Next

        For i = 0 To 6
            Settings(i) = Me.DBDataSet.Settings.Rows(SettingsLocation)(i + 2).ToString
        Next
        'Sees if the user is eligable to see the create user button
        Dim tempAccessLevel As String = "Resident"

        For row = 0 To DBDataSet.Users.Rows.Count - 1
            If DBDataSet.Users.Item(row).ID = ID Then
                tempAccessLevel = AccessLevel(Level:=DBDataSet.Users.Item(row).AccessLevel)

                If DBDataSet.Users.Item(row).AccessLevel > 2 Then
                    BTNaddUser.Visible = True
                Else
                    BTNaddUser.Visible = False
                End If

                Exit For
            End If
        Next

        sideBar.Innit(Me, Settings, tempAccessLevel)

    End Sub

    Private Sub FRMusers_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub BTNaddUser_Click(sender As Object, e As EventArgs) Handles BTNaddUser.Click

        Me.Hide()

        FRMaddUser.ShowDialog()

        Me.Show()

    End Sub
End Class