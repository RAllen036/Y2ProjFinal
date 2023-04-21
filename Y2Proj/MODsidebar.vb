Module MODsidebar

    Structure Slot
        Dim icon As PictureBox
        Dim text As Label
    End Structure

    Public Class Sidebar

        Private UserLevel As String

        Public container As Panel
        Public slots(6) As Slot
        Public icon As PictureBox
        Public userName As Label

        Public Sub Innit(form As Object, settings() As String, Level As String)

            UserLevel = Level

            Dim user As String = FRMlogin.user

            Dim barSize As New Size(70, form.Height)

            Dim iconImageLocation As String = "DefaultIcon"

            ' Creates the background panel
            Me.container = New Panel
            With Me.container
                .Size = barSize
                .Location = New Point(0, 0)
                .BackColor = Color.Gray
                .BorderStyle = BorderStyle.FixedSingle
            End With

            '
            Me.icon = New PictureBox

            With Me.icon
                .Size = New Size(50, 50)
                .Location = New Point(10, 10)
                .BackColor = Color.Gainsboro
                .BorderStyle = BorderStyle.FixedSingle
                .SizeMode = PictureBoxSizeMode.Zoom
                .Image = Image.FromFile($"{AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 21)}Images\{iconImageLocation}.png")
            End With

            AddHandler Me.icon.Click, AddressOf Me.Expand

            '

            Me.userName = New Label
            With Me.userName
                .Size = Me.icon.Size
                .AutoSize = True
                .Location = New Point(Me.icon.Location.X + Me.icon.Width + 10, Me.icon.Location.Y + 5)
                .Text = $"{user}"
                .Font = fType(FontSize:=30)
                .Visible = False
                .Enabled = False
                .BackColor = Color.Gray
            End With

            form.Controls.Add(Me.userName)

            form.Controls.Add(Me.icon)

            '

            For i = 0 To slots.Length - 1
                '

                Dim sIcon As New PictureBox With
                {
                .Size = Me.icon.Size,
                .Location = New Point(Me.icon.Location.X, form.Height - (100 + (i * 60))),
                .BackColor = Color.Gainsboro,
                .BorderStyle = BorderStyle.FixedSingle,
                .Name = settings(i)
                }

                '
                Dim sLabel As New Label

                With sLabel
                    .Name = $"{settings(i)}"
                    .Location = New Point(sIcon.Location.X + sIcon.Width + 15, sIcon.Location.Y + 5)
                    .Font = fType(FontSize:=30)
                    .Text = $"{settings(i)}"
                    .BackColor = Me.container.BackColor
                    .BorderStyle = BorderStyle.FixedSingle
                    .AutoSize = True
                    .Enabled = False
                    .Visible = False
                End With

                If settings(i) = "" Then
                    sLabel.BorderStyle = BorderStyle.None
                End If

                '
                Me.slots(i) = New Slot
                With Me.slots(i)
                    .icon = sIcon
                    .text = sLabel
                End With

                AddHandler Me.slots(i).icon.Click, AddressOf Me.SlotClick
                AddHandler Me.slots(i).text.Click, AddressOf Me.SlotClick

                '
                form.Controls.Add(Me.slots(i).icon)
                form.Controls.Add(Me.slots(i).text)

            Next

            AddHandler Me.container.Click, AddressOf Me.Expand

            form.Controls.Add(Me.container)

        End Sub

        Sub Expand(sender As Object, e As EventArgs)

            Static expanded As Boolean = False

            '
            If expanded Then
                Me.container.Size = New Size(70, Form.ActiveForm.Height)
            Else
                Me.container.Size = New Size(280, Form.ActiveForm.Height)
            End If

            '
            expanded = Not expanded

            Me.userName.Enabled = expanded
            Me.userName.Visible = expanded

            '
            For i = 0 To slots.Length - 1
                Me.slots(i).text.Enabled = expanded
                Me.slots(i).text.Visible = expanded
            Next

        End Sub

        Sub SlotClick(sender As Object, e As EventArgs)
            '
            Dim activeForm As Object = Form.ActiveForm

            If sender.name = "" Then
                Exit Sub
            End If

            FRMusers.Hide()

            If UserLevel <> "Resident" Then
                Select Case sender.name
                    Case "Till"
                        FRMtill.ShowDialog()
                    Case "Lookup"
                        FRMlookUp.ShowDialog()
                    Case "Medical"
                        FRMmedical.ShowDialog()
                End Select
            End If

            If (sender.name = "LogBook") And (UserLevel = "Director") Then
                FRMlogBook.ShowDialog()
            End If

            '
            Select Case sender.name
                Case "Help"
                    FRMhelp.ShowDialog()
                Case "Settings"
                    FRMsettings.ShowDialog()
                Case "Request"
                    FRMrequest.ShowDialog()
                Case "Timetable"
                    FRMtimetable.ShowDialog()
            End Select

            '
            activeForm.Show()

        End Sub

    End Class
End Module
