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

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Beranda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OBATToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OBATToolStripMenuItem.Click
        OBAT.ShowDialog()
    End Sub

    Private Sub DOKTERToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DOKTERSPToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DOKTERSPToolStripMenuItem1.Click
        DOKTER_SP.ShowDialog()
    End Sub

    Private Sub DOKTERSPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DOKTERSPToolStripMenuItem.Click
        DOKTER_SP.ShowDialog()
    End Sub

    Private Sub PASIENToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PASIENToolStripMenuItem1.Click
        PASIEN_SP.ShowDialog()
    End Sub
End Class
