Imports Contact_Tracing.mainForm
Imports System.IO
Imports Contact_Tracing.InputsController

Module OutputController
    Public genderRadio = New RadioButton() {mainForm.genderMale, mainForm.genderFemale}
    Public travelledRadio = New RadioButton() {mainForm.travelledYes, mainForm.travelledNo}
    Public contactRadio = New RadioButton() {mainForm.contactYes, mainForm.contactNo}
    Public checkboxes = New CheckBox() _
        {mainForm.sicknessBreath, mainForm.sicknessCold, mainForm.sicknessFever}


    ''' <summary>
    ''' Generate all the txt file needed for the form
    ''' </summary>
    Public Sub GenerateTextFile()
        FormToText("forms\SubmittedForms.txt")
        FormToText("forms\" & DateTime.Now.ToString("MMMM dd, yyyy; dddd") & ".txt")
        DateToText()
        ResetInputs()
    End Sub

    ''' <summary>
    ''' Converts the form to txt file
    ''' </summary>
    ''' <param name="pathName">where to save</param>
    Private Sub FormToText(ByVal pathName As String)
        Dim form As StreamWriter
        form = My.Computer.FileSystem.OpenTextFileWriter(pathName, True)
        form.WriteLine($"Date & Time Submitted: {DateTime.Now.ToString("MMMM dd, yyyy; dddd; hh:MM tt")}")
        form.WriteLine($"Name: {mainForm.nameInput.Text}")
        form.WriteLine($"Address: {mainForm.addressInput.Text}")
        form.WriteLine($"Age: {mainForm.ageInput.Text}")
        For Each gender As RadioButton In genderRadio
            If gender.Checked Then
                form.WriteLine($"Gender: {gender.Text}")
            End If
        Next
        For Each travelled As RadioButton In travelledRadio
            If travelled.Checked Then
                form.WriteLine($"Travelled: {travelled.Text}")
            End If
        Next
        For Each contact As RadioButton In contactRadio
            If contact.Checked Then
                form.WriteLine($"Have Contact: {contact.Text}")
            End If
        Next
        form.Write("Sickness:")
        For Each check As CheckBox In checkboxes
            If check.Checked Then
                form.Write($" {check.Text};")
            End If
        Next
        form.WriteLine()
        form.WriteLine($"Phone Number: {mainForm.numberInput.Text}")
        form.WriteLine($"Email Address: {mainForm.emailInput.Text}")
        form.WriteLine($"{vbCrLf}")
        form.Close()
    End Sub

    ''' <summary>
    ''' make a txt file that write the date
    ''' </summary>
    Private Sub DateToText()
        Dim line As String = DateTime.Now.ToString("MMMM dd, yyyy; dddd")
        If Not CheckIfDateExist(GetAllDates, line) Then
            Dim form As StreamWriter
            form = My.Computer.FileSystem.OpenTextFileWriter("forms\dates.txt", True)
            form.WriteLine(line)
            form.Close()
        End If
    End Sub

    ''' <summary>
    ''' get a list of all dates in the txt file
    ''' </summary>
    ''' <returns>return a list of dates</returns>
    Public Function GetAllDates() As List(Of String)
        Dim path As String = "forms\dates.txt"
        Dim dates As New List(Of String)
        If File.Exists(path) Then
            For Each line As String In File.ReadLines("forms\dates.txt")
                dates.Add(line)
            Next
        End If
        Return dates
    End Function

    ''' <summary>
    ''' will check if the given date exist in the given list
    ''' </summary>
    ''' <param name="dates"> reference to list of dates </param>
    ''' <param name="theDate"> the date that should be check on the list </param>
    ''' <returns>true if it exist</returns>
    Public Function CheckIfDateExist(ByVal dates As List(Of String), ByVal theDate As String) As Boolean
        For Each element As String In dates
            If element = theDate Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function GetText(ByRef path As String) As String
        If File.Exists(path) Then
            Return File.ReadAllText(path)
        End If
        Return "None"
    End Function

End Module
