<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Change
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.BtnChange = New System.Windows.Forms.Button
        Me.txtKonfirmasi = New System.Windows.Forms.TextBox
        Me.txtchange = New System.Windows.Forms.TextBox
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.txtusername = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Confirm Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Change Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "User Name"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(226, 221)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(200, 61)
        Me.BtnCancel.TabIndex = 15
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnChange
        '
        Me.BtnChange.Enabled = False
        Me.BtnChange.Location = New System.Drawing.Point(20, 221)
        Me.BtnChange.Name = "BtnChange"
        Me.BtnChange.Size = New System.Drawing.Size(200, 61)
        Me.BtnChange.TabIndex = 14
        Me.BtnChange.Text = "Change"
        Me.BtnChange.UseVisualStyleBackColor = True
        '
        'txtKonfirmasi
        '
        Me.txtKonfirmasi.Enabled = False
        Me.txtKonfirmasi.Location = New System.Drawing.Point(143, 171)
        Me.txtKonfirmasi.Name = "txtKonfirmasi"
        Me.txtKonfirmasi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtKonfirmasi.Size = New System.Drawing.Size(204, 20)
        Me.txtKonfirmasi.TabIndex = 13
        '
        'txtchange
        '
        Me.txtchange.Enabled = False
        Me.txtchange.Location = New System.Drawing.Point(143, 145)
        Me.txtchange.Name = "txtchange"
        Me.txtchange.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtchange.Size = New System.Drawing.Size(204, 20)
        Me.txtchange.TabIndex = 12
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(143, 119)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(204, 20)
        Me.txtpassword.TabIndex = 11
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(143, 92)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(204, 20)
        Me.txtusername.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(111, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(236, 31)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Change Password"
        '
        'Frm_Change
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(444, 313)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnChange)
        Me.Controls.Add(Me.txtKonfirmasi)
        Me.Controls.Add(Me.txtchange)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Name = "Frm_Change"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Change"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnChange As System.Windows.Forms.Button
    Friend WithEvents txtKonfirmasi As System.Windows.Forms.TextBox
    Friend WithEvents txtchange As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
