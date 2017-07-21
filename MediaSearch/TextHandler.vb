Public Class TextHandler
    Public oMovieSearch As MediaSearch

    Public Sub New(oSetMovieFerret As MediaSearch)
        oMovieSearch = oSetMovieFerret
    End Sub

    Public Function convertImportedMovie(sRawRead As String, oFileInfo As IO.FileInfo) As Media
        Dim oMovie As Media
        Dim sFileName As String
        Dim sExtention As String = ""
        Dim iYear As Integer = 0

        oMovie = New Media()

        oMovie.sRawRead = sRawRead

        If oMovie.sRawRead <> "" Then
            'Process movie read
            'sFileName = StripFileName(oMovie.sRawRead)
            sFileName = oFileInfo.Name
            sFileName = StripKnownTypes(sFileName, sExtention)

            oMovie.sName = oFileInfo.Name
            'oMovie.sFormattedName = sFileName
            oMovie.sExtention = oFileInfo.Extension

            'oMovie.sName = sFileName
            'oMovie.sExtention = sExtention

            FindDate(oMovie)

            'stripNameBeforeYear(oMovie)

            'FormatMovieName(oMovie)

        End If

        Return oMovie

    End Function

    Public Function FindDate(oMovie As Media) As Boolean
        Dim iYearFound As Integer
        Dim bMatch As Boolean = oMovie.sName Like "*####*"

        If bMatch Then
            oMovie.iYearPos = FindDatePos(iYearFound, oMovie.sName)
            oMovie.iYear = iYearFound
        End If

        Return bMatch
    End Function

    Public Function FindDatePos(ByRef iReturnYear As Integer, sRead As String) As Integer
        Dim iYear As Integer
        Dim iYearPos As Integer
        Dim iCounter As Integer
        Dim sCheck As String

        For iCounter = 0 To sRead.Length - 4
            sCheck = sRead.Substring(iCounter, 4)

            Try
                iYear = Convert.ToInt32(sCheck)
            Catch ex As Exception
                iYear = 0
            End Try

            If iYear < 2050 And iYear > 1900 Then
                iReturnYear = iYear
                iYearPos = iCounter
            End If

        Next

        Return iYearPos
    End Function


    Private Function StripFileName(sFullPath As String) As String
        Dim sReturn As String

        sReturn = sFullPath

        While sReturn.Contains("\")
            sReturn = sReturn.Substring(sReturn.IndexOf("\") + 1)
        End While

        Return sReturn
    End Function

    Private Function StripKnownTypes(sFileName As String, ByRef sExtention As String) As String
        Dim sReturn As String

        sExtention = sFileName

        While sExtention.Contains(".")
            sExtention = sExtention.Substring(sExtention.IndexOf(".") + 1)
        End While

        sReturn = sFileName.Substring(0, sFileName.Length - sExtention.Length - 1)

        Return sReturn
    End Function

    Private Function stripNameBeforeYear(oMovie As Media) As Boolean
        Dim bReturn As Boolean
        Dim sFileName As String

        sFileName = oMovie.sName

        If oMovie.iYearPos > 0 Then
            sFileName = sFileName.Substring(0, oMovie.iYearPos - 1)
        End If

        oMovie.sFormattedName = sFileName

        Return bReturn
    End Function

    Private Function FormatMovieName(oMovie As Media) As Boolean
        Dim bReturn As Boolean

        oMovie.sFormattedName = RemoveCommonChars(oMovie.sFormattedName)

        Return bReturn
    End Function

    Private Function RemoveCommonChars(sMovieName As String, Optional sRemoveChars As String = ".") As String
        Dim sReturnName As String
        Dim sChar As String
        Dim iCharLoop As Integer

        sReturnName = sMovieName

        For iCharLoop = 0 To sRemoveChars.Length - 1

            sChar = sRemoveChars.Substring(iCharLoop, 1)
            sReturnName = sReturnName.Replace(sChar, " ")

        Next

        Return sReturnName
    End Function

End Class
