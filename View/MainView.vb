
Public Class MainView


Private m_nextNumber As Integer


Private Function captureScreen(
    ByVal hWnd As IntPtr,
    ByVal srcRect As System.Drawing.Rectangle,
    ByVal fileName As String) As Boolean
''--------------------------------------------------------------------
''    指定したウィンドウのキャプチャを行う
''--------------------------------------------------------------------
Dim imgCanvas As System.Drawing.Bitmap
Dim imgBuffer As System.Drawing.Bitmap
Dim grpBuffer As System.Drawing.Graphics
Dim hDisplayDC As IntPtr
Dim hDstDC As IntPtr

    hDisplayDC = GetDC(hWnd)

    imgBuffer = New System.Drawing.Bitmap(srcRect.Width, srcRect.Height)
    grpBuffer = System.Drawing.Graphics.FromImage(imgBuffer)

    hDstDC = grpBuffer.GetHdc()
    BitBlt(hDstDC, 0, 0, srcRect.Width, srcRect.Height,
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


Private Sub MainView_MouseDown(sender As Object, e As EventArgs) Handles _
            Me.MouseDown
''--------------------------------------------------------------------
''    フォームのマウスダウンイベントハンドラ。
''--------------------------------------------------------------------
Dim hWnd As IntPtr
Dim rectSrc As System.Drawing.Rectangle
Dim sbWndName As System.Text.StringBuilder

    Me.Capture = False

    ' マウスの位置からウィンドウハンドルを取得する
    hWnd = WindowFromPoint(Cursor.Position)
    GetWindowRect(hWnd, rectSrc)

    ' ウィンドウキャプションを取得する
    sbWndName = New System.Text.StringBuilder(65536)
    GetWindowText(hWnd, sbWndName, 65536)
    Me.txbWnd.Text = $"{hWnd}:${sbWndName}"
    Me.txbRect.Text = $"{rectSrc.Left}, {rectSrc.Top}, {rectSrc.Width}, {rectSrc.Height}"
End Sub


Private Sub btnDesktop_Click(sender As Object, e As EventArgs) Handles _
            btnDesktop.Click
''--------------------------------------------------------------------
''    「デスクトップ」ボタンのクリックイベントハンドラ。
''
''    デスクトップの HWND をテキストボックスに表示する。
''--------------------------------------------------------------------
Dim hWndDesktop As IntPtr

    hWndDesktop = GetDesktopWindow()
    txbWnd.Text = $"{hWndDesktop}"
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

    captureScreen(IntPtr.Zero, Screen.PrimaryScreen.Bounds, "Test.png")
End Sub


Private Sub txbRect_ButtonClick(sender As Object, e As EventArgs) Handles _
            txbRect.ButtonClick
''--------------------------------------------------------------------
''    「Src Rect」ボックスのボタンクリックイベントハンドラ。
''--------------------------------------------------------------------
    Dim f As WinFormsControl.RectSelectForm

    f = New WinFormsControl.RectSelectForm
    With f
        .ShowDialog()
        If .DialogResult = System.Windows.Forms.DialogResult.OK Then
            txbRect.Text = $"{ .lastRect.Left}, { .lastRect.Top}, { .lastRect.Width}, { .lastRect.Height}"
        End If
        .Dispose()
    End With

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
