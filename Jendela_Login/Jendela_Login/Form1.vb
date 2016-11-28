Public Class Jendela_login

    Private Sub ButtonLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLogin.Click
        Dim formlogin As New Menu_Utama 'setelah login menu utama akan tampil dan merupakan menu utama dari seluruh form tabel'
        If (TextBox1.Text = "AJIS") And (TextBox2.Text = "AGIL2897") Then 'jika username yang dimasukan adalah AJIS dan password dimasukan adalah AGIL2897'
            MessageBox.Show("Selamat Anda Berhasil Login", "Konfirmasi") ' maka notife berhasil'

            Menu_Utama.Show() 'maka menu utama di tampilkan'
            Me.Hide() 'setelah menu utama ditampilkan maka jendela login akan tersembunyi atau tidak terlihat ditampilkan'
        ElseIf MessageBox.Show("Username:  " & TextBox1.Text & ".     Password:  " & TextBox2.Text & ".    Salah, Coba Lagi", _
                "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning) Then 'selain dari username =ajis dan password = agil2897 yang ditampilkan adalah peringatan error'
        End If
        'tutup statement'
    End Sub

    Private Sub Jendela_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = "" 'bantuan kode username jendela login terlihat ditampilkan setelah dirunning'
        TextBox2.Text = "" 'bantuan kode password jendela login terlihat ditampilkan setelah dirunning'
    End Sub
End Class
