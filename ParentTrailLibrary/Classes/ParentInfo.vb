Namespace Classes
    Public Class ParentInfo
        ''' <summary>
        ''' Current control name
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Name As String
        ''' <summary>
        ''' Complete path of control back to the form level
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property ParentTrail As String

        Protected _ImmediateParent As String
        ''' <summary>
        ''' Represents this control's parent control
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public ReadOnly Property ImmediateParent As String
            Get
                Return _ImmediateParent
            End Get
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="pName">Name of control</param>
        ''' <param name="pParentTrail">trail from ParentTrail language extension method</param>
        ''' <remarks></remarks>
        Public Sub New(pName As String, pParentTrail As String)
            Dim tempPath As String = pParentTrail.Replace("." & pName, "")

            Name = pName
            ParentTrail = pParentTrail

            If tempPath.Contains(".") Then
                tempPath = tempPath.Substring(tempPath.LastIndexOf(".", StringComparison.Ordinal) + 1)
            End If

            _ImmediateParent = TempPath

        End Sub
    End Class
End Namespace