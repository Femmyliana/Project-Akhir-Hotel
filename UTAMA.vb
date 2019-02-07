Imports System.Data.SqlClient


Public Class UTAMA
    Dim connectionString As String = "server=DESKTOP-FPLP4BF; " & "database=HOTEL; " & "integrated security=true"
    Dim conn As SqlConnection
    Dim comm As SqlCommand
    Dim comm2 As SqlCommand
    Dim reader As SqlDataReader
    Dim affectedrows As Integer
    Dim affectedrows2 As Integer
    Dim jk As String
    Dim st As String

    Private Sub UTAMA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub kamar_Click(sender As Object, e As EventArgs) Handles kamar.Click
        Me.Hide()
        Dim kamar As New KAMAR
        kamar.Show()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Public Sub tutup_Click(sender As Object, e As EventArgs) Handles tutup.Click, tutup.Click
        Me.Close()
    End Sub

    Private Sub makanan_Click(sender As Object, e As EventArgs) Handles makanan.Click
        Me.Hide()
        Dim makanan As New MAKANAN
        makanan.Show()
    End Sub

    Private Sub pegawai_Click(sender As Object, e As EventArgs) Handles pegawai.Click

    End Sub
End Class
