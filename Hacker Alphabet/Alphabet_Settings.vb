Option Strict On

Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports System.Threading
Imports System.Reflection
Public Class Alphabet_Settings

    Public Property ChangeModel As Integer = 1
    Public Property ChangeNumberModel As Integer = 1
    Public Property NumberActivateBol As Boolean = True

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure KBDLLHOOKSTRUCT
        Friend key As Keys
        Friend vkCode As Long
        Friend scanCode As Long
        Friend flags As Long
        Friend time As Long
        Friend dwExtraInfo As UIntPtr
    End Structure

    'CONSTANTES PARA CAPTURAR A TECLA PRESSIONADA
    Private Const WM_KEYDOWN = &H100
    Private Const WH_KEYBOARD_LL = 13

    'LEVEL DE SYSTEMA USADO PARA HOOKAR E DESHOOKAR COISA INSERIDA NO TECLADO.
    Private Delegate Function LowLevelKeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr


    'DIRECIONA EVENTO WINDOW PARA FUNCTION
    Private Declare Auto Function SetWindowsHookEx Lib "user32.dll" Alias "SetWindowsHookExA" (ByVal id As Integer, ByVal callback As LowLevelKeyboardProc, ByVal hMod As IntPtr, ByVal dwThreadId As UInteger) As IntPtr
    Private Declare Auto Function UnhookWindowsHookEx Lib "user32.dll" Alias "UnhookWindowsHookEx" (ByVal hook As IntPtr) As Boolean
    Private Declare Auto Function CallNextHookEx Lib "user32.dll" Alias "CallNextHookEx" (ByVal hook As IntPtr, ByVal nCode As Integer, ByVal wp As IntPtr, ByVal lp As IntPtr) As IntPtr
    Private Declare Auto Function GetAsyncKeyState Lib "user32.dll" Alias "GetAsyncKeyState" (ByVal key As Keys) As Short
    Private Declare Auto Function GetModuleHandle Lib "kernel32.dll" (ByVal name As String) As IntPtr

    'DECLARANDO OBJETOS GLOBAIS
    Private PtrHook As IntPtr
    Private ObjKeyBoardProcess As LowLevelKeyboardProc
    Private ObjCurrentModule As ProcessModule



    'FUNÇÃO ATIVADORA DA FERRAMENTA
    Public Function KEYSACTIVATE(ByVal ACTIVE As Boolean) As Boolean
        Try
            If ACTIVE Then
                'ABILITA O PROCESSO DE LETRAS HACKER
                ObjCurrentModule = Process.GetCurrentProcess().MainModule
                ObjKeyBoardProcess = New LowLevelKeyboardProc(AddressOf CaptureKey)
                PtrHook = SetWindowsHookEx(WH_KEYBOARD_LL, ObjKeyBoardProcess, GetModuleHandle(ObjCurrentModule.ModuleName), 0)
                Return True
            Else
                'DESABILITA O PROCESSO DE LETRAS HACKER
                UnhookWindowsHookEx(PtrHook)
                Return False
            End If
        Catch
            Return False
        End Try
    End Function
    Private Function RandomLetras(ByVal Caracters As String()) As String
        Dim Rand As Random = New Random
        Dim Count As Integer = Rand.Next(Caracters.Count)
        Return Caracters(Count)
    End Function

    Private objKeyInfo As KBDLLHOOKSTRUCT
    Private Function CaptureKey(ByVal EventoCaptura As Integer, ByVal TeclaApertada As IntPtr, ByVal ThereadID As IntPtr) As IntPtr
        On Error Resume Next

        objKeyInfo = DirectCast(Marshal.PtrToStructure(ThereadID, GetType(KBDLLHOOKSTRUCT)), KBDLLHOOKSTRUCT)


        If CInt(TeclaApertada) = WM_KEYDOWN Then


            If ChangeModel = 1 Then


                If objKeyInfo.key = Keys.A Then
                    SendKeys.Send(RandomLetras({"ⱥ", "Д", "ª", "ă"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.B Then
                    SendKeys.Send(RandomLetras({"в", "ß", "ь", "β"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.C Then
                    SendKeys.Send(RandomLetras({"¢", "©", "č"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.D Then
                    SendKeys.Send(RandomLetras({"đ", "Đ", "∂", "ð", "ď"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.E Then
                    SendKeys.Send(RandomLetras({"ε", "Э", "ξ", "ễ", "Є", "£", "ﻍ"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.F Then
                    SendKeys.Send(RandomLetras({"ƒ", "₣"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.G Then
                    SendKeys.Send(RandomLetras({"ġ", "Ğ", "פ"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.H Then
                    SendKeys.Send(RandomLetras({"ђ", "Њ"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.I Then
                    SendKeys.Send(RandomLetras({"ĭ", "ι"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.J Then
                    SendKeys.Send(RandomLetras({"§", "Љ", "ﻝ"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.K Then
                    SendKeys.Send(RandomLetras({"ķ", "Ж", "Ķ"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.L Then
                    SendKeys.Send(RandomLetras({"ℓ", "ł", "Ľ"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.M Then
                    SendKeys.Send(RandomLetras({"м", "♏", "ⓜ", "∑", "ღ"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.N Then
                    SendKeys.Send(RandomLetras({"и", "й", "Ŋ", "∩"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.O Then
                    SendKeys.Send(RandomLetras({"ø", "θ", "Ø", "◑", "☼", "〇"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.P Then
                    SendKeys.Send(RandomLetras({"Þ", "þ", "ק"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.Q Then
                    SendKeys.Send(RandomLetras({"♀", "ⓠ"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.R Then
                    SendKeys.Send(RandomLetras({"я", "®"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.S Then
                    SendKeys.Send(RandomLetras({"ֆ", "§", "ک"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.T Then
                    SendKeys.Send(RandomLetras({"ŧ", "†", "Ѓ", "τ", "┬", "〒", "┱"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.U Then
                    SendKeys.Send(RandomLetras({"µ", "ﻦ", "◡"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.V Then
                    SendKeys.Send(RandomLetras({"◡", "ⓥ", "\/"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.W Then
                    SendKeys.Send(RandomLetras({"ω", "௰", "Ш"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.X Then
                    SendKeys.Send(RandomLetras({"✗", "✘", "〷", "ⓧ", "×"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.Y Then
                    SendKeys.Send(RandomLetras({"Ψ", "Ҹ", "Ψ", "¥", "ỷ"}))
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.Z Then
                    SendKeys.Send(RandomLetras({"ż", "ž", "ⓩ", "Ž"}))
                    Return CType(1, IntPtr)

                End If

                'MODELO 2
            ElseIf ChangeModel = 2 Then



                If objKeyInfo.key = Keys.A Then
                    SendKeys.Send("ⓐ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.B Then
                    SendKeys.Send("ⓑ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.C Then
                    SendKeys.Send("ⓒ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.D Then
                    SendKeys.Send("ⓓ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.E Then
                    SendKeys.Send("ⓔ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.F Then
                    SendKeys.Send("ⓕ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.G Then
                    SendKeys.Send("ⓖ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.H Then
                    SendKeys.Send("ⓗ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.Y Then
                    SendKeys.Send("ⓘ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.J Then
                    SendKeys.Send("ⓙ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.K Then
                    SendKeys.Send("ⓚ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.L Then
                    SendKeys.Send("ⓛ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.M Then
                    SendKeys.Send("ⓜ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.N Then
                    SendKeys.Send("ⓝ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.O Then
                    SendKeys.Send("ⓞ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.P Then
                    SendKeys.Send("ⓟ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.Q Then
                    SendKeys.Send("ⓠ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.R Then
                    SendKeys.Send("ⓡ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.S Then
                    SendKeys.Send("ⓢ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.T Then
                    SendKeys.Send("ⓣ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.U Then
                    SendKeys.Send("ⓤ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.V Then
                    SendKeys.Send("ⓥ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.W Then
                    SendKeys.Send("ⓦ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.X Then
                    SendKeys.Send("ⓧ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.Y Then
                    SendKeys.Send("ⓨ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.Z Then
                    SendKeys.Send("ⓩ")
                    Return CType(1, IntPtr)

                End If

                'MODELO 3
            ElseIf ChangeModel = 3 Then

                If objKeyInfo.key = Keys.A Then
                    SendKeys.Send("α")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.B Then
                    SendKeys.Send("ß")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.C Then
                    SendKeys.Send("č")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.D Then
                    SendKeys.Send("đ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.E Then
                    SendKeys.Send("є")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.F Then
                    SendKeys.Send("ƒ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.G Then
                    SendKeys.Send("ğ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.H Then
                    SendKeys.Send("ħ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.I Then
                    SendKeys.Send("ĭ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.J Then
                    SendKeys.Send("נ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.K Then
                    SendKeys.Send("ķ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.L Then
                    SendKeys.Send("ℓ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.M Then
                    SendKeys.Send("м")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.N Then
                    SendKeys.Send("и")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.O Then
                    SendKeys.Send("ø")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.P Then
                    SendKeys.Send("ρ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.Q Then
                    SendKeys.Send("♀")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.R Then
                    SendKeys.Send("я")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.S Then
                    SendKeys.Send("ی")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.T Then
                    SendKeys.Send("ŧ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.U Then
                    SendKeys.Send("ﮞ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.V Then
                    SendKeys.Send("υ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.W Then
                    SendKeys.Send("ω")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.X Then
                    SendKeys.Send("χ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.Y Then
                    SendKeys.Send("ψ")
                    Return CType(1, IntPtr)

                ElseIf objKeyInfo.key = Keys.Z Then
                    SendKeys.Send("ž")
                    Return CType(1, IntPtr)

                End If

            ElseIf ChangeModel = 4 Then
            ElseIf ChangeModel = 5 Then
            End If


            'VALORES NUMERICOS NUMPAD PARA O TECLADO.


            If NumberActivateBol = True Then

                If ChangeNumberModel = 1 Then

                    If objKeyInfo.key = Keys.NumPad0 Then
                        SendKeys.Send("⁰")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.NumPad1 Then
                        SendKeys.Send("¹")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.NumPad2 Then
                        SendKeys.Send("²")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.NumPad3 Then
                        SendKeys.Send("³")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.NumPad4 Then
                        SendKeys.Send("⁴")
                        Return CType(1, IntPtr)


                    ElseIf objKeyInfo.key = Keys.NumPad5 Then
                        SendKeys.Send("⁵")
                        Return CType(1, IntPtr)


                    ElseIf objKeyInfo.key = Keys.NumPad6 Then
                        SendKeys.Send("⁶")
                        Return CType(1, IntPtr)


                    ElseIf objKeyInfo.key = Keys.NumPad7 Then
                        SendKeys.Send("⁷")
                        Return CType(1, IntPtr)


                    ElseIf objKeyInfo.key = Keys.NumPad8 Then
                        SendKeys.Send("⁸")
                        Return CType(1, IntPtr)


                    ElseIf objKeyInfo.key = Keys.NumPad9 Then
                        SendKeys.Send("⁹")
                        Return CType(1, IntPtr)


                        'VALORES NUMERICOS PARA O TECLADO.


                    ElseIf objKeyInfo.key = Keys.D1 Then
                        SendKeys.Send("¹")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D2 Then
                        SendKeys.Send("²")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D3 Then
                        SendKeys.Send("³")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D4 Then
                        SendKeys.Send("⁴")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D5 Then
                        SendKeys.Send("⁵")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D6 Then
                        SendKeys.Send("⁶")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D7 Then
                        SendKeys.Send("⁷")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D8 Then
                        SendKeys.Send("⁸")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D9 Then
                        SendKeys.Send("⁹")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D0 Then
                        SendKeys.Send("⁰")
                        Return CType(1, IntPtr)

                    End If


                    'NUMERO TECLADO MODELO 2
                ElseIf ChangeNumberModel = 2 Then

                    If objKeyInfo.key = Keys.NumPad0 Then
                        SendKeys.Send("ⓞ")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.NumPad1 Then
                        SendKeys.Send("①")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.NumPad2 Then
                        SendKeys.Send("②")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.NumPad3 Then
                        SendKeys.Send("③")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.NumPad4 Then
                        SendKeys.Send("④")
                        Return CType(1, IntPtr)


                    ElseIf objKeyInfo.key = Keys.NumPad5 Then
                        SendKeys.Send("⑤")
                        Return CType(1, IntPtr)


                    ElseIf objKeyInfo.key = Keys.NumPad6 Then
                        SendKeys.Send("⑥")
                        Return CType(1, IntPtr)


                    ElseIf objKeyInfo.key = Keys.NumPad7 Then
                        SendKeys.Send("⑦")
                        Return CType(1, IntPtr)


                    ElseIf objKeyInfo.key = Keys.NumPad8 Then
                        SendKeys.Send("⑧")
                        Return CType(1, IntPtr)


                    ElseIf objKeyInfo.key = Keys.NumPad9 Then
                        SendKeys.Send("⑨")
                        Return CType(1, IntPtr)


                        'VALORES NUMERICOS PARA O TECLADO.


                    ElseIf objKeyInfo.key = Keys.D1 Then
                        SendKeys.Send("①")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D2 Then
                        SendKeys.Send("②")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D3 Then
                        SendKeys.Send("③")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D4 Then
                        SendKeys.Send("④")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D5 Then
                        SendKeys.Send("⑤")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D6 Then
                        SendKeys.Send("⑥")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D7 Then
                        SendKeys.Send("⑦")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D8 Then
                        SendKeys.Send("⑧")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D9 Then
                        SendKeys.Send("⑨")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D0 Then
                        SendKeys.Send("ⓞ")
                        Return CType(1, IntPtr)

                    End If

                    'NUMERO TECLADO MODELO 2
                ElseIf ChangeNumberModel = 3 Then



                    If objKeyInfo.key = Keys.NumPad1 Then
                        SendKeys.Send("Ⅰ")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.NumPad2 Then
                        SendKeys.Send("Ⅱ")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.NumPad3 Then
                        SendKeys.Send("Ⅲ")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.NumPad4 Then
                        SendKeys.Send("Ⅳ")
                        Return CType(1, IntPtr)


                    ElseIf objKeyInfo.key = Keys.NumPad5 Then
                        SendKeys.Send("Ⅴ")
                        Return CType(1, IntPtr)


                    ElseIf objKeyInfo.key = Keys.NumPad6 Then
                        SendKeys.Send("Ⅵ")
                        Return CType(1, IntPtr)


                    ElseIf objKeyInfo.key = Keys.NumPad7 Then
                        SendKeys.Send("Ⅶ")
                        Return CType(1, IntPtr)


                    ElseIf objKeyInfo.key = Keys.NumPad8 Then
                        SendKeys.Send("Ⅷ")
                        Return CType(1, IntPtr)


                    ElseIf objKeyInfo.key = Keys.NumPad9 Then
                        SendKeys.Send("Ⅸ")
                        Return CType(1, IntPtr)


                        'VALORES NUMERICOS PARA O TECLADO.


                    ElseIf objKeyInfo.key = Keys.D1 Then
                        SendKeys.Send("Ⅰ")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D2 Then
                        SendKeys.Send("Ⅱ")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D3 Then
                        SendKeys.Send("Ⅲ")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D4 Then
                        SendKeys.Send("Ⅳ")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D5 Then
                        SendKeys.Send("Ⅴ")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D6 Then
                        SendKeys.Send("Ⅵ")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D7 Then
                        SendKeys.Send("Ⅶ")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D8 Then
                        SendKeys.Send("Ⅷ")
                        Return CType(1, IntPtr)

                    ElseIf objKeyInfo.key = Keys.D9 Then
                        SendKeys.Send("Ⅸ")
                        Return CType(1, IntPtr)
                    End If

                End If



            End If

        End If



        Return CallNextHookEx(PtrHook, EventoCaptura, TeclaApertada, ThereadID)


    End Function
End Class
