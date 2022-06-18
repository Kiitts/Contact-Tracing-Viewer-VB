<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Viewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.formListBox = New System.Windows.Forms.ComboBox()
        Me.submissionText = New System.Windows.Forms.TextBox()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'formListBox
        '
        Me.formListBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.formListBox.FormattingEnabled = True
        Me.formListBox.Items.AddRange(New Object() {"All"})
        Me.formListBox.Location = New System.Drawing.Point(12, 12)
        Me.formListBox.Name = "formListBox"
        Me.formListBox.Size = New System.Drawing.Size(244, 23)
        Me.formListBox.TabIndex = 0
        '
        'submissionText
        '
        Me.submissionText.Location = New System.Drawing.Point(13, 42)
        Me.submissionText.Multiline = True
        Me.submissionText.Name = "submissionText"
        Me.submissionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.submissionText.Size = New System.Drawing.Size(443, 460)
        Me.submissionText.TabIndex = 1
        '
        'refreshButton
        '
        Me.refreshButton.Location = New System.Drawing.Point(287, 12)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(169, 23)
        Me.refreshButton.TabIndex = 2
        Me.refreshButton.Text = "Refresh"
        Me.refreshButton.UseVisualStyleBackColor = True
        '
        'Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 514)
        Me.Controls.Add(Me.refreshButton)
        Me.Controls.Add(Me.submissionText)
        Me.Controls.Add(Me.formListBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Viewer"
        Me.Text = "Viewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents formListBox As ComboBox
    Friend WithEvents submissionText As TextBox
    Friend WithEvents refreshButton As Button
End Class
