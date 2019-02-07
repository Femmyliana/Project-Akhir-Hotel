Public Class LOGIN

  
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Me.Hide()
        Dim UTAMA As New UTAMA
        UTAMA.Show()
    End Sub

    Private Sub tutup_Click(sender As Object, e As EventArgs) Handles tutup.Click
        Me.Close()
    End Sub
End Class