Public Class PASIEN_SP

    Private Sub PasienBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasienBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PasienBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sistem_informasi_rumahsakitDataSet)

    End Sub

    Private Sub PASIEN_SP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Sistem_informasi_rumahsakitDataSet.pasien' table. You can move, or remove it, as needed.
        Me.PasienTableAdapter.Fill(Me.Sistem_informasi_rumahsakitDataSet.pasien)

    End Sub

    Private Sub TAMBAHButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TAMBAHButton1.Click
        ID_PASIENTextBox.Enabled = True
        NAMA_PASIENTextBox.Enabled = True
        J_KComboBox.Enabled = True
        KOTA_PASIENTextBox.Enabled = True
        ALAMATTextBox.Enabled = True
        KELUHANTextBox.Enabled = True
        UMURComboBox.Enabled = True

        TAMBAHButton1.Enabled = False
        HAPUSButton5.Enabled = False
        EDITButton4.Enabled = False
        REFRESHButton6.Enabled = False
        SIMPANButton2.Enabled = True
        BATALButton7.Enabled = True

        PasienBindingSource.AddNew()
    End Sub

    Private Sub SIMPANButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SIMPANButton2.Click
        Me.Validate()
        Me.PasienBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Sistem_informasi_rumahsakitDataSet)

        MessageBox.Show("Data telah tersimpan")
        ID_PASIENTextBox.Enabled = False
        NAMA_PASIENTextBox.Enabled = False
        J_KComboBox.Enabled = False
        KOTA_PASIENTextBox.Enabled = False
        ALAMATTextBox.Enabled = False
        KELUHANTextBox.Enabled = False
        UMURComboBox.Enabled = False
       

        TAMBAHButton1.Enabled = True
        HAPUSButton5.Enabled = True
        EDITButton4.Enabled = True
        SIMPANButton2.Enabled = False
    End Sub

    Private Sub PASIEN_SP(ByVal p1 As Object)
        Throw New NotImplementedException
    End Sub

    Private Sub KELUARButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KELUARButton3.Click
        Me.Close()
    End Sub

    Private Sub EDITButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITButton4.Click
        NAMA_PASIENTextBox.Enabled = True
        J_KComboBox.Enabled = True
        KOTA_PASIENTextBox.Enabled = True
        ALAMATTextBox.Enabled = True
        KELUHANTextBox.Enabled = True
        UMURComboBox.Enabled = True

        TAMBAHButton1.Enabled = False
        HAPUSButton5.Enabled = False
        EDITButton4.Enabled = False
        REFRESHButton6.Enabled = False
        SIMPANButton2.Enabled = False
        BATALButton7.Enabled = False
    End Sub

    Private Sub HAPUSButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HAPUSButton5.Click
        If MessageBox.Show("hapus data?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            PasienBindingSource.RemoveCurrent()


            Me.Validate()
            Me.PasienBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Sistem_informasi_rumahsakitDataSet)

            MessageBox.Show("data telah di hapus")
        End If
    End Sub

    Private Sub REFRESHButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REFRESHButton6.Click
        Me.PasienTableAdapter.Fill(Me.Sistem_informasi_rumahsakitDataSet.pasien)
    End Sub

    Private Sub BATALButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BATALButton7.Click
        PasienBindingSource.CancelEdit()

        TAMBAHButton1.Enabled = True
        HAPUSButton5.Enabled = True
        EDITButton4.Enabled = True
        REFRESHButton6.Enabled = True
        SIMPANButton2.Enabled = False
        BATALButton7.Enabled = False
    End Sub
End Class