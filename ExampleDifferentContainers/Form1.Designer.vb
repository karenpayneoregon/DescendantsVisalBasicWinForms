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
        Me.NameGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.TextBox1OnForm = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBoxTextBoxesButton = New System.Windows.Forms.Button()
        Me.TextBoxesOnFormButton = New System.Windows.Forms.Button()
        Me.TextBox2OnForm = New System.Windows.Forms.TextBox()
        Me.NameGroupBox.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameGroupBox
        '
        Me.NameGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.NameGroupBox.Controls.Add(Me.Label2)
        Me.NameGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.NameGroupBox.Controls.Add(Me.Label1)
        Me.NameGroupBox.Location = New System.Drawing.Point(28, 23)
        Me.NameGroupBox.Name = "NameGroupBox"
        Me.NameGroupBox.Size = New System.Drawing.Size(234, 106)
        Me.NameGroupBox.TabIndex = 0
        Me.NameGroupBox.TabStop = False
        Me.NameGroupBox.Text = "Name Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First name"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(100, 24)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last name"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(100, 58)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DeleteButton)
        Me.Panel1.Controls.Add(Me.UpdateButton)
        Me.Panel1.Location = New System.Drawing.Point(37, 146)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(225, 62)
        Me.Panel1.TabIndex = 1
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(9, 16)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateButton.TabIndex = 0
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(130, 16)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 1
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'TextBox1OnForm
        '
        Me.TextBox1OnForm.Location = New System.Drawing.Point(310, 40)
        Me.TextBox1OnForm.Name = "TextBox1OnForm"
        Me.TextBox1OnForm.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1OnForm.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(310, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBoxesOnFormButton)
        Me.Panel2.Controls.Add(Me.GroupBoxTextBoxesButton)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 270)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(506, 56)
        Me.Panel2.TabIndex = 4
        '
        'GroupBoxTextBoxesButton
        '
        Me.GroupBoxTextBoxesButton.Location = New System.Drawing.Point(10, 21)
        Me.GroupBoxTextBoxesButton.Name = "GroupBoxTextBoxesButton"
        Me.GroupBoxTextBoxesButton.Size = New System.Drawing.Size(135, 23)
        Me.GroupBoxTextBoxesButton.TabIndex = 0
        Me.GroupBoxTextBoxesButton.Text = "Textboxes in group box"
        Me.GroupBoxTextBoxesButton.UseVisualStyleBackColor = True
        '
        'TextBoxesOnFormButton
        '
        Me.TextBoxesOnFormButton.Location = New System.Drawing.Point(167, 21)
        Me.TextBoxesOnFormButton.Name = "TextBoxesOnFormButton"
        Me.TextBoxesOnFormButton.Size = New System.Drawing.Size(135, 23)
        Me.TextBoxesOnFormButton.TabIndex = 1
        Me.TextBoxesOnFormButton.Text = "Textboxes on form"
        Me.TextBoxesOnFormButton.UseVisualStyleBackColor = True
        '
        'TextBox2OnForm
        '
        Me.TextBox2OnForm.Location = New System.Drawing.Point(310, 66)
        Me.TextBox2OnForm.Name = "TextBox2OnForm"
        Me.TextBox2OnForm.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2OnForm.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 326)
        Me.Controls.Add(Me.TextBox2OnForm)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1OnForm)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.NameGroupBox)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Example"
        Me.NameGroupBox.ResumeLayout(False)
        Me.NameGroupBox.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameGroupBox As GroupBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DeleteButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents TextBox1OnForm As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBoxTextBoxesButton As Button
    Friend WithEvents TextBoxesOnFormButton As Button
    Friend WithEvents TextBox2OnForm As TextBox
End Class
