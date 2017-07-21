Public Class SearchPath
    Public sPath As String
    Public bInclude As Boolean

    'Set routines
    Public Sub setPath(sSetPath As String)
        sPath = sSetPath
    End Sub
    Public Sub setInclude(bSetInc As Boolean)
        bInclude = bSetInc
    End Sub

    'Get routines
    Public Function getPath() As String
        Return sPath
    End Function
    Public Function getInclude() As Boolean
        Return bInclude
    End Function
End Class
