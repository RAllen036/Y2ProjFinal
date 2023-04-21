Imports System.Net.Mail
Public Class FRMforgotLogin

    Dim RandomKey As String
    Dim tries As Integer = 0
    Dim user As String

    Private Sub FRMforgotLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.DBDataSet.Users)

    End Sub
    ' Generates a random number between the minimum and maximum numbers passed through
    Function RandNumGen(min As Integer, max As Integer)
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(min, max)
    End Function
    'Creates a random key using the ASCII character set and the random number generator
    Sub GenRandomKey(Optional length As Integer = 10)
        RandomKey = ""
        For i = 0 To length - 1
            RandomKey += Chr(RandNumGen(33, 127)) ' 33 and 127 are most of the viable / normal characters
        Next
    End Sub

    Private Sub BTNsendEmail_Click(sender As Object, e As EventArgs) Handles BTNsendEmail.Click

        'Test to see if a username was entered
        If TXTusername.Text = "" Or TXTusername.Text = Nothing Then
            MsgBox("Please enter a username")
            Exit Sub
        End If

        For i = 0 To DBDataSet.Users.Rows.Count - 1

            If TXTusername.Text = DBDataSet.Users.Item(i).Username Then ' Looks for the user in the db so that it can get the users email

                GenRandomKey()

                ' Get users email

                Dim recipient As String = DBDataSet.Users.Item(FRMlogin.getUserLocation(TXTusername.Text)).Email

                ' Send email

                Dim Title As String = "Password reset code."
                Dim message As String = $"Your code for changing your password: {Environment.NewLine}{RandomKey} {Environment.NewLine}Do not share this code with anyone."

                SendEmail(recipient, message, Title)
                ' Saves the username for later
                user = TXTusername.Text
                'Resets the username text box
                TXTusername.Text = ""

            End If

        Next

    End Sub

    Private Sub BTNResetPassword_Click(sender As Object, e As EventArgs) Handles BTNResetPassword.Click

        If tries >= 3 Then ' Ensures the user cannot guess there random code
            MsgBox("You cannot change your password right now.")

            ' Starts timer

            TMRattemptReset.Enabled = True

            Exit Sub
        End If

        If TXTCode.Text = RandomKey And TXTNewPassword.Text <> "" And TXTNewPassword.Text <> vbNullChar Then
            ' Resets the users password to the one entered 
            For i = 0 To DBDataSet.Users.Rows.Count - 1
                If DBDataSet.Users.Item(i).Username = user Then

                    DBDataSet.Users.Item(i).Password = TXTNewPassword.Text

                    UsersTableAdapter.Update(DBDataSet.Users)
                    UsersTableAdapter.Fill(DBDataSet.Users)

                    MsgBox("Password has been changed.")

                    Exit For

                End If
            Next

        Else

            MsgBox("Something went wrong")
            tries -= 1
            Exit Sub
        End If

        FRMlogin.LogAction($"Changed {user} password", Me.Name)
        'Resets the display
        TXTCode.Text = ""
        TXTNewPassword.Text = ""

    End Sub
End Class