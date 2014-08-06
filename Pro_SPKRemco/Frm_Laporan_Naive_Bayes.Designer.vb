<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Laporan_Naive_Bayes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Laporan_Naive_Bayes))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbBulan = New System.Windows.Forms.ComboBox
        Me.CmbTahun = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.fa = New AxVSFlex8.AxVSFlexGrid
        Me.BtnKeluar = New System.Windows.Forms.Button
        Me.BtnView = New System.Windows.Forms.Button
        Me.RDYa = New System.Windows.Forms.RadioButton
        Me.RDAll = New System.Windows.Forms.RadioButton
        Me.RDTidak = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CmbInsentifDipilih = New System.Windows.Forms.ComboBox
        Me.BtnCustomOutput = New System.Windows.Forms.Button
        CType(Me.fa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Black
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(2, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(892, 3)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "DATA KARYAWAN"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(20, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(846, 62)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "LAPORAN NAIVE BAYES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(30, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(846, 62)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "DATA KARYAWAN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbBulan
        '
        Me.CmbBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBulan.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBulan.FormattingEnabled = True
        Me.CmbBulan.Location = New System.Drawing.Point(162, 134)
        Me.CmbBulan.Name = "CmbBulan"
        Me.CmbBulan.Size = New System.Drawing.Size(119, 25)
        Me.CmbBulan.TabIndex = 16
        '
        'CmbTahun
        '
        Me.CmbTahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTahun.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTahun.FormattingEnabled = True
        Me.CmbTahun.Location = New System.Drawing.Point(162, 107)
        Me.CmbTahun.Name = "CmbTahun"
        Me.CmbTahun.Size = New System.Drawing.Size(119, 25)
        Me.CmbTahun.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 22)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Tahun"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 22)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Bulan"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 22)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Insentif"
        '
        'fa
        '
        Me.fa.DataSource = Nothing
        Me.fa.Location = New System.Drawing.Point(9, 243)
        Me.fa.Name = "fa"
        Me.fa.OcxState = CType(resources.GetObject("fa.OcxState"), System.Windows.Forms.AxHost.State)
        Me.fa.Size = New System.Drawing.Size(884, 270)
        Me.fa.TabIndex = 19
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeluar.Location = New System.Drawing.Point(158, 191)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(140, 46)
        Me.BtnKeluar.TabIndex = 21
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'BtnView
        '
        Me.BtnView.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnView.Location = New System.Drawing.Point(12, 192)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(140, 46)
        Me.BtnView.TabIndex = 20
        Me.BtnView.Text = "Tampil"
        Me.BtnView.UseVisualStyleBackColor = True
        '
        'RDYa
        '
        Me.RDYa.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDYa.Location = New System.Drawing.Point(231, 165)
        Me.RDYa.Name = "RDYa"
        Me.RDYa.Size = New System.Drawing.Size(124, 19)
        Me.RDYa.TabIndex = 22
        Me.RDYa.Text = "Ya"
        Me.RDYa.UseVisualStyleBackColor = True
        '
        'RDAll
        '
        Me.RDAll.Checked = True
        Me.RDAll.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDAll.Location = New System.Drawing.Point(162, 165)
        Me.RDAll.Name = "RDAll"
        Me.RDAll.Size = New System.Drawing.Size(124, 19)
        Me.RDAll.TabIndex = 23
        Me.RDAll.TabStop = True
        Me.RDAll.Text = "All"
        Me.RDAll.UseVisualStyleBackColor = True
        '
        'RDTidak
        '
        Me.RDTidak.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDTidak.Location = New System.Drawing.Point(308, 167)
        Me.RDTidak.Name = "RDTidak"
        Me.RDTidak.Size = New System.Drawing.Size(124, 19)
        Me.RDTidak.TabIndex = 24
        Me.RDTidak.Text = "Tidak"
        Me.RDTidak.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbInsentifDipilih)
        Me.GroupBox1.Controls.Add(Me.BtnCustomOutput)
        Me.GroupBox1.Location = New System.Drawing.Point(402, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 129)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insentif yang dipilih"
        Me.GroupBox1.Visible = False
        '
        'CmbInsentifDipilih
        '
        Me.CmbInsentifDipilih.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbInsentifDipilih.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbInsentifDipilih.FormattingEnabled = True
        Me.CmbInsentifDipilih.Items.AddRange(New Object() {"Ya", "Tidak", "Belum Ditentukan"})
        Me.CmbInsentifDipilih.Location = New System.Drawing.Point(15, 29)
        Me.CmbInsentifDipilih.Name = "CmbInsentifDipilih"
        Me.CmbInsentifDipilih.Size = New System.Drawing.Size(179, 25)
        Me.CmbInsentifDipilih.TabIndex = 27
        '
        'BtnCustomOutput
        '
        Me.BtnCustomOutput.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert
        Me.BtnCustomOutput.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCustomOutput.Location = New System.Drawing.Point(15, 66)
        Me.BtnCustomOutput.Name = "BtnCustomOutput"
        Me.BtnCustomOutput.Size = New System.Drawing.Size(179, 46)
        Me.BtnCustomOutput.TabIndex = 26
        Me.BtnCustomOutput.Text = "Simpan Insentif"
        Me.BtnCustomOutput.UseVisualStyleBackColor = True
        '
        'Frm_Laporan_Naive_Bayes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(901, 525)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RDTidak)
        Me.Controls.Add(Me.RDYa)
        Me.Controls.Add(Me.RDAll)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnView)
        Me.Controls.Add(Me.fa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CmbBulan)
        Me.Controls.Add(Me.CmbTahun)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Frm_Laporan_Naive_Bayes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Laporan_Naive_Bayes"
        CType(Me.fa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbBulan As System.Windows.Forms.ComboBox
    Friend WithEvents CmbTahun As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents fa As AxVSFlex8.AxVSFlexGrid
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents BtnView As System.Windows.Forms.Button
    Friend WithEvents RDYa As System.Windows.Forms.RadioButton
    Friend WithEvents RDAll As System.Windows.Forms.RadioButton
    Friend WithEvents RDTidak As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmbInsentifDipilih As System.Windows.Forms.ComboBox
    Friend WithEvents BtnCustomOutput As System.Windows.Forms.Button
End Class
