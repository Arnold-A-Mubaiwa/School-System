Public Class THE__LOADING_PAGE
    Private Sub THE__LOADING_PAGE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timeCount.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles timeCount.Tick
        prbLoad.Increment(5)
        If prbLoad.Value = 100 Then
            timeCount.Stop()
            Login.Show()
            If Login.Visible Then
                Me.Hide()
            End If
        End If
    End Sub
End Class