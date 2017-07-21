Public Class frmMediaInfo
    Dim oMediaSearch As MediaSearch

    Public Sub New(oSetMediaSearch As MediaSearch)

        ' This call is required by the designer.
        InitializeComponent()

        oMediaSearch = oSetMediaSearch
        Me.Hide()

    End Sub

    Public Sub showForm(Optional bRefresh As Boolean = True)
        Me.Show()
    End Sub

    Private Sub refreshMediaInfo()

    End Sub
End Class