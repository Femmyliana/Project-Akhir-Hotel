Imports System.Data.SqlClient

Public Class PEMBAYARAN
    Dim connectionString As String = "server=DESKTOP-FPLP4BF; " & "database=HOTEL; " & "integrated security=true"
    Dim conn As SqlConnection
    Dim comm As SqlCommand
    Dim comm2 As SqlCommand
    Dim reader As SqlDataReader
    Dim affectedrows As Integer
    Dim affectedrows2 As Integer
    Dim jk As String
    Dim st As String

    Private Sub PEMBAYARAN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        comm2 = New SqlCommand()
        comm.Connection = conn
        comm2.Connection = conn
        comm.CommandType = CommandType.Text
        comm2.CommandType = CommandType.Text
        comm2.CommandText = "Select count(*) from pembayaran where id_pembayaran = '" + tb_idpembayaran.Text + "'"
        affectedrows = comm2.ExecuteScalar()
        If (affectedrows <> 0) Then
            comm.CommandText = "UPDATE pembayaran SET id_pegawai = " & "'" & tb_idpeg.Text & "'" & ", tanggal_pembayaran= '" & tgl_pembayaran.Text & "'" & ", id_pelanggan = '" & tb_idpelanggan.Text & "'" & ", id_pesan_kamar = '" & tb_idpesankamar.Text & "'" & ", id_pesan_makanan = '" & tb_idpesanmakanan.Text & "'" & ", id_pesan_minuman = '" & tb_idpesanminuman.Text & "'" & ", total_keseluruhan = '" & total.Text & "'" & " where id_pembayaran = '" & tb_idpembayaran.Text & "'"
            comm.ExecuteNonQuery()
            MessageBox.Show("Data telah diupdate")
            LoadTabel()
        Else
            comm.CommandText = "INSERT INTO pembayaran VALUES ('" & tb_idpembayaran.Text & "'" & ",'" & tb_idpeg.Text & "'" & ",'" & tgl_pembayaran.Text & "'" & ",'" & tb_idpelanggan.Text & "'" & ",'" & tb_idpesankamar.Text & "'" & ",'" & tb_idpesanmakanan.Text & ",'" & tb_idpesanminuman.Text & "'" & ",'" & total.Text & "'" & ")"
            comm.ExecuteNonQuery()
            MessageBox.Show("Data telah ditambahkan")
            LoadTabel()
        End If
    End Sub
    Public Sub LoadTabel()
        Dim tampildata As New SqlDataAdapter
        Dim datatabel As New DataSet
        conn = New SqlConnection(connectionString)
        conn.Open()
        comm = New SqlCommand()
        comm.Connection = conn
        comm.CommandType = CommandType.Text
        comm.CommandText = "Select * from pembayaran"
        tampildata.SelectCommand = comm
        datatabel.Tables.Clear()
        tampildata.Fill(datatabel, "pembayaran")
        tabel_pemesanan_kamar.DataSource = datatabel.Tables("pembayaran")
    End Sub

    Private Sub bt_kembali_Click(sender As Object, e As EventArgs) Handles bt_kembali.Click
        Me.Hide()
        UTAMA.Show()
    End Sub

    Private Sub bt_hapus_Click(sender As Object, e As EventArgs) Handles bt_hapus.Click
        conn = New SqlConnection(connectionString)
        conn.Open()
        comm = New SqlCommand()
        comm2 = New SqlCommand()
        comm.Connection = conn
        comm2.Connection = conn
        comm.CommandType = CommandType.Text
        comm2.CommandType = CommandType.Text

        comm2.CommandText = "Select count(*) from pembayaran where id_pembayaran = '" + tb_idpembayaran.Text + "'"
        affectedrows = comm2.ExecuteScalar()
        If (affectedrows <> 0) Then
            Dim pesan_user As String
            pesan_user = MsgBox("Yakin Hapus Data ?",
                       MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Hapus Data")
            If (pesan_user = vbYes) Then
                comm.CommandText = "DELETE FROM pembayaran where id_pembayaran = " & "'" & tb_idpembayaran.Text & "'"
                comm.ExecuteNonQuery()
                LoadTabel()
                MessageBox.Show("Data telah dihapus")
                'ClearForm()
            End If
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
        comm2.CommandText = "Select count(*) from pembayaran where ID_pembayaran = '" + tb_idpembayaran.Text + "'"
        affectedrows = comm2.ExecuteScalar()
        If (affectedrows <> 0) Then
            MessageBox.Show("Data Ada")
            comm.CommandText = "Select * from pembayaran where ID_pembayaran = '" + tb_idpembayaran.Text + "'"
            reader = comm.ExecuteReader
            While reader.Read
                tb_idpeg.Text = reader(1).ToString
                tgl_pembayaran.Text = reader(2).ToString
                tb_idpelanggan.Text = reader(3).ToString
                tb_idpesankamar.Text = reader(4).ToString
                tb_idpesanmakanan.Text = reader(5).ToString
                tb_idpesanminuman.Text = reader(6).ToString
                total.Text = "Rp" & " " & reader(7).ToString


            End While
        Else
            MessageBox.Show("Data Tidak Ada")
        End If
    End Sub

    Private Sub atur_ulang_Click(sender As Object, e As EventArgs) Handles atur_ulang.Click
        tb_idpembayaran.Text = " "
        tb_idpeg.Text = " "
        tb_idpelanggan.Text = " "
        tb_idpesankamar.Text = " "
        tb_idpesanmakanan.Text = " "
        tb_idpesanminuman.Text = " "
        total.Text = " "
    End Sub
End Class