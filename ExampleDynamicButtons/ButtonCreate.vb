Imports System.IO
Public Class ButtonCreate
    Public Property Items() As Dictionary(Of Integer, Button)
    ''' <summary>
    ''' Parent control where TextBox controls will be placed
    ''' </summary>
    Public Property ParentControl() As Control

    Private baseHeight As Integer = 10
    Private buttonWidth As Integer = 150
    Private indexer As Integer = 0

    Public Sub New()
        Items = New Dictionary(Of Integer, Button)()
    End Sub
    ''' <summary>
    ''' Create a single TextBox
    ''' </summary>
    Public Sub CreateSingleButton(pCaption As String, pFileName As String)

        indexer += 1

        Dim b = New Button With {
                .Name = $"btnGenerated{indexer}",
                .Text = pCaption,
                .Width = buttonWidth,
                .Location = New Point(25, baseHeight),
                .Parent = ParentControl,
                .Tag = pFileName
                }

        AddHandler b.Click, Sub(s As Object, e As EventArgs)
                                Dim buttonName = DirectCast((DirectCast(s, Button)).Tag, String)
                                If File.Exists(buttonName) Then
                                    Process.Start(DirectCast(DirectCast(s, Button).Tag, String))
                                Else
                                    MessageBox.Show($"{buttonName} not found")
                                End If

                            End Sub

        ParentControl.Controls.Add(b)
        Items.Add(indexer, b)
        baseHeight += 30

    End Sub
End Class
