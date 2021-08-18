Public Module Hotkey

#Region "Declarations - WinAPI, Hotkey constant and Modifier Enum"
    ''' <summary>
    ''' Declaration of winAPI function wrappers. The winAPI functions are used to register / unregister a hotkey
    ''' </summary>
    Private Declare Function RegisterHotKey Lib "user32" (ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer

    Private Declare Function UnregisterHotKey Lib "user32" (ByVal hwnd As IntPtr, ByVal id As Integer) As Integer

    Public Const WM_HOTKEY As Integer = &H312

    Enum KeyModifier
        None = 0
        Alt = &H1
        Control = &H2
        Shift = &H4
        Winkey = &H8
    End Enum 'This enum is just to make it easier to call the registerHotKey function: The modifier integer codes are replaced by a friendly "Alt","Shift" etc.
#End Region

    Private Key As Keys
#Region "Hotkey registration, unregistration and handling"
    Public Sub RegisterHotKey(ByRef sourceForm As Form, ByVal triggerKey As Keys, ByVal modifier As KeyModifier)
        RegisterHotKey(sourceForm.Handle, 1, modifier, Int(triggerKey))
    End Sub
    Public Sub UnregisterHotKeys(ByRef sourceForm As Form)
        UnregisterHotKey(sourceForm.Handle, 1)  'Remember to call unregisterHotkeys() when closing your application.
    End Sub
#End Region
End Module