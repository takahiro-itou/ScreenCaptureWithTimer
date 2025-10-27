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
        mnuRunCommand = New ToolStripMenuItem()

        tmrDisk = New Timer(components)
        dlgSave = New SaveFileDialog()

        Label1 = New Label()
        txtCommand = New TextBox()
        btnRun = New Button()
        txtOutput = New TextBox()

        mnuMain.SuspendLayout()
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
        mnuRun.DropDownItems.AddRange(New ToolStripItem() {mnuRunCommand})
        mnuRun.Name = "mnuRun"
        '
        ' mnuRunCommand
        '
        resources.ApplyResources(mnuRunCommand, "mnuRunCommand")
        mnuRunCommand.Name = "mnuRunCommand"

        '
        ' tmrDisk
        '
        resources.ApplyResources(tmrDisk, "tmrDisk")
        tmrDisk.Interval = 60000

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
        ' txtCommand
        '
        resources.ApplyResources(txtCommand, "txtCommand")
        txtCommand.Name = "txtCommand"
        '
        ' btnRun
        '
        resources.ApplyResources(btnRun, "btnRun")
        btnRun.Name = "btnRun"
        btnRun.UseVisualStyleBackColor = True
        '
        ' txtOutput
        '
        resources.ApplyResources(txtOutput, "txtOutput")
        txtOutput.Name = "txtOutput"
        txtOutput.BackColor = SystemColors.Window
        txtOutput.ReadOnly = True

        '
        ' MainView
        '
        resources.ApplyResources(Me, "$this")
        AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(mnuMain)
        Me.Controls.Add(Label1)
        Me.Controls.Add(txtCommand)
        Me.Controls.Add(btnRun)
        Me.Controls.Add(txtOutput)
        Me.MainMenuStrip = mnuMain
        Me.Name = "MainView"

        mnuMain.ResumeLayout(False)
        mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuRun As ToolStripMenuItem
    Friend WithEvents mnuRunCommand As ToolStripMenuItem

    Friend WithEvents tmrDisk As Timer
    Friend WithEvents dlgSave As SaveFileDialog

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCommand As TextBox
    Friend WithEvents btnRun As Button
    Friend WithEvents txtOutput As TextBox

End Class
