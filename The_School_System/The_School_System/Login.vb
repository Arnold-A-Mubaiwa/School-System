Imports System.Data.OleDb
Imports System.Data
Public Class Login
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim UserName As String = txtUsername.Text
        Dim Password As String = txtPassword.Text
        Dim pass As String
        If txtPassword.Text = "" Or txtUsername.Text = "" Then
            MsgBox("Plz Fill All the info")
        Else
            Dim querry As String = "Select password From Login where Password= '" & Password & "';"
            Dim source As String =
            "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\StudentReport.accdb"
            Dim conn = New OleDbConnection(source)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MsgBox("Username does not exit")
            End Try
            If (Password = pass) Then

                MainPage.Show()
                If MainPage.Visible Then
                    Me.Hide()
                End If

            Else

                txtPassword.Clear()
                txtUsername.Clear()

            End If
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtPassword.Clear()
        txtUsername.Clear()

    End Sub
End Class