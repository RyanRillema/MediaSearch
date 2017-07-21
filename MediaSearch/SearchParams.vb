Public Class SearchParams
    Private bLogEnabled As Boolean
    Private sLogPath As String
    Private bDetailed, bInfo, bWarning, bError As Boolean

    'Publics
    Public Sub New()
        loadParams()
    End Sub

    Public Sub loadParams()
        Dim readValue

        readValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "LogEnabled", Nothing)
        bLogEnabled = readValue
        readValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "LogPath", Nothing)
        sLogPath = readValue
        readValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "DetailedLog", Nothing)
        bDetailed = readValue
        readValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "InfoLog", Nothing)
        bInfo = readValue
        readValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "WarningLog", Nothing)
        bWarning = readValue
        readValue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "ErrorLog", Nothing)
        bError = readValue

    End Sub

    Public Sub writeToReg()

        My.Computer.Registry.CurrentUser.CreateSubKey("MediaSearch")
        ' Change MyTestKeyValue to This is a test value. 
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "LogEnabled", bLogEnabled)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "LogPath", sLogPath)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "DetailedLog", bDetailed)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "InfoLog", bInfo)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "WarningLog", bWarning)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\MediaSearch", "ErrorLog", bError)

    End Sub

    'Set routines
    Public Sub setLogEnabled(bSetEnabled As Boolean)
        bLogEnabled = bSetEnabled
    End Sub
    Public Sub setLogPath(sSetLogPath As String)
        sLogPath = sSetLogPath
    End Sub
    Public Sub setDetailed(bSetEnabled As Boolean)
        bDetailed = bSetEnabled
    End Sub
    Public Sub setInfo(bSetEnabled As Boolean)
        bInfo = bSetEnabled
    End Sub
    Public Sub setWarning(bSetEnabled As Boolean)
        bWarning = bSetEnabled
    End Sub
    Public Sub setError(bSetEnabled As Boolean)
        bError = bSetEnabled
    End Sub

    'Get routines
    Public Function getLogEnabled() As Boolean
        Return bLogEnabled
    End Function
    Public Function getLogPath() As String
        Return sLogPath
    End Function
    Public Function getDetailed() As Boolean
        Return bDetailed
    End Function
    Public Function getInfo() As Boolean
        Return bInfo
    End Function
    Public Function getWarning() As Boolean
        Return bWarning
    End Function
    Public Function getError() As Boolean
        Return bError
    End Function
End Class