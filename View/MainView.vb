
Public Class MainView


Private m_outPrefix As String
Private m_nextNumber As Integer
Private m_hSrcWnd As IntPtr
Private m_srcRect As System.Drawing.Rectangle


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

    imgBuffer.Save($"{fileName}.png")
    imgBuffer.Save($"{fileName}.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
    imgBuffer.Save($"{fileName}.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

    imgCanvas = New System.Drawing.Bitmap(
            imgBuffer, picView.Width, picView.Height)
    picView.Image = imgCanvas

    Return  False
End Function


Private Function captureScreen() As Boolean
''--------------------------------------------------------------------
''    ウィンドウのキャプチャを行う
''--------------------------------------------------------------------
Dim strPath As String

    strPath = $"{Me.m_outPrefix}-{Me.m_nextNumber}"
    Me.m_nextNumber = Me.m_nextNumber + 1

    Return  captureScreen(Me.m_hSrcWnd, Me.m_srcRect, strPath)

End Function


Private Function initializeCapture() As Boolean
''--------------------------------------------------------------------
''    キャプチャの初期化を行う
''--------------------------------------------------------------------

    Me.m_outPrefix = txbOutput.Text
    Me.m_nextNumber = 0
    tmrSnap.Interval = updInterval.Value
    tmrSnap.Enabled = False

    Return  captureScreen()

End Function


Private Function setSourceRect(
    ByVal srcRect As System.Drawing.Rectangle) As Boolean
''--------------------------------------------------------------------
''    ソース矩形を設定する。
''--------------------------------------------------------------------

    Me.m_srcRect = srcRect
    showSourceRect(Me.m_srcRect)

    Return  initializeCapture()

End Function


Private Function setSourceRect(ByVal strRect As String) As Boolean
''--------------------------------------------------------------------
''    ソース矩形を設定する。
''--------------------------------------------------------------------
Dim parts1 As String()
Dim X As Integer
Dim Y As Integer
Dim W As Integer
Dim H As Integer

    parts1 = strRect.Split(New String() {","}, 4, StringSplitOptions.None)
    X = Val(parts1(0))
    Y = Val(parts1(1))
    W = Val(parts1(2))
    H = Val(parts1(3))

    Return  setSourceRect(
        New System.Drawing.Rectangle With {.X = X, .Y = Y, .Width = W, .Height = H})
End Function


Private Function setSourceWindow(ByVal hWnd As IntPtr) As Boolean
''--------------------------------------------------------------------
''    ソースウィンドウを設定する。
''--------------------------------------------------------------------
Dim srcRect As System.Drawing.Rectangle

    Me.m_hSrcWnd = hWnd
    showSourceWindow(Me.m_hSrcWnd)

    GetWindowRect(hWnd, srcRect)
    Return  setSourceRect(srcRect)

End Function


Private Function setSourceWindow(ByVal strWnd As String) As Boolean
''--------------------------------------------------------------------
''    ソースウィンドウを設定する。
''--------------------------------------------------------------------
Dim x As Integer
Dim hWnd As IntPtr

    If strWnd = "" Then
        hWnd = IntPtr.Zero
    Else
        x = Convert.ToInt32(strWnd, 16)
        hWnd = x
    End If

    Return  setSourceWindow(hWnd)
End Function


Private Sub showSourceRect(ByVal r As System.Drawing.Rectangle)
''--------------------------------------------------------------------
''    ソース矩形の情報を表示する。
''--------------------------------------------------------------------

    txbRect.Text = $"{r.Left}, {r.Top}, {r.Width}, {r.Height}"
End Sub


Private Sub showSourceWindow(ByVal hWnd As IntPtr)
''--------------------------------------------------------------------
''    ソースウィンドウの情報を表示する。
''--------------------------------------------------------------------
Dim sbWndName As System.Text.StringBuilder
Dim strWnd As String

    strWnd = hWnd.ToString("X")

    ' ウィンドウキャプションを取得する
    sbWndName = New System.Text.StringBuilder(65536)
    GetWindowText(hWnd, sbWndName, 65536)

    Me.txbWnd.Text = $"0x{strWnd}:{sbWndName}"
End Sub


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

    ' マウスをリリースする
    Me.Capture = False

    ' マウスの位置からウィンドウハンドルを取得する
    hWnd = WindowFromPoint(Cursor.Position)

    setSourceWindow(hWnd)

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


Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles _
            btnPause.Click
''--------------------------------------------------------------------
''    ボタンのクリックイベントハンドラ。
''
''    一時停止する
''--------------------------------------------------------------------

    tmrSnap.Enabled = False
End Sub


Private Sub btnRectOK_Click(sender As Object, e As EventArgs) Handles _
            btnRectOK.Click
''--------------------------------------------------------------------
''    ボタンのクリックイベントハンドラ。
''
''    手動で入力した矩形情報をパラメータにセットする
''--------------------------------------------------------------------

    setSourceRect(txbRect.Text)
End Sub


Private Sub btnWndOK_Click(sender As Object, e As EventArgs) Handles _
            btnWndOK.Click
''--------------------------------------------------------------------
''    ボタンのクリックイベントハンドラ。
''
''    テキストに入力した HWND をパラメータにセットする
''--------------------------------------------------------------------
Dim parts1 As String()

    parts1 = txbWnd.Text.Split(New String() {":"}, 2, StringSplitOptions.None)
    setSourceWindow(parts1(0))
End Sub


Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles _
            mnuFileExit.Click
''--------------------------------------------------------------------
''    メニュー「ファイル」－「終了」
''--------------------------------------------------------------------

    Application.Exit()
End Sub


Private Sub mnuRunPause_Click(sender As Object, e As EventArgs) Handles _
            mnuRunPause.Click
''--------------------------------------------------------------------
''    メニュー「実行」－「一時停止」
''--------------------------------------------------------------------

    tmrSnap.Enabled = False
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

    captureScreen(IntPtr.Zero, Screen.PrimaryScreen.Bounds, "Test")
End Sub


Private Sub txbRect_ButtonClick(sender As Object, e As EventArgs) Handles _
            txbRect.ButtonClick
''--------------------------------------------------------------------
''    「Src Rect」ボックスのボタンクリックイベントハンドラ。
''--------------------------------------------------------------------
Dim f As WinFormsControl.RectSelectForm
Dim r As System.Drawing.Rectangle
Dim dResult As System.Windows.Forms.DialogResult
Dim bUpdate As Boolean

    bUpdate = False
    f = New WinFormsControl.RectSelectForm
    With f
        dResult = .ShowDialog(Me)
        If dResult = System.Windows.Forms.DialogResult.OK Then
            bUpdate = True
            r = .lastRect
        End If
        .Close()
        .Dispose()
    End With

    If bUpdate Then
        setSourceRect(r)
    End If

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
