Imports DescendantsLibrary

Public Class Form1
    Private Sub RateButton_Click(sender As Object, e As EventArgs) _
        Handles RateButton.Click

        Dim selectedRating = RatingsGroupBox.RadioButtonChecked()

        If selectedRating Is Nothing Then
            MessageBox.Show("Please select a rating.")
        Else
            MessageBox.Show($"Rating selected is {selectedRating.Text} using {selectedRating.Name}")
        End If

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ExcellentRadioButton.Checked = False
    End Sub
End Class
