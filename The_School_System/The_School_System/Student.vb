Imports System.Data.OleDb
Public Class Student
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
        STR = "Insert into Student([FirstName],[MiddleName],[LastName],[DateOfBirth],[MothersName],[FathersName],[BloodGroup],[LocalAddress],[PermanentAddress],[Gender],[Category],[EmailID],[ContactNumber]) Values(?,?,?,?,?,?,?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(STR, myConnect)

        cmd.Parameters.Add(New OleDbParameter("FirstName", CType(txtFirstName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MiddleName", CType(txtMiddleName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("LastName", CType(txtLastName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("DateOfBirth", CType(dtpDOB.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("MothersName", CType(txtMotherName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("FathersName", CType(txtFatherName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("BloodGroup", CType(txtBloodGroup.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("LocalAddress", CType(rtxtPermanantAddress.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("PermanentAddress", CType(rtxtLocalAddress.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Gender", CType(cmbGender.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Category", CType(cmbCategory.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("EmailID", CType(txtEmailID.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("ContactNumber", CType(txtContactNumber.Text, String)))

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
        STR = "Update [Student] set [FirstName] ='" & txtFirstName.Text & "',[MiddleName] ='" & txtMiddleName.Text & "',[LastName] ='" & txtLastName.Text & "',[DateOfBirth] ='" & dtpDOB.Text & "',[MothersName] ='" & txtMotherName.Text & "',[FathersName] ='" & txtFatherName.Text & "',[BloodGroup] ='" & txtBloodGroup.Text & "',[LocalAddress] ='" & rtxtLocalAddress.Text & "',[PermanentAddress] ='" & rtxtPermanantAddress.Text & "',[Gender] ='" & cmbGender.Text & "',[Category] ='" & cmbCategory.Text & "',[EmailID] ='" & txtEmailID.Text & "',[ContactNumber] ='" & txtContactNumber.Text & "'Where [StudentID]=" & txtStudentID.Text & ""

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
        STR = "Delete from [Student] Where [StudentID] =" & txtStudentID.Text & ""

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
        txtBloodGroup.Clear()
        txtContactNumber.Clear()
        txtEmailID.Clear()
        txtFatherName.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtMiddleName.Clear()
        txtMotherName.Clear()
        txtStudentID.Clear()
        rtxtLocalAddress.Clear()
        rtxtPermanantAddress.Clear()

    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        ConnectionStrings()

        Dim str As String = "Select * from Student where StudentID like '%" & txtStudentID.Text & "%'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnect)
        Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
        Dim searchs As Boolean = False
        While dr.Read
            searchs = True
            txtFirstName.Text = dr("FirstName").ToString
            txtLastName.Text = dr("LastName").ToString
            dtpDOB.Text = dr("DateOfBirth").ToString
            txtMiddleName.Text = dr("MiddleName").ToString
            txtMotherName.Text = dr("MothersName").ToString
            txtFatherName.Text = dr("FathersName").ToString
            txtBloodGroup.Text = dr("BloodGroup").ToString
            rtxtLocalAddress.Text = dr("LocalAddress").ToString
            rtxtPermanantAddress.Text = dr("PermanentAddress").ToString
            txtEmailID.Text = dr("EmailID").ToString
            txtContactNumber.Text = dr("ContactNumber").ToString
            cmbCategory.Text = dr("Category").ToString
            cmbGender.Text = dr("Gender").ToString

        End While
        Try
            myConnect.Close()
        Catch ex As Exception
            myConnect.Close()
        End Try

    End Sub
End Class