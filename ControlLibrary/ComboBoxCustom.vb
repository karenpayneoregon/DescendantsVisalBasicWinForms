Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
''' <summary>
''' Provides the capability to set read-only background color
''' </summary>
Public Class ComboBoxCustom
    Inherits ComboBox

    <Category("Appearance"), Description("Set disabled background color")>
    Public Property DisabledBackGroundColor() As Color

    <DllImport("gdi32.dll")>
    Friend Shared Function CreateSolidBrush(color As Integer) As IntPtr
    End Function

    <DllImport("gdi32.dll")>
    Friend Shared Function SetBkColor(hdc As IntPtr, color As Integer) As Integer
    End Function

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)

        Dim brush As IntPtr

        Select Case m.Msg
            Case 312
                SetBkColor(m.WParam, ColorTranslator.ToWin32(DisabledBackGroundColor))
                brush = CreateSolidBrush(ColorTranslator.ToWin32(DisabledBackGroundColor))
                m.Result = brush
            Case Else
        End Select
    End Sub
End Class
