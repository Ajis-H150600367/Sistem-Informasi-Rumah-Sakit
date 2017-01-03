Public Class OBAT

    Private Sub ObatBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObatBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ObatBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sistem_informasi_rumahsakitDataSet)

    End Sub

    Private Sub OBAT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Sistem_informasi_rumahsakitDataSet.obat' table. You can move, or remove it, as needed.
        Me.ObatTableAdapter.Fill(Me.Sistem_informasi_rumahsakitDataSet.obat)

    End Sub

    Private Sub TAMBAHButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TAMBAHButton1.Click
        ID_OBATTextBox.Enabled = True
        NAMA_OBATTextBox.Enabled = True
        MASA_BERLAKUDateTimePicker.Enabled = True
        HARGATextBox.Enabled = True
       
        TAMBAHButton1.Enabled = False
        HAPUSButton7.Enabled = False
        EDITButton4.Enabled = False
        REFRESHButton5.Enabled = False
        SIMPANButton2.Enabled = True
        BATALButton6.Enabled = True

        ObatBindingSource.AddNew()
    End Sub

    Private Sub SIMPANButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SIMPANButton2.Click
        Me.Validate()
        Me.ObatBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Sistem_informasi_rumahsakitDataSet)

        MessageBox.Show("Data telah tersimpan")

        ID_OBATTextBox.Enabled = False
        NAMA_OBATTextBox.Enabled = False
        MASA_BERLAKUDateTimePicker.Enabled = False
        HARGATextBox.Enabled = False

        TAMBAHButton1.Enabled = True
        HAPUSButton7.Enabled = True
        EDITButton4.Enabled = True
        SIMPANButton2.Enabled = False
    End Sub

    Private Sub KELUARButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KELUARButton3.Click
        Me.Close()
    End Sub

    Private Sub EDITButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EDITButton4.Click
        NAMA_OBATTextBox.Enabled = True
        MASA_BERLAKUDateTimePicker.Enabled = True
        HARGATextBox.Enabled = True

        TAMBAHButton1.Enabled = False
        HAPUSButton7.Enabled = False
        EDITButton4.Enabled = False
        REFRESHButton5.Enabled = False
        SIMPANButton2.Enabled = False
        BATALButton6.Enabled = False
    End Sub

    Private Sub REFRESHButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REFRESHButton5.Click
        Me.ObatTableAdapter.Fill(Me.Sistem_informasi_rumahsakitDataSet.obat)
    End Sub

    Private Sub BATALButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BATALButton6.Click
        ObatBindingSource.CancelEdit()

        TAMBAHButton1.Enabled = True
        HAPUSButton7.Enabled = True
        EDITButton4.Enabled = True
        REFRESHButton5.Enabled = True
        SIMPANButton2.Enabled = False
        BATALButton6.Enabled = False
    End Sub

    Private Sub HAPUSButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HAPUSButton7.Click
        If MessageBox.Show("hapus data?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            ObatBindingSource.RemoveCurrent()


            Me.Validate()
            Me.ObatBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Sistem_informasi_rumahsakitDataSet)

            MessageBox.Show("data telah di hapus")
        End If
    End Sub
End Class