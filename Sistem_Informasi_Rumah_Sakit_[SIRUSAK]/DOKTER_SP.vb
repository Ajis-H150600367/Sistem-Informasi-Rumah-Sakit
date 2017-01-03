Public Class DOKTER_SP

    Private Sub DokterBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DokterBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DokterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sistem_informasi_rumahsakitDataSet)

    End Sub

    Private Sub DOKTER_SP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Sistem_informasi_rumahsakitDataSet.dokter' table. You can move, or remove it, as needed.
        Me.DokterTableAdapter.Fill(Me.Sistem_informasi_rumahsakitDataSet.dokter)

    End Sub

    Private Sub TAMBAHButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TAMBAHButton1.Click
        ID_DOKTERTextBox.Enabled = True
        NAMA_DOKTERTextBox.Enabled = True
        SPESIALISTextBox.Enabled = True
        ALAMATTextBox.Enabled = True
        NO_TELPONTextBox.Enabled = True
        Pasien_ID_PASIENTextBox.Enabled = True


        TAMBAHButton1.Enabled = False
        HAPUSButton6.Enabled = False
        EDITButton7.Enabled = False
        REFRESHButton4.Enabled = False
        SIMPANButton2.Enabled = True
        BATALButton5.Enabled = True

        DokterBindingSource.AddNew()
    End Sub

    Private Sub SIMPANButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SIMPANButton2.Click
        Me.Validate()
        Me.DokterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Sistem_informasi_rumahsakitDataSet)

        MessageBox.Show("Data telah tersimpan")

        ID_DOKTERTextBox.Enabled = False
        NAMA_DOKTERTextBox.Enabled = False
        SPESIALISTextBox.Enabled = False
        ALAMATTextBox.Enabled = False
        NO_TELPONTextBox.Enabled = False
        Pasien_ID_PASIENTextBox.Enabled = False


        TAMBAHButton1.Enabled = True
        HAPUSButton6.Enabled = True
        EDITButton7.Enabled = True
        SIMPANButton2.Enabled = False
    End Sub

    Private Sub KELUARButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KELUARButton3.Click
        Me.Close()
    End Sub

    Private Sub REFRESHButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REFRESHButton4.Click
        Me.DokterTableAdapter.Fill(Me.Sistem_informasi_rumahsakitDataSet.dokter)
    End Sub

    Private Sub BATALButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BATALButton5.Click
        DokterBindingSource.CancelEdit()

        TAMBAHButton1.Enabled = True
        HAPUSButton6.Enabled = True
        EDITButton7.Enabled = True
        REFRESHButton4.Enabled = True
        SIMPANButton2.Enabled = False
        BATALButton5.Enabled = False
    End Sub

    Private Sub HAPUSButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HAPUSButton6.Click
        If MessageBox.Show("hapus data?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            DokterBindingSource.RemoveCurrent()


            Me.Validate()
            Me.DokterBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Sistem_informasi_rumahsakitDataSet)

            MessageBox.Show("data telah di hapus")
        End If
    End Sub

    Private Sub DOKTER_SP(ByVal p1 As Object)
        Throw New NotImplementedException
    End Sub

    Private Sub EDITButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITButton7.Click
        NAMA_DOKTERTextBox.Enabled = True
        SPESIALISTextBox.Enabled = True
        ALAMATTextBox.Enabled = True
        NO_TELPONTextBox.Enabled = True
        Pasien_ID_PASIENTextBox.Enabled = True

        TAMBAHButton1.Enabled = False
        HAPUSButton6.Enabled = False
        EDITButton7.Enabled = False
        REFRESHButton4.Enabled = False
        SIMPANButton2.Enabled = False
        BATALButton5.Enabled = False
    End Sub
End Class