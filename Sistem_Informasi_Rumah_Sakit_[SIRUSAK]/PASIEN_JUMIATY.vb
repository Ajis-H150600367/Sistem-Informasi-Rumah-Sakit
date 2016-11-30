Public Class PASIEN_JUMIATY

    Private Sub PasienBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasienBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PasienBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sistem_informasi_rumah_sakitDataSet)

    End Sub

    Private Sub PASIEN_JUMIATY_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Sistem_informasi_rumah_sakitDataSet.pasien' table. You can move, or remove it, as needed.
        Me.PasienTableAdapter.Fill(Me.Sistem_informasi_rumah_sakitDataSet.pasien)

    End Sub
End Class