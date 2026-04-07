<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        pbLogo = New PictureBox()
        lblJudull = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label1 = New Label()
        cbGrup = New ComboBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        lblGender = New Label()
        DateTimePicker1 = New DateTimePicker()
        lblTgl = New Label()
        txtID = New TextBox()
        lblId = New Label()
        txtNama = New TextBox()
        lblNama = New Label()
        TabPage2 = New TabPage()
        txtAlamat = New TextBox()
        lblAlamat = New Label()
        txtEmail = New TextBox()
        lblEmail = New Label()
        mtbTelepon = New MaskedTextBox()
        lblNoTelpon = New Label()
        TabPage3 = New TabPage()
        btnSimpan = New Button()
        gbAktivitas = New GroupBox()
        cbJurnal = New CheckBox()
        cbRP = New CheckBox()
        cbMasak = New CheckBox()
        cbAlbum = New CheckBox()
        cbDance = New CheckBox()
        cbNyanyi = New CheckBox()
        cbVlog = New CheckBox()
        cbStreaming = New CheckBox()
        GroupBox1 = New GroupBox()
        rbDancer = New RadioButton()
        rbVokal = New RadioButton()
        rbVisual = New RadioButton()
        btnBrowse = New Button()
        pbFoto = New PictureBox()
        ofdFoto = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        MenuStrip1.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        gbAktivitas.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(8, 2, 0, 2)
        MenuStrip1.Size = New Size(938, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(110, 29)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(109, 29)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(128, 29)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(106, 29)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(74, 29)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' pbLogo
        ' 
        pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), Image)
        pbLogo.Location = New Point(0, 35)
        pbLogo.Margin = New Padding(3, 4, 3, 4)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(71, 61)
        pbLogo.SizeMode = PictureBoxSizeMode.StretchImage
        pbLogo.TabIndex = 2
        pbLogo.TabStop = False
        ' 
        ' lblJudull
        ' 
        lblJudull.AutoSize = True
        lblJudull.Font = New Font("Cascadia Code", 24.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudull.ForeColor = Color.Black
        lblJudull.Location = New Point(77, 35)
        lblJudull.Name = "lblJudull"
        lblJudull.Size = New Size(528, 52)
        lblJudull.TabIndex = 3
        lblJudull.Text = "Neo Culture Technology"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(14, 103)
        TabControl1.Margin = New Padding(3, 4, 3, 4)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(910, 450)
        TabControl1.TabIndex = 4
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(cbGrup)
        TabPage1.Controls.Add(rbPerempuan)
        TabPage1.Controls.Add(rbLaki)
        TabPage1.Controls.Add(lblGender)
        TabPage1.Controls.Add(DateTimePicker1)
        TabPage1.Controls.Add(lblTgl)
        TabPage1.Controls.Add(txtID)
        TabPage1.Controls.Add(lblId)
        TabPage1.Controls.Add(txtNama)
        TabPage1.Controls.Add(lblNama)
        TabPage1.Location = New Point(4, 36)
        TabPage1.Margin = New Padding(3, 4, 3, 4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3, 4, 3, 4)
        TabPage1.Size = New Size(902, 410)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(26, 255)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 27)
        Label1.TabIndex = 10
        Label1.Text = "Grup"
        ' 
        ' cbGrup
        ' 
        cbGrup.DropDownStyle = ComboBoxStyle.DropDownList
        cbGrup.FormattingEnabled = True
        cbGrup.Items.AddRange(New Object() {"NCT 127", "NCT Dream", "WayV", "NCT Wish"})
        cbGrup.Location = New Point(206, 247)
        cbGrup.Margin = New Padding(3, 4, 3, 4)
        cbGrup.Name = "cbGrup"
        cbGrup.Size = New Size(220, 35)
        cbGrup.TabIndex = 9
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.ForeColor = SystemColors.ActiveCaptionText
        rbPerempuan.Location = New Point(364, 188)
        rbPerempuan.Margin = New Padding(3, 4, 3, 4)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(141, 31)
        rbPerempuan.TabIndex = 8
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.ForeColor = SystemColors.ActiveCaptionText
        rbLaki.Location = New Point(206, 188)
        rbLaki.Margin = New Padding(3, 4, 3, 4)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(141, 31)
        rbLaki.TabIndex = 7
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.ForeColor = SystemColors.ActiveCaptionText
        lblGender.Location = New Point(26, 193)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(168, 27)
        lblGender.TabIndex = 6
        lblGender.Text = "Jenis Kelamin"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(206, 134)
        DateTimePicker1.Margin = New Padding(3, 4, 3, 4)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(300, 31)
        DateTimePicker1.TabIndex = 5
        ' 
        ' lblTgl
        ' 
        lblTgl.AutoSize = True
        lblTgl.ForeColor = SystemColors.ActiveCaptionText
        lblTgl.Location = New Point(26, 143)
        lblTgl.Name = "lblTgl"
        lblTgl.Size = New Size(120, 27)
        lblTgl.TabIndex = 4
        lblTgl.Text = "Tgl Lahir"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(206, 83)
        txtID.Margin = New Padding(3, 4, 3, 4)
        txtID.Name = "txtID"
        txtID.PlaceholderText = "ID Member"
        txtID.Size = New Size(266, 31)
        txtID.TabIndex = 3
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.ForeColor = SystemColors.ActiveCaptionText
        lblId.Location = New Point(26, 93)
        lblId.Name = "lblId"
        lblId.Size = New Size(120, 27)
        lblId.TabIndex = 2
        lblId.Text = "ID Member"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(206, 38)
        txtNama.Margin = New Padding(3, 4, 3, 4)
        txtNama.Name = "txtNama"
        txtNama.PlaceholderText = "Nama"
        txtNama.Size = New Size(266, 31)
        txtNama.TabIndex = 1
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.ForeColor = SystemColors.ActiveCaptionText
        lblNama.Location = New Point(26, 41)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(60, 27)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(txtAlamat)
        TabPage2.Controls.Add(lblAlamat)
        TabPage2.Controls.Add(txtEmail)
        TabPage2.Controls.Add(lblEmail)
        TabPage2.Controls.Add(mtbTelepon)
        TabPage2.Controls.Add(lblNoTelpon)
        TabPage2.Location = New Point(4, 34)
        TabPage2.Margin = New Padding(3, 4, 3, 4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3, 4, 3, 4)
        TabPage2.Size = New Size(902, 412)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(142, 139)
        txtAlamat.Margin = New Padding(3, 4, 3, 4)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.PlaceholderText = "Jalan jalan ke simpang siur"
        txtAlamat.Size = New Size(534, 236)
        txtAlamat.TabIndex = 5
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.ForeColor = SystemColors.ActiveCaptionText
        lblAlamat.Location = New Point(27, 139)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(84, 27)
        lblAlamat.TabIndex = 4
        lblAlamat.Text = "Alamat"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(460, 49)
        txtEmail.Margin = New Padding(3, 4, 3, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "jae@nct.com"
        txtEmail.Size = New Size(335, 31)
        txtEmail.TabIndex = 3
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.ForeColor = SystemColors.ActiveCaptionText
        lblEmail.Location = New Point(370, 52)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(72, 27)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email"
        ' 
        ' mtbTelepon
        ' 
        mtbTelepon.Location = New Point(142, 48)
        mtbTelepon.Margin = New Padding(3, 4, 3, 4)
        mtbTelepon.Mask = "0000-0000-0000"
        mtbTelepon.Name = "mtbTelepon"
        mtbTelepon.Size = New Size(199, 31)
        mtbTelepon.TabIndex = 1
        ' 
        ' lblNoTelpon
        ' 
        lblNoTelpon.AutoSize = True
        lblNoTelpon.ForeColor = SystemColors.ActiveCaptionText
        lblNoTelpon.Location = New Point(27, 48)
        lblNoTelpon.Name = "lblNoTelpon"
        lblNoTelpon.Size = New Size(96, 27)
        lblNoTelpon.TabIndex = 0
        lblNoTelpon.Text = "No Telp"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(btnSimpan)
        TabPage3.Controls.Add(gbAktivitas)
        TabPage3.Controls.Add(GroupBox1)
        TabPage3.Controls.Add(btnBrowse)
        TabPage3.Controls.Add(pbFoto)
        TabPage3.Location = New Point(4, 36)
        TabPage3.Margin = New Padding(3, 4, 3, 4)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(902, 410)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = SystemColors.ActiveCaptionText
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(248, 324)
        btnSimpan.Margin = New Padding(3, 4, 3, 4)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(292, 59)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "Simpan dan Cetak Kartu"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' gbAktivitas
        ' 
        gbAktivitas.Controls.Add(cbJurnal)
        gbAktivitas.Controls.Add(cbRP)
        gbAktivitas.Controls.Add(cbMasak)
        gbAktivitas.Controls.Add(cbAlbum)
        gbAktivitas.Controls.Add(cbDance)
        gbAktivitas.Controls.Add(cbNyanyi)
        gbAktivitas.Controls.Add(cbVlog)
        gbAktivitas.Controls.Add(cbStreaming)
        gbAktivitas.Location = New Point(248, 109)
        gbAktivitas.Margin = New Padding(3, 4, 3, 4)
        gbAktivitas.Name = "gbAktivitas"
        gbAktivitas.Padding = New Padding(3, 4, 3, 4)
        gbAktivitas.Size = New Size(518, 207)
        gbAktivitas.TabIndex = 3
        gbAktivitas.TabStop = False
        gbAktivitas.Text = "Hobi"
        ' 
        ' cbJurnal
        ' 
        cbJurnal.AutoSize = True
        cbJurnal.Location = New Point(154, 115)
        cbJurnal.Margin = New Padding(3, 4, 3, 4)
        cbJurnal.Name = "cbJurnal"
        cbJurnal.Size = New Size(142, 31)
        cbJurnal.TabIndex = 7
        cbJurnal.Text = "Jurnaling"
        cbJurnal.UseVisualStyleBackColor = True
        ' 
        ' cbRP
        ' 
        cbRP.AutoSize = True
        cbRP.Location = New Point(311, 76)
        cbRP.Margin = New Padding(3, 4, 3, 4)
        cbRP.Name = "cbRP"
        cbRP.Size = New Size(130, 31)
        cbRP.TabIndex = 6
        cbRP.Text = "RolePlay"
        cbRP.UseVisualStyleBackColor = True
        ' 
        ' cbMasak
        ' 
        cbMasak.AutoSize = True
        cbMasak.Location = New Point(16, 115)
        cbMasak.Margin = New Padding(3, 4, 3, 4)
        cbMasak.Name = "cbMasak"
        cbMasak.Size = New Size(94, 31)
        cbMasak.TabIndex = 5
        cbMasak.Text = "Masak"
        cbMasak.UseVisualStyleBackColor = True
        ' 
        ' cbAlbum
        ' 
        cbAlbum.AutoSize = True
        cbAlbum.Location = New Point(311, 38)
        cbAlbum.Margin = New Padding(3, 4, 3, 4)
        cbAlbum.Name = "cbAlbum"
        cbAlbum.Size = New Size(202, 31)
        cbAlbum.TabIndex = 4
        cbAlbum.Text = "Ngoleksi Album"
        cbAlbum.UseVisualStyleBackColor = True
        ' 
        ' cbDance
        ' 
        cbDance.AutoSize = True
        cbDance.Location = New Point(154, 76)
        cbDance.Margin = New Padding(3, 4, 3, 4)
        cbDance.Name = "cbDance"
        cbDance.Size = New Size(94, 31)
        cbDance.TabIndex = 3
        cbDance.Text = "Dance"
        cbDance.UseVisualStyleBackColor = True
        ' 
        ' cbNyanyi
        ' 
        cbNyanyi.AutoSize = True
        cbNyanyi.Location = New Point(154, 38)
        cbNyanyi.Margin = New Padding(3, 4, 3, 4)
        cbNyanyi.Name = "cbNyanyi"
        cbNyanyi.Size = New Size(142, 31)
        cbNyanyi.TabIndex = 2
        cbNyanyi.Text = "Bernyanyi"
        cbNyanyi.UseVisualStyleBackColor = True
        ' 
        ' cbVlog
        ' 
        cbVlog.AutoSize = True
        cbVlog.Location = New Point(16, 76)
        cbVlog.Margin = New Padding(3, 4, 3, 4)
        cbVlog.Name = "cbVlog"
        cbVlog.Size = New Size(82, 31)
        cbVlog.TabIndex = 1
        cbVlog.Text = "Vlog"
        cbVlog.UseVisualStyleBackColor = True
        ' 
        ' cbStreaming
        ' 
        cbStreaming.AutoSize = True
        cbStreaming.Location = New Point(16, 38)
        cbStreaming.Margin = New Padding(3, 4, 3, 4)
        cbStreaming.Name = "cbStreaming"
        cbStreaming.Size = New Size(142, 31)
        cbStreaming.TabIndex = 0
        cbStreaming.Text = "Streaming"
        cbStreaming.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbDancer)
        GroupBox1.Controls.Add(rbVokal)
        GroupBox1.Controls.Add(rbVisual)
        GroupBox1.Location = New Point(248, 21)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(348, 81)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Pilihan Peran"
        ' 
        ' rbDancer
        ' 
        rbDancer.AutoSize = True
        rbDancer.Location = New Point(230, 35)
        rbDancer.Margin = New Padding(3, 4, 3, 4)
        rbDancer.Name = "rbDancer"
        rbDancer.Size = New Size(105, 31)
        rbDancer.TabIndex = 2
        rbDancer.TabStop = True
        rbDancer.Text = "Dancer"
        rbDancer.UseVisualStyleBackColor = True
        ' 
        ' rbVokal
        ' 
        rbVokal.AutoSize = True
        rbVokal.Location = New Point(131, 35)
        rbVokal.Margin = New Padding(3, 4, 3, 4)
        rbVokal.Name = "rbVokal"
        rbVokal.Size = New Size(93, 31)
        rbVokal.TabIndex = 1
        rbVokal.TabStop = True
        rbVokal.Text = "Vokal"
        rbVokal.UseVisualStyleBackColor = True
        ' 
        ' rbVisual
        ' 
        rbVisual.AutoSize = True
        rbVisual.Location = New Point(20, 35)
        rbVisual.Margin = New Padding(3, 4, 3, 4)
        rbVisual.Name = "rbVisual"
        rbVisual.Size = New Size(105, 31)
        rbVisual.TabIndex = 0
        rbVisual.TabStop = True
        rbVisual.Text = "Visual"
        rbVisual.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.Black
        btnBrowse.ForeColor = Color.White
        btnBrowse.Location = New Point(14, 263)
        btnBrowse.Margin = New Padding(3, 4, 3, 4)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(196, 72)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' pbFoto
        ' 
        pbFoto.BorderStyle = BorderStyle.FixedSingle
        pbFoto.Location = New Point(14, 21)
        pbFoto.Margin = New Padding(3, 4, 3, 4)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(196, 234)
        pbFoto.SizeMode = PictureBoxSizeMode.StretchImage
        pbFoto.TabIndex = 0
        pbFoto.TabStop = False
        ' 
        ' ofdFoto
        ' 
        ofdFoto.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12.0F, 27.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        ClientSize = New Size(938, 598)
        Controls.Add(TabControl1)
        Controls.Add(lblJudull)
        Controls.Add(pbLogo)
        Controls.Add(MenuStrip1)
        Font = New Font("Cascadia Code", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = SystemColors.ActiveCaptionText
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "NCTzen Official Membership"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        gbAktivitas.ResumeLayout(False)
        gbAktivitas.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents lblJudull As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblTgl As Label
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents lblGender As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents cbGrup As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNoTelpon As Label
    Friend WithEvents mtbTelepon As MaskedTextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents ofdFoto As OpenFileDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbDancer As RadioButton
    Friend WithEvents rbVokal As RadioButton
    Friend WithEvents rbVisual As RadioButton
    Friend WithEvents gbAktivitas As GroupBox
    Friend WithEvents cbAlbum As CheckBox
    Friend WithEvents cbDance As CheckBox
    Friend WithEvents cbNyanyi As CheckBox
    Friend WithEvents cbVlog As CheckBox
    Friend WithEvents cbStreaming As CheckBox
    Friend WithEvents cbJurnal As CheckBox
    Friend WithEvents cbRP As CheckBox
    Friend WithEvents cbMasak As CheckBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog

End Class
