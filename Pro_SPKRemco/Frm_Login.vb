Public Class Frm_Login
    Dim cls As New ClsKoneksi
    Dim hk As String

    Private Sub Frm_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cls.non_aktif()
        setStringConnection("ACER4750SB\SQLEXPRESS", "DB_RemcoInsentif")
    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        If txtuser.Text = "" Or txtpass.Text = "" Then
            MsgBox("Data Tidak Lengkap", MsgBoxStyle.Information)
        Else

            With cls
                .Open_Koneksi()
                .Cmd.CommandText = "select *from pengguna where username='" & txtuser.Text & "' and pass='" & txtpass.Text & "'"
                .Cmd.ExecuteNonQuery()
                .ReadTabel = .Cmd.ExecuteReader
                If .ReadTabel.HasRows = True Then
                    .ReadTabel.Read()
                    hk = Trim(.ReadTabel("Hak_Akses"))
                    .Close_Koneksi()
                    Call Aktif()
                    Exit Sub
                Else
                    MsgBox("Username dan Password Tidak Cocok", MsgBoxStyle.Information)
                    txtuser.Text = ""
                    txtpass.Text = ""
                    txtuser.Focus()
                End If
                .Close_Koneksi()
            End With
        End If
    End Sub

    Sub Aktif()
        With Frm_Menu
            For i = 1 To Len(hk)
                Select Case i
                    Case 1 : If Mid(hk, i, 1) = "1" Then .ChangePasswordToolStripMenuItem.Enabled = True
                    Case 2 : If Mid(hk, i, 1) = "1" Then .KaryawanToolStripMenuItem.Enabled = True
                    Case 3 : If Mid(hk, i, 1) = "1" Then .HistoryToolStripMenuItem.Enabled = True
                    Case 4 : If Mid(hk, i, 1) = "1" Then .ProcessNaiveBayesToolStripMenuItem.Enabled = True
                    Case 5 : If Mid(hk, i, 1) = "1" Then .LaporanNaiveBayesToolStripMenuItem.Enabled = True
                    
                End Select
            Next
        End With
        Frm_Menu.Show()
        Me.Hide()

    End Sub

    Private Sub BtnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogOut.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class