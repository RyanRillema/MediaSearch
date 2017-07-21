Public Class frmSearchParameters
    Private oMediaSearch As MediaSearch
    Private oParams As SearchParams

    Public Sub New(oSetMediaSearch As MediaSearch)

        ' This call is required by the designer.
        InitializeComponent()

        oMediaSearch = oSetMediaSearch
        oParams = oMediaSearch.getParams
        Me.Hide()

    End Sub

    'Public routines
    Public Sub showForm(Optional bRefresh As Boolean = True)
        oParams.loadParams()
        paramsToFrom()
        Me.Show()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sPaths(oMediaSearch.getConstants.getAvailablePaths) As SearchPath

        formToParams()
        oParams.writeToReg()

        Me.Hide()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Hide()
    End Sub

    'Private form subs
    Private Sub formToParams()
        oParams.setLogEnabled(cbEnableLog.Checked)
        oParams.setLogPath(tbLogPath.Text)
        oParams.setDetailed(cbDetailed.Checked)
        oParams.setInfo(cbInfo.Checked)
        oParams.setWarning(cbWarning.Checked)
        oParams.setError(cbError.Checked)
    End Sub
    Private Sub paramsToFrom()
        cbEnableLog.Checked = oParams.getLogEnabled
        tbLogPath.Text = oParams.getLogPath
        cbDetailed.Checked = oParams.getDetailed
        cbInfo.Checked = oParams.getInfo
        cbWarning.Checked = oParams.getWarning
        cbError.Checked = oParams.getError

    End Sub
End Class