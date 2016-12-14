Public Class Pasien

    Private Sub PasienBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PasienBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sistem_informasi_rumahsakitDataSet)

    End Sub

    Private Sub Pasien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Sistem_informasi_rumahsakitDataSet.pasien' table. You can move, or remove it, as needed.
        Me.PasienTableAdapter.Fill(Me.Sistem_informasi_rumahsakitDataSet.pasien)

        Timer1.Start()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTambah.Click
        ID_PASIENTextBox.Enabled = True
        NAMA_PASIENTextBox.Enabled = True
        J_KComboBox.Enabled = True
        KOTA_PASIENTextBox.Enabled = True
        ALAMATTextBox.Enabled = True
        KELUHANTextBox.Enabled = True
        UMURComboBox.Enabled = True


        ButtonTambah.Enabled = False
        ButtonSimpan.Enabled = True
        ButtonHapus.Enabled = False
        ButtonEdit.Enabled = False
        ButtonBatal.Enabled = True
        ButtonRefresh.Enabled = False

        If MessageBox.Show("Ingin Menambahkan Data.?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            PasienBindingSource.AddNew()

        ElseIf Windows.Forms.DialogResult.No Then

            ID_PASIENTextBox.Enabled = False
            NAMA_PASIENTextBox.Enabled = False
            J_KComboBox.Enabled = False
            KOTA_PASIENTextBox.Enabled = False
            ALAMATTextBox.Enabled = False
            KELUHANTextBox.Enabled = False
            UMURComboBox.Enabled = False


            ButtonTambah.Enabled = True
            ButtonEdit.Enabled = True
        End If

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
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

        MessageBox.Show("Data Berhasil Disimpan", "Konfirmasi Data")

        ButtonTambah.Enabled = True
        ButtonSimpan.Enabled = False
        ButtonHapus.Enabled = True
        ButtonEdit.Enabled = False
        ButtonBatal.Enabled = True

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHapus.Click
        If MessageBox.Show("Hapus Data", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            PasienBindingSource.RemoveCurrent()

            Me.Validate()
            Me.PasienBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Sistem_informasi_rumahsakitDataSet)

            MessageBox.Show("Data Telah Dihapus")
        End If
    End Sub

    Private Sub CariButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariButton.Click
        PasienTableAdapter.CariData(Sistem_informasi_rumahsakitDataSet.pasien, " " & CariTextbox.Text & " ")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click
        NAMA_PASIENTextBox.Enabled = True
        J_KComboBox.Enabled = True
        KOTA_PASIENTextBox.Enabled = True
        ALAMATTextBox.Enabled = True
        KELUHANTextBox.Enabled = True
        UMURComboBox.Enabled = True

        ButtonTambah.Enabled = False
        ButtonSimpan.Enabled = True
        ButtonHapus.Enabled = False
        ButtonEdit.Enabled = False
        ButtonBatal.Enabled = True
        ButtonRefresh.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        LblJam.Text = TimeOfDay.Hour
        LblMenit.Text = TimeOfDay.Minute
        LblDetik.Text = TimeOfDay.Second
        Tanggal.Text = Date.Now.ToLongDateString
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If MessageBox.Show("Ingin Keluar dari Semua Form", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            User_Login.Close()
            Login_Master.Close()
            Beranda.Close()
            Halaman_Login.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Beranda.Show()
    End Sub

    Private Sub ButtonBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBatal.Click
        PasienBindingSource.CancelEdit()

        ButtonTambah.Enabled = True
        ButtonSimpan.Enabled = False
        ButtonHapus.Enabled = True
        ButtonEdit.Enabled = True
        ButtonBatal.Enabled = False
        ButtonRefresh.Enabled = True

        ID_PASIENTextBox.Enabled = False
        NAMA_PASIENTextBox.Enabled = False
        J_KComboBox.Enabled = False
        KOTA_PASIENTextBox.Enabled = False
        ALAMATTextBox.Enabled = False
        KELUHANTextBox.Enabled = False
        UMURComboBox.Enabled = False

    End Sub

    Private Sub ButtonRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefresh.Click
        Me.PasienTableAdapter.Fill(Me.Sistem_informasi_rumahsakitDataSet.pasien)
    End Sub

    'Private Sub OpenFileToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Dim fileDialog As New OpenFileDialog
    '    'fileDialog.Title = "Open File"
    '    'fileDialog.Filter = "*.mpg (*.mpg)|*.mpg|*.mp4 (*.mp4)|*.mp4|*.mp3 (*.mp3)|*.mp3"
    '    'fileDialog.ShowDialog()
    '    'AxWindowsMediaPlayer1.URL = fileDialog.FileName
    'End Sub

    'Private Sub AxWindowsMediaPlayer1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DengarMusik.Enter
    '    Dim fileDialog As New OpenFileDialog
    '    fileDialog.Title = "Open File"
    '    fileDialog.Filter = "*.mpg (*.mpg)|*.mpg|*.mp4 (*.mp4)|*.mp4|*.mp3 (*.mp3)|*.mp3"
    '    fileDialog.ShowDialog()
    '    DengarMusik.URL = fileDialog.FileName
    'End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If MessageBox.Show("Ingin mendengar musik", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '        DengarMusik.URL = Application.StartupPath & "/MUSIK/Wiz Khalifa - See You Again ft. Charlie Puth [Official Video] Furious 7 Soundtrack.mp3"
    '        MessageBox.Show("Anda Telah Mendengarkan Musik agar tidak bosan", "Dengar Musik")
    '    End If
    'End Sub

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If MessageBox.Show("Ingin mendengar musik", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '        DengarMusik.URL = Application.StartupPath & "/MUSIK/---Maher Zain - Number One For Me - Official Music Video - YouTube.mp4"
    '        MessageBox.Show("Anda Telah Mendengarkan Musik agar tidak bosan", "Dengar Musik")
    '    End If
    'End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Beranda.Show()
    End Sub
End Class
