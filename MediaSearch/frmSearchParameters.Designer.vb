<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchParameters
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchParameters))
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.tlpTop = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpFileTypes = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpIncExcMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpIncExcDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpLogMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpLoggerTop = New System.Windows.Forms.TableLayoutPanel()
        Me.cbEnableLog = New System.Windows.Forms.CheckBox()
        Me.tbLogPath = New System.Windows.Forms.TextBox()
        Me.tlpLoggerBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpLogLevels = New System.Windows.Forms.TableLayoutPanel()
        Me.cbDetailed = New System.Windows.Forms.CheckBox()
        Me.cbError = New System.Windows.Forms.CheckBox()
        Me.cbWarning = New System.Windows.Forms.CheckBox()
        Me.cbInfo = New System.Windows.Forms.CheckBox()
        Me.tlpBottom = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpMain.SuspendLayout()
        Me.tlpButtons.SuspendLayout()
        Me.tlpTop.SuspendLayout()
        Me.tlpFileTypes.SuspendLayout()
        Me.tlpIncExcMain.SuspendLayout()
        Me.tlpLogMain.SuspendLayout()
        Me.tlpLoggerTop.SuspendLayout()
        Me.tlpLoggerBottom.SuspendLayout()
        Me.tlpLogLevels.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.tlpButtons, 0, 2)
        Me.tlpMain.Controls.Add(Me.tlpTop, 0, 0)
        Me.tlpMain.Controls.Add(Me.tlpBottom, 0, 1)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 3
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.tlpMain.Size = New System.Drawing.Size(763, 551)
        Me.tlpMain.TabIndex = 0
        '
        'tlpButtons
        '
        Me.tlpButtons.ColumnCount = 5
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.00049!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0005!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0005!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.9985!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpButtons.Controls.Add(Me.cmdSave, 0, 0)
        Me.tlpButtons.Controls.Add(Me.cmdClose, 4, 0)
        Me.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpButtons.Location = New System.Drawing.Point(4, 492)
        Me.tlpButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpButtons.Name = "tlpButtons"
        Me.tlpButtons.RowCount = 1
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpButtons.Size = New System.Drawing.Size(755, 55)
        Me.tlpButtons.TabIndex = 3
        '
        'cmdSave
        '
        Me.cmdSave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdSave.Location = New System.Drawing.Point(0, 0)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(151, 55)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdClose.Location = New System.Drawing.Point(603, 0)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(152, 55)
        Me.cmdClose.TabIndex = 2
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'tlpTop
        '
        Me.tlpTop.ColumnCount = 2
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.Controls.Add(Me.tlpFileTypes, 0, 0)
        Me.tlpTop.Controls.Add(Me.tlpLogMain, 1, 0)
        Me.tlpTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTop.Location = New System.Drawing.Point(0, 0)
        Me.tlpTop.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpTop.Name = "tlpTop"
        Me.tlpTop.RowCount = 1
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpTop.Size = New System.Drawing.Size(763, 244)
        Me.tlpTop.TabIndex = 0
        '
        'tlpFileTypes
        '
        Me.tlpFileTypes.ColumnCount = 2
        Me.tlpFileTypes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpFileTypes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpFileTypes.Controls.Add(Me.tlpIncExcMain, 0, 0)
        Me.tlpFileTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFileTypes.Location = New System.Drawing.Point(0, 0)
        Me.tlpFileTypes.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpFileTypes.Name = "tlpFileTypes"
        Me.tlpFileTypes.RowCount = 1
        Me.tlpFileTypes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpFileTypes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpFileTypes.Size = New System.Drawing.Size(381, 244)
        Me.tlpFileTypes.TabIndex = 0
        '
        'tlpIncExcMain
        '
        Me.tlpIncExcMain.ColumnCount = 1
        Me.tlpIncExcMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpIncExcMain.Controls.Add(Me.tlpIncExcDetails, 0, 1)
        Me.tlpIncExcMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpIncExcMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpIncExcMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpIncExcMain.Name = "tlpIncExcMain"
        Me.tlpIncExcMain.RowCount = 2
        Me.tlpIncExcMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tlpIncExcMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpIncExcMain.Size = New System.Drawing.Size(190, 244)
        Me.tlpIncExcMain.TabIndex = 0
        '
        'tlpIncExcDetails
        '
        Me.tlpIncExcDetails.ColumnCount = 2
        Me.tlpIncExcDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpIncExcDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpIncExcDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpIncExcDetails.Location = New System.Drawing.Point(0, 37)
        Me.tlpIncExcDetails.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpIncExcDetails.Name = "tlpIncExcDetails"
        Me.tlpIncExcDetails.RowCount = 8
        Me.tlpIncExcDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tlpIncExcDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tlpIncExcDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tlpIncExcDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tlpIncExcDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tlpIncExcDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tlpIncExcDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.tlpIncExcDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpIncExcDetails.Size = New System.Drawing.Size(190, 207)
        Me.tlpIncExcDetails.TabIndex = 0
        '
        'tlpLogMain
        '
        Me.tlpLogMain.ColumnCount = 1
        Me.tlpLogMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLogMain.Controls.Add(Me.tlpLoggerTop, 0, 0)
        Me.tlpLogMain.Controls.Add(Me.tlpLoggerBottom, 0, 1)
        Me.tlpLogMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLogMain.Location = New System.Drawing.Point(381, 0)
        Me.tlpLogMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpLogMain.Name = "tlpLogMain"
        Me.tlpLogMain.RowCount = 2
        Me.tlpLogMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74.0!))
        Me.tlpLogMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLogMain.Size = New System.Drawing.Size(382, 244)
        Me.tlpLogMain.TabIndex = 1
        '
        'tlpLoggerTop
        '
        Me.tlpLoggerTop.ColumnCount = 2
        Me.tlpLoggerTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpLoggerTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpLoggerTop.Controls.Add(Me.cbEnableLog, 0, 0)
        Me.tlpLoggerTop.Controls.Add(Me.tbLogPath, 0, 1)
        Me.tlpLoggerTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLoggerTop.Location = New System.Drawing.Point(0, 0)
        Me.tlpLoggerTop.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpLoggerTop.Name = "tlpLoggerTop"
        Me.tlpLoggerTop.RowCount = 2
        Me.tlpLoggerTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpLoggerTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpLoggerTop.Size = New System.Drawing.Size(382, 74)
        Me.tlpLoggerTop.TabIndex = 0
        '
        'cbEnableLog
        '
        Me.cbEnableLog.AutoSize = True
        Me.cbEnableLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbEnableLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEnableLog.Location = New System.Drawing.Point(0, 0)
        Me.cbEnableLog.Margin = New System.Windows.Forms.Padding(0)
        Me.cbEnableLog.Name = "cbEnableLog"
        Me.cbEnableLog.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbEnableLog.Size = New System.Drawing.Size(191, 37)
        Me.cbEnableLog.TabIndex = 0
        Me.cbEnableLog.Text = "Enable Logging"
        Me.cbEnableLog.UseVisualStyleBackColor = True
        '
        'tbLogPath
        '
        Me.tbLogPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbLogPath.Location = New System.Drawing.Point(3, 39)
        Me.tbLogPath.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbLogPath.Name = "tbLogPath"
        Me.tbLogPath.Size = New System.Drawing.Size(185, 22)
        Me.tbLogPath.TabIndex = 1
        Me.tbLogPath.Text = "C:/FTPTemp"
        '
        'tlpLoggerBottom
        '
        Me.tlpLoggerBottom.ColumnCount = 2
        Me.tlpLoggerBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpLoggerBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpLoggerBottom.Controls.Add(Me.tlpLogLevels, 0, 0)
        Me.tlpLoggerBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLoggerBottom.Location = New System.Drawing.Point(0, 74)
        Me.tlpLoggerBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpLoggerBottom.Name = "tlpLoggerBottom"
        Me.tlpLoggerBottom.RowCount = 1
        Me.tlpLoggerBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpLoggerBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpLoggerBottom.Size = New System.Drawing.Size(382, 170)
        Me.tlpLoggerBottom.TabIndex = 1
        '
        'tlpLogLevels
        '
        Me.tlpLogLevels.ColumnCount = 2
        Me.tlpLogLevels.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlpLogLevels.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLogLevels.Controls.Add(Me.cbDetailed, 1, 0)
        Me.tlpLogLevels.Controls.Add(Me.cbError, 1, 3)
        Me.tlpLogLevels.Controls.Add(Me.cbWarning, 1, 2)
        Me.tlpLogLevels.Controls.Add(Me.cbInfo, 1, 1)
        Me.tlpLogLevels.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLogLevels.Location = New System.Drawing.Point(0, 0)
        Me.tlpLogLevels.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpLogLevels.Name = "tlpLogLevels"
        Me.tlpLogLevels.RowCount = 5
        Me.tlpLogLevels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpLogLevels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpLogLevels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpLogLevels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpLogLevels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLogLevels.Size = New System.Drawing.Size(191, 170)
        Me.tlpLogLevels.TabIndex = 0
        '
        'cbDetailed
        '
        Me.cbDetailed.AutoSize = True
        Me.cbDetailed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbDetailed.Location = New System.Drawing.Point(13, 3)
        Me.cbDetailed.Name = "cbDetailed"
        Me.cbDetailed.Size = New System.Drawing.Size(175, 24)
        Me.cbDetailed.TabIndex = 7
        Me.cbDetailed.Text = "Detailed"
        Me.cbDetailed.UseVisualStyleBackColor = True
        '
        'cbError
        '
        Me.cbError.AutoSize = True
        Me.cbError.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbError.Location = New System.Drawing.Point(13, 93)
        Me.cbError.Name = "cbError"
        Me.cbError.Size = New System.Drawing.Size(175, 24)
        Me.cbError.TabIndex = 5
        Me.cbError.Text = "Error"
        Me.cbError.UseVisualStyleBackColor = True
        '
        'cbWarning
        '
        Me.cbWarning.AutoSize = True
        Me.cbWarning.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbWarning.Location = New System.Drawing.Point(13, 63)
        Me.cbWarning.Name = "cbWarning"
        Me.cbWarning.Size = New System.Drawing.Size(175, 24)
        Me.cbWarning.TabIndex = 3
        Me.cbWarning.Text = "Warning"
        Me.cbWarning.UseVisualStyleBackColor = True
        '
        'cbInfo
        '
        Me.cbInfo.AutoSize = True
        Me.cbInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbInfo.Location = New System.Drawing.Point(13, 33)
        Me.cbInfo.Name = "cbInfo"
        Me.cbInfo.Size = New System.Drawing.Size(175, 24)
        Me.cbInfo.TabIndex = 0
        Me.cbInfo.Text = "Info"
        Me.cbInfo.UseVisualStyleBackColor = True
        '
        'tlpBottom
        '
        Me.tlpBottom.ColumnCount = 2
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBottom.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBottom.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpBottom.Location = New System.Drawing.Point(0, 244)
        Me.tlpBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpBottom.Name = "tlpBottom"
        Me.tlpBottom.RowCount = 1
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBottom.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpBottom.Size = New System.Drawing.Size(763, 244)
        Me.tlpBottom.TabIndex = 1
        '
        'frmSearchParameters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 551)
        Me.Controls.Add(Me.tlpMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSearchParameters"
        Me.Text = "frmSearchParameters"
        Me.tlpMain.ResumeLayout(False)
        Me.tlpButtons.ResumeLayout(False)
        Me.tlpTop.ResumeLayout(False)
        Me.tlpFileTypes.ResumeLayout(False)
        Me.tlpIncExcMain.ResumeLayout(False)
        Me.tlpLogMain.ResumeLayout(False)
        Me.tlpLoggerTop.ResumeLayout(False)
        Me.tlpLoggerTop.PerformLayout()
        Me.tlpLoggerBottom.ResumeLayout(False)
        Me.tlpLogLevels.ResumeLayout(False)
        Me.tlpLogLevels.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents tlpTop As TableLayoutPanel
    Friend WithEvents tlpFileTypes As TableLayoutPanel
    Friend WithEvents tlpIncExcMain As TableLayoutPanel
    Friend WithEvents tlpIncExcDetails As TableLayoutPanel
    Friend WithEvents tlpLogMain As TableLayoutPanel
    Friend WithEvents tlpLoggerTop As TableLayoutPanel
    Friend WithEvents cbEnableLog As CheckBox
    Friend WithEvents tlpBottom As TableLayoutPanel
    Friend WithEvents tlpButtons As TableLayoutPanel
    Friend WithEvents cmdSave As Button
    Friend WithEvents cmdClose As Button
    Friend WithEvents tbLogPath As TextBox
    Friend WithEvents tlpLoggerBottom As TableLayoutPanel
    Friend WithEvents tlpLogLevels As TableLayoutPanel
    Friend WithEvents cbError As CheckBox
    Friend WithEvents cbWarning As CheckBox
    Friend WithEvents cbInfo As CheckBox
    Friend WithEvents cbDetailed As CheckBox
End Class
