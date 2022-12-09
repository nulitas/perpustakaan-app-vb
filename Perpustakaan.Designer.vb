<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Perpustakaan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Perpustakaan))
        Me.BTNSelectKoleksi = New System.Windows.Forms.Button()
        Me.BTNRemoveKoleksi = New System.Windows.Forms.Button()
        Me.BTNUpdateKoleksi = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.TSBtnTambahKoleksi = New System.Windows.Forms.ToolStripButton()
        Me.TSBtnHapusKoleksi = New System.Windows.Forms.ToolStripButton()
        Me.DataGridKoleksi = New System.Windows.Forms.DataGridView()
        Me.BTNInsertKoleksi = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNSelectKoleksi
        '
        Me.BTNSelectKoleksi.Location = New System.Drawing.Point(576, 559)
        Me.BTNSelectKoleksi.Name = "BTNSelectKoleksi"
        Me.BTNSelectKoleksi.Size = New System.Drawing.Size(94, 29)
        Me.BTNSelectKoleksi.TabIndex = 9
        Me.BTNSelectKoleksi.Text = "Select"
        Me.BTNSelectKoleksi.UseVisualStyleBackColor = True
        '
        'BTNRemoveKoleksi
        '
        Me.BTNRemoveKoleksi.Location = New System.Drawing.Point(676, 559)
        Me.BTNRemoveKoleksi.Name = "BTNRemoveKoleksi"
        Me.BTNRemoveKoleksi.Size = New System.Drawing.Size(94, 29)
        Me.BTNRemoveKoleksi.TabIndex = 8
        Me.BTNRemoveKoleksi.Text = "Remove"
        Me.BTNRemoveKoleksi.UseVisualStyleBackColor = True
        '
        'BTNUpdateKoleksi
        '
        Me.BTNUpdateKoleksi.Location = New System.Drawing.Point(464, 559)
        Me.BTNUpdateKoleksi.Name = "BTNUpdateKoleksi"
        Me.BTNUpdateKoleksi.Size = New System.Drawing.Size(94, 29)
        Me.BTNUpdateKoleksi.TabIndex = 7
        Me.BTNUpdateKoleksi.Text = "Update"
        Me.BTNUpdateKoleksi.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSBtnTambahKoleksi, Me.TSBtnHapusKoleksi})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1254, 27)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'TSBtnTambahKoleksi
        '
        Me.TSBtnTambahKoleksi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TSBtnTambahKoleksi.Image = CType(resources.GetObject("TSBtnTambahKoleksi.Image"), System.Drawing.Image)
        Me.TSBtnTambahKoleksi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBtnTambahKoleksi.Name = "TSBtnTambahKoleksi"
        Me.TSBtnTambahKoleksi.Size = New System.Drawing.Size(29, 24)
        Me.TSBtnTambahKoleksi.Text = "+"
        Me.TSBtnTambahKoleksi.ToolTipText = "Tambah"
        '
        'TSBtnHapusKoleksi
        '
        Me.TSBtnHapusKoleksi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TSBtnHapusKoleksi.Image = CType(resources.GetObject("TSBtnHapusKoleksi.Image"), System.Drawing.Image)
        Me.TSBtnHapusKoleksi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TSBtnHapusKoleksi.Name = "TSBtnHapusKoleksi"
        Me.TSBtnHapusKoleksi.Size = New System.Drawing.Size(29, 24)
        Me.TSBtnHapusKoleksi.Text = "-"
        Me.TSBtnHapusKoleksi.ToolTipText = "Hapus"
        '
        'DataGridKoleksi
        '
        Me.DataGridKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKoleksi.Location = New System.Drawing.Point(206, 114)
        Me.DataGridKoleksi.Name = "DataGridKoleksi"
        Me.DataGridKoleksi.RowHeadersWidth = 51
        Me.DataGridKoleksi.RowTemplate.Height = 29
        Me.DataGridKoleksi.Size = New System.Drawing.Size(747, 420)
        Me.DataGridKoleksi.TabIndex = 5
        '
        'BTNInsertKoleksi
        '
        Me.BTNInsertKoleksi.Location = New System.Drawing.Point(352, 559)
        Me.BTNInsertKoleksi.Name = "BTNInsertKoleksi"
        Me.BTNInsertKoleksi.Size = New System.Drawing.Size(94, 29)
        Me.BTNInsertKoleksi.TabIndex = 10
        Me.BTNInsertKoleksi.Text = "Insert"
        Me.BTNInsertKoleksi.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(372, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(444, 59)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "LibraryApp | C R U D"
        '
        'Perpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 637)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNInsertKoleksi)
        Me.Controls.Add(Me.BTNSelectKoleksi)
        Me.Controls.Add(Me.BTNRemoveKoleksi)
        Me.Controls.Add(Me.BTNUpdateKoleksi)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridKoleksi)
        Me.Name = "Perpustakaan"
        Me.Text = "Perpustakaan"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNSelectKoleksi As Button
    Friend WithEvents BTNRemoveKoleksi As Button
    Friend WithEvents BTNUpdateKoleksi As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents TSBtnTambahKoleksi As ToolStripButton
    Friend WithEvents TSBtnHapusKoleksi As ToolStripButton
    Friend WithEvents DataGridKoleksi As DataGridView
    Friend WithEvents BTNInsertKoleksi As Button
    Friend WithEvents Label1 As Label
End Class
