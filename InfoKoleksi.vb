Public Class InfoKoleksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


        If Perpustakaan.koleksi.GSFoto IsNot Nothing Then
            PictureBox1.Load(Perpustakaan.koleksi.GSFoto)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        LBLNama.Text = Perpustakaan.koleksi.GSnama
        LBLKoleksi.Text = Perpustakaan.koleksi.GSjenis
        LBLDeskripsi.Text = Perpustakaan.koleksi.GSdeskripsi
        LBLPenerbit.Text = Perpustakaan.koleksi.GSpenerbit
        LBLTahunTerbit.Text = Perpustakaan.koleksi.GStahun
        LBLLokasiRak.Text = Perpustakaan.koleksi.GSlokasi
        LBLTanggalMasuk.Text = Perpustakaan.koleksi.GStanggalMasuk
        LBLStock.Text = Perpustakaan.koleksi.GSstok
        LBLBahasa.Text = Perpustakaan.koleksi.GSbahasa

        ListBoxKategori.Items.Clear()
        For Each kat In Perpustakaan.koleksi.GSkategori
            ListBoxKategori.Items.Add(kat)
        Next

    End Sub



End Class