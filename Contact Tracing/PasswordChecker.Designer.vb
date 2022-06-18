<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordChecker
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
        Me.passwordButton = New System.Windows.Forms.Button()
        Me.passwordText = New System.Windows.Forms.TextBox()
        Me.messageLabel = New System.Windows.Forms.Label()
        Me.warnLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'passwordButton
        '
        Me.passwordButton.Location = New System.Drawing.Point(208, 236)
        Me.passwordButton.Name = "passwordButton"
        Me.passwordButton.Size = New System.Drawing.Size(75, 23)
        Me.passwordButton.TabIndex = 0
        Me.passwordButton.Text = "Continue"
        Me.passwordButton.UseVisualStyleBackColor = True
        '
        'passwordText
        '
        Me.passwordText.Location = New System.Drawing.Point(158, 207)
        Me.passwordText.Name = "passwordText"
        Me.passwordText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordText.Size = New System.Drawing.Size(169, 23)
        Me.passwordText.TabIndex = 1
        '
        'messageLabel
        '
        Me.messageLabel.AutoSize = True
        Me.messageLabel.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.messageLabel.Location = New System.Drawing.Point(198, 174)
        Me.messageLabel.Name = "messageLabel"
        Me.messageLabel.Size = New System.Drawing.Size(105, 15)
        Me.messageLabel.TabIndex = 2
        Me.messageLabel.Text = "ONLY FOR STAFF"
        '
        'warnLabel
        '
        Me.warnLabel.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.warnLabel.ForeColor = System.Drawing.Color.Red
        Me.warnLabel.Location = New System.Drawing.Point(12, 284)
        Me.warnLabel.Name = "warnLabel"
        Me.warnLabel.Size = New System.Drawing.Size(458, 28)
        Me.warnLabel.TabIndex = 3
        Me.warnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PasswordChecker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 514)
        Me.Controls.Add(Me.warnLabel)
        Me.Controls.Add(Me.messageLabel)
        Me.Controls.Add(Me.passwordText)
        Me.Controls.Add(Me.passwordButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PasswordChecker"
        Me.Text = "PasswordChecker"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents passwordButton As Button
    Friend WithEvents passwordText As TextBox
    Friend WithEvents messageLabel As Label
    Friend WithEvents warnLabel As Label
End Class
