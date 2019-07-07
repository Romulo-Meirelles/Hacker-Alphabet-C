'Imports Letras_Hacker.KeyboardHook
Public Class Hacker_Alphabet

    Private WithEvents KeyHook As New KeyboardHook
    Private WithEvents LETRASHACKER As New Alphabet_Settings

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        Me.Hide()
        NotifyIcon1.BalloonTipTitle = "Hacker Alphabet"
        NotifyIcon1.BalloonTipText = "Hacker Letters started sucessful! To finish click on the right corner next to the system clock."
        NotifyIcon1.ShowBalloonTip(3000)
        NotifyIcon1.Visible = True

        'INICIA CLASS LETRASHACKER
        LETRASHACKER.KEYSACTIVATE(True)

        'DESATIVA INICIAR PORQUE JÁ FOI INICIADO
        IniciarToolStripMenuItem.Enabled = False

    End Sub
    Private Sub IniciarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles IniciarToolStripMenuItem.Click
        LETRASHACKER.KEYSACTIVATE(True)
        IniciarToolStripMenuItem.Enabled = False
        PararToolStripMenuItem.Enabled = True
        My.Computer.Audio.Play(My.Resources.Alert, AudioPlayMode.Background)
        NotifyIcon1.BalloonTipTitle = "Hacker Alphabet"
        NotifyIcon1.BalloonTipText = "▶ Hacker Alphabet started sucessful."
        NotifyIcon1.ShowBalloonTip(3000)
        NotifyIcon1.Visible = True

        If ModelToolStripMenuItem1.Checked = True Then
            LETRASHACKER.ChangeModel = 1
        ElseIf ModelToolStripMenuItem2.Checked = False Then
            LETRASHACKER.ChangeModel = 2
        ElseIf ModelToolStripMenuItem3.Checked = False Then
            LETRASHACKER.ChangeModel = 3
        End If
    End Sub
    Private Sub PararToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PararToolStripMenuItem.Click
        LETRASHACKER.KEYSACTIVATE(False)
        IniciarToolStripMenuItem.Enabled = True
        PararToolStripMenuItem.Enabled = False
        My.Computer.Audio.Play(My.Resources.Alert, AudioPlayMode.Background)
        NotifyIcon1.BalloonTipTitle = "Hacker Alphabet"
        NotifyIcon1.BalloonTipText = "■ Hacker Alphabet Stopped!"
        NotifyIcon1.ShowBalloonTip(3000)
        NotifyIcon1.Visible = True

    End Sub
    Private Sub SairToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SairToolStripMenuItem.Click
        End
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        LETRASHACKER.KEYSACTIVATE(False)
    End Sub

    Private Sub ModelToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ModelToolStripMenuItem.Click
        LETRASHACKER.ChangeModel = 1
        ModelToolStripMenuItem.Checked = True
        ModelToolStripMenuItem1.Checked = False
        ModelToolStripMenuItem2.Checked = False
        My.Computer.Audio.Play(My.Resources.Alert, AudioPlayMode.Background)
        NotifyIcon1.BalloonTipTitle = "Hacker Alphabet"
        NotifyIcon1.BalloonTipText = "Hacker Alphabet Changed to: 〒ễ§ŧ ℓεŧ†Эπֆ"
        NotifyIcon1.ShowBalloonTip(3000)
        NotifyIcon1.Visible = True
    End Sub

    Private Sub ModelToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ModelToolStripMenuItem1.Click
        LETRASHACKER.ChangeModel = 2
        ModelToolStripMenuItem.Checked = False
        ModelToolStripMenuItem1.Checked = True
        ModelToolStripMenuItem2.Checked = False
        My.Computer.Audio.Play(My.Resources.Alert, AudioPlayMode.Background)
        NotifyIcon1.BalloonTipTitle = "Hacker Alphabet"
        NotifyIcon1.BalloonTipText = "Hacker Alphabet Changed to: ⓣⓔⓢⓣ ⓛⓔⓣⓣⓔⓡ"
        NotifyIcon1.ShowBalloonTip(3000)
        NotifyIcon1.Visible = True
    End Sub

    Private Sub ModelToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ModelToolStripMenuItem2.Click
        LETRASHACKER.ChangeModel = 3
        ModelToolStripMenuItem.Checked = False
        ModelToolStripMenuItem1.Checked = False
        ModelToolStripMenuItem2.Checked = True
        My.Computer.Audio.Play(My.Resources.Alert, AudioPlayMode.Background)
        NotifyIcon1.BalloonTipTitle = "Hacker Alphabet"
        NotifyIcon1.BalloonTipText = "Hacker Alphabet Changed to: ŧєیŧ ℓєŧŧєя"
        NotifyIcon1.ShowBalloonTip(3000)
        NotifyIcon1.Visible = True
    End Sub

    Private Sub ModelToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ModelToolStripMenuItem3.Click
        If LETRASHACKER.NumberActivateBol = True Then
            My.Computer.Audio.Play(My.Resources.Alert, AudioPlayMode.Background)
            LETRASHACKER.NumberActivateBol = False
            ModelToolStripMenuItem3.Checked = False
            ModelToolStripMenuItem4.Enabled = False
            ModelToolStripMenuItem5.Enabled = False
            ModelToolStripMenuItem6.Enabled = False
            LETRASHACKER.ChangeNumberModel = 0

        Else
            My.Computer.Audio.Play(My.Resources.Alert, AudioPlayMode.Background)
            LETRASHACKER.NumberActivateBol = True
            ModelToolStripMenuItem3.Checked = True
            ModelToolStripMenuItem4.Enabled = True
            ModelToolStripMenuItem5.Enabled = True
            ModelToolStripMenuItem6.Enabled = True


            If ModelToolStripMenuItem4.Checked = True Then
                LETRASHACKER.ChangeNumberModel = 1
            ElseIf ModelToolStripMenuItem5.Checked = True Then
                LETRASHACKER.ChangeNumberModel = 2
            ElseIf ModelToolStripMenuItem6.Checked = True Then
                LETRASHACKER.ChangeNumberModel = 3

            End If
        End If
    End Sub

    Private Sub ModelToolStripMenuItem4_Click(sender As System.Object, e As System.EventArgs) Handles ModelToolStripMenuItem4.Click
        LETRASHACKER.ChangeNumberModel = 1
        ModelToolStripMenuItem4.Checked = True
        ModelToolStripMenuItem5.Checked = False
        ModelToolStripMenuItem6.Checked = False
        My.Computer.Audio.Play(My.Resources.Alert, AudioPlayMode.Background)
        NotifyIcon1.BalloonTipTitle = "Hacker Alphabet"
        NotifyIcon1.BalloonTipText = "Hacker Number Changed to: ¹²³⁴⁵⁶⁷⁸⁹⁰"
        NotifyIcon1.ShowBalloonTip(3000)
        NotifyIcon1.Visible = True
    End Sub

    Private Sub ModelToolStripMenuItem5_Click(sender As System.Object, e As System.EventArgs) Handles ModelToolStripMenuItem5.Click
        LETRASHACKER.ChangeNumberModel = 2
        ModelToolStripMenuItem4.Checked = False
        ModelToolStripMenuItem5.Checked = True
        ModelToolStripMenuItem6.Checked = False
        My.Computer.Audio.Play(My.Resources.Alert, AudioPlayMode.Background)
        NotifyIcon1.BalloonTipTitle = "Hacker Alphabet"
        NotifyIcon1.BalloonTipText = "Hacker Number Changed to: ①②③④⑤⑥⑦⑧⑨ⓞ"
        NotifyIcon1.ShowBalloonTip(3000)
        NotifyIcon1.Visible = True
    End Sub

    Private Sub ModelToolStripMenuItem6_Click(sender As System.Object, e As System.EventArgs) Handles ModelToolStripMenuItem6.Click
        LETRASHACKER.ChangeNumberModel = 3
        ModelToolStripMenuItem4.Checked = False
        ModelToolStripMenuItem5.Checked = False
        ModelToolStripMenuItem6.Checked = True
        My.Computer.Audio.Play(My.Resources.Alert, AudioPlayMode.Background)
        NotifyIcon1.BalloonTipTitle = "Hacker Alphabet"
        NotifyIcon1.BalloonTipText = "Hacker Number Changed to: ⅠⅡⅢⅣⅤⅥⅦⅧⅨ"
        NotifyIcon1.ShowBalloonTip(3000)
        NotifyIcon1.Visible = True
    End Sub

    Private Sub NotifyIcon1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            NotifyIcon1.ContextMenuStrip.Show(MousePosition.X, MousePosition.Y)
        End If
    End Sub

End Class
