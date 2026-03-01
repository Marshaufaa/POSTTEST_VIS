Public Class Form1
    Dim totalIP As Double = 0.0
    Dim jumlahSemester As Integer = 0

    Private Sub btntbh_Click(sender As Object, e As EventArgs) Handles btntbh.Click
        Dim nilaiInput As Double
        Dim hasilIPK As Double
        Dim statusPredikat As String = ""
        Dim teksInput As String = txtIPSmt.Text.Replace(".", ",")

        If Double.TryParse(teksInput, nilaiInput) Then
            jumlahSemester += 1
            totalIP += nilaiInput

            hasilIPK = totalIP / jumlahSemester
            txtIpk.Text = hasilIPK.ToString("N2")

            If hasilIPK >= 3.01 And hasilIPK <= 4.0 Then
                statusPredikat = "Sangat Memuaskan"
            ElseIf hasilIPK >= 2.76 And hasilIPK <= 3.0 Then
                statusPredikat = "Memuaskan"
            ElseIf hasilIPK >= 2.0 And hasilIPK <= 2.75 Then
                statusPredikat = "Cukup"
            Else
                statusPredikat = "Di Bawah Standar"
            End If

            lblPredikat.Text = statusPredikat
            txtIPSmt.Clear()
            txtIPSmt.Focus()
        Else
            MessageBox.Show("Silakan masukkan format angka yang benar!", "Peringatan")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        totalIP = 0
        jumlahSemester = 0

        txtIPSmt.Clear()
        txtIpk.Clear()
        lblPredikat.Text = "-"
    End Sub
End Class