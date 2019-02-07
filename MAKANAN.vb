Imports System.Data.SqlClient


Public Class MAKANAN

    Dim connectionString As String = "server=DESKTOP-FPLP4BF; " & "database=HOTEL; " & "integrated security=true"
    Dim conn As SqlConnection
    Dim comm As SqlCommand
    Dim comm2 As SqlCommand
    Dim reader As SqlDataReader
    Dim affectedrows As Integer
    Dim affectedrows2 As Integer

    Private Sub MAKANAN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        comm2.CommandText = "Select count(*) from makanan where id_makanan = '" + tb_idmakanan.Text + "'"
        affectedrows = comm2.ExecuteScalar()
        If (affectedrows <> 0) Then
            comm.CommandText = "UPDATE makanan SET id_makanan = " & "'" & tb_idmakanan.Text & "'" & ", menu_makanan = '" & tb_menu.Text & "'" & ", harga_makanan = '" & tb_harga.Text & "'" & " where id_makanan = '" & tb_idmakanan.Text & "'"
            comm.ExecuteNonQuery()
            MessageBox.Show("Data telah diupdate")
            LoadTabel()
        Else
            comm.CommandText = "INSERT INTO makanan VALUES ('" & tb_idmakanan.Text & "'" & ",'" & tb_menu.Text & "'" & ",'" & tb_harga.Text & "'" & ")"
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
        comm.CommandText = "Select * from makanan"
        tampildata.SelectCommand = comm
        datatabel.Tables.Clear()
        tampildata.Fill(datatabel, "makanan")
        tabel_makanan.DataSource = datatabel.Tables("makanan")
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

        comm2.CommandText = "Select count(*) from makanan where id_makanan = '" + tb_idmakanan.Text + "'"
        affectedrows = comm2.ExecuteScalar()
        If (affectedrows <> 0) Then
            Dim pesan_user As String
            pesan_user = MsgBox("Yakin Hapus Data ?",
                       MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Hapus Data")
            If (pesan_user = vbYes) Then
                comm.CommandText = "DELETE FROM makanan where id_makanan = " & "'" & tb_idmakanan.Text & "'"
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
        comm2.CommandText = "Select count(*) from makanan where ID_makanan = '" + tb_idmakanan.Text + "'"
        affectedrows = comm2.ExecuteScalar()
        If (affectedrows <> 0) Then
            MessageBox.Show("Data Ada")
            comm.CommandText = "Select * from makanan where ID_makanan = '" + tb_idmakanan.Text + "'"
            reader = comm.ExecuteReader
            While reader.Read
                tb_menu.Text = reader(1).ToString
                tb_harga.Text = reader(2).ToString



            End While
        Else
            MessageBox.Show("Data Tidak Ada")
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        UTAMA.Show()
    End Sub

    Private Sub atur_ulang_Click(sender As Object, e As EventArgs) Handles atur_ulang.Click
        tb_idmakanan.Text = " "
        tb_menu.Text = " "
        tb_harga.Text = " "
      
    End Sub
End Class