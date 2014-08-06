Public Class Frm_Laporan_Naive_Bayes
    Dim cls As New ClsKoneksi

    Private Sub Frm_Laporan_Naive_Bayes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call combo()
        Call display()
    End Sub

    Function returnZeroIfNull(ByVal obj As Object, Optional ByVal friendly As Boolean = True) As Object
        If obj.GetType.Name = "DBNull" Then
            Return "<belum ditentukan>"
        Else

            If friendly = True Then
                If obj = "1" Then
                    Return "Ya"
                Else
                    Return "Tidak"
                End If
            End If

            Return obj
        End If
    End Function

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

    Sub List()
        With fa
            .Cols = 12
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
            .set_TextMatrix(0, 8, "Hasil Ya")
            .set_TextMatrix(0, 9, "Hasil Tidak")
            .set_TextMatrix(0, 10, "Insentif")
            .set_TextMatrix(0, 11, "Insentif yang diambil")

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
            .set_ColWidth(11, 1500)

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
            .Cmd.CommandText = "select * from v_Naive_Bayes"
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
                    fa.set_TextMatrix(i, 8, Trim(.ReadTabel("Nilai_Ya")))
                    fa.set_TextMatrix(i, 9, Trim(.ReadTabel("Nilai_Tidak")))
                    fa.set_TextMatrix(i, 10, Trim(.ReadTabel("Ins")))
                    fa.set_TextMatrix(i, 11, Trim(returnZeroIfNull(.ReadTabel("Insentif_diambil"))))
                    i = i + 1
                Loop
            End If
            .Close_Koneksi()
        End With
    End Sub


    Private Sub BtnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnView.Click
        Call List()
        Dim ins As Integer
        If RDYa.Checked = True Then
            ins = 0
        ElseIf RDTidak.Checked = True Then
            ins = 1
        ElseIf RDAll.Checked = True Then
            ins = 2
        End If
        If ins = 2 Then
            With cls
                .Open_koneksi()
                .Cmd.CommandText = "select *from v_Naive_Bayes where Tahun=" & CmbTahun.Text & " and Bulan=" & CmbBulan.Text
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
                        fa.set_TextMatrix(i, 8, Trim(.ReadTabel("Nilai_Ya")))
                        fa.set_TextMatrix(i, 9, Trim(.ReadTabel("Nilai_Tidak")))
                        fa.set_TextMatrix(i, 10, Trim(.ReadTabel("Ins")))
                        fa.set_TextMatrix(i, 11, Trim(returnZeroIfNull(.ReadTabel("Insentif_diambil"))))
                        i = i + 1
                    Loop
                End If
                .Close_Koneksi()
            End With
        Else
            With cls
                .Open_koneksi()
                .Cmd.CommandText = "select *from v_Naive_Bayes where Tahun=" & CmbTahun.Text & " and Bulan=" & CmbBulan.Text & " and Insentif=" & ins
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
                        fa.set_TextMatrix(i, 8, Trim(.ReadTabel("Nilai_Ya")))
                        fa.set_TextMatrix(i, 9, Trim(.ReadTabel("Nilai_Tidak")))
                        fa.set_TextMatrix(i, 10, Trim(.ReadTabel("Ins")))
                        fa.set_TextMatrix(i, 11, Trim(returnZeroIfNull(.ReadTabel("Insentif_diambil"))))
                        i = i + 1
                    Loop
                End If
                .Close_Koneksi()
            End With
        End If

    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click
        Me.Close()
    End Sub

    Private Sub fa_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles fa.ClickEvent
        'fa.get_TextMatrix(fa.Row, 4)
        GroupBox1.Visible = True

        'Dim insentifDiambil As String

        'Select Case fetchOne("SELECT insentif_diambil from naive_bayes where id_karyawan = '" & fa.get_TextMatrix(fa.Row, 2) & "'")
        '    Case "1"
        '        insentifDiambil = 1
        '    Case "0"
        '        insentifDiambil = 0
        '    Case Else
        '        insentifDiambil = 2
        'End Select

        'MsgBox(fetchOne("SELECT insentif_diambil from naive_bayes where id_karyawan = '" & fa.get_TextMatrix(fa.Row, 2) & "'"))

        'CmbInsentifDipilih.SelectedIndex = insentifDiambil
    End Sub

    Private Sub BtnCustomOutput_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCustomOutput.Click

        With cls
            .Open_koneksi()
            Dim insentifDiambil As String

            Select Case CmbInsentifDipilih.SelectedIndex
                Case 0
                    insentifDiambil = "1"
                Case 1
                    insentifDiambil = "0"
                Case Else
                    insentifDiambil = "NULL"
            End Select

            Dim idKaryawan As String = fa.get_TextMatrix(fa.Row, 2)
            .Cmd.CommandText = "update naive_bayes set insentif_diambil = " & insentifDiambil & " where id_karyawan = '" & idKaryawan & "'"
            .Cmd.ExecuteNonQuery()
            .Close_Koneksi()
            MsgBox("Data Telah Diubah", MsgBoxStyle.Information)

            Call List()
            Dim ins As Integer

            With cls
                .Open_koneksi()
                .Cmd.CommandText = "select *from v_Naive_Bayes "
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
                        fa.set_TextMatrix(i, 8, Trim(.ReadTabel("Nilai_Ya")))
                        fa.set_TextMatrix(i, 9, Trim(.ReadTabel("Nilai_Tidak")))
                        fa.set_TextMatrix(i, 10, Trim(.ReadTabel("Ins")))
                        fa.set_TextMatrix(i, 11, Trim(returnZeroIfNull(.ReadTabel("Insentif_diambil"))))
                        i = i + 1
                    Loop
                End If
                .Close_Koneksi()
            End With
            
        End With
    End Sub

    Private Sub fa_SelChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fa.SelChange

    End Sub
End Class