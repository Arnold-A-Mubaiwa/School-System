Imports System.Data.OleDb
Imports System.Data
Public Class Salary
    Dim source As String
    Dim myConnect As OleDbConnection = New OleDbConnection
    Sub ConnectionStrings()
        source = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\StudentReport.accdb"
        myConnect.ConnectionString = source
        myConnect.Open()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ConnectionStrings()

        Dim STR As String
        STR = "Insert into Salary([EmploeeID],[Amount],[Months],[ISPAID],[DueAmount]) Values(?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(STR, myConnect)

        cmd.Parameters.Add(New OleDbParameter("EmploeeID", CType(cmbEmployeeID.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Amount", CType(txtAmount.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Months", CType(cmbMonth.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("ISPAID", CType(cmbIsPaid.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("DueAmount", CType(txtDueAmount.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnect.Close()
        Catch ex As Exception
            myConnect.Close()
        End Try
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ConnectionStrings()

        Dim STR As String
        STR = "Delete from [Salary] Where [SalaryID] =" & txtSalaryID.Text & ""

        Dim CMD As OleDbCommand = New OleDbCommand(STR, myConnect)
        Try
            CMD.ExecuteNonQuery()
            CMD.Dispose()
            myConnect.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            myConnect.Close()
        End Try
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ConnectionStrings()

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        Dim scon As String = "Select * from Salary where SalaryID like '%" & txtSalaryID.Text & "%'"
        da = New OleDbDataAdapter(scon, myConnect)

        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView

        Dim cmd As OleDbCommand = New OleDbCommand(scon, myConnect)
        Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
        Dim searchs As Boolean = False
        While dr.Read
            searchs = True
            txtSalaryID.Text = dr("SalaryID").ToString
            cmbEmployeeID.Text = dr("EmploeeID").ToString
            cmbIsPaid.Text = dr("ISPAID").ToString
            cmbMonth.Text = dr("Months").ToString
            txtAmount.Text = dr("Amount").ToString
            txtDueAmount.Text = dr("DueAmount").ToString
        End While
        Try
            myConnect.Close()
        Catch ex As Exception
            myConnect.Close()
        End Try
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ConnectionStrings()

        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        Dim scon As String = "Select * from Salary"
        da = New OleDbDataAdapter(scon, myConnect)

        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView
        myConnect.Close()

    End Sub
End Class