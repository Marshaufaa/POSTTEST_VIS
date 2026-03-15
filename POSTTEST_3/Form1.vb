Public Class Form1


    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub validasiAngka_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress, txtNoTelp.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFile As New OpenFileDialog()
        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        If openFile.ShowDialog() = DialogResult.OK Then
            picProfile.Image = Image.FromFile(openFile.FileName)
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Dim listHobi As New List(Of String)
        For Each ctrl As Control In gbHobby.Controls
            If TypeOf ctrl Is CheckBox AndAlso DirectCast(ctrl, CheckBox).Checked Then
                listHobi.Add(DirectCast(ctrl, CheckBox).Text)
            End If
        Next
        Dim daftarHobi As String = String.Join(", ", listHobi)

        If txtNama.Text = "" Or txtUmur.Text = "" Or txtNoTelp.Text = "" Or txtAlamat.Text = "" Or
           picProfile.Image Is Nothing Or (Not rbLaki.Checked And Not rbPerempuan.Checked) Or
           daftarHobi = "" Then

            MessageBox.Show("Inputan tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim f2 As New Form2()

        f2.lblNama.Text = txtNama.Text
        f2.lblUmur.Text = txtUmur.Text & " Tahun"
        f2.lblTgl.Text = dtpTanggal.Value.ToString("dd/MM/yyyy")
        f2.lblNoTelp.Text = txtNoTelp.Text
        f2.lblAlamat.Text = txtAlamat.Text
        f2.lblGender.Text = If(rbLaki.Checked, "Laki - Laki", "Perempuan")
        f2.lblHobiHasil.Text = daftarHobi
        f2.pic.Image = picProfile.Image

        f2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class