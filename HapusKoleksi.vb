Public Class HapusKoleksi

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        LBLKoleksi.Text() = Perpustakaan.selectedTableKoleksiNama
    End Sub
    Private Sub BTNHapus_Click(sender As Object, e As EventArgs) Handles BTNHapus.Click
        Perpustakaan.koleksi.DeleteDataKoleksiByIDDatabase(Perpustakaan.selectedTableKoleksi)
        Me.Close()
    End Sub
End Class