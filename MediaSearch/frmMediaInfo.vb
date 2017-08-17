Public Class frmMediaInfo
    Dim oMediaSearch As MediaSearch
    Dim oMedia As Media 'Media item To display

    Public Sub New(oSetMediaSearch As MediaSearch)

        ' This call is required by the designer.
        InitializeComponent()

        oMediaSearch = oSetMediaSearch
        Me.Hide()

    End Sub

    Public Sub setMedia(oSetMedia As Media)
        oMedia = oSetMedia
    End Sub

    Public Sub showForm(Optional bRefresh As Boolean = True)
        Me.Show()
    End Sub

    Public Sub hideForm(Optional bRefresh As Boolean = True)
        Me.Hide()
    End Sub

    Private Sub refreshMediaInfo()

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        hideForm()
    End Sub
End Class