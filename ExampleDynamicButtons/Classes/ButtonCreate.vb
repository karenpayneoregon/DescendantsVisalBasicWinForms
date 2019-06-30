Imports System.IO

Namespace Classes
    Public Class ButtonCreate
        ''' <summary>
        ''' Parent control where button controls will be placed
        ''' </summary>
        Public Property ParentControl() As Control
        Public Property ButtonPreFix() As String = "cmd"

        Protected BaseHeight As Integer = 10
        Protected ButtonWidth As Integer = 150
        Private _indexer As Integer = 0

        ''' <summary>
        ''' Create a single button with caption and setup an action to open a file
        ''' </summary>
        ''' <param name="pCaption">Text to show</param>
        ''' <param name="pFileName">Existing file to open</param>
        Public Sub CreateSingleButton(pCaption As String, pFileName As String)

            _indexer += 1

            Dim b = New Button With {
                    .Name = $"{ButtonPreFix}Generated{_indexer}",
                    .Text = pCaption,
                    .Width = ButtonWidth,
                    .Location = New Point(25, BaseHeight),
                    .Parent = ParentControl,
                    .Tag = pFileName
                    }

            AddHandler b.Click, Sub(s As Object, e As EventArgs)
                                    Dim buttonName = DirectCast(DirectCast(s, Button).Tag, String)
                                    If File.Exists(buttonName) Then
                                        Process.Start(DirectCast(DirectCast(s, Button).Tag, String))
                                    Else
                                        MessageBox.Show($"{buttonName} not found")
                                    End If

                                End Sub

            ParentControl.Controls.Add(b)
            BaseHeight += 30

        End Sub
    End Class
End Namespace