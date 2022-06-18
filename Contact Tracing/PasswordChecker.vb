Imports Contact_Tracing.MainLayoutController

Public Class PasswordChecker
    Private Sub passwordButton_Click(sender As Object, e As EventArgs) Handles passwordButton.Click
        If passwordText.Text = "0000" Then
            passwordText.Text = ""
            warnLabel.Text = ""
            MainLayoutController.loadForm(Viewer, MainLayout)
        Else
            warnLabel.Text = "Password is Incorrect"
        End If
    End Sub
End Class