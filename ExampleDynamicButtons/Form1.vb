Imports System.IO
Imports DescendantsLibrary
Imports ExampleDynamicButtons.Classes
Imports LanguageExtensions

Public Class Form1
    Private Creator As ButtonCreate
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Creator = New ButtonCreate() With {.ParentControl = FlowLayoutPanel1}

        Dim files = Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory), "*.txt")
        For Each file As String In files
            Creator.CreateSingleButton(Path.GetFileNameWithoutExtension(file), file)
        Next
    End Sub

    Private Sub DescendantsButton_Click(sender As Object, e As EventArgs) Handles DescendantsButton.Click
        MessageBox.Show(FlowLayoutPanel1.ButtonList.ControlNames().JoinedBy(Environment.NewLine))
    End Sub
End Class
