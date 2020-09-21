Imports System.Data.OleDb
Imports System.Data

Public Class Employee_Information2
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
        STR = "Insert into Employee([FirstName],[LastName],[DateOfBirth],[MobileNumber],[PhoneNumber],[EmailAddress],[PermanentAddress],[LocalAddress],[Salary]) Values(?,?,?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(STR, myConnect)

        cmd.Parameters.Add(New OleDbParameter("FirstName", CType(txtEmpFirstName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("LastName", CType(txtEmpLastName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("DateOfBirth", CType(dtpDOB.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MobileNumber", CType(txtMobNumber.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("PhoneNumber", CType(txtPNumber.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("EmailAddress", CType(txtEmailID.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("PermanentAddress", CType(rtxtPermanentAddress.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("LocalAddress", CType(rtxtLocalAddress.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Salary", CType(txtSalary.Text, String)))

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

        Dim STR As String
        STR = "Update [Employee] set [FirstName] ='" & txtEmpFirstName.Text & "',[LastName] ='" & txtEmpLastName.Text & "'[DateOfBirth] ='" & dtpDOB.Text & "'[MobileNumber] ='" & txtMobNumber.Text & "'[PhoneNumber] ='" & txtPNumber.Text & "'[EmailAddress]'" & txtEmailID.Text & "'[PermanentAddress] ='" & rtxtPermanentAddress.Text & "'[LocalAddress] ='" & rtxtPermanentAddress.Text & "'[Salary] ='" & txtSalary.Text & "' Where [EmployeeID] = " & txtEmployeeID.Text

        Dim CMD As OleDbCommand = New OleDbCommand(STR, myConnect)
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
        STR = "Delete from [Employee] Where [EmployeeID] =" & txtEmployeeID.Text & ""

        Dim CMD As OleDbCommand = New OleDbCommand(STR, myConnect)
        Try
            CMD.ExecuteNonQuery()
            CMD.Dispose()
            myConnect.Close()

        Catch ex As Exception
            myConnect.Close()
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEmailID.Clear()
        txtEmpDesig.Clear()
        txtEmpFirstName.Clear()
        txtEmployeeID.Clear()
        txtEmpLastName.Clear()
        txtEmpTitle.Clear()
        txtEmpType.Clear()
        txtMobNumber.Clear()
        txtPNumber.Clear()
        txtSalary.Clear()

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        ConnectionStrings()

        Dim str As String = "Select * from Employee where EmployeeID like '%" & txtEmployeeID.Text & "%'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnect)
        Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
        Dim searchs As Boolean = False
        While dr.Read
            searchs = True
            txtEmpFirstName.Text = dr("FirstName").ToString
            txtEmpLastName.Text = dr("LastName").ToString
            dtpDOB.Text = dr("DateOfBirth").ToString
            txtMobNumber.Text = dr("MobileNumber").ToString
            txtPNumber.Text = dr("PhoneNumber").ToString
            txtEmailID.Text = dr("EmailAddress").ToString
            rtxtPermanentAddress.Text = dr("PermanentAddress").ToString
            rtxtLocalAddress.Text = dr("LocalAddress").ToString
            txtSalary.Text = dr("Salary").ToString

        End While
        Try
            myConnect.Close()

        Catch ex As Exception
            myConnect.Close()

        End Try

    End Sub
End Class