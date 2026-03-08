Public Module DataBuku

    Public daftarJudul(99) As String
    Public daftarGenre(99) As String
    Public totalBuku As Integer = 0

    Public Sub TambahDataBuku(ByVal jdl As String, ByVal gnr As String)

        If totalBuku < daftarJudul.Length Then
            daftarJudul(totalBuku) = jdl
            daftarGenre(totalBuku) = gnr
            totalBuku = totalBuku + 1
        End If

    End Sub

End Module
