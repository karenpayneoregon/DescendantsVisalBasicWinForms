Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports ExampleListOfTextBox.Classes.ExceptionHandling

Namespace Classes
    Public Class ControlOperations
        Inherits BaseExceptionProperties
        Public Property List() As List(Of ControlInformation)
        Public Property FileName() As String
        Public Sub New(pFileName As String)
            List = New List(Of ControlInformation)
            FileName = pFileName
        End Sub
        ''' <summary>
        ''' Use this before a load to ensure there is a file to read.
        ''' </summary>
        ''' <returns></returns>
        Public Function FileExists() As Boolean
            Return File.Exists(FileName)
        End Function
        ''' <summary>
        ''' Used to start over again.
        ''' </summary>
        ''' <returns></returns>
        Public Function DeleteFile() As Boolean
            mHasException = False

            Try
                File.Delete(FileName)
                Return True
            Catch ex As Exception
                mHasException = True
                mLastException = ex
            End Try

            Return IsSuccessful

        End Function
        ''' <summary>
        ''' Load data file with known controls
        ''' </summary>
        ''' <returns></returns>
        Public Function Load() As Boolean

            mHasException = False

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
                mHasException = True
                mLastException = ex
            Finally
                fs.Close()
                If Not (bf Is Nothing) Then
                    bf = Nothing
                End If
            End Try

            Return List.Count > 0

        End Function
        ''' <summary>
        ''' Save known controls to dat file.
        ''' </summary>
        ''' <returns></returns>
        Public Function Save() As Boolean

            mHasException = False
            Dim identifier As Integer = 1

            Dim bf As New BinaryFormatter

            Try

                Using fs As New FileStream(FileName, FileMode.Create)

                    For Each Info In List
                        Info.Id = identifier
                        bf.Serialize(fs, Info)
                        identifier += 1
                    Next

                    fs.Close()

                End Using
            Catch ex As Exception
                mHasException = True
                mLastException = ex
            Finally
                If Not (bf Is Nothing) Then
                    bf = Nothing
                End If
            End Try

            Return IsSuccessful

        End Function
        ''' <summary>
        ''' Remove ControlInformation by primary key
        ''' </summary>
        ''' <param name="pControlInformation"></param>
        ''' <returns></returns>
        Public Function Remove(pControlInformation As ControlInformation) As Boolean
            mHasException = False

            Try
                If List.FirstOrDefault(Function(item) item.Id = pControlInformation.Id) IsNot Nothing Then
                    List.Remove(pControlInformation)
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                mHasException = True
                mLastException = ex
            End Try

            Return IsSuccessful

        End Function
        ''' <summary>
        ''' Add a new ControlInformation
        ''' </summary>
        ''' <param name="pControlInformation"></param>
        Public Sub Add(pControlInformation As ControlInformation)

            mHasException = False
            Dim identifier As Integer = 1

            Try
                If List.Count > 0 Then
                    identifier = List.Select(Function(item) item.Id).Max() + 1
                End If

                pControlInformation.Id = identifier
                List.Add(pControlInformation)

            Catch ex As Exception
                mHasException = True
                mLastException = ex
            End Try

        End Sub
    End Class
End Namespace