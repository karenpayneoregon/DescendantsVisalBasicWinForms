Imports System.Windows.Forms
Imports ParentTrailLibrary.Classes

Public Module ControlExtensions
    ''' <summary>
    ''' Compose parents for 
    ''' </summary>
    ''' <param name="pSender"></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension()>
    Function ParentTrail(pSender As Control) As String
        Dim theParent As Control = pSender

        Dim backwardsPath As String = ""

        Do
            theParent = theParent.Parent
            backwardsPath &= theParent.Name & "."
        Loop Until TypeOf TheParent Is Form Or TheParent Is Nothing

        Dim parts() As String = backwardsPath.Split(".".ToCharArray)

        Dim path As String = ""
        Dim count As Integer = parts.Count - 1

        For token As Integer = count To 0 Step -1
            If token = count Then
                path &= parts(token)
            Else
                path &= parts(Token) & "."
            End If
        Next

        Return path

    End Function
    <Runtime.CompilerServices.Extension()>
    Public Function GetParentInformation(pSender As List(Of Control)) As List(Of ParentInfo)
        Dim parentInfoList As New List(Of ParentInfo)

        pSender.ForEach(Sub(panel) parentInfoList.Add(New ParentInfo(panel.Name, $"{panel.ParentTrail}{panel.Name}")))

        Return parentInfoList
    End Function

End Module