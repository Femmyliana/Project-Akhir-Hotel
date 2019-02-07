Imports System.Data.SqlClient

Public Class JENIS_KAMAR

    Dim connectionString As String = "server=DESKTOP-FPLP4BF; " & "database=HOTEL; " & "integrated security=true"
    Dim conn As SqlConnection
    Dim comm As SqlCommand
    Dim comm2 As SqlCommand
    Dim reader As SqlDataReader
    Dim affectedrows As Integer
    Dim affectedrows2 As Integer
    Dim jk As String
    Dim st As String

    Private Sub JENIS_KAMAR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If (affectedrows <> 0) Then
            comm2.CommandText = "Select count(*) from JENIS_kamar where id_JENIS_KAMAR = '" + tb_idjenis.Text + "'"
            affectedrows = comm2.ExecuteScalar()
            comm.CommandText = "UPDATE jenis_kamar SET id_JENIS_KAMAR = " & "'" & tb_idjenis.Text & "'" & ", NAMA_jeniS = '" & tb_namajenis.Text & "'" & ", UKURAN = '" & tb_ukuran.Text & "'"
            comm.ExecuteNonQuery()
            MessageBox.Show("Data telah diupdate")
            LoadTabel()
        Else
            comm.CommandText = "INSERT INTO JENIS_KAMAR VALUES ('" & tb_idjenis.Text & "'" & ",'" & tb_namajenis.Text & "'" & ",'" & tb_ukuran.Text & "'" & " )"
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
        comm.CommandText = "Select*from JENIS_KAMAR"
        tampildata.SelectCommand = comm
        datatabel.Tables.Clear()
        tampildata.Fill(datatabel, "JENIS_KAMAR")
        tabel_jeniskamar.DataSource = datatabel.Tables("JENIS_KAMAR")
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

        comm2.CommandText = "Select count(*) from jenis_kamar where id_jenis_kamar = '" + tb_idjenis.Text + "'"
        affectedrows = comm2.ExecuteScalar()
        If (affectedrows <> 0) Then
            Dim pesan_user As String
            pesan_user = MsgBox("Yakin Hapus Data ?",
                       MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Hapus Data")
            If (pesan_user = vbYes) Then
                comm.CommandText = "DELETE FROM JENIS_KAMAR where id_jenis_kamar = " & "'" & tb_idjenis.Text & "'"
                comm.ExecuteNonQuery()
                LoadTabel()
                MessageBox.Show("Data telah dihapus")
                'ClearForm()
            End If
        End If
    End Sub

    Private Sub atur_ulang_Click(sender As Object, e As EventArgs) Handles atur_ulang.Click
        tb_idjenis.Text = " "
        tb_namajenis.Text = " "
        tb_ukuran.Text = " "
      
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
        comm2.CommandText = "Select count(*) from jenis_kamar where id_jenis_kamar = '" + tb_idjenis.Text + "'"
        affectedrows = comm2.ExecuteScalar()
        If (affectedrows <> 0) Then
            MessageBox.Show("Data Ada")
            comm.CommandText = "Select * from jenis_kamar where id_jenis_kamar = '" + tb_idjenis.Text + "'"
            reader = comm.ExecuteReader
            While reader.Read
                tb_namajenis.Text = reader(1).ToString
                tb_ukuran.Text = reader(2).ToString


            End While
        Else
            MessageBox.Show("Data Tidak Ada")
        End If
    End Sub
End Class