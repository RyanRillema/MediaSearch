Imports System.Threading

Public Class trdMediaSearch

    Private oMediaSearch As MediaSearch
    Private trdFolderReader As Thread
    Private bRunning As Boolean
    Private bWaiting As Boolean
    Private sPath(1) As SearchPath
    Private sSearchText As String
    Private iPathCounter As Integer = 0
    Private oImportMovieArray(1) As Media
    Private iCounter As Integer = 0

    Public Sub New(oSetMovieFerret As MediaSearch)
        oMediaSearch = oSetMovieFerret
        trdFolderReader = New Thread(AddressOf ThreadTask)
        trdFolderReader.IsBackground = True

        ReDim sPath(oMediaSearch.getConstants.getAvailablePaths)
        ReDim oImportMovieArray(oMediaSearch.getConstants.getImportArraySize)
    End Sub

    Public Sub StartThread()
        bRunning = True
        trdFolderReader.Start()
    End Sub

    Public Sub StopThread()
        trdFolderReader.Abort()
        bRunning = False
    End Sub

    Public Function isRunning() As Boolean
        Return bRunning
    End Function

    Public Function search(sPaths() As SearchPath, sSearchString As String) As Boolean
        Dim bReturn As Boolean

        If Not bWaiting Then
            sPath = sPaths
            sSearchText = sSearchString
            bWaiting = True
            bReturn = True
        End If

        Return bReturn
    End Function

    Private Sub ThreadTask()
        Do

            If bWaiting Then
                ReadFolderDetails()
            End If

            Thread.Sleep(10)
        Loop
    End Sub

    Private Function ReadFolderDetails() As Boolean
        Dim bReturn As Boolean
        Dim oTempMedia As New Media
        Dim FoundFile As String
        Dim oFileInfo As IO.FileInfo
        Dim sCurrentPath As String
        Dim bInclude As Boolean

        sCurrentPath = sPath(iPathCounter).getPath
        bInclude = sPath(iPathCounter).getInclude
        sPath(iPathCounter).setPath("")
        iPathCounter = iPathCounter + 1

        If sCurrentPath <> "" And bInclude And iPathCounter < 10 Then

            oMediaSearch.getLogger.writeInfoGeneric("")
            oMediaSearch.getLogger.writeInfoGeneric("Current path: " & sCurrentPath)

            'Blah blah blah
            For Each FoundFile In My.Computer.FileSystem.GetFiles(sCurrentPath, FileIO.SearchOption.SearchAllSubDirectories)

                oMediaSearch.getLogger.writeDetailedGeneric("Current file: " & FoundFile)

                Try
                    oFileInfo = My.Computer.FileSystem.GetFileInfo(FoundFile)
                    oTempMedia = oMediaSearch.getStringHandler.convertImportedMovie(FoundFile, oFileInfo)
                Catch
                    oMediaSearch.getLogger.writeErrorGeneric("Error with file: " & FoundFile)
                End Try

                If validateFile(oTempMedia) And CompareToSearchString(oTempMedia) Then
                    oImportMovieArray(iCounter) = oTempMedia
                    iCounter = iCounter + 1
                    oMediaSearch.incImportMediaCount()
                End If
            Next

        End If

        If iPathCounter > 9 Then

            bWaiting = False
            iPathCounter = 0

            oMediaSearch.setImportArray(oImportMovieArray)

        End If

        Return bReturn

    End Function

    Private Function CompareToSearchString(oMedia As Media) As Boolean
        Dim bReturn As Boolean = True
        Dim sMediaDetail, sTempSearchText As String
        Dim iFound As Integer

        'Check search string
        sMediaDetail = oMedia.sName.ToUpper

        sTempSearchText = sSearchText.ToUpper

        If sSearchText <> "" Then
            iFound = sMediaDetail.IndexOf(sTempSearchText)
        End If

        If iFound = -1 Then
            bReturn = False
        End If

        Return bReturn
    End Function

    Private Function validateFile(oMovie As Media) As Boolean
        Dim bReturn As Boolean = True

        'Check extention
        Select Case oMovie.sExtention
            Case ".avi", ".mkv", ".mp4"
                'Valid

            Case Else
                bReturn = False
        End Select

        Return bReturn
    End Function

End Class