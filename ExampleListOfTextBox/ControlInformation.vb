''' <summary>
''' Represents controls on a form
''' </summary>
<Serializable()>
Public Class ControlInformation
    Public Property Name() As String
    Public Property Text As String

    Public Overrides Function ToString() As String
        Return $"{Name}, {Text}"
    End Function
End Class
