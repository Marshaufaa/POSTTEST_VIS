<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtJudul = New System.Windows.Forms.TextBox()
		Me.txtGenre = New System.Windows.Forms.TextBox()
		Me.txtHapus = New System.Windows.Forms.TextBox()
		Me.btnTambah = New System.Windows.Forms.Button()
		Me.btnHapus = New System.Windows.Forms.Button()
		Me.ListBox1 = New System.Windows.Forms.ListBox()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.btnTambah)
		Me.GroupBox1.Controls.Add(Me.txtGenre)
		Me.GroupBox1.Controls.Add(Me.txtJudul)
		Me.GroupBox1.Controls.Add(Me.Label2)
		Me.GroupBox1.Controls.Add(Me.Label1)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 65)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(337, 222)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Tambah Buku"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.btnHapus)
		Me.GroupBox2.Controls.Add(Me.txtHapus)
		Me.GroupBox2.Controls.Add(Me.Label3)
		Me.GroupBox2.Location = New System.Drawing.Point(451, 65)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(337, 222)
		Me.GroupBox2.TabIndex = 1
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Hapus Buku"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(39, 58)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(88, 20)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Judul Buku"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(39, 126)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(54, 20)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Genre"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(35, 101)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(88, 20)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Judul Buku"
		'
		'txtJudul
		'
		Me.txtJudul.Location = New System.Drawing.Point(187, 58)
		Me.txtJudul.Name = "txtJudul"
		Me.txtJudul.Size = New System.Drawing.Size(125, 26)
		Me.txtJudul.TabIndex = 2
		'
		'txtGenre
		'
		Me.txtGenre.Location = New System.Drawing.Point(187, 126)
		Me.txtGenre.Name = "txtGenre"
		Me.txtGenre.Size = New System.Drawing.Size(125, 26)
		Me.txtGenre.TabIndex = 3
		'
		'txtHapus
		'
		Me.txtHapus.Location = New System.Drawing.Point(177, 98)
		Me.txtHapus.Name = "txtHapus"
		Me.txtHapus.Size = New System.Drawing.Size(125, 26)
		Me.txtHapus.TabIndex = 4
		'
		'btnTambah
		'
		Me.btnTambah.Location = New System.Drawing.Point(120, 183)
		Me.btnTambah.Name = "btnTambah"
		Me.btnTambah.Size = New System.Drawing.Size(90, 33)
		Me.btnTambah.TabIndex = 4
		Me.btnTambah.Text = "Tambah"
		Me.btnTambah.UseVisualStyleBackColor = True
		'
		'btnHapus
		'
		Me.btnHapus.Location = New System.Drawing.Point(132, 183)
		Me.btnHapus.Name = "btnHapus"
		Me.btnHapus.Size = New System.Drawing.Size(90, 33)
		Me.btnHapus.TabIndex = 5
		Me.btnHapus.Text = "Hapus"
		Me.btnHapus.UseVisualStyleBackColor = True
		'
		'ListBox1
		'
		Me.ListBox1.FormattingEnabled = True
		Me.ListBox1.ItemHeight = 20
		Me.ListBox1.Location = New System.Drawing.Point(214, 328)
		Me.ListBox1.Name = "ListBox1"
		Me.ListBox1.Size = New System.Drawing.Size(393, 244)
		Me.ListBox1.TabIndex = 2
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1002, 618)
		Me.Controls.Add(Me.ListBox1)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents btnTambah As Button
	Friend WithEvents txtGenre As TextBox
	Friend WithEvents txtJudul As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents btnHapus As Button
	Friend WithEvents txtHapus As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents ListBox1 As ListBox
End Class
