Public Class NaiveBayes

    Dim data As New DataTable

    Private Function getAllFields(ByVal data As DataTable, Optional ByVal exceptionName As String = "")
        Dim fields As New List(Of String)
        Dim i As Integer = 0

        For Each column As DataColumn In data.Columns
            fields.Add(column.ColumnName)
        Next

        fields.Remove(exceptionName)

        Return fields
    End Function

    Public Function result(ByVal rules As Dictionary(Of String, Double))
        Dim data As DataTable = fetch("select Absensi, Penampilan, Sikap, Lama_Kerja, Insentif from History_Insentif")

        Dim totalData As Integer = data.Rows.Count
        Dim arrayOfYes = data.Select("Insentif = 1")
        Dim arrayOfNo = data.Select("Insentif = 0")
        Dim totalYes As Integer = arrayOfYes.Count
        Dim totalNo As Integer = arrayOfNo.Count
        Dim chanceOfYes As Double = totalYes / totalData
        Dim chanceOfNo As Double = totalNo / totalData

        ' nilai estimator tingkat pertama
        If chanceOfYes = 0 And chanceOfNo = 0 Then
            chanceOfYes = (totalYes + 1) / totalData
            chanceOfNo = (totalNo + 1) / totalData
        End If

        ' variabel penampung
        Dim output As New Dictionary(Of String, Double)

        ' variabel P(Ya)'
        Dim chanceOfYesList As New List(Of Double)

        ' variabel P(Tidak)'
        Dim chanceOfNoList As New List(Of Double)

        ' masukan nilai PYa ke P(ya)'
        chanceOfYesList.Add(chanceOfYes)
        ' masukan nilai PTdk ke P(Tidak)'
        chanceOfNoList.Add(chanceOfNo)

        ' perulangan sebanyak jumlah kriteria
        For Each field As String In getAllFields(data, "Insentif")
            ' masukan nilai utk P(kriteria_1|ya), P(Kriteria_2|ya), dst
            chanceOfYesList.Add((From value In arrayOfYes.ToList Where (value.Item("Insentif") = 1 And value.Item(field) = rules(field)) Select value).Count / totalYes)

            ' masukan nilai utk P(kriteria_1|tdk), P(Kriteria_2|tdk), dst
            chanceOfNoList.Add((From value In arrayOfNo.ToList() Where (value.Item("Insentif") = 0 And value.Item(field) = rules(field)) Select value).Count / totalNo)
        Next

        ' saling mengalikan utk P(Ya)'
        Dim totalChanceOfYes As Double = chanceOfYesList.Aggregate(Function(container, value) container * value)

        ' saling mengalikan utk P(Tdk)'
        Dim totalChanceOfNo As Double = chanceOfNoList.Aggregate(Function(container, value) container * value)

        ' nilai estimator tingkat kedua
        If totalChanceOfYes = 0 And totalChanceOfNo = 0 Then
            chanceOfYesList.Clear()
            chanceOfNoList.Clear()

            chanceOfYesList.Add(chanceOfYes)
            chanceOfNoList.Add(chanceOfNo)

            For Each field As String In getAllFields(data, "Insentif")
                chanceOfYesList.Add(((From value In arrayOfYes.ToList Where value.Item("Insentif") = 1 And value.Item(field) = rules(field) Select value).Count + 1) / totalYes)

                chanceOfNoList.Add(((From value In arrayOfNo.ToList() Where (value.Item("Insentif") = 0 And value.Item(field) = rules(field)) Select value).Count + 1) / totalNo)
            Next

            totalChanceOfYes = chanceOfYesList.Aggregate(Function(container, value) container * value)
            totalChanceOfNo = chanceOfNoList.Aggregate(Function(container, value) container * value)
        End If

        output.Add("diterima", totalChanceOfYes)
        output.Add("ditolak", totalChanceOfNo)

        Return output
    End Function

End Class
