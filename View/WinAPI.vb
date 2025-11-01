
Imports System.Runtime.InteropServices

Module WinAPI

Public Const SRCCOPY As Integer = &HCC0020

<DllImport("gdi32.dll")> _
Public Function BitBlt(
    ByVal hDestDC As IntPtr,
    ByVal X As Integer,
    ByVal Y As Integer,
    ByVal nWidth As Integer,
    ByVal nHeight As Integer,
    ByVal hSrcDC As IntPtr,
    ByVal xSrc As Integer,
    ByVal ySrc As Integer,
    ByVal dwRop As Integer) As Integer
End Function

<DllImport("user32.dll")> _
Public Function GetDC(ByVal hWnd As IntPtr) As IntPtr
End Function

<DllImport("user32.dll")> _
Public Function ReleaseDC(
    ByVal hWnd As IntPtr, ByVal hDC As IntPtr) As IntPtr
End Function

<DllImport("user32.dll")> _
Public Function GetWindowRect(
    ByVal hWnd As IntPtr,
    ByRef lpRect As System.Drawing.Rectangle) As Boolean
End Function

<DllImport("user32.dll")> _
Public Function WindowFromPoint(
    ByVal pt As System.Drawing.Point) As IntPtr
End Function

End Module
