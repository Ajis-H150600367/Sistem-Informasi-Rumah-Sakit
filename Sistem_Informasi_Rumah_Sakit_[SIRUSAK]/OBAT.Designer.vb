<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OBAT
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
        Dim ID_OBATLabel As System.Windows.Forms.Label
        Dim NAMA_OBATLabel As System.Windows.Forms.Label
        Dim MASA_BERLAKULabel As System.Windows.Forms.Label
        Dim HARGALabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OBAT))
        Me.Sistem_informasi_rumahsakitDataSet = New Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSet()
        Me.ObatBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ObatTableAdapter = New Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.obatTableAdapter()
        Me.TableAdapterManager = New Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.TableAdapterManager()
        Me.ObatBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ObatBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ObatDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_OBATTextBox = New System.Windows.Forms.TextBox()
        Me.NAMA_OBATTextBox = New System.Windows.Forms.TextBox()
        Me.MASA_BERLAKUDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.HARGATextBox = New System.Windows.Forms.TextBox()
        Me.TAMBAHButton1 = New System.Windows.Forms.Button()
        Me.SIMPANButton2 = New System.Windows.Forms.Button()
        Me.KELUARButton3 = New System.Windows.Forms.Button()
        Me.EDITButton4 = New System.Windows.Forms.Button()
        Me.REFRESHButton5 = New System.Windows.Forms.Button()
        Me.BATALButton6 = New System.Windows.Forms.Button()
        Me.HAPUSButton7 = New System.Windows.Forms.Button()
        ID_OBATLabel = New System.Windows.Forms.Label()
        NAMA_OBATLabel = New System.Windows.Forms.Label()
        MASA_BERLAKULabel = New System.Windows.Forms.Label()
        HARGALabel = New System.Windows.Forms.Label()
        CType(Me.Sistem_informasi_rumahsakitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObatBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ObatBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ObatBindingNavigator.SuspendLayout()
        CType(Me.ObatDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_OBATLabel
        '
        ID_OBATLabel.AutoSize = True
        ID_OBATLabel.Location = New System.Drawing.Point(518, 42)
        ID_OBATLabel.Name = "ID_OBATLabel"
        ID_OBATLabel.Size = New System.Drawing.Size(53, 13)
        ID_OBATLabel.TabIndex = 2
        ID_OBATLabel.Text = "ID OBAT:"
        '
        'NAMA_OBATLabel
        '
        NAMA_OBATLabel.AutoSize = True
        NAMA_OBATLabel.Location = New System.Drawing.Point(518, 68)
        NAMA_OBATLabel.Name = "NAMA_OBATLabel"
        NAMA_OBATLabel.Size = New System.Drawing.Size(73, 13)
        NAMA_OBATLabel.TabIndex = 4
        NAMA_OBATLabel.Text = "NAMA OBAT:"
        '
        'MASA_BERLAKULabel
        '
        MASA_BERLAKULabel.AutoSize = True
        MASA_BERLAKULabel.Location = New System.Drawing.Point(518, 95)
        MASA_BERLAKULabel.Name = "MASA_BERLAKULabel"
        MASA_BERLAKULabel.Size = New System.Drawing.Size(93, 13)
        MASA_BERLAKULabel.TabIndex = 6
        MASA_BERLAKULabel.Text = "MASA BERLAKU:"
        '
        'HARGALabel
        '
        HARGALabel.AutoSize = True
        HARGALabel.Location = New System.Drawing.Point(518, 120)
        HARGALabel.Name = "HARGALabel"
        HARGALabel.Size = New System.Drawing.Size(48, 13)
        HARGALabel.TabIndex = 8
        HARGALabel.Text = "HARGA:"
        '
        'Sistem_informasi_rumahsakitDataSet
        '
        Me.Sistem_informasi_rumahsakitDataSet.DataSetName = "sistem_informasi_rumahsakitDataSet"
        Me.Sistem_informasi_rumahsakitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ObatBindingSource
        '
        Me.ObatBindingSource.DataMember = "obat"
        Me.ObatBindingSource.DataSource = Me.Sistem_informasi_rumahsakitDataSet
        '
        'ObatTableAdapter
        '
        Me.ObatTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dokter_has_obatTableAdapter = Nothing
        Me.TableAdapterManager.dokterTableAdapter = Nothing
        Me.TableAdapterManager.kasirTableAdapter = Nothing
        Me.TableAdapterManager.lobiTableAdapter = Nothing
        Me.TableAdapterManager.obatTableAdapter = Me.ObatTableAdapter
        Me.TableAdapterManager.pasien_has_obatTableAdapter = Nothing
        Me.TableAdapterManager.pasienTableAdapter = Nothing
        Me.TableAdapterManager.ruangan_has_dokterTableAdapter = Nothing
        Me.TableAdapterManager.ruanganTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ObatBindingNavigator
        '
        Me.ObatBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ObatBindingNavigator.BindingSource = Me.ObatBindingSource
        Me.ObatBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ObatBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ObatBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ObatBindingNavigatorSaveItem})
        Me.ObatBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ObatBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ObatBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ObatBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ObatBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ObatBindingNavigator.Name = "ObatBindingNavigator"
        Me.ObatBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ObatBindingNavigator.Size = New System.Drawing.Size(1354, 25)
        Me.ObatBindingNavigator.TabIndex = 0
        Me.ObatBindingNavigator.Text = "BindingNavigator1"
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
        'ObatBindingNavigatorSaveItem
        '
        Me.ObatBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ObatBindingNavigatorSaveItem.Image = CType(resources.GetObject("ObatBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ObatBindingNavigatorSaveItem.Name = "ObatBindingNavigatorSaveItem"
        Me.ObatBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ObatBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ObatDataGridView
        '
        Me.ObatDataGridView.AutoGenerateColumns = False
        Me.ObatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ObatDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ObatDataGridView.DataSource = Me.ObatBindingSource
        Me.ObatDataGridView.Location = New System.Drawing.Point(12, 39)
        Me.ObatDataGridView.Name = "ObatDataGridView"
        Me.ObatDataGridView.Size = New System.Drawing.Size(488, 259)
        Me.ObatDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_OBAT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_OBAT"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NAMA_OBAT"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NAMA_OBAT"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "MASA_BERLAKU"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MASA_BERLAKU"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "HARGA"
        Me.DataGridViewTextBoxColumn4.HeaderText = "HARGA"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'ID_OBATTextBox
        '
        Me.ID_OBATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObatBindingSource, "ID_OBAT", True))
        Me.ID_OBATTextBox.Location = New System.Drawing.Point(617, 39)
        Me.ID_OBATTextBox.Name = "ID_OBATTextBox"
        Me.ID_OBATTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_OBATTextBox.TabIndex = 3
        '
        'NAMA_OBATTextBox
        '
        Me.NAMA_OBATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObatBindingSource, "NAMA_OBAT", True))
        Me.NAMA_OBATTextBox.Location = New System.Drawing.Point(617, 65)
        Me.NAMA_OBATTextBox.Name = "NAMA_OBATTextBox"
        Me.NAMA_OBATTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NAMA_OBATTextBox.TabIndex = 5
        '
        'MASA_BERLAKUDateTimePicker
        '
        Me.MASA_BERLAKUDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ObatBindingSource, "MASA_BERLAKU", True))
        Me.MASA_BERLAKUDateTimePicker.Location = New System.Drawing.Point(617, 91)
        Me.MASA_BERLAKUDateTimePicker.Name = "MASA_BERLAKUDateTimePicker"
        Me.MASA_BERLAKUDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.MASA_BERLAKUDateTimePicker.TabIndex = 7
        '
        'HARGATextBox
        '
        Me.HARGATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ObatBindingSource, "HARGA", True))
        Me.HARGATextBox.Location = New System.Drawing.Point(617, 117)
        Me.HARGATextBox.Name = "HARGATextBox"
        Me.HARGATextBox.Size = New System.Drawing.Size(200, 20)
        Me.HARGATextBox.TabIndex = 9
        '
        'TAMBAHButton1
        '
        Me.TAMBAHButton1.Location = New System.Drawing.Point(12, 317)
        Me.TAMBAHButton1.Name = "TAMBAHButton1"
        Me.TAMBAHButton1.Size = New System.Drawing.Size(95, 28)
        Me.TAMBAHButton1.TabIndex = 10
        Me.TAMBAHButton1.Text = "TAMBAH"
        Me.TAMBAHButton1.UseVisualStyleBackColor = True
        '
        'SIMPANButton2
        '
        Me.SIMPANButton2.Location = New System.Drawing.Point(123, 317)
        Me.SIMPANButton2.Name = "SIMPANButton2"
        Me.SIMPANButton2.Size = New System.Drawing.Size(95, 28)
        Me.SIMPANButton2.TabIndex = 11
        Me.SIMPANButton2.Text = "SIMPAN"
        Me.SIMPANButton2.UseVisualStyleBackColor = True
        '
        'KELUARButton3
        '
        Me.KELUARButton3.Location = New System.Drawing.Point(379, 317)
        Me.KELUARButton3.Name = "KELUARButton3"
        Me.KELUARButton3.Size = New System.Drawing.Size(95, 28)
        Me.KELUARButton3.TabIndex = 12
        Me.KELUARButton3.Text = "KELUAR"
        Me.KELUARButton3.UseVisualStyleBackColor = True
        '
        'EDITButton4
        '
        Me.EDITButton4.Location = New System.Drawing.Point(12, 364)
        Me.EDITButton4.Name = "EDITButton4"
        Me.EDITButton4.Size = New System.Drawing.Size(95, 28)
        Me.EDITButton4.TabIndex = 13
        Me.EDITButton4.Text = "EDIT"
        Me.EDITButton4.UseVisualStyleBackColor = True
        '
        'REFRESHButton5
        '
        Me.REFRESHButton5.Location = New System.Drawing.Point(255, 317)
        Me.REFRESHButton5.Name = "REFRESHButton5"
        Me.REFRESHButton5.Size = New System.Drawing.Size(95, 28)
        Me.REFRESHButton5.TabIndex = 14
        Me.REFRESHButton5.Text = "REFRESH"
        Me.REFRESHButton5.UseVisualStyleBackColor = True
        '
        'BATALButton6
        '
        Me.BATALButton6.Location = New System.Drawing.Point(255, 364)
        Me.BATALButton6.Name = "BATALButton6"
        Me.BATALButton6.Size = New System.Drawing.Size(95, 28)
        Me.BATALButton6.TabIndex = 15
        Me.BATALButton6.Text = "BATAL"
        Me.BATALButton6.UseVisualStyleBackColor = True
        '
        'HAPUSButton7
        '
        Me.HAPUSButton7.Location = New System.Drawing.Point(123, 364)
        Me.HAPUSButton7.Name = "HAPUSButton7"
        Me.HAPUSButton7.Size = New System.Drawing.Size(95, 28)
        Me.HAPUSButton7.TabIndex = 16
        Me.HAPUSButton7.Text = "HAPUS"
        Me.HAPUSButton7.UseVisualStyleBackColor = True
        '
        'OBAT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 732)
        Me.Controls.Add(Me.HAPUSButton7)
        Me.Controls.Add(Me.BATALButton6)
        Me.Controls.Add(Me.REFRESHButton5)
        Me.Controls.Add(Me.EDITButton4)
        Me.Controls.Add(Me.KELUARButton3)
        Me.Controls.Add(Me.SIMPANButton2)
        Me.Controls.Add(Me.TAMBAHButton1)
        Me.Controls.Add(ID_OBATLabel)
        Me.Controls.Add(Me.ID_OBATTextBox)
        Me.Controls.Add(NAMA_OBATLabel)
        Me.Controls.Add(Me.NAMA_OBATTextBox)
        Me.Controls.Add(MASA_BERLAKULabel)
        Me.Controls.Add(Me.MASA_BERLAKUDateTimePicker)
        Me.Controls.Add(HARGALabel)
        Me.Controls.Add(Me.HARGATextBox)
        Me.Controls.Add(Me.ObatDataGridView)
        Me.Controls.Add(Me.ObatBindingNavigator)
        Me.Name = "OBAT"
        Me.Text = "OBAT"
        CType(Me.Sistem_informasi_rumahsakitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObatBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ObatBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ObatBindingNavigator.ResumeLayout(False)
        Me.ObatBindingNavigator.PerformLayout()
        CType(Me.ObatDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Sistem_informasi_rumahsakitDataSet As Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSet
    Friend WithEvents ObatBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ObatTableAdapter As Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.obatTableAdapter
    Friend WithEvents TableAdapterManager As Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ObatBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ObatBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ObatDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ID_OBATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NAMA_OBATTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MASA_BERLAKUDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents HARGATextBox As System.Windows.Forms.TextBox
    Friend WithEvents TAMBAHButton1 As System.Windows.Forms.Button
    Friend WithEvents SIMPANButton2 As System.Windows.Forms.Button
    Friend WithEvents KELUARButton3 As System.Windows.Forms.Button
    Friend WithEvents EDITButton4 As System.Windows.Forms.Button
    Friend WithEvents REFRESHButton5 As System.Windows.Forms.Button
    Friend WithEvents BATALButton6 As System.Windows.Forms.Button
    Friend WithEvents HAPUSButton7 As System.Windows.Forms.Button
End Class
