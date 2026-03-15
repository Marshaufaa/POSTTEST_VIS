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
        picProfile = New PictureBox()
        btnBrowse = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtNama = New TextBox()
        txtUmur = New TextBox()
        txtNoTelp = New TextBox()
        txtAlamat = New TextBox()
        lblTglLahir = New Label()
        dtpTanggal = New DateTimePicker()
        btnCetak = New Button()
        gbGender = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        gbHobby = New GroupBox()
        CheckBox10 = New CheckBox()
        CheckBox9 = New CheckBox()
        CheckBox8 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        CType(picProfile, ComponentModel.ISupportInitialize).BeginInit()
        gbGender.SuspendLayout()
        gbHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' picProfile
        ' 
        picProfile.BorderStyle = BorderStyle.FixedSingle
        picProfile.Location = New Point(10, 51)
        picProfile.Margin = New Padding(2, 3, 2, 3)
        picProfile.Name = "picProfile"
        picProfile.Size = New Size(282, 274)
        picProfile.SizeMode = PictureBoxSizeMode.StretchImage
        picProfile.TabIndex = 0
        picProfile.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(191, 336)
        btnBrowse.Margin = New Padding(2, 3, 2, 3)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(101, 25)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Cari Foto"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Location = New Point(317, 47)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 21)
        Label1.TabIndex = 2
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(317, 88)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 21)
        Label2.TabIndex = 3
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(317, 164)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 21)
        Label3.TabIndex = 4
        Label3.Text = "No. Telp"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(317, 202)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 21)
        Label4.TabIndex = 5
        Label4.Text = "Alamat"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(429, 47)
        txtNama.Margin = New Padding(2, 3, 2, 3)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(260, 27)
        txtNama.TabIndex = 6
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(429, 88)
        txtUmur.Margin = New Padding(2, 3, 2, 3)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(60, 27)
        txtUmur.TabIndex = 7
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.Location = New Point(429, 164)
        txtNoTelp.Margin = New Padding(2, 3, 2, 3)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(260, 27)
        txtNoTelp.TabIndex = 8
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(429, 202)
        txtAlamat.Margin = New Padding(2, 3, 2, 3)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(260, 40)
        txtAlamat.TabIndex = 9
        ' 
        ' lblTglLahir
        ' 
        lblTglLahir.AutoSize = True
        lblTglLahir.BackColor = Color.Transparent
        lblTglLahir.Location = New Point(317, 127)
        lblTglLahir.Margin = New Padding(2, 0, 2, 0)
        lblTglLahir.Name = "lblTglLahir"
        lblTglLahir.Size = New Size(107, 21)
        lblTglLahir.TabIndex = 10
        lblTglLahir.Text = "Tanggal Lahir"
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Location = New Point(429, 127)
        dtpTanggal.Margin = New Padding(2, 3, 2, 3)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(260, 27)
        dtpTanggal.TabIndex = 11
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.DarkGoldenrod
        btnCetak.ForeColor = Color.White
        btnCetak.Location = New Point(471, 412)
        btnCetak.Margin = New Padding(2, 3, 2, 3)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(218, 44)
        btnCetak.TabIndex = 12
        btnCetak.Text = "Print Kartu"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' gbGender
        ' 
        gbGender.Controls.Add(rbPerempuan)
        gbGender.Controls.Add(rbLaki)
        gbGender.Location = New Point(540, 258)
        gbGender.Margin = New Padding(2, 3, 2, 3)
        gbGender.Name = "gbGender"
        gbGender.Padding = New Padding(2, 3, 2, 3)
        gbGender.Size = New Size(149, 134)
        gbGender.TabIndex = 13
        gbGender.TabStop = False
        gbGender.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(5, 55)
        rbPerempuan.Margin = New Padding(2, 3, 2, 3)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(110, 25)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(5, 26)
        rbLaki.Margin = New Padding(2, 3, 2, 3)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(105, 25)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki - Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' gbHobby
        ' 
        gbHobby.Controls.Add(CheckBox10)
        gbHobby.Controls.Add(CheckBox9)
        gbHobby.Controls.Add(CheckBox8)
        gbHobby.Controls.Add(CheckBox7)
        gbHobby.Controls.Add(CheckBox6)
        gbHobby.Controls.Add(CheckBox5)
        gbHobby.Controls.Add(CheckBox4)
        gbHobby.Controls.Add(CheckBox3)
        gbHobby.Controls.Add(CheckBox2)
        gbHobby.Controls.Add(CheckBox1)
        gbHobby.Location = New Point(317, 247)
        gbHobby.Margin = New Padding(2, 3, 2, 3)
        gbHobby.Name = "gbHobby"
        gbHobby.Padding = New Padding(2, 3, 2, 3)
        gbHobby.Size = New Size(218, 145)
        gbHobby.TabIndex = 14
        gbHobby.TabStop = False
        gbHobby.Text = "Hobby"
        ' 
        ' CheckBox10
        ' 
        CheckBox10.AutoSize = True
        CheckBox10.Location = New Point(105, 108)
        CheckBox10.Margin = New Padding(2, 3, 2, 3)
        CheckBox10.Name = "CheckBox10"
        CheckBox10.Size = New Size(101, 25)
        CheckBox10.TabIndex = 9
        CheckBox10.Text = "Menyanyi"
        CheckBox10.UseVisualStyleBackColor = True
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.Location = New Point(105, 89)
        CheckBox9.Margin = New Padding(2, 3, 2, 3)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(82, 25)
        CheckBox9.TabIndex = 8
        CheckBox9.Text = "Menari"
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(105, 67)
        CheckBox8.Margin = New Padding(2, 3, 2, 3)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(87, 25)
        CheckBox8.TabIndex = 7
        CheckBox8.Text = "Melukis"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(105, 45)
        CheckBox7.Margin = New Padding(2, 3, 2, 3)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(126, 25)
        CheckBox7.TabIndex = 6
        CheckBox7.Text = "Menggambar"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(105, 26)
        CheckBox6.Margin = New Padding(2, 3, 2, 3)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(98, 25)
        CheckBox6.TabIndex = 5
        CheckBox6.Text = "Olahraga"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(8, 108)
        CheckBox5.Margin = New Padding(2, 3, 2, 3)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(97, 25)
        CheckBox5.TabIndex = 4
        CheckBox5.Text = "Traveling"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(8, 89)
        CheckBox4.Margin = New Padding(2, 3, 2, 3)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(99, 25)
        CheckBox4.TabIndex = 3
        CheckBox4.Text = "Membaca"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(8, 67)
        CheckBox3.Margin = New Padding(2, 3, 2, 3)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(92, 25)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Mancing"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(8, 45)
        CheckBox2.Margin = New Padding(2, 3, 2, 3)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(82, 25)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Nonton"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(8, 23)
        CheckBox1.Margin = New Padding(2, 3, 2, 3)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(87, 25)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Gaming"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Wheat
        ClientSize = New Size(700, 461)
        Controls.Add(gbHobby)
        Controls.Add(gbGender)
        Controls.Add(btnCetak)
        Controls.Add(dtpTanggal)
        Controls.Add(lblTglLahir)
        Controls.Add(txtAlamat)
        Controls.Add(txtNoTelp)
        Controls.Add(txtUmur)
        Controls.Add(txtNama)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnBrowse)
        Controls.Add(picProfile)
        Font = New Font("Tw Cen MT Condensed Extra Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(2, 3, 2, 3)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Travel License Card"
        CType(picProfile, ComponentModel.ISupportInitialize).EndInit()
        gbGender.ResumeLayout(False)
        gbGender.PerformLayout()
        gbHobby.ResumeLayout(False)
        gbHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picProfile As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNoTelp As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents lblTglLahir As Label
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents btnCetak As Button
    Friend WithEvents gbGender As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents gbHobby As GroupBox
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox

End Class
