<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DOKTER_SP
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
        Dim ID_DOKTERLabel As System.Windows.Forms.Label
        Dim NAMA_DOKTERLabel As System.Windows.Forms.Label
        Dim SPESIALISLabel As System.Windows.Forms.Label
        Dim ALAMATLabel As System.Windows.Forms.Label
        Dim NO_TELPONLabel As System.Windows.Forms.Label
        Dim Pasien_ID_PASIENLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DOKTER_SP))
        Me.Sistem_informasi_rumahsakitDataSet = New Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSet()
        Me.DokterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DokterTableAdapter = New Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.dokterTableAdapter()
        Me.TableAdapterManager = New Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.TableAdapterManager()
        Me.DokterBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DokterBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DokterDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_DOKTERTextBox = New System.Windows.Forms.TextBox()
        Me.NAMA_DOKTERTextBox = New System.Windows.Forms.TextBox()
        Me.SPESIALISTextBox = New System.Windows.Forms.TextBox()
        Me.ALAMATTextBox = New System.Windows.Forms.TextBox()
        Me.NO_TELPONTextBox = New System.Windows.Forms.TextBox()
        Me.Pasien_ID_PASIENTextBox = New System.Windows.Forms.TextBox()
        Me.TAMBAHButton1 = New System.Windows.Forms.Button()
        Me.SIMPANButton2 = New System.Windows.Forms.Button()
        Me.KELUARButton3 = New System.Windows.Forms.Button()
        Me.REFRESHButton4 = New System.Windows.Forms.Button()
        Me.BATALButton5 = New System.Windows.Forms.Button()
        Me.HAPUSButton6 = New System.Windows.Forms.Button()
        Me.EDITButton7 = New System.Windows.Forms.Button()
        ID_DOKTERLabel = New System.Windows.Forms.Label()
        NAMA_DOKTERLabel = New System.Windows.Forms.Label()
        SPESIALISLabel = New System.Windows.Forms.Label()
        ALAMATLabel = New System.Windows.Forms.Label()
        NO_TELPONLabel = New System.Windows.Forms.Label()
        Pasien_ID_PASIENLabel = New System.Windows.Forms.Label()
        CType(Me.Sistem_informasi_rumahsakitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DokterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DokterBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DokterBindingNavigator.SuspendLayout()
        CType(Me.DokterDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_DOKTERLabel
        '
        ID_DOKTERLabel.AutoSize = True
        ID_DOKTERLabel.Location = New System.Drawing.Point(12, 117)
        ID_DOKTERLabel.Name = "ID_DOKTERLabel"
        ID_DOKTERLabel.Size = New System.Drawing.Size(69, 13)
        ID_DOKTERLabel.TabIndex = 2
        ID_DOKTERLabel.Text = "ID DOKTER:"
        '
        'NAMA_DOKTERLabel
        '
        NAMA_DOKTERLabel.AutoSize = True
        NAMA_DOKTERLabel.Location = New System.Drawing.Point(12, 143)
        NAMA_DOKTERLabel.Name = "NAMA_DOKTERLabel"
        NAMA_DOKTERLabel.Size = New System.Drawing.Size(89, 13)
        NAMA_DOKTERLabel.TabIndex = 4
        NAMA_DOKTERLabel.Text = "NAMA DOKTER:"
        '
        'SPESIALISLabel
        '
        SPESIALISLabel.AutoSize = True
        SPESIALISLabel.Location = New System.Drawing.Point(12, 169)
        SPESIALISLabel.Name = "SPESIALISLabel"
        SPESIALISLabel.Size = New System.Drawing.Size(64, 13)
        SPESIALISLabel.TabIndex = 6
        SPESIALISLabel.Text = "SPESIALIS:"
        '
        'ALAMATLabel
        '
        ALAMATLabel.AutoSize = True
        ALAMATLabel.Location = New System.Drawing.Point(12, 195)
        ALAMATLabel.Name = "ALAMATLabel"
        ALAMATLabel.Size = New System.Drawing.Size(53, 13)
        ALAMATLabel.TabIndex = 8
        ALAMATLabel.Text = "ALAMAT:"
        '
        'NO_TELPONLabel
        '
        NO_TELPONLabel.AutoSize = True
        NO_TELPONLabel.Location = New System.Drawing.Point(12, 221)
        NO_TELPONLabel.Name = "NO_TELPONLabel"
        NO_TELPONLabel.Size = New System.Drawing.Size(72, 13)
        NO_TELPONLabel.TabIndex = 10
        NO_TELPONLabel.Text = "NO TELPON:"
        '
        'Pasien_ID_PASIENLabel
        '
        Pasien_ID_PASIENLabel.AutoSize = True
        Pasien_ID_PASIENLabel.Location = New System.Drawing.Point(12, 247)
        Pasien_ID_PASIENLabel.Name = "Pasien_ID_PASIENLabel"
        Pasien_ID_PASIENLabel.Size = New System.Drawing.Size(98, 13)
        Pasien_ID_PASIENLabel.TabIndex = 12
        Pasien_ID_PASIENLabel.Text = "Pasien ID PASIEN:"
        '
        'Sistem_informasi_rumahsakitDataSet
        '
        Me.Sistem_informasi_rumahsakitDataSet.DataSetName = "sistem_informasi_rumahsakitDataSet"
        Me.Sistem_informasi_rumahsakitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DokterBindingSource
        '
        Me.DokterBindingSource.DataMember = "dokter"
        Me.DokterBindingSource.DataSource = Me.Sistem_informasi_rumahsakitDataSet
        '
        'DokterTableAdapter
        '
        Me.DokterTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dokter_has_obatTableAdapter = Nothing
        Me.TableAdapterManager.dokterTableAdapter = Me.DokterTableAdapter
        Me.TableAdapterManager.kasirTableAdapter = Nothing
        Me.TableAdapterManager.lobiTableAdapter = Nothing
        Me.TableAdapterManager.obatTableAdapter = Nothing
        Me.TableAdapterManager.pasien_has_obatTableAdapter = Nothing
        Me.TableAdapterManager.pasienTableAdapter = Nothing
        Me.TableAdapterManager.ruangan_has_dokterTableAdapter = Nothing
        Me.TableAdapterManager.ruanganTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DokterBindingNavigator
        '
        Me.DokterBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DokterBindingNavigator.BindingSource = Me.DokterBindingSource
        Me.DokterBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DokterBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DokterBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DokterBindingNavigatorSaveItem})
        Me.DokterBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DokterBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DokterBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DokterBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DokterBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DokterBindingNavigator.Name = "DokterBindingNavigator"
        Me.DokterBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DokterBindingNavigator.Size = New System.Drawing.Size(732, 25)
        Me.DokterBindingNavigator.TabIndex = 0
        Me.DokterBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(47, 22)
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
        'DokterBindingNavigatorSaveItem
        '
        Me.DokterBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DokterBindingNavigatorSaveItem.Image = CType(resources.GetObject("DokterBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DokterBindingNavigatorSaveItem.Name = "DokterBindingNavigatorSaveItem"
        Me.DokterBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DokterBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DokterDataGridView
        '
        Me.DokterDataGridView.AutoGenerateColumns = False
        Me.DokterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DokterDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DokterDataGridView.DataSource = Me.DokterBindingSource
        Me.DokterDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.DokterDataGridView.Name = "DokterDataGridView"
        Me.DokterDataGridView.Size = New System.Drawing.Size(646, 66)
        Me.DokterDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_DOKTER"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_DOKTER"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NAMA_DOKTER"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NAMA_DOKTER"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SPESIALIS"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SPESIALIS"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ALAMAT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ALAMAT"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "NO_TELPON"
        Me.DataGridViewTextBoxColumn5.HeaderText = "NO_TELPON"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Pasien_ID_PASIEN"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Pasien_ID_PASIEN"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'ID_DOKTERTextBox
        '
        Me.ID_DOKTERTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokterBindingSource, "ID_DOKTER", True))
        Me.ID_DOKTERTextBox.Location = New System.Drawing.Point(116, 114)
        Me.ID_DOKTERTextBox.Name = "ID_DOKTERTextBox"
        Me.ID_DOKTERTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_DOKTERTextBox.TabIndex = 3
        '
        'NAMA_DOKTERTextBox
        '
        Me.NAMA_DOKTERTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokterBindingSource, "NAMA_DOKTER", True))
        Me.NAMA_DOKTERTextBox.Location = New System.Drawing.Point(116, 140)
        Me.NAMA_DOKTERTextBox.Name = "NAMA_DOKTERTextBox"
        Me.NAMA_DOKTERTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NAMA_DOKTERTextBox.TabIndex = 5
        '
        'SPESIALISTextBox
        '
        Me.SPESIALISTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokterBindingSource, "SPESIALIS", True))
        Me.SPESIALISTextBox.Location = New System.Drawing.Point(116, 166)
        Me.SPESIALISTextBox.Name = "SPESIALISTextBox"
        Me.SPESIALISTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SPESIALISTextBox.TabIndex = 7
        '
        'ALAMATTextBox
        '
        Me.ALAMATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokterBindingSource, "ALAMAT", True))
        Me.ALAMATTextBox.Location = New System.Drawing.Point(116, 192)
        Me.ALAMATTextBox.Name = "ALAMATTextBox"
        Me.ALAMATTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ALAMATTextBox.TabIndex = 9
        '
        'NO_TELPONTextBox
        '
        Me.NO_TELPONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokterBindingSource, "NO_TELPON", True))
        Me.NO_TELPONTextBox.Location = New System.Drawing.Point(116, 218)
        Me.NO_TELPONTextBox.Name = "NO_TELPONTextBox"
        Me.NO_TELPONTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NO_TELPONTextBox.TabIndex = 11
        '
        'Pasien_ID_PASIENTextBox
        '
        Me.Pasien_ID_PASIENTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokterBindingSource, "Pasien_ID_PASIEN", True))
        Me.Pasien_ID_PASIENTextBox.Location = New System.Drawing.Point(116, 244)
        Me.Pasien_ID_PASIENTextBox.Name = "Pasien_ID_PASIENTextBox"
        Me.Pasien_ID_PASIENTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Pasien_ID_PASIENTextBox.TabIndex = 13
        '
        'TAMBAHButton1
        '
        Me.TAMBAHButton1.Location = New System.Drawing.Point(287, 114)
        Me.TAMBAHButton1.Name = "TAMBAHButton1"
        Me.TAMBAHButton1.Size = New System.Drawing.Size(75, 23)
        Me.TAMBAHButton1.TabIndex = 14
        Me.TAMBAHButton1.Text = "TAMBAH"
        Me.TAMBAHButton1.UseVisualStyleBackColor = True
        '
        'SIMPANButton2
        '
        Me.SIMPANButton2.Location = New System.Drawing.Point(287, 164)
        Me.SIMPANButton2.Name = "SIMPANButton2"
        Me.SIMPANButton2.Size = New System.Drawing.Size(75, 23)
        Me.SIMPANButton2.TabIndex = 15
        Me.SIMPANButton2.Text = "SIMPAN"
        Me.SIMPANButton2.UseVisualStyleBackColor = True
        '
        'KELUARButton3
        '
        Me.KELUARButton3.Location = New System.Drawing.Point(287, 221)
        Me.KELUARButton3.Name = "KELUARButton3"
        Me.KELUARButton3.Size = New System.Drawing.Size(75, 23)
        Me.KELUARButton3.TabIndex = 16
        Me.KELUARButton3.Text = "KELUAR"
        Me.KELUARButton3.UseVisualStyleBackColor = True
        '
        'REFRESHButton4
        '
        Me.REFRESHButton4.Location = New System.Drawing.Point(400, 117)
        Me.REFRESHButton4.Name = "REFRESHButton4"
        Me.REFRESHButton4.Size = New System.Drawing.Size(75, 23)
        Me.REFRESHButton4.TabIndex = 17
        Me.REFRESHButton4.Text = "REFRESH"
        Me.REFRESHButton4.UseVisualStyleBackColor = True
        '
        'BATALButton5
        '
        Me.BATALButton5.Location = New System.Drawing.Point(400, 166)
        Me.BATALButton5.Name = "BATALButton5"
        Me.BATALButton5.Size = New System.Drawing.Size(75, 23)
        Me.BATALButton5.TabIndex = 18
        Me.BATALButton5.Text = "BATAL"
        Me.BATALButton5.UseVisualStyleBackColor = True
        '
        'HAPUSButton6
        '
        Me.HAPUSButton6.Location = New System.Drawing.Point(400, 218)
        Me.HAPUSButton6.Name = "HAPUSButton6"
        Me.HAPUSButton6.Size = New System.Drawing.Size(75, 23)
        Me.HAPUSButton6.TabIndex = 19
        Me.HAPUSButton6.Text = "HAPUS"
        Me.HAPUSButton6.UseVisualStyleBackColor = True
        '
        'EDITButton7
        '
        Me.EDITButton7.Location = New System.Drawing.Point(523, 169)
        Me.EDITButton7.Name = "EDITButton7"
        Me.EDITButton7.Size = New System.Drawing.Size(75, 23)
        Me.EDITButton7.TabIndex = 20
        Me.EDITButton7.Text = "EDIT"
        Me.EDITButton7.UseVisualStyleBackColor = True
        '
        'DOKTER_SP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 296)
        Me.Controls.Add(Me.EDITButton7)
        Me.Controls.Add(Me.HAPUSButton6)
        Me.Controls.Add(Me.BATALButton5)
        Me.Controls.Add(Me.REFRESHButton4)
        Me.Controls.Add(Me.KELUARButton3)
        Me.Controls.Add(Me.SIMPANButton2)
        Me.Controls.Add(Me.TAMBAHButton1)
        Me.Controls.Add(ID_DOKTERLabel)
        Me.Controls.Add(Me.ID_DOKTERTextBox)
        Me.Controls.Add(NAMA_DOKTERLabel)
        Me.Controls.Add(Me.NAMA_DOKTERTextBox)
        Me.Controls.Add(SPESIALISLabel)
        Me.Controls.Add(Me.SPESIALISTextBox)
        Me.Controls.Add(ALAMATLabel)
        Me.Controls.Add(Me.ALAMATTextBox)
        Me.Controls.Add(NO_TELPONLabel)
        Me.Controls.Add(Me.NO_TELPONTextBox)
        Me.Controls.Add(Pasien_ID_PASIENLabel)
        Me.Controls.Add(Me.Pasien_ID_PASIENTextBox)
        Me.Controls.Add(Me.DokterDataGridView)
        Me.Controls.Add(Me.DokterBindingNavigator)
        Me.Name = "DOKTER_SP"
        Me.Text = "DOKTER_SP"
        CType(Me.Sistem_informasi_rumahsakitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DokterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DokterBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DokterBindingNavigator.ResumeLayout(False)
        Me.DokterBindingNavigator.PerformLayout()
        CType(Me.DokterDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Sistem_informasi_rumahsakitDataSet As Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSet
    Friend WithEvents DokterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DokterTableAdapter As Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.dokterTableAdapter
    Friend WithEvents TableAdapterManager As Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DokterBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents DokterBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DokterDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_DOKTERTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NAMA_DOKTERTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SPESIALISTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ALAMATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NO_TELPONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pasien_ID_PASIENTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TAMBAHButton1 As System.Windows.Forms.Button
    Friend WithEvents SIMPANButton2 As System.Windows.Forms.Button
    Friend WithEvents KELUARButton3 As System.Windows.Forms.Button
    Friend WithEvents REFRESHButton4 As System.Windows.Forms.Button
    Friend WithEvents BATALButton5 As System.Windows.Forms.Button
    Friend WithEvents HAPUSButton6 As System.Windows.Forms.Button
    Friend WithEvents EDITButton7 As System.Windows.Forms.Button
End Class
