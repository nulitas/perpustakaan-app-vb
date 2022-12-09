Public Class Registrasi


    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TXTPass.UseSystemPasswordChar = True
        TXTConfirmPass.UseSystemPasswordChar = True

        If CheckPassword.Checked Then
            TXTPass.UseSystemPasswordChar = False
        End If

        If CheckConfirmPassword.Checked Then
            TXTConfirmPass.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BTNRegister.Click
        If TXTUsername.Text.Length > 0 And TXTPass.Text.Length > 0 Then
            If String.Compare(TXTPass.Text, TXTConfirmPass.Text) = 0 Then
                Login.Users.AddUsersDatabase(TXTUsername.Text, TXTPass.Text)
                Me.Close()
            Else
                MessageBox.Show("Error!")
            End If

        Else
            MessageBox.Show("Insert Data!")
        End If
    End Sub

    Private Sub CheckPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPassword.CheckedChanged
        TXTPass.UseSystemPasswordChar = Not CheckPassword.Checked

    End Sub

    Private Sub CheckConfirmPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckConfirmPassword.CheckedChanged
        TXTConfirmPass.UseSystemPasswordChar = Not CheckConfirmPassword.Checked
    End Sub

End Class