Imports System.Windows.Forms

Public Class Frm_Menu

    Dim cls As New ClsKoneksi

    Private Sub DataKaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataKaryawanToolStripMenuItem.Click
        Frm_Karyawan.Show()
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryToolStripMenuItem.Click
        Frm_History.Show()
    End Sub

    Private Sub ProcessNaiveBayesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessNaiveBayesToolStripMenuItem.Click
        Frm_Naive_Bayes.Show()
    End Sub

    Private Sub LaporanNaiveBayesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LaporanNaiveBayesToolStripMenuItem.Click
        Frm_Laporan_Naive_Bayes.Show()
    End Sub

    Private Sub Frm_Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cls.non_aktif()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        Frm_Login.Show()
    End Sub

    Private Sub AdministratorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdministratorToolStripMenuItem.Click
        Frm_Administrator.Show()
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        Frm_Change.Show()
    End Sub
End Class
