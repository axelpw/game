Public Class Form2

    Dim menit As Integer, detik As Integer, ms As Integer, ur As Integer = 0
    'timer countdown
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ms -= 1
        If ms < 0 Then
            detik -= 1
            If detik < 0 Then
                detik = 30
            End If

        End If
        labtime.Text = Format(menit, "00") & ":" & Format(detik, "00")
        If detik = 0 Then
            Timer1.Enabled = False
            Me.Hide()
            Form4.Show()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form4.Show()
    End Sub
    'waktu sesuai jam real
    Private Sub Form3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        labcutime.Text = CStr(TimeOfDay)
        DataGridView1.DataSource = Koneksi.tampil("SELECT * FROM Liga Jerman")
        DataGridView1.Hide()
        menit = 5
        detik = 0
        ms = 10
        labtime.Text = "05.00"
        Timer1.Enabled = True
        ur = 0
    End Sub
End Class