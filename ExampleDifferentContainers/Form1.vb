Imports DescendantsLibrary
Imports LanguageExtensions

Public Class Form1
    Private Sub GroupBoxTextBoxesButton_Click(sender As Object, e As EventArgs) _
        Handles GroupBoxTextBoxesButton.Click

        MessageBox.Show(NameGroupBox.
                           TextBoxList().
                           ControlNames.
                           JoinedBy(Environment.NewLine))

    End Sub
    ''' <summary>
    ''' Get TextBox controls on form canvas, exclude those in child containers
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TextBoxesOnFormButton_Click(sender As Object, e As EventArgs) _
        Handles TextBoxesOnFormButton.Click

        Dim orderedByNameOnFormCanvas As String =
                TextBoxList().
                OrderBy(Function(c) c.Name).
                Where(Function(c) c.Parent Is Me).
                ControlNames.
                JoinedBy(Environment.NewLine)

        MessageBox.Show(orderedByNameOnFormCanvas)

    End Sub
End Class
