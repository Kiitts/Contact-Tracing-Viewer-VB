Imports Contact_Tracing.InputsController
Imports Contact_Tracing.OutputController

Public Class QRForm
    Private Sub generateQRButton_Click(sender As Object, e As EventArgs) Handles generateQRButton.Click
        Dim failedInput As String = CheckForInputs()
        If failedInput IsNot Nothing Then
            MessageBox.Show("Survey Form is Incomplete!", "Error!") '
        Else
            GenerateQR()
        End If
    End Sub
End Class