<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lobi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lobi))
        Me.Sistem_informasi_rumahsakitDataSet = New Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSet()
        Me.LobiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LobiTableAdapter = New Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.lobiTableAdapter()
        Me.TableAdapterManager = New Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.TableAdapterManager()
        Me.LobiBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.LobiBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.LobiDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tambah = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Sistem_informasi_rumahsakitDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LobiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LobiBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LobiBindingNavigator.SuspendLayout()
        CType(Me.LobiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sistem_informasi_rumahsakitDataSet
        '
        Me.Sistem_informasi_rumahsakitDataSet.DataSetName = "sistem_informasi_rumahsakitDataSet"
        Me.Sistem_informasi_rumahsakitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LobiBindingSource
        '
        Me.LobiBindingSource.DataMember = "lobi"
        Me.LobiBindingSource.DataSource = Me.Sistem_informasi_rumahsakitDataSet
        '
        'LobiTableAdapter
        '
        Me.LobiTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dokter_has_obatTableAdapter = Nothing
        Me.TableAdapterManager.dokterTableAdapter = Nothing
        Me.TableAdapterManager.kasirTableAdapter = Nothing
        Me.TableAdapterManager.lobiTableAdapter = Me.LobiTableAdapter
        Me.TableAdapterManager.obatTableAdapter = Nothing
        Me.TableAdapterManager.pasien_has_obatTableAdapter = Nothing
        Me.TableAdapterManager.pasienTableAdapter = Nothing
        Me.TableAdapterManager.ruangan_has_dokterTableAdapter = Nothing
        Me.TableAdapterManager.ruanganTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LobiBindingNavigator
        '
        Me.LobiBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LobiBindingNavigator.BindingSource = Me.LobiBindingSource
        Me.LobiBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LobiBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LobiBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LobiBindingNavigatorSaveItem})
        Me.LobiBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LobiBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LobiBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LobiBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LobiBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LobiBindingNavigator.Name = "LobiBindingNavigator"
        Me.LobiBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LobiBindingNavigator.Size = New System.Drawing.Size(1354, 25)
        Me.LobiBindingNavigator.TabIndex = 0
        Me.LobiBindingNavigator.Text = "BindingNavigator1"
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
        'LobiBindingNavigatorSaveItem
        '
        Me.LobiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LobiBindingNavigatorSaveItem.Image = CType(resources.GetObject("LobiBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LobiBindingNavigatorSaveItem.Name = "LobiBindingNavigatorSaveItem"
        Me.LobiBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LobiBindingNavigatorSaveItem.Text = "Save Data"
        '
        'LobiDataGridView
        '
        Me.LobiDataGridView.AutoGenerateColumns = False
        Me.LobiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LobiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.LobiDataGridView.DataSource = Me.LobiBindingSource
        Me.LobiDataGridView.Location = New System.Drawing.Point(365, 70)
        Me.LobiDataGridView.Name = "LobiDataGridView"
        Me.LobiDataGridView.Size = New System.Drawing.Size(541, 220)
        Me.LobiDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NO_URUT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NO_URUT"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "KELUHAN"
        Me.DataGridViewTextBoxColumn3.HeaderText = "KELUHAN"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TGL_DAFTAR"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TGL_DAFTAR"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Pasien_ID_PASIEN"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Pasien_ID_PASIEN"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'tambah
        '
        Me.tambah.Location = New System.Drawing.Point(12, 89)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(75, 23)
        Me.tambah.TabIndex = 2
        Me.tambah.Text = "hapus"
        Me.tambah.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(156, 89)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "tambah"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(261, 89)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "edit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(156, 147)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "keluar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Lobi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 732)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.tambah)
        Me.Controls.Add(Me.LobiDataGridView)
        Me.Controls.Add(Me.LobiBindingNavigator)
        Me.Name = "Lobi"
        Me.Text = "Lobi"
        CType(Me.Sistem_informasi_rumahsakitDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LobiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LobiBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LobiBindingNavigator.ResumeLayout(False)
        Me.LobiBindingNavigator.PerformLayout()
        CType(Me.LobiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Sistem_informasi_rumahsakitDataSet As Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSet
    Friend WithEvents LobiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LobiTableAdapter As Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.lobiTableAdapter
    Friend WithEvents TableAdapterManager As Sistem_Informasi_Rumah_Sakit__SIRUSAK_.sistem_informasi_rumahsakitDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LobiBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents LobiBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents LobiDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tambah As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
