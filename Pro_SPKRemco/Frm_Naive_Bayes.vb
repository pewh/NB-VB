Public Class Frm_Naive_Bayes
    Dim cls As New ClsKoneksi

    Dim Tot_Ya As Integer
    Dim Tot_Tidak As Integer

    Dim ab, p, s, lk, ins As Integer

    Dim tot_temp As Integer

    Dim PYaIns, PTdkIns As Double
    Dim PYaAbs, PTdkAbs As Double
    Dim PYaTampil, PTdkTampil As Double
    Dim PYaSopan, PTdkSopan As Double
    Dim PYaLK, PTdkLK As Double

    Dim YYa, YTidak As Double

    Dim kond_Absen As Integer
    Dim kond_Tampil As Integer
    Dim kond_Sopan As Integer
    Dim kond_LK As Integer

    Dim NamaField As String
    Dim kondisi_kary As Boolean
    Dim idkary As String

    Private Sub BtnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProcess.Click
        If RDYaAbsen.Checked = True Then
            kond_Absen = 1
        Else
            kond_Absen = 0
        End If
        If RDYaRapih.Checked = True Then
            kond_Tampil = 1
        Else
            kond_Tampil = 0
        End If
        If RDYaSopan.Checked = True Then
            kond_Sopan = 1
        Else
            kond_Sopan = 0
        End If
        If RDYa6.Checked = True Then
            kond_LK = 1
        Else
            kond_LK = 0
        End If
        Call ProcessInsentif()
        lblHasilYa.Text = YYa
        lblHasilTidak.Text = YTidak
    End Sub
    Sub ProcessInsentif()
        If txtIdKaryawan.Text <> "" Then
            Dim nb As New NaiveBayes
            Dim rules As New Dictionary(Of String, Double)
            rules.Add("Absensi", kond_Absen)
            rules.Add("Penampilan", kond_Tampil)
            rules.Add("Sikap", kond_Sopan)
            rules.Add("Lama_Kerja", kond_LK)

            Dim output = nb.result(rules)

            YYa = output("diterima")
            YTidak = output("ditolak")

            MsgBox("Ya = " & YYa & "    Tidak=" & YTidak)

            If YYa > YTidak Then
                LblHasil.Text = "Sebaiknya diberikan insentif"
            ElseIf YYa = YTidak Then
                LblHasil.Text = "Nilai sama"
            Else
                LblHasil.Text = "Sebaiknya tidak diberikan insentif"
                'Else
                'MsgBox("Data Belum lengkap", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub Frm_Naive_Bayes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call combo()
        Call display()
    End Sub

    Sub combo()
        For i = 2013 To 2099
            CmbTahun.Items.Add(i)
        Next
        For i = 1 To 12
            CmbBulan.Items.Add(i)
        Next
        CmbTahun.Text = Year(Now)
        CmbBulan.Text = Month(Now)
    End Sub

    Private Sub txtIdKaryawan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtIdKaryawan.KeyDown
        If e.KeyCode = Keys.F5 Then
            faKaryawan.Visible = True
            faKaryawan.Location = New Point(162, 192)
            Call displaykaryawan()
            faKaryawan.Focus()
        End If
    End Sub

    Private Sub txtId_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F5 Then
            faPeriod.Visible = True
            faPeriod.Location = New Point(460, 136)
            Call displayPeriod()
            faPeriod.Focus()
        End If
    End Sub



    Sub displayPeriod()
        Call ListPeriod()
        With cls
            .Open_koneksi()
            .Cmd.CommandText = "select *from v_Period_List"
            .Cmd.ExecuteNonQuery()
            .ReadTabel = .Cmd.ExecuteReader
            If .ReadTabel.HasRows = True Then
                Dim i As Integer
                i = faPeriod.Rows
                Do While .ReadTabel.Read
                    faPeriod.Rows = i + 1
                    faPeriod.set_TextMatrix(i, 0, Trim(.ReadTabel("Period_ID")))
                    faPeriod.set_TextMatrix(i, 1, Trim(.ReadTabel("Period_Name")))
                    faPeriod.set_TextMatrix(i, 2, Trim(.ReadTabel("Ya_Insentif")))
                    faPeriod.set_TextMatrix(i, 3, Trim(.ReadTabel("Tdk_Insentif")))
                    faPeriod.set_TextMatrix(i, 4, Trim(.ReadTabel("Jumlah")))
                    faPeriod.set_TextMatrix(i, 5, Trim(.ReadTabel("Tot_Ya")))
                    faPeriod.set_TextMatrix(i, 6, Trim(.ReadTabel("Tot_Tidak")))

                    i = i + 1
                Loop
            End If
            .Close_Koneksi()
        End With
    End Sub

    Sub ListPeriod()
        With faPeriod
            .Cols = 7
            .Rows = 2
            .FixedCols = 0

            .set_TextMatrix(0, 0, "Id Karyawan")
            .set_TextMatrix(0, 1, "Nama")
            

            .set_ColWidth(0, 1300)
            .set_ColWidth(1, 3800)
            

            For i = 2 To .Cols - 1
                .set_ColHidden(i, True)
            Next
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

    Private Sub faPeriod_AfterEdit(ByVal sender As Object, ByVal e As AxVSFlex8._IVSFlexGridEvents_AfterEditEvent) Handles faPeriod.AfterEdit
        Dim kolom As Byte
        If faPeriod.Col = 0 Then
            kolom = faPeriod.Col
            NamaField = "Period_ID"
        ElseIf faPeriod.Col = 1 Then
            kolom = faPeriod.Col
            NamaField = "Period_Name"
        End If
        If faPeriod.Row = 1 And faPeriod.get_TextMatrix(1, kolom) <> "" Then
            With cls
                .Open_koneksi()
                .Cmd.CommandText = "select *from v_Period_List where " & NamaField & " like '%" & faPeriod.get_TextMatrix(1, kolom) & "%'"
                .Cmd.ExecuteNonQuery()
                .ReadTabel = .Cmd.ExecuteReader
                If .ReadTabel.HasRows = False Then
                    MsgBox("Maaf Data Tidak Ada", MsgBoxStyle.Information)
                    .Close_Koneksi()
                    Call displayPeriod()
                    faPeriod.set_TextMatrix(1, kolom, "")
                    Exit Sub
                Else
                    Call ListPeriod()
                    Dim i As String
                    i = faPeriod.Rows
                    Do While .ReadTabel.Read
                        faPeriod.Rows = i + 1
                        faPeriod.set_TextMatrix(i, 0, Trim(.ReadTabel("Period_ID")))
                        faPeriod.set_TextMatrix(i, 1, Trim(.ReadTabel("Period_Name")))

                        i = i + 1
                    Loop
                    faPeriod.set_TextMatrix(1, kolom, "")
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

    Private Sub faPeriod_KeyDownEvent(ByVal sender As Object, ByVal e As AxVSFlex8._IVSFlexGridEvents_KeyDownEvent) Handles faPeriod.KeyDownEvent
        If e.keyCode = Keys.Enter Then
            If faPeriod.Row > 1 Then
                'txtId.Text = Trim(faPeriod.get_TextMatrix(faPeriod.Row, 0))
                'lblPeriod.Text = Trim(faPeriod.get_TextMatrix(faPeriod.Row, 1))
                PYaIns = Trim(faPeriod.get_TextMatrix(faPeriod.Row, 2))
                PTdkIns = Trim(faPeriod.get_TextMatrix(faPeriod.Row, 3))
                Tot_Ya = Trim(faPeriod.get_TextMatrix(faPeriod.Row, 5))
                Tot_Tidak = Trim(faPeriod.get_TextMatrix(faPeriod.Row, 6))
                faPeriod.Visible = False
            End If
        ElseIf e.keyCode = Keys.Escape Then
            faPeriod.Visible = False
            'txtId.Focus()
        End If
    End Sub

    Sub check_data()
        With cls
            .Open_koneksi()
            .Cmd.CommandText = "select *from Naive_Bayes where Tahun=" & CmbTahun.Text & " and Bulan=" & CmbBulan.Text & " and Id_Karyawan='" & idkary & "'"
            .Cmd.ExecuteNonQuery()
            .ReadTabel = .Cmd.ExecuteReader
            If .ReadTabel.HasRows = False Then
                kondisi_kary = False
            Else
                kondisi_kary = True
            End If
            .Close_Koneksi()
        End With
    End Sub


    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If txtIdKaryawan.Text = "" Or lblHasilYa.Text = "" Or lblHasilTidak.Text = "" Or lblnama.Text = "" Then
            MsgBox("Maaf Data Tidak Lengkap", MsgBoxStyle.Information)
        Else
            With cls
                Dim ss As String
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
                If Val(lblHasilYa.Text) > Val(lblHasilTidak.Text) Then
                    ins = 0
                Else
                    ins = 1
                End If
                .Open_koneksi()
                ss = CmbTahun.Text & "," & CmbBulan.Text & ",'" & txtIdKaryawan.Text & "'," & ab & "," & p & "," & s & "," & lk & "," & ins & "," & lblHasilYa.Text & "," & lblHasilTidak.Text
                .Cmd.CommandText = "Simpan_Naive_Bayes " & ss

                .Cmd.ExecuteNonQuery()
                .Close_Koneksi()
                MsgBox("Data Telah DiSimpan", MsgBoxStyle.Information)
                Call bersih()
            End With
        End If
    End Sub

    Sub bersih()
        txtIdKaryawan.Text = ""
        lblHasilTidak.Text = ""
        lblHasilYa.Text = ""
        lblnama.Text = ""
        RDYa6.Checked = True
        RDYaAbsen.Checked = True
        RDYaRapih.Checked = True
        RDYaSopan.Checked = True
        Call display()
    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub BtnBersih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBersih.Click
        Call bersih()
    End Sub

    Sub List()
        With fa
            .Cols = 11
            .Rows = 2
            .FixedCols = 0

            .set_TextMatrix(0, 0, "Tahun")
            .set_TextMatrix(0, 1, "Bulan")
            .set_TextMatrix(0, 2, "Id Karyawan")
            .set_TextMatrix(0, 3, "Nama")
            .set_TextMatrix(0, 4, "Absensi")
            .set_TextMatrix(0, 5, "Penampilan")
            .set_TextMatrix(0, 6, "Sikap")
            .set_TextMatrix(0, 7, "Lama Kerja")
            .set_TextMatrix(0, 8, "Insentif")
            .set_TextMatrix(0, 9, "Hasil Ya")
            .set_TextMatrix(0, 10, "Hasil Tidak")

            .set_ColWidth(0, 1300)
            .set_ColWidth(1, 2800)
            .set_ColWidth(2, 2000)
            .set_ColWidth(3, 2000)
            .set_ColWidth(4, 1500)
            .set_ColWidth(5, 1500)
            .set_ColWidth(6, 1500)
            .set_ColWidth(7, 1500)
            .set_ColWidth(8, 1500)
            .set_ColWidth(9, 1500)
            .set_ColWidth(10, 1500)

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

    Sub display()
        Call List()
        With cls
            .Open_koneksi()
            .Cmd.CommandText = "select *from v_Naive_Bayes"
            .Cmd.ExecuteNonQuery()
            .ReadTabel = .Cmd.ExecuteReader
            If .ReadTabel.HasRows = True Then
                Dim i As Integer
                i = fa.Rows
                Do While .ReadTabel.Read
                    fa.Rows = i + 1
                    fa.set_TextMatrix(i, 0, Trim(.ReadTabel("Tahun")))
                    fa.set_TextMatrix(i, 1, Trim(.ReadTabel("Bulan")))
                    fa.set_TextMatrix(i, 2, Trim(.ReadTabel("Id_Karyawan")))
                    fa.set_TextMatrix(i, 3, Trim(.ReadTabel("Nama")))
                    fa.set_TextMatrix(i, 4, Trim(.ReadTabel("Absen")))
                    fa.set_TextMatrix(i, 5, Trim(.ReadTabel("Tmpl")))
                    fa.set_TextMatrix(i, 6, Trim(.ReadTabel("Skp")))
                    fa.set_TextMatrix(i, 7, Trim(.ReadTabel("LK")))
                    fa.set_TextMatrix(i, 8, Trim(.ReadTabel("Ins")))
                    fa.set_TextMatrix(i, 9, Trim(.ReadTabel("Nilai_Ya")))
                    fa.set_TextMatrix(i, 10, Trim(.ReadTabel("Nilai_Tidak")))
                    i = i + 1
                Loop
            End If
            .Close_Koneksi()
        End With
    End Sub

  
    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If txtIdKaryawan.Text = "" Or lblHasilYa.Text = "" Or lblHasilTidak.Text = "" Or lblnama.Text = "" Then
            MsgBox("Maaf Data Tidak Lengkap", MsgBoxStyle.Information)
        Else
            Dim ty As String
            ty = MsgBox("Apakah Anda Yakin Untuk Menghapus", MsgBoxStyle.YesNo)
            If ty = vbYes Then
                With cls
                    .Open_koneksi()
                    Dim ss As String
                    ss = CmbTahun.Text & "," & CmbBulan.Text & ",'" & txtIdKaryawan.Text & "'"
                    .Cmd.CommandText = "Hapus_Naive_Bayes " & ss
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

    Private Sub fa_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fa.SelChange
        If fa.Row = 1 Then
            txtIdKaryawan.Text = ""
            lblnama.Text = ""
            lblnama.Text = ""
            LblHasil.Text = ""
            lblHasilTidak.Text = ""
            lblHasilYa.Text = ""

            RDYa6.Checked = True
            RDYaAbsen.Checked = True

            RDYaRapih.Checked = True
            RDYaSopan.Checked = True

            BtnSimpan.Enabled = True

            BtnHapus.Enabled = False

        Else
            CmbTahun.Text = fa.get_TextMatrix(fa.Row, 0)
            CmbBulan.Text = fa.get_TextMatrix(fa.Row, 1)
            txtIdKaryawan.Text = fa.get_TextMatrix(fa.Row, 2)
            lblnama.Text = fa.get_TextMatrix(fa.Row, 3)

            If fa.get_TextMatrix(fa.Row, 8) = "Ya" Then
                LblHasil.Text = "Sebaiknya diberikan insentif"
            Else
                LblHasil.Text = "Sebaiknya tidak diberikan insentif"
            End If

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
            lblHasilYa.Text = fa.get_TextMatrix(fa.Row, 9)
            lblHasilTidak.Text = fa.get_TextMatrix(fa.Row, 10)

            BtnSimpan.Enabled = False
            BtnHapus.Enabled = True

        End If
    End Sub

    Private Sub txtIdKaryawan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdKaryawan.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class