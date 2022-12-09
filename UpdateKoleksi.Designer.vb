<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateKoleksi
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
        Me.BTNUpdateKoleksi = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckSains = New System.Windows.Forms.CheckBox()
        Me.CheckSosial = New System.Windows.Forms.CheckBox()
        Me.CheckBudaya = New System.Windows.Forms.CheckBox()
        Me.CheckTeknologi = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBBInggris = New System.Windows.Forms.RadioButton()
        Me.RBBIndonesia = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTNTambahGambar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TXTPenerbit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTStock = New System.Windows.Forms.TextBox()
        Me.DTPTanggalMasukKoleksi = New System.Windows.Forms.DateTimePicker()
        Me.TXTLokasiRak = New System.Windows.Forms.TextBox()
        Me.RTXTDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.TXTTahunTerbit = New System.Windows.Forms.TextBox()
        Me.TXTNamaKoleksi = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ComboJenisKoleksi = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNUpdateKoleksi
        '
        Me.BTNUpdateKoleksi.Location = New System.Drawing.Point(374, 767)
        Me.BTNUpdateKoleksi.Name = "BTNUpdateKoleksi"
        Me.BTNUpdateKoleksi.Size = New System.Drawing.Size(180, 29)
        Me.BTNUpdateKoleksi.TabIndex = 90
        Me.BTNUpdateKoleksi.Text = "Update Koleksi"
        Me.BTNUpdateKoleksi.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckSains)
        Me.GroupBox2.Controls.Add(Me.CheckSosial)
        Me.GroupBox2.Controls.Add(Me.CheckBudaya)
        Me.GroupBox2.Controls.Add(Me.CheckTeknologi)
        Me.GroupBox2.Location = New System.Drawing.Point(305, 608)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(249, 144)
        Me.GroupBox2.TabIndex = 89
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kategori"
        '
        'CheckSains
        '
        Me.CheckSains.AutoSize = True
        Me.CheckSains.Location = New System.Drawing.Point(16, 26)
        Me.CheckSains.Name = "CheckSains"
        Me.CheckSains.Size = New System.Drawing.Size(65, 24)
        Me.CheckSains.TabIndex = 8
        Me.CheckSains.Text = "Sains"
        Me.CheckSains.UseVisualStyleBackColor = True
        '
        'CheckSosial
        '
        Me.CheckSosial.AutoSize = True
        Me.CheckSosial.Location = New System.Drawing.Point(16, 56)
        Me.CheckSosial.Name = "CheckSosial"
        Me.CheckSosial.Size = New System.Drawing.Size(70, 24)
        Me.CheckSosial.TabIndex = 9
        Me.CheckSosial.Text = "Sosial"
        Me.CheckSosial.UseVisualStyleBackColor = True
        '
        'CheckBudaya
        '
        Me.CheckBudaya.AutoSize = True
        Me.CheckBudaya.Location = New System.Drawing.Point(16, 117)
        Me.CheckBudaya.Name = "CheckBudaya"
        Me.CheckBudaya.Size = New System.Drawing.Size(80, 24)
        Me.CheckBudaya.TabIndex = 11
        Me.CheckBudaya.Text = "Budaya"
        Me.CheckBudaya.UseVisualStyleBackColor = True
        '
        'CheckTeknologi
        '
        Me.CheckTeknologi.AutoSize = True
        Me.CheckTeknologi.Location = New System.Drawing.Point(16, 86)
        Me.CheckTeknologi.Name = "CheckTeknologi"
        Me.CheckTeknologi.Size = New System.Drawing.Size(96, 24)
        Me.CheckTeknologi.TabIndex = 10
        Me.CheckTeknologi.Text = "Teknologi"
        Me.CheckTeknologi.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBBInggris)
        Me.GroupBox1.Controls.Add(Me.RBBIndonesia)
        Me.GroupBox1.Location = New System.Drawing.Point(305, 521)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 81)
        Me.GroupBox1.TabIndex = 88
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bahasa"
        '
        'RBBInggris
        '
        Me.RBBInggris.AutoSize = True
        Me.RBBInggris.Location = New System.Drawing.Point(142, 38)
        Me.RBBInggris.Name = "RBBInggris"
        Me.RBBInggris.Size = New System.Drawing.Size(77, 24)
        Me.RBBInggris.TabIndex = 7
        Me.RBBInggris.TabStop = True
        Me.RBBInggris.Text = "English"
        Me.RBBInggris.UseVisualStyleBackColor = True
        '
        'RBBIndonesia
        '
        Me.RBBIndonesia.AutoSize = True
        Me.RBBIndonesia.Location = New System.Drawing.Point(24, 38)
        Me.RBBIndonesia.Name = "RBBIndonesia"
        Me.RBBIndonesia.Size = New System.Drawing.Size(94, 24)
        Me.RBBIndonesia.TabIndex = 6
        Me.RBBIndonesia.TabStop = True
        Me.RBBIndonesia.Text = "Indonesia"
        Me.RBBIndonesia.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(124, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 20)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Jenis Koleksi"
        '
        'BTNTambahGambar
        '
        Me.BTNTambahGambar.Location = New System.Drawing.Point(718, 364)
        Me.BTNTambahGambar.Name = "BTNTambahGambar"
        Me.BTNTambahGambar.Size = New System.Drawing.Size(157, 29)
        Me.BTNTambahGambar.TabIndex = 85
        Me.BTNTambahGambar.Text = "Tambah Gambar"
        Me.BTNTambahGambar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(689, 97)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(223, 244)
        Me.PictureBox1.TabIndex = 84
        Me.PictureBox1.TabStop = False
        '
        'TXTPenerbit
        '
        Me.TXTPenerbit.Location = New System.Drawing.Point(304, 314)
        Me.TXTPenerbit.Name = "TXTPenerbit"
        Me.TXTPenerbit.Size = New System.Drawing.Size(151, 27)
        Me.TXTPenerbit.TabIndex = 83
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(126, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 20)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "Penerbit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(128, 461)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 20)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Stock"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(124, 423)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 20)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Tanggal Masuk Koleksi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(124, 387)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Lokasi Rak"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(126, 354)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 20)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Tahun Terbit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Deskripsi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(124, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Nama"
        '
        'TXTStock
        '
        Me.TXTStock.Location = New System.Drawing.Point(304, 458)
        Me.TXTStock.Name = "TXTStock"
        Me.TXTStock.Size = New System.Drawing.Size(151, 27)
        Me.TXTStock.TabIndex = 75
        '
        'DTPTanggalMasukKoleksi
        '
        Me.DTPTanggalMasukKoleksi.Location = New System.Drawing.Point(304, 418)
        Me.DTPTanggalMasukKoleksi.Name = "DTPTanggalMasukKoleksi"
        Me.DTPTanggalMasukKoleksi.Size = New System.Drawing.Size(250, 27)
        Me.DTPTanggalMasukKoleksi.TabIndex = 74
        '
        'TXTLokasiRak
        '
        Me.TXTLokasiRak.Location = New System.Drawing.Point(304, 380)
        Me.TXTLokasiRak.Name = "TXTLokasiRak"
        Me.TXTLokasiRak.Size = New System.Drawing.Size(151, 27)
        Me.TXTLokasiRak.TabIndex = 73
        '
        'RTXTDeskripsi
        '
        Me.RTXTDeskripsi.Location = New System.Drawing.Point(304, 184)
        Me.RTXTDeskripsi.Name = "RTXTDeskripsi"
        Me.RTXTDeskripsi.Size = New System.Drawing.Size(151, 120)
        Me.RTXTDeskripsi.TabIndex = 72
        Me.RTXTDeskripsi.Text = ""
        '
        'TXTTahunTerbit
        '
        Me.TXTTahunTerbit.Location = New System.Drawing.Point(304, 347)
        Me.TXTTahunTerbit.Name = "TXTTahunTerbit"
        Me.TXTTahunTerbit.Size = New System.Drawing.Size(151, 27)
        Me.TXTTahunTerbit.TabIndex = 71
        '
        'TXTNamaKoleksi
        '
        Me.TXTNamaKoleksi.Location = New System.Drawing.Point(304, 66)
        Me.TXTNamaKoleksi.Name = "TXTNamaKoleksi"
        Me.TXTNamaKoleksi.Size = New System.Drawing.Size(151, 27)
        Me.TXTNamaKoleksi.TabIndex = 70
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ComboJenisKoleksi
        '
        Me.ComboJenisKoleksi.FormattingEnabled = True
        Me.ComboJenisKoleksi.Location = New System.Drawing.Point(304, 121)
        Me.ComboJenisKoleksi.Name = "ComboJenisKoleksi"
        Me.ComboJenisKoleksi.Size = New System.Drawing.Size(151, 28)
        Me.ComboJenisKoleksi.TabIndex = 92
        '
        'UpdateKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 864)
        Me.Controls.Add(Me.ComboJenisKoleksi)
        Me.Controls.Add(Me.BTNUpdateKoleksi)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BTNTambahGambar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TXTPenerbit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTStock)
        Me.Controls.Add(Me.DTPTanggalMasukKoleksi)
        Me.Controls.Add(Me.TXTLokasiRak)
        Me.Controls.Add(Me.RTXTDeskripsi)
        Me.Controls.Add(Me.TXTTahunTerbit)
        Me.Controls.Add(Me.TXTNamaKoleksi)
        Me.Name = "UpdateKoleksi"
        Me.Text = "UpdateKoleksi"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNUpdateKoleksi As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckSains As CheckBox
    Friend WithEvents CheckSosial As CheckBox
    Friend WithEvents CheckBudaya As CheckBox
    Friend WithEvents CheckTeknologi As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBBInggris As RadioButton
    Friend WithEvents RBBIndonesia As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents BTNTambahGambar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TXTPenerbit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTStock As TextBox
    Friend WithEvents DTPTanggalMasukKoleksi As DateTimePicker
    Friend WithEvents TXTLokasiRak As TextBox
    Friend WithEvents RTXTDeskripsi As RichTextBox
    Friend WithEvents TXTTahunTerbit As TextBox
    Friend WithEvents TXTNamaKoleksi As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ComboJenisKoleksi As ComboBox
End Class
