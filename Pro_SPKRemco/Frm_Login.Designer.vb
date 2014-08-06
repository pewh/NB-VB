<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtpass = New System.Windows.Forms.TextBox
        Me.txtuser = New System.Windows.Forms.TextBox
        Me.BtnLogOut = New System.Windows.Forms.Button
        Me.BtnLogin = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Username"
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(182, 110)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(147, 20)
        Me.txtpass.TabIndex = 9
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(182, 71)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(147, 20)
        Me.txtuser.TabIndex = 8
        '
        'BtnLogOut
        '
        Me.BtnLogOut.Location = New System.Drawing.Point(195, 152)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(144, 44)
        Me.BtnLogOut.TabIndex = 7
        Me.BtnLogOut.Text = "Logout"
        Me.BtnLogOut.UseVisualStyleBackColor = True
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(14, 152)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(144, 44)
        Me.BtnLogin.TabIndex = 6
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(119, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Password"
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(359, 220)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.BtnLogOut)
        Me.Controls.Add(Me.BtnLogin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents BtnLogOut As System.Windows.Forms.Button
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
