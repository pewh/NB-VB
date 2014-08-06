Imports System.Data
Imports System.Data.SqlClient

Public Class ClsKoneksi
    Public DBCon As New SqlClient.SqlConnection
    Public Cmd As New SqlClient.SqlCommand
    Public ReadTabel As SqlClient.SqlDataReader


    Sub Open_koneksi()
        DBCon.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DB_RemcoInsentif;Data Source=ACER4750SB\SQLEXPRESS"
        DBCon.Open()
        Cmd.Connection = DBCon
    End Sub

    Public Sub Close_Koneksi()
        DBCon.Close()
    End Sub

    Sub non_aktif()
        With Frm_Menu
            .AdministratorToolStripMenuItem.Enabled = False
            .KaryawanToolStripMenuItem.Enabled = False
            .HistoryToolStripMenuItem.Enabled = False
            .ProcessNaiveBayesToolStripMenuItem.Enabled = False
            .LaporanNaiveBayesToolStripMenuItem.Enabled = False
        End With
    End Sub
End Class
