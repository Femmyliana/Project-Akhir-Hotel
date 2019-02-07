Imports System.Data.SqlClient

Public Class EVENT_TAHUN_BARU
    Dim connectionString As String = "server=DESKTOP-FPLP4BF; " & "database=HOTEL; " & "integrated security=true"
    Dim conn As SqlConnection
    Dim comm As SqlCommand
    Dim comm2 As SqlCommand
    Dim reader As SqlDataReader
    Dim affectedrows As Integer
    Dim affectedrows2 As Integer
  
    Private Sub EVENT_TAHUN_BARU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            'MessageBox.Show("Koneksi dibuka.")
            '-----------------------------------------------------'
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
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

        Using comm As New SqlClient.SqlCommand("SELECT dbo.HARGAEVENT_TAHUN_BARU(@id_kamar,@min,@max)", conn)
            comm.Parameters.AddWithValue("@id_kamar", tb_idkamar.Text)
            comm.Parameters.AddWithValue("@min", tb_range_min.Text)
            comm.Parameters.AddWithValue("@max", tb_range_max.Text)
            reader = comm.ExecuteReader
            While reader.Read
                tb_harga.Text = reader(0).ToString
            End While
        End Using
        LoadTabel()

        comm.CommandText = "SELECT dbo.HARGAEVENT_TAHUN_BARU(@id_kamar,@min,@max"
        tampildata.SelectCommand = comm
        datatabel.Tables.Clear()
        tampildata.Fill(datatabel, "kamar")
        tabel_kamar.DataSource = datatabel.Tables("kamar")
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
        If (affectedrows <> 0) Then
            comm2.CommandText = "Select count(*) from kamar where id_kamar = '" + tb_idkamar.Text + "'"
            affectedrows = comm2.ExecuteScalar()
            comm.CommandText = "UPDATE kamar SET id_kamar = " & "'" & tb_idkamar.Text & "'" & ", id_jenis = '" & tb_idjenis.Text & "'" & ", harga = '" & tb_harga.Text & "'" & ", status = '" & cb_status.Text & " where id_kamar = '" & tb_idkamar.Text & "'"
            comm.ExecuteNonQuery()
            MessageBox.Show("Data telah diupdate")
            LoadTabel()
        Else
            comm.CommandText = "INSERT INTO KAMAR VALUES ('" & tb_idkamar.Text & "'" & ",'" & tb_idjenis.Text & "'" & ",'" & tb_harga.Text & "'" & ",'" & cb_status.Text & "'" & ")"
            comm.ExecuteNonQuery()
            MessageBox.Show("Data telah ditambahkan")
            LoadTabel()
        End If
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

        comm2.CommandText = "Select count(*) from kamar where id_kamar = '" + tb_idkamar.Text + "'"
        affectedrows = comm2.ExecuteScalar()
        If (affectedrows <> 0) Then
            Dim pesan_user As String
            pesan_user = MsgBox("Yakin Hapus Data ?",
                       MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Hapus Data")
            If (pesan_user = vbYes) Then
                comm.CommandText = "DELETE FROM KAMAR where id_kamar = " & "'" & tb_idkamar.Text & "'"
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
        comm2.CommandText = "Select count(*) from kamar where id_kamar = '" + tb_idkamar.Text + "'"
        affectedrows = comm2.ExecuteScalar()
        If (affectedrows <> 0) Then
            MessageBox.Show("Data Ada")
            comm.CommandText = "Select * from kamar where id_kamar = '" + tb_idkamar.Text + "'"
            reader = comm.ExecuteReader
            While reader.Read
                tb_idjenis.Text = reader(1).ToString
                tb_harga.Text = reader(2).ToString
                cb_status.Text = reader(3).ToString

            End While
        Else
            MessageBox.Show("Data Tidak Ada")
        End If
    End Sub


     
End Class