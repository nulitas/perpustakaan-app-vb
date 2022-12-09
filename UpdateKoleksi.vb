Public Class UpdateKoleksi


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        PictureBox1.Load(Perpustakaan.koleksi.GSFoto)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        DTPTanggalMasukKoleksi.Format = DateTimePickerFormat.Custom
        DTPTanggalMasukKoleksi.CustomFormat = "yyyy/MM/dd"
        TXTNamaKoleksi.Text = Perpustakaan.koleksi.GSnama
        ComboJenisKoleksi.Text = Perpustakaan.koleksi.GSjenis
        RTXTDeskripsi.Text = Perpustakaan.koleksi.GSdeskripsi
        TXTPenerbit.Text = Perpustakaan.koleksi.GSpenerbit
        TXTLokasiRak.Text = Perpustakaan.koleksi.GSlokasi
        DTPTanggalMasukKoleksi.Value = Perpustakaan.koleksi.GStanggalMasuk
        TXTStock.Text = Perpustakaan.koleksi.GSstok

        If String.Compare(Perpustakaan.koleksi.GSbahasa, "Indonesia") = 0 Then
            RBBIndonesia.Checked = True
        ElseIf String.Compare(Perpustakaan.koleksi.GSbahasa, "Inggris") = 0 Then
            RBBInggris.Checked = True
        End If

        For Each kategoriItem In Perpustakaan.koleksi.GSkategori
            If String.Compare(kategoriItem, "Sains") Then
                CheckSains.Checked = True
            ElseIf String.Compare(kategoriItem, "Sosial") Then
                CheckSosial.Checked = True
            ElseIf String.Compare(kategoriItem, "Teknologi") Then
                CheckTeknologi.Checked = True
            ElseIf String.Compare(kategoriItem, "Budaya") Then
                CheckBudaya.Checked = True
            End If

        Next
        Perpustakaan.koleksi.GSkategori.Clear()
    End Sub

    Private Sub BTNTambahGambar_Click(sender As Object, e As EventArgs) Handles BTNTambahGambar.Click
        OpenFileDialog1.Title = "Pilih Foto"
        OpenFileDialog1.Filter = "All Format|*.*"
        OpenFileDialog1.ShowDialog()

        Dim picKoleksiDir As String = OpenFileDialog1.FileName

        PictureBox1.Load(picKoleksiDir)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Perpustakaan.koleksi.GSFoto = picKoleksiDir.ToString()
    End Sub

    Private Sub BTNUpdateKoleksi_Click(sender As Object, e As EventArgs) Handles BTNUpdateKoleksi.Click
        Perpustakaan.koleksi.GSnama = TXTNamaKoleksi.Text.ToString()
        Perpustakaan.koleksi.GSjenis = ComboJenisKoleksi.Text.ToString()
        Perpustakaan.koleksi.GSdeskripsi = RTXTDeskripsi.Text.ToString()
        Perpustakaan.koleksi.GSpenerbit = TXTPenerbit.Text.ToString()
        Perpustakaan.koleksi.GStahun = Integer.Parse(TXTTahunTerbit.Text)
        Perpustakaan.koleksi.GSlokasi = TXTLokasiRak.Text.ToString()
        Perpustakaan.koleksi.GStanggalMasuk = DTPTanggalMasukKoleksi.Value.ToString("yyyy/MM/dd")
        Perpustakaan.koleksi.GSstok = Integer.Parse(TXTStock.Text)

        If RBBIndonesia.Checked() Then
            Perpustakaan.koleksi.GSbahasa = "Bahasa Indonesia"
        End If
        If RBBInggris.Checked() Then
            Perpustakaan.koleksi.GSbahasa = "Bahasa Inggris"
        End If

        If CheckSains.Checked() Then
            Perpustakaan.koleksi.GSkategori.Add("Sains")
        End If
        If CheckSosial.Checked() Then
            Perpustakaan.koleksi.GSkategori.Add("Sosial")
        End If
        If CheckTeknologi.Checked() Then
            Perpustakaan.koleksi.GSkategori.Add("Teknologi")
        End If
        If CheckBudaya.Checked() Then
            Perpustakaan.koleksi.GSkategori.Add("Budaya")
        End If

        Dim convertedKoleksi = Perpustakaan.koleksi.ConvertKoleksiToString(Perpustakaan.koleksi.GSkategori)
        Perpustakaan.koleksi.UpdateDataKoleksiByIDDatabase(
        Perpustakaan.selectedTableKoleksi,
        Perpustakaan.koleksi.GSFoto,
        Perpustakaan.koleksi.GSnama,
        Perpustakaan.koleksi.GSjenis,
        Perpustakaan.koleksi.GSpenerbit,
        Perpustakaan.koleksi.GSdeskripsi,
        Perpustakaan.koleksi.GStahun,
        Perpustakaan.koleksi.GSlokasi,
        Perpustakaan.koleksi.GStanggalMasuk,
        Perpustakaan.koleksi.GSstok,
        Perpustakaan.koleksi.GSbahasa,
        convertedKoleksi
        )
        'Dim infoTambah = New FormInfoKoleksi()
        'infoTambah.Show()

        Me.Close()
    End Sub

    Private Sub TXTTahunTerbit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTTahunTerbit.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Masukan Angka")

        End If
    End Sub

    Private Sub TXTStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTStock.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MessageBox.Show("Masukan Angka")

        End If
    End Sub
End Class