Imports System.Data.OleDb
Imports System.Data
Public Class Fees
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
   
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ConnectionStrings()

        Dim STR As String
        STR = "Insert into Fees([StudentID],[PaymentType],[FeeDate],[FeesMonth],[FeesYear],[FeesAmount]) Values(?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(STR, myConnect)

        cmd.Parameters.Add(New OleDbParameter("StudendID", CType(txtStudentID.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("PaymentType", CType(cmbPaymentType.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("FeeDate", CType(cmbFeeDate.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("FeeMonth", CType(cmbFeeMonth.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("FeesYear", CType(cmbFeeYear.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("FeesAmount", CType(txtFeesID.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnect.Close()
        Catch ex As Exception
            myConnect.Close()
        End Try
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        ConnectionStrings()

        Dim STRi As String
        STRi = "Update [Fees] set [StudentID] ='" & txtStudentID.Text & "',[PaymentType]='" & cmbPaymentType.Text & "',[FeeDate] ='" & cmbFeeDate.Text & "',[FeesMonth] ='" & cmbFeeMonth.Text & "',[FeesYear] = '" & cmbFeeYear.Text & "'Where [FeesID]=" & txtFeesID.Text & ""

        Dim CMD As OleDbCommand = New OleDbCommand(STRi, myConnect)
        Try
            CMD.ExecuteNonQuery()
            CMD.Dispose()
            myConnect.Close()
        Catch ex As Exception
            myConnect.Close()
        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ConnectionStrings()

        Dim STR As String
        STR = "Delete from [Fees] Where [FeesID] =" & txtFeesID.Text & ""

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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFeeAmount.Clear()
        txtFeesID.Clear()
        txtStudentID.Clear()
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        ConnectionStrings()

        Dim str As String = "Select * from Fees where FeesID like '%" & txtFeesID.Text & "%'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnect)
        Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
        Dim searchs As Boolean = False
        While dr.Read
            searchs = True
            txtStudentID.Text = dr("StudentID").ToString
            cmbPaymentType.Text = dr("PaymentType").ToString
            cmbFeeDate.Text = dr("FeeDate").ToString
            cmbFeeMonth.Text = dr("FeeMonth").ToString
            cmbFeeYear.Text = dr("FeesYear").ToString
            txtFeeAmount.Text = dr("FeeAmount").ToString
        End While
        Try
            myConnect.Close()
        Catch ex As Exception
            myConnect.Close()
        End Try
    End Sub
End Class