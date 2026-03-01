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
		Me.btntbh = New System.Windows.Forms.Button()
		Me.btnReset = New System.Windows.Forms.Button()
		Me.txtIPSmt = New System.Windows.Forms.TextBox()
		Me.txtIpk = New System.Windows.Forms.TextBox()
		Me.lblIpSemester = New System.Windows.Forms.Label()
		Me.lblIpk = New System.Windows.Forms.Label()
		Me.lblPredikat = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btntbh
		'
		Me.btntbh.Location = New System.Drawing.Point(235, 156)
		Me.btntbh.Name = "btntbh"
		Me.btntbh.Size = New System.Drawing.Size(144, 55)
		Me.btntbh.TabIndex = 0
		Me.btntbh.Text = "Tambah"
		Me.btntbh.UseVisualStyleBackColor = True
		'
		'btnReset
		'
		Me.btnReset.Location = New System.Drawing.Point(432, 156)
		Me.btnReset.Name = "btnReset"
		Me.btnReset.Size = New System.Drawing.Size(144, 55)
		Me.btnReset.TabIndex = 1
		Me.btnReset.Text = "Reset"
		Me.btnReset.UseVisualStyleBackColor = True
		'
		'txtIPSmt
		'
		Me.txtIPSmt.Location = New System.Drawing.Point(235, 83)
		Me.txtIPSmt.Name = "txtIPSmt"
		Me.txtIPSmt.Size = New System.Drawing.Size(341, 26)
		Me.txtIPSmt.TabIndex = 2
		'
		'txtIpk
		'
		Me.txtIpk.Location = New System.Drawing.Point(235, 253)
		Me.txtIpk.Name = "txtIpk"
		Me.txtIpk.Size = New System.Drawing.Size(341, 26)
		Me.txtIpk.TabIndex = 3
		'
		'lblIpSemester
		'
		Me.lblIpSemester.AutoSize = True
		Me.lblIpSemester.Location = New System.Drawing.Point(40, 89)
		Me.lblIpSemester.Name = "lblIpSemester"
		Me.lblIpSemester.Size = New System.Drawing.Size(97, 20)
		Me.lblIpSemester.TabIndex = 4
		Me.lblIpSemester.Text = "IP Semester"
		'
		'lblIpk
		'
		Me.lblIpk.AutoSize = True
		Me.lblIpk.Location = New System.Drawing.Point(40, 259)
		Me.lblIpk.Name = "lblIpk"
		Me.lblIpk.Size = New System.Drawing.Size(94, 20)
		Me.lblIpk.TabIndex = 5
		Me.lblIpk.Text = "IP Kumulatif"
		'
		'lblPredikat
		'
		Me.lblPredikat.AutoSize = True
		Me.lblPredikat.Location = New System.Drawing.Point(232, 321)
		Me.lblPredikat.Name = "lblPredikat"
		Me.lblPredikat.Size = New System.Drawing.Size(0, 20)
		Me.lblPredikat.TabIndex = 6
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.lblPredikat)
		Me.Controls.Add(Me.lblIpk)
		Me.Controls.Add(Me.lblIpSemester)
		Me.Controls.Add(Me.txtIpk)
		Me.Controls.Add(Me.txtIPSmt)
		Me.Controls.Add(Me.btnReset)
		Me.Controls.Add(Me.btntbh)
		Me.Name = "Form1"
		Me.Text = "Kalkulator IP"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btntbh As Button
	Friend WithEvents btnReset As Button
	Friend WithEvents txtIPSmt As TextBox
	Friend WithEvents txtIpk As TextBox
	Friend WithEvents lblIpSemester As Label
	Friend WithEvents lblIpk As Label
	Friend WithEvents lblPredikat As Label
End Class
