Imports Contact_Tracing.OutputController

Module ViewerController
    Sub GenerateComboBoxList(ByRef datesComboBox As ComboBox)
        Dim dateList As List(Of String) = OutputController.GetAllDates()
        For Each item As String In dateList
            datesComboBox.Items.Add(item)
        Next
    End Sub

    Sub WriteText(ByRef path As String, submissionBox As TextBox)
        submissionBox.Text = OutputController.GetText(path)
    End Sub
End Module
