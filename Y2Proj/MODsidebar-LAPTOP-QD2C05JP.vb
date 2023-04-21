Module MODsidebar

    Structure slot
        Dim icon As PictureBox
        Dim text As Label
    End Structure

    Public Class sidebar

        Public container As Panel
        Public slots(8) As slot
        Public icon As PictureBox
        Dim expanded As Boolean

        Public Sub innit(form As Object)

            Dim barSize As New Size(70, form.height)

            ' Creates the background panel
            Dim tempBar As New Panel With {
                .Size = barSize,
                .Location = New Point(0, 0),
                .BackColor = Color.Gray,
                .BorderStyle = BorderStyle.FixedSingle
            }

            '
            Dim tempIcon As New PictureBox With {
            .Size = New Size(tempBar.Width * 0.7!, tempBar.Width * 0.7!),
            .Location = New Point(10, 5),
            .BackColor = Color.Green,
            .BorderStyle = BorderStyle.FixedSingle
            }

            Me.icon = tempIcon

            AddHandler icon.Click, AddressOf Me.expand

            form.controls.add(Me.icon)

            '
            For i = 0 To slots.Length - 1
                '
                Dim sIcon As New PictureBox With
                {
                .Size = Me.icon.Size,
                .Location = New Point(tempIcon.Location.X, form.height - 100 - (i * 60)),
                .BackColor = Color.ForestGreen,
                .BorderStyle = BorderStyle.FixedSingle
                }

                Select Case i
                    Case 1
                        sIcon.Name = "Help"
                    Case 0
                        sIcon.Name = "Settings"
                    Case Else
                        sIcon.Name = ""
                End Select

                '
                Dim sLabel As New Label With {
                .Location = New Point(sIcon.Location.X + sIcon.Width + 15, sIcon.Location.Y + 10),
                .Font = New System.Drawing.Font("Georgia", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte)),
                .Text = $"{sIcon.Name}",
                .BackColor = tempBar.BackColor,
                .BorderStyle = BorderStyle.FixedSingle,
                .AutoSize = True,
                .Enabled = False,
                .Visible = False
                }

                Dim tempSLot As New slot With {
                .icon = sIcon,
                .text = sLabel
                }

                slots(i) = tempSLot

                AddHandler slots(i).icon.Click, AddressOf Me.slotClick
                AddHandler slots(i).text.Click, AddressOf Me.slotClick

                '
                form.controls.add(slots(i).icon)
                form.controls.add(slots(i).text)

            Next

            container = tempBar

            AddHandler container.Click, AddressOf Me.expand

            form.Controls.Add(container)

        End Sub

        Sub expand(sender As Object, e As EventArgs)

            '
            If expanded Then
                container.Size = New Size(70, Form.ActiveForm.Height)
            Else
                container.Size = New Size(container.Width * 3, Form.ActiveForm.Height)
            End If

            '
            expanded = Not expanded

            '
            For i = 0 To slots.Length - 1
                slots(i).text.Enabled = expanded
                slots(i).text.Visible = expanded
            Next

        End Sub

        Sub slotClick(sender As Object, e As EventArgs)

            '
            Dim activeForm As Object = Form.ActiveForm

            activeForm.hide()

            '
            Dim name As String

            If sender Is New PictureBox Then
                name = sender.name
            Else
                name = sender.text
            End If

            ' TODO - Add the rest of the form that will be used in the sidebar
            Select Case name
                Case "Calendar"
                    FRMcalendar.ShowDialog()
                Case "Help"
                    FRMhelp.ShowDialog()
                Case "Settings"
                    FRMsettings.ShowDialog()

            End Select

            '
            activeForm.Show()

        End Sub

    End Class
End Module
