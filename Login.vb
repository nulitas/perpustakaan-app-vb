Public Class Login
    Public Shared Perpustakaan = New Perpustakaan
    Public Shared Users = New Users
    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TXTPassword.UseSystemPasswordChar = True
        If CheckPassword.Checked Then
            TXTPassword.UseSystemPasswordChar = False
        End If

        Perpustakaan = New Perpustakaan
        Users = New Users
    End Sub

    Private Sub LinkLblRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLblRegister.LinkClicked
        Registrasi.Show()

    End Sub

    Private Sub BTNLogin_Click(sender As Object, e As EventArgs) Handles BTNLogin.Click
        Dim plainUsername As String = TXTUsername.Text
        Dim plainPassword As String = TXTPassword.Text

        Dim data_user As List(Of String) = Users.CheckAuthDatabase(plainUsername, plainPassword)

        If data_user.Count > 0 Then
            Users.GSusername = data_user(1)
            Me.Hide()
            Perpustakaan.Show()
        Else
            MessageBox.Show("Error!")
        End If
    End Sub

    Private Sub CheckPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPassword.CheckedChanged
        TXTPassword.UseSystemPasswordChar = Not CheckPassword.Checked
    End Sub
End Class