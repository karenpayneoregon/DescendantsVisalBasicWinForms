Imports System.Windows.Forms

Public Module ControlExtensions
    ''' <summary>
    ''' Provides access to all controls on a form including
    ''' controls within containers e.g. panel and group-box etc.
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="control"></param>
    ''' <returns></returns>
    <Runtime.CompilerServices.Extension>
    Public Iterator Function Descendants(Of T As Class)(control As Control) As IEnumerable(Of T)
        For Each child As Control In control.Controls

            Dim currentChild = TryCast(child, T)
            If currentChild IsNot Nothing Then
                Yield currentChild
            End If

            If child.HasChildren Then
                For Each descendant As T In child.Descendants(Of T)()
                    Yield descendant
                Next
            End If
        Next

    End Function
    <Runtime.CompilerServices.Extension>
    Public Function TextBoxList(pControl As Control) As List(Of TextBox)
        Return pControl.Descendants(Of TextBox)().ToList()
    End Function
    <Runtime.CompilerServices.Extension>
    Public Function CheckBoxList(pControl As Control) As List(Of CheckBox)
        Return pControl.Descendants(Of CheckBox)().ToList()
    End Function
    <Runtime.CompilerServices.Extension>
    Public Function ComboBoxList(pControl As Control) As List(Of ComboBox)
        Return pControl.Descendants(Of ComboBox)().ToList()
    End Function
    <Runtime.CompilerServices.Extension>
    Public Function PictureBoxList(pControl As Control) As List(Of PictureBox)
        Return pControl.Descendants(Of PictureBox)().ToList()
    End Function
    <Runtime.CompilerServices.Extension>
    Public Function PanelList(pControl As Control) As List(Of Panel)
        Return pControl.Descendants(Of Panel)().ToList()
    End Function
    <Runtime.CompilerServices.Extension>
    Public Function RadioButtonList(pControl As Control) As List(Of RadioButton)
        Return pControl.Descendants(Of RadioButton)().ToList()
    End Function
    <Runtime.CompilerServices.Extension>
    Public Function NumericUpDownList(pControl As Control) As List(Of NumericUpDown)
        Return pControl.Descendants(Of NumericUpDown)().ToList()
    End Function
End Module