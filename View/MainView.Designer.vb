<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = _
            New System.ComponentModel.ComponentResourceManager(GetType(MainView))

        mnuMain = New MenuStrip()
        mnuFile = New ToolStripMenuItem()
        mnuFileExit = New ToolStripMenuItem()
        mnuRun = New ToolStripMenuItem()
        mnuRunStart = New ToolStripMenuItem()
        mnuRunPause = New ToolStripMenuItem()

        tmrSnap = New Timer(components)
        dlgSave = New SaveFileDialog()

        Label1 = New Label()
        txtWnd = New TextBox()
        btnWnd = New Button()

        Label1 = New Label()
        txtOutput = New TextBox()
        btnOutput = New Button()

        btnRun = New Button()
        btnPause = New Button()
        picView = New PictureBox()

        mnuMain.SuspendLayout()
        CType(picView, ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '
        ' mnuMain
        '
        resources.ApplyResources(mnuMain, "mnuMain")
        mnuMain.Items.AddRange(New ToolStripItem() {mnuFile, mnuRun})
        mnuMain.Name = "mnuMain"
        '
        ' mnuFile
        '
        resources.ApplyResources(mnuFile, "mnuFile")
        mnuFile.DropDownItems.AddRange(New ToolStripItem() {mnuFileExit})
        mnuFile.Name = "mnuFile"
        '
        ' mnuFileExit
        '
        resources.ApplyResources(mnuFileExit, "mnuFileExit")
        mnuFileExit.Name = "mnuFileExit"
        '
        ' mnuRun
        '
        resources.ApplyResources(mnuRun, "mnuRun")
        mnuRun.DropDownItems.AddRange(New ToolStripItem() {mnuRunStart, mnuRunPause})
        mnuRun.Name = "mnuRun"
        '
        ' mnuRunStart
        '
        resources.ApplyResources(mnuRunStart, "mnuRunStart")
        mnuRunStart.Name = "mnuRunStart"
        '
        ' mnuRunPause
        '
        mnuRunStart.Name = "mnuRunPause"

        '
        ' tmrSnap
        '
        resources.ApplyResources(tmrSnap, "tmrSnap")
        tmrSnap.Interval = 60000

        '
        ' dlgSave
        '
        resources.ApplyResources(dlgSave, "dlgSave")
        dlgSave.FileName = "dlgSave"

        '
        ' Label1
        '
        resources.ApplyResources(Label1, "Label1")
        Label1.Name = "Label1"
        '
        ' txtWnd
        '
        resources.ApplyResources(txtWnd, "txtWnd")
        txtWnd.Name = "txtWnd"
        '
        ' btnWnd
        '
        btnWnd.Name = "btnWnd"
        btnWnd.UseVisualStyleBackColor = True

        '
        ' Label2
        '
        Label1.Name = "Label2"
        '
        ' txtOutput
        '
        resources.ApplyResources(txtOutput, "txtOutput")
        txtOutput.Name = "txtOutput"
        txtOutput.BackColor = SystemColors.Window
        '
        ' btnOutput
        '
        btnOutput.Name = "btnOutput"
        btnOutput.UseVisualStyleBackColor = True

        '
        ' btnRun
        '
        resources.ApplyResources(btnRun, "btnRun")
        btnRun.Name = "btnRun"
        btnRun.UseVisualStyleBackColor = True
        '
        ' btnPause
        '
        btnPause.Name = "btnPause"
        btnPause.UseVisualStyleBackColor = True

        '
        ' picView
        '
        picView.BackColor = Color.White
        picView.Name = "picView"
        picView.TabStop = False

        '
        ' MainView
        '
        resources.ApplyResources(Me, "$this")
        AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(mnuMain)
        Me.Controls.Add(Label1)
        Me.Controls.Add(txtWnd)
        Me.Controls.Add(btnWnd)
        Me.Controls.Add(Label2)
        Me.Controls.Add(txtOutput)
        Me.Controls.Add(btnOutput)
        Me.Controls.Add(btnRun)
        Me.Controls.Add(btnPause)
        Me.Controls.Add(picView)
        Me.MainMenuStrip = mnuMain
        Me.Name = "MainView"

        mnuMain.ResumeLayout(False)
        mnuMain.PerformLayout()
        CType(picView, ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuRun As ToolStripMenuItem
    Friend WithEvents mnuRunStart As ToolStripMenuItem
    Friend WithEvents mnuRunPause As ToolStripMenuItem

    Friend WithEvents tmrSnap As Timer
    Friend WithEvents dlgSave As SaveFileDialog

    Friend WithEvents Label1 As Label
    Friend WithEvents txtWnd As TextBox
    Friend WithEvents btnWnd As Button

    Friend WithEvents Label2 As Label
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents btnOutput As Button

    Friend WithEvents btnRun As Button
    Friend WithEvents btnPause As Button
    Friend WithEvents picView As PictureBox

End Class
