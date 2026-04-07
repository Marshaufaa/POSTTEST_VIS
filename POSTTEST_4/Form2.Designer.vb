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
        pbFotoProfil = New PictureBox()
        lblNamaHasil = New Label()
        lblIDHasil = New Label()
        lblGrupHasil = New Label()
        lblKontakHasil = New Label()
        lblHobiHasil = New Label()
        lblAlamatHasil = New Label()
        PictureBox1 = New PictureBox()
        CType(pbFotoProfil, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbFotoProfil
        ' 
        pbFotoProfil.Location = New Point(13, 125)
        pbFotoProfil.Name = "pbFotoProfil"
        pbFotoProfil.Size = New Size(198, 192)
        pbFotoProfil.SizeMode = PictureBoxSizeMode.StretchImage
        pbFotoProfil.TabIndex = 0
        pbFotoProfil.TabStop = False
        ' 
        ' lblNamaHasil
        ' 
        lblNamaHasil.AutoSize = True
        lblNamaHasil.Font = New Font("Bell MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNamaHasil.Location = New Point(230, 125)
        lblNamaHasil.Name = "lblNamaHasil"
        lblNamaHasil.Size = New Size(80, 28)
        lblNamaHasil.TabIndex = 1
        lblNamaHasil.Text = "Label1"
        ' 
        ' lblIDHasil
        ' 
        lblIDHasil.AutoSize = True
        lblIDHasil.Font = New Font("Bell MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIDHasil.Location = New Point(230, 163)
        lblIDHasil.Name = "lblIDHasil"
        lblIDHasil.Size = New Size(80, 28)
        lblIDHasil.TabIndex = 2
        lblIDHasil.Text = "Label1"
        ' 
        ' lblGrupHasil
        ' 
        lblGrupHasil.AutoSize = True
        lblGrupHasil.Font = New Font("Bell MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGrupHasil.Location = New Point(230, 203)
        lblGrupHasil.Name = "lblGrupHasil"
        lblGrupHasil.Size = New Size(80, 28)
        lblGrupHasil.TabIndex = 3
        lblGrupHasil.Text = "Label1"
        ' 
        ' lblKontakHasil
        ' 
        lblKontakHasil.AutoSize = True
        lblKontakHasil.Font = New Font("Bell MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKontakHasil.Location = New Point(230, 242)
        lblKontakHasil.Name = "lblKontakHasil"
        lblKontakHasil.Size = New Size(80, 28)
        lblKontakHasil.TabIndex = 4
        lblKontakHasil.Text = "Label1"
        ' 
        ' lblHobiHasil
        ' 
        lblHobiHasil.AutoSize = True
        lblHobiHasil.BackColor = Color.Transparent
        lblHobiHasil.Font = New Font("Bell MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHobiHasil.Location = New Point(13, 332)
        lblHobiHasil.MaximumSize = New Size(605, 0)
        lblHobiHasil.Name = "lblHobiHasil"
        lblHobiHasil.Size = New Size(80, 28)
        lblHobiHasil.TabIndex = 5
        lblHobiHasil.Text = "Label1"
        ' 
        ' lblAlamatHasil
        ' 
        lblAlamatHasil.AutoSize = True
        lblAlamatHasil.Font = New Font("Bell MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAlamatHasil.Location = New Point(13, 423)
        lblAlamatHasil.MaximumSize = New Size(605, 0)
        lblAlamatHasil.Name = "lblAlamatHasil"
        lblAlamatHasil.Size = New Size(80, 28)
        lblAlamatHasil.TabIndex = 6
        lblAlamatHasil.Text = "Label1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-3, -11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(685, 121)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(11F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(675, 545)
        Controls.Add(PictureBox1)
        Controls.Add(lblAlamatHasil)
        Controls.Add(lblHobiHasil)
        Controls.Add(lblKontakHasil)
        Controls.Add(lblGrupHasil)
        Controls.Add(lblIDHasil)
        Controls.Add(lblNamaHasil)
        Controls.Add(pbFotoProfil)
        Font = New Font("Cascadia Code", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "NCTzen Official Membership"
        CType(pbFotoProfil, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbFotoProfil As PictureBox
    Friend WithEvents lblNamaHasil As Label
    Friend WithEvents lblIDHasil As Label
    Friend WithEvents lblGrupHasil As Label
    Friend WithEvents lblKontakHasil As Label
    Friend WithEvents lblHobiHasil As Label
    Friend WithEvents lblAlamatHasil As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
