<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainView
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

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

        grpControl = New GroupBox()
        txbWnd = New WinFormsControl.TextBoxWithButton()
        btnDesktop = New Button()
        btnWndOK = New Button()
        txbOutput = New WinFormsControl.TextBoxWithButton()
        label1 = New Label()
        updInterval = New NumericUpDown()
        txbRect = New WinFormsControl.TextBoxWithButton()

        btnRun = New Button()
        btnPause = New Button()
        picView = New PictureBox()

        mnuMain.SuspendLayout()
        grpControl.SuspendLayout()
        CType(updInterval, ComponentModel.ISupportInitialize).BeginInit()
        CType(picView, ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '
        ' mnuMain
        '
        mnuMain.Items.AddRange(New ToolStripItem() {mnuFile, mnuRun})
        resources.ApplyResources(mnuMain, "mnuMain")
        mnuMain.Name = "mnuMain"
        '
        ' mnuFile
        '
        mnuFile.DropDownItems.AddRange(New ToolStripItem() {mnuFileExit})
        mnuFile.Name = "mnuFile"
        resources.ApplyResources(mnuFile, "mnuFile")
        '
        ' mnuFileExit
        '
        mnuFileExit.Name = "mnuFileExit"
        resources.ApplyResources(mnuFileExit, "mnuFileExit")
        '
        ' mnuRun
        '
        mnuRun.DropDownItems.AddRange(New ToolStripItem() {mnuRunStart, mnuRunPause})
        mnuRun.Name = "mnuRun"
        resources.ApplyResources(mnuRun, "mnuRun")
        '
        ' mnuRunStart
        '
        mnuRunStart.Name = "mnuRunStart"
        resources.ApplyResources(mnuRunStart, "mnuRunStart")
        '
        ' mnuRunPause
        '
        mnuRunPause.Name = "mnuRunPause"
        resources.ApplyResources(mnuRunPause, "mnuRunPause")

        '
        ' tmrSnap
        '
        resources.ApplyResources(tmrSnap, "tmrSnap")
        tmrSnap.Interval = 2000

        '
        ' dlgSave
        '
        resources.ApplyResources(dlgSave, "dlgSave")
        dlgSave.FileName = "dlgSave"

        '
        ' grpControl
        '
        resources.ApplyResources(grpControl, "grpControl")
        grpControl.Controls.Add(txbWnd)
        grpControl.Controls.Add(btnDesktop)
        grpControl.Controls.Add(btnWndOK)
        grpControl.Controls.Add(txbOutput)
        grpControl.Controls.Add(label1)
        grpControl.Controls.Add(updInterval)
        grpControl.Controls.Add(txbRect)
        grpControl.Controls.Add(btnRun)
        grpControl.Controls.Add(btnPause)
        grpControl.Name = "grpControl"
        grpControl.TabStop = False

        '
        ' updInterval
        '
        resources.ApplyResources(updInterval, "updInterval")
        updInterval.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        updInterval.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        updInterval.Name = "updInterval"
        updInterval.Value = New Decimal(New Integer() {2000, 0, 0, 0})

        '
        ' txbWnd
        '
        resources.ApplyResources(txbWnd, "txbWnd")
        txbWnd.ButtonText = "..."
        txbWnd.LabelCaption = "&HWND:"
        txbWnd.Name = "txbWnd"

        '
        ' txbOutput
        '
        resources.ApplyResources(txbOutput, "txbOutput")
        txbOutput.ButtonText = "..."
        txbOutput.LabelCaption = "&Output:"
        txbOutput.Name = "txbOutput"

        '
        ' label1
        '
        resources.ApplyResources(label1, "label1")
        label1.Name = "label1"

        '
        ' txbRect
        '
        resources.ApplyResources(txbRect, "txbRect")
        txbRect.ButtonText = "..."
        txbRect.LabelCaption = "Src Rect:"
        txbRect.Name = "txbRect"

        '
        ' btnRun
        '
        resources.ApplyResources(btnRun, "btnRun")
        btnRun.Name = "btnRun"
        btnRun.UseVisualStyleBackColor = True
        '
        ' btnPause
        '
        resources.ApplyResources(btnPause, "btnPause")
        btnPause.Name = "btnPause"
        btnPause.UseVisualStyleBackColor = True

        '
        ' picView
        '
        resources.ApplyResources(picView, "picView")
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
        Me.Controls.Add(grpControl)
        Me.Controls.Add(picView)
        Me.MainMenuStrip = mnuMain
        Me.Name = "MainView"

        mnuMain.ResumeLayout(False)
        mnuMain.PerformLayout()
        grpControl.ResumeLayout(False)
        CType(updInterval, ComponentModel.ISupportInitialize).EndInit()
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

    Friend WithEvents grpControl As GroupBox
    Friend WithEvents txbWnd As WinFormsControl.TextBoxWithButton
    Friend WithEvents btnDesktop As Button
    Friend WithEvents btnWndOK As Button
    Friend WithEvents txbOutput As WinFormsControl.TextBoxWithButton
    Friend WithEvents label1 As Label
    Friend WithEvents updInterval As NumericUpDown
    Friend WithEvents txbRect As WinFormsControl.TextBoxWithButton
    Friend WithEvents btnRun As Button
    Friend WithEvents btnPause As Button

    Friend WithEvents picView As PictureBox

End Class
