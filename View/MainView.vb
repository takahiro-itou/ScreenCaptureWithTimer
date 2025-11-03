
Public Class MainView


Private m_nextNumber As Integer


Private Function captureScreen(
    ByVal fileName As String) As Boolean
''--------------------------------------------------------------------
''    指定したウィンドウのキャプチャを行う
''--------------------------------------------------------------------
Dim imgCanvas As System.Drawing.Bitmap
Dim imgBuffer As System.Drawing.Bitmap
Dim grpBuffer As System.Drawing.Graphics
Dim hDisplayDC As IntPtr
Dim hDstDC As IntPtr

    hDisplayDC = GetDC(IntPtr.Zero)

    imgBuffer = New System.Drawing.Bitmap(
            Screen.PrimaryScreen.Bounds.Width,
            Screen.PrimaryScreen.Bounds.Height)
    grpBuffer = System.Drawing.Graphics.FromImage(imgBuffer)

    hDstDC = grpBuffer.GetHdc()
    BitBlt(hDstDC, 0, 0,
           Screen.PrimaryScreen.Bounds.Width,
           Screen.PrimaryScreen.Bounds.Height,
           hDisplayDC, 0, 0, SRCCOPY)
    grpBuffer.ReleaseHdc(hDstDC)
    ReleaseDC(IntPtr.Zero, hDisplayDC)

    imgBuffer.Save(fileName)
    imgBuffer.Save("Test.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
    imgBuffer.Save("Test.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

    imgCanvas = New System.Drawing.Bitmap(
            imgBuffer, picView.Width, picView.Height)
    picView.Image = imgCanvas

    Return  False
End Function


Private Sub MainView_Load(sender As Object, e As EventArgs) Handles _
            MyBase.Load
''--------------------------------------------------------------------
''    フォームのロードイベントハンドラ。
''--------------------------------------------------------------------

    tmrSnap.Interval = 2000
    tmrSnap.Enabled = False
End Sub


Private Sub btnRunStart_Click(sender As Object, e As EventArgs) Handles _
            btnRun.Click
''--------------------------------------------------------------------
''    「実行」ボタンのクリックイベントハンドラ。
''
''    入力したコマンドを実行する。
''--------------------------------------------------------------------

    tmrSnap.Enabled = True
End Sub

Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles _
            mnuFileExit.Click
''--------------------------------------------------------------------
''    メニュー「ファイル」－「終了」
''--------------------------------------------------------------------

    Application.Exit()
End Sub


Private Sub mnuRunStart_Click(sender As Object, e As EventArgs) Handles _
            mnuRunStart.Click
''--------------------------------------------------------------------
''    メニュー「実行」－「コマンドを実行」
''--------------------------------------------------------------------

    tmrSnap.Enabled = True
End Sub


Private Sub tmrSnap_Tick(sender As Object, e As EventArgs) Handles _
            tmrSnap.Tick
''--------------------------------------------------------------------
''    「タイマー」のイベントハンドラ
''--------------------------------------------------------------------

    captureScreen("Test.png")
End Sub


Private Sub txbWnd_ButtonClick(sender As Object, e As EventArgs) Handles _
            txbWnd.ButtonClick
''--------------------------------------------------------------------
''    「HWND」ボックスのボタンクリックイベントハンドラ。
''--------------------------------------------------------------------
    picView.Image = Nothing
    Me.Capture = True
    Me.Text = "Now Capture"
End Sub

End Class
