Public Class CLSReturnButton

    Public button As Button

    Public Sub Innit(form As Object)

        Dim tempButton As New Button With {
        .Size = New Size(100, 55),
        .Location = New Point(form.width - 125, 10),
        .BackColor = Color.Red,
        .Text = "Return",
        .Font = New System.Drawing.Font("Sans", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        }

        Me.button = tempButton

        AddHandler Me.button.Click, AddressOf Me.Click

        form.Controls.Add(Me.button)

    End Sub

    Sub Click(sender As Object, e As EventArgs)



    End Sub

End Class
