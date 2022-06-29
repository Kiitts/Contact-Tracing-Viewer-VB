Imports QRCoder
Imports Newtonsoft.Json

Module QRController
    Public isImageAGeneratedQR As Boolean = False
    Public genderRadio = New RadioButton() {mainForm.genderMale, mainForm.genderFemale}
    Public travelledRadio = New RadioButton() {mainForm.travelledYes, mainForm.travelledNo}
    Public contactRadio = New RadioButton() {mainForm.contactYes, mainForm.contactNo}
    Public checkboxes = New CheckBox() _
        {mainForm.sicknessFever, mainForm.sicknessCold, mainForm.sicknessBreath}
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

    Sub GenerateQR()
        isImageAGeneratedQR = True
        QRForm.qRBox.Image = Nothing
        Dim qr As QRCodeGenerator = New QRCodeGenerator()
        Dim qrData = qr.CreateQrCode(GenerateJSON(), QRCodeGenerator.ECCLevel.Q)
        Dim qrCode As New QRCode(qrData)
        QRForm.qRBox.Image = qrCode.GetGraphic(100)
    End Sub

    Function GenerateJSON() As String
        Dim data As QRInfo = New QRInfo()
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
End Module
