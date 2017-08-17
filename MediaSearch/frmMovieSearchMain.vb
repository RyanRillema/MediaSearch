Public Class frmMovieSearchMain

    Private oMediaSearch As MediaSearch

    Private Sub MovieFerretMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        oMediaSearch = New MediaSearch()
        oMediaSearch.startThread()

    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click

        Dim sPaths(oMediaSearch.getConstants.getAvailablePaths) As SearchPath
        sPaths = oMediaSearch.getPaths()

        oMediaSearch.getTrdSearch.search(sPaths, txtSearchValue.Text)
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Dim oImportMediaArray(oMediaSearch.getConstants.getImportArraySize) As Media
        Dim iLoop, iCount As Integer

        lbSearchResults.Items.Clear()
        iCount = oMediaSearch.getImportMediaCount
        oImportMediaArray = oMediaSearch.getImportArray
        lbSearchResults.Items.Add(iCount & " items found")

        Try
            For iLoop = 0 To iCount - 1
                lbSearchResults.Items.Add(oImportMediaArray(iLoop).sFormattedName)
            Next
        Catch ex As Exception
            lbSearchResults.Items.Clear()
            lbSearchResults.Items.Add("Still searching...")
            lbSearchResults.Items.Add(iCount & " items found so far")
        End Try

    End Sub

    Private Sub cmdClearReg_Click(sender As Object, e As EventArgs) Handles cmdClearReg.Click
        oMediaSearch.clearRegistryDetails()
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSearchPaths_Click(sender As Object, e As EventArgs) Handles cmdSearchPaths.Click
        oMediaSearch.reloadParams(True)
        oMediaSearch.getFrmPaths.showForm()
    End Sub

    Private Sub cmdParams_Click(sender As Object, e As EventArgs) Handles cmdParams.Click
        oMediaSearch.getFrmParams.showForm()
    End Sub

    Private Sub lbSearchResults_DoubleClick(sender As Object, e As EventArgs) Handles lbSearchResults.DoubleClick
        Dim frmMediaInfo As frmMediaInfo

        frmMediaInfo = oMediaSearch.getFrmMediaInfo

        'Set the media item somehow? and validate

        frmMediaInfo.showForm()

    End Sub

End Class
