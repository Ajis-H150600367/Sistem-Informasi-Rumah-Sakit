<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Beranda
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BerandaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LobiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RuanganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DokterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuPilihanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BerandaToolStripMenuItem, Me.MenuPilihanToolStripMenuItem, Me.CloseAllToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1015, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BerandaToolStripMenuItem
        '
        Me.BerandaToolStripMenuItem.BackColor = System.Drawing.Color.Lime
        Me.BerandaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PasienToolStripMenuItem, Me.LobiToolStripMenuItem, Me.RuanganToolStripMenuItem, Me.DokterToolStripMenuItem})
        Me.BerandaToolStripMenuItem.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BerandaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BerandaToolStripMenuItem.Name = "BerandaToolStripMenuItem"
        Me.BerandaToolStripMenuItem.Size = New System.Drawing.Size(90, 25)
        Me.BerandaToolStripMenuItem.Text = "&Beranda"
        '
        'PasienToolStripMenuItem
        '
        Me.PasienToolStripMenuItem.Name = "PasienToolStripMenuItem"
        Me.PasienToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.PasienToolStripMenuItem.Text = "&Pasien"
        '
        'LobiToolStripMenuItem
        '
        Me.LobiToolStripMenuItem.Name = "LobiToolStripMenuItem"
        Me.LobiToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.LobiToolStripMenuItem.Text = "&Lobi"
        '
        'RuanganToolStripMenuItem
        '
        Me.RuanganToolStripMenuItem.Name = "RuanganToolStripMenuItem"
        Me.RuanganToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.RuanganToolStripMenuItem.Text = "&Ruangan"
        '
        'DokterToolStripMenuItem
        '
        Me.DokterToolStripMenuItem.Name = "DokterToolStripMenuItem"
        Me.DokterToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.DokterToolStripMenuItem.Text = "&Dokter"
        '
        'MenuPilihanToolStripMenuItem
        '
        Me.MenuPilihanToolStripMenuItem.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuPilihanToolStripMenuItem.Name = "MenuPilihanToolStripMenuItem"
        Me.MenuPilihanToolStripMenuItem.Size = New System.Drawing.Size(128, 25)
        Me.MenuPilihanToolStripMenuItem.Text = "Menu Pilihan"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Font = New System.Drawing.Font("Elephant", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(91, 25)
        Me.CloseAllToolStripMenuItem.Text = "Close All"
        '
        'Beranda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 435)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Beranda"
        Me.Text = "Beranda"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents BerandaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasienToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LobiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RuanganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DokterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuPilihanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
