Public Class OBAT01

    Private Sub ObatBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ObatBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ObatBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sistem_informasi_rumahsakitDataSet)

    End Sub
End Class