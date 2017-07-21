Public Class frmSearchPaths

    Dim oMediaSearch As MediaSearch

    Public Sub New(oSetMediaSearch As MediaSearch)

        ' This call is required by the designer.
        InitializeComponent()

        oMediaSearch = oSetMediaSearch
        createPaths()
        refreshForm()
        Me.Hide()

    End Sub

    'Public routines
    Public Sub showForm(Optional bRefresh As Boolean = True)
        If bRefresh Then
            refreshForm()
        End If

        Me.Show()
    End Sub

    Public Sub refreshForm()
        Dim sPaths(oMediaSearch.getConstants.getAvailablePaths) As SearchPath

        sPaths = oMediaSearch.getPaths
        pathsToForm(sPaths)

    End Sub

    'Button routines
    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Hide()
    End Sub

    'Private routines
    Private Sub createPaths()
        Dim sPaths(oMediaSearch.getConstants.getAvailablePaths) As SearchPath
        Dim iLoop As Integer

        For iLoop = 0 To oMediaSearch.getConstants.getAvailablePaths - 1
            sPaths(iLoop) = New SearchPath
        Next

        oMediaSearch.setPathArray(sPaths)

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim sPaths(oMediaSearch.getConstants.getAvailablePaths) As SearchPath

        sPaths = oMediaSearch.getPaths
        formToPaths(sPaths)

        oMediaSearch.setPathArray(sPaths)

        writeDataToReg(sPaths)

        Me.Hide()

    End Sub

    Private Sub writeDataToReg(sPaths() As SearchPath)

        My.Computer.Registry.CurrentUser.CreateSubKey("MediaSearch")
        ' Change MyTestKeyValue to This is a test value. 
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Path0", sPaths(0).getPath)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Inc0", sPaths(0).getInclude)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Path1", sPaths(1).getPath)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Inc1", sPaths(1).getInclude)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Path2", sPaths(2).getPath)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Inc2", sPaths(2).getInclude)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Path3", sPaths(3).getPath)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Inc3", sPaths(3).getInclude)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Path4", sPaths(4).getPath)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Inc4", sPaths(4).getInclude)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Path5", sPaths(5).getPath)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Inc5", sPaths(5).getInclude)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Path6", sPaths(6).getPath)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Inc6", sPaths(6).getInclude)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Path7", sPaths(7).getPath)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Inc7", sPaths(7).getInclude)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Path8", sPaths(8).getPath)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Inc8", sPaths(8).getInclude)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Path9", sPaths(9).getPath)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Inc9", sPaths(9).getInclude)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Path10", sPaths(10).getPath)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Inc10", sPaths(10).getInclude)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Path11", sPaths(11).getPath)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Inc11", sPaths(11).getInclude)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Path12", sPaths(12).getPath)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Inc12", sPaths(12).getInclude)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Path13", sPaths(13).getPath)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Inc13", sPaths(13).getInclude)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Path14", sPaths(14).getPath)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Inc14", sPaths(14).getInclude)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Path15", sPaths(15).getPath)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Inc15", sPaths(15).getInclude)

    End Sub

    Private Sub formToPaths(sPaths() As SearchPath)
        sPaths(0).setPath(txtPath1.Text)
        sPaths(0).setInclude(cbInclude1.Checked)
        sPaths(1).setPath(txtPath2.Text)
        sPaths(1).setInclude(cbInclude2.Checked)
        sPaths(2).setPath(txtPath3.Text)
        sPaths(2).setInclude(cbInclude3.Checked)
        sPaths(3).setPath(txtPath4.Text)
        sPaths(3).setInclude(cbInclude4.Checked)
        sPaths(4).setPath(txtPath5.Text)
        sPaths(4).setInclude(cbInclude5.Checked)
        sPaths(5).setPath(txtPath6.Text)
        sPaths(5).setInclude(cbInclude6.Checked)
        sPaths(6).setPath(txtPath7.Text)
        sPaths(6).setInclude(cbInclude7.Checked)
        sPaths(7).setPath(txtPath8.Text)
        sPaths(7).setInclude(cbInclude8.Checked)
        sPaths(8).setPath(txtPath9.Text)
        sPaths(8).setInclude(cbInclude9.Checked)
        sPaths(9).setPath(txtPath10.Text)
        sPaths(9).setInclude(cbInclude10.Checked)
        sPaths(10).setPath(txtPath11.Text)
        sPaths(10).setInclude(cbInclude11.Checked)
        sPaths(11).setPath(txtPath12.Text)
        sPaths(11).setInclude(cbInclude12.Checked)
        sPaths(12).setPath(txtPath13.Text)
        sPaths(12).setInclude(cbInclude13.Checked)
        sPaths(13).setPath(txtPath14.Text)
        sPaths(13).setInclude(cbInclude14.Checked)
        sPaths(14).setPath(txtPath15.Text)
        sPaths(14).setInclude(cbInclude15.Checked)
        sPaths(15).setPath(txtPath16.Text)
        sPaths(15).setInclude(cbInclude16.Checked)
    End Sub

    Private Sub pathsToForm(sPaths() As SearchPath)
        txtPath1.Text = sPaths(0).getPath
        cbInclude1.Checked = sPaths(0).getInclude
        txtPath2.Text = sPaths(1).getPath
        cbInclude2.Checked = sPaths(1).getInclude
        txtPath3.Text = sPaths(2).getPath
        cbInclude3.Checked = sPaths(2).getInclude
        txtPath4.Text = sPaths(3).getPath
        cbInclude4.Checked = sPaths(3).getInclude
        txtPath5.Text = sPaths(4).getPath
        cbInclude5.Checked = sPaths(4).getInclude
        txtPath6.Text = sPaths(5).getPath
        cbInclude6.Checked = sPaths(5).getInclude
        txtPath7.Text = sPaths(6).getPath
        cbInclude7.Checked = sPaths(6).getInclude
        txtPath8.Text = sPaths(7).getPath
        cbInclude8.Checked = sPaths(7).getInclude
        txtPath9.Text = sPaths(8).getPath
        cbInclude9.Checked = sPaths(8).getInclude
        txtPath10.Text = sPaths(9).getPath
        cbInclude10.Checked = sPaths(9).getInclude
        txtPath11.Text = sPaths(10).getPath
        cbInclude11.Checked = sPaths(10).getInclude
        txtPath12.Text = sPaths(11).getPath
        cbInclude12.Checked = sPaths(11).getInclude
        txtPath13.Text = sPaths(12).getPath
        cbInclude13.Checked = sPaths(12).getInclude
        txtPath14.Text = sPaths(13).getPath
        cbInclude14.Checked = sPaths(13).getInclude
        txtPath15.Text = sPaths(14).getPath
        cbInclude15.Checked = sPaths(14).getInclude
        txtPath16.Text = sPaths(15).getPath
        cbInclude16.Checked = sPaths(15).getInclude
    End Sub

End Class