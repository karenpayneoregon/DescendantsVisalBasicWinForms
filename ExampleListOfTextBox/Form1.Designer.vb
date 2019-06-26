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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LastTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.GetTextBoxesButton = New System.Windows.Forms.Button()
        Me.LoadTextBoxesButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LastTextBox)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 90)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'LastTextBox
        '
        Me.LastTextBox.Location = New System.Drawing.Point(14, 52)
        Me.LastTextBox.Name = "LastTextBox"
        Me.LastTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastTextBox.TabIndex = 1
        Me.LastTextBox.Text = "Payne"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(11, 20)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 0
        Me.FirstNameTextBox.Text = "Karen"
        '
        'GetTextBoxesButton
        '
        Me.GetTextBoxesButton.Location = New System.Drawing.Point(27, 122)
        Me.GetTextBoxesButton.Name = "GetTextBoxesButton"
        Me.GetTextBoxesButton.Size = New System.Drawing.Size(225, 23)
        Me.GetTextBoxesButton.TabIndex = 2
        Me.GetTextBoxesButton.Text = "Get Textboxes in GroupBox"
        Me.GetTextBoxesButton.UseVisualStyleBackColor = True
        '
        'LoadTextBoxesButton
        '
        Me.LoadTextBoxesButton.Location = New System.Drawing.Point(27, 151)
        Me.LoadTextBoxesButton.Name = "LoadTextBoxesButton"
        Me.LoadTextBoxesButton.Size = New System.Drawing.Size(225, 23)
        Me.LoadTextBoxesButton.TabIndex = 3
        Me.LoadTextBoxesButton.Text = "Load TextBoxes"
        Me.LoadTextBoxesButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 412)
        Me.Controls.Add(Me.LoadTextBoxesButton)
        Me.Controls.Add(Me.GetTextBoxesButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LastTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents GetTextBoxesButton As Button
    Friend WithEvents LoadTextBoxesButton As Button
End Class
