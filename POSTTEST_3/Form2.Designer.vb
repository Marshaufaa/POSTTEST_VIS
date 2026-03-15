<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        pic = New PictureBox()
        lblNama = New Label()
        lblUmur = New Label()
        lblTgl = New Label()
        lblNoTelp = New Label()
        lblAlamat = New Label()
        lblGender = New Label()
        lblHobiHasil = New Label()
        CType(pic, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pic
        ' 
        pic.BorderStyle = BorderStyle.FixedSingle
        pic.Location = New Point(58, 82)
        pic.Margin = New Padding(3, 2, 3, 2)
        pic.Name = "pic"
        pic.Size = New Size(282, 274)
        pic.SizeMode = PictureBoxSizeMode.StretchImage
        pic.TabIndex = 16
        pic.TabStop = False
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.Location = New Point(403, 105)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(19, 25)
        lblNama.TabIndex = 17
        lblNama.Text = "-"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.BackColor = Color.Transparent
        lblUmur.Location = New Point(403, 134)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(19, 25)
        lblUmur.TabIndex = 18
        lblUmur.Text = "-"
        ' 
        ' lblTgl
        ' 
        lblTgl.AutoSize = True
        lblTgl.BackColor = Color.Transparent
        lblTgl.Location = New Point(477, 162)
        lblTgl.Name = "lblTgl"
        lblTgl.Size = New Size(19, 25)
        lblTgl.TabIndex = 19
        lblTgl.Text = "-"
        ' 
        ' lblNoTelp
        ' 
        lblNoTelp.AutoSize = True
        lblNoTelp.BackColor = Color.Transparent
        lblNoTelp.Location = New Point(438, 189)
        lblNoTelp.Name = "lblNoTelp"
        lblNoTelp.Size = New Size(19, 25)
        lblNoTelp.TabIndex = 20
        lblNoTelp.Text = "-"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.BackColor = Color.Transparent
        lblAlamat.Location = New Point(419, 218)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(19, 25)
        lblAlamat.TabIndex = 21
        lblAlamat.Text = "-"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.BackColor = Color.Transparent
        lblGender.Location = New Point(477, 268)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(19, 25)
        lblGender.TabIndex = 22
        lblGender.Text = "-"
        ' 
        ' lblHobiHasil
        ' 
        lblHobiHasil.AutoSize = True
        lblHobiHasil.BackColor = Color.Transparent
        lblHobiHasil.Location = New Point(419, 295)
        lblHobiHasil.Name = "lblHobiHasil"
        lblHobiHasil.Size = New Size(19, 25)
        lblHobiHasil.TabIndex = 23
        lblHobiHasil.Text = "-"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(732, 452)
        Controls.Add(lblHobiHasil)
        Controls.Add(lblGender)
        Controls.Add(lblAlamat)
        Controls.Add(lblNoTelp)
        Controls.Add(lblTgl)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(pic)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form2"
        Text = "License Travel Card"
        CType(pic, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pic As PictureBox
    Public WithEvents lblNama As Label
    Public WithEvents lblUmur As Label
    Public WithEvents lblTgl As Label
    Public WithEvents lblNoTelp As Label
    Public WithEvents lblAlamat As Label
    Public WithEvents lblGender As Label
    Friend WithEvents lblHobiHasil As Label
End Class
