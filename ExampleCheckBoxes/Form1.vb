Imports System.Globalization
Imports DescendantsLibrary

Public Class Form1
    ''' <summary>
    ''' Create a CheckBox for each month of the year in a FlowLayoutPanel
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim months =
                (
                    From month In CultureInfo.CurrentCulture.DateTimeFormat.MonthNames
                    Where Not String.IsNullOrEmpty(month)
                ).ToArray

        For Each monthName As String In months
            Dim cb As New CheckBox With {.Name = $"cb{monthName}", .Text = monthName}
            FlowLayoutPanel1.Controls.Add(cb)
        Next
    End Sub
    ''' <summary>
    ''' Get selected CheckBox controls.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SelectedCheckBoxesButton_Click(sender As Object, e As EventArgs) Handles SelectedCheckBoxesButton.Click
        ListBox1.DataSource = FlowLayoutPanel1.
            CheckBoxList.Where(Function(cb) cb.Checked).
            Select(Function(checkBox) checkBox.Text).
            ToList
    End Sub
End Class
