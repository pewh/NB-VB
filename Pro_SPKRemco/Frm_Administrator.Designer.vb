<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Administrator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Administrator))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.fa = New AxVSFlex8.AxVSFlexGrid
        Me.faHak = New AxVSFlex8.AxVSFlexGrid
        Me.BtnSetHak = New System.Windows.Forms.Button
        Me.BtnHapus = New System.Windows.Forms.Button
        Me.BtnSimpan = New System.Windows.Forms.Button
        Me.txtpass = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        CType(Me.fa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.faHak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(846, 62)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ADMINISTRATOR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(22, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(846, 62)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "DATA KARYAWAN"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fa
        '
        Me.fa.DataSource = Nothing
        Me.fa.Location = New System.Drawing.Point(14, 98)
        Me.fa.Name = "fa"
        Me.fa.OcxState = CType(resources.GetObject("fa.OcxState"), System.Windows.Forms.AxHost.State)
        Me.fa.Size = New System.Drawing.Size(450, 308)
        Me.fa.TabIndex = 7
        '
        'faHak
        '
        Me.faHak.DataSource = Nothing
        Me.faHak.Location = New System.Drawing.Point(577, 96)
        Me.faHak.Name = "faHak"
        Me.faHak.OcxState = CType(resources.GetObject("faHak.OcxState"), System.Windows.Forms.AxHost.State)
        Me.faHak.Size = New System.Drawing.Size(280, 310)
        Me.faHak.TabIndex = 8
        '
        'BtnSetHak
        '
        Me.BtnSetHak.Location = New System.Drawing.Point(484, 283)
        Me.BtnSetHak.Name = "BtnSetHak"
        Me.BtnSetHak.Size = New System.Drawing.Size(77, 35)
        Me.BtnSetHak.TabIndex = 10
        Me.BtnSetHak.Text = "Set hak Akses"
        Me.BtnSetHak.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(484, 155)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(77, 35)
        Me.BtnHapus.TabIndex = 9
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Location = New System.Drawing.Point(129, 466)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(161, 39)
        Me.BtnSimpan.TabIndex = 15
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(126, 438)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(165, 20)
        Me.txtpass.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(14, 440)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 22)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Password"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(126, 412)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(165, 20)
        Me.txtUser.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(14, 414)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 22)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Username"
        '
        'Frm_Administrator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(882, 533)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnSetHak)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.faHak)
        Me.Controls.Add(Me.fa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Frm_Administrator"
        Me.Text = "Frm_Administrator"
        CType(Me.fa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.faHak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fa As AxVSFlex8.AxVSFlexGrid
    Friend WithEvents faHak As AxVSFlex8.AxVSFlexGrid
    Friend WithEvents BtnSetHak As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
