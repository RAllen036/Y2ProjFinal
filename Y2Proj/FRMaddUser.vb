Public Class FRMaddUser

    Private Sub FRMaddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet.Settings' table. You can move, or remove it, as needed.
        Me.SettingsTableAdapter.Fill(Me.DBDataSet.Settings)
        'TODO: This line of code loads data into the 'DBDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.DBDataSet.Users)



    End Sub

    Private Sub BTNconfirm_Click(sender As Object, e As EventArgs) Handles BTNconfirm.Click

        ' Checking to see if admin entered enough details

        If TXTFirstName.Text = "" Or TXTFirstName.Text = vbNullChar Then
            Exit Sub
        End If

        If TXTLastName.Text = "" Or TXTLastName.Text = vbNullChar Then
            Exit Sub
        End If

        If TXTaddress.Text = "" Or TXTaddress.Text = vbNullChar Then
            Exit Sub
        End If

        If TXTPassword.Text = "" Or TXTPassword.Text = vbNullChar Then
            Exit Sub
        End If

        If TXTPhoneNumber.Text = "" Or TXTPhoneNumber.Text = vbNullChar Then
            Exit Sub
        End If

        'Creates a new row  in the users table
        Dim row = DBDataSet.Users.NewUsersRow()

        Dim TempUsername As String
        Dim TempFullName As String

        Dim UserPos As String

        UserPos = CStr(DBDataSet.Users.Rows.Count)

        'Adds correst number of 0 to position e.g 1 to 0001

        While UserPos.Length - 1 < 3
            UserPos = $"0{UserPos}"
        End While

        'Turns the First and last name into the fullname
        TempFullName = $"{TXTFirstName.Text} {TXTLastName.Text}"
        'Creates the username from the initials of the new user and the position in the database
        TempUsername = $"{TXTFirstName.Text.Substring(0, 1)}{TXTLastName.Text.Substring(0, 1)}{UserPos}"
        'Puts the users details into the database
        With row
            .Username = TempUsername
            .FullName = TempFullName
            .PhoneNumber = TXTPhoneNumber.Text
            .Password = TXTPassword.Text
            .NextOfKinName = TXTNextOfKin.Text
            .NextOfKinContact = TXTNextOfKinContact.Text
            .AccessLevel = AccessLevel(Text:=CMBaccessLevel.SelectedText, Backwards:=True)
        End With

        ' Create the default settings

        Dim userSettings = DBDataSet.Settings.NewSettingsRow

        Dim slot5 As String = ""
        'Default if you are not resident
        If row.AccessLevel <> 1 Then
            slot5 = "Till"
        End If
        'Adds in the default sidebar and till options
        With userSettings
            .UserID = row.ID
            .SidebarSlot1 = "Settings"
            .SidebarSlot2 = "Help"
            .SidebarSlot3 = "Request"
            .SidebarSlot4 = "Timetable"
            .SidebarSlot5 = $"{slot5}"
            .SidebarSlot6 = ""
            .SidebarSlot7 = ""
            .IconPath = ""
            .TillSlot1 = "Electric"
            .TillSlot2 = "Standing Charge"
            .TillSlot3 = "Rent / Lettings"
            .TillSlot4 = "Misc."
            .TillSlot5 = "Gas Bottle"
            .TillSlot6 = "Pitch Fee"
            .TillSlot7 = "Paid Out"
            .TillSlot8 = ""
            .TillSlot9 = ""
            .TillSlot10 = ""
            .TillSlot11 = ""
            .TillSlot12 = ""
        End With

        'Logs the creation of a new user alongside the creator of the new user
        FRMlogin.LogAction($"{FRMlogin.user} created new user: {TempUsername}", Me.Name)

        ' Saves the users details and settings

        UsersTableAdapter.Update(DBDataSet.Users)
        UsersTableAdapter.Fill(DBDataSet.Users)

        SettingsTableAdapter.Update(DBDataSet.Settings)
        SettingsTableAdapter.Fill(DBDataSet.Settings)

    End Sub

End Class