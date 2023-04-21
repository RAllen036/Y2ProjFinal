Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class FRMlogin

    Public ID As Integer
    Public user As String
    Public userLocation As String

    Private Sub FRMlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBDataSet.LogBook' table. You can move, or remove it, as needed.
        Me.LogBookTableAdapter.Fill(Me.DBDataSet.LogBook)
        'TODO: This line of code loads data into the 'DBDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.DBDataSet.Users)
    End Sub

    Private Sub BTNlogin_Click(sender As Object, e As EventArgs) Handles BTNlogin.Click

        Dim username As String
        Dim password As String
        'Test to see if the user has entered a username and password
        If (TXTusername.Text <> vbNullChar And TXTusername.Text <> "") And (TXTpassword.Text <> vbNullChar And TXTpassword.Text <> "") Then
            username = TXTusername.Text
            password = TXTpassword.Text
            ' Sees if the username and password are correct
            For i = 0 To DBDataSet.Users.Rows.Count - 1
                If username = DBDataSet.Users.Item(i).Username Then
                    If password = DBDataSet.Users.Item(i).Password Then
                        ' Saves some neccesary details (Username, UserID and the users location in the users form)
                        ID = CInt(username.Substring(2))
                        user = username
                        userLocation = getUserLocation(user)

                        LogAction("Login to users form", Me.Name)

                        Me.Hide()
                        ' Shows the users form
                        FRMusers.ShowDialog()

                        Me.Show()

                        Exit Sub
                    End If
                End If
            Next

        Else
            MsgBox("Something was left blank")
        End If
        ' Resets the display
        TXTusername.Text = vbNullChar
        TXTpassword.Text = vbNullChar

    End Sub

    Private Sub BTNforgotLogin_Click(sender As Object, e As EventArgs) Handles BTNforgotLogin.Click

        Me.Hide()

        FRMforgotLogin.ShowDialog()

        Me.Show()

    End Sub

    Public Function getUserLocation(User As String)
        ' Goes through each row in the database and checks to see if the username matches and returns the number of tries it took
        For i = 0 To DBDataSet.Users.Rows.Count - 1
            If User = DBDataSet.Users.Item(i).Username Then
                Return i
            End If
        Next
        Return -1
    End Function

    Private Sub TXTpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTpassword.KeyPress

        If e.KeyChar = Chr(13) Then ' Chr(13) represents the enter key which allow the user to sign in without going to the login button

            BTNlogin_Click(sender, New EventArgs)

        End If

    End Sub

    Sub LogAction(Action As String, formName As String)

        Dim Time As Date = Today
        'Creates a new row
        DBDataSet.LogBook.Rows.Add()

        Dim LogID As Integer = DBDataSet.LogBook.Rows.Count - 1

        If LogID = -1 Then
            LogID = 0
        End If
        ' Saves details to the new row
        With DBDataSet.LogBook.Item(LogID)
            .Action = $"{formName}: {Action}"
            .UserID = Me.ID
            ._Date = Time.ToString("g")
        End With

        UpdateTable()

    End Sub

    Sub UpdateTable()
        LogBookTableAdapter.Update(DBDataSet.LogBook)
        LogBookTableAdapter.Fill(DBDataSet.LogBook)
    End Sub

End Class