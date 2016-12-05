Public Class Beranda

    Private Sub PasienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasienToolStripMenuItem.Click
        Pasien.Show()
    End Sub

    Private Sub LobiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LobiToolStripMenuItem.Click
        Lobi.Show()
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseAllToolStripMenuItem.Click
        User_Login.Close()
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
End Class
