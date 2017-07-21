Public Class Constants
    Private iAvailableSearchPaths As Integer = 16
    Private iImportArraySize As Integer = 100000

    'Get routines
    Public Function getAvailablePaths() As Integer
        Return iAvailableSearchPaths
    End Function

    Public Function getImportArraySize() As Integer
        Return iImportArraySize
    End Function
End Class
