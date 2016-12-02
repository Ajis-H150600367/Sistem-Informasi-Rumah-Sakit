Public Class Pasien

    Private Sub PasienBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasienBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PasienBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sistem_informasi_rumahsakitDataSet)

    End Sub

    Private Sub Pasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Sistem_informasi_rumahsakitDataSet.pasien' table. You can move, or remove it, as needed.
        Me.PasienTableAdapter.Fill(Me.Sistem_informasi_rumahsakitDataSet.pasien)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ID_PASIENTextBox.Enabled = True
        NAMA_PASIENTextBox.Enabled = True
        J_KComboBox.Enabled = True
        KOTA_PASIENTextBox.Enabled = True
        ALAMATTextBox.Enabled = True
        KELUHANTextBox.Enabled = True
        UMURComboBox.Enabled = True

        PasienBindingSource.AddNew()
        MessageBox.Show("Ingin Menambah Data.?", "Konfirmasi")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ID_PASIENTextBox.Enabled = False
        NAMA_PASIENTextBox.Enabled = False
        J_KComboBox.Enabled = False
        KOTA_PASIENTextBox.Enabled = False
        ALAMATTextBox.Enabled = False
        KELUHANTextBox.Enabled = False
        UMURComboBox.Enabled = False

        Me.Validate()
        Me.PasienBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sistem_informasi_rumahsakitDataSet)

        MessageBox.Show("Data Berhasil Disimpan")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MessageBox.Show("Hapus Data", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            PasienBindingSource.RemoveCurrent()

            Me.Validate()
            Me.PasienBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Sistem_informasi_rumahsakitDataSet)

            MessageBox.Show("Data Telah Dihapus")
        End If
    End Sub
End Class
