Imports System.Net.Mail
Module MODgetConst

    ' In short this funtion returns a font that you can use in a label etc

    ' This function uses optional variables so that you can use different or similar fonts depending on use

    ' The optional type means that you do not need to specify that variable but if you wish you could change it somewhere else

    Public Function fType(Optional ByVal familyName As String = "Comic Sans MS",
                          Optional ByVal FontSize As Integer = 25.0!,
                          Optional ByVal style As FontStyle = FontStyle.Regular,
                          Optional ByVal type As GraphicsUnit = GraphicsUnit.Pixel)

        Return New Font(familyName, FontSize, style, type, CType(0, Byte))

    End Function

    Public Function screenSize(Optional BigScreen As Boolean = False)

        If BigScreen Then
            Return New Size(1936, 1056)
        Else
            Return New Size(1552, 832)
        End If

    End Function

    Public Function AccessLevel(Optional Text As String = "Resident", Optional Level As Integer = 1, Optional Backwards As Boolean = False)

        If Backwards Then
            Select Case Text
                Case "Employee"
                    Return 2
                Case "Director"
                    Return 3
                Case "Admin"
                    Return 4
                Case Else
                    Return 1
            End Select
        Else
            Select Case Level
                Case 2
                    Return "Employee"
                Case 3
                    Return "Director"
                Case 4
                    Return "Admin"
                Case Else
                    Return "Resident"
            End Select
        End If


    End Function

    Public Sub GetFormTopBar(obj As Form)

        With obj
            .WindowState = FormWindowState.Maximized
            .Font = fType()
            .AutoScaleMode = AutoScaleMode.None
            '.Icon = 
        End With

    End Sub

    Sub SendEmail(recipient As String, message As String, Title As String)

        message = $"{message} {Environment.NewLine}Best wishes, {Environment.NewLine}The office's automatic emailing system."

        ' Send email

        If MsgBox("Would you like email confimation?", MsgBoxStyle.YesNo) = 7 Then
            Exit Sub
        End If

        Dim emailSender As String = "GPHES2023@outlook.com"
        Dim senderPassword As String = "@Kimble4me"

        Try

            Dim SmtpServer As New SmtpClient
            Dim eMail As New MailMessage()

            With SmtpServer
                .UseDefaultCredentials = False
                .Credentials = New Net.NetworkCredential(emailSender, senderPassword)
                .Port = 587
                .EnableSsl = True
                .Host = "smtp.office365.com"
            End With

            With eMail
                .From = New MailAddress(emailSender)
                .To.Add(recipient)
                .Subject = Title
                .IsBodyHtml = False
                .Body = message
            End With

            SmtpServer.Send(eMail)

            FRMlogin.LogAction($"System sent an email to {recipient}", "MODgetConst")

            MsgBox("Email has been sent")

        Catch ex As Exception
            MsgBox("Email could not be sent")
        End Try

    End Sub

    Function BeginningOfWeek(day As Date)

        Dim StartOfWeek As Date

        For extraDays = 0 To 7
            If Today.AddDays(-1 * extraDays).ToString("ddd").Substring(0, 2) = "Su" Then
                StartOfWeek = day.AddDays(-1 * extraDays)
                Exit For
            End If
        Next

        Return StartOfWeek

    End Function

End Module
