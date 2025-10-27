Public Class MainView


Private m_workFiles() As String
Private m_fileFlags() As Boolean

Private m_prvText As String


Private Sub initializeWorkFiles()
''--------------------------------------------------------------------
''    作業用のファイルを初期化する。
''--------------------------------------------------------------------
Dim i As Integer
Dim outText As String
Dim curText As String
Dim bFlag As Boolean

    ReDim Me.m_workFiles(2)
    ReDim Me.m_fileFlags(2)

    Me.m_workFiles(0) = "F:\Work\DisWdIp\DisWdIp.txt"
    Me.m_workFiles(1) = "L:\Work\DisWdIp\DisWdIp.txt"
    Me.m_fileFlags(0) = True
    Me.m_fileFlags(1) = True

    txtOutput.Text = $"{Me.m_prvText}{Environment.NewLine}"
    outText = $"{DateTime.Now:yyyy/MM/dd HH:mm:ss}  初期化"
    curText = $"{outText}{Environment.NewLine}"

    For i = 0 To 1
        bFlag = False
        curText += writeToWorkFile(Me.m_workFiles(i), outText, False, bFlag)
        Me.m_fileFlags(i) = bFlag
    Next i
    curText += $"{Environment.NewLine}完了"

    txtOutput.Text += $"{Environment.NewLine}{curText}{Environment.NewLine}"
    Me.m_prvText = curText

End Sub

Private Sub runDiskAccess()
''--------------------------------------------------------------------
''    指定されたディスクアクセスを実行する。
''--------------------------------------------------------------------
Dim i As Integer
Dim outText As String
Dim curText As String
Dim bFlag As Boolean

    txtOutput.Text = $"{Me.m_prvText}{Environment.NewLine}"
    outText = $"{DateTime.Now:yyyy/MM/dd HH:mm:ss}  書き込み"
    curText = $"{outText}{Environment.NewLine}"

    For i = 0 To 1
        bFlag = Me.m_fileFlags(i)
        If (bFlag = False) Then Continue For
        curText += writeToWorkFile(Me.m_workFiles(i), outText, True, bFlag)
    Next i
    curText += $"{Environment.NewLine}完了"

    txtOutput.Text += $"{Environment.NewLine}{curText}{Environment.NewLine}"
    Me.m_prvText = curText

End Sub


Private Function writeToWorkFile(
        ByVal fileName As String,
        ByVal strText As String,
        ByVal bAppend As Boolean,
        ByRef bValid As Boolean) As String
''--------------------------------------------------------------------
''    指定されたファイルに書き込みを行う
''
''  @param [in] fileName    書き込み先のファイル名
''  @param [in] strText     書き込む内容
''  @param [in] bAppend     真ならば追記を行う
''--------------------------------------------------------------------
Dim encUtf As System.Text.Encoding

    encUtf = System.Text.Encoding.UTF8
    bValid = False
    writeToWorkFile = ""

    Try
        Using sw As New System.IO.StreamWriter(fileName, bAppend, encUtf)
            sw.WriteLine(strText)
        End Using
        writeToWorkFile += $"ファイル {fileName} に書き込み成功!{Environment.NewLine}"
        bValid = True
    Catch e As Exception
        writeToWorkFile += $"ファイルにアクセスできません：{e.Message}{Environment.NewLine}"
    End Try

End Function


Private Sub MainView_Load(sender As Object, e As EventArgs) Handles _
            MyBase.Load
''--------------------------------------------------------------------
''    フォームのロードイベントハンドラ。
''--------------------------------------------------------------------

    Me.m_prvText = "ロード中"

    initializeWorkFiles()
    tmrDisk.Enabled = True
End Sub


Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles _
            btnRun.Click
''--------------------------------------------------------------------
''    「実行」ボタンのクリックイベントハンドラ。
''
''    入力したコマンドを実行する。
''--------------------------------------------------------------------

    runDiskAccess()
End Sub

Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles _
            mnuFileExit.Click
''--------------------------------------------------------------------
''    メニュー「ファイル」－「終了」
''--------------------------------------------------------------------

    Application.Exit()
End Sub


Private Sub mnuRunCommand_Click(sender As Object, e As EventArgs) Handles _
            mnuRunCommand.Click
''--------------------------------------------------------------------
''    メニュー「実行」－「コマンドを実行」
''--------------------------------------------------------------------

    runDiskAccess()
End Sub


Private Sub tmrDisk_Tick(sender As Object, e As EventArgs) Handles _
            tmrDisk.Tick
''--------------------------------------------------------------------
''    「タイマー」のイベントハンドラ
''--------------------------------------------------------------------

    runDiskAccess()
End Sub

End Class
