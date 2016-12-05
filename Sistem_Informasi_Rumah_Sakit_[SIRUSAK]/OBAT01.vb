Public Class OBAT01

    Private Sub ObatBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObatBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ObatBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sistem_informasi_rumahsakitDataSet)

    End Sub

    Private Sub OBAT01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Sistem_informasi_rumahsakitDataSet.obat' table. You can move, or remove it, as needed.
        Me.ObatTableAdapter.Fill(Me.Sistem_informasi_rumahsakitDataSet.obat)

    End Sub
End Class