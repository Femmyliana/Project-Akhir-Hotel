Imports System.Data.SqlClient

Public Class PEMESANAN_KAMAR
    Dim connectionString As String = "server=DESKTOP-FPLP4BF; " & "database=HOTEL; " & "integrated security=true"
    Dim conn As SqlConnection
    Dim comm As SqlCommand
    Dim comm2 As SqlCommand
    Dim reader As SqlDataReader
    Dim affectedrows As Integer
    Dim affectedrows2 As Integer
    Dim jk As String
    Dim st As String

    Private Sub PEMESANAN_KAMAR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        comm.CommandText = "dbo.INSERT_DATA_PESANKAMAR"
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@id_pesan_kamar", tb_idpesan.Text)
        comm.Parameters.AddWithValue("@id_pelanggan", tb_idpel.Text)
        comm.Parameters.AddWithValue("@id_kamar", tb_idkamar.Text)
        comm.Parameters.AddWithValue("@id_jenis_kamar", tb_idjeniskamar.Text)
        comm.Parameters.AddWithValue("@cek_in", cek_in.Text)
        comm.Parameters.AddWithValue("@cek_out", cek_out.Text)
        comm.Parameters.AddWithValue("@total_bayar", total.Text)
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
        comm.CommandText = "Select * from pemesanan_kamar"
        tampildata.SelectCommand = comm
        datatabel.Tables.Clear()
        tampildata.Fill(datatabel, "pemesanan_kamar")
        tabel_pemesanan_kamar.DataSource = datatabel.Tables("pemesanan_kamar")
    End Sub


    Private Sub bt_kembali_Click(sender As Object, e As EventArgs) Handles bt_kembali.Click
        Me.Hide()
        UTAMA.Show()
    End Sub

    Private Sub bt_hapus_Click(sender As Object, e As EventArgs)
        conn = New SqlConnection(connectionString)
        conn.Open()
        comm = New SqlCommand()
        Dim pesanuser As String
        pesanuser = MsgBox("Yakin Hapus Data ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Hapus Data")
        If (pesanuser = vbYes) Then
            comm.Connection = conn
            comm.CommandText = "dbo.DELETE_DATA_PESANKAMAR"
            comm.CommandType = CommandType.StoredProcedure
            comm.Parameters.AddWithValue("@id_pesan_kamar", tb_idpesan.Text)
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
        comm2.CommandText = "Select count(*) from pemesanan_kamar where ID_pesan_kamar = '" + tb_idpesan.Text + "'"
        affectedrows = comm2.ExecuteScalar()
        If (affectedrows <> 0) Then
            MessageBox.Show("Data Ada")
            comm.CommandText = "Select * from pemesanan_kamar where ID_pesan_kamar = '" + tb_idpesan.Text + "'"
            reader = comm.ExecuteReader
            While reader.Read
                tb_idpel.Text = reader(1).ToString
                tb_idkamar.Text = reader(2).ToString
                tb_idjeniskamar.Text = reader(3).ToString
                cek_in.Text = reader(4).ToString
                cek_out.Text = reader(5).ToString
                total.Text = "Rp" & " " & reader(6).ToString


            End While
        Else
            MessageBox.Show("Data Tidak Ada")
        End If
    End Sub

    Private Sub atur_ulang_Click(sender As Object, e As EventArgs) Handles atur_ulang.Click
        tb_idpesan.Text = " "
        tb_idpel.Text = " "
        tb_idkamar.Text = " "
        tb_idjeniskamar.Text = " "
        total.Text = " "
       

    End Sub

    Private Sub bt_perbarui_Click(sender As Object, e As EventArgs) Handles bt_perbarui.Click
        conn = New SqlConnection(connectionString)
        conn.Open()
        comm = New SqlCommand()
        comm.Connection = conn
        comm.CommandText = "dbo.UPDATE_DATA_PESANKAMAR"
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.AddWithValue("@id_pesan_kamar", tb_idpesan.Text)
        comm.Parameters.AddWithValue("@id_pelanggan", tb_idpel.Text)
        comm.Parameters.AddWithValue("@id_kamar", tb_idkamar.Text)
        comm.Parameters.AddWithValue("@id_jenis_kamar", tb_idjeniskamar.Text)
        comm.Parameters.AddWithValue("@cek_in", cek_in.Text)
        comm.Parameters.AddWithValue("@cek_out", cek_out.Text)
        comm.Parameters.AddWithValue("@total_bayar", total.Text)

        comm.ExecuteNonQuery()
        MessageBox.Show("Data telah diupdate")
        LoadTabel()

    End Sub

    Private Sub bt_hitung_Click(sender As Object, e As EventArgs) Handles bt_hitung.Click
        Using comm As New SqlClient.SqlCommand("SELECT dbo.HARGA_PESANKAMAR(@id_kamar)", conn)
            comm.Parameters.AddWithValue("@id_kamar", total.Text)
            reader = comm.ExecuteReader
            While reader.Read
                total.Text = reader(0).ToString
            End While
        End Using

    End Sub

End Class