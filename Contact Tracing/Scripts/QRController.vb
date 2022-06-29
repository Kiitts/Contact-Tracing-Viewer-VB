Imports QRCoder
Imports Newtonsoft.Json
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing

Module QRController
    Public genderRadio = New RadioButton() {mainForm.genderMale, mainForm.genderFemale}
    Public travelledRadio = New RadioButton() {mainForm.travelledYes, mainForm.travelledNo}
    Public contactRadio = New RadioButton() {mainForm.contactYes, mainForm.contactNo}
    Public checkboxes = New CheckBox() _
        {mainForm.sicknessFever, mainForm.sicknessCold, mainForm.sicknessBreath}
    Dim data As QRInfo
    <Serializable>
    Class QRInfo
        Public Name As String
        Public Address As String
        Public Age As String
        Public Gender As String
        Public Travelled As String
        Public Contacted As String
        Public Symptoms As String
        Public PhoneNumber As String
        Public EmailAddress As String
    End Class

    ''' <summary>
    ''' Will generate the qr code in the picture box
    ''' </summary>
    Sub GenerateQR()
        QRForm.qRBox.Image = Nothing
        Dim qr As QRCodeGenerator = New QRCodeGenerator()
        Dim qrData = qr.CreateQrCode(GenerateJSON(), QRCodeGenerator.ECCLevel.Q)
        Dim qrCode As New QRCode(qrData)
        QRForm.qRBox.Image = qrCode.GetGraphic(100)
    End Sub

    ''' <summary>
    ''' Generate the json details from the main form
    ''' </summary>
    ''' <returns>return the json string</returns>
    Function GenerateJSON() As String
        data = New QRInfo()
        data.Name = mainForm.nameInput.Text
        data.Address = mainForm.addressInput.Text
        data.Age = mainForm.ageInput.Text
        For Each gender As RadioButton In genderRadio
            If gender.Checked Then
                data.Gender = gender.Text
            End If
        Next
        For Each travelled As RadioButton In travelledRadio
            If travelled.Checked Then
                data.Travelled = travelled.Text
                Console.WriteLine(travelled.Text)
            End If
        Next
        For Each contacted As RadioButton In contactRadio
            If contacted.Checked Then
                data.Contacted = contacted.Text
            End If
        Next
        For Each symptoms As CheckBox In checkboxes
            If symptoms.Checked Then
                data.Symptoms += $"{symptoms.Text};"
            End If
        Next
        data.PhoneNumber = mainForm.numberInput.Text
        data.EmailAddress = mainForm.emailInput.Text

        Dim json As String = JsonConvert.SerializeObject(data, Formatting.Indented)
        Return json
    End Function

    ''' <summary>
    ''' let you choose folder where to save the generated qr
    ''' </summary>
    Public Sub SaveQR()
        If QRForm.folderQRBrowser.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim savePath As String = QRForm.folderQRBrowser.SelectedPath
            QRForm.qRBox.Image.Save(savePath + $"\{data.Name}.jpg")
            MessageBox.Show("Saved!", "Success!")
        End If
    End Sub

    ''' <summary>
    ''' will check if the cam detects a qr and stop the camera if so and save the data in
    ''' the qr code
    ''' </summary>
    Public Sub CamToQR()
        If QRForm.qRBox.Image IsNot Nothing Then
            Dim qrcode As BarcodeReader = New BarcodeReader()
            Dim result As Result = qrcode.Decode(DirectCast(QRForm.qRBox.Image, Bitmap))
            If result IsNot Nothing Then
                StopCam()
                QRForm.checkForQr.Stop()
                SaveQRDetectedResult(result.ToString())
            End If
        End If
    End Sub

    Public Sub StopCam()
        Try
            If QRForm.vid IsNot Nothing Then
                If QRForm.vid.IsRunning Then
                    QRForm.vid.SignalToStop()
                    QRForm.vid.WaitForStop()
                    QRForm.vid.Stop()
                End If
            End If
        Catch

        End Try

    End Sub

    ''' <summary>
    ''' save result as a deserialized qrinfo
    ''' </summary>
    ''' <param name="result">reference of a string that has the result</param>
    Private Sub SaveQRDetectedResult(result As String)
        Dim data As QRInfo = JsonConvert.DeserializeObject(Of QRInfo)(result)
        FillForm(data)
    End Sub

    ''' <summary>
    ''' fill the input form in the mainform
    ''' </summary>
    ''' <param name="data">reference of the data</param>
    Private Sub FillForm(data As QRInfo)
        'Debug.WriteLine(data.Symptoms)
        'Debug.WriteLine(data.Symptoms.Split(";"))
        mainForm.nameInput.Text = data.Name
        mainForm.addressInput.Text = data.Address
        mainForm.ageInput.Text = data.Age
        For Each gender As RadioButton In genderRadio
            If gender.Text = data.Gender Then
                gender.Checked = True
                Exit For
            End If
        Next
        For Each travelled As RadioButton In travelledRadio
            If travelled.Text = data.Travelled Then
                travelled.Checked = True
                Exit For
            End If
        Next
        For Each contacted As RadioButton In contactRadio
            If contacted.Text = data.Contacted Then
                contacted.Checked = True
                Exit For
            End If
        Next
        For Each symptom As String In data.Symptoms.Split(";")
            If symptom IsNot Nothing Or symptom IsNot "" Then
                For Each sick As CheckBox In checkboxes
                    If symptom = sick.Text Then
                        sick.Checked = True
                    End If
                Next
            End If
        Next
        mainForm.numberInput.Text = data.PhoneNumber
        mainForm.emailInput.Text = data.EmailAddress
        MessageBox.Show("The survey form is now filled!", "Success!")
    End Sub
End Module
