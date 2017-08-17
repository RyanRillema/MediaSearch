<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMediaInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMediaInfo))
        Me.tlpInfoMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpTop = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpButtons = New System.Windows.Forms.TableLayoutPanel()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.tlpInfoMain.SuspendLayout()
        Me.tlpTop.SuspendLayout()
        Me.tlpButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpInfoMain
        '
        Me.tlpInfoMain.ColumnCount = 1
        Me.tlpInfoMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpInfoMain.Controls.Add(Me.tlpTop, 0, 0)
        Me.tlpInfoMain.Controls.Add(Me.tlpButtons, 0, 1)
        Me.tlpInfoMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpInfoMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpInfoMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpInfoMain.Name = "tlpInfoMain"
        Me.tlpInfoMain.RowCount = 2
        Me.tlpInfoMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpInfoMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpInfoMain.Size = New System.Drawing.Size(573, 446)
        Me.tlpInfoMain.TabIndex = 1
        '
        'tlpTop
        '
        Me.tlpTop.ColumnCount = 2
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTop.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpTop.Controls.Add(Me.tlpMain, 0, 0)
        Me.tlpTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTop.Location = New System.Drawing.Point(0, 0)
        Me.tlpTop.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpTop.Name = "tlpTop"
        Me.tlpTop.RowCount = 1
        Me.tlpTop.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTop.Size = New System.Drawing.Size(573, 396)
        Me.tlpTop.TabIndex = 0
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 4
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMain.Size = New System.Drawing.Size(553, 396)
        Me.tlpMain.TabIndex = 0
        '
        'tlpButtons
        '
        Me.tlpButtons.ColumnCount = 4
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpButtons.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlpButtons.Controls.Add(Me.cmdClose, 3, 0)
        Me.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpButtons.Location = New System.Drawing.Point(0, 396)
        Me.tlpButtons.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpButtons.Name = "tlpButtons"
        Me.tlpButtons.RowCount = 1
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpButtons.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpButtons.Size = New System.Drawing.Size(573, 50)
        Me.tlpButtons.TabIndex = 1
        '
        'cmdClose
        '
        Me.cmdClose.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmdClose.Location = New System.Drawing.Point(429, 0)
        Me.cmdClose.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(144, 50)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'frmMediaInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 446)
        Me.Controls.Add(Me.tlpInfoMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmMediaInfo"
        Me.Text = "frmMediaInfo"
        Me.tlpInfoMain.ResumeLayout(False)
        Me.tlpTop.ResumeLayout(False)
        Me.tlpButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpInfoMain As TableLayoutPanel
    Friend WithEvents tlpTop As TableLayoutPanel
    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents tlpButtons As TableLayoutPanel
    Friend WithEvents cmdClose As Button
End Class
