Imports Contact_Tracing.InputsController
Imports Contact_Tracing.OutputController
Imports AForge.Video
Imports AForge.Video.DirectShow

Public Class QRForm
    Public vid As VideoCaptureDevice
    Public bmp As Bitmap
    Public camList As FilterInfoCollection
    Private Sub generateQRButton_Click(sender As Object, e As EventArgs) Handles generateQRButton.Click
        qRBox.Image = Nothing
        qRBox.SizeMode = PictureBoxSizeMode.StretchImage
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

    Private Sub QRForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If vid.IsRunning Then
            vid.SignalToStop()
            vid.WaitForStop()
            vid.Stop()
        End If
    End Sub

    Private Sub submitQRButton_Click(sender As Object, e As EventArgs) Handles submitQRButton.Click
        qRBox.Image = Nothing
        qRBox.SizeMode = PictureBoxSizeMode.CenterImage
        checkForQr.Start()
        Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If cameras.ShowDialog() = Windows.Forms.DialogResult.OK Then
            vid = cameras.VideoDevice
            AddHandler vid.NewFrame, New NewFrameEventHandler(AddressOf ShowCamera)
            vid.Start()
        End If
    End Sub

    Private Sub ShowCamera(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        qRBox.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub checkForQr_Tick(sender As Object, e As EventArgs) Handles checkForQr.Tick
        CamToQR()
    End Sub
End Class