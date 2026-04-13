<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuUtamaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPageInput = New System.Windows.Forms.TabPage()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.dtpTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numHarga = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numDurasi = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLokasi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNamaPenyewa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPageData = New System.Windows.Forms.TabPage()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()

        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageInput.SuspendLayout()
        CType(Me.numHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDurasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageData.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' --- MenuStrip1 ---
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuUtamaToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"

        ' --- MenuUtamaToolStripMenuItem ---
        Me.MenuUtamaToolStripMenuItem.Name = "MenuUtamaToolStripMenuItem"
        Me.MenuUtamaToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.MenuUtamaToolStripMenuItem.Text = "Halaman Utama"

        ' --- KeluarToolStripMenuItem ---
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"

        ' --- TabControl1 ---
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPageInput)
        Me.TabControl1.Controls.Add(Me.TabPageData)
        Me.TabControl1.Location = New System.Drawing.Point(12, 38)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(760, 411)
        Me.TabControl1.TabIndex = 1

        ' --- TabPageInput (Form Tambah/Edit) ---
        Me.TabPageInput.Controls.Add(Me.lblID)
        Me.TabPageInput.Controls.Add(Me.btnSimpan)
        Me.TabPageInput.Controls.Add(Me.dtpTanggal)
        Me.TabPageInput.Controls.Add(Me.Label5)
        Me.TabPageInput.Controls.Add(Me.numHarga)
        Me.TabPageInput.Controls.Add(Me.Label4)
        Me.TabPageInput.Controls.Add(Me.numDurasi)
        Me.TabPageInput.Controls.Add(Me.Label3)
        Me.TabPageInput.Controls.Add(Me.txtLokasi)
        Me.TabPageInput.Controls.Add(Me.Label2)
        Me.TabPageInput.Controls.Add(Me.txtNamaPenyewa)
        Me.TabPageInput.Controls.Add(Me.Label1)
        Me.TabPageInput.Location = New System.Drawing.Point(4, 24)
        Me.TabPageInput.Name = "TabPageInput"
        Me.TabPageInput.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageInput.Size = New System.Drawing.Size(752, 383)
        Me.TabPageInput.TabIndex = 0
        Me.TabPageInput.Text = "Form Input"
        Me.TabPageInput.UseVisualStyleBackColor = True

        ' --- Label & Input: Nama Penyewa ---
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 15)
        Me.Label1.Text = "Nama Penyewa"

        Me.txtNamaPenyewa.Location = New System.Drawing.Point(150, 27)
        Me.txtNamaPenyewa.Name = "txtNamaPenyewa"
        Me.txtNamaPenyewa.Size = New System.Drawing.Size(300, 23)

        ' --- Label & Input: Lokasi Videotron ---
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.Text = "Lokasi Videotron"

        Me.txtLokasi.Location = New System.Drawing.Point(150, 67)
        Me.txtLokasi.Name = "txtLokasi"
        Me.txtLokasi.Size = New System.Drawing.Size(300, 23)

        ' --- Label & Input: Durasi Sewa ---
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 15)
        Me.Label3.Text = "Durasi Sewa (Hari)"

        Me.numDurasi.Location = New System.Drawing.Point(150, 107)
        Me.numDurasi.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numDurasi.Name = "numDurasi"
        Me.numDurasi.Size = New System.Drawing.Size(100, 23)

        ' --- Label & Input: Harga ---
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 15)
        Me.Label4.Text = "Harga (Rp)"

        Me.numHarga.Location = New System.Drawing.Point(150, 147)
        Me.numHarga.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0}) ' Set maksimal harga tinggi
        Me.numHarga.Name = "numHarga"
        Me.numHarga.Size = New System.Drawing.Size(200, 23)
        Me.numHarga.DecimalPlaces = 2
        Me.numHarga.ThousandsSeparator = True

        ' --- Label & Input: Tanggal Sewa ---
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.Text = "Tanggal Sewa"

        Me.dtpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpTanggal.Location = New System.Drawing.Point(150, 187)
        Me.dtpTanggal.Name = "dtpTanggal"
        Me.dtpTanggal.Size = New System.Drawing.Size(200, 23)

        ' --- lblID (Hidden State untuk Edit Mode) ---
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(150, 220)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(13, 15)
        Me.lblID.Text = "0"
        Me.lblID.Visible = False

        ' --- Button Simpan ---
        Me.btnSimpan.Location = New System.Drawing.Point(150, 245)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(120, 35)
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True

        ' --- TabPageData (Grid & Pencarian) ---
        Me.TabPageData.Controls.Add(Me.btnHapus)
        Me.TabPageData.Controls.Add(Me.btnEdit)
        Me.TabPageData.Controls.Add(Me.dgvData)
        Me.TabPageData.Controls.Add(Me.txtSearch)
        Me.TabPageData.Controls.Add(Me.Label6)
        Me.TabPageData.Location = New System.Drawing.Point(4, 24)
        Me.TabPageData.Name = "TabPageData"
        Me.TabPageData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageData.Size = New System.Drawing.Size(752, 383)
        Me.TabPageData.TabIndex = 1
        Me.TabPageData.Text = "Data Penyewaan"
        Me.TabPageData.UseVisualStyleBackColor = True

        ' --- Label & Input Search ---
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.Text = "Cari Data:"

        Me.txtSearch.Location = New System.Drawing.Point(79, 17)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(300, 23)

        ' --- DataGridView ---
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(15, 55)
        Me.dgvData.MultiSelect = False
        Me.dgvData.Name = "dgvData"
        Me.dgvData.ReadOnly = True
        Me.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvData.Size = New System.Drawing.Size(720, 275)

        ' --- Button Edit ---
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Location = New System.Drawing.Point(15, 340)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(90, 30)
        Me.btnEdit.Text = "Edit Data"
        Me.btnEdit.UseVisualStyleBackColor = True

        ' --- Button Hapus ---
        Me.btnHapus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHapus.Location = New System.Drawing.Point(111, 340)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(90, 30)
        Me.btnHapus.Text = "Hapus Data"
        Me.btnHapus.UseVisualStyleBackColor = True

        ' --- Form1 (Konfigurasi Utama) ---
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Manajemen Penyewaan Videotron"

        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageInput.ResumeLayout(False)
        Me.TabPageInput.PerformLayout()
        CType(Me.numHarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDurasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageData.ResumeLayout(False)
        Me.TabPageData.PerformLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuUtamaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPageInput As TabPage
    Friend WithEvents TabPageData As TabPage

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNamaPenyewa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLokasi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents numDurasi As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents numHarga As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents btnSimpan As Button
    Friend WithEvents lblID As Label

    Friend WithEvents Label6 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button

End Class