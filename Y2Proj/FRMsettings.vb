Public Class FRMsettings

    Structure SideBarOptionsControl
        Dim PCBDisplay As PictureBox
        Dim LBLDisplay As Label
    End Structure

    ReadOnly UserID As Integer = FRMlogin.ID

    Dim TillDisplay(12) As Button

    Dim SidebarOptions(5) As SideBarOptionsControl

    Dim UserLocation As Integer = -1

    Dim hidePassword As Boolean = True

    Private Sub FRMsettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.DBDataSet.Users)
        'TODO: This line of code loads data into the 'DBDataSet.Settings' table. You can move, or remove it, as needed.
        Me.SettingsTableAdapter.Fill(Me.DBDataSet.Settings)

        TBCmain.Font = fType()

        With DGVTillOptions
            .RowCount = 12
            .Font = fType()
        End With

        Dim TempUserLocation As Integer = FRMlogin.getUserLocation(FRMlogin.user)
        'Getting the users details to display
        TXTUsername.Text = FRMlogin.user
        TXTFullName.Text = DBDataSet.Users.Item(TempUserLocation).FullName
        TXTAddress.Text = DBDataSet.Users.Item(TempUserLocation).Address
        TXTEmail.Text = DBDataSet.Users.Item(TempUserLocation).Email
        'Hiding the password with a string of * with the same length as the password
        TXTPassword.Text = StrDup(DBDataSet.Users.Item(TempUserLocation).Password.Length, "*")
        ' Testing to see if the user has detils for the next of kin
        Try
            TXTNextOfKinName.Text = DBDataSet.Users.Item(TempUserLocation).NextOfKinName
            TXTNextOfKinContactINfo.Text = DBDataSet.Users.Item(TempUserLocation).NextOfKinContact
        Catch ex As Exception

        End Try

        LBLIcon.Text = FRMlogin.user

        PCBIcon.SizeMode = PictureBoxSizeMode.Zoom
        PCBIcon.Image = Image.FromFile($"{AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 21)}Images\DefaultIcon.png")

        ' Fill the DGV using the settings

        Dim ColCount As Integer = 0

        UserLocation = FRMlogin.getUserLocation(FRMlogin.user)

        For y = 1 To 3
            For x = 1 To 4

                ' Gets the users current settings
                Try
                    If DBDataSet.Settings.Rows(UserLocation)(10 + ColCount) <> "" Then
                        DGVTillOptions.Item(0, ColCount).Value = DBDataSet.Settings.Rows(UserLocation)(10 + ColCount)
                    End If
                Catch ex As Exception
                    DGVTillOptions.Item(0, ColCount).Value = ""
                End Try

                ' Displays the position of the setting when you are on the till

                DGVTillOptions.Item(1, ColCount).Value = y

                DGVTillOptions.Item(2, ColCount).Value = x

                ColCount += 1

            Next
        Next

        DisplayTillOptions()

        '

        DGVSidebarOptions.RowCount = 7
        'Sees if the user is eligable to see the logbook form
        If AccessLevel(Level:=DBDataSet.Users.Item(FRMlogin.getUserLocation(FRMlogin.user)).AccessLevel) = "Director" Then
            LBSidebarOptions.Items.Add("LogBook")
        End If

        SidebarOptions = {
            New SideBarOptionsControl With {.LBLDisplay = LBLOptionThree, .PCBDisplay = PCBOptionThree},
            New SideBarOptionsControl With {.LBLDisplay = LBLOptionFour, .PCBDisplay = PCBOptionFour},
            New SideBarOptionsControl With {.LBLDisplay = LBLOptionFive, .PCBDisplay = PCBOptionFive},
            New SideBarOptionsControl With {.LBLDisplay = LBLOptionSix, .PCBDisplay = PCBOptionSix},
            New SideBarOptionsControl With {.LBLDisplay = LBLOptionSeven, .PCBDisplay = PCBOptionSeven}
            }
        ' Puts the users setting sinto the displays
        For i = 4 To 8
            If DBDataSet.Settings.Rows(UserLocation)(i).ToString() <> "" Then
                SidebarOptions(i - 4).LBLDisplay.Text = DBDataSet.Settings.Rows(UserLocation)(i)
            End If
        Next

        For i = 0 To 6
            If DBDataSet.Settings.Rows(UserLocation)(i + 2).ToString <> "" Then
                DGVSidebarOptions.Item(1, i).Value = DBDataSet.Settings.Rows(UserLocation)(8 - i)
            End If
            DGVSidebarOptions.Item(0, i).Value = 7 - i
        Next
        ' creates the default settings for the data grid view
        DGVSidebarOptions.Item(1, 6).Value = "Settings"
        DGVSidebarOptions.Item(1, 5).Value = "Help"

    End Sub

    Sub DisplayTillOptions()

        Dim LBLContext As New Label

        With LBLContext
            .AutoSize = False
            .Size = New Size(10 + 110 * 3, 55 + 80 * 4)
            .Location = New Point(970, 53)
            .Text = "Display of selected options"
            .BackColor = Color.GreenYellow
            .Font = fType(FontSize:=20)
            .TextAlign = ContentAlignment.TopCenter
        End With

        TBPTillOptions.Controls.Add(LBLContext)
        ' Creates an array of button on the screen to represent the pots from the till screen
        For i = 0 To 11

            Dim NewButton As New Button

            With NewButton
                .Size = New Size(100, 75)
                .Location = New Point(980 + 110 * (i Mod 3), 103 + 80 * (i \ 3)) ' changes the location based on how far along it is
                .BackColor = Color.Red
                .Text = DGVTillOptions.Item(0, i).Value.ToString
                .Font = fType()
            End With

            'Puts the newly created button on the screen and in an array for later
            TillDisplay(i) = NewButton

            TBPTillOptions.Controls.Add(TillDisplay(i))

        Next

        LBLContext.SendToBack()

    End Sub

    Private Sub DGVTillOptions_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVTillOptions.CellMouseClick
        ' Ask's to remove item

        Dim answer As Integer
        'Makes sure the user wants to remov ethat option
        Try
            answer = MsgBox("Would you like to remove this option?", MsgBoxStyle.YesNo)
        Catch ex As Exception
            Exit Sub
        End Try

        If answer = 7 Then
            Exit Sub
        End If
        'Removes the option and logs it
        FRMlogin.LogAction($"Removed till option: {TillDisplay(e.RowIndex).Text}", Me.Name)

        DGVTillOptions.Item(0, e.RowIndex).Value = ""

        TillDisplay(e.RowIndex).Text = ""

    End Sub

    Private Sub LBOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBOptions.SelectedIndexChanged

        ' Asks which slot to add it to in the DGV

        Dim answer As Integer

        Try
            answer = CInt(InputBox($"Please enter the index to add {LBOptions.SelectedItem}."))
        Catch ex As Exception
            Exit Sub
        End Try
        ' If something is in the designated region it will double check the user is happy to replace the region with the new value
        If DGVTillOptions.Item(0, answer).Value <> "" Then
            Try
                If MsgBox("This index has an item in it, would you like to continue?", MsgBoxStyle.YesNo) = 7 Then
                    Exit Sub
                End If
            Catch ex As Exception
                Exit Sub
            End Try
        End If
        ' Replaces the selected value with the new one and logs it
        DGVTillOptions.Item(0, answer).Value = LBOptions.SelectedItem

        TillDisplay(answer).Text = LBOptions.SelectedItem

        FRMlogin.LogAction($"Adding till option: {LBOptions.SelectedItem} to slot {answer}", Me.Name)

    End Sub

    Private Sub BTNsaveOptions_Click(sender As Object, e As EventArgs) Handles BTNsaveOptions.Click
        ' Makes sure the database recieves a comprehendable string
        'Saves the ew settings
        For i = 0 To 11
            If DGVTillOptions.Item(0, i).Value <> "" Then
                DBDataSet.Settings.Rows(UserLocation)(10 + i) = DGVTillOptions.Item(0, i).Value
            Else
                DBDataSet.Settings.Rows(UserLocation)(10 + i) = ""
            End If
        Next

        Me.SettingsTableAdapter.Update(Me.DBDataSet.Settings)
        Me.SettingsTableAdapter.Fill(Me.DBDataSet.Settings)

        FRMlogin.LogAction("Saving recent changes of the till options", Me.Name)

    End Sub

    Private Sub LBSidebarOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBSidebarOptions.SelectedIndexChanged

        ' Checks to see if the option is already used

        Dim answer As Integer

        Try
            answer = Int(InputBox("What index would you like to put this option at?"))
        Catch ex As Exception
            MsgBox("Sorry something went wrong.")
            Exit Sub
        End Try

        If answer < 3 Then
            MsgBox("Sorry you cannot edit this option.")
            Exit Sub
        End If
        ' Double checks the user is happy to replace the selected index
        If SidebarOptions(answer - 3).LBLDisplay.Text <> $"Option {answer}" Then
            If MsgBox("This option is already in use. Would you like to carry on?", MessageBoxButtons.YesNo) = 7 Then
                Exit Sub
            End If
        End If

        ' Adds the option and logs it

        DGVSidebarOptions.Item(1, 7 - answer).Value = LBSidebarOptions.SelectedItem

        SidebarOptions(answer - 3).LBLDisplay.Text = LBSidebarOptions.SelectedItem

        FRMlogin.LogAction($"Adding / replacing slot {answer - 3} with {LBSidebarOptions.SelectedItem}", Me.Name)

    End Sub

    Private Sub DGVSidebarOptions_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGVSidebarOptions.CellMouseClick

        ' Checks that, that option is not nothing

        If e.RowIndex < 0 Then
            Exit Sub
        End If

        If DGVSidebarOptions.Item(1, e.RowIndex).Value = Nothing Then
            MsgBox("Nothing exists at that index.")
            Exit Sub
        End If

        ' Checks that the option is not the settings or help option

        If e.RowIndex = 5 Or e.RowIndex = 6 Then
            MsgBox("Sorry but you cannot remove this setting.")
            Exit Sub
        End If

        ' Asks to remove that option

        If MsgBox($"Would you like to remove {DGVSidebarOptions.Item(1, e.RowIndex).Value}?", MessageBoxButtons.YesNo) = 7 Then
            Exit Sub
        End If

        ' Removes that option

        FRMlogin.LogAction($"Removed sidebar option {SidebarOptions(4 - e.RowIndex).LBLDisplay.Text} from slot {7 - e.RowIndex}", Me.Name)

        DGVSidebarOptions.Item(1, e.RowIndex).Value = ""

        SidebarOptions(4 - e.RowIndex).LBLDisplay.Text = $"Option {7 - e.RowIndex}"

    End Sub

    Private Sub BTNSaveSidebarOptions_Click(sender As Object, e As EventArgs) Handles BTNSaveSidebarOptions.Click

        ' Checks if the user has used all the options or would rather exclude one

        For i = 0 To 6
            If DGVSidebarOptions.Item(1, i).Value = "" Or DGVSidebarOptions.Item(1, i).Value = Nothing Then
                If MsgBox("Are you sure you would like to leave a space blank?", MessageBoxButtons.YesNo) = 7 Then
                    Exit Sub
                Else
                    Exit For
                End If
            End If
        Next

        If MsgBox("Are you sure you would like to save?", MessageBoxButtons.YesNo) = 7 Then
            Exit Sub
        End If

        ' Updates the last 5 sidebar options

        For i = 4 To 7
            DBDataSet.Settings.Rows(UserLocation)(i) = DGVSidebarOptions.Item(1, 4 - (i - 4)).Value
        Next

        ' Updates and fills the database / table adapters

        SettingsTableAdapter.Update(DBDataSet.Settings)
        SettingsTableAdapter.Fill(DBDataSet.Settings)

        FRMlogin.LogAction("Saved recent changes to sidebar options", Me.Name)

        MsgBox("Save complete")

    End Sub

    Private Sub BTNAmend_Click(sender As Object, e As EventArgs) Handles BTNAmend.Click
        'Sees if the user has entered enough details
        If TXTFullName.Text = "" Then
            MsgBox("You need to enter a name")
            Exit Sub
        End If

        If TXTPassword.Text = "" Then
            MsgBox("You need to have a password")
            Exit Sub
        End If

        If TXTEmail.Text = "" Then
            MsgBox("You need to have an email")
            Exit Sub
        End If

        If TXTAddress.Text = "" Then
            MsgBox("You need an address")
            Exit Sub
        End If

        If TXTNextOfKinName.Text = "" Then
            MsgBox("You need to have someone who we can contact in emergencies")
            Exit Sub
        End If

        If TXTNextOfKinContactINfo.Text = "" Then
            MsgBox("Your next of kin needs to be contactable")
            Exit Sub
        End If
        'Replaces the users available details and logs it
        Dim userLoc = DBDataSet.Users.Item(FRMlogin.getUserLocation(FRMlogin.user))

        With userLoc
            .FullName = TXTFullName.Text
            .Password = TXTPassword.Text
            .Email = TXTEmail.Text
            .Address = TXTAddress.Text
            .NextOfKinName = TXTNextOfKinName.Text
            .NextOfKinContact = TXTNextOfKinContactINfo.Text
        End With

        Me.UsersTableAdapter.Update(Me.DBDataSet.Users)
        Me.UsersTableAdapter.Fill(Me.DBDataSet.Users)

        FRMlogin.LogAction("Amended recent changes to the users details", Me.Name)

    End Sub

    Private Sub FRMsettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub

    Private Sub BTNShowPassword_Click(sender As Object, e As EventArgs) Handles BTNShowPassword.Click
        'Shows the button and starts a timer to hide it
        'If clicked again it will hide the password and reset the timer
        If hidePassword Then
            TXTPassword.Text = DBDataSet.Users.Item(FRMlogin.getUserLocation(FRMlogin.user)).Password

            TMRPassword.Enabled = True
            TMRPassword.Start()
        Else
            TMRPassword_Tick(sender, e)
        End If

        hidePassword = Not hidePassword

    End Sub

    Private Sub TMRPassword_Tick(sender As Object, e As EventArgs) Handles TMRPassword.Tick
        ' hides the password
        TXTPassword.Text = StrDup(DBDataSet.Users.Item(FRMlogin.getUserLocation(FRMlogin.user)).Password.Length, "*")

        TMRPassword.Enabled = False

    End Sub
End Class