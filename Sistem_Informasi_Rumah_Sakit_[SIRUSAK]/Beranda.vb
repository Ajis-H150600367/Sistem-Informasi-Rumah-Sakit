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
End Class
