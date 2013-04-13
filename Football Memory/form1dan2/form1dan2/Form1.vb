Public Class Form1
    

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim cur As New choose
        ProgressBar1.Value += 10
        If ProgressBar1.Value = 250 Then
            Timer1.Dispose()
            Me.Visible = False
            cur.Show()
        End If

    End Sub
End Class
