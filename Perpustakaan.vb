Public Class Perpustakaan
    Public Shared JenisKoleksi As New List(Of String) From {"Buku", "Ensikopledia", "Koran", "Majalah", "Publikasi"}
    Public Shared koleksi = New Koleksi
    Public Shared selectedDataKoleksi
    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama

    Private koleksiDataTabel As New ArrayList()

    Private Sub BTNInsertKoleksi_Click(sender As Object, e As EventArgs) Handles BTNInsertKoleksi.Click
        TambahKoleksi.Show()
    End Sub
    Private Sub TSBtnTambahKoleksi_Click(sender As Object, e As EventArgs) Handles TSBtnTambahKoleksi.Click
        TambahKoleksi.Show()
    End Sub

    Private Sub TSBtnHapusKoleksi_Click(sender As Object, e As EventArgs) Handles TSBtnHapusKoleksi.Click
        HapusKoleksi.Show()
    End Sub

    Private Sub BTNUpdateKoleksi_Click(sender As Object, e As EventArgs) Handles BTNUpdateKoleksi.Click
        UpdateKoleksi.Show()
    End Sub

    Private Sub BTNSelectKoleksi_Click(sender As Object, e As EventArgs) Handles BTNSelectKoleksi.Click
        Dim selectedKoleksi As List(Of String) = koleksi.GetDataKoleksiByIDDatabase(selectedTableKoleksi)

        koleksi.GSFoto = selectedKoleksi(2)
        koleksi.GSnama = selectedKoleksi(1)
        koleksi.GSjenis = selectedKoleksi(5)
        koleksi.GSdeskripsi = selectedKoleksi(3)
        koleksi.GSpenerbit = selectedKoleksi(4)
        koleksi.GStahun = selectedKoleksi(6)
        koleksi.GSlokasi = selectedKoleksi(7)
        koleksi.GStanggalMasuk = selectedKoleksi(8)
        koleksi.GSstok = selectedKoleksi(9)
        koleksi.GSbahasa = selectedKoleksi(10)
        Dim data_kategori As List(Of String) = koleksi.ConvertStringToKoleksi(selectedKoleksi(11))

        koleksi.GSKategori = data_kategori

        Dim InfoTambah = New InfoKoleksi()
        InfoTambah.Show()
    End Sub

    Private Sub BTNRemoveKoleksi_Click(sender As Object, e As EventArgs) Handles BTNRemoveKoleksi.Click
        HapusKoleksi.Show()
    End Sub

    Private Sub Perpustakaan_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UpdateDataTableArrayList()
        ReloadDataTableDatabase()
    End Sub

    Public Sub UpdateDataTableArrayList()
        'DataGridKoleksi.Rows.Clear()
        For Each rowKoleksi In koleksi.getKoleksiDataTable()
            Dim dataTable As String() = {
            rowKoleksi(1),
            rowKoleksi(2),
            rowKoleksi(3),
            rowKoleksi(4),
            rowKoleksi(5),
            rowKoleksi(6),
            rowKoleksi(7),
            rowKoleksi(8),
            rowKoleksi(9),
            rowKoleksi(10),
            rowKoleksi(11)
            }
            DataGridKoleksi.Rows.Add(dataTable)
        Next
    End Sub

    Private Sub ReloadDataTableDatabase()
        DataGridKoleksi.DataSource = koleksi.GetDataKoleksiDatabase()
    End Sub

    Private Sub DataGridKoleksi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridKoleksi.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridKoleksi.Rows(index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub


End Class
