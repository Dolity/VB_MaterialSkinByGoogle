Option Explicit On
Option Strict On

Imports Npgsql

Public Class Form1

    Private ID As String = ""
    Private intRow As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetMe()
        LoadData()
    End Sub

    Private Sub ResetMe()

        Me.ID = ""

        txtFirstName.Text = ""
        txtLastName.Text = ""

        If txtGender.Items.Count > 0 Then
            txtGender.SelectedIndex = 0
        End If

        btnInsert.Text = "Insert"
        btnUpdate.Text = "Update"
        btnDelete.Text = "Delete"

        txtSearch.Clear()
        txtSearch.Select()

    End Sub

    Private Sub LoadData(Optional keyword As String = "")

        sql = "SELECT auto_id, first_name, last_name, CONCAT(first_name, ' ', last_name) AS full_name, gender FROM vb_employee " &
        "WHERE CONCAT(first_name, ' ', last_name) LIKE @keyword::varchar OR TRIM(gender) LIKE @keyword::varchar ORDER BY auto_id ASC "




        Dim strKeyword As String = String.Format("%{0}%", keyword)

        cmd = New NpgsqlCommand(sql, conn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("keyword", strKeyword)

        Dim dt As DataTable = PerformCRUD(cmd)

        If dt.Rows.Count > 0 Then
            intRow = Convert.ToInt32(dt.Rows.Count.ToString())
        Else
            intRow = 0
        End If

        ToolStripStatusLabel1.Text = "Number of row(s): " & intRow.ToString()

        With DataGridView1

            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AutoGenerateColumns = True

            .DataSource = dt

            .Columns(0).HeaderText = "ID"
            .Columns(1).HeaderText = "First Name"
            .Columns(2).HeaderText = "Last Name"
            .Columns(3).HeaderText = "Full Name"
            .Columns(4).HeaderText = "Gender"

            .Columns(0).Width = 60
            .Columns(1).Width = 150
            .Columns(2).Width = 150
            .Columns(3).Width = 200
            .Columns(4).Width = 80
        End With

    End Sub

    Private Sub Execute(MySQL As String, Optional Parameter As String = "")

        cmd = New NpgsqlCommand(MySQL, conn)
        AddParameters(Parameter)
        PerformCRUD(cmd)


    End Sub

    Private Sub AddParameters(str As String)

        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("FirstName", txtFirstName.Text.Trim())
        cmd.Parameters.AddWithValue("LastName", txtLastName.Text.Trim())
        cmd.Parameters.AddWithValue("Gender", txtGender.SelectedItem.ToString())

        If str = "Update" Or str = "Delete" And Not String.IsNullOrEmpty(Me.ID) Then
            cmd.Parameters.AddWithValue("ID", Me.ID)
        End If

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        If String.IsNullOrEmpty(txtFirstName.Text.Trim()) Or String.IsNullOrEmpty(txtLastName.Text.Trim()) Then
            MessageBox.Show("Please input first name and last name", "Insert data ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Exit Sub
        End If

        sql = "INSERT INTO vb_employee(first_name, last_name, gender) VALUES(@FirstName, @LastName, @Gender)"
        Execute(sql, "Insert")

        MessageBox.Show("The record has been saved", "Insert data ", MessageBoxButtons.OK, MessageBoxIcon.Information)

        LoadData()
        ResetMe()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try
            Dim dgv As DataGridView = DataGridView1

            If e.RowIndex <> -1 Then

                Me.ID = Convert.ToString(dgv.CurrentRow.Cells(0).Value).Trim()
                btnUpdate.Text = "Update (" & Me.ID & ")"
                btnDelete.Text = "Delete  (" & Me.ID & ")"

                txtFirstName.Text = Convert.ToString(dgv.CurrentRow.Cells(1).Value).Trim()
                txtLastName.Text = Convert.ToString(dgv.CurrentRow.Cells(2).Value).Trim()

                txtGender.Text = Convert.ToString(dgv.CurrentRow.Cells(4).Value).Trim()


            End If


        Catch ex As Exception
            MsgBox("An error pccurred: " & ex.Message, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Click error")
        End Try


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If DataGridView1.Rows.Count = 0 Then
            Exit Sub
        End If

        If String.IsNullOrEmpty(Me.ID) Then
            MessageBox.Show("Please select item on list", "Update data ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Exit Sub
        End If

        If String.IsNullOrEmpty(txtFirstName.Text.Trim()) Or String.IsNullOrEmpty(txtLastName.Text.Trim()) Then
            MessageBox.Show("Please input first name and last name", "Update data ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Exit Sub
        End If

        sql = "UPDATE vb_employee SET first_name = @FirstName, last_name = @LastName, gender = @Gender WHERE auto_id = @ID::integer"
        Execute(sql, "Update")

        MessageBox.Show("The record has been update", "Update data ", MessageBoxButtons.OK, MessageBoxIcon.Information)

        LoadData()
        ResetMe()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If DataGridView1.Rows.Count = 0 Then
            Exit Sub
        End If

        If String.IsNullOrEmpty(Me.ID) Then
            MessageBox.Show("Please select item on list", "Delete data ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Exit Sub
        End If

        If String.IsNullOrEmpty(txtFirstName.Text.Trim()) Or String.IsNullOrEmpty(txtLastName.Text.Trim()) Then
            MessageBox.Show("Please input first name and last name", "Delete data ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Exit Sub
        End If

        If MessageBox.Show("Do you want to permanently delete the slected record?", "Dete data",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then

            sql = "DELETE FROM vb_employee WHERE auto_id = @ID::integer"
            Execute(sql, "Delete")

            MessageBox.Show("The record has been delete", "Delete data ", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadData()
            ResetMe()

        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Try
            If Not String.IsNullOrEmpty(txtSearch.Text.Trim()) Then
                LoadData(Me.txtSearch.Text.Trim())
            Else
                MsgBox("Search not found")
                LoadData()
            End If

            ResetMe()

        Catch ex As Exception
            MsgBox("An error pccurred: " & ex.Message, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Search error")
        End Try

    End Sub


End Class
