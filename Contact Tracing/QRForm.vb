Imports Contact_Tracing.InputsController
Imports Contact_Tracing.OutputController
Imports AForge.Video
Imports AForge.Video.DirectShow

Public Class QRForm
    'Public camerasList As FilterInfoCollection
    'Public vid As VideoCaptureDevice
    Private Sub generateQRButton_Click(sender As Object, e As EventArgs) Handles generateQRButton.Click
        Dim failedInput As String = CheckForInputs()
        If failedInput IsNot Nothing Then
            MessageBox.Show("Survey Form is Incomplete!", "Error!") '
        Else
            GenerateQR()
        End If
    End Sub

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        If QRController.isImageAGeneratedQR Then
            SaveQR()
        Else
            MessageBox.Show("No QR Generated", "Error")
        End If
    End Sub
End Class