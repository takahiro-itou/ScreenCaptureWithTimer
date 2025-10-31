Public Class MainView


Private m_workFiles() As String
Private m_fileFlags() As Boolean

Private m_prvText As String


Private Sub captureScreen(
        ByVal fileName As String) As Boolean
''--------------------------------------------------------------------
''    指定したウィンドウのキャプチャを行う
''--------------------------------------------------------------------

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
            btnRunStart.Click
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

    captureScreen()
End Sub

End Class
