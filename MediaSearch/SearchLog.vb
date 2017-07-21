Public Class SearchLog

    Private oMediaSearch As MediaSearch
    Private oParams As SearchParams
    Private writeFile As System.IO.StreamWriter

    Public Sub New(oSetMediaSearch As MediaSearch)
        oMediaSearch = oSetMediaSearch
        oParams = oMediaSearch.getParams
    End Sub

    Public Sub writeDetailedGeneric(sWriteLn As String)

        If oParams.getLogEnabled Then
            If oParams.getDetailed Then
                writetoLog(sWriteLn)
            End If
        End If

    End Sub

    Public Sub writeInfoGeneric(sWriteLn As String)

        If oParams.getLogEnabled Then
            If oParams.getInfo Then
                writetoLog(sWriteLn)
            End If
        End If

    End Sub

    Public Sub writeWarningGeneric(sWriteLn As String)

        If oParams.getLogEnabled Then
            If oParams.getWarning Then
                writetoLog(sWriteLn)
            End If
        End If

    End Sub

    Public Sub writeErrorGeneric(sWriteLn As String)

        If oParams.getLogEnabled Then
            If oParams.getError Then
                writetoLog(sWriteLn)
            End If
        End If

    End Sub

    Public Sub writeErrorFile(sWriteLn As String)

        If oParams.getLogEnabled Then
            writetoLog(sWriteLn)
        End If

    End Sub

    Private Sub writetoLog(sWriteln As String)
        writeFile = My.Computer.FileSystem.OpenTextFileWriter(oParams.getLogPath & "\Log.txt", True)

        writeFile.WriteLine(sWriteln)

        writeFile.Close()
    End Sub

End Class
