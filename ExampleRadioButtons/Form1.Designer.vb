<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.RatingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExcellentRadioButton = New System.Windows.Forms.RadioButton()
        Me.GoodRadioButton = New System.Windows.Forms.RadioButton()
        Me.FairRadioButton = New System.Windows.Forms.RadioButton()
        Me.PoorRadioButton = New System.Windows.Forms.RadioButton()
        Me.RateButton = New System.Windows.Forms.Button()
        Me.RatingsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'RatingsGroupBox
        '
        Me.RatingsGroupBox.Controls.Add(Me.PoorRadioButton)
        Me.RatingsGroupBox.Controls.Add(Me.FairRadioButton)
        Me.RatingsGroupBox.Controls.Add(Me.GoodRadioButton)
        Me.RatingsGroupBox.Controls.Add(Me.ExcellentRadioButton)
        Me.RatingsGroupBox.Location = New System.Drawing.Point(25, 18)
        Me.RatingsGroupBox.Name = "RatingsGroupBox"
        Me.RatingsGroupBox.Size = New System.Drawing.Size(153, 126)
        Me.RatingsGroupBox.TabIndex = 0
        Me.RatingsGroupBox.TabStop = False
        Me.RatingsGroupBox.Text = "Rating"
        '
        'ExcellentRadioButton
        '
        Me.ExcellentRadioButton.AutoSize = True
        Me.ExcellentRadioButton.Location = New System.Drawing.Point(17, 22)
        Me.ExcellentRadioButton.Name = "ExcellentRadioButton"
        Me.ExcellentRadioButton.Size = New System.Drawing.Size(68, 17)
        Me.ExcellentRadioButton.TabIndex = 0
        Me.ExcellentRadioButton.TabStop = True
        Me.ExcellentRadioButton.Text = "Excellent"
        Me.ExcellentRadioButton.UseVisualStyleBackColor = True
        '
        'GoodRadioButton
        '
        Me.GoodRadioButton.AutoSize = True
        Me.GoodRadioButton.Location = New System.Drawing.Point(17, 45)
        Me.GoodRadioButton.Name = "GoodRadioButton"
        Me.GoodRadioButton.Size = New System.Drawing.Size(51, 17)
        Me.GoodRadioButton.TabIndex = 1
        Me.GoodRadioButton.TabStop = True
        Me.GoodRadioButton.Text = "Good"
        Me.GoodRadioButton.UseVisualStyleBackColor = True
        '
        'FairRadioButton
        '
        Me.FairRadioButton.AutoSize = True
        Me.FairRadioButton.Location = New System.Drawing.Point(17, 68)
        Me.FairRadioButton.Name = "FairRadioButton"
        Me.FairRadioButton.Size = New System.Drawing.Size(42, 17)
        Me.FairRadioButton.TabIndex = 2
        Me.FairRadioButton.TabStop = True
        Me.FairRadioButton.Text = "Fair"
        Me.FairRadioButton.UseVisualStyleBackColor = True
        '
        'PoorRadioButton
        '
        Me.PoorRadioButton.AutoSize = True
        Me.PoorRadioButton.Location = New System.Drawing.Point(17, 91)
        Me.PoorRadioButton.Name = "PoorRadioButton"
        Me.PoorRadioButton.Size = New System.Drawing.Size(47, 17)
        Me.PoorRadioButton.TabIndex = 3
        Me.PoorRadioButton.TabStop = True
        Me.PoorRadioButton.Text = "Poor"
        Me.PoorRadioButton.UseVisualStyleBackColor = True
        '
        'RateButton
        '
        Me.RateButton.Location = New System.Drawing.Point(195, 18)
        Me.RateButton.Name = "RateButton"
        Me.RateButton.Size = New System.Drawing.Size(75, 23)
        Me.RateButton.TabIndex = 1
        Me.RateButton.Text = "Rating"
        Me.RateButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 174)
        Me.Controls.Add(Me.RateButton)
        Me.Controls.Add(Me.RatingsGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selected radio button example"
        Me.RatingsGroupBox.ResumeLayout(False)
        Me.RatingsGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RatingsGroupBox As GroupBox
    Friend WithEvents FairRadioButton As RadioButton
    Friend WithEvents GoodRadioButton As RadioButton
    Friend WithEvents ExcellentRadioButton As RadioButton
    Friend WithEvents PoorRadioButton As RadioButton
    Friend WithEvents RateButton As Button
End Class
