<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_Pasien
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ID_PASIENLabel As System.Windows.Forms.Label
        Dim NAMA_PASIENLabel As System.Windows.Forms.Label
        Dim J_KLabel As System.Windows.Forms.Label
        Dim KOTA_PASIENLabel As System.Windows.Forms.Label
        Dim ALAMATLabel As System.Windows.Forms.Label
        Dim KELUHANLabel As System.Windows.Forms.Label
        Dim UMURLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_Pasien))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox_WaktudanTanggal = New System.Windows.Forms.GroupBox()
        Me.Tanggal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblDetik = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblMenit = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblJam = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Sistem_informasi_rumahsakitDataSet = New Sistem_Informasi_Rumah_Sakit.sistem_informasi_rumahsakitDataSet()
        Me.PasienBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PasienTableAdapter = New Sistem_Informasi_Rumah_Sakit.sistem_informasi_rumahsakitDataSetTableAdapters.pasienTableAdapter()
        Me.TableAdapterManager = New Sistem_Informasi_Rumah_Sakit.sistem_informasi_rumahsakitDataSetTableAdapters.TableAdapterManager()
        Me.ID_PASIENTextBox = New System.Windows.Forms.TextBox()
        Me.NAMA_PASIENTextBox = New System.Windows.Forms.TextBox()
        Me.J_KComboBox = New System.Windows.Forms.ComboBox()
        Me.KOTA_PASIENTextBox = New System.Windows.Forms.TextBox()
        Me.ALAMATTextBox = New System.Windows.Forms.TextBox()
        Me.KELUHANTextBox = New System.Windows.Forms.TextBox()
        Me.UMURComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox_Data_Pasien = New System.Windows.Forms.GroupBox()
        Me.Batal = New System.Windows.Forms.PictureBox()
        Me.Keluar = New System.Windows.Forms.PictureBox()
        Me.Edit = New System.Windows.Forms.PictureBox()
        Me.Refresh = New System.Windows.Forms.PictureBox()
        Me.Hapus = New System.Windows.Forms.PictureBox()
        Me.Simpan = New System.Windows.Forms.PictureBox()
        Me.Tambah = New System.Windows.Forms.PictureBox()
        Me.PasienDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Button2 = New System.Windows.Forms.Button()
        ID_PASIENLabel = New System.Windows.Forms.Label()
        NAMA_PASIENLabel = New System.Windows.Forms.Label()
        J_KLabel = New System.Windows.Forms.Label()
        KOTA_PASIENLabel = New System.Windows.Forms.Label()
        ALAMATLabel = New System.Windows.Forms.Label()
        KELUHANLabel = New System.Windows.Forms.Label()
        UMURLabel = New System.Windows.Forms.Label()
        Me.GroupBox_WaktudanTanggal.SuspendLayout()
        CType(Me.Sistem_informasi_rumahsakitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasienBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Data_Pasien.SuspendLayout()
        CType(Me.Batal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Keluar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Refresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hapus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Simpan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tambah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasienDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_PASIENLabel
        '
        ID_PASIENLabel.AutoSize = True
        ID_PASIENLabel.Location = New System.Drawing.Point(10, 22)
        ID_PASIENLabel.Name = "ID_PASIENLabel"
        ID_PASIENLabel.Size = New System.Drawing.Size(63, 13)
        ID_PASIENLabel.TabIndex = 17
        ID_PASIENLabel.Text = "ID PASIEN:"
        '
        'NAMA_PASIENLabel
        '
        NAMA_PASIENLabel.AutoSize = True
        NAMA_PASIENLabel.Location = New System.Drawing.Point(10, 48)
        NAMA_PASIENLabel.Name = "NAMA_PASIENLabel"
        NAMA_PASIENLabel.Size = New System.Drawing.Size(83, 13)
        NAMA_PASIENLabel.TabIndex = 19
        NAMA_PASIENLabel.Text = "NAMA PASIEN:"
        '
        'J_KLabel
        '
        J_KLabel.AutoSize = True
        J_KLabel.Location = New System.Drawing.Point(10, 74)
        J_KLabel.Name = "J_KLabel"
        J_KLabel.Size = New System.Drawing.Size(25, 13)
        J_KLabel.TabIndex = 21
        J_KLabel.Text = "J K:"
        '
        'KOTA_PASIENLabel
        '
        KOTA_PASIENLabel.AutoSize = True
        KOTA_PASIENLabel.Location = New System.Drawing.Point(10, 101)
        KOTA_PASIENLabel.Name = "KOTA_PASIENLabel"
        KOTA_PASIENLabel.Size = New System.Drawing.Size(81, 13)
        KOTA_PASIENLabel.TabIndex = 23
        KOTA_PASIENLabel.Text = "KOTA PASIEN:"
        '
        'ALAMATLabel
        '
        ALAMATLabel.AutoSize = True
        ALAMATLabel.Location = New System.Drawing.Point(10, 127)
        ALAMATLabel.Name = "ALAMATLabel"
        ALAMATLabel.Size = New System.Drawing.Size(53, 13)
        ALAMATLabel.TabIndex = 25
        ALAMATLabel.Text = "ALAMAT:"
        '
        'KELUHANLabel
        '
        KELUHANLabel.AutoSize = True
        KELUHANLabel.Location = New System.Drawing.Point(10, 153)
        KELUHANLabel.Name = "KELUHANLabel"
        KELUHANLabel.Size = New System.Drawing.Size(61, 13)
        KELUHANLabel.TabIndex = 27
        KELUHANLabel.Text = "KELUHAN:"
        '
        'UMURLabel
        '
        UMURLabel.AutoSize = True
        UMURLabel.Location = New System.Drawing.Point(10, 179)
        UMURLabel.Name = "UMURLabel"
        UMURLabel.Size = New System.Drawing.Size(43, 13)
        UMURLabel.TabIndex = 29
        UMURLabel.Text = "UMUR:"
        '
        'Timer1
        '
        '
        'GroupBox_WaktudanTanggal
        '
        Me.GroupBox_WaktudanTanggal.Controls.Add(Me.Tanggal)
        Me.GroupBox_WaktudanTanggal.Controls.Add(Me.Label2)
        Me.GroupBox_WaktudanTanggal.Controls.Add(Me.LblDetik)
        Me.GroupBox_WaktudanTanggal.Controls.Add(Me.Label5)
        Me.GroupBox_WaktudanTanggal.Controls.Add(Me.LblMenit)
        Me.GroupBox_WaktudanTanggal.Controls.Add(Me.Label3)
        Me.GroupBox_WaktudanTanggal.Controls.Add(Me.LblJam)
        Me.GroupBox_WaktudanTanggal.Controls.Add(Me.Label4)
        Me.GroupBox_WaktudanTanggal.Location = New System.Drawing.Point(857, 5)
        Me.GroupBox_WaktudanTanggal.Name = "GroupBox_WaktudanTanggal"
        Me.GroupBox_WaktudanTanggal.Size = New System.Drawing.Size(234, 53)
        Me.GroupBox_WaktudanTanggal.TabIndex = 16
        Me.GroupBox_WaktudanTanggal.TabStop = False
        '
        'Tanggal
        '
        Me.Tanggal.AutoSize = True
        Me.Tanggal.Location = New System.Drawing.Point(133, 28)
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.Size = New System.Drawing.Size(95, 13)
        Me.Tanggal.TabIndex = 23
        Me.Tanggal.Text = "Tanggal Sekarang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Tanggal"
        '
        'LblDetik
        '
        Me.LblDetik.AutoSize = True
        Me.LblDetik.Location = New System.Drawing.Point(75, 28)
        Me.LblDetik.Name = "LblDetik"
        Me.LblDetik.Size = New System.Drawing.Size(32, 13)
        Me.LblDetik.TabIndex = 21
        Me.LblDetik.Text = "Detik"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = ":"
        '
        'LblMenit
        '
        Me.LblMenit.AutoSize = True
        Me.LblMenit.Location = New System.Drawing.Point(35, 28)
        Me.LblMenit.Name = "LblMenit"
        Me.LblMenit.Size = New System.Drawing.Size(33, 13)
        Me.LblMenit.TabIndex = 19
        Me.LblMenit.Text = "Menit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = ":"
        '
        'LblJam
        '
        Me.LblJam.AutoSize = True
        Me.LblJam.Location = New System.Drawing.Point(4, 28)
        Me.LblJam.Name = "LblJam"
        Me.LblJam.Size = New System.Drawing.Size(26, 13)
        Me.LblJam.TabIndex = 17
        Me.LblJam.Text = "Jam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Waktu Sekarang"
        '
        'Sistem_informasi_rumahsakitDataSet
        '
        Me.Sistem_informasi_rumahsakitDataSet.DataSetName = "sistem_informasi_rumahsakitDataSet"
        Me.Sistem_informasi_rumahsakitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PasienBindingSource
        '
        Me.PasienBindingSource.DataMember = "pasien"
        Me.PasienBindingSource.DataSource = Me.Sistem_informasi_rumahsakitDataSet
        '
        'PasienTableAdapter
        '
        Me.PasienTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dokter_has_obatTableAdapter = Nothing
        Me.TableAdapterManager.dokterTableAdapter = Nothing
        Me.TableAdapterManager.kasirTableAdapter = Nothing
        Me.TableAdapterManager.lobiTableAdapter = Nothing
        Me.TableAdapterManager.obatTableAdapter = Nothing
        Me.TableAdapterManager.pasien_has_obatTableAdapter = Nothing
        Me.TableAdapterManager.pasienTableAdapter = Me.PasienTableAdapter
        Me.TableAdapterManager.ruangan_has_dokterTableAdapter = Nothing
        Me.TableAdapterManager.ruanganTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistem_Informasi_Rumah_Sakit.sistem_informasi_rumahsakitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ID_PASIENTextBox
        '
        Me.ID_PASIENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "ID_PASIEN", True))
        Me.ID_PASIENTextBox.Enabled = False
        Me.ID_PASIENTextBox.Location = New System.Drawing.Point(99, 19)
        Me.ID_PASIENTextBox.Name = "ID_PASIENTextBox"
        Me.ID_PASIENTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ID_PASIENTextBox.TabIndex = 18
        '
        'NAMA_PASIENTextBox
        '
        Me.NAMA_PASIENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "NAMA_PASIEN", True))
        Me.NAMA_PASIENTextBox.Enabled = False
        Me.NAMA_PASIENTextBox.Location = New System.Drawing.Point(99, 45)
        Me.NAMA_PASIENTextBox.Name = "NAMA_PASIENTextBox"
        Me.NAMA_PASIENTextBox.Size = New System.Drawing.Size(188, 20)
        Me.NAMA_PASIENTextBox.TabIndex = 20
        '
        'J_KComboBox
        '
        Me.J_KComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "J_K", True))
        Me.J_KComboBox.Enabled = False
        Me.J_KComboBox.FormattingEnabled = True
        Me.J_KComboBox.Items.AddRange(New Object() {"L", "P"})
        Me.J_KComboBox.Location = New System.Drawing.Point(99, 71)
        Me.J_KComboBox.Name = "J_KComboBox"
        Me.J_KComboBox.Size = New System.Drawing.Size(44, 21)
        Me.J_KComboBox.TabIndex = 22
        '
        'KOTA_PASIENTextBox
        '
        Me.KOTA_PASIENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "KOTA_PASIEN", True))
        Me.KOTA_PASIENTextBox.Enabled = False
        Me.KOTA_PASIENTextBox.Location = New System.Drawing.Point(99, 98)
        Me.KOTA_PASIENTextBox.Name = "KOTA_PASIENTextBox"
        Me.KOTA_PASIENTextBox.Size = New System.Drawing.Size(188, 20)
        Me.KOTA_PASIENTextBox.TabIndex = 24
        '
        'ALAMATTextBox
        '
        Me.ALAMATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "ALAMAT", True))
        Me.ALAMATTextBox.Enabled = False
        Me.ALAMATTextBox.Location = New System.Drawing.Point(99, 150)
        Me.ALAMATTextBox.Name = "ALAMATTextBox"
        Me.ALAMATTextBox.Size = New System.Drawing.Size(158, 20)
        Me.ALAMATTextBox.TabIndex = 26
        '
        'KELUHANTextBox
        '
        Me.KELUHANTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "KELUHAN", True))
        Me.KELUHANTextBox.Enabled = False
        Me.KELUHANTextBox.Location = New System.Drawing.Point(99, 127)
        Me.KELUHANTextBox.Name = "KELUHANTextBox"
        Me.KELUHANTextBox.Size = New System.Drawing.Size(188, 20)
        Me.KELUHANTextBox.TabIndex = 28
        '
        'UMURComboBox
        '
        Me.UMURComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "UMUR", True))
        Me.UMURComboBox.Enabled = False
        Me.UMURComboBox.FormattingEnabled = True
        Me.UMURComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"})
        Me.UMURComboBox.Location = New System.Drawing.Point(99, 176)
        Me.UMURComboBox.Name = "UMURComboBox"
        Me.UMURComboBox.Size = New System.Drawing.Size(44, 21)
        Me.UMURComboBox.TabIndex = 30
        '
        'GroupBox_Data_Pasien
        '
        Me.GroupBox_Data_Pasien.Controls.Add(Me.Batal)
        Me.GroupBox_Data_Pasien.Controls.Add(Me.Keluar)
        Me.GroupBox_Data_Pasien.Controls.Add(Me.Edit)
        Me.GroupBox_Data_Pasien.Controls.Add(Me.Refresh)
        Me.GroupBox_Data_Pasien.Controls.Add(Me.Hapus)
        Me.GroupBox_Data_Pasien.Controls.Add(Me.Simpan)
        Me.GroupBox_Data_Pasien.Controls.Add(Me.Tambah)
        Me.GroupBox_Data_Pasien.Controls.Add(Me.J_KComboBox)
        Me.GroupBox_Data_Pasien.Controls.Add(ID_PASIENLabel)
        Me.GroupBox_Data_Pasien.Controls.Add(Me.UMURComboBox)
        Me.GroupBox_Data_Pasien.Controls.Add(Me.ID_PASIENTextBox)
        Me.GroupBox_Data_Pasien.Controls.Add(UMURLabel)
        Me.GroupBox_Data_Pasien.Controls.Add(NAMA_PASIENLabel)
        Me.GroupBox_Data_Pasien.Controls.Add(Me.KELUHANTextBox)
        Me.GroupBox_Data_Pasien.Controls.Add(Me.NAMA_PASIENTextBox)
        Me.GroupBox_Data_Pasien.Controls.Add(KELUHANLabel)
        Me.GroupBox_Data_Pasien.Controls.Add(J_KLabel)
        Me.GroupBox_Data_Pasien.Controls.Add(Me.ALAMATTextBox)
        Me.GroupBox_Data_Pasien.Controls.Add(ALAMATLabel)
        Me.GroupBox_Data_Pasien.Controls.Add(KOTA_PASIENLabel)
        Me.GroupBox_Data_Pasien.Controls.Add(Me.KOTA_PASIENTextBox)
        Me.GroupBox_Data_Pasien.Location = New System.Drawing.Point(714, 64)
        Me.GroupBox_Data_Pasien.Name = "GroupBox_Data_Pasien"
        Me.GroupBox_Data_Pasien.Size = New System.Drawing.Size(377, 353)
        Me.GroupBox_Data_Pasien.TabIndex = 31
        Me.GroupBox_Data_Pasien.TabStop = False
        Me.GroupBox_Data_Pasien.Text = "Data Pasien"
        '
        'Batal
        '
        Me.Batal.Image = CType(resources.GetObject("Batal.Image"), System.Drawing.Image)
        Me.Batal.Location = New System.Drawing.Point(179, 278)
        Me.Batal.Name = "Batal"
        Me.Batal.Size = New System.Drawing.Size(77, 65)
        Me.Batal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Batal.TabIndex = 45
        Me.Batal.TabStop = False
        '
        'Keluar
        '
        Me.Keluar.Image = CType(resources.GetObject("Keluar.Image"), System.Drawing.Image)
        Me.Keluar.Location = New System.Drawing.Point(99, 281)
        Me.Keluar.Name = "Keluar"
        Me.Keluar.Size = New System.Drawing.Size(74, 62)
        Me.Keluar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Keluar.TabIndex = 43
        Me.Keluar.TabStop = False
        '
        'Edit
        '
        Me.Edit.Image = CType(resources.GetObject("Edit.Image"), System.Drawing.Image)
        Me.Edit.Location = New System.Drawing.Point(13, 281)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(74, 62)
        Me.Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Edit.TabIndex = 42
        Me.Edit.TabStop = False
        '
        'Refresh
        '
        Me.Refresh.Image = CType(resources.GetObject("Refresh.Image"), System.Drawing.Image)
        Me.Refresh.Location = New System.Drawing.Point(265, 281)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(77, 62)
        Me.Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Refresh.TabIndex = 41
        Me.Refresh.TabStop = False
        '
        'Hapus
        '
        Me.Hapus.Image = CType(resources.GetObject("Hapus.Image"), System.Drawing.Image)
        Me.Hapus.Location = New System.Drawing.Point(183, 203)
        Me.Hapus.Name = "Hapus"
        Me.Hapus.Size = New System.Drawing.Size(74, 65)
        Me.Hapus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Hapus.TabIndex = 40
        Me.Hapus.TabStop = False
        '
        'Simpan
        '
        Me.Simpan.Image = CType(resources.GetObject("Simpan.Image"), System.Drawing.Image)
        Me.Simpan.Location = New System.Drawing.Point(99, 203)
        Me.Simpan.Name = "Simpan"
        Me.Simpan.Size = New System.Drawing.Size(74, 65)
        Me.Simpan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Simpan.TabIndex = 39
        Me.Simpan.TabStop = False
        '
        'Tambah
        '
        Me.Tambah.Image = CType(resources.GetObject("Tambah.Image"), System.Drawing.Image)
        Me.Tambah.Location = New System.Drawing.Point(10, 203)
        Me.Tambah.Name = "Tambah"
        Me.Tambah.Size = New System.Drawing.Size(77, 65)
        Me.Tambah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Tambah.TabIndex = 38
        Me.Tambah.TabStop = False
        '
        'PasienDataGridView
        '
        Me.PasienDataGridView.AutoGenerateColumns = False
        Me.PasienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PasienDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.PasienDataGridView.DataSource = Me.PasienBindingSource
        Me.PasienDataGridView.Location = New System.Drawing.Point(12, 64)
        Me.PasienDataGridView.Name = "PasienDataGridView"
        Me.PasienDataGridView.Size = New System.Drawing.Size(696, 353)
        Me.PasienDataGridView.TabIndex = 31
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_PASIEN"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_PASIEN"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NAMA_PASIEN"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NAMA_PASIEN"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "J_K"
        Me.DataGridViewTextBoxColumn3.HeaderText = "J_K"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "KOTA_PASIEN"
        Me.DataGridViewTextBoxColumn4.HeaderText = "KOTA_PASIEN"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ALAMAT"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ALAMAT"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "KELUHAN"
        Me.DataGridViewTextBoxColumn6.HeaderText = "KELUHAN"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "UMUR"
        Me.DataGridViewTextBoxColumn7.HeaderText = "UMUR"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.MediumBlue
        Me.Button1.Location = New System.Drawing.Point(12, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 36)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Data Pasien"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(720, 10)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 23)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "Print Data Pasien"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Data_Pasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 449)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PasienDataGridView)
        Me.Controls.Add(Me.GroupBox_Data_Pasien)
        Me.Controls.Add(Me.GroupBox_WaktudanTanggal)
        Me.Name = "Data_Pasien"
        Me.Text = "Data_Pasien"
        Me.GroupBox_WaktudanTanggal.ResumeLayout(False)
        Me.GroupBox_WaktudanTanggal.PerformLayout()
        CType(Me.Sistem_informasi_rumahsakitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasienBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Data_Pasien.ResumeLayout(False)
        Me.GroupBox_Data_Pasien.PerformLayout()
        CType(Me.Batal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Keluar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Refresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hapus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Simpan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tambah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasienDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox_WaktudanTanggal As System.Windows.Forms.GroupBox
    Friend WithEvents Tanggal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblDetik As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblMenit As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblJam As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Sistem_informasi_rumahsakitDataSet As Sistem_Informasi_Rumah_Sakit.sistem_informasi_rumahsakitDataSet
    Friend WithEvents PasienBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PasienTableAdapter As Sistem_Informasi_Rumah_Sakit.sistem_informasi_rumahsakitDataSetTableAdapters.pasienTableAdapter
    Friend WithEvents TableAdapterManager As Sistem_Informasi_Rumah_Sakit.sistem_informasi_rumahsakitDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ID_PASIENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NAMA_PASIENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents J_KComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents KOTA_PASIENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ALAMATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KELUHANTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UMURComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox_Data_Pasien As System.Windows.Forms.GroupBox
    Friend WithEvents PasienDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Hapus As System.Windows.Forms.PictureBox
    Friend WithEvents Simpan As System.Windows.Forms.PictureBox
    Friend WithEvents Tambah As System.Windows.Forms.PictureBox
    Friend WithEvents Refresh As System.Windows.Forms.PictureBox
    Friend WithEvents Edit As System.Windows.Forms.PictureBox
    Friend WithEvents Keluar As System.Windows.Forms.PictureBox
    Friend WithEvents Batal As System.Windows.Forms.PictureBox
End Class
