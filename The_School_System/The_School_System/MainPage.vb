Public Class MainPage
    Sub ShowForm(ChildForm As Form)
        If Not (IsNothing(Me.MdiChildren)) Then
            For Each openForm As Form In Me.MdiChildren
                openForm.Close()
            Next
        End If
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub StudentInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentInformationToolStripMenuItem.Click
        Dim myform As New Student
        ShowForm(myform)
    End Sub

    Private Sub SalaryDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalaryDetailsToolStripMenuItem.Click
        Dim myForm As New Salary
        ShowForm(myForm)
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim myForm As New Fees
        ShowForm(myForm)
    End Sub

    Private Sub EmployeeInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeInformationToolStripMenuItem.Click
        Dim myForm As New Employee_Information2
        ShowForm(myForm)
    End Sub

    Private Sub CourseDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CourseDetailsToolStripMenuItem.Click
        Dim myForm As New Course
        ShowForm(myForm)
    End Sub

    Private Sub AboutDeveloperrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutDeveloperrToolStripMenuItem.Click
        Dim myForm As New Developer
        ShowForm(myForm)
    End Sub

End Class
