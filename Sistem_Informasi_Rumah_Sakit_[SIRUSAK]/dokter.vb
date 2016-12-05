Public Class dokter

    Private Sub DokterBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DokterBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DokterBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sistem_informasi_rumahsakitDataSet)

    End Sub

    Private Sub dokter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Sistem_informasi_rumahsakitDataSet.dokter' table. You can move, or remove it, as needed.
        Me.DokterTableAdapter.Fill(Me.Sistem_informasi_rumahsakitDataSet.dokter)

    End Sub
End Class