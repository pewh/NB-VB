<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Naive_Bayes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Naive_Bayes))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.CmbTahun = New System.Windows.Forms.ComboBox
        Me.CmbBulan = New System.Windows.Forms.ComboBox
        Me.lblnama = New System.Windows.Forms.Label
        Me.txtIdKaryawan = New System.Windows.Forms.TextBox
        Me.faKaryawan = New AxVSFlex8.AxVSFlexGrid
        Me.faPeriod = New AxVSFlex8.AxVSFlexGrid
        Me.BtnProcess = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Gr = New System.Windows.Forms.GroupBox
        Me.RDTidakAbsen = New System.Windows.Forms.RadioButton
        Me.RDYaAbsen = New System.Windows.Forms.RadioButton
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RDTidakSopan = New System.Windows.Forms.RadioButton
        Me.RDYaSopan = New System.Windows.Forms.RadioButton
        Me.GrLama = New System.Windows.Forms.GroupBox
        Me.RDTidak6 = New System.Windows.Forms.RadioButton
        Me.RDYa6 = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RDTidakRapih = New System.Windows.Forms.RadioButton
        Me.RDYaRapih = New System.Windows.Forms.RadioButton
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblHasilYa = New System.Windows.Forms.Label
        Me.lblHasilTidak = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.BtnKeluar = New System.Windows.Forms.Button
        Me.BtnBersih = New System.Windows.Forms.Button
        Me.BtnHapus = New System.Windows.Forms.Button
        Me.BtnSimpan = New System.Windows.Forms.Button
        Me.fa = New AxVSFlex8.AxVSFlexGrid
        Me.LblHasil = New System.Windows.Forms.Label
        CType(Me.faKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.faPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gr.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GrLama.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(5, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(892, 3)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "DATA KARYAWAN"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(23, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(846, 62)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "NAIVE BAYES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(33, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(846, 62)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "DATA KARYAWAN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 22)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Id Karyawan"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 22)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Bulan"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 22)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Tahun"
        '
        'CmbTahun
        '
        Me.CmbTahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTahun.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTahun.FormattingEnabled = True
        Me.CmbTahun.Location = New System.Drawing.Point(161, 109)
        Me.CmbTahun.Name = "CmbTahun"
        Me.CmbTahun.Size = New System.Drawing.Size(119, 25)
        Me.CmbTahun.TabIndex = 13
        '
        'CmbBulan
        '
        Me.CmbBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBulan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBulan.FormattingEnabled = True
        Me.CmbBulan.Location = New System.Drawing.Point(161, 136)
        Me.CmbBulan.Name = "CmbBulan"
        Me.CmbBulan.Size = New System.Drawing.Size(119, 25)
        Me.CmbBulan.TabIndex = 13
        '
        'lblnama
        '
        Me.lblnama.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnama.Location = New System.Drawing.Point(286, 164)
        Me.lblnama.Name = "lblnama"
        Me.lblnama.Size = New System.Drawing.Size(447, 22)
        Me.lblnama.TabIndex = 33
        '
        'txtIdKaryawan
        '
        Me.txtIdKaryawan.BackColor = System.Drawing.Color.White
        Me.txtIdKaryawan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdKaryawan.Location = New System.Drawing.Point(161, 164)
        Me.txtIdKaryawan.Name = "txtIdKaryawan"
        Me.txtIdKaryawan.Size = New System.Drawing.Size(119, 23)
        Me.txtIdKaryawan.TabIndex = 59
        '
        'faKaryawan
        '
        Me.faKaryawan.DataSource = Nothing
        Me.faKaryawan.Location = New System.Drawing.Point(162, 19200)
        Me.faKaryawan.Name = "faKaryawan"
        Me.faKaryawan.OcxState = CType(resources.GetObject("faKaryawan.OcxState"), System.Windows.Forms.AxHost.State)
        Me.faKaryawan.Size = New System.Drawing.Size(642, 197)
        Me.faKaryawan.TabIndex = 60
        '
        'faPeriod
        '
        Me.faPeriod.DataSource = Nothing
        Me.faPeriod.Location = New System.Drawing.Point(460, 13600)
        Me.faPeriod.Name = "faPeriod"
        Me.faPeriod.OcxState = CType(resources.GetObject("faPeriod.OcxState"), System.Windows.Forms.AxHost.State)
        Me.faPeriod.Size = New System.Drawing.Size(434, 169)
        Me.faPeriod.TabIndex = 61
        '
        'BtnProcess
        '
        Me.BtnProcess.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProcess.Location = New System.Drawing.Point(11, 328)
        Me.BtnProcess.Name = "BtnProcess"
        Me.BtnProcess.Size = New System.Drawing.Size(129, 38)
        Me.BtnProcess.TabIndex = 73
        Me.BtnProcess.Text = "Process"
        Me.BtnProcess.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(459, 279)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 22)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "Lama >=6ulan"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(459, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 22)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Kesopanan"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 22)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Penampilan"
        '
        'Gr
        '
        Me.Gr.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Gr.Controls.Add(Me.RDTidakAbsen)
        Me.Gr.Controls.Add(Me.RDYaAbsen)
        Me.Gr.Location = New System.Drawing.Point(163, 227)
        Me.Gr.Name = "Gr"
        Me.Gr.Size = New System.Drawing.Size(283, 38)
        Me.Gr.TabIndex = 66
        Me.Gr.TabStop = False
        '
        'RDTidakAbsen
        '
        Me.RDTidakAbsen.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDTidakAbsen.Location = New System.Drawing.Point(146, 13)
        Me.RDTidakAbsen.Name = "RDTidakAbsen"
        Me.RDTidakAbsen.Size = New System.Drawing.Size(124, 19)
        Me.RDTidakAbsen.TabIndex = 9
        Me.RDTidakAbsen.Text = "Tidak"
        Me.RDTidakAbsen.UseVisualStyleBackColor = True
        '
        'RDYaAbsen
        '
        Me.RDYaAbsen.Checked = True
        Me.RDYaAbsen.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDYaAbsen.Location = New System.Drawing.Point(16, 13)
        Me.RDYaAbsen.Name = "RDYaAbsen"
        Me.RDYaAbsen.Size = New System.Drawing.Size(124, 19)
        Me.RDYaAbsen.TabIndex = 8
        Me.RDYaAbsen.TabStop = True
        Me.RDYaAbsen.Text = "Ya"
        Me.RDYaAbsen.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 241)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(132, 22)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Absensi >= 25 hari"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 202)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(883, 22)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Pertanyaan"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.RDTidakSopan)
        Me.GroupBox3.Controls.Add(Me.RDYaSopan)
        Me.GroupBox3.Location = New System.Drawing.Point(614, 227)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(283, 38)
        Me.GroupBox3.TabIndex = 70
        Me.GroupBox3.TabStop = False
        '
        'RDTidakSopan
        '
        Me.RDTidakSopan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDTidakSopan.Location = New System.Drawing.Point(146, 13)
        Me.RDTidakSopan.Name = "RDTidakSopan"
        Me.RDTidakSopan.Size = New System.Drawing.Size(124, 19)
        Me.RDTidakSopan.TabIndex = 9
        Me.RDTidakSopan.Text = "Tidak Sopan"
        Me.RDTidakSopan.UseVisualStyleBackColor = True
        '
        'RDYaSopan
        '
        Me.RDYaSopan.Checked = True
        Me.RDYaSopan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDYaSopan.Location = New System.Drawing.Point(16, 13)
        Me.RDYaSopan.Name = "RDYaSopan"
        Me.RDYaSopan.Size = New System.Drawing.Size(124, 19)
        Me.RDYaSopan.TabIndex = 8
        Me.RDYaSopan.TabStop = True
        Me.RDYaSopan.Text = "Sopan"
        Me.RDYaSopan.UseVisualStyleBackColor = True
        '
        'GrLama
        '
        Me.GrLama.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GrLama.Controls.Add(Me.RDTidak6)
        Me.GrLama.Controls.Add(Me.RDYa6)
        Me.GrLama.Location = New System.Drawing.Point(616, 269)
        Me.GrLama.Name = "GrLama"
        Me.GrLama.Size = New System.Drawing.Size(283, 38)
        Me.GrLama.TabIndex = 72
        Me.GrLama.TabStop = False
        '
        'RDTidak6
        '
        Me.RDTidak6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDTidak6.Location = New System.Drawing.Point(146, 13)
        Me.RDTidak6.Name = "RDTidak6"
        Me.RDTidak6.Size = New System.Drawing.Size(124, 19)
        Me.RDTidak6.TabIndex = 9
        Me.RDTidak6.Text = "Tidak"
        Me.RDTidak6.UseVisualStyleBackColor = True
        '
        'RDYa6
        '
        Me.RDYa6.Checked = True
        Me.RDYa6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDYa6.Location = New System.Drawing.Point(16, 13)
        Me.RDYa6.Name = "RDYa6"
        Me.RDYa6.Size = New System.Drawing.Size(124, 19)
        Me.RDYa6.TabIndex = 8
        Me.RDYa6.TabStop = True
        Me.RDYa6.Text = "Ya"
        Me.RDYa6.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.RDTidakRapih)
        Me.GroupBox1.Controls.Add(Me.RDYaRapih)
        Me.GroupBox1.Location = New System.Drawing.Point(163, 271)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 38)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        '
        'RDTidakRapih
        '
        Me.RDTidakRapih.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDTidakRapih.Location = New System.Drawing.Point(146, 13)
        Me.RDTidakRapih.Name = "RDTidakRapih"
        Me.RDTidakRapih.Size = New System.Drawing.Size(124, 19)
        Me.RDTidakRapih.TabIndex = 9
        Me.RDTidakRapih.Text = "Tidak Rapih"
        Me.RDTidakRapih.UseVisualStyleBackColor = True
        '
        'RDYaRapih
        '
        Me.RDYaRapih.Checked = True
        Me.RDYaRapih.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDYaRapih.Location = New System.Drawing.Point(16, 13)
        Me.RDYaRapih.Name = "RDYaRapih"
        Me.RDYaRapih.Size = New System.Drawing.Size(124, 19)
        Me.RDYaRapih.TabIndex = 8
        Me.RDYaRapih.TabStop = True
        Me.RDYaRapih.Text = "Rapih"
        Me.RDYaRapih.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 380)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 22)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "Hasil Ya"
        '
        'lblHasilYa
        '
        Me.lblHasilYa.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasilYa.Location = New System.Drawing.Point(160, 380)
        Me.lblHasilYa.Name = "lblHasilYa"
        Me.lblHasilYa.Size = New System.Drawing.Size(214, 22)
        Me.lblHasilYa.TabIndex = 75
        '
        'lblHasilTidak
        '
        Me.lblHasilTidak.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasilTidak.Location = New System.Drawing.Point(162, 402)
        Me.lblHasilTidak.Name = "lblHasilTidak"
        Me.lblHasilTidak.Size = New System.Drawing.Size(214, 22)
        Me.lblHasilTidak.TabIndex = 77
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(14, 402)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(126, 22)
        Me.Label16.TabIndex = 76
        Me.Label16.Text = "Hasil Tidak"
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Location = New System.Drawing.Point(451, 465)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(140, 46)
        Me.BtnKeluar.TabIndex = 81
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtnBersih
        '
        Me.BtnBersih.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBersih.Location = New System.Drawing.Point(305, 465)
        Me.BtnBersih.Name = "BtnBersih"
        Me.BtnBersih.Size = New System.Drawing.Size(140, 46)
        Me.BtnBersih.TabIndex = 82
        Me.BtnBersih.Text = "Bersih"
        Me.BtnBersih.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Enabled = False
        Me.BtnHapus.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Location = New System.Drawing.Point(159, 465)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(140, 46)
        Me.BtnHapus.TabIndex = 80
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Location = New System.Drawing.Point(11, 465)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(140, 46)
        Me.BtnSimpan.TabIndex = 79
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'fa
        '
        Me.fa.DataSource = Nothing
        Me.fa.Location = New System.Drawing.Point(11, 524)
        Me.fa.Name = "fa"
        Me.fa.OcxState = CType(resources.GetObject("fa.OcxState"), System.Windows.Forms.AxHost.State)
        Me.fa.Size = New System.Drawing.Size(892, 137)
        Me.fa.TabIndex = 83
        '
        'LblHasil
        '
        Me.LblHasil.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHasil.Location = New System.Drawing.Point(12, 433)
        Me.LblHasil.Name = "LblHasil"
        Me.LblHasil.Size = New System.Drawing.Size(349, 22)
        Me.LblHasil.TabIndex = 84
        '
        'Frm_Naive_Bayes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(907, 687)
        Me.Controls.Add(Me.LblHasil)
        Me.Controls.Add(Me.fa)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnBersih)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.lblHasilTidak)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblHasilYa)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.faPeriod)
        Me.Controls.Add(Me.faKaryawan)
        Me.Controls.Add(Me.txtIdKaryawan)
        Me.Controls.Add(Me.lblnama)
        Me.Controls.Add(Me.CmbBulan)
        Me.Controls.Add(Me.CmbTahun)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnProcess)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Gr)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GrLama)
        Me.Controls.Add(Me.GroupBox1)
        Me.MinimizeBox = False
        Me.Name = "Frm_Naive_Bayes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.faKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.faPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gr.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GrLama.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.fa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmbTahun As System.Windows.Forms.ComboBox
    Friend WithEvents CmbBulan As System.Windows.Forms.ComboBox
    Friend WithEvents lblnama As System.Windows.Forms.Label
    Friend WithEvents txtIdKaryawan As System.Windows.Forms.TextBox
    Friend WithEvents faKaryawan As AxVSFlex8.AxVSFlexGrid
    Friend WithEvents faPeriod As AxVSFlex8.AxVSFlexGrid
    Friend WithEvents BtnProcess As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Gr As System.Windows.Forms.GroupBox
    Friend WithEvents RDTidakAbsen As System.Windows.Forms.RadioButton
    Friend WithEvents RDYaAbsen As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RDTidakSopan As System.Windows.Forms.RadioButton
    Friend WithEvents RDYaSopan As System.Windows.Forms.RadioButton
    Friend WithEvents GrLama As System.Windows.Forms.GroupBox
    Friend WithEvents RDTidak6 As System.Windows.Forms.RadioButton
    Friend WithEvents RDYa6 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RDTidakRapih As System.Windows.Forms.RadioButton
    Friend WithEvents RDYaRapih As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblHasilYa As System.Windows.Forms.Label
    Friend WithEvents lblHasilTidak As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents BtnBersih As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents fa As AxVSFlex8.AxVSFlexGrid
    Friend WithEvents LblHasil As System.Windows.Forms.Label
End Class
