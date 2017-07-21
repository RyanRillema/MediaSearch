Imports System.Threading

Public Class MediaSearch

    Private oConstants As New Constants
    Private frmPaths As frmSearchPaths
    Private frmParams As frmSearchParameters
    Private frmMediaInfo As frmMediaInfo
    Private trdSearch As trdMediaSearch
    Private oStringHandler As TextHandler
    Private oParams As SearchParams
    Private oLogfile As SearchLog
    Private oImportMediaArray(oConstants.getImportArraySize) As Media
    Private iImportMediaCount As Integer
    Private oPath(oConstants.getAvailablePaths) As SearchPath

    Public Sub New()
        frmPaths = New frmSearchPaths(Me)
        frmMediaInfo = New frmMediaInfo(Me)
        trdSearch = New trdMediaSearch(Me)
        oStringHandler = New TextHandler(Me)
        oParams = New SearchParams()
        frmParams = New frmSearchParameters(Me)
        oLogfile = New SearchLog(Me)

        loadData()

        'removeRegDetails()
    End Sub

    'Import publics
    Public Sub incImportMediaCount()
        iImportMediaCount = iImportMediaCount + 1
    End Sub
    Public Sub reloadParams(Optional bLoadPaths As Boolean = False)
        loadData()
    End Sub

    'General Publics
    Public Sub startThread()
        trdSearch.StartThread()
    End Sub
    Public Sub clearRegistryDetails()
        removeRegDetails()
    End Sub

    'General privates
    Private Sub loadData()

        Dim readValue
        Dim iLoop As Integer

        For iLoop = 0 To oConstants.getAvailablePaths - 1

            readValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Path" & iLoop, Nothing)
            oPath(iLoop).setPath(readValue)
            readValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "Inc" & iLoop, Nothing)
            oPath(iLoop).setInclude(readValue)

        Next

    End Sub

    Private Sub removeRegDetails()
        My.Computer.Registry.CurrentUser.DeleteSubKey("MediaSearch")
    End Sub

    'Sets
    Public Sub setImportArray(oSetArray() As Media)
        oImportMediaArray = oSetArray
    End Sub
    Public Sub setPathArray(oSetPaths() As SearchPath)
        oPath = oSetPaths
    End Sub

    'Gets
    Public Function getFrmPaths() As frmSearchPaths
        Return frmPaths
    End Function
    Public Function getFrmParams() As frmSearchParameters
        Return frmParams
    End Function
    Public Function getFrmMediaInfo() As frmMediaInfo
        Return frmMediaInfo
    End Function
    Public Function getTrdSearch() As trdMediaSearch
        Return trdSearch
    End Function
    Public Function getStringHandler() As TextHandler
        Return oStringHandler
    End Function
    Public Function getParams() As SearchParams
        Return oParams
    End Function
    Public Function getLogger() As SearchLog
        Return oLogfile
    End Function
    Public Function getImportArray() As Media()
        Return oImportMediaArray
    End Function
    Public Function getImportMediaCount() As Integer
        Return iImportMediaCount
    End Function
    Public Function getPaths() As SearchPath()
        Return oPath
    End Function
    Public Function getConstants() As Constants
        Return oConstants
    End Function
End Class