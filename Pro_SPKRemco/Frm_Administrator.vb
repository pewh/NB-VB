Public Class Frm_Administrator
    Dim cls As New ClsKoneksi

    Private Sub Frm_Administrator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ListHak()
        Call Display()
    End Sub

    Sub Display()
        Call List()
        With cls
            .Open_Koneksi()
            .Cmd.CommandText = "select *from pengguna"
            .Cmd.ExecuteNonQuery()
            .ReadTabel = .Cmd.ExecuteReader
            If .ReadTabel.HasRows = True Then
                Dim i As Integer
                i = fa.Rows
                Do While .ReadTabel.Read
                    fa.Rows = i + 1
                    fa.set_TextMatrix(i, 0, Trim(.ReadTabel("Username")))
                    fa.set_TextMatrix(i, 1, Trim(.ReadTabel("pass")))
                    fa.set_TextMatrix(i, 2, Trim(.ReadTabel("Hak_Akses")))
                    i = i + 1
                Loop
            End If
            .Close_Koneksi()
        End With
    End Sub

    Sub List()
        With fa
            .Cols = 3
            .Rows = 1
            .FixedCols = 0

            .set_TextMatrix(0, 0, "username")
            .set_TextMatrix(0, 1, "password")
            .set_TextMatrix(0, 2, "Hak Akses")

            .set_ColWidth(0, 1500)
            .set_ColWidth(1, 1500)
            .set_ColWidth(2, 3000)
        End With
    End Sub

    Sub ListHak()
        With faHak
            .Cols = 1
            .Rows = 6
            .FixedCols = 0
            .FixedRows = 1

            .set_TextMatrix(0, 0, "Set Hak Akses")
            .set_TextMatrix(1, 0, "Administrator")
            .set_TextMatrix(2, 0, "Data Karyawan")
            .set_TextMatrix(3, 0, "History")
            .set_TextMatrix(4, 0, "Naive Bayes")
            .set_TextMatrix(5, 0, "Laporan Naive Bayes")
            
            .set_ColWidth(0, 3500)

            For i = 1 To .Rows - 1
                .set_Cell(VSFlex8.CellPropertySettings.flexcpChecked, i, 0, i, 0, VSFlex8.CellCheckedSettings.flexUnchecked)
            Next
            .Editable = VSFlex8.EditableSettings.flexEDKbdMouse
        End With
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If txtUser.Text = "" Or txtpass.Text = "" Then
            MsgBox("Maaf Data Tidak Lengkap", MsgBoxStyle.Information)
        Else
            Dim st As String
            Dim hak As String
            hak = ""
            For i = 1 To faHak.Rows - 1
                If faHak.get_Cell(VSFlex8.CellPropertySettings.flexcpChecked, i, 0, i, 0) = VSFlex8.CellCheckedSettings.flexChecked Then
                    hak = hak + "1"
                Else
                    hak = hak + "0"
                End If
            Next
            With cls
                .Open_Koneksi()
                st = "'" & txtUser.Text & "','" & txtpass.Text & "','" & hak & "'"
                .Cmd.CommandText = "Simpan_Pengguna " & st
                .Cmd.ExecuteNonQuery()
                .Close_Koneksi()
                MsgBox("Data Telah Disimpan", MsgBoxStyle.Information)
                Call bersih()
            End With
        End If
    End Sub

    Sub bersih()
        Call List()
        txtUser.Text = ""
        txtpass.Text = ""
        Call Display()
    End Sub

    Private Sub fa_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles fa.ClickEvent
        Dim hak As String
        hak = fa.get_TextMatrix(fa.Row, 2)
        For i = 1 To faHak.Rows - 1
            If Mid(hak, i, 1) = "1" Then
                faHak.set_Cell(VSFlex8.CellPropertySettings.flexcpChecked, i, 0, i, 0, VSFlex8.CellCheckedSettings.flexChecked)
            Else
                faHak.set_Cell(VSFlex8.CellPropertySettings.flexcpChecked, i, 0, i, 0, VSFlex8.CellCheckedSettings.flexUnchecked)
            End If
        Next
    End Sub

    Private Sub fa_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fa.SelChange
        Dim hak As String
        hak = fa.get_TextMatrix(fa.Row, 2)
        For i = 1 To faHak.Rows - 1
            If Mid(hak, i, 1) = "1" Then
                faHak.set_Cell(VSFlex8.CellPropertySettings.flexcpChecked, i, 0, i, 0, VSFlex8.CellCheckedSettings.flexChecked)
            Else
                faHak.set_Cell(VSFlex8.CellPropertySettings.flexcpChecked, i, 0, i, 0, VSFlex8.CellCheckedSettings.flexUnchecked)
            End If
        Next
    End Sub

    Private Sub BtnSetHak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSetHak.Click
        If fa.get_TextMatrix(fa.Row, 0) = "" Then
            MsgBox("Maaf Data Tidak Lengkap", MsgBoxStyle.Information)
        Else
            Dim hak As String
            hak = ""
            For i = 1 To faHak.Rows - 1
                If faHak.get_Cell(VSFlex8.CellPropertySettings.flexcpChecked, i, 0, i, 0) = VSFlex8.CellCheckedSettings.flexChecked Then
                    hak = hak + "1"
                Else
                    hak = hak + "0"
                End If
            Next

            Dim st As String
            st = "'" & fa.get_TextMatrix(fa.Row, 0) & "','" & hak & "'"
            With cls
                .Open_Koneksi()
                .Cmd.CommandText = "Ubah_Hak_Akses " & st
                .Cmd.ExecuteNonQuery()
                .Close_Koneksi()
                MsgBox("Data Telah DiUbah", MsgBoxStyle.Information)
                Call bersih()
            End With
        End If
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If fa.get_TextMatrix(fa.Row, 0) = "" Then
            MsgBox("Maaf Data Tidak Lengkap", MsgBoxStyle.Information)
        Else
            Dim ty As String
            ty = MsgBox("Apakah Anda Yakin Untuk Menghapus username " & fa.get_TextMatrix(fa.Row, 0) & "", MsgBoxStyle.YesNo)
            If ty = vbYes Then
                Dim st As String
                st = "'" & fa.get_TextMatrix(fa.Row, 0) & "'"
                With cls
                    .Open_Koneksi()
                    .Cmd.CommandText = "Hapus_Pengguna " & st
                    .Cmd.ExecuteNonQuery()
                    .Close_Koneksi()
                    MsgBox("Data Telah DiHapus", MsgBoxStyle.Information)
                    Call bersih()
                End With
            Else
                MsgBox("Data Batal DiHapus", MsgBoxStyle.Information)
                Call bersih()
            End If
        End If
    End Sub
End Class