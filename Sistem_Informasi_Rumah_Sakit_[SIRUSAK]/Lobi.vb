Public Class Lobi

    Private Sub LobiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LobiBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LobiBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sistem_informasi_rumahsakitDataSet)

    End Sub

    Private Sub Lobi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Sistem_informasi_rumahsakitDataSet.lobi' table. You can move, or remove it, as needed.
        Me.LobiTableAdapter.Fill(Me.Sistem_informasi_rumahsakitDataSet.lobi)

    End Sub
End Class