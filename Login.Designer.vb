<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLblRegister = New System.Windows.Forms.LinkLabel()
        Me.BTNLogin = New System.Windows.Forms.Button()
        Me.TXTPassword = New System.Windows.Forms.TextBox()
        Me.TXTUsername = New System.Windows.Forms.TextBox()
        Me.CheckPassword = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(216, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(252, 59)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "LibraryApp"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(171, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Username"
        '
        'LinkLblRegister
        '
        Me.LinkLblRegister.AutoSize = True
        Me.LinkLblRegister.Location = New System.Drawing.Point(239, 424)
        Me.LinkLblRegister.Name = "LinkLblRegister"
        Me.LinkLblRegister.Size = New System.Drawing.Size(189, 20)
        Me.LinkLblRegister.TabIndex = 18
        Me.LinkLblRegister.TabStop = True
        Me.LinkLblRegister.Text = "Tidak punya akun? Register"
        '
        'BTNLogin
        '
        Me.BTNLogin.Location = New System.Drawing.Point(285, 355)
        Me.BTNLogin.Name = "BTNLogin"
        Me.BTNLogin.Size = New System.Drawing.Size(94, 29)
        Me.BTNLogin.TabIndex = 17
        Me.BTNLogin.Text = "Login"
        Me.BTNLogin.UseVisualStyleBackColor = True
        '
        'TXTPassword
        '
        Me.TXTPassword.Location = New System.Drawing.Point(252, 278)
        Me.TXTPassword.Name = "TXTPassword"
        Me.TXTPassword.Size = New System.Drawing.Size(176, 27)
        Me.TXTPassword.TabIndex = 16
        '
        'TXTUsername
        '
        Me.TXTUsername.Location = New System.Drawing.Point(252, 217)
        Me.TXTUsername.Name = "TXTUsername"
        Me.TXTUsername.Size = New System.Drawing.Size(176, 27)
        Me.TXTUsername.TabIndex = 15
        '
        'CheckPassword
        '
        Me.CheckPassword.AutoSize = True
        Me.CheckPassword.Location = New System.Drawing.Point(434, 284)
        Me.CheckPassword.Name = "CheckPassword"
        Me.CheckPassword.Size = New System.Drawing.Size(18, 17)
        Me.CheckPassword.TabIndex = 22
        Me.CheckPassword.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 507)
        Me.Controls.Add(Me.CheckPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLblRegister)
        Me.Controls.Add(Me.BTNLogin)
        Me.Controls.Add(Me.TXTPassword)
        Me.Controls.Add(Me.TXTUsername)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLblRegister As LinkLabel
    Friend WithEvents BTNLogin As Button
    Friend WithEvents TXTPassword As TextBox
    Friend WithEvents TXTUsername As TextBox
    Friend WithEvents CheckPassword As CheckBox
End Class
