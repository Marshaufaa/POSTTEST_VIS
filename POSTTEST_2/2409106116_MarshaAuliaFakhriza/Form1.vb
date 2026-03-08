Public Class Form1

    Dim daftarJudul(99) As String
    Dim daftarGenre(99) As String
    Dim totalBuku As Integer = 0

    Private Sub TampilkanBuku()

        ListBox1.Items.Clear()

        For i As Integer = 0 To totalBuku - 1
            ListBox1.Items.Add(daftarJudul(i) & " (" & daftarGenre(i) & ")")
        Next

    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        If txtJudul.Text = "" Or txtGenre.Text = "" Then
            MessageBox.Show("Harus Ada Input")
        Else

            If totalBuku < daftarJudul.Length Then
                daftarJudul(totalBuku) = txtJudul.Text
                daftarGenre(totalBuku) = txtGenre.Text
                totalBuku = totalBuku + 1
            End If

            TampilkanBuku()

            txtJudul.Clear()
            txtGenre.Clear()

        End If

    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Dim judulDicari As String = txtHapus.Text
        Dim ada As Boolean = False

        For i As Integer = 0 To totalBuku - 1

            If daftarJudul(i) = judulDicari Then

                ada = True

                For j As Integer = i To totalBuku - 2
                    daftarJudul(j) = daftarJudul(j + 1)
                    daftarGenre(j) = daftarGenre(j + 1)
                Next

                totalBuku = totalBuku - 1
                Exit For

            End If

        Next

        If ada = False Then
            MessageBox.Show("Tidak ada Juddul Di List INI")
        End If

        TampilkanBuku()
        txtHapus.Clear()

    End Sub

End Class