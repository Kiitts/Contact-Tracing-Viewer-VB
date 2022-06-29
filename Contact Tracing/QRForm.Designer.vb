<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QRForm
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
        Me.qRBox = New System.Windows.Forms.PictureBox()
        Me.generateQRButton = New System.Windows.Forms.Button()
        Me.submitQRButton = New System.Windows.Forms.Button()
        CType(Me.qRBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'qRBox
        '
        Me.qRBox.Location = New System.Drawing.Point(117, 12)
        Me.qRBox.Name = "qRBox"
        Me.qRBox.Size = New System.Drawing.Size(300, 300)
        Me.qRBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.qRBox.TabIndex = 0
        Me.qRBox.TabStop = False
        '
        'generateQRButton
        '
        Me.generateQRButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.generateQRButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.generateQRButton.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.generateQRButton.ForeColor = System.Drawing.Color.White
        Me.generateQRButton.Location = New System.Drawing.Point(199, 315)
        Me.generateQRButton.Margin = New System.Windows.Forms.Padding(0)
        Me.generateQRButton.Name = "generateQRButton"
        Me.generateQRButton.Size = New System.Drawing.Size(132, 29)
        Me.generateQRButton.TabIndex = 18
        Me.generateQRButton.Text = "Generate QR"
        Me.generateQRButton.UseVisualStyleBackColor = False
        '
        'submitQRButton
        '
        Me.submitQRButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.submitQRButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.submitQRButton.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.submitQRButton.ForeColor = System.Drawing.Color.White
        Me.submitQRButton.Location = New System.Drawing.Point(209, 349)
        Me.submitQRButton.Margin = New System.Windows.Forms.Padding(0)
        Me.submitQRButton.Name = "submitQRButton"
        Me.submitQRButton.Size = New System.Drawing.Size(116, 29)
        Me.submitQRButton.TabIndex = 19
        Me.submitQRButton.Text = "Submit QR"
        Me.submitQRButton.UseVisualStyleBackColor = False
        '
        'QRForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 450)
        Me.Controls.Add(Me.submitQRButton)
        Me.Controls.Add(Me.generateQRButton)
        Me.Controls.Add(Me.qRBox)
        Me.MaximumSize = New System.Drawing.Size(565, 489)
        Me.MinimumSize = New System.Drawing.Size(565, 489)
        Me.Name = "QRForm"
        Me.Text = "QR"
        CType(Me.qRBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents qRBox As PictureBox
    Friend WithEvents generateQRButton As Button
    Friend WithEvents submitQRButton As Button
End Class
