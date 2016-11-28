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
End Class