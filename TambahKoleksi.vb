Public Class TambahKoleksi

    Public Shared FotoKoleksi


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ComboJenisKoleksi.DataSource = Perpustakaan.JenisKoleksi
        ' Add any initialization after the InitializeComponent() call.
        DTPTanggalMasukKoleksi.Format = DateTimePickerFormat.Custom
        DTPTanggalMasukKoleksi.CustomFormat = "yyyy/MM/dd"

    End Sub
    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Upload Foto"
        OpenFileDialog1.Filter = "All Format|*.*"
        OpenFileDialog1.ShowDialog()

        FotoKoleksi = OpenFileDialog1.FileName

        PictureBox1.Load(FotoKoleksi)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Perpustakaan.koleksi.GSFoto = FotoKoleksi.ToString()
        Perpustakaan.koleksi.GSFoto = Perpustakaan.koleksi.GSFoto.Replace("\", "/")
    End Sub

    Private Sub BTNTambahKoleksi_Click(sender As Object, e As EventArgs) Handles BTNTambahKoleksi.Click
        Perpustakaan.koleksi.GSnama = TXTNamaKoleksi.Text
        'Perpustakaan.koleksi.GSjenis = TXTJenisKoleksi.Text
        Perpustakaan.koleksi.GSjenis = ComboJenisKoleksi.Text
        Perpustakaan.koleksi.GSdeskripsi = RTXTDeskripsi.Text
        Perpustakaan.koleksi.GSpenerbit = TXTPenerbit.Text
        Perpustakaan.koleksi.GStahun = TXTTahunTerbit.Text
        Perpustakaan.koleksi.GSlokasi = TXTLokasiRak.Text
        Perpustakaan.koleksi.GStanggalMasuk = DTPTanggalMasukKoleksi.Value.ToShortDateString
        Perpustakaan.koleksi.GSstok = TXTStock.Text

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

        'InfoKoleksi.Show()

        Dim convertedKoleksi = Perpustakaan.koleksi.ConvertKoleksiToString(Perpustakaan.koleksi.GSkategori)
        Perpustakaan.koleksi.AddDataKoleksiDatabase(
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