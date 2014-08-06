Public Class Frm_History
    Dim cls As New ClsKoneksi
    Dim NamaField As String
    Dim kondisi_kary As Boolean
    Dim idkary As String
    Dim ab, p, s, lk, ins As String

    Private Sub Frm_History_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call display()
        Call nomor()
    End Sub


    Sub nomor()
        With cls
            .Open_koneksi()
            .Cmd.CommandText = "select *from History_Insentif order by Id_Karyawan desc"
            .Cmd.ExecuteNonQuery()
            .ReadTabel = .Cmd.ExecuteReader
            
            .Close_Koneksi()
        End With
    End Sub



    Sub display()
        Call List()
        On Error Resume Next
        With cls
            .Open_koneksi()
            .Cmd.CommandText = "select id_karyawan, period_name, absen, tmpl, skp, lk, ins from v_History_Insentif"
            .Cmd.ExecuteNonQuery()
            .ReadTabel = .Cmd.ExecuteReader
            If .ReadTabel.HasRows = True Then
                Dim i As Integer
                i = fa.Rows
                Do While .ReadTabel.Read
                    fa.Rows = i + 1
                    'fa.set_TextMatrix(i, 0, Trim(.ReadTabel("Period_Id")))
                    fa.set_TextMatrix(i, 0, Trim(.ReadTabel("Id_Karyawan")))
                    fa.set_TextMatrix(i, 1, Trim(.ReadTabel("Period_Name")))
                    'fa.set_TextMatrix(i, 3, Trim(.ReadTabel("Nama")))
                    fa.set_TextMatrix(i, 2, Trim(.ReadTabel("Absen")))
                    fa.set_TextMatrix(i, 3, Trim(.ReadTabel("Tmpl")))
                    fa.set_TextMatrix(i, 4, Trim(.ReadTabel("Skp")))
                    fa.set_TextMatrix(i, 5, Trim(.ReadTabel("LK")))
                    fa.set_TextMatrix(i, 6, Trim(.ReadTabel("Ins")))
                    i = i + 1
                Loop
            End If
            .Close_Koneksi()
        End With
    End Sub

    Sub List()
        With fa
            .Cols = 9
            .Rows = 2
            .FixedCols = 0

            '.set_TextMatrix(0, 0, "Period ID")
            .set_TextMatrix(0, 0, "Id Karyawan")
            .set_TextMatrix(0, 1, "Period Nama")
            '.set_TextMatrix(0, 3, "Nama")
            .set_TextMatrix(0, 2, "Absensi")
            .set_TextMatrix(0, 3, "Penampilan")
            .set_TextMatrix(0, 4, "Sikap")
            .set_TextMatrix(0, 5, "Lama Kerja")
            .set_TextMatrix(0, 6, "Insentif")

            '.set_ColWidth(0, 1300)
            .set_ColWidth(0, 2000)
            .set_ColWidth(1, 2800)
            '.set_ColWidth(2, 2000)

            .set_ColWidth(2, 1500)
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

    Private Sub txtIdKaryawan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIdKaryawan.KeyDown
        If e.KeyCode = Keys.F5 Then
            faKaryawan.Visible = True
            faKaryawan.Location = New Point(165, 216)
            Call displaykaryawan()
            faKaryawan.Focus()
        End If
    End Sub


    Sub displaykaryawan()

        Call ListKaryawan()
        With cls
            .Open_koneksi()
            .Cmd.CommandText = "select *from v_Karyawan"
            .Cmd.ExecuteNonQuery()
            .ReadTabel = .Cmd.ExecuteReader
            If .ReadTabel.HasRows = True Then
                Dim i As Integer
                i = faKaryawan.Rows
                Do While .ReadTabel.Read
                    faKaryawan.Rows = i + 1
                    faKaryawan.set_TextMatrix(i, 0, Trim(.ReadTabel("Id_Karyawan")))
                    faKaryawan.set_TextMatrix(i, 1, Trim(.ReadTabel("Nama")))
                    faKaryawan.set_TextMatrix(i, 2, Trim(.ReadTabel("Alamat")))
                    faKaryawan.set_TextMatrix(i, 3, Trim(.ReadTabel("JK")))
                    faKaryawan.set_TextMatrix(i, 4, Format(.ReadTabel("Tgl_Masuk"), "dd/MM/yyyy"))
                    faKaryawan.set_TextMatrix(i, 5, Trim(.ReadTabel("SK")))
                    i = i + 1
                Loop
            End If
            .Close_Koneksi()
        End With
    End Sub

    Sub ListKaryawan()
        With faKaryawan
            .Cols = 6
            .Rows = 2
            .FixedCols = 0

            .set_TextMatrix(0, 0, "Id Karyawan")
            .set_TextMatrix(0, 1, "Nama")
            .set_TextMatrix(0, 2, "Alamat")
            .set_TextMatrix(0, 3, "Jenis Kelamin")
            .set_TextMatrix(0, 4, "Tanggal Masuk")
            .set_TextMatrix(0, 5, "Status")

            .set_ColWidth(0, 1300)
            .set_ColWidth(1, 2800)
            .set_ColWidth(2, 4000)
            .set_ColWidth(3, 1500)
            .set_ColWidth(4, 1500)
            .set_ColWidth(5, 1500)

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

    Private Sub faKaryawan_AfterEdit(ByVal sender As Object, ByVal e As AxVSFlex8._IVSFlexGridEvents_AfterEditEvent) Handles faKaryawan.AfterEdit
        Dim kolom As Byte
        If faKaryawan.Col = 0 Then
            kolom = faKaryawan.Col
            NamaField = "Id_Karyawan"
        ElseIf faKaryawan.Col = 1 Then
            kolom = faKaryawan.Col
            NamaField = "Nama"
        ElseIf faKaryawan.Col = 2 Then
            kolom = faKaryawan.Col
            NamaField = "Alamat"
        ElseIf faKaryawan.Col = 3 Then
            kolom = faKaryawan.Col
            NamaField = "Jenis_Kelamin"
        ElseIf faKaryawan.Col = 5 Then
            kolom = faKaryawan.Col
            NamaField = "Status_Karyawan"
        End If
        If faKaryawan.Row = 1 And faKaryawan.get_TextMatrix(1, kolom) <> "" Then
            With cls
                .Open_koneksi()
                .Cmd.CommandText = "select *from v_Karyawan where " & NamaField & " like '%" & faKaryawan.get_TextMatrix(1, kolom) & "%'"
                .Cmd.ExecuteNonQuery()
                .ReadTabel = .Cmd.ExecuteReader
                If .ReadTabel.HasRows = False Then
                    MsgBox("Maaf Data Tidak Ada", MsgBoxStyle.Information)
                    .Close_Koneksi()
                    Call displaykaryawan()
                    faKaryawan.set_TextMatrix(1, kolom, "")
                    Exit Sub
                Else
                    Call ListKaryawan()
                    Dim i As String
                    i = faKaryawan.Rows
                    Do While .ReadTabel.Read
                        faKaryawan.Rows = i + 1
                        faKaryawan.set_TextMatrix(i, 0, Trim(.ReadTabel("Id_Karyawan")))
                        faKaryawan.set_TextMatrix(i, 1, Trim(.ReadTabel("Nama")))
                        faKaryawan.set_TextMatrix(i, 2, Trim(.ReadTabel("Alamat")))
                        faKaryawan.set_TextMatrix(i, 3, Trim(.ReadTabel("JK")))
                        faKaryawan.set_TextMatrix(i, 4, Format(.ReadTabel("Tgl_Masuk"), "dd/MM/yyyy"))
                        faKaryawan.set_TextMatrix(i, 5, Trim(.ReadTabel("SK")))
                        i = i + 1
                    Loop
                    faKaryawan.set_TextMatrix(1, kolom, "")
                End If
                .Close_Koneksi()
            End With
        End If
    End Sub

    Private Sub faKaryawan_KeyDownEvent(ByVal sender As Object, ByVal e As AxVSFlex8._IVSFlexGridEvents_KeyDownEvent) Handles faKaryawan.KeyDownEvent
        If e.keyCode = Keys.Enter Then
            If faKaryawan.Row > 1 Then
                kondisi_kary = False
                idkary = Trim(faKaryawan.get_TextMatrix(faKaryawan.Row, 0))
                Call check_data()

                If kondisi_kary = False Then
                    txtIdKaryawan.Text = Trim(faKaryawan.get_TextMatrix(faKaryawan.Row, 0))
                    lblnama.Text = Trim(faKaryawan.get_TextMatrix(faKaryawan.Row, 1))
                    faKaryawan.Visible = False
                Else
                    MsgBox("Maaf Data sudah ada", MsgBoxStyle.Information)
                End If
                
            End If
        ElseIf e.keyCode = Keys.Escape Then
            faKaryawan.Visible = False
            txtIdKaryawan.Focus()
        End If
    End Sub

    Sub check_data()
        
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        With cls
            .Open_koneksi()
            .Cmd.CommandText = "select *from History_Insentif order by Id_Karyawan desc"
            .Cmd.ExecuteNonQuery()
            .ReadTabel = .Cmd.ExecuteReader
            
            .Close_Koneksi()
        End With

    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If txtIdKaryawan.Text = "" Or lblnama.Text = "" Then
            MsgBox("Maaf Data Tidak Lengkap", MsgBoxStyle.Information)
        Else

            With cls
                .Open_koneksi()
                If RDYaAbsen.Checked = True Then
                    ab = "0"
                Else
                    ab = "1"
                End If
                If RDYaRapih.Checked = True Then
                    p = "0"
                Else
                    p = "1"
                End If
                If RDYaSopan.Checked = True Then
                    s = "0"
                Else
                    s = "1"
                End If
                If RDYa6.Checked = True Then
                    lk = "0"
                Else
                    lk = "1"
                End If
                If RDYaInsentif.Checked = True Then
                    ins = "0"
                Else
                    ins = "1"
                End If

                Dim ss As String

                .Cmd.ExecuteNonQuery()
                .Close_Koneksi()
                MsgBox("Data Telah DiSimpan", MsgBoxStyle.Information)
                Call bersih()
            End With
        End If
    End Sub

    Sub bersih()
        txtIdKaryawan.Text = ""
        lblnama.Text = ""
        RDYa6.Checked = True
        RDYaAbsen.Checked = True
        RDYaInsentif.Checked = True
        RDYaRapih.Checked = True
        RDYaSopan.Checked = True
        Call display()
        Call nomor()
    End Sub

    Private Sub BtnBersih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBersih.Click
        Call bersih()

    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        If txtIdKaryawan.Text = "" Or lblnama.Text = "" Then
            MsgBox("Maaf Data Tidak Lengkap", MsgBoxStyle.Information)
        Else

            With cls
                .Open_koneksi()
                If RDYaAbsen.Checked = True Then
                    ab = "0"
                ElseIf RDTidakAbsen.Checked = True Then
                    ab = "1"
                End If
                If RDYaRapih.Checked = True Then
                    p = "0"
                ElseIf RDTidakRapih.Checked = True Then
                    p = "1"
                End If
                If RDYaSopan.Checked = True Then
                    s = "0"
                ElseIf RDTidakSopan.Checked = True Then
                    s = "1"
                End If
                If RDYa6.Checked = True Then
                    lk = "0"
                ElseIf RDTidak6.Checked = True Then
                    lk = "1"
                End If
                If RDYaInsentif.Checked = True Then
                    ins = "0"
                ElseIf RDTidakInsentif.Checked = True Then
                    ins = "1"
                End If

                Dim ss As String
                ss = "'00','00','" & txtIdKaryawan.Text & "','" & ab & "','" & p & "','" & s & "','" & lk & "','" & ins & "'"
                Debug.Print(ss)

                .Cmd.CommandText = "Ubah_History_Insentif" & ss
                .Cmd.ExecuteNonQuery()
                .Close_Koneksi()
                MsgBox("Data Telah DiUbah", MsgBoxStyle.Information)
                Call bersih()
            End With
        End If
    End Sub

    Private Sub fa_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fa.SelChange
        If fa.Row = 1 Then
            lblnama.Text = ""
            txtIdKaryawan.Text = ""

            RDYa6.Checked = True
            RDYaAbsen.Checked = True
            RDYaInsentif.Checked = True
            RDYaRapih.Checked = True
            RDYaSopan.Checked = True

            BtnSimpan.Enabled = True
            BtnUbah.Enabled = False
            BtnHapus.Enabled = False
            Call nomor()
        Else
            txtIdKaryawan.Text = fa.get_TextMatrix(fa.Row, 0)
            lblnama.Text = fa.get_TextMatrix(fa.Row, 1)
            If fa.get_TextMatrix(fa.Row, 4) = ">= 25 hari" Then
                RDYaAbsen.Checked = True
            Else
                RDTidakAbsen.Checked = True
            End If

            If fa.get_TextMatrix(fa.Row, 5) = "Rapi" Then
                RDYaRapih.Checked = True
            Else
                RDTidakRapih.Checked = True
            End If

            If fa.get_TextMatrix(fa.Row, 6) = "Sopan" Then
                RDYaSopan.Checked = True
            Else
                RDTidakSopan.Checked = True
            End If

            If fa.get_TextMatrix(fa.Row, 7) = "> 6 bln" Then
                RDYa6.Checked = True
            Else
                RDTidak6.Checked = True
            End If

            If fa.get_TextMatrix(fa.Row, 8) = "Ya" Then
                RDYaInsentif.Checked = True
            Else
                RDTidakInsentif.Checked = True
            End If

            BtnSimpan.Enabled = False
            BtnUbah.Enabled = True
            BtnHapus.Enabled = True

        End If
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If txtIdKaryawan.Text = "" Then
            MsgBox("Maaf Data Tidak Lengkap", MsgBoxStyle.Information)
        Else
            Dim ty As String
            ty = MsgBox("Apakah Anda Yakin Untuk Menghapus", MsgBoxStyle.YesNo)
            If ty = vbYes Then
                With cls
                    .Open_koneksi()
                    Dim ss As String
                    ss = "'" & txtIdKaryawan.Text & "'"
                    .Cmd.CommandText = "Hapus_History_Insentif '01', " & ss
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

    Private Sub txtIdKaryawan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtIdKaryawan.TextChanged

    End Sub
End Class