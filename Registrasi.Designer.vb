<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrasi
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNRegister = New System.Windows.Forms.Button()
        Me.TXTConfirmPass = New System.Windows.Forms.TextBox()
        Me.TXTPass = New System.Windows.Forms.TextBox()
        Me.TXTUsername = New System.Windows.Forms.TextBox()
        Me.CheckPassword = New System.Windows.Forms.CheckBox()
        Me.CheckConfirmPassword = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(97, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 301)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Konfirmasi Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(301, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 54)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Register"
        '
        'BTNRegister
        '
        Me.BTNRegister.Location = New System.Drawing.Point(335, 372)
        Me.BTNRegister.Name = "BTNRegister"
        Me.BTNRegister.Size = New System.Drawing.Size(94, 29)
        Me.BTNRegister.TabIndex = 19
        Me.BTNRegister.Text = "Register"
        Me.BTNRegister.UseVisualStyleBackColor = True
        '
        'TXTConfirmPass
        '
        Me.TXTConfirmPass.Location = New System.Drawing.Point(272, 298)
        Me.TXTConfirmPass.Name = "TXTConfirmPass"
        Me.TXTConfirmPass.Size = New System.Drawing.Size(245, 27)
        Me.TXTConfirmPass.TabIndex = 18
        '
        'TXTPass
        '
        Me.TXTPass.Location = New System.Drawing.Point(272, 245)
        Me.TXTPass.Name = "TXTPass"
        Me.TXTPass.Size = New System.Drawing.Size(245, 27)
        Me.TXTPass.TabIndex = 17
        '
        'TXTUsername
        '
        Me.TXTUsername.Location = New System.Drawing.Point(272, 190)
        Me.TXTUsername.Name = "TXTUsername"
        Me.TXTUsername.Size = New System.Drawing.Size(245, 27)
        Me.TXTUsername.TabIndex = 16
        '
        'CheckPassword
        '
        Me.CheckPassword.AutoSize = True
        Me.CheckPassword.Location = New System.Drawing.Point(523, 252)
        Me.CheckPassword.Name = "CheckPassword"
        Me.CheckPassword.Size = New System.Drawing.Size(18, 17)
        Me.CheckPassword.TabIndex = 24
        Me.CheckPassword.UseVisualStyleBackColor = True
        '
        'CheckConfirmPassword
        '
        Me.CheckConfirmPassword.AutoSize = True
        Me.CheckConfirmPassword.Location = New System.Drawing.Point(523, 304)
        Me.CheckConfirmPassword.Name = "CheckConfirmPassword"
        Me.CheckConfirmPassword.Size = New System.Drawing.Size(18, 17)
        Me.CheckConfirmPassword.TabIndex = 25
        Me.CheckConfirmPassword.UseVisualStyleBackColor = True
        '
        'Registrasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 477)
        Me.Controls.Add(Me.CheckConfirmPassword)
        Me.Controls.Add(Me.CheckPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNRegister)
        Me.Controls.Add(Me.TXTConfirmPass)
        Me.Controls.Add(Me.TXTPass)
        Me.Controls.Add(Me.TXTUsername)
        Me.Name = "Registrasi"
        Me.Text = "Registrasi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BTNRegister As Button
    Friend WithEvents TXTConfirmPass As TextBox
    Friend WithEvents TXTPass As TextBox
    Friend WithEvents TXTUsername As TextBox
    Friend WithEvents CheckPassword As CheckBox
    Friend WithEvents CheckConfirmPassword As CheckBox
End Class
