Public Class Beranda

    Private Sub PasienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasienToolStripMenuItem.Click
        Pasien.Show()
        Me.Hide()
    End Sub

    Private Sub LobiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LobiToolStripMenuItem.Click
        Lobi.Show()
    End Sub

    Private Sub PASIEN01ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PASIEN01ToolStripMenuItem.Click
        PASIEN01.Show()
    End Sub

    Private Sub DokterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DokterToolStripMenuItem.Click
        dokter.Show()
    End Sub

    Private Sub OBAT01ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OBAT01ToolStripMenuItem.Click
        OBAT01.Show()
    End Sub

    Private Sub KASIRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KASIRToolStripMenuItem.Click
        KASIR.ShowDialog()
    End Sub

    Private Sub KeluarSemuaFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarSemuaFormToolStripMenuItem.Click
        If MessageBox.Show("Ingin Keluar dari Semua Form", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            User_Login.Close()
            Login_Master.Close()
            Halaman_Login.Close()
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
        User_Login.Close()
    End Sub

    Private Sub AplikasiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AplikasiToolStripMenuItem.Click
        Tentang_Aplikasi.Show()
    End Sub
End Class
