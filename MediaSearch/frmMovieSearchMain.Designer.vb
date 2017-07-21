<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovieSearchMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovieSearchMain))
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpLeft = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpControls = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdSearchPaths = New System.Windows.Forms.Button()
        Me.cmdParams = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdExit1 = New System.Windows.Forms.Button()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cmdParams1 = New System.Windows.Forms.Button()
        Me.cmdSearchPaths1 = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdClearReg = New System.Windows.Forms.Button()
        Me.txtSearchValue = New System.Windows.Forms.TextBox()
        Me.tlpAbout = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpLogo = New System.Windows.Forms.TableLayoutPanel()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.tlpAboutDetails = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lbSearchResults = New System.Windows.Forms.ListBox()
        Me.tlpMain.SuspendLayout()
        Me.tlpLeft.SuspendLayout()
        Me.tlpControls.SuspendLayout()
        Me.tlpButtons.SuspendLayout()
        Me.tlpAbout.SuspendLayout()
        Me.tlpLogo.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpAboutDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 2
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.Controls.Add(Me.tlpLeft, 0, 0)
        Me.tlpMain.Controls.Add(Me.lbSearchResults, 1, 0)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(1)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 1
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Size = New System.Drawing.Size(739, 528)
        Me.tlpMain.TabIndex = 0
        '
        'tlpLeft
        '
        Me.tlpLeft.AutoScroll = True
        Me.tlpLeft.ColumnCount = 1
        Me.tlpLeft.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLeft.Controls.Add(Me.tlpControls, 0, 0)
        Me.tlpLeft.Controls.Add(Me.tlpAbout, 0, 1)
        Me.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLeft.Location = New System.Drawing.Point(1, 1)
        Me.tlpLeft.Margin = New System.Windows.Forms.Padding(1)
        Me.tlpLeft.Name = "tlpLeft"
        Me.tlpLeft.RowCount = 2
        Me.tlpLeft.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 199.0!))
        Me.tlpLeft.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLeft.Size = New System.Drawing.Size(367, 526)
        Me.tlpLeft.TabIndex = 0
        '
        'tlpControls
        '
        Me.tlpControls.ColumnCount = 1
        Me.tlpControls.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpControls.Controls.Add(Me.tlpButtons, 0, 2)
        Me.tlpControls.Controls.Add(Me.txtSearchValue, 0, 0)
        Me.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpControls.Location = New System.Drawing.Point(1, 1)
        Me.tlpControls.Margin = New System.Windows.Forms.Padding(1)
        Me.tlpControls.Name = "tlpControls"
        Me.tlpControls.RowCount = 3
        Me.tlpControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpControls.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148.0!))
        Me.tlpControls.Size = New System.Drawing.Size(365, 197)
        Me.tlpControls.TabIndex = 0
        '
        'tlpButtons
        '
        Me.tlpButtons.ColumnCount = 3
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpButtons.Controls.Add(Me.cmdSearchPaths, 0, 3)
        Me.tlpButtons.Controls.Add(Me.cmdParams, 0, 3)
        Me.tlpButtons.Controls.Add(Me.cmdExit, 0, 3)
        Me.tlpButtons.Controls.Add(Me.cmdExit1, 2, 2)
        Me.tlpButtons.Controls.Add(Me.cmdSearch, 0, 0)
        Me.tlpButtons.Controls.Add(Me.Button3, 2, 0)
        Me.tlpButtons.Controls.Add(Me.Button4, 0, 1)
        Me.tlpButtons.Controls.Add(Me.cmdParams1, 1, 2)
        Me.tlpButtons.Controls.Add(Me.cmdSearchPaths1, 0, 2)
        Me.tlpButtons.Controls.Add(Me.cmdUpdate, 1, 0)
        Me.tlpButtons.Controls.Add(Me.cmdClearReg, 2, 1)
        Me.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpButtons.Location = New System.Drawing.Point(1, 50)
        Me.tlpButtons.Margin = New System.Windows.Forms.Padding(1)
        Me.tlpButtons.Name = "tlpButtons"
        Me.tlpButtons.RowCount = 4
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813!))
        Me.tlpButtons.Size = New System.Drawing.Size(363, 146)
        Me.tlpButtons.TabIndex = 0
        '
        'cmdSearchPaths
        '
        Me.cmdSearchPaths.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdSearchPaths.Location = New System.Drawing.Point(1, 109)
        Me.cmdSearchPaths.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdSearchPaths.Name = "cmdSearchPaths"
        Me.cmdSearchPaths.Size = New System.Drawing.Size(119, 36)
        Me.cmdSearchPaths.TabIndex = 11
        Me.cmdSearchPaths.Text = "Search Paths"
        Me.cmdSearchPaths.UseVisualStyleBackColor = True
        '
        'cmdParams
        '
        Me.cmdParams.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdParams.Location = New System.Drawing.Point(122, 109)
        Me.cmdParams.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdParams.Name = "cmdParams"
        Me.cmdParams.Size = New System.Drawing.Size(119, 36)
        Me.cmdParams.TabIndex = 10
        Me.cmdParams.Text = "Parameters"
        Me.cmdParams.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdExit.Location = New System.Drawing.Point(243, 109)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(119, 36)
        Me.cmdExit.TabIndex = 9
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdExit1
        '
        Me.cmdExit1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdExit1.Enabled = False
        Me.cmdExit1.Location = New System.Drawing.Point(243, 73)
        Me.cmdExit1.Margin = New System.Windows.Forms.Padding(1)
        Me.cmdExit1.Name = "cmdExit1"
        Me.cmdExit1.Size = New System.Drawing.Size(119, 34)
        Me.cmdExit1.TabIndex = 0
        Me.cmdExit1.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdSearch.Location = New System.Drawing.Point(0, 0)
        Me.cmdSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(121, 36)
        Me.cmdSearch.TabIndex = 1
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button3.Location = New System.Drawing.Point(242, 0)
        Me.Button3.Margin = New System.Windows.Forms.Padding(0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(121, 36)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(0, 36)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(121, 36)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Find Online"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cmdParams1
        '
        Me.cmdParams1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdParams1.Enabled = False
        Me.cmdParams1.Location = New System.Drawing.Point(121, 72)
        Me.cmdParams1.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdParams1.Name = "cmdParams1"
        Me.cmdParams1.Size = New System.Drawing.Size(121, 36)
        Me.cmdParams1.TabIndex = 5
        Me.cmdParams1.UseVisualStyleBackColor = True
        '
        'cmdSearchPaths1
        '
        Me.cmdSearchPaths1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdSearchPaths1.Enabled = False
        Me.cmdSearchPaths1.Location = New System.Drawing.Point(0, 72)
        Me.cmdSearchPaths1.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdSearchPaths1.Name = "cmdSearchPaths1"
        Me.cmdSearchPaths1.Size = New System.Drawing.Size(121, 36)
        Me.cmdSearchPaths1.TabIndex = 6
        Me.cmdSearchPaths1.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdUpdate.Location = New System.Drawing.Point(121, 0)
        Me.cmdUpdate.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(121, 36)
        Me.cmdUpdate.TabIndex = 7
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'cmdClearReg
        '
        Me.cmdClearReg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdClearReg.Location = New System.Drawing.Point(242, 36)
        Me.cmdClearReg.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClearReg.Name = "cmdClearReg"
        Me.cmdClearReg.Size = New System.Drawing.Size(121, 36)
        Me.cmdClearReg.TabIndex = 8
        Me.cmdClearReg.Text = "Clear Registry"
        Me.cmdClearReg.UseVisualStyleBackColor = True
        '
        'txtSearchValue
        '
        Me.txtSearchValue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearchValue.Location = New System.Drawing.Point(3, 2)
        Me.txtSearchValue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSearchValue.Name = "txtSearchValue"
        Me.txtSearchValue.Size = New System.Drawing.Size(359, 22)
        Me.txtSearchValue.TabIndex = 1
        '
        'tlpAbout
        '
        Me.tlpAbout.ColumnCount = 1
        Me.tlpAbout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAbout.Controls.Add(Me.tlpLogo, 0, 0)
        Me.tlpAbout.Controls.Add(Me.tlpAboutDetails, 0, 1)
        Me.tlpAbout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpAbout.Location = New System.Drawing.Point(1, 200)
        Me.tlpAbout.Margin = New System.Windows.Forms.Padding(1)
        Me.tlpAbout.Name = "tlpAbout"
        Me.tlpAbout.RowCount = 2
        Me.tlpAbout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpAbout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.tlpAbout.Size = New System.Drawing.Size(365, 325)
        Me.tlpAbout.TabIndex = 1
        '
        'tlpLogo
        '
        Me.tlpLogo.ColumnCount = 1
        Me.tlpLogo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLogo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpLogo.Controls.Add(Me.pbLogo, 0, 0)
        Me.tlpLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLogo.Location = New System.Drawing.Point(0, 0)
        Me.tlpLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpLogo.Name = "tlpLogo"
        Me.tlpLogo.RowCount = 1
        Me.tlpLogo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLogo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 265.0!))
        Me.tlpLogo.Size = New System.Drawing.Size(365, 265)
        Me.tlpLogo.TabIndex = 0
        '
        'pbLogo
        '
        Me.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbLogo.Image = Global.MediaSearch.My.Resources.Resources.MediaSearchLogo
        Me.pbLogo.Location = New System.Drawing.Point(0, 0)
        Me.pbLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(365, 265)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 0
        Me.pbLogo.TabStop = False
        '
        'tlpAboutDetails
        '
        Me.tlpAboutDetails.ColumnCount = 2
        Me.tlpAboutDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpAboutDetails.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpAboutDetails.Controls.Add(Me.Label1, 0, 0)
        Me.tlpAboutDetails.Controls.Add(Me.lblVersion, 1, 1)
        Me.tlpAboutDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpAboutDetails.Location = New System.Drawing.Point(3, 267)
        Me.tlpAboutDetails.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tlpAboutDetails.Name = "tlpAboutDetails"
        Me.tlpAboutDetails.RowCount = 2
        Me.tlpAboutDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpAboutDetails.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpAboutDetails.Size = New System.Drawing.Size(359, 56)
        Me.tlpAboutDetails.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rillema Inc"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVersion.Location = New System.Drawing.Point(182, 28)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(174, 28)
        Me.lblVersion.TabIndex = 1
        Me.lblVersion.Text = "Version 1.0.1"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbSearchResults
        '
        Me.lbSearchResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbSearchResults.FormattingEnabled = True
        Me.lbSearchResults.ItemHeight = 16
        Me.lbSearchResults.Location = New System.Drawing.Point(372, 2)
        Me.lbSearchResults.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbSearchResults.Name = "lbSearchResults"
        Me.lbSearchResults.Size = New System.Drawing.Size(364, 524)
        Me.lbSearchResults.TabIndex = 8
        '
        'frmMovieSearchMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 528)
        Me.Controls.Add(Me.tlpMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMovieSearchMain"
        Me.Text = "Media Search"
        Me.tlpMain.ResumeLayout(False)
        Me.tlpLeft.ResumeLayout(False)
        Me.tlpControls.ResumeLayout(False)
        Me.tlpControls.PerformLayout()
        Me.tlpButtons.ResumeLayout(False)
        Me.tlpAbout.ResumeLayout(False)
        Me.tlpLogo.ResumeLayout(False)
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpAboutDetails.ResumeLayout(False)
        Me.tlpAboutDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents tlpLeft As TableLayoutPanel
    Friend WithEvents tlpControls As TableLayoutPanel
    Friend WithEvents tlpAbout As TableLayoutPanel
    Friend WithEvents tlpButtons As TableLayoutPanel
    Friend WithEvents cmdSearch As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents cmdParams1 As Button
    Friend WithEvents cmdSearchPaths1 As Button
    Friend WithEvents txtSearchValue As TextBox
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents lbSearchResults As ListBox
    Friend WithEvents tlpLogo As TableLayoutPanel
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents tlpAboutDetails As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents cmdClearReg As Button
    Friend WithEvents cmdExit1 As Button
    Friend WithEvents cmdSearchPaths As Button
    Friend WithEvents cmdParams As Button
    Friend WithEvents cmdExit As Button
End Class
