Imports System.ComponentModel
Imports System.IO
Imports DescendantsLibrary

Public Class Form1
    Private FileName As String =
                Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory, "controlData.dat")


    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim ops = New ControlOperations(FileName)
        If ops.FileExists() Then
            If ops.Load() Then
                For Each data As ControlInformation In ops.List
                    Console.WriteLine(data)
                    Dim tb = GroupBox1.Controls.Find(data.Name, False)(0)
                    tb.Text = data.Text
                Next
            Else
                MessageBox.Show($"Failed to load: {ops.LastExceptionMessage}")
            End If
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Dim TextBoxList = GroupBox1.TextBoxList.OrderBy(Function(box) box.TabIndex)
        Dim ops = New ControlOperations(FileName)

        ops.List = TextBoxList.
            Select(Function(box) New ControlInformation With
                      {.Name = box.Name, .Text = box.Text}).ToList()

        If Not ops.Save() Then
            MessageBox.Show($"Failed to load: {ops.LastExceptionMessage}")
        End If

    End Sub
End Class
