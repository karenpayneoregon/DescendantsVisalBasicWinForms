Imports System.IO
Imports DescendantsLibrary

Public Class Form1
    Private FileName As String =
                Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory, "controlData.dat")
    Private Sub GetTextBoxesButton_Click(sender As Object, e As EventArgs) _
        Handles GetTextBoxesButton.Click

        Dim TextBoxList = GroupBox1.TextBoxList.OrderBy(Function(box) box.TabIndex)
        Dim ops = New ControlOperations(FileName)

        ops.List = TextBoxList.
            Select(Function(box) New ControlInformation With
                      {.Name = box.Name, .Text = box.Text}).ToList()
        ops.Save()
    End Sub

    Private Sub LoadTextBoxesButton_Click(sender As Object, e As EventArgs) Handles LoadTextBoxesButton.Click
        Dim ops = New ControlOperations(FileName)
        If ops.Load() Then
            For Each data As ControlInformation In ops.List
                Console.WriteLine(data)
                Dim tb = GroupBox1.Controls.Find(data.Name, False)(0)
                tb.Text = data.Text
            Next
        End If
    End Sub
End Class
