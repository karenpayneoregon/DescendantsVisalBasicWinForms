Public Module EnumerableExtensions
    ''' <summary>
    ''' Concatenates all elements of a sequence using the specified separator between each element.
    ''' </summary>
    ''' <typeparam name="TSource">The type of the elements of <paramref name="values"/>.</typeparam>
    ''' <param name="values">A sequence that contains the objects to concatenate.</param>
    ''' <param name="separator">The string to use as a separator.</param>
    ''' <returns>A string holding the concatenated values.</returns>
    <Runtime.CompilerServices.Extension>
    Public Function JoinedBy(Of TSource)(values As IEnumerable(Of TSource), separator As String) As String
        Return String.Join(separator, values)
    End Function
End Module
