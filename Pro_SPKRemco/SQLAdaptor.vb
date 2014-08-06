Imports System.Data.SqlClient
Imports System.IO

Module sqlAdaptor

    Public sql As New SqlConnection

    Sub setStringConnection(ByVal host As String, ByVal database As String, Optional ByVal username As String = "", Optional ByVal password As String = "")
        sql.ConnectionString = String.Format("Data Source={0}; Initial Catalog={1}; User Id={2}; Password={3}; Integrated Security=True", host, database, username, password)
    End Sub

    Function exec(ByVal query As String) As Boolean
        Dim cmd As New SqlCommand(query, sql)

        Try
            sql.Open()
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            Trace.Write(ex.Message)
            Return False
        Finally
            If sql.State = ConnectionState.Open Then
                sql.Close()
            End If
        End Try
    End Function

    Function fetch(ByVal query As String) As DataTable
        Dim cmd As New SqlCommand(query, sql)
        Dim dataAdapter As New SqlDataAdapter
        Dim dataTable As New DataTable

        dataAdapter.SelectCommand = cmd

        Try
            sql.Open()
            dataAdapter.Fill(dataTable)
        Catch ex As Exception
            Return New DataTable
        End Try

        If sql.State = ConnectionState.Open Then
            sql.Close()
        End If

        Return dataTable
    End Function


    Function fetchOne(ByVal query As String) As String
        Try
            Dim fetched As DataTable = fetch(query)
            Return fetched.Rows(0).Item(0)
        Catch ex As Exception
            Return "0"
        End Try
    End Function


    Function countFetch(ByVal query As String) As Integer
        If fetch(query) Is Nothing Then
            Return -1
        Else
            Return fetch(query).Rows.Count
        End If
    End Function

    Sub fetchToDatagrid(ByVal datagrid As DataGridView, ByVal query As String, ByVal ParamArray indexColumnsToHide() As Integer)
        Dim fetchedTable As DataTable = fetch(query)

        If fetchedTable IsNot Nothing Then
            datagrid.DataSource = fetchedTable
        End If

        If fetchedTable.Columns.Count > 0 Then
            For Each indexColumnToHide In indexColumnsToHide
                datagrid.Columns(indexColumnToHide).Visible = False
            Next
        End If
    End Sub

    Sub fetchToCombobox(ByVal combobox As ComboBox, ByVal query As String)
        Dim fetchedTable As DataTable = fetch(query)

        combobox.Items.Clear()

        For index = 0 To countFetch(query) - 1
            combobox.Items.Add(fetchedTable.Rows(index).Item(0))
        Next
    End Sub

    Sub fetchToListbox(ByVal listbox As ListBox, ByVal query As String)
        Dim fetchedTable As DataTable = fetch(query)

        listbox.Items.Clear()

        If countFetch(query) > 0 Then
            For index = 0 To countFetch(query) - 1
                listbox.Items.Add(fetchedTable.Rows(index).Item(0))
            Next
        End If
    End Sub
End Module
