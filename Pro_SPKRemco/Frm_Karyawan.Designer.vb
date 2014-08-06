<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Karyawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Karyawan))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtId = New System.Windows.Forms.TextBox
        Me.txtNama = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtAlamat = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.fa = New AxVSFlex8.AxVSFlexGrid
        Me.BtnSimpan = New System.Windows.Forms.Button
        Me.BtnUbah = New System.Windows.Forms.Button
        Me.BtnHapus = New System.Windows.Forms.Button
        Me.BtnBersih = New System.Windows.Forms.Button
        Me.BtnKeluar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RDNonAktif = New System.Windows.Forms.RadioButton
        Me.RDAktif = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RDPerempuan = New System.Windows.Forms.RadioButton
        Me.RDLaki = New System.Windows.Forms.RadioButton
        Me.CmbJabatan = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        CType(Me.fa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(846, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATA KARYAWAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(30, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(846, 62)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DATA KARYAWAN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(2, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(892, 3)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "DATA KARYAWAN"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Id Karyawan"
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(166, 125)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(119, 23)
        Me.txtId.TabIndex = 4
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(166, 154)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(311, 23)
        Me.txtNama.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 22)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nama"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Alamat"
        '
        'txtAlamat
        '
        Me.txtAlamat.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.Location = New System.Drawing.Point(166, 185)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(460, 23)
        Me.txtAlamat.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 220)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 22)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Jenis Kelamin"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 257)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 22)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Tanggal Masuk"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(166, 254)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(153, 23)
        Me.DateTimePicker1.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 294)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 22)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Status Karyawn"
        '
        'fa
        '
        Me.fa.DataSource = Nothing
        Me.fa.Location = New System.Drawing.Point(3, 445)
        Me.fa.Name = "fa"
        Me.fa.OcxState = CType(resources.GetObject("fa.OcxState"), System.Windows.Forms.AxHost.State)
        Me.fa.Size = New System.Drawing.Size(876, 200)
        Me.fa.TabIndex = 12
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSimpan.Location = New System.Drawing.Point(3, 383)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(140, 46)
        Me.BtnSimpan.TabIndex = 13
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnUbah
        '
        Me.BtnUbah.Enabled = False
        Me.BtnUbah.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUbah.Location = New System.Drawing.Point(149, 383)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(140, 46)
        Me.BtnUbah.TabIndex = 13
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Enabled = False
        Me.BtnHapus.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHapus.Location = New System.Drawing.Point(295, 383)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(140, 46)
        Me.BtnHapus.TabIndex = 13
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnBersih
        '
        Me.BtnBersih.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBersih.Location = New System.Drawing.Point(441, 383)
        Me.BtnBersih.Name = "BtnBersih"
        Me.BtnBersih.Size = New System.Drawing.Size(140, 46)
        Me.BtnBersih.TabIndex = 13
        Me.BtnBersih.Text = "Bersih"
        Me.BtnBersih.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Location = New System.Drawing.Point(587, 383)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(140, 46)
        Me.BtnKeluar.TabIndex = 13
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RDNonAktif)
        Me.GroupBox1.Controls.Add(Me.RDAktif)
        Me.GroupBox1.Location = New System.Drawing.Point(166, 283)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 38)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'RDNonAktif
        '
        Me.RDNonAktif.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDNonAktif.Location = New System.Drawing.Point(146, 13)
        Me.RDNonAktif.Name = "RDNonAktif"
        Me.RDNonAktif.Size = New System.Drawing.Size(124, 19)
        Me.RDNonAktif.TabIndex = 12
        Me.RDNonAktif.Text = "Non Aktif"
        Me.RDNonAktif.UseVisualStyleBackColor = True
        '
        'RDAktif
        '
        Me.RDAktif.Checked = True
        Me.RDAktif.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDAktif.Location = New System.Drawing.Point(14, 13)
        Me.RDAktif.Name = "RDAktif"
        Me.RDAktif.Size = New System.Drawing.Size(124, 19)
        Me.RDAktif.TabIndex = 13
        Me.RDAktif.TabStop = True
        Me.RDAktif.Text = "Aktif"
        Me.RDAktif.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RDPerempuan)
        Me.GroupBox2.Controls.Add(Me.RDLaki)
        Me.GroupBox2.Location = New System.Drawing.Point(166, 210)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 38)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'RDPerempuan
        '
        Me.RDPerempuan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDPerempuan.Location = New System.Drawing.Point(146, 13)
        Me.RDPerempuan.Name = "RDPerempuan"
        Me.RDPerempuan.Size = New System.Drawing.Size(124, 19)
        Me.RDPerempuan.TabIndex = 9
        Me.RDPerempuan.Text = "Perempuan"
        Me.RDPerempuan.UseVisualStyleBackColor = True
        '
        'RDLaki
        '
        Me.RDLaki.Checked = True
        Me.RDLaki.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDLaki.Location = New System.Drawing.Point(16, 13)
        Me.RDLaki.Name = "RDLaki"
        Me.RDLaki.Size = New System.Drawing.Size(124, 19)
        Me.RDLaki.TabIndex = 8
        Me.RDLaki.TabStop = True
        Me.RDLaki.Text = "Laki - Laki"
        Me.RDLaki.UseVisualStyleBackColor = True
        '
        'CmbJabatan
        '
        Me.CmbJabatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbJabatan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbJabatan.FormattingEnabled = True
        Me.CmbJabatan.Location = New System.Drawing.Point(166, 333)
        Me.CmbJabatan.Name = "CmbJabatan"
        Me.CmbJabatan.Size = New System.Drawing.Size(283, 25)
        Me.CmbJabatan.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 333)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 22)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Jabatan"
        '
        'Frm_Karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(897, 649)
        Me.Controls.Add(Me.CmbJabatan)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnBersih)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.fa)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.Name = "Frm_Karyawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Karyawan"
        CType(Me.fa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents fa As AxVSFlex8.AxVSFlexGrid
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnBersih As System.Windows.Forms.Button
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RDNonAktif As System.Windows.Forms.RadioButton
    Friend WithEvents RDAktif As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RDPerempuan As System.Windows.Forms.RadioButton
    Friend WithEvents RDLaki As System.Windows.Forms.RadioButton
    Friend WithEvents CmbJabatan As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
