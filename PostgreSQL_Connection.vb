Option Explicit On
Option Strict On
Imports Npgsql

Module PostgreSQL_Connection

    Public Function GetConnectionString() As String
        Dim host As String = "Host=localhost;"
        Dim port As String = "Port=5432;"
        Dim database As String = "Database=postgres;"
        Dim user As String = "Username=postgres;"
        Dim password As String = "Password=abc123;"

        Dim connString As String = String.Format("{0}{1}{2}{3}{4}", host, port, database, user, password)
        'Dim connString As String = $"Host={host};Port={port};Database={database};User ID={user};Password={password};"

        Return connString

    End Function

    Public conn As New NpgsqlConnection(GetConnectionString())
    Public cmd As NpgsqlCommand
    Public sql As String = ""

    Public Function PerformCRUD(com As NpgsqlCommand) As DataTable

        Dim da As NpgsqlDataAdapter
        Dim dt As New DataTable()

        Try

            da = New NpgsqlDataAdapter
            da.SelectCommand = com
            da.Fill(dt)

            Return dt

        Catch ex As Exception
            MessageBox.Show("An error occured: " & ex.Message, "Perform CRUD Operations Failed ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt

    End Function

End Module
