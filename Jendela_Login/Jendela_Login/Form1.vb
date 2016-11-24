Public Class Jendela_login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim formlogin As New Menu_Utama
        If (TextBox1.Text = "AJIS") And (TextBox2.Text = "AGIL2897") Then
            MessageBox.Show("Selamat Anda Berhasil Login", "Konfirmasi")

            Menu_Utama.Show()
            Me.Hide()
        ElseIf MessageBox.Show("Username:  " & TextBox1.Text & ".     Password:  " & TextBox2.Text & ".    Salah, Coba Lagi", _
                "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning) Then
        End If
    End Sub
End Class
