<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusKoleksi
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
        Me.BTNHapus = New System.Windows.Forms.Button()
        Me.LBLKoleksi = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTNHapus
        '
        Me.BTNHapus.Location = New System.Drawing.Point(212, 133)
        Me.BTNHapus.Name = "BTNHapus"
        Me.BTNHapus.Size = New System.Drawing.Size(94, 29)
        Me.BTNHapus.TabIndex = 8
        Me.BTNHapus.Text = "Hapus"
        Me.BTNHapus.UseVisualStyleBackColor = True
        '
        'LBLKoleksi
        '
        Me.LBLKoleksi.AutoSize = True
        Me.LBLKoleksi.Location = New System.Drawing.Point(12, 56)
        Me.LBLKoleksi.Name = "LBLKoleksi"
        Me.LBLKoleksi.Size = New System.Drawing.Size(53, 20)
        Me.LBLKoleksi.TabIndex = 7
        Me.LBLKoleksi.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Apakah Anda Ingin Menghapus"
        '
        'HapusKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 185)
        Me.Controls.Add(Me.BTNHapus)
        Me.Controls.Add(Me.LBLKoleksi)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HapusKoleksi"
        Me.Text = "HapusKoleksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNHapus As Button
    Friend WithEvents LBLKoleksi As Label
    Friend WithEvents Label1 As Label
End Class
