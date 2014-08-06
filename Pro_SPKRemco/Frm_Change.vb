Public Class Frm_Change
    Dim cls As New ClsKoneksi

    Private Sub Frm_Change_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtusername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusername.KeyPress
        If e.KeyChar = Chr(13) Then
            Call cek()
        End If
    End Sub

    Private Sub txtusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub txtpassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassword.KeyPress
        If e.KeyChar = Chr(13) Then
            Call cek()
        End If
    End Sub

    Sub cek()
        If txtusername.Text <> "" Or txtpassword.Text <> "" Then
            With cls
                .Open_Koneksi()
                .Cmd.CommandText = "select *from pengguna where username='" & txtusername.Text & "' and pass='" & txtpassword.Text & "'"
                .Cmd.ExecuteNonQuery()
                .ReadTabel = .Cmd.ExecuteReader
                If .ReadTabel.HasRows = True Then
                    txtchange.Enabled = True
                    txtKonfirmasi.Enabled = True
                    BtnChange.Enabled = True
                    txtchange.Focus()
                    txtusername.Enabled = False
                    txtpassword.Enabled = False
                Else
                    txtchange.Enabled = False
                    txtKonfirmasi.Enabled = False
                    BtnChange.Enabled = False
                    txtusername.Focus()
                    txtusername.Text = ""
                    txtpassword.Text = ""
                    txtusername.Enabled = True
                    txtpassword.Enabled = True
                    MsgBox("Maaf Username dan Password Tidak Cocok", MsgBoxStyle.Information)
                End If
                .Close_Koneksi()
            End With
        End If
    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub BtnChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChange.Click
        Call change()
    End Sub

    Private Sub txtchange_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtchange.KeyPress
        If e.KeyChar = Chr(13) Then
            Call change()
        End If
    End Sub

    Sub change()
        If txtchange.Text <> "" And txtKonfirmasi.Text <> "" Then
            If txtchange.Text = txtKonfirmasi.Text Then
                With cls
                    .Open_Koneksi()
                    Dim st As String
                    st = "'" & txtusername.Text & "','" & txtchange.Text & "'"
                    .Cmd.CommandText = "Ubah_Password " & st
                    .Cmd.ExecuteNonQuery()
                    .Close_Koneksi()
                    MsgBox("Password Telah DiUbah", MsgBoxStyle.Information)
                    Call bersih()
                End With
            Else
                MsgBox("Maaf Change dan Konfirmasi Tidak Cocok", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Sub bersih()
        txtchange.Text = ""
        txtKonfirmasi.Text = ""
        txtchange.Enabled = False
        txtKonfirmasi.Enabled = False
        BtnChange.Enabled = False
        txtusername.Enabled = True
        txtpassword.Enabled = True
        txtusername.Text = ""
        txtpassword.Text = ""
        txtusername.Focus()
    End Sub

    Private Sub txtKonfirmasi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKonfirmasi.KeyPress
        If e.KeyChar = Chr(13) Then
            Call change()
        End If
    End Sub

    Private Sub txtKonfirmasi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKonfirmasi.TextChanged

    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtchange_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtchange.TextChanged

    End Sub
End Class