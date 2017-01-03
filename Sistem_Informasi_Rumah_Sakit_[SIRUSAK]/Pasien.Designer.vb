<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pasien
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
        Me.PasienDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasienBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sistem_informasi_rumahsakitDataSet = New Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSet()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.CariTextbox = New System.Windows.Forms.TextBox()
        Me.CariButton = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.ID_PASIENTextBox = New System.Windows.Forms.TextBox()
        Me.NAMA_PASIENTextBox = New System.Windows.Forms.TextBox()
        Me.J_KComboBox = New System.Windows.Forms.ComboBox()
        Me.KOTA_PASIENTextBox = New System.Windows.Forms.TextBox()
        Me.ALAMATTextBox = New System.Windows.Forms.TextBox()
        Me.KELUHANTextBox = New System.Windows.Forms.TextBox()
        Me.UMURComboBox = New System.Windows.Forms.ComboBox()
        Me.Tanggal = New System.Windows.Forms.Label()
        Me.LblDetik = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblMenit = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblJam = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PasienTableAdapter = New Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.pasienTableAdapter()
        Me.TableAdapterManager = New Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.TableAdapterManager()
        Me.Button2 = New System.Windows.Forms.Button()
        ID_PASIENLabel = New System.Windows.Forms.Label()
        NAMA_PASIENLabel = New System.Windows.Forms.Label()
        J_KLabel = New System.Windows.Forms.Label()
        KOTA_PASIENLabel = New System.Windows.Forms.Label()
        ALAMATLabel = New System.Windows.Forms.Label()
        KELUHANLabel = New System.Windows.Forms.Label()
        UMURLabel = New System.Windows.Forms.Label()
        CType(Me.PasienDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasienBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sistem_informasi_rumahsakitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID_PASIENLabel
        '
        ID_PASIENLabel.AutoSize = True
        ID_PASIENLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        ID_PASIENLabel.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ID_PASIENLabel.Location = New System.Drawing.Point(35, 8)
        ID_PASIENLabel.Name = "ID_PASIENLabel"
        ID_PASIENLabel.Size = New System.Drawing.Size(92, 16)
        ID_PASIENLabel.TabIndex = 17
        ID_PASIENLabel.Text = "ID PASIEN:"
        '
        'NAMA_PASIENLabel
        '
        NAMA_PASIENLabel.AutoSize = True
        NAMA_PASIENLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        NAMA_PASIENLabel.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NAMA_PASIENLabel.Location = New System.Drawing.Point(1, 34)
        NAMA_PASIENLabel.Name = "NAMA_PASIENLabel"
        NAMA_PASIENLabel.Size = New System.Drawing.Size(126, 16)
        NAMA_PASIENLabel.TabIndex = 19
        NAMA_PASIENLabel.Text = "NAMA PASIEN:"
        '
        'J_KLabel
        '
        J_KLabel.AutoSize = True
        J_KLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        J_KLabel.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        J_KLabel.Location = New System.Drawing.Point(93, 59)
        J_KLabel.Name = "J_KLabel"
        J_KLabel.Size = New System.Drawing.Size(34, 16)
        J_KLabel.TabIndex = 21
        J_KLabel.Text = "J K:"
        '
        'KOTA_PASIENLabel
        '
        KOTA_PASIENLabel.AutoSize = True
        KOTA_PASIENLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        KOTA_PASIENLabel.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KOTA_PASIENLabel.Location = New System.Drawing.Point(9, 86)
        KOTA_PASIENLabel.Name = "KOTA_PASIENLabel"
        KOTA_PASIENLabel.Size = New System.Drawing.Size(118, 16)
        KOTA_PASIENLabel.TabIndex = 23
        KOTA_PASIENLabel.Text = "KOTA PASIEN:"
        '
        'ALAMATLabel
        '
        ALAMATLabel.AutoSize = True
        ALAMATLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        ALAMATLabel.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ALAMATLabel.Location = New System.Drawing.Point(44, 113)
        ALAMATLabel.Name = "ALAMATLabel"
        ALAMATLabel.Size = New System.Drawing.Size(83, 16)
        ALAMATLabel.TabIndex = 25
        ALAMATLabel.Text = "ALAMAT:"
        '
        'KELUHANLabel
        '
        KELUHANLabel.AutoSize = True
        KELUHANLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        KELUHANLabel.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        KELUHANLabel.Location = New System.Drawing.Point(37, 138)
        KELUHANLabel.Name = "KELUHANLabel"
        KELUHANLabel.Size = New System.Drawing.Size(90, 16)
        KELUHANLabel.TabIndex = 27
        KELUHANLabel.Text = "KELUHAN:"
        '
        'UMURLabel
        '
        UMURLabel.AutoSize = True
        UMURLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        UMURLabel.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UMURLabel.Location = New System.Drawing.Point(69, 165)
        UMURLabel.Name = "UMURLabel"
        UMURLabel.Size = New System.Drawing.Size(58, 16)
        UMURLabel.TabIndex = 29
        UMURLabel.Text = "UMUR:"
        '
        'PasienDataGridView
        '
        Me.PasienDataGridView.AutoGenerateColumns = False
        Me.PasienDataGridView.BackgroundColor = System.Drawing.Color.Black
        Me.PasienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PasienDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.PasienDataGridView.DataSource = Me.PasienBindingSource
        Me.PasienDataGridView.Location = New System.Drawing.Point(0, 98)
        Me.PasienDataGridView.Name = "PasienDataGridView"
        Me.PasienDataGridView.Size = New System.Drawing.Size(868, 466)
        Me.PasienDataGridView.TabIndex = 1
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
        'PasienBindingSource
        '
        Me.PasienBindingSource.DataMember = "pasien"
        Me.PasienBindingSource.DataSource = Me.Sistem_informasi_rumahsakitDataSet
        '
        'Sistem_informasi_rumahsakitDataSet
        '
        Me.Sistem_informasi_rumahsakitDataSet.DataSetName = "sistem_informasi_rumahsakitDataSet"
        Me.Sistem_informasi_rumahsakitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(870, 94)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(464, 470)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Black
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Button7)
        Me.TabPage1.Controls.Add(Me.CariTextbox)
        Me.TabPage1.Controls.Add(Me.CariButton)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(456, 444)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cari,Keluar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Elephant", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(344, 20)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Masukan ID PASIEN untuk mencari data"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(17, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(67, 34)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Keluar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Red
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(275, 148)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(151, 34)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "Keluar Semua Form"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'CariTextbox
        '
        Me.CariTextbox.BackColor = System.Drawing.Color.White
        Me.CariTextbox.Location = New System.Drawing.Point(17, 38)
        Me.CariTextbox.Multiline = True
        Me.CariTextbox.Name = "CariTextbox"
        Me.CariTextbox.Size = New System.Drawing.Size(328, 28)
        Me.CariTextbox.TabIndex = 3
        '
        'CariButton
        '
        Me.CariButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CariButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CariButton.Location = New System.Drawing.Point(351, 38)
        Me.CariButton.Name = "CariButton"
        Me.CariButton.Size = New System.Drawing.Size(75, 28)
        Me.CariButton.TabIndex = 2
        Me.CariButton.Text = "Cari"
        Me.CariButton.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Black
        Me.TabPage2.Controls.Add(Me.ButtonRefresh)
        Me.TabPage2.Controls.Add(Me.ButtonBatal)
        Me.TabPage2.Controls.Add(Me.ButtonEdit)
        Me.TabPage2.Controls.Add(Me.ButtonHapus)
        Me.TabPage2.Controls.Add(Me.ButtonSimpan)
        Me.TabPage2.Controls.Add(Me.ButtonTambah)
        Me.TabPage2.Controls.Add(ID_PASIENLabel)
        Me.TabPage2.Controls.Add(Me.ID_PASIENTextBox)
        Me.TabPage2.Controls.Add(NAMA_PASIENLabel)
        Me.TabPage2.Controls.Add(Me.NAMA_PASIENTextBox)
        Me.TabPage2.Controls.Add(J_KLabel)
        Me.TabPage2.Controls.Add(Me.J_KComboBox)
        Me.TabPage2.Controls.Add(KOTA_PASIENLabel)
        Me.TabPage2.Controls.Add(Me.KOTA_PASIENTextBox)
        Me.TabPage2.Controls.Add(ALAMATLabel)
        Me.TabPage2.Controls.Add(Me.ALAMATTextBox)
        Me.TabPage2.Controls.Add(KELUHANLabel)
        Me.TabPage2.Controls.Add(Me.KELUHANTextBox)
        Me.TabPage2.Controls.Add(UMURLabel)
        Me.TabPage2.Controls.Add(Me.UMURComboBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(456, 444)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Tambah,Simpan,Edit,Batal,Hapus,Refresh"
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.BackColor = System.Drawing.Color.White
        Me.ButtonRefresh.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefresh.ForeColor = System.Drawing.Color.Red
        Me.ButtonRefresh.Location = New System.Drawing.Point(289, 247)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(79, 28)
        Me.ButtonRefresh.TabIndex = 36
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = False
        '
        'ButtonBatal
        '
        Me.ButtonBatal.BackColor = System.Drawing.Color.White
        Me.ButtonBatal.Enabled = False
        Me.ButtonBatal.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBatal.ForeColor = System.Drawing.Color.Red
        Me.ButtonBatal.Location = New System.Drawing.Point(86, 247)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(79, 28)
        Me.ButtonBatal.TabIndex = 35
        Me.ButtonBatal.Text = "Batal"
        Me.ButtonBatal.UseVisualStyleBackColor = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.White
        Me.ButtonEdit.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEdit.ForeColor = System.Drawing.Color.Red
        Me.ButtonEdit.Location = New System.Drawing.Point(289, 208)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(79, 28)
        Me.ButtonEdit.TabIndex = 34
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'ButtonHapus
        '
        Me.ButtonHapus.BackColor = System.Drawing.Color.White
        Me.ButtonHapus.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHapus.ForeColor = System.Drawing.Color.Red
        Me.ButtonHapus.Location = New System.Drawing.Point(185, 247)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(79, 28)
        Me.ButtonHapus.TabIndex = 33
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = False
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.BackColor = System.Drawing.Color.White
        Me.ButtonSimpan.Enabled = False
        Me.ButtonSimpan.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSimpan.ForeColor = System.Drawing.Color.Red
        Me.ButtonSimpan.Location = New System.Drawing.Point(185, 208)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(79, 28)
        Me.ButtonSimpan.TabIndex = 32
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = False
        '
        'ButtonTambah
        '
        Me.ButtonTambah.BackColor = System.Drawing.Color.White
        Me.ButtonTambah.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTambah.ForeColor = System.Drawing.Color.Red
        Me.ButtonTambah.Location = New System.Drawing.Point(86, 208)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(79, 28)
        Me.ButtonTambah.TabIndex = 31
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = False
        '
        'ID_PASIENTextBox
        '
        Me.ID_PASIENTextBox.BackColor = System.Drawing.Color.White
        Me.ID_PASIENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "ID_PASIEN", True))
        Me.ID_PASIENTextBox.Enabled = False
        Me.ID_PASIENTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_PASIENTextBox.Location = New System.Drawing.Point(130, 5)
        Me.ID_PASIENTextBox.Name = "ID_PASIENTextBox"
        Me.ID_PASIENTextBox.Size = New System.Drawing.Size(121, 22)
        Me.ID_PASIENTextBox.TabIndex = 18
        '
        'NAMA_PASIENTextBox
        '
        Me.NAMA_PASIENTextBox.BackColor = System.Drawing.Color.White
        Me.NAMA_PASIENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "NAMA_PASIEN", True))
        Me.NAMA_PASIENTextBox.Enabled = False
        Me.NAMA_PASIENTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NAMA_PASIENTextBox.Location = New System.Drawing.Point(130, 31)
        Me.NAMA_PASIENTextBox.Name = "NAMA_PASIENTextBox"
        Me.NAMA_PASIENTextBox.Size = New System.Drawing.Size(218, 22)
        Me.NAMA_PASIENTextBox.TabIndex = 20
        '
        'J_KComboBox
        '
        Me.J_KComboBox.BackColor = System.Drawing.Color.White
        Me.J_KComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "J_K", True))
        Me.J_KComboBox.Enabled = False
        Me.J_KComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.J_KComboBox.FormattingEnabled = True
        Me.J_KComboBox.Items.AddRange(New Object() {"L", "P"})
        Me.J_KComboBox.Location = New System.Drawing.Point(130, 57)
        Me.J_KComboBox.Name = "J_KComboBox"
        Me.J_KComboBox.Size = New System.Drawing.Size(69, 24)
        Me.J_KComboBox.TabIndex = 22
        '
        'KOTA_PASIENTextBox
        '
        Me.KOTA_PASIENTextBox.BackColor = System.Drawing.Color.White
        Me.KOTA_PASIENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "KOTA_PASIEN", True))
        Me.KOTA_PASIENTextBox.Enabled = False
        Me.KOTA_PASIENTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KOTA_PASIENTextBox.Location = New System.Drawing.Point(130, 84)
        Me.KOTA_PASIENTextBox.Name = "KOTA_PASIENTextBox"
        Me.KOTA_PASIENTextBox.Size = New System.Drawing.Size(188, 22)
        Me.KOTA_PASIENTextBox.TabIndex = 24
        '
        'ALAMATTextBox
        '
        Me.ALAMATTextBox.BackColor = System.Drawing.Color.White
        Me.ALAMATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "ALAMAT", True))
        Me.ALAMATTextBox.Enabled = False
        Me.ALAMATTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALAMATTextBox.Location = New System.Drawing.Point(130, 110)
        Me.ALAMATTextBox.Name = "ALAMATTextBox"
        Me.ALAMATTextBox.Size = New System.Drawing.Size(218, 22)
        Me.ALAMATTextBox.TabIndex = 26
        '
        'KELUHANTextBox
        '
        Me.KELUHANTextBox.BackColor = System.Drawing.Color.White
        Me.KELUHANTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "KELUHAN", True))
        Me.KELUHANTextBox.Enabled = False
        Me.KELUHANTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KELUHANTextBox.Location = New System.Drawing.Point(130, 136)
        Me.KELUHANTextBox.Name = "KELUHANTextBox"
        Me.KELUHANTextBox.Size = New System.Drawing.Size(188, 22)
        Me.KELUHANTextBox.TabIndex = 28
        '
        'UMURComboBox
        '
        Me.UMURComboBox.BackColor = System.Drawing.Color.White
        Me.UMURComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "UMUR", True))
        Me.UMURComboBox.Enabled = False
        Me.UMURComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UMURComboBox.FormattingEnabled = True
        Me.UMURComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100"})
        Me.UMURComboBox.Location = New System.Drawing.Point(130, 162)
        Me.UMURComboBox.Name = "UMURComboBox"
        Me.UMURComboBox.Size = New System.Drawing.Size(69, 24)
        Me.UMURComboBox.TabIndex = 30
        '
        'Tanggal
        '
        Me.Tanggal.AutoSize = True
        Me.Tanggal.BackColor = System.Drawing.Color.White
        Me.Tanggal.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tanggal.Location = New System.Drawing.Point(6, 51)
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.Size = New System.Drawing.Size(121, 16)
        Me.Tanggal.TabIndex = 15
        Me.Tanggal.Text = "Tanggal_Hari_ini"
        '
        'LblDetik
        '
        Me.LblDetik.AutoSize = True
        Me.LblDetik.BackColor = System.Drawing.Color.White
        Me.LblDetik.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDetik.Location = New System.Drawing.Point(238, 51)
        Me.LblDetik.Name = "LblDetik"
        Me.LblDetik.Size = New System.Drawing.Size(40, 16)
        Me.LblDetik.TabIndex = 13
        Me.LblDetik.Text = "Detik"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(228, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = ":"
        '
        'LblMenit
        '
        Me.LblMenit.AutoSize = True
        Me.LblMenit.BackColor = System.Drawing.Color.White
        Me.LblMenit.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMenit.Location = New System.Drawing.Point(206, 51)
        Me.LblMenit.Name = "LblMenit"
        Me.LblMenit.Size = New System.Drawing.Size(45, 16)
        Me.LblMenit.TabIndex = 11
        Me.LblMenit.Text = "Menit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(198, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = ":"
        '
        'LblJam
        '
        Me.LblJam.AutoSize = True
        Me.LblJam.BackColor = System.Drawing.Color.White
        Me.LblJam.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJam.Location = New System.Drawing.Point(179, 51)
        Me.LblJam.Name = "LblJam"
        Me.LblJam.Size = New System.Drawing.Size(36, 16)
        Me.LblJam.TabIndex = 9
        Me.LblJam.Text = "Jam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(174, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Waktu_Sekarang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Tanggal"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.LblJam)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LblDetik)
        Me.GroupBox1.Controls.Add(Me.Tanggal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.LblMenit)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(1004, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 85)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Elephant", 8.999999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(272, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "WITA"
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Elephant", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(425, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Data Pasien"
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
        Me.TableAdapterManager.UpdateOrder = Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Green
        Me.Button2.Font = New System.Drawing.Font("Elephant", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(0, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 32)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Beranda"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Pasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1362, 740)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PasienDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Pasien"
        Me.Text = "Pasien"
        CType(Me.PasienDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasienBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sistem_informasi_rumahsakitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Sistem_informasi_rumahsakitDataSet As Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSet
    Friend WithEvents PasienBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PasienTableAdapter As Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.pasienTableAdapter
    Friend WithEvents TableAdapterManager As Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PasienDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents ID_PASIENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NAMA_PASIENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents J_KComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents KOTA_PASIENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ALAMATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KELUHANTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UMURComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CariTextbox As System.Windows.Forms.TextBox
    Friend WithEvents CariButton As System.Windows.Forms.Button
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ButtonBatal As System.Windows.Forms.Button
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Tanggal As System.Windows.Forms.Label
    Friend WithEvents LblDetik As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblMenit As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblJam As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
