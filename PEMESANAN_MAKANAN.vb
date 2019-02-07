Imports System.Data.SqlClient

Public Class PEMESANAN_MAKANAN

    Dim connectionString As String = "server=DESKTOP-FPLP4BF; " & "database=HOTEL; " & "integrated security=true"
    Dim conn As SqlConnection
    Dim comm As SqlCommand
    Dim comm2 As SqlCommand
    Dim reader As SqlDataReader
    Dim affectedrows As Integer
    Dim affectedrows2 As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection(connectionString)
        Try
            conn.Open()
            'MessageBox.Show("Koneksi dibuka.")
            '-----------------------------------------------------'
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        LoadTabel()

    End Sub

    Private Sub bt_simpan_Click(sender As Object, e As EventArgs) Handles bt_simpan.Click
        conn = New SqlConnection(connectionString)
        conn.Open()
        comm = New SqlCommand()
        comm.Connection = conn
        comm.CommandText = "dbo.INSERT_DATA"
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@id_pesan_makanan", tb_pesan_makanan.Text)
        comm.Parameters.AddWithValue("@id_pelanggan", tb_idpelanggan.Text)
        comm.Parameters.AddWithValue("@id_kamar", tb_idkamar.Text)
        comm.Parameters.AddWithValue("@id_makanan", tb_idmakanan.Text)
        comm.Parameters.AddWithValue("@jum_pesan", tb_jumlah_pesan.Text)
      
        comm.Parameters.AddWithValue("@total_bayar", lb_totalbayar.Text)
        comm.ExecuteNonQuery()
        MessageBox.Show("Data telah ditambahkan")
        LoadTabel()
    End Sub

    Public Sub LoadTabel()
        Dim tampildata As New SqlDataAdapter
        Dim datatabel As New DataSet
        conn = New SqlConnection(connectionString)
        conn.Open()
        comm = New SqlCommand()
        comm.Connection = conn
        comm.CommandType = CommandType.Text
        comm.CommandText = "Select * from PEMESANAN_MAKANAN"
        tampildata.SelectCommand = comm
        datatabel.Tables.Clear()
        tampildata.Fill(datatabel, "PEMESANAN_MAKANAN")
        tabel_makanan.DataSource = datatabel.Tables("PEMESANAN_MAKANAN")
    End Sub

    Private Sub bt_perbarui_Click(sender As Object, e As EventArgs) Handles bt_perbarui.Click
        conn = New SqlConnection(connectionString)
        conn.Open()
        comm = New SqlCommand()
        comm.Connection = conn
        comm.CommandText = "dbo.UPDATE_DATA"
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@id_pesan_makanan", tb_pesan_makanan.Text)
        comm.Parameters.AddWithValue("@id_pelanggan", tb_idpelanggan.Text)
        comm.Parameters.AddWithValue("@id_kamar", tb_idkamar.Text)
        comm.Parameters.AddWithValue("@id_makanan", tb_idmakanan.Text)
        comm.Parameters.AddWithValue("@jum_pesan", tb_jumlah_pesan.Text)
        comm.Parameters.AddWithValue("@total_bayar", lb_totalbayar.Text)

        comm.ExecuteNonQuery()
        MessageBox.Show("Data telah diupdate")
        LoadTabel()

    End Sub

    
    Private Sub bt_hapus_Click(sender As Object, e As EventArgs) Handles bt_hapus.Click
        conn = New SqlConnection(connectionString)
        conn.Open()
        comm = New SqlCommand()
        Dim pesanuser As String
        pesanuser = MsgBox("Yakin Hapus Data ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Hapus Data")
        If (pesanuser = vbYes) Then
            comm.Connection = conn
            comm.CommandText = "dbo.DELETE_DATA"
            comm.CommandType = CommandType.StoredProcedure
            comm.Parameters.AddWithValue("@id_pesan_makanan", tb_pesan_makanan.Text)
            comm.ExecuteNonQuery()
            MessageBox.Show("Data telah dihapus")
            LoadTabel()
            'ClearForm()
        End If

    End Sub

    Private Sub bt_cari_Click(sender As Object, e As EventArgs) Handles bt_cari.Click
        conn = New SqlConnection(connectionString)
        conn.Open()
        comm = New SqlCommand()
        comm2 = New SqlCommand()
        comm.Connection = conn
        comm2.Connection = conn
        comm.CommandType = CommandType.Text
        comm2.CommandType = CommandType.Text
        comm2.CommandText = "Select count(*) from PEMESANAN_MAKANAN where id_pesan_makanan = '" + tb_pesan_makanan.Text + "'"
        affectedrows = comm2.ExecuteScalar()
        If (affectedrows <> 0) Then
            MessageBox.Show("Data Ada")
            comm.CommandText = "Select * from PEMESANAN_MAKANAN where id_pesan_makanan = '" + tb_pesan_makanan.Text + "'"
            reader = comm.ExecuteReader
            While reader.Read
                tb_idpelanggan.Text = reader(1).ToString
                tb_idkamar.Text = reader(2).ToString
                tb_idmakanan.Text = reader(3).ToString
                tb_jumlah_pesan.Text = reader(4).ToString
                lb_totalbayar.Text = "Rp" & " " & reader(5).ToString


            End While
        Else
            MessageBox.Show("Data Tidak Ada")
        End If
    End Sub

    Private Sub atur_ulang_Click(sender As Object, e As EventArgs) Handles atur_ulang.Click
        tb_pesan_makanan.Text = " "
        tb_idpelanggan.Text = " "
        tb_idkamar.Text = " "
        tb_idmakanan.Text = " "
        tb_jumlah_pesan.Text = " "
        lb_totalbayar.Text = " "

    End Sub

    Private Sub bt_hitung_Click(sender As Object, e As EventArgs) Handles bt_hitung.Click
        Using comm As New SqlClient.SqlCommand("SELECT dbo.TOTAL_BAYAR (@id_makanan)", conn)
            comm.Parameters.AddWithValue("@id_makanan", tb_idmakanan.Text)
            reader = comm.ExecuteReader
            While reader.Read
                lb_totalbayar.Text = reader(6).ToString
            End While
        End Using

    End Sub
End Class