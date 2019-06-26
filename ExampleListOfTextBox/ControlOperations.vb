Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class ControlOperations
    Public Property List() As List(Of ControlInformation)
    Public Property FileName() As String
    Public Sub New(pFileName As String)
        List = New List(Of ControlInformation)
        FileName = pFileName
    End Sub
    Public Function Load() As Boolean
        Dim success As Boolean
        Dim bf As New BinaryFormatter
        Dim item As Object

        Dim fs As New FileStream(FileName, FileMode.OpenOrCreate)

        Try

            Do
                item = bf.Deserialize(fs)

                If item.GetType Is GetType(ControlInformation) Then
                    List.Add(CType(item, ControlInformation))
                End If

            Loop While fs.Position < fs.Length - 1

        Catch ex As Exception

        Finally
            fs.Close()
            If Not (bf Is Nothing) Then
                bf = Nothing
            End If
        End Try

        Return List.Count > 0

    End Function

    Public Function Save() As Boolean
        Dim success As Boolean

        Dim bf As New BinaryFormatter
        Try

            Using fs As New FileStream(FileName, FileMode.Create)

                For Each Info In List
                    bf.Serialize(fs, Info)
                Next

                fs.Close()
                success = True
            End Using
        Catch ex As Exception
            Console.WriteLine()
            ' decide how to handle
        Finally
            If Not (bf Is Nothing) Then
                bf = Nothing
            End If
        End Try

        Return success

    End Function

End Class
