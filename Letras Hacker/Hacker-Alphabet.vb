Imports ToolsBox.Utils

Public Class Hack_Alphabet

    Private WithEvents KeyHook As New KeyboardHook
    Private WithEvents LETRASHACKER As New Alphabet_Settings
    Private Icon_Animation As Integer = 0
    Dim LOCAT As Point
    Dim WithEvents HK As HotKeys

    Sub New()
        'This call is required by the designer.
        InitializeComponent()
        NotifyIcon1.BalloonTipTitle = "Hacker Alphabet"
        NotifyIcon1.BalloonTipText = "Hacker Letters started sucessful! To finish click on the right corner next to the system clock."
        NotifyIcon1.ShowBalloonTip(3000)
        NotifyIcon1.Visible = True
        Icon_Animation = 1

        'INICIA CLASS LETRASHACKER
        LETRASHACKER.KEYSACTIVATE(True)

        'DESATIVA INICIAR PORQUE JÁ FOI INICIADO
        IniciarToolStripMenuItem.Enabled = False
       
    End Sub
    
    'Friend Key As Keys
    Private Sub HotKey()
        On Error Resume Next
        System.Threading.Thread.Sleep(500)
        If ComboBox1.SelectedItem = "F1" Then
            HK = HotKeys.Create(HotKeys.Modifier.None, Keys.F1)
        ElseIf ComboBox1.SelectedItem = "F2" Then
            HK = HotKeys.Create(HotKeys.Modifier.None, Keys.F2)
        ElseIf ComboBox1.SelectedItem = "F3" Then
            HK = HotKeys.Create(HotKeys.Modifier.None, Keys.F3)
        ElseIf ComboBox1.SelectedItem = "F4" Then
            HK = HotKeys.Create(HotKeys.Modifier.None, Keys.F4)
        ElseIf ComboBox1.SelectedItem = "F5" Then
            HK = HotKeys.Create(HotKeys.Modifier.None, Keys.F5)
        ElseIf ComboBox1.SelectedItem = "F6" Then
            HK = HotKeys.Create(HotKeys.Modifier.None, Keys.F6)
        ElseIf ComboBox1.SelectedItem = "F7" Then
            HK = HotKeys.Create(HotKeys.Modifier.None, Keys.F7)
        ElseIf ComboBox1.SelectedItem = "F8" Then
            HK = HotKeys.Create(HotKeys.Modifier.None, Keys.F8)
        ElseIf ComboBox1.SelectedItem = "F9" Then
            HK = HotKeys.Create(HotKeys.Modifier.None, Keys.F9)
        ElseIf ComboBox1.SelectedItem = "F10" Then
            HK = HotKeys.Create(HotKeys.Modifier.None, Keys.F10)
        ElseIf ComboBox1.SelectedItem = "F11" Then
            HK = HotKeys.Create(HotKeys.Modifier.None, Keys.F11)
        ElseIf ComboBox1.SelectedItem = "F12" Then
            HK = HotKeys.Create(HotKeys.Modifier.None, Keys.F12)

        ElseIf ComboBox1.SelectedItem = "Alt + F1" Then
            HK = HotKeys.Create(HotKeys.Modifier.Alt, Keys.F1)
        ElseIf ComboBox1.SelectedItem = "Alt + F2" Then
            HK = HotKeys.Create(HotKeys.Modifier.Alt, Keys.F2)
        ElseIf ComboBox1.SelectedItem = "Alt + F3" Then
            HK = HotKeys.Create(HotKeys.Modifier.Alt, Keys.F3)
        ElseIf ComboBox1.SelectedItem = "Alt + F4" Then
            HK = HotKeys.Create(HotKeys.Modifier.Alt, Keys.F4)
        ElseIf ComboBox1.SelectedItem = "Alt + F5" Then
            HK = HotKeys.Create(HotKeys.Modifier.Alt, Keys.F5)
        ElseIf ComboBox1.SelectedItem = "Alt + F6" Then
            HK = HotKeys.Create(HotKeys.Modifier.Alt, Keys.F6)
        ElseIf ComboBox1.SelectedItem = "Alt + F7" Then
            HK = HotKeys.Create(HotKeys.Modifier.Alt, Keys.F7)
        ElseIf ComboBox1.SelectedItem = "Alt + F8" Then
            HK = HotKeys.Create(HotKeys.Modifier.Alt, Keys.F8)
        ElseIf ComboBox1.SelectedItem = "Alt + F9" Then
            HK = HotKeys.Create(HotKeys.Modifier.Alt, Keys.F9)
        ElseIf ComboBox1.SelectedItem = "Alt + F10" Then
            HK = HotKeys.Create(HotKeys.Modifier.Alt, Keys.F10)
        ElseIf ComboBox1.SelectedItem = "Alt + F11" Then
            HK = HotKeys.Create(HotKeys.Modifier.Alt, Keys.F11)
        ElseIf ComboBox1.SelectedItem = "Alt + F12" Then
            HK = HotKeys.Create(HotKeys.Modifier.Alt, Keys.F12)

        ElseIf ComboBox1.SelectedItem = "Ctr + F1" Then
            HK = HotKeys.Create(HotKeys.Modifier.Control, Keys.F1)
        ElseIf ComboBox1.SelectedItem = "Ctr + F2" Then
            HK = HotKeys.Create(HotKeys.Modifier.Control, Keys.F2)
        ElseIf ComboBox1.SelectedItem = "Ctr + F3" Then
            HK = HotKeys.Create(HotKeys.Modifier.Control, Keys.F3)
        ElseIf ComboBox1.SelectedItem = "Ctr + F4" Then
            HK = HotKeys.Create(HotKeys.Modifier.Control, Keys.F4)
        ElseIf ComboBox1.SelectedItem = "Ctr + F5" Then
            HK = HotKeys.Create(HotKeys.Modifier.Control, Keys.F5)
        ElseIf ComboBox1.SelectedItem = "Ctr + F6" Then
            HK = HotKeys.Create(HotKeys.Modifier.Control, Keys.F6)
        ElseIf ComboBox1.SelectedItem = "Ctr + F7" Then
            HK = HotKeys.Create(HotKeys.Modifier.Control, Keys.F7)
        ElseIf ComboBox1.SelectedItem = "Ctr + F8" Then
            HK = HotKeys.Create(HotKeys.Modifier.Control, Keys.F8)
        ElseIf ComboBox1.SelectedItem = "Ctr + F9" Then
            HK = HotKeys.Create(HotKeys.Modifier.Control, Keys.F9)
        ElseIf ComboBox1.SelectedItem = "Ctr + F10" Then
            HK = HotKeys.Create(HotKeys.Modifier.Control, Keys.F10)
        ElseIf ComboBox1.SelectedItem = "Ctr + F11" Then
            HK = HotKeys.Create(HotKeys.Modifier.Control, Keys.F11)
        ElseIf ComboBox1.SelectedItem = "Ctr + F12" Then
            HK = HotKeys.Create(HotKeys.Modifier.Control, Keys.F12)
        End If
    End Sub
    Private Sub HK_Press(ByVal s As Object, ByVal e As HotKeys.HotKeyEventArgs) Handles HK.Press
        If ON_OFF_Switch.Checked = True Then
            Stop_()
            ON_OFF_Switch.Checked = False
        Else
            Start_()
            ON_OFF_Switch.Checked = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        My.Settings.HotKey = ComboBox1.SelectedItem
        My.Settings.Save()
        Call HotKey()
    End Sub
    Private Sub Choose_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' Threading.Thread.Sleep(50)
        Me.ShowInTaskbar = False
        Me.WindowState = FormWindowState.Minimized
        Me.Hide()

        If My.Settings.HotKey = "" Then
            My.Settings.HotKey = "F11"
            My.Settings.Save()
        End If

        If My.Settings.Opacity = Nothing Then
        Else
            Me.Opacity = My.Settings.Opacity
            Opacity_Trb.Value = My.Settings.Opacity * 10
            Opacity_lbl.Text = "Opacity: " & Opacity_Trb.Value * 10 & "%"
        End If

        ComboBox1.SelectedItem = My.Settings.HotKey
       
    End Sub
    Private Sub IniciarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IniciarToolStripMenuItem.Click
        Call Start_()
    End Sub
    Private Sub PararToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PararToolStripMenuItem.Click
        Call Stop_()
    End Sub
    Private Sub Stop_()
        LETRASHACKER.KEYSACTIVATE(False)
        IniciarToolStripMenuItem.Enabled = True
        PararToolStripMenuItem.Enabled = False
        My.Computer.Audio.Play(My.Resources.Alert, AudioPlayMode.Background)
        NotifyIcon1.BalloonTipTitle = "Hacker Alphabet"
        NotifyIcon1.BalloonTipText = "■ Hacker Alphabet Stopped!"
        NotifyIcon1.ShowBalloonTip(3000)
        NotifyIcon1.Visible = True
        Icon_Animation = 0
        ON_OFF_Switch.Checked = False
        ON_OFF_LBL.Text = "OFF"
        ON_OFF_LBL.ForeColor = Color.FromArgb(255, 128, 128)

    End Sub
    Private Sub Start_()
        LETRASHACKER.KEYSACTIVATE(True)
        IniciarToolStripMenuItem.Enabled = False
        PararToolStripMenuItem.Enabled = True
        My.Computer.Audio.Play(My.Resources.Alert, AudioPlayMode.Background)
        NotifyIcon1.BalloonTipTitle = "Hacker Alphabet"
        NotifyIcon1.BalloonTipText = "▶ Hacker Alphabet started sucessful."
        NotifyIcon1.ShowBalloonTip(3000)
        NotifyIcon1.Visible = True
        Icon_Animation = 1
        ON_OFF_Switch.Checked = True
        ON_OFF_LBL.Text = "ON"
        ON_OFF_LBL.ForeColor = Color.Lime
    End Sub
    Private Sub SairToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SairToolStripMenuItem.Click
        NotifyIcon1.Visible = False
        LETRASHACKER.KEYSACTIVATE(False)
        End
    End Sub

    Private Sub Hacker_Alphabet_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs)
        NotifyIcon1.Visible = False
        LETRASHACKER.KEYSACTIVATE(False)
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs)
        NotifyIcon1.Visible = False
        LETRASHACKER.KEYSACTIVATE(False)
    End Sub
    Private Sub Close_btn_Click(sender As System.Object, e As System.EventArgs) Handles Close_btn.Click
        NotifyIcon1.Visible = False
        LETRASHACKER.KEYSACTIVATE(False)
        End
    End Sub

    Private Sub LETTER_1()
        LETRASHACKER.ChangeModel = 1
        ModelToolStripMenuItem.Checked = True
        ModelToolStripMenuItem1.Checked = False
        ModelToolStripMenuItem2.Checked = False
        Model_1_Radio.Checked = True
        My.Computer.Audio.Play(My.Resources.Alert, AudioPlayMode.Background)
        NotifyIcon1.BalloonTipTitle = "Hacker Alphabet"
        NotifyIcon1.BalloonTipText = "Hacker Alphabet Changed to: 〒ễ§ŧ ℓεŧ†Эπֆ"
        NotifyIcon1.ShowBalloonTip(3000)
        NotifyIcon1.Visible = True
    End Sub
    Private Sub LETTER_2()
        LETRASHACKER.ChangeModel = 2
        ModelToolStripMenuItem.Checked = False
        ModelToolStripMenuItem1.Checked = True
        ModelToolStripMenuItem2.Checked = False
        Model_2_Radio.Checked = True
        My.Computer.Audio.Play(My.Resources.Alert, AudioPlayMode.Background)
        NotifyIcon1.BalloonTipTitle = "Hacker Alphabet"
        NotifyIcon1.BalloonTipText = "Hacker Alphabet Changed to: ⓣⓔⓢⓣ ⓛⓔⓣⓣⓔⓡ"
        NotifyIcon1.ShowBalloonTip(3000)
        NotifyIcon1.Visible = True
    End Sub
    Private Sub LETTER_3()
        LETRASHACKER.ChangeModel = 3
        ModelToolStripMenuItem.Checked = False
        ModelToolStripMenuItem1.Checked = False
        ModelToolStripMenuItem2.Checked = True
        Model_3_Radio.Checked = True
        My.Computer.Audio.Play(My.Resources.Alert, AudioPlayMode.Background)
        NotifyIcon1.BalloonTipTitle = "Hacker Alphabet"
        NotifyIcon1.BalloonTipText = "Hacker Alphabet Changed to: ŧєیŧ ℓєŧŧєя"
        NotifyIcon1.ShowBalloonTip(3000)
        NotifyIcon1.Visible = True
    End Sub
    Private Sub ModelToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModelToolStripMenuItem.Click
        Call LETTER_1()
    End Sub
    Private Sub ModelToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ModelToolStripMenuItem1.Click
        Call LETTER_2()
    End Sub
    Private Sub ModelToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ModelToolStripMenuItem2.Click
        Call LETTER_3()
    End Sub

    Private Sub ModelToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ModelToolStripMenuItem3.Click
        Call ACTIVATE_NUMBER()
    End Sub
    Private Sub NUMBER_ACTIVATE_SWITCH_Click(sender As Object, e As System.EventArgs) Handles NUMBER_ACTIVATE_SWITCH.Click
        Call ACTIVATE_NUMBER()
    End Sub
    Private Sub ACTIVATE_NUMBER()
        If LETRASHACKER.NumberActivateBol = True Then
            My.Computer.Audio.Play(My.Resources.Alert, AudioPlayMode.Background)
            LETRASHACKER.NumberActivateBol = False
            NUMBER_ACTIVATE_SWITCH.Checked = False
            ModelToolStripMenuItem3.Checked = False
            ModelToolStripMenuItem4.Enabled = False
            ModelToolStripMenuItem5.Enabled = False
            ModelToolStripMenuItem6.Enabled = False
            Model_4_Radio.Enabled = False
            Model_5_Radio.Enabled = False
            Model_6_Radio.Enabled = False
            LETRASHACKER.ChangeNumberModel = 0

        Else
            My.Computer.Audio.Play(My.Resources.Alert, AudioPlayMode.Background)
            LETRASHACKER.NumberActivateBol = True
            NUMBER_ACTIVATE_SWITCH.Checked = True
            ModelToolStripMenuItem3.Checked = True
            ModelToolStripMenuItem4.Enabled = True
            ModelToolStripMenuItem5.Enabled = True
            ModelToolStripMenuItem6.Enabled = True
            Model_4_Radio.Enabled = True
            Model_5_Radio.Enabled = True
            Model_6_Radio.Enabled = True

            If ModelToolStripMenuItem4.Checked = True Then
                LETRASHACKER.ChangeNumberModel = 1
            ElseIf ModelToolStripMenuItem5.Checked = True Then
                LETRASHACKER.ChangeNumberModel = 2
            ElseIf ModelToolStripMenuItem6.Checked = True Then
                LETRASHACKER.ChangeNumberModel = 3
            End If

            If Model_4_Radio.Checked = True Then
                LETRASHACKER.ChangeNumberModel = 1
            ElseIf Model_5_Radio.Checked = True Then
                LETRASHACKER.ChangeNumberModel = 2
            ElseIf Model_6_Radio.Checked = True Then
                LETRASHACKER.ChangeNumberModel = 3
            End If

        End If
    End Sub

    Private Sub NUMBER_1()
        LETRASHACKER.ChangeNumberModel = 1
        ModelToolStripMenuItem4.Checked = True
        ModelToolStripMenuItem5.Checked = False
        ModelToolStripMenuItem6.Checked = False
        Model_4_Radio.Checked = True
        Model_5_Radio.Checked = False
        Model_6_Radio.Checked = False
        My.Computer.Audio.Play(My.Resources.Alert, AudioPlayMode.Background)
        NotifyIcon1.BalloonTipTitle = "Hacker Alphabet"
        NotifyIcon1.BalloonTipText = "Hacker Number Changed to: ¹²³⁴⁵⁶⁷⁸⁹⁰"
        NotifyIcon1.ShowBalloonTip(3000)
        NotifyIcon1.Visible = True
    End Sub
    Private Sub NUMBER_2()
        LETRASHACKER.ChangeNumberModel = 2
        ModelToolStripMenuItem4.Checked = False
        ModelToolStripMenuItem5.Checked = True
        ModelToolStripMenuItem6.Checked = False
        Model_4_Radio.Checked = False
        Model_5_Radio.Checked = True
        Model_6_Radio.Checked = False
        My.Computer.Audio.Play(My.Resources.Alert, AudioPlayMode.Background)
        NotifyIcon1.BalloonTipTitle = "Hacker Alphabet"
        NotifyIcon1.BalloonTipText = "Hacker Number Changed to: ①②③④⑤⑥⑦⑧⑨ⓞ"
        NotifyIcon1.ShowBalloonTip(3000)
        NotifyIcon1.Visible = True
    End Sub
    Private Sub NUMBER_3()
        LETRASHACKER.ChangeNumberModel = 3
        ModelToolStripMenuItem4.Checked = False
        ModelToolStripMenuItem5.Checked = False
        ModelToolStripMenuItem6.Checked = True
        Model_4_Radio.Checked = False
        Model_5_Radio.Checked = False
        Model_6_Radio.Checked = True
        My.Computer.Audio.Play(My.Resources.Alert, AudioPlayMode.Background)
        NotifyIcon1.BalloonTipTitle = "Hacker Alphabet"
        NotifyIcon1.BalloonTipText = "Hacker Number Changed to: ⅠⅡⅢⅣⅤⅥⅦⅧⅨ"
        NotifyIcon1.ShowBalloonTip(3000)
        NotifyIcon1.Visible = True
    End Sub
    Private Sub ModelToolStripMenuItem4_Click(sender As System.Object, e As System.EventArgs) Handles ModelToolStripMenuItem4.Click
        Call NUMBER_1()
    End Sub

    Private Sub ModelToolStripMenuItem5_Click(sender As System.Object, e As System.EventArgs) Handles ModelToolStripMenuItem5.Click
        Call NUMBER_2()
    End Sub

    Private Sub ModelToolStripMenuItem6_Click(sender As System.Object, e As System.EventArgs) Handles ModelToolStripMenuItem6.Click
        Call NUMBER_3()
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NotifyIcon1.ContextMenuStrip.Show(MousePosition.X, MousePosition.Y)
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            Me.WindowState = FormWindowState.Normal
            Me.Show()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub Icons_Timer_Tick(sender As System.Object, e As System.EventArgs) Handles Icons_Timer.Tick
        If Icon_Animation = 0 Then
            NotifyIcon1.Icon = My.Resources.HackerIconH
        ElseIf Icon_Animation = 1 Then
            NotifyIcon1.Icon = My.Resources.HackerIconR
            Icon_Animation = 2
        ElseIf Icon_Animation = 2 Then
            NotifyIcon1.Icon = My.Resources.HackerIconB
            Icon_Animation = 3
        ElseIf Icon_Animation = 3 Then
            NotifyIcon1.Icon = My.Resources.HackerIconY
            Icon_Animation = 4
        ElseIf Icon_Animation = 4 Then
            NotifyIcon1.Icon = My.Resources.HackerIconP
            Icon_Animation = 5
        ElseIf Icon_Animation = 5 Then
            NotifyIcon1.Icon = My.Resources.HackerIconO
            Icon_Animation = 6
        ElseIf Icon_Animation = 6 Then
            NotifyIcon1.Icon = My.Resources.HackerIconBL
            Icon_Animation = 1
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Hide_btn.Click
        Me.Hide()
    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LOCAT = e.Location
        End If
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - LOCAT
        End If
    End Sub
    Private Sub Label2_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LOCAT = e.Location
        End If
    End Sub
    Private Sub Label2_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - LOCAT
        End If
    End Sub

    Private Sub ON_OFF_Switch_Click(sender As Object, e As System.EventArgs) Handles ON_OFF_Switch.Click
        If ON_OFF_Switch.Checked = True Then
            Start_()
        Else
            Stop_()
        End If
    End Sub

    Private Sub Model_1_Radio_Click(sender As Object, e As System.EventArgs) Handles Model_1_Radio.Click
        Call LETTER_1()
    End Sub

    Private Sub Model_2_Radio_Click(sender As Object, e As System.EventArgs) Handles Model_2_Radio.Click
        Call LETTER_2()
    End Sub

    Private Sub Model_3_Radio_Click(sender As Object, e As System.EventArgs) Handles Model_3_Radio.Click
        Call LETTER_3()
    End Sub

    Private Sub Model_4_Radio_Click(sender As Object, e As System.EventArgs) Handles Model_4_Radio.Click
        Call NUMBER_1()
    End Sub

    Private Sub Model_5_Radio_Click(sender As Object, e As System.EventArgs) Handles Model_5_Radio.Click
        Call NUMBER_2()
    End Sub

    Private Sub Model_6_Radio_Click(sender As Object, e As System.EventArgs) Handles Model_6_Radio.Click
        Call NUMBER_3()
    End Sub

    
    Private Sub Opacity_Trb_Scroll(sender As System.Object, e As System.EventArgs) Handles Opacity_Trb.Scroll
        If Opacity_Trb.Value < 1 Then
            Me.Opacity = 0.1
        Else
            Me.Opacity = Opacity_Trb.Value / 10
            Opacity_lbl.Text = "Opacity: " & CDbl(Opacity_Trb.Value * 10) & "%"
            My.Settings.Opacity = Opacity_Trb.Value / 10
            My.Settings.Save()

        End If
    End Sub
    Private PICINT As Integer = 0
    Private Sub Logo_Animation_Timer_Tick(sender As System.Object, e As System.EventArgs) Handles Logo_Animation_Timer.Tick
        If PICINT = 0 Then
            LogoFile_Pic.Image = My.Resources.HackerIconB.ToBitmap
            PICINT = 1

        ElseIf PICINT = 1 Then
            LogoFile_Pic.Image = My.Resources.HackerIconBL.ToBitmap
            PICINT = 2

        ElseIf PICINT = 2 Then
            LogoFile_Pic.Image = My.Resources.HackerIconH.ToBitmap
            PICINT = 3

        ElseIf PICINT = 3 Then
            LogoFile_Pic.Image = My.Resources.HackerIconO.ToBitmap
            PICINT = 4

        ElseIf PICINT = 4 Then
            LogoFile_Pic.Image = My.Resources.HackerIconP.ToBitmap
            PICINT = 5

        ElseIf PICINT = 5 Then
            LogoFile_Pic.Image = My.Resources.HackerIconR.ToBitmap
            PICINT = 6

        ElseIf PICINT = 6 Then
            LogoFile_Pic.Image = My.Resources.HackerIconY.ToBitmap
            PICINT = 0
        End If
    End Sub
End Class
