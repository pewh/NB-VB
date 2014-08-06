<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Menu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.PenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdministratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataKaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProcessNaiveBayesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LaporanNaiveBayesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenggunaToolStripMenuItem, Me.KaryawanToolStripMenuItem, Me.ProcessToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(881, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PenggunaToolStripMenuItem
        '
        Me.PenggunaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.AdministratorToolStripMenuItem})
        Me.PenggunaToolStripMenuItem.Name = "PenggunaToolStripMenuItem"
        Me.PenggunaToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.PenggunaToolStripMenuItem.Text = "Pengguna"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        Me.LoginToolStripMenuItem.Visible = False
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Enabled = False
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'AdministratorToolStripMenuItem
        '
        Me.AdministratorToolStripMenuItem.Name = "AdministratorToolStripMenuItem"
        Me.AdministratorToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AdministratorToolStripMenuItem.Text = "Administrator"
        Me.AdministratorToolStripMenuItem.Visible = False
        '
        'KaryawanToolStripMenuItem
        '
        Me.KaryawanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataKaryawanToolStripMenuItem})
        Me.KaryawanToolStripMenuItem.Name = "KaryawanToolStripMenuItem"
        Me.KaryawanToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.KaryawanToolStripMenuItem.Text = "Karyawan"
        '
        'DataKaryawanToolStripMenuItem
        '
        Me.DataKaryawanToolStripMenuItem.Name = "DataKaryawanToolStripMenuItem"
        Me.DataKaryawanToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DataKaryawanToolStripMenuItem.Text = "Data Karyawan"
        '
        'ProcessToolStripMenuItem
        '
        Me.ProcessToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistoryToolStripMenuItem, Me.ProcessNaiveBayesToolStripMenuItem})
        Me.ProcessToolStripMenuItem.Name = "ProcessToolStripMenuItem"
        Me.ProcessToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ProcessToolStripMenuItem.Text = "Process"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HistoryToolStripMenuItem.Text = "History"
        '
        'ProcessNaiveBayesToolStripMenuItem
        '
        Me.ProcessNaiveBayesToolStripMenuItem.Name = "ProcessNaiveBayesToolStripMenuItem"
        Me.ProcessNaiveBayesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProcessNaiveBayesToolStripMenuItem.Text = "Process Naive Bayes"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanNaiveBayesToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanNaiveBayesToolStripMenuItem
        '
        Me.LaporanNaiveBayesToolStripMenuItem.Name = "LaporanNaiveBayesToolStripMenuItem"
        Me.LaporanNaiveBayesToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.LaporanNaiveBayesToolStripMenuItem.Text = "Laporan Naive Bayes"
        '
        'Frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(881, 453)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "Frm_Menu"
        Me.Text = "Frm_Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PenggunaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministratorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataKaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessNaiveBayesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanNaiveBayesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
