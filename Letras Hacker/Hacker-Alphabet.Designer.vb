<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hack_Alphabet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hack_Alphabet))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Control_Box_Nine1 = New ToolsBox.Control_Box_Nine()
        Me.LogoFile_Pic = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Hide_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Icons_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModelToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModelToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModelToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModelToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModelToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModelToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IniciarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PararToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Close_btn = New System.Windows.Forms.Button()
        Me.Letters_GB = New System.Windows.Forms.GroupBox()
        Me.Model_3_Radio = New System.Windows.Forms.RadioButton()
        Me.Model_2_Radio = New System.Windows.Forms.RadioButton()
        Me.Model_1_Radio = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Model_6_Radio = New System.Windows.Forms.RadioButton()
        Me.Model_5_Radio = New System.Windows.Forms.RadioButton()
        Me.Model_4_Radio = New System.Windows.Forms.RadioButton()
        Me.ON_OFF_LBL = New System.Windows.Forms.Label()
        Me.ON_OFF_Switch = New ToolsBox.Switch_Vizual_White()
        Me.NUMBER_ACTIVATE_SWITCH = New ToolsBox.Switch_Vizual_White()
        Me.Ativate_Number_lbl = New System.Windows.Forms.Label()
        Me.Opacity_lbl = New System.Windows.Forms.Label()
        Me.Opacity_Trb = New System.Windows.Forms.TrackBar()
        Me.Logo_Animation_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.LogoFile_Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Letters_GB.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Opacity_Trb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Control_Box_Nine1)
        Me.Panel1.Controls.Add(Me.LogoFile_Pic)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(430, 22)
        Me.Panel1.TabIndex = 0
        '
        'Control_Box_Nine1
        '
        Me.Control_Box_Nine1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Control_Box_Nine1.ControlButton = ToolsBox.Control_Box_Nine.Button.Close
        Me.Control_Box_Nine1.ControlColor = -20
        Me.Control_Box_Nine1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Control_Box_Nine1.Customization = ""
        Me.Control_Box_Nine1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Control_Box_Nine1.Image = Nothing
        Me.Control_Box_Nine1.ItemColor = System.Drawing.Color.White
        Me.Control_Box_Nine1.Location = New System.Drawing.Point(410, 6)
        Me.Control_Box_Nine1.Margin = New System.Windows.Forms.Padding(0)
        Me.Control_Box_Nine1.MaximumSize = New System.Drawing.Size(13, 13)
        Me.Control_Box_Nine1.MinimumSize = New System.Drawing.Size(10, 10)
        Me.Control_Box_Nine1.Name = "Control_Box_Nine1"
        Me.Control_Box_Nine1.NoRounding = False
        Me.Control_Box_Nine1.Size = New System.Drawing.Size(13, 13)
        Me.Control_Box_Nine1.TabIndex = 26
        Me.Control_Box_Nine1.Text = "Control_Box_Nine1"
        Me.Control_Box_Nine1.Transparent = False
        '
        'LogoFile_Pic
        '
        Me.LogoFile_Pic.Location = New System.Drawing.Point(8, 3)
        Me.LogoFile_Pic.Name = "LogoFile_Pic"
        Me.LogoFile_Pic.Size = New System.Drawing.Size(16, 16)
        Me.LogoFile_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoFile_Pic.TabIndex = 26
        Me.LogoFile_Pic.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hacker Alphabet - Configuration."
        '
        'Hide_btn
        '
        Me.Hide_btn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Hide_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Hide_btn.FlatAppearance.BorderSize = 0
        Me.Hide_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Hide_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Hide_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Hide_btn.Location = New System.Drawing.Point(224, 283)
        Me.Hide_btn.Name = "Hide_btn"
        Me.Hide_btn.Size = New System.Drawing.Size(94, 35)
        Me.Hide_btn.TabIndex = 1
        Me.Hide_btn.Text = "Hide"
        Me.Hide_btn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(297, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "HotKey Select:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"F1", "F2", "F3", "F4", "F5 ", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "Alt + F1", "Alt + F2", "Alt + F3", "Alt + F4", "Alt + F5", "Alt + F6", "Alt + F7", "Alt + F8", "Alt + F9", "Alt + F10", "Alt + F11", "Alt + F12", "Ctr + F1", "Ctr + F2", "Ctr + F3", "Ctr + F4", "Ctr + F5", "Ctr + F6", "Ctr + F7", "Ctr + F8", "Ctr + F9", "Ctr + F10", "Ctr + F11", "Ctr + F12", "Shift + F1", "Shift + F2", "Shift + F3", "Shift + F4", "Shift + F5", "Shift + F6", "Shift + F7", "Shift + F8", "Shift + F9", "Shift + F10", "Shift + F11", "Shift + F12"})
        Me.ComboBox1.Location = New System.Drawing.Point(300, 87)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Icons_Timer
        '
        Me.Icons_Timer.Enabled = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ContextMenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ContextMenuStrip1.DropShadowEnabled = False
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ChangeToolStripMenuItem, Me.IniciarToolStripMenuItem, Me.PararToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ContextMenuStrip1.ShowItemToolTips = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(116, 114)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.OpenToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.OpenToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OpenToolStripMenuItem.Image = Global.Hacker_Alphabet.My.Resources.Resources.Open_16px
        Me.OpenToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ChangeToolStripMenuItem
        '
        Me.ChangeToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ChangeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModelToolStripMenuItem, Me.ModelToolStripMenuItem1, Me.ModelToolStripMenuItem2, Me.ModelToolStripMenuItem3, Me.ModelToolStripMenuItem4, Me.ModelToolStripMenuItem5, Me.ModelToolStripMenuItem6})
        Me.ChangeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ChangeToolStripMenuItem.Image = Global.Hacker_Alphabet.My.Resources.Resources.change_16x16
        Me.ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem"
        Me.ChangeToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ChangeToolStripMenuItem.Text = "Change"
        '
        'ModelToolStripMenuItem
        '
        Me.ModelToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ModelToolStripMenuItem.Checked = True
        Me.ModelToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ModelToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ModelToolStripMenuItem.Name = "ModelToolStripMenuItem"
        Me.ModelToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.ModelToolStripMenuItem.Text = "Model: 〒ễ§ŧ ℓεŧ†Эπֆ"
        '
        'ModelToolStripMenuItem1
        '
        Me.ModelToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ModelToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ModelToolStripMenuItem1.Name = "ModelToolStripMenuItem1"
        Me.ModelToolStripMenuItem1.Size = New System.Drawing.Size(237, 22)
        Me.ModelToolStripMenuItem1.Text = "Model: ⓣⓔⓢⓣ ⓛⓔⓣⓣⓔⓡ"
        '
        'ModelToolStripMenuItem2
        '
        Me.ModelToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ModelToolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ModelToolStripMenuItem2.Name = "ModelToolStripMenuItem2"
        Me.ModelToolStripMenuItem2.Size = New System.Drawing.Size(237, 22)
        Me.ModelToolStripMenuItem2.Text = "Model: ŧєیŧ ℓєŧŧєя"
        '
        'ModelToolStripMenuItem3
        '
        Me.ModelToolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ModelToolStripMenuItem3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ModelToolStripMenuItem3.Name = "ModelToolStripMenuItem3"
        Me.ModelToolStripMenuItem3.Size = New System.Drawing.Size(237, 22)
        Me.ModelToolStripMenuItem3.Text = "Ativate Number"
        '
        'ModelToolStripMenuItem4
        '
        Me.ModelToolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ModelToolStripMenuItem4.Checked = True
        Me.ModelToolStripMenuItem4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ModelToolStripMenuItem4.Enabled = False
        Me.ModelToolStripMenuItem4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ModelToolStripMenuItem4.Name = "ModelToolStripMenuItem4"
        Me.ModelToolStripMenuItem4.Size = New System.Drawing.Size(237, 22)
        Me.ModelToolStripMenuItem4.Text = "Model: ¹²³⁴⁵⁶⁷⁸⁹⁰"
        '
        'ModelToolStripMenuItem5
        '
        Me.ModelToolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ModelToolStripMenuItem5.Enabled = False
        Me.ModelToolStripMenuItem5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ModelToolStripMenuItem5.Name = "ModelToolStripMenuItem5"
        Me.ModelToolStripMenuItem5.Size = New System.Drawing.Size(237, 22)
        Me.ModelToolStripMenuItem5.Text = "Model: ①②③④⑤⑥⑦⑧⑨ⓞ"
        '
        'ModelToolStripMenuItem6
        '
        Me.ModelToolStripMenuItem6.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ModelToolStripMenuItem6.Enabled = False
        Me.ModelToolStripMenuItem6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ModelToolStripMenuItem6.Name = "ModelToolStripMenuItem6"
        Me.ModelToolStripMenuItem6.Size = New System.Drawing.Size(237, 22)
        Me.ModelToolStripMenuItem6.Text = "Model: ⅠⅡⅢⅣⅤⅥⅦⅧⅨ"
        '
        'IniciarToolStripMenuItem
        '
        Me.IniciarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.IniciarToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.IniciarToolStripMenuItem.Image = Global.Hacker_Alphabet.My.Resources.Resources.play_16x16
        Me.IniciarToolStripMenuItem.Name = "IniciarToolStripMenuItem"
        Me.IniciarToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.IniciarToolStripMenuItem.Text = "Start"
        '
        'PararToolStripMenuItem
        '
        Me.PararToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.PararToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PararToolStripMenuItem.Image = Global.Hacker_Alphabet.My.Resources.Resources.stop_16x16
        Me.PararToolStripMenuItem.Name = "PararToolStripMenuItem"
        Me.PararToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.PararToolStripMenuItem.Text = "Stop"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.SairToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SairToolStripMenuItem.Image = Global.Hacker_Alphabet.My.Resources.Resources.exit_16x16
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.SairToolStripMenuItem.Text = "Close"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Hacker Alphabet"
        Me.NotifyIcon1.BalloonTipTitle = "Hacker Alphabet"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Hacker Alphabet"
        Me.NotifyIcon1.Visible = True
        '
        'Close_btn
        '
        Me.Close_btn.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Close_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Close_btn.FlatAppearance.BorderSize = 0
        Me.Close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close_btn.Location = New System.Drawing.Point(324, 283)
        Me.Close_btn.Name = "Close_btn"
        Me.Close_btn.Size = New System.Drawing.Size(94, 35)
        Me.Close_btn.TabIndex = 9
        Me.Close_btn.Text = "Close Program."
        Me.Close_btn.UseVisualStyleBackColor = False
        '
        'Letters_GB
        '
        Me.Letters_GB.BackColor = System.Drawing.Color.Transparent
        Me.Letters_GB.Controls.Add(Me.Model_3_Radio)
        Me.Letters_GB.Controls.Add(Me.Model_2_Radio)
        Me.Letters_GB.Controls.Add(Me.Model_1_Radio)
        Me.Letters_GB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Letters_GB.ForeColor = System.Drawing.Color.Gainsboro
        Me.Letters_GB.Location = New System.Drawing.Point(10, 30)
        Me.Letters_GB.Name = "Letters_GB"
        Me.Letters_GB.Size = New System.Drawing.Size(270, 104)
        Me.Letters_GB.TabIndex = 18
        Me.Letters_GB.TabStop = False
        Me.Letters_GB.Text = "Letters"
        '
        'Model_3_Radio
        '
        Me.Model_3_Radio.AutoSize = True
        Me.Model_3_Radio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Model_3_Radio.Location = New System.Drawing.Point(16, 62)
        Me.Model_3_Radio.Name = "Model_3_Radio"
        Me.Model_3_Radio.Size = New System.Drawing.Size(128, 21)
        Me.Model_3_Radio.TabIndex = 2
        Me.Model_3_Radio.Text = "Model: ŧєیŧ ℓєŧŧєя"
        Me.Model_3_Radio.UseVisualStyleBackColor = True
        '
        'Model_2_Radio
        '
        Me.Model_2_Radio.AutoSize = True
        Me.Model_2_Radio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Model_2_Radio.Location = New System.Drawing.Point(16, 40)
        Me.Model_2_Radio.Name = "Model_2_Radio"
        Me.Model_2_Radio.Size = New System.Drawing.Size(225, 21)
        Me.Model_2_Radio.TabIndex = 1
        Me.Model_2_Radio.Text = "Model: ⓣⓔⓢⓣ ⓛⓔⓣⓣⓔⓡ"
        Me.Model_2_Radio.UseVisualStyleBackColor = True
        '
        'Model_1_Radio
        '
        Me.Model_1_Radio.AutoSize = True
        Me.Model_1_Radio.Checked = True
        Me.Model_1_Radio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Model_1_Radio.Location = New System.Drawing.Point(16, 19)
        Me.Model_1_Radio.Name = "Model_1_Radio"
        Me.Model_1_Radio.Size = New System.Drawing.Size(151, 21)
        Me.Model_1_Radio.TabIndex = 0
        Me.Model_1_Radio.TabStop = True
        Me.Model_1_Radio.Text = "Model: 〒ễ§ŧ ℓεŧ†Эπֆ"
        Me.Model_1_Radio.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.Model_6_Radio)
        Me.GroupBox1.Controls.Add(Me.Model_5_Radio)
        Me.GroupBox1.Controls.Add(Me.Model_4_Radio)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Location = New System.Drawing.Point(12, 169)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 97)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Numbers"
        '
        'Model_6_Radio
        '
        Me.Model_6_Radio.AutoSize = True
        Me.Model_6_Radio.Enabled = False
        Me.Model_6_Radio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Model_6_Radio.Location = New System.Drawing.Point(17, 62)
        Me.Model_6_Radio.Name = "Model_6_Radio"
        Me.Model_6_Radio.Size = New System.Drawing.Size(206, 21)
        Me.Model_6_Radio.TabIndex = 3
        Me.Model_6_Radio.Text = "Model: ⅠⅡⅢⅣⅤⅥⅦⅧⅨ"
        Me.Model_6_Radio.UseVisualStyleBackColor = True
        '
        'Model_5_Radio
        '
        Me.Model_5_Radio.AutoSize = True
        Me.Model_5_Radio.Enabled = False
        Me.Model_5_Radio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Model_5_Radio.Location = New System.Drawing.Point(17, 40)
        Me.Model_5_Radio.Name = "Model_5_Radio"
        Me.Model_5_Radio.Size = New System.Drawing.Size(221, 21)
        Me.Model_5_Radio.TabIndex = 2
        Me.Model_5_Radio.Text = "Model: ①②③④⑤⑥⑦⑧⑨ⓞ"
        Me.Model_5_Radio.UseVisualStyleBackColor = True
        '
        'Model_4_Radio
        '
        Me.Model_4_Radio.AutoSize = True
        Me.Model_4_Radio.Checked = True
        Me.Model_4_Radio.Enabled = False
        Me.Model_4_Radio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Model_4_Radio.Location = New System.Drawing.Point(17, 18)
        Me.Model_4_Radio.Name = "Model_4_Radio"
        Me.Model_4_Radio.Size = New System.Drawing.Size(121, 21)
        Me.Model_4_Radio.TabIndex = 1
        Me.Model_4_Radio.TabStop = True
        Me.Model_4_Radio.Text = "Model: ¹²³⁴⁵⁶⁷⁸⁹⁰"
        Me.Model_4_Radio.UseVisualStyleBackColor = True
        '
        'ON_OFF_LBL
        '
        Me.ON_OFF_LBL.AutoSize = True
        Me.ON_OFF_LBL.ForeColor = System.Drawing.Color.Lime
        Me.ON_OFF_LBL.Location = New System.Drawing.Point(346, 43)
        Me.ON_OFF_LBL.Name = "ON_OFF_LBL"
        Me.ON_OFF_LBL.Size = New System.Drawing.Size(23, 13)
        Me.ON_OFF_LBL.TabIndex = 20
        Me.ON_OFF_LBL.Text = "ON"
        '
        'ON_OFF_Switch
        '
        Me.ON_OFF_Switch.Checked = True
        Me.ON_OFF_Switch.Color = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ON_OFF_Switch.Color_Disabled = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ON_OFF_Switch.Color_Enabled = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ON_OFF_Switch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ON_OFF_Switch.Customization = ""
        Me.ON_OFF_Switch.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ON_OFF_Switch.Image = Nothing
        Me.ON_OFF_Switch.Location = New System.Drawing.Point(300, 40)
        Me.ON_OFF_Switch.Name = "ON_OFF_Switch"
        Me.ON_OFF_Switch.NoRounding = False
        Me.ON_OFF_Switch.Size = New System.Drawing.Size(35, 19)
        Me.ON_OFF_Switch.TabIndex = 21
        Me.ON_OFF_Switch.Text = "Switch_Vizual_White1"
        Me.ON_OFF_Switch.Transparent = False
        '
        'NUMBER_ACTIVATE_SWITCH
        '
        Me.NUMBER_ACTIVATE_SWITCH.Checked = False
        Me.NUMBER_ACTIVATE_SWITCH.Color = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.NUMBER_ACTIVATE_SWITCH.Color_Disabled = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.NUMBER_ACTIVATE_SWITCH.Color_Enabled = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.NUMBER_ACTIVATE_SWITCH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NUMBER_ACTIVATE_SWITCH.Customization = ""
        Me.NUMBER_ACTIVATE_SWITCH.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.NUMBER_ACTIVATE_SWITCH.Image = Nothing
        Me.NUMBER_ACTIVATE_SWITCH.Location = New System.Drawing.Point(12, 144)
        Me.NUMBER_ACTIVATE_SWITCH.Name = "NUMBER_ACTIVATE_SWITCH"
        Me.NUMBER_ACTIVATE_SWITCH.NoRounding = False
        Me.NUMBER_ACTIVATE_SWITCH.Size = New System.Drawing.Size(35, 19)
        Me.NUMBER_ACTIVATE_SWITCH.TabIndex = 22
        Me.NUMBER_ACTIVATE_SWITCH.Text = "Switch_Vizual_White2"
        Me.NUMBER_ACTIVATE_SWITCH.Transparent = False
        '
        'Ativate_Number_lbl
        '
        Me.Ativate_Number_lbl.AutoSize = True
        Me.Ativate_Number_lbl.ForeColor = System.Drawing.Color.Gainsboro
        Me.Ativate_Number_lbl.Location = New System.Drawing.Point(54, 147)
        Me.Ativate_Number_lbl.Name = "Ativate_Number_lbl"
        Me.Ativate_Number_lbl.Size = New System.Drawing.Size(86, 13)
        Me.Ativate_Number_lbl.TabIndex = 23
        Me.Ativate_Number_lbl.Text = "Activate Number"
        '
        'Opacity_lbl
        '
        Me.Opacity_lbl.AutoSize = True
        Me.Opacity_lbl.ForeColor = System.Drawing.Color.Gainsboro
        Me.Opacity_lbl.Location = New System.Drawing.Point(297, 121)
        Me.Opacity_lbl.Name = "Opacity_lbl"
        Me.Opacity_lbl.Size = New System.Drawing.Size(75, 13)
        Me.Opacity_lbl.TabIndex = 24
        Me.Opacity_lbl.Text = "Opacity: 100%"
        '
        'Opacity_Trb
        '
        Me.Opacity_Trb.Location = New System.Drawing.Point(300, 137)
        Me.Opacity_Trb.Name = "Opacity_Trb"
        Me.Opacity_Trb.Size = New System.Drawing.Size(126, 45)
        Me.Opacity_Trb.TabIndex = 25
        Me.Opacity_Trb.Value = 10
        '
        'Logo_Animation_Timer
        '
        Me.Logo_Animation_Timer.Enabled = True
        '
        'Hack_Alphabet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(430, 330)
        Me.Controls.Add(Me.Opacity_Trb)
        Me.Controls.Add(Me.Opacity_lbl)
        Me.Controls.Add(Me.Ativate_Number_lbl)
        Me.Controls.Add(Me.NUMBER_ACTIVATE_SWITCH)
        Me.Controls.Add(Me.ON_OFF_Switch)
        Me.Controls.Add(Me.ON_OFF_LBL)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Letters_GB)
        Me.Controls.Add(Me.Close_btn)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Hide_btn)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Hack_Alphabet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Choose"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LogoFile_Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Letters_GB.ResumeLayout(False)
        Me.Letters_GB.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Opacity_Trb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Hide_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Icons_Timer As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModelToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModelToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModelToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModelToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModelToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModelToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IniciarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PararToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Close_btn As System.Windows.Forms.Button
    Friend WithEvents Letters_GB As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ON_OFF_LBL As System.Windows.Forms.Label
    Friend WithEvents ON_OFF_Switch As ToolsBox.Switch_Vizual_White
    Friend WithEvents Model_3_Radio As System.Windows.Forms.RadioButton
    Friend WithEvents Model_2_Radio As System.Windows.Forms.RadioButton
    Friend WithEvents Model_1_Radio As System.Windows.Forms.RadioButton
    Friend WithEvents Model_6_Radio As System.Windows.Forms.RadioButton
    Friend WithEvents Model_5_Radio As System.Windows.Forms.RadioButton
    Friend WithEvents Model_4_Radio As System.Windows.Forms.RadioButton
    Friend WithEvents NUMBER_ACTIVATE_SWITCH As ToolsBox.Switch_Vizual_White
    Friend WithEvents Ativate_Number_lbl As System.Windows.Forms.Label
    Friend WithEvents Opacity_lbl As System.Windows.Forms.Label
    Friend WithEvents Opacity_Trb As System.Windows.Forms.TrackBar
    Friend WithEvents LogoFile_Pic As System.Windows.Forms.PictureBox
    Friend WithEvents Logo_Animation_Timer As System.Windows.Forms.Timer
    Friend WithEvents Control_Box_Nine1 As ToolsBox.Control_Box_Nine
End Class
