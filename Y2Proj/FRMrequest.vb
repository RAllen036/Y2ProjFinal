Public Class FRMrequest

    ReadOnly ID As Integer = FRMlogin.ID
    ReadOnly Username As String = FRMlogin.user

    Dim pnlBigContainer As Panel
    Dim pnlInfoContainer As Panel
    Dim pnlRequestContainer As Panel
    Dim pnlAdminContainer As Panel
    Dim pnlConfirmContainer As Panel
    Dim txtRequestName As TextBox
    Dim txtRequestDescription As TextBox
    Dim dtpRequestDateTime As DateTimePicker
    Dim txtRequestLocation As TextBox
    Dim txtUserDisplay As TextBox
    Dim txtUserContact As TextBox
    Dim chbAdminFormal As CheckBox
    Dim cboAdminImportance As ComboBox
    Dim btnConfirmRequest As Button

    Private Sub FRMrequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet.RequestLookup' table. You can move, or remove it, as needed.
        Me.RequestLookupTableAdapter.Fill(Me.DBDataSet.RequestLookup)
        'TODO: This line of code loads data into the 'DBDataSet.RequestLog' table. You can move, or remove it, as needed.
        Me.RequestLogTableAdapter.Fill(Me.DBDataSet.RequestLog)
        'TODO: This line of code loads data into the 'DBDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.DBDataSet.Users)

        Dim temp As Boolean = temp = False

        If Me.Size = screenSize(BigScreen:=True) Then
            temp = True
        End If

        Dim tempsize As Size = screenSize(temp)

        TBCuser.Size = New Size(tempsize.Width - 250, tempsize.Height - 61)

        InnitAddingRequests()

    End Sub

    Sub UpdateTables()

        RequestLogTableAdapter.Update(DBDataSet.RequestLog)
        RequestLogTableAdapter.Fill(DBDataSet.RequestLog)

        RequestLookupTableAdapter.Update(DBDataSet.RequestLookup)
        RequestLookupTableAdapter.Fill(DBDataSet.RequestLookup)

    End Sub

    Sub InnitAddingRequests()

        ' Create the contaniner (overall)

        pnlBigContainer = New Panel

        With pnlBigContainer
            .Size = New Size()
            .Location = New Point()
            .BackColor = Color.DimGray
        End With

        ' Create the user information section

        pnlInfoContainer = New Panel With {
            .Size = New Size(320, 170),
            .Location = New Point(100, 180),
            .BackColor = Color.Green
        }

        Dim TempUserLabel As New Label With {
            .Text = "User Name:",
            .Font = fType(),
            .AutoSize = True,
            .Location = New Point(180, 185),
            .BackColor = Color.Green
        }

        txtUserDisplay = New TextBox With {
            .Size = New Size(150, 100),
            .Text = Username,
            .Location = New Point(180, 220),
            .Font = fType(),
            .TextAlign = HorizontalAlignment.Center
        }

        Dim tempContactLabel As New Label With {
            .Text = "Contact Info:",
            .Font = fType(),
            .AutoSize = False,
            .Size = New Size(300, 30),
            .TextAlign = ContentAlignment.TopCenter,
            .Location = New Point(110, 260),
            .BackColor = Color.Green
        }

        txtUserContact = New TextBox With {
            .Size = New Size(300, 100),
            .Text = "Email or phone number",
            .Location = New Point(110, 300),
            .Font = fType(),
            .TextAlign = HorizontalAlignment.Center
        }

        TBPAddRequest.Controls.Add(tempContactLabel)

        TBPAddRequest.Controls.Add(TempUserLabel)

        TBPAddRequest.Controls.Add(txtUserContact)

        TBPAddRequest.Controls.Add(txtUserDisplay)

        TBPAddRequest.Controls.Add(pnlInfoContainer)

        ' Create the request information

        pnlRequestContainer = New Panel With {
            .Size = New Size(750, 340),
            .Location = New Point(490, 180),
            .BackColor = Color.LightBlue
        }

        Dim TempRequestName As New Label With {
            .Text = "Request Name:",
            .Font = fType(),
            .AutoSize = False,
            .Size = New Size(400, 35),
            .Location = New Point(500, 190),
            .BackColor = Color.LightBlue,
            .TextAlign = ContentAlignment.TopCenter
        }

        txtRequestName = New TextBox With {
            .Size = New Size(300, 100),
            .Text = "Request Name",
            .Location = New Point(550, 235),
            .Font = fType(),
            .TextAlign = HorizontalAlignment.Center
        }

        Dim TempRequestDescription As New Label With {
            .Text = "Description:",
            .Font = fType(),
            .AutoSize = False,
            .Size = New Size(400, 35),
            .Location = New Point(500, 280),
            .BackColor = Color.LightBlue,
            .TextAlign = ContentAlignment.TopCenter
        }

        txtRequestDescription = New TextBox With {
            .AutoSize = False,
            .Multiline = True,
            .Size = New Size(400, 185),
            .Text = "Description",
            .Location = New Point(500, 325),
            .Font = fType(),
            .TextAlign = HorizontalAlignment.Center
        }

        Dim TempRequestDateTime As New Label With {
            .Text = "Request Due Date:",
            .Font = fType(),
            .AutoSize = False,
            .Size = New Size(280, 35),
            .Location = New Point(950, 190),
            .BackColor = Color.LightBlue,
            .TextAlign = ContentAlignment.TopCenter
        }

        dtpRequestDateTime = New DateTimePicker With {
            .AutoSize = False,
            .Size = New Size(280, 35),
            .Location = New Point(950, 235),
            .Font = fType()
        }

        Dim TempRequestLocation As New Label With {
            .Text = "Request Location:",
            .Font = fType(),
            .AutoSize = False,
            .Size = New Size(280, 35),
            .Location = New Point(950, 280),
            .BackColor = Color.LightBlue,
            .TextAlign = ContentAlignment.TopCenter
        }

        txtRequestLocation = New TextBox With {
            .AutoSize = False,
            .Multiline = True,
            .Size = New Size(280, 185),
            .Text = "Request Location",
            .Location = New Point(950, 325),
            .Font = fType(),
            .TextAlign = HorizontalAlignment.Center
        }

        TBPAddRequest.Controls.Add(TempRequestLocation)

        TBPAddRequest.Controls.Add(TempRequestDateTime)

        TBPAddRequest.Controls.Add(TempRequestName)

        TBPAddRequest.Controls.Add(TempRequestDescription)

        TBPAddRequest.Controls.Add(txtRequestLocation)

        TBPAddRequest.Controls.Add(dtpRequestDateTime)

        TBPAddRequest.Controls.Add(txtRequestDescription)

        TBPAddRequest.Controls.Add(txtRequestName)

        TBPAddRequest.Controls.Add(pnlRequestContainer)

        ' Create the admin only section

        Dim AdminContainerHeight As Integer = 950

        Dim tempSize As Size = screenSize(True)

        If Me.Size.Height = tempSize.Height Then
            AdminContainerHeight = tempSize.Height - 71
        End If

        pnlAdminContainer = New Panel With {
            .Size = New Size(225, AdminContainerHeight),
            .Location = New Point(1430, 10),
            .BackColor = Color.Yellow
        }

        Dim AdminOnlyLabel As New Label With {
            .Text = "Admin Only",
            .Size = New Size(225, 55),
            .Font = fType(),
            .Location = New Point(1430, 10),
            .BackColor = Color.Yellow,
            .BorderStyle = BorderStyle.FixedSingle,
            .TextAlign = ContentAlignment.MiddleCenter
        }

        chbAdminFormal = New CheckBox With {
            .AutoSize = True,
            .Text = "Formal?",
            .Location = New Point(1480, 90),
            .Font = fType(),
            .TextAlign = ContentAlignment.TopCenter,
            .BackColor = Color.Yellow
        }

        Dim TempAdminImportnace As New Label With {
            .Text = "Priority level:",
            .Size = New Size(225, 35),
            .Font = fType(),
            .Location = New Point(1430, 140),
            .BackColor = Color.Yellow,
            .TextAlign = ContentAlignment.MiddleCenter
        }

        cboAdminImportance = New ComboBox With {
            .Size = New Size(210, 40),
            .Location = New Point(1435, 190),
            .Font = fType()
        }

        cboAdminImportance.Items.Add("++")
        cboAdminImportance.Items.Add("+")
        cboAdminImportance.Items.Add("Neutral")
        cboAdminImportance.Items.Add("-")
        cboAdminImportance.Items.Add("--")

        TBPAddRequest.Controls.Add(TempAdminImportnace)

        TBPAddRequest.Controls.Add(AdminOnlyLabel)

        TBPAddRequest.Controls.Add(cboAdminImportance)

        TBPAddRequest.Controls.Add(chbAdminFormal)

        TBPAddRequest.Controls.Add(pnlAdminContainer)

        Dim level As String = "Resident"

        For i = 0 To DBDataSet.Users.Rows.Count - 1
            If DBDataSet.Users.Item(i).ID = ID Then
                level = AccessLevel(Level:=DBDataSet.Users.Item(i).AccessLevel)
            End If
        Next

        If level <> "Admin" Then ' Stops non admins from making "Important" requests like cutting there grass

            chbAdminFormal.Enabled = False

            cboAdminImportance.Enabled = False

        End If

        ' Create the confirm button

        pnlConfirmContainer = New Panel With {
            .Size = New Size(280, 130),
            .Location = New Point(120, 370),
            .BackColor = Color.Aqua
        }

        btnConfirmRequest = New Button With {
            .Text = "Confirm",
            .AutoSize = False,
            .Size = New Size(240, 90),
            .Location = New Point(140, 390),
            .Font = fType()
        }

        AddHandler btnConfirmRequest.Click, AddressOf Me.ConfirmClick

        TBPAddRequest.Controls.Add(btnConfirmRequest)

        TBPAddRequest.Controls.Add(pnlConfirmContainer)

        '

        TBPAddRequest.Controls.Add(Container)

    End Sub

    Sub ConfirmClick(sender As Object, e As EventArgs)

        ' Create a request in the request log

        Dim Formality As Boolean    ' Col 1
        Dim Importance As String    ' Col 2
        Dim RequestName As String   ' Col 3
        Dim Description As String   ' Col 4
        Dim DueDate As DateTime     ' Col 7
        Dim Location As String      ' Col 8

        Try
            'Getting the reqeusts details
            Formality = chbAdminFormal.Checked
            Importance = cboAdminImportance.SelectedItem
            RequestName = txtRequestName.Text
            Description = txtRequestDescription.Text
            DueDate = dtpRequestDateTime.Value
            Location = txtRequestLocation.Text
            ' Checking the requests details
            If RequestName = "" Or RequestName = "Request Name" Then
                MsgBox("You need to enter a name for the request.")
                Exit Sub
            End If

            If Description = "" Or Description = "Description" Then
                MsgBox("Please enter a small description atleast.")
                Exit Sub
            End If

            If Location = "" Or Location = "Request Location" Then
                MsgBox("Please enter a location.")
                Exit Sub
            End If

        Catch ex As Exception
            ' Reset the request details if they cannot be converted to the correct datatype
            Importance = "Neutral"
            RequestName = "Reqeust Name: "
            Description = "Description:"
            Location = "Location: "

            MsgBox("Invalid details entered.")

            Exit Sub

        End Try
        ' Making sure the Importance rank is usable
        If Importance = "" Then
            Importance = "Neutral"
        End If
        ' Making sure the user wants to create a new request
        If MsgBox("Would you like to continue?", MessageBoxButtons.YesNo) = 7 Then
            Exit Sub
        End If
        'Creating a new reqeust log row
        DBDataSet.RequestLog.Rows.Add()
        'Retrieving the Location / ID of the row
        Dim RequestID As Integer = Me.DBDataSet.RequestLog.Rows.Count - 1

        If RequestID = -1 Then
            RequestID = 0
        End If
        'Saving the requests details
        With Me.DBDataSet.RequestLog.Item(RequestID)
            .usernameOfSender = Username
            .Formal = Formality
            .ImportanceRank = Importance
            .NameOfRequest = RequestName
            .DescriptionOfRequest = Description
            .Due_date = DueDate.ToString("d")
            .Location = Location
        End With
        ' Sending email confirmation
        SendEmail(DBDataSet.Users.Item(FRMlogin.userLocation).Email, $"You have created a request for {RequestName} {Environment.NewLine}If you did not make this request then change your password on the forgot login form.", "Request confirmation")

        UpdateTables()

        ResetDisplay()
        ' Logging the creation of a new request and confirming request
        FRMlogin.LogAction($"Created new request: {RequestID}", Me.Name)

        MsgBox("Request has been logged.")

    End Sub

    Sub ResetDisplay()

        txtUserDisplay.Text = Username
        txtUserContact.Text = "Email or phone number"

        txtRequestName.Text = "Request Name"
        txtRequestDescription.Text = "Description"
        txtRequestLocation.Text = "Request Location"
        dtpRequestDateTime.Value = Today

        cboAdminImportance.SelectedItem = ""
        chbAdminFormal.Checked = False

    End Sub

    Private Sub FRMrequest_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Dispose()
    End Sub
End Class