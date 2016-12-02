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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pasien))
        Dim ID_PASIENLabel As System.Windows.Forms.Label
        Dim NAMA_PASIENLabel As System.Windows.Forms.Label
        Dim J_KLabel As System.Windows.Forms.Label
        Dim KOTA_PASIENLabel As System.Windows.Forms.Label
        Dim ALAMATLabel As System.Windows.Forms.Label
        Dim KELUHANLabel As System.Windows.Forms.Label
        Dim UMURLabel As System.Windows.Forms.Label
        Me.Sistem_informasi_rumahsakitDataSet = New Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSet()
        Me.PasienBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PasienTableAdapter = New Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.pasienTableAdapter()
        Me.TableAdapterManager = New Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.TableAdapterManager()
        Me.PasienBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PasienBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PasienDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ID_PASIENTextBox = New System.Windows.Forms.TextBox()
        Me.NAMA_PASIENTextBox = New System.Windows.Forms.TextBox()
        Me.J_KComboBox = New System.Windows.Forms.ComboBox()
        Me.KOTA_PASIENTextBox = New System.Windows.Forms.TextBox()
        Me.ALAMATTextBox = New System.Windows.Forms.TextBox()
        Me.KELUHANTextBox = New System.Windows.Forms.TextBox()
        Me.UMURComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
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
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.PasienBindingNavigator.Size = New System.Drawing.Size(1058, 29)
        Me.PasienBindingNavigator.TabIndex = 0
        Me.PasienBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 29)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(47, 26)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'PasienBindingNavigatorSaveItem
        '
        Me.PasienBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PasienBindingNavigatorSaveItem.Image = CType(resources.GetObject("PasienBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PasienBindingNavigatorSaveItem.Name = "PasienBindingNavigatorSaveItem"
        Me.PasienBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 26)
        Me.PasienBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PasienDataGridView
        '
        Me.PasienDataGridView.AutoGenerateColumns = False
        Me.PasienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PasienDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.PasienDataGridView.DataSource = Me.PasienBindingSource
        Me.PasienDataGridView.Location = New System.Drawing.Point(0, 34)
        Me.PasienDataGridView.Name = "PasienDataGridView"
        Me.PasienDataGridView.Size = New System.Drawing.Size(698, 322)
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(704, 34)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(342, 322)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(ID_PASIENLabel)
        Me.TabPage1.Controls.Add(Me.ID_PASIENTextBox)
        Me.TabPage1.Controls.Add(NAMA_PASIENLabel)
        Me.TabPage1.Controls.Add(Me.NAMA_PASIENTextBox)
        Me.TabPage1.Controls.Add(J_KLabel)
        Me.TabPage1.Controls.Add(Me.J_KComboBox)
        Me.TabPage1.Controls.Add(KOTA_PASIENLabel)
        Me.TabPage1.Controls.Add(Me.KOTA_PASIENTextBox)
        Me.TabPage1.Controls.Add(ALAMATLabel)
        Me.TabPage1.Controls.Add(Me.ALAMATTextBox)
        Me.TabPage1.Controls.Add(KELUHANLabel)
        Me.TabPage1.Controls.Add(Me.KELUHANTextBox)
        Me.TabPage1.Controls.Add(UMURLabel)
        Me.TabPage1.Controls.Add(Me.UMURComboBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(334, 296)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data Pasien"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(192, 74)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ID_PASIENLabel
        '
        ID_PASIENLabel.AutoSize = True
        ID_PASIENLabel.Location = New System.Drawing.Point(8, 9)
        ID_PASIENLabel.Name = "ID_PASIENLabel"
        ID_PASIENLabel.Size = New System.Drawing.Size(63, 13)
        ID_PASIENLabel.TabIndex = 0
        ID_PASIENLabel.Text = "ID PASIEN:"
        '
        'ID_PASIENTextBox
        '
        Me.ID_PASIENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "ID_PASIEN", True))
        Me.ID_PASIENTextBox.Enabled = False
        Me.ID_PASIENTextBox.Location = New System.Drawing.Point(97, 6)
        Me.ID_PASIENTextBox.Name = "ID_PASIENTextBox"
        Me.ID_PASIENTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ID_PASIENTextBox.TabIndex = 1
        '
        'NAMA_PASIENLabel
        '
        NAMA_PASIENLabel.AutoSize = True
        NAMA_PASIENLabel.Location = New System.Drawing.Point(8, 35)
        NAMA_PASIENLabel.Name = "NAMA_PASIENLabel"
        NAMA_PASIENLabel.Size = New System.Drawing.Size(83, 13)
        NAMA_PASIENLabel.TabIndex = 2
        NAMA_PASIENLabel.Text = "NAMA PASIEN:"
        '
        'NAMA_PASIENTextBox
        '
        Me.NAMA_PASIENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "NAMA_PASIEN", True))
        Me.NAMA_PASIENTextBox.Enabled = False
        Me.NAMA_PASIENTextBox.Location = New System.Drawing.Point(97, 32)
        Me.NAMA_PASIENTextBox.Name = "NAMA_PASIENTextBox"
        Me.NAMA_PASIENTextBox.Size = New System.Drawing.Size(121, 20)
        Me.NAMA_PASIENTextBox.TabIndex = 3
        '
        'J_KLabel
        '
        J_KLabel.AutoSize = True
        J_KLabel.Location = New System.Drawing.Point(8, 61)
        J_KLabel.Name = "J_KLabel"
        J_KLabel.Size = New System.Drawing.Size(25, 13)
        J_KLabel.TabIndex = 4
        J_KLabel.Text = "J K:"
        '
        'J_KComboBox
        '
        Me.J_KComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "J_K", True))
        Me.J_KComboBox.Enabled = False
        Me.J_KComboBox.FormattingEnabled = True
        Me.J_KComboBox.Items.AddRange(New Object() {"L", "P"})
        Me.J_KComboBox.Location = New System.Drawing.Point(97, 58)
        Me.J_KComboBox.Name = "J_KComboBox"
        Me.J_KComboBox.Size = New System.Drawing.Size(121, 21)
        Me.J_KComboBox.TabIndex = 5
        '
        'KOTA_PASIENLabel
        '
        KOTA_PASIENLabel.AutoSize = True
        KOTA_PASIENLabel.Location = New System.Drawing.Point(8, 88)
        KOTA_PASIENLabel.Name = "KOTA_PASIENLabel"
        KOTA_PASIENLabel.Size = New System.Drawing.Size(81, 13)
        KOTA_PASIENLabel.TabIndex = 6
        KOTA_PASIENLabel.Text = "KOTA PASIEN:"
        '
        'KOTA_PASIENTextBox
        '
        Me.KOTA_PASIENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "KOTA_PASIEN", True))
        Me.KOTA_PASIENTextBox.Enabled = False
        Me.KOTA_PASIENTextBox.Location = New System.Drawing.Point(97, 85)
        Me.KOTA_PASIENTextBox.Name = "KOTA_PASIENTextBox"
        Me.KOTA_PASIENTextBox.Size = New System.Drawing.Size(121, 20)
        Me.KOTA_PASIENTextBox.TabIndex = 7
        '
        'ALAMATLabel
        '
        ALAMATLabel.AutoSize = True
        ALAMATLabel.Location = New System.Drawing.Point(8, 114)
        ALAMATLabel.Name = "ALAMATLabel"
        ALAMATLabel.Size = New System.Drawing.Size(53, 13)
        ALAMATLabel.TabIndex = 8
        ALAMATLabel.Text = "ALAMAT:"
        '
        'ALAMATTextBox
        '
        Me.ALAMATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "ALAMAT", True))
        Me.ALAMATTextBox.Enabled = False
        Me.ALAMATTextBox.Location = New System.Drawing.Point(97, 111)
        Me.ALAMATTextBox.Name = "ALAMATTextBox"
        Me.ALAMATTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ALAMATTextBox.TabIndex = 9
        '
        'KELUHANLabel
        '
        KELUHANLabel.AutoSize = True
        KELUHANLabel.Location = New System.Drawing.Point(8, 140)
        KELUHANLabel.Name = "KELUHANLabel"
        KELUHANLabel.Size = New System.Drawing.Size(61, 13)
        KELUHANLabel.TabIndex = 10
        KELUHANLabel.Text = "KELUHAN:"
        '
        'KELUHANTextBox
        '
        Me.KELUHANTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "KELUHAN", True))
        Me.KELUHANTextBox.Enabled = False
        Me.KELUHANTextBox.Location = New System.Drawing.Point(97, 137)
        Me.KELUHANTextBox.Name = "KELUHANTextBox"
        Me.KELUHANTextBox.Size = New System.Drawing.Size(121, 20)
        Me.KELUHANTextBox.TabIndex = 11
        '
        'UMURLabel
        '
        UMURLabel.AutoSize = True
        UMURLabel.Location = New System.Drawing.Point(8, 166)
        UMURLabel.Name = "UMURLabel"
        UMURLabel.Size = New System.Drawing.Size(43, 13)
        UMURLabel.TabIndex = 12
        UMURLabel.Text = "UMUR:"
        '
        'UMURComboBox
        '
        Me.UMURComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PasienBindingSource, "UMUR", True))
        Me.UMURComboBox.Enabled = False
        Me.UMURComboBox.FormattingEnabled = True
        Me.UMURComboBox.Location = New System.Drawing.Point(97, 163)
        Me.UMURComboBox.Name = "UMURComboBox"
        Me.UMURComboBox.Size = New System.Drawing.Size(121, 21)
        Me.UMURComboBox.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 206)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Tambah"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(107, 206)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Simpan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(203, 206)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Hapus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Pasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 382)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PasienDataGridView)
        Me.Controls.Add(Me.PasienBindingNavigator)
        Me.Name = "Pasien"
        Me.Text = "Pasien"
        CType(Me.Sistem_informasi_rumahsakitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasienBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PasienBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PasienBindingNavigator.ResumeLayout(False)
        Me.PasienBindingNavigator.PerformLayout()
        CType(Me.PasienDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ID_PASIENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NAMA_PASIENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents J_KComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents KOTA_PASIENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ALAMATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KELUHANTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UMURComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
