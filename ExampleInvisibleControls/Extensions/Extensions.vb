Imports DescendantsLibrary

Public Module Extensions
    <Runtime.CompilerServices.Extension>
    Public Function TextBoxVisibleList(pControl As Control) As List(Of TextBox)
        Return pControl.TextBoxList().Where(Function(box) box.Visible).ToList()
    End Function
    ''' <summary>
    ''' Get list of Label on control
    ''' </summary>
    ''' <param name="pControl">Control to find controls on</param>
    ''' <returns>List of Label or empty list</returns>
    <Runtime.CompilerServices.Extension>
    Public Function LabelVisibleList(pControl As Control) As List(Of Label)
        Return pControl.LabelList().Where(Function(lb) lb.Visible).ToList()
    End Function
End Module