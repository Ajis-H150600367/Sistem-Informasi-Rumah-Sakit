<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PASIEN_SP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PASIEN_SP))
        Me.Sistem_informasi_rumahsakitDataSet = New Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSet()
        Me.PasienBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PasienTableAdapter = New Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.pasienTableAdapter()
        Me.TableAdapterManager = New Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.TableAdapterManager()
        Me.PasienBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PasienBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PasienDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_PASIENTextBox = New System.Windows.Forms.TextBox()
        Me.NAMA_PASIENTextBox = New System.Windows.Forms.TextBox()
        Me.J_KComboBox = New System.Windows.Forms.ComboBox()
        Me.KOTA_PASIENTextBox = New System.Windows.Forms.TextBox()
        Me.ALAMATTextBox = New System.Windows.Forms.TextBox()
        Me.KELUHANTextBox = New System.Windows.Forms.TextBox()
        Me.UMURComboBox = New System.Windows.Forms.ComboBox()
        Me.TAMBAHButton1 = New System.Windows.Forms.Button()
        Me.SIMPANButton2 = New System.Windows.Forms.Button()
        Me.KELUARButton3 = New System.Windows.Forms.Button()
        Me.EDITButton4 = New System.Windows.Forms.Button()
        Me.HAPUSButton5 = New System.Windows.Forms.Button()
        Me.REFRESHButton6 = New System.Windows.Forms.Button()
        Me.BATALButton7 = New System.Windows.Forms.Button()
        ID_PASIENLabel = New System.Windows.Forms.Label()
        NAMA_PASIENLabel = New System.Windows.Forms.Label()
        J_KLabel = New System.Windows.Forms.Label()
        KOTA_PASIENLabel = New System.Windows.Forms.Label()
        ALAMATLabel = New System.Windows.Forms.Label()
        KELUHANLabel = New System.Windows.Forms.Label()
        UMURLabel = New System.Windows.Forms.Label()
        CType(Me.Sistem_informasi_rumahsakitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasienBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PasienBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PasienBindingNavigator.SuspendLayout()
        CType(Me.PasienDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_PASIENLabel
        '
        ID_PASIENLabel.AutoSize = True
        ID_PASIENLabel.Location = New System.Drawing.Point(21, 114)
        ID_PASIENLabel.Name = "ID_PASIENLabel"
        ID_PASIENLabel.Size = New System.Drawing.Size(63, 13)
        ID_PASIENLabel.TabIndex = 2
        ID_PASIENLabel.Text = "ID PASIEN:"
        '
        'NAMA_PASIENLabel
        '
        NAMA_PASIENLabel.AutoSize = True
        NAMA_PASIENLabel.Location = New System.Drawing.Point(21, 140)
        NAMA_PASIENLabel.Name = "NAMA_PASIENLabel"
        NAMA_PASIENLabel.Size = New System.Drawing.Size(83, 13)
        NAMA_PASIENLabel.TabIndex = 4
        NAMA_PASIENLabel.Text = "NAMA PASIEN:"
        '
        'J_KLabel
        '
        J_KLabel.AutoSize = True
        J_KLabel.Location = New System.Drawing.Point(21, 166)
        J_KLabel.Name = "J_KLabel"
        J_KLabel.Size = New System.Drawing.Size(25, 13)
        J_KLabel.TabIndex = 6
        J_KLabel.Text = "J K:"
        '
        'KOTA_PASIENLabel
        '
        KOTA_PASIENLabel.AutoSize = True
        KOTA_PASIENLabel.Location = New System.Drawing.Point(21, 193)
        KOTA_PASIENLabel.Name = "KOTA_PASIENLabel"
        KOTA_PASIENLabel.Size = New System.Drawing.Size(81, 13)
        KOTA_PASIENLabel.TabIndex = 8
        KOTA_PASIENLabel.Text = "KOTA PASIEN:"
        '
        'ALAMATLabel
        '
        ALAMATLabel.AutoSize = True
        ALAMATLabel.Location = New System.Drawing.Point(21, 219)
        ALAMATLabel.Name = "ALAMATLabel"
        ALAMATLabel.Size = New System.Drawing.Size(53, 13)
        ALAMATLabel.TabIndex = 10
        ALAMATLabel.Text = "ALAMAT:"
        '
        'KELUHANLabel
        '
        KELUHANLabel.AutoSize = True
        KELUHANLabel.Location = New System.Drawing.Point(21, 245)
        KELUHANLabel.Name = "KELUHANLabel"
        KELUHANLabel.Size = New System.Drawing.Size(61, 13)
        KELUHANLabel.TabIndex = 12
        KELUHANLabel.Text = "KELUHAN:"
        '
        'UMURLabel
        '
        UMURLabel.AutoSize = True
        UMURLabel.Location = New System.Drawing.Point(21, 271)
        UMURLabel.Name = "UMURLabel"
        UMURLabel.Size = New System.Drawing.Size(43, 13)
        UMURLabel.TabIndex = 14
        UMURLabel.Text = "UMUR:"
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
        Me.TableAdapterManager.UpdateOrder = Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PasienBindingNavigator
        '
        Me.PasienBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PasienBindingNavigator.BindingSource = Me.PasienBindingSource
        Me.PasienBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PasienBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PasienBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PasienBindingNavigatorSaveItem})
        Me.PasienBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PasienBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PasienBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PasienBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PasienBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PasienBindingNavigator.Name = "PasienBindingNavigator"
        Me.PasienBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PasienBindingNavigator.Size = New System.Drawing.Size(820, 25)
        Me.PasienBindingNavigator.TabIndex = 0
        Me.PasienBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PasienBindingNavigatorSaveItem
        '
        Me.PasienBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasienBindingNavigatorSaveItem.Image = CType(resources.GetObject("PasienBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PasienBindingNavigatorSaveItem.Name = "PasienBindingNavigatorSaveItem"
        Me.PasienBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PasienBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PasienDataGridView
        '
        Me.PasienDataGridView.AutoGenerateColumns = False
        Me.PasienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PasienDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.PasienDataGridView.DataSource = Me.PasienBindingSource
        Me.PasienDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.PasienDataGridView.Name = "PasienDataGridView"
        Me.PasienDataGridView.Size = New System.Drawing.Size(748, 69)
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
        'ID_PASIENTextBox
        '
        Me.ID_PASIENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "ID_PASIEN", True))
        Me.ID_PASIENTextBox.Location = New System.Drawing.Point(110, 111)
        Me.ID_PASIENTextBox.Name = "ID_PASIENTextBox"
        Me.ID_PASIENTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ID_PASIENTextBox.TabIndex = 3
        '
        'NAMA_PASIENTextBox
        '
        Me.NAMA_PASIENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "NAMA_PASIEN", True))
        Me.NAMA_PASIENTextBox.Location = New System.Drawing.Point(110, 137)
        Me.NAMA_PASIENTextBox.Name = "NAMA_PASIENTextBox"
        Me.NAMA_PASIENTextBox.Size = New System.Drawing.Size(121, 20)
        Me.NAMA_PASIENTextBox.TabIndex = 5
        '
        'J_KComboBox
        '
        Me.J_KComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "J_K", True))
        Me.J_KComboBox.FormattingEnabled = True
        Me.J_KComboBox.Location = New System.Drawing.Point(110, 163)
        Me.J_KComboBox.Name = "J_KComboBox"
        Me.J_KComboBox.Size = New System.Drawing.Size(121, 21)
        Me.J_KComboBox.TabIndex = 7
        '
        'KOTA_PASIENTextBox
        '
        Me.KOTA_PASIENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "KOTA_PASIEN", True))
        Me.KOTA_PASIENTextBox.Location = New System.Drawing.Point(110, 190)
        Me.KOTA_PASIENTextBox.Name = "KOTA_PASIENTextBox"
        Me.KOTA_PASIENTextBox.Size = New System.Drawing.Size(121, 20)
        Me.KOTA_PASIENTextBox.TabIndex = 9
        '
        'ALAMATTextBox
        '
        Me.ALAMATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "ALAMAT", True))
        Me.ALAMATTextBox.Location = New System.Drawing.Point(110, 216)
        Me.ALAMATTextBox.Name = "ALAMATTextBox"
        Me.ALAMATTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ALAMATTextBox.TabIndex = 11
        '
        'KELUHANTextBox
        '
        Me.KELUHANTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "KELUHAN", True))
        Me.KELUHANTextBox.Location = New System.Drawing.Point(110, 242)
        Me.KELUHANTextBox.Name = "KELUHANTextBox"
        Me.KELUHANTextBox.Size = New System.Drawing.Size(121, 20)
        Me.KELUHANTextBox.TabIndex = 13
        '
        'UMURComboBox
        '
        Me.UMURComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "UMUR", True))
        Me.UMURComboBox.FormattingEnabled = True
        Me.UMURComboBox.Location = New System.Drawing.Point(110, 268)
        Me.UMURComboBox.Name = "UMURComboBox"
        Me.UMURComboBox.Size = New System.Drawing.Size(121, 21)
        Me.UMURComboBox.TabIndex = 15
        '
        'TAMBAHButton1
        '
        Me.TAMBAHButton1.Location = New System.Drawing.Point(344, 144)
        Me.TAMBAHButton1.Name = "TAMBAHButton1"
        Me.TAMBAHButton1.Size = New System.Drawing.Size(75, 23)
        Me.TAMBAHButton1.TabIndex = 16
        Me.TAMBAHButton1.Text = "TAMBAH"
        Me.TAMBAHButton1.UseVisualStyleBackColor = True
        '
        'SIMPANButton2
        '
        Me.SIMPANButton2.Location = New System.Drawing.Point(472, 144)
        Me.SIMPANButton2.Name = "SIMPANButton2"
        Me.SIMPANButton2.Size = New System.Drawing.Size(75, 23)
        Me.SIMPANButton2.TabIndex = 17
        Me.SIMPANButton2.Text = "SIMPAN"
        Me.SIMPANButton2.UseVisualStyleBackColor = True
        '
        'KELUARButton3
        '
        Me.KELUARButton3.Location = New System.Drawing.Point(592, 144)
        Me.KELUARButton3.Name = "KELUARButton3"
        Me.KELUARButton3.Size = New System.Drawing.Size(75, 23)
        Me.KELUARButton3.TabIndex = 18
        Me.KELUARButton3.Text = "KELUAR"
        Me.KELUARButton3.UseVisualStyleBackColor = True
        '
        'EDITButton4
        '
        Me.EDITButton4.Location = New System.Drawing.Point(344, 209)
        Me.EDITButton4.Name = "EDITButton4"
        Me.EDITButton4.Size = New System.Drawing.Size(75, 23)
        Me.EDITButton4.TabIndex = 19
        Me.EDITButton4.Text = "EDIT"
        Me.EDITButton4.UseVisualStyleBackColor = True
        '
        'HAPUSButton5
        '
        Me.HAPUSButton5.Location = New System.Drawing.Point(472, 209)
        Me.HAPUSButton5.Name = "HAPUSButton5"
        Me.HAPUSButton5.Size = New System.Drawing.Size(75, 23)
        Me.HAPUSButton5.TabIndex = 20
        Me.HAPUSButton5.Text = "HAPUS"
        Me.HAPUSButton5.UseVisualStyleBackColor = True
        '
        'REFRESHButton6
        '
        Me.REFRESHButton6.Location = New System.Drawing.Point(592, 209)
        Me.REFRESHButton6.Name = "REFRESHButton6"
        Me.REFRESHButton6.Size = New System.Drawing.Size(75, 23)
        Me.REFRESHButton6.TabIndex = 21
        Me.REFRESHButton6.Text = "REFRESH"
        Me.REFRESHButton6.UseVisualStyleBackColor = True
        '
        'BATALButton7
        '
        Me.BATALButton7.Location = New System.Drawing.Point(472, 261)
        Me.BATALButton7.Name = "BATALButton7"
        Me.BATALButton7.Size = New System.Drawing.Size(75, 23)
        Me.BATALButton7.TabIndex = 22
        Me.BATALButton7.Text = "BATAL"
        Me.BATALButton7.UseVisualStyleBackColor = True
        '
        'PASIEN_SP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 333)
        Me.Controls.Add(Me.BATALButton7)
        Me.Controls.Add(Me.REFRESHButton6)
        Me.Controls.Add(Me.HAPUSButton5)
        Me.Controls.Add(Me.EDITButton4)
        Me.Controls.Add(Me.KELUARButton3)
        Me.Controls.Add(Me.SIMPANButton2)
        Me.Controls.Add(Me.TAMBAHButton1)
        Me.Controls.Add(ID_PASIENLabel)
        Me.Controls.Add(Me.ID_PASIENTextBox)
        Me.Controls.Add(NAMA_PASIENLabel)
        Me.Controls.Add(Me.NAMA_PASIENTextBox)
        Me.Controls.Add(J_KLabel)
        Me.Controls.Add(Me.J_KComboBox)
        Me.Controls.Add(KOTA_PASIENLabel)
        Me.Controls.Add(Me.KOTA_PASIENTextBox)
        Me.Controls.Add(ALAMATLabel)
        Me.Controls.Add(Me.ALAMATTextBox)
        Me.Controls.Add(KELUHANLabel)
        Me.Controls.Add(Me.KELUHANTextBox)
        Me.Controls.Add(UMURLabel)
        Me.Controls.Add(Me.UMURComboBox)
        Me.Controls.Add(Me.PasienDataGridView)
        Me.Controls.Add(Me.PasienBindingNavigator)
        Me.Name = "PASIEN_SP"
        Me.Text = "PASIEN_SP"
        CType(Me.Sistem_informasi_rumahsakitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasienBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasienBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PasienBindingNavigator.ResumeLayout(False)
        Me.PasienBindingNavigator.PerformLayout()
        CType(Me.PasienDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Sistem_informasi_rumahsakitDataSet As Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSet
    Friend WithEvents PasienBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PasienTableAdapter As Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.pasienTableAdapter
    Friend WithEvents TableAdapterManager As Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PasienBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PasienBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PasienDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_PASIENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NAMA_PASIENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents J_KComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents KOTA_PASIENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ALAMATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KELUHANTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UMURComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TAMBAHButton1 As System.Windows.Forms.Button
    Friend WithEvents SIMPANButton2 As System.Windows.Forms.Button
    Friend WithEvents KELUARButton3 As System.Windows.Forms.Button
    Friend WithEvents EDITButton4 As System.Windows.Forms.Button
    Friend WithEvents HAPUSButton5 As System.Windows.Forms.Button
    Friend WithEvents REFRESHButton6 As System.Windows.Forms.Button
    Friend WithEvents BATALButton7 As System.Windows.Forms.Button
End Class
