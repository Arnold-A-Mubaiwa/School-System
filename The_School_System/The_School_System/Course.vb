Imports System.Data.OleDb
Public Class Course
    Dim source As String
    Dim myConnect As OleDbConnection = New OleDbConnection
    Sub ConnectionStrings()
        source = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\StudentReport.accdb"
        myConnect.ConnectionString = source
        myConnect.Open()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ConnectionStrings()

        Dim STR As String
        STR = "Insert into Courses([CourseTitle],[CourseName],[CourseCode],[CourseFee],[CourseDuration]) Values(?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(STR, myConnect)

        cmd.Parameters.Add(New OleDbParameter("CourseTitle", CType(txtCourseTitle.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("CourseName", CType(txtCourseName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("CourseCode", CType(txtCourseCode.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("CourseFee", CType(txtCourseFee.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("CourseDuration", CType(txtCourseDuration.Text, String)))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myConnect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            myConnect.Close()
        End Try
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ConnectionStrings()
        Dim STR As String
        STR = "Update [Courses] set [CourseTitle] ='" & txtCourseTitle.Text & "',[CourseName] ='" & txtCourseName.Text & "',[CourseCode] ='" & txtCourseCode.Text & "',[CourseFee] ='" & txtCourseFee.Text & "',[CourseDuration] ='" & txtCourseDuration.Text & "'Where [CourseID]=" & txtCourseID.Text & ""
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
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ConnectionStrings()
        Dim STR As String
        STR = "Delete from Courses Where [CourseID] =" & txtCourseID.Text

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
        txtCourseCode.Clear()
        txtCourseDuration.Clear()
        txtCourseFee.Clear()
        txtCourseID.Clear()
        txtCourseName.Clear()
        txtCourseTitle.Clear()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        ConnectionStrings()

        Dim str As String = "Select * from Courses where CourseID like '%" & txtCourseID.Text & "%'"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myConnect)
        Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
        Dim searchs As Boolean = False
        While dr.Read
            searchs = True
            txtCourseCode.Text = dr("CourseCode").ToString
            txtCourseDuration.Text = dr("CourseDuration").ToString
            txtCourseName.Text = dr("CourseName").ToString
            txtCourseTitle.Text = dr("CourseTitle").ToString
            txtCourseFee.Text = dr("CourseFee").ToString

        End While
        Try
            myConnect.Close()
        Catch ex As Exception
            myConnect.Close()
        End Try

    End Sub
End Class