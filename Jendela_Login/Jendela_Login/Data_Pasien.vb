Public Class Data_Pasien

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblJam.Text = TimeOfDay.Hour
        LblMenit.Text = TimeOfDay.Minute
        LblDetik.Text = TimeOfDay.Second
        Tanggal.Text = Date.Now.ToLongDateString
    End Sub

    Private Sub Data_Pasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Sistem_informasi_rumahsakitDataSet.pasien' table. You can move, or remove it, as needed.
        Me.PasienTableAdapter.Fill(Me.Sistem_informasi_rumahsakitDataSet.pasien)
        Timer1.Start()
    End Sub

    Private Sub PasienBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PasienBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sistem_informasi_rumahsakitDataSet)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PrintDialog1.ShowDialog()
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ID_PASIENTextBox.Enabled = True
        NAMA_PASIENTextBox.Enabled = True
        J_KComboBox.Enabled = True
        KOTA_PASIENTextBox.Enabled = True
        ALAMATTextBox.Enabled = True
        KELUHANTextBox.Enabled = True
        UMURComboBox.Enabled = True

        Tambah.Enabled = False
        Edit.Enabled = False
        Refresh.Enabled = False
        Batal.Enabled = True
        Hapus.Enabled = False
        Simpan.Enabled = True
    End Sub

    Private Sub HapusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MessageBox.Show("HAPUS DATA?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            PasienBindingSource.RemoveCurrent()
            Me.Validate()
            Me.PasienBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Sistem_informasi_rumahsakitDataSet)
            MessageBox.Show("DATA TELAH DIHAPUS")
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hapus.Click
        If MessageBox.Show("APAKAH ANDA INGIN MENGHAPUS DATA?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            PasienBindingSource.RemoveCurrent()
            Me.Validate()
            Me.PasienBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Sistem_informasi_rumahsakitDataSet)
            MessageBox.Show("DATA TELAH DIHAPUS")
        End If
    End Sub

    Private Sub Batal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Batal.Click
        PasienBindingSource.CancelEdit()
        Tambah.Enabled = True
        Edit.Enabled = True
        Hapus.Enabled = True
        Refresh.Enabled = True
        Simpan.Enabled = False
        Batal.Enabled = False
    End Sub

    Private Sub Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Edit.Click
        NAMA_PASIENTextBox.Enabled = True
        J_KComboBox.Enabled = True
        KOTA_PASIENTextBox.Enabled = True
        ALAMATTextBox.Enabled = True
        KELUHANTextBox.Enabled = True
        UMURComboBox.Enabled = True

        Tambah.Enabled = False
        Edit.Enabled = False
        Refresh.Enabled = False
        Batal.Enabled = True
        Hapus.Enabled = False
        Simpan.Enabled = True
    End Sub

    Private Sub Keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Keluar.Click
        Me.Close()
    End Sub

    Private Sub Refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Refresh.Click
        Me.PasienTableAdapter.Fill(Me.Sistem_informasi_rumahsakitDataSet.pasien)
    End Sub

    Private Sub Simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Simpan.Click
        Me.Validate()
        Me.PasienBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sistem_informasi_rumahsakitDataSet)

        MessageBox.Show("DATA TELAH DISIMPAN")

        ID_PASIENTextBox.Enabled = False
        NAMA_PASIENTextBox.Enabled = False
        J_KComboBox.Enabled = False
        KOTA_PASIENTextBox.Enabled = False
        ALAMATTextBox.Enabled = False
        KELUHANTextBox.Enabled = False
        UMURComboBox.Enabled = False

        Tambah.Enabled = True
        Edit.Enabled = True
        Hapus.Enabled = True
        Simpan.Enabled = False
    End Sub

    Private Sub Tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tambah.Click
        ID_PASIENTextBox.Enabled = True
        NAMA_PASIENTextBox.Enabled = True
        J_KComboBox.Enabled = True
        KOTA_PASIENTextBox.Enabled = True
        ALAMATTextBox.Enabled = True
        KELUHANTextBox.Enabled = True
        UMURComboBox.Enabled = True

        Tambah.Enabled = False
        Edit.Enabled = False
        Refresh.Enabled = False
        Batal.Enabled = True
        Hapus.Enabled = False
        Simpan.Enabled = True

        PasienBindingSource.AddNew()
    End Sub
End Class