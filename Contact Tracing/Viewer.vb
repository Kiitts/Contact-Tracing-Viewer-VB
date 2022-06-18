﻿Imports Contact_Tracing.ViewerController

Public Class Viewer
    Private Sub Viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewerController.GenerateComboBoxList(formListBox)
        formListBox.SelectedIndex = 0
    End Sub

    Private Sub formListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles formListBox.SelectedIndexChanged
        If formListBox.SelectedIndex = 0 Then
            ViewerController.WriteText("forms\SubmittedForms.txt", submissionText)
        Else
            ViewerController.WriteText($"forms\{formListBox.SelectedItem.ToString()}.txt", submissionText)
        End If
    End Sub
End Class