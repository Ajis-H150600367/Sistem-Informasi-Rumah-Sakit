Public Class User_Login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim JendelaLogin As New Beranda 'setelah login menu utama akan tampil dan merupakan menu utama dari seluruh form tabel'
        If (UsernameTextBox.Text = "ajis") And (PasswordTextBox.Text = "agil2897") Then 'jika username yang dimasukan adalah AJIS dan password dimasukan adalah AGIL2897'
            MessageBox.Show("Selamat Anda Berhasil Login", "Konfirmasi") ' maka notife berhasil'

            Beranda.Show() 'maka menu beranda di tampilkan'

            Me.Hide() 'setelah menu utama ditampilkan maka jendela login akan tersembunyi atau tidak terlihat ditampilkan'
        ElseIf MessageBox.Show("Username:  " & UsernameTextBox.Text & ".     Password:  " & PasswordTextBox.Text & ".    Salah, Coba Lagi", _
                "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning) Then 'selain dari username =ajis dan password = agil2897 yang ditampilkan adalah peringatan error'
        End If
        'tutup statement'
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
