<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_History
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_History))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtIdKaryawan = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Gr = New System.Windows.Forms.GroupBox
        Me.RDTidakAbsen = New System.Windows.Forms.RadioButton
        Me.RDYaAbsen = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RDTidakRapih = New System.Windows.Forms.RadioButton
        Me.RDYaRapih = New System.Windows.Forms.RadioButton
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.RDTidakSopan = New System.Windows.Forms.RadioButton
        Me.RDYaSopan = New System.Windows.Forms.RadioButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.RDTidakInsentif = New System.Windows.Forms.RadioButton
        Me.RDYaInsentif = New System.Windows.Forms.RadioButton
        Me.Label11 = New System.Windows.Forms.Label
        Me.GrLama = New System.Windows.Forms.GroupBox
        Me.RDTidak6 = New System.Windows.Forms.RadioButton
        Me.RDYa6 = New System.Windows.Forms.RadioButton
        Me.BtnKeluar = New System.Windows.Forms.Button
        Me.BtnBersih = New System.Windows.Forms.Button
        Me.BtnHapus = New System.Windows.Forms.Button
        Me.BtnUbah = New System.Windows.Forms.Button
        Me.BtnSimpan = New System.Windows.Forms.Button
        Me.fa = New AxVSFlex8.AxVSFlexGrid
        Me.faKaryawan = New AxVSFlex8.AxVSFlexGrid
        Me.lblnama = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Gr.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GrLama.SuspendLayout()
        CType(Me.fa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.faKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(9, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(892, 3)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "DATA KARYAWAN"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(27, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(846, 62)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "HISTORY INSENTIF"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(37, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(846, 62)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "DATA KARYAWAN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtIdKaryawan
        '
        Me.txtIdKaryawan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdKaryawan.Location = New System.Drawing.Point(167, 183)
        Me.txtIdKaryawan.Name = "txtIdKaryawan"
        Me.txtIdKaryawan.Size = New System.Drawing.Size(119, 23)
        Me.txtIdKaryawan.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 22)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Id Karyawan"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 22)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Absensi >= 25 hari"
        '
        'Gr
        '
        Me.Gr.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Gr.Controls.Add(Me.RDTidakAbsen)
        Me.Gr.Controls.Add(Me.RDYaAbsen)
        Me.Gr.Location = New System.Drawing.Point(167, 212)
        Me.Gr.Name = "Gr"
        Me.Gr.Size = New System.Drawing.Size(283, 38)
        Me.Gr.TabIndex = 16
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.RDTidakRapih)
        Me.GroupBox1.Controls.Add(Me.RDYaRapih)
        Me.GroupBox1.Location = New System.Drawing.Point(167, 256)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 38)
        Me.GroupBox1.TabIndex = 18
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
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 270)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 22)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Penampilan"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.RDTidakSopan)
        Me.GroupBox3.Controls.Add(Me.RDYaSopan)
        Me.GroupBox3.Location = New System.Drawing.Point(618, 212)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(283, 38)
        Me.GroupBox3.TabIndex = 20
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
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(463, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 22)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Kesopanan"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.RDTidakInsentif)
        Me.GroupBox4.Controls.Add(Me.RDYaInsentif)
        Me.GroupBox4.Location = New System.Drawing.Point(618, 256)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(283, 38)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        '
        'RDTidakInsentif
        '
        Me.RDTidakInsentif.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDTidakInsentif.Location = New System.Drawing.Point(146, 13)
        Me.RDTidakInsentif.Name = "RDTidakInsentif"
        Me.RDTidakInsentif.Size = New System.Drawing.Size(124, 19)
        Me.RDTidakInsentif.TabIndex = 9
        Me.RDTidakInsentif.Text = "Tidak Dapat"
        Me.RDTidakInsentif.UseVisualStyleBackColor = True
        '
        'RDYaInsentif
        '
        Me.RDYaInsentif.Checked = True
        Me.RDYaInsentif.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDYaInsentif.Location = New System.Drawing.Point(16, 13)
        Me.RDYaInsentif.Name = "RDYaInsentif"
        Me.RDYaInsentif.Size = New System.Drawing.Size(124, 19)
        Me.RDYaInsentif.TabIndex = 8
        Me.RDYaInsentif.TabStop = True
        Me.RDYaInsentif.Text = "Dapat"
        Me.RDYaInsentif.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 310)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 22)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Lama >=6ulan"
        '
        'GrLama
        '
        Me.GrLama.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GrLama.Controls.Add(Me.RDTidak6)
        Me.GrLama.Controls.Add(Me.RDYa6)
        Me.GrLama.Location = New System.Drawing.Point(167, 300)
        Me.GrLama.Name = "GrLama"
        Me.GrLama.Size = New System.Drawing.Size(283, 38)
        Me.GrLama.TabIndex = 24
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
        'BtnKeluar
        '
        Me.BtnKeluar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Location = New System.Drawing.Point(599, 366)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(140, 46)
        Me.BtnKeluar.TabIndex = 28
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtnBersih
        '
        Me.BtnBersih.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBersih.Location = New System.Drawing.Point(453, 366)
        Me.BtnBersih.Name = "BtnBersih"
        Me.BtnBersih.Size = New System.Drawing.Size(140, 46)
        Me.BtnBersih.TabIndex = 29
        Me.BtnBersih.Text = "Bersih"
        Me.BtnBersih.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Enabled = False
        Me.BtnHapus.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Location = New System.Drawing.Point(307, 366)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(140, 46)
        Me.BtnHapus.TabIndex = 27
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnUbah
        '
        Me.BtnUbah.Enabled = False
        Me.BtnUbah.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUbah.Location = New System.Drawing.Point(161, 366)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(140, 46)
        Me.BtnUbah.TabIndex = 25
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Location = New System.Drawing.Point(15, 366)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(140, 46)
        Me.BtnSimpan.TabIndex = 26
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'fa
        '
        Me.fa.DataSource = Nothing
        Me.fa.Location = New System.Drawing.Point(12, 421)
        Me.fa.Name = "fa"
        Me.fa.OcxState = CType(resources.GetObject("fa.OcxState"), System.Windows.Forms.AxHost.State)
        Me.fa.Size = New System.Drawing.Size(889, 185)
        Me.fa.TabIndex = 30
        '
        'faKaryawan
        '
        Me.faKaryawan.DataSource = Nothing
        Me.faKaryawan.Location = New System.Drawing.Point(165, 21600)
        Me.faKaryawan.Name = "faKaryawan"
        Me.faKaryawan.OcxState = CType(resources.GetObject("faKaryawan.OcxState"), System.Windows.Forms.AxHost.State)
        Me.faKaryawan.Size = New System.Drawing.Size(736, 196)
        Me.faKaryawan.TabIndex = 31
        '
        'lblnama
        '
        Me.lblnama.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnama.Location = New System.Drawing.Point(292, 184)
        Me.lblnama.Name = "lblnama"
        Me.lblnama.Size = New System.Drawing.Size(447, 22)
        Me.lblnama.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(463, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 22)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Insentif"
        '
        'Frm_History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(909, 618)
        Me.Controls.Add(Me.lblnama)
        Me.Controls.Add(Me.faKaryawan)
        Me.Controls.Add(Me.fa)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnBersih)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.GrLama)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Gr)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtIdKaryawan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.Name = "Frm_History"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_History"
        Me.Gr.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GrLama.ResumeLayout(False)
        CType(Me.fa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.faKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIdKaryawan As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Gr As System.Windows.Forms.GroupBox
    Friend WithEvents RDTidakAbsen As System.Windows.Forms.RadioButton
    Friend WithEvents RDYaAbsen As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RDTidakRapih As System.Windows.Forms.RadioButton
    Friend WithEvents RDYaRapih As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RDTidakSopan As System.Windows.Forms.RadioButton
    Friend WithEvents RDYaSopan As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RDTidakInsentif As System.Windows.Forms.RadioButton
    Friend WithEvents RDYaInsentif As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GrLama As System.Windows.Forms.GroupBox
    Friend WithEvents RDTidak6 As System.Windows.Forms.RadioButton
    Friend WithEvents RDYa6 As System.Windows.Forms.RadioButton
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents BtnBersih As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents fa As AxVSFlex8.AxVSFlexGrid
    Friend WithEvents faKaryawan As AxVSFlex8.AxVSFlexGrid
    Friend WithEvents lblnama As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
