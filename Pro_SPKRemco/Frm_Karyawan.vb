Public Class Frm_Karyawan
    Dim cls As New ClsKoneksi
    Dim NamaField As String

    Private Sub Frm_Karyawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call display()
        Call nomor()
        Call combo()
    End Sub

    Sub display()
        Call List()
        With cls
            .Open_koneksi()
            .Cmd.CommandText = "select *from v_Karyawan"
            .Cmd.ExecuteNonQuery()
            .ReadTabel = .Cmd.ExecuteReader
            If .ReadTabel.HasRows = True Then
                Dim i As Integer
                i = fa.Rows
                Do While .ReadTabel.Read
                    fa.Rows = i + 1
                    fa.set_TextMatrix(i, 0, Trim(.ReadTabel("Id_Karyawan")))
                    fa.set_TextMatrix(i, 1, Trim(.ReadTabel("Nama")))
                    fa.set_TextMatrix(i, 2, Trim(.ReadTabel("Alamat")))
                    fa.set_TextMatrix(i, 3, Trim(.ReadTabel("JK")))
                    fa.set_TextMatrix(i, 4, Format(.ReadTabel("Tgl_Masuk"), "dd/MM/yyyy"))
                    fa.set_TextMatrix(i, 5, Trim(.ReadTabel("Jabatan")))
                    fa.set_TextMatrix(i, 6, Trim(.ReadTabel("SK")))
                    i = i + 1
                Loop
            End If
            .Close_Koneksi()
        End With
    End Sub

    Sub List()
        With fa
            .Cols = 7
            .Rows = 2
            .FixedCols = 0

            .set_TextMatrix(0, 0, "Id Karyawan")
            .set_TextMatrix(0, 1, "Nama")
            .set_TextMatrix(0, 2, "Alamat")
            .set_TextMatrix(0, 3, "Jenis Kelamin")
            .set_TextMatrix(0, 4, "Tanggal Masuk")
            .set_TextMatrix(0, 5, "Jabatan")
            .set_TextMatrix(0, 6, "Status")


            .set_ColWidth(0, 1300)
            .set_ColWidth(1, 2800)
            .set_ColWidth(2, 4000)
            .set_ColWidth(3, 1500)
            .set_ColWidth(4, 1500)
            .set_ColWidth(5, 1500)
            .set_ColWidth(6, 1500)

            For i = 0 To .Cols - 1
                .set_ColAlignment(i, VSFlex8.AlignmentSettings.flexAlignCenterCenter)
            Next
            .BackColor = Color.Gray
            .BackColorAlternate = Color.Yellow

            .SelectionMode = VSFlex8.SelModeSettings.flexSelectionListBox
            .ExplorerBar = VSFlex8.ExplorerBarSettings.flexExSort
            .MergeCells = VSFlex8.MergeSettings.flexMergeFree

            .FrozenCols = 1

            .Editable = VSFlex8.EditableSettings.flexEDKbdMouse
        End With
    End Sub

    Sub nomor()
        Dim bln, tahun As String

        tahun = Year(Now)
        bln = Month(Now)

        With cls
            .Open_koneksi()
            .Cmd.CommandText = "select * from Karyawan where substring(id_karyawan, 0, 5) = " & tahun & " and substring(id_karyawan, 5, 2) =" & bln & " order by Id_Karyawan desc"

            .Cmd.ExecuteNonQuery()
            .ReadTabel = .Cmd.ExecuteReader
            If .ReadTabel.HasRows = False Then
                If Len(bln) = "1" Then
                    txtId.Text = tahun & "0" & bln & "01"
                Else
                    txtId.Text = tahun & bln & "01"
                End If

            Else
                .ReadTabel.Read()
                Dim a As String
                a = Val(.ReadTabel("Id_Karyawan")) + 1
                txtId.Text = a

            End If
            .Close_Koneksi()
        End With
    End Sub


    Sub combo()
        With CmbJabatan
            .Items.Clear()
            .Items.Add("Pimpinan pabrik")
            .Items.Add("Kepala personalia")
            .Items.Add("Kepala produksi")
            .Items.Add("Kepala laboratorium")
            .Items.Add("Kabag keamanan")
            .Items.Add("Kabag poliklinik")
            .Items.Add("Kabag keuangan")
            .Items.Add("Kabag personalia")
            .Items.Add("Waka produksi")
            .Items.Add("Kabag gudang")
            .Items.Add("Waka laboratorium")
            .Items.Add("Coordinator mesin")
            .Items.Add("Krani produksi (giling) ")
            .Items.Add("Krani produksi I (crumb rubber)")
            .Items.Add("Pengawas pengemasan")
            .Items.Add("Analis")
            .Items.Add("Petugas lingkungan")
        End With
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If txtId.Text = "" Or txtNama.Text = "" Or txtAlamat.Text = "" Or CmbJabatan.Text = "" Then
            MsgBox("Maaf Data Tidak Lengkap", MsgBoxStyle.Information)
        Else
            Dim jk, sk As String
            With cls
                .Open_koneksi()
                If RDLaki.Checked = True Then
                    jk = "0"
                Else
                    jk = "1"
                End If
                If RDNonAktif.Checked = True Then
                    sk = "0"
                Else
                    sk = "1"
                End If
                Dim ss As String
                ss = "'" & txtId.Text & "','" & txtNama.Text & "','" & txtAlamat.Text & "','" & jk & "','" & Format(DateTimePicker1.Value, "MM/dd/yyyy") & "','" & sk & "','" & CmbJabatan.Text & "'"
                .Cmd.CommandText = "Simpan_Karyawan" & ss
                Console.Write(.Cmd.CommandText)
                .Cmd.ExecuteNonQuery()
                .Close_Koneksi()
                MsgBox("Data Telah DiSimpan", MsgBoxStyle.Information)
                Call bersih()
            End With
        End If
    End Sub

    Sub bersih()
        txtId.Text = ""
        txtId.Focus()
        txtNama.Text = ""
        txtAlamat.Text = ""
        RDAktif.Checked = True
        RDLaki.Checked = True
        Call display()
        Call nomor()
        Call combo()
        BtnSimpan.Enabled = True
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        If txtId.Text = "" Or txtNama.Text = "" Or txtAlamat.Text = "" Then
            MsgBox("Maaf Data Tidak Lengkap", MsgBoxStyle.Information)
        Else
            Dim jk, sk As String
            With cls
                .Open_koneksi()
                If RDLaki.Checked = True Then
                    jk = "0"
                Else
                    jk = "1"
                End If
                If RDNonAktif.Checked = True Then
                    sk = "0"
                Else
                    sk = "1"
                End If
                Dim ss As String
                ss = "'" & txtId.Text & "','" & txtNama.Text & "','" & txtAlamat.Text & "','" & jk & "','" & Format(DateTimePicker1.Value, "MM/dd/yyyy") & "','" & sk & "','" & CmbJabatan.Text & "'"
                .Cmd.CommandText = "Ubah_Karyawan" & ss
                .Cmd.ExecuteNonQuery()
                .Close_Koneksi()
                MsgBox("Data Telah DiUbah", MsgBoxStyle.Information)
                Call bersih()
            End With
        End If
    End Sub

    Private Sub BtnBersih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBersih.Click
        Call bersih()
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If txtId.Text = "" Or txtNama.Text = "" Or txtAlamat.Text = "" Then
            MsgBox("Maaf Data Tidak Lengkap", MsgBoxStyle.Information)
        Else
            Dim ty As String
            ty = MsgBox("Apakah Anda Yakin Untuk Menghapus", MsgBoxStyle.YesNo)
            If ty = vbYes Then
                With cls
                    .Open_koneksi()
                    Dim ss As String
                    ss = "'" & txtId.Text & "'"
                    .Cmd.CommandText = "Hapus_Karyawan" & ss
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

    Private Sub fa_AfterEdit(ByVal sender As Object, ByVal e As AxVSFlex8._IVSFlexGridEvents_AfterEditEvent) Handles fa.AfterEdit
        Dim kolom As Byte
        If fa.Col = 0 Then
            kolom = fa.Col
            NamaField = "Id_Karyawan"
        ElseIf fa.Col = 1 Then
            kolom = fa.Col
            NamaField = "Nama"
        ElseIf fa.Col = 2 Then
            kolom = fa.Col
            NamaField = "Alamat"
        ElseIf fa.Col = 3 Then
            kolom = fa.Col
            NamaField = "Jenis_Kelamin"
        ElseIf fa.Col = 5 Then
            kolom = fa.Col
            NamaField = "Jabatan"
        ElseIf fa.Col = 6 Then
            kolom = fa.Col
            NamaField = "Status_Karyawan"
        End If
        If fa.Row = 1 And fa.get_TextMatrix(1, kolom) <> "" Then
            With cls
                .Open_koneksi()
                .Cmd.CommandText = "select *from v_Karyawan where " & NamaField & " like '%" & fa.get_TextMatrix(1, kolom) & "%'"
                .Cmd.ExecuteNonQuery()
                .ReadTabel = .Cmd.ExecuteReader
                If .ReadTabel.HasRows = False Then
                    MsgBox("Maaf Data Tidak Ada", MsgBoxStyle.Information)
                    .Close_Koneksi()
                    Call display()
                    fa.set_TextMatrix(1, kolom, "")
                    Exit Sub
                Else
                    Call List()
                    Dim i As String
                    i = fa.Rows
                    Do While .ReadTabel.Read
                        fa.Rows = i + 1
                        fa.set_TextMatrix(i, 0, Trim(.ReadTabel("Id_Karyawan")))
                        fa.set_TextMatrix(i, 1, Trim(.ReadTabel("Nama")))
                        fa.set_TextMatrix(i, 2, Trim(.ReadTabel("Alamat")))
                        fa.set_TextMatrix(i, 3, Trim(.ReadTabel("JK")))
                        fa.set_TextMatrix(i, 4, Format(.ReadTabel("Tgl_Masuk"), "dd/MM/yyyy"))
                        fa.set_TextMatrix(i, 5, Trim(.ReadTabel("Jabatan")))
                        fa.set_TextMatrix(i, 6, Trim(.ReadTabel("SK")))
                        i = i + 1
                    Loop
                    fa.set_TextMatrix(1, kolom, "")
                End If
                .Close_Koneksi()
            End With
        End If
    End Sub

    Private Sub fa_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles fa.ClickEvent
        If fa.Row = 1 Then
            txtNama.Text = ""
            txtAlamat.Text = ""
            Call combo()
            BtnSimpan.Enabled = True
            BtnUbah.Enabled = False
            BtnHapus.Enabled = False
        Else
            Call combo()
            txtId.Text = fa.get_TextMatrix(fa.Row, 0)
            txtNama.Text = fa.get_TextMatrix(fa.Row, 1)
            txtAlamat.Text = fa.get_TextMatrix(fa.Row, 2)
            If fa.get_TextMatrix(fa.Row, 3) = "Laki-Laki" Then
                RDLaki.Checked = True
            Else
                RDPerempuan.Checked = True
            End If
            DateTimePicker1.Value = Format(fa.get_TextMatrix(fa.Row, 4), "dd/MM/yyyy")
            CmbJabatan.Text = fa.get_TextMatrix(fa.Row, 5)
            If fa.get_TextMatrix(fa.Row, 6) = "Aktif" Then
                RDAktif.Checked = True
            Else
                RDNonAktif.Checked = True
            End If

            BtnSimpan.Enabled = False
            BtnUbah.Enabled = True
            BtnHapus.Enabled = True
        End If
    End Sub

    Private Sub fa_KeyDownEvent(ByVal sender As Object, ByVal e As AxVSFlex8._IVSFlexGridEvents_KeyDownEvent) Handles fa.KeyDownEvent
        If e.keyCode = Keys.F5 Then
            Call display()
        End If
    End Sub

    Private Sub fa_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fa.SelChange
        If fa.Row = 1 Then
            txtNama.Text = ""
            txtAlamat.Text = ""
            BtnSimpan.Enabled = True
            BtnUbah.Enabled = False
            BtnHapus.Enabled = False
            Call nomor()
            Call combo()
        Else
            txtId.Text = fa.get_TextMatrix(fa.Row, 0)
            txtNama.Text = fa.get_TextMatrix(fa.Row, 1)
            txtAlamat.Text = fa.get_TextMatrix(fa.Row, 2)
            If fa.get_TextMatrix(fa.Row, 3) = "Laki-Laki" Then
                RDLaki.Checked = True
            Else
                RDPerempuan.Checked = True
            End If

            CmbJabatan.Text = fa.get_TextMatrix(fa.Row, 5)
            If fa.get_TextMatrix(fa.Row, 6) = "Aktif" Then
                RDAktif.Checked = True
            Else
                RDNonAktif.Checked = True
            End If
            BtnSimpan.Enabled = False
            BtnUbah.Enabled = True
            BtnHapus.Enabled = True
            DateTimePicker1.Value = (fa.get_TextMatrix(fa.Row, 4))
        End If
    End Sub

    Private Sub txtId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtId.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class