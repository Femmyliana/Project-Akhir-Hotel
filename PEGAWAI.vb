Imports System.Data.SqlClient


Public Class PEGAWAI

    Dim connectionString As String = "server=DESKTOP-FPLP4BF; " & "database=HOTEL; " & "integrated security=true"
    Dim conn As SqlConnection
    Dim comm As SqlCommand
    Dim comm2 As SqlCommand
    Dim reader As SqlDataReader
    Dim affectedrows As Integer
    Dim affectedrows2 As Integer
    Dim jk As String
    Dim st As String

    Private Sub PEGAWAI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        comm2.CommandText = "Select count(*) from PEGAWAI where ID_PEGAWAI = '" + tb_idpeg.Text + "'"
        affectedrows = comm2.ExecuteScalar()

        If (affectedrows <> 0) Then
            If (rb_perem.Checked) Then
                jk = "PEREMPUAN"
            Else
                jk = "LAKI-LAKI"
            End If

            comm.CommandText = "UPDATE PEGAWAI SET NAMA_DEPAN_PEGAWAI = " & "'" & tb_namadep.Text & "'" & ",NAMA_BELAKANG_PEGAWAI = '" & tb_namabel.Text & "'" & ", JENIS_KELAMIN = '" & jk & "'" & ", UMUR = '" & tb_umur.Text & "'" & ", ALAMAT = '" & tb_alamat.Text & "'" & " where id_pegawai = '" & tb_idpeg.Text & "'"
            comm.ExecuteNonQuery()
            MessageBox.Show("Data telah diupdate")
            LoadTabel()
        Else
            If (rb_perem.Checked) Then
                jk = "PEREMPUAN"
            Else
                jk = "LAKI-LAKI"
            End If

            comm.CommandText = "INSERT INTO PEGAWAI VALUES ('" & tb_idpeg.Text & "'" & ",'" & tb_namadep.Text & "'" & ",'" & tb_namabel.Text & "'" & ",'" & jk & "'" & ",'" & tb_umur.Text & "'" & ",'" & tb_alamat.Text & "'" & ")"
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
        comm.CommandText = "Select*from PEGAWAI"
        tampildata.SelectCommand = comm
        datatabel.Tables.Clear()
        tampildata.Fill(datatabel, "PEGAWAI")
        tabel_pegawai.DataSource = datatabel.Tables("PEGAWAI")
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

        comm2.CommandText = "Select count(*) from PEGAWAI where ID_PEGAWAI = '" + tb_idpeg.Text + "'"
        affectedrows = comm2.ExecuteScalar()
        If (affectedrows <> 0) Then
            Dim pesan_user As String
            pesan_user = MsgBox("Yakin Hapus Data ?",
                       MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Hapus Data")
            If (pesan_user = vbYes) Then
                comm.CommandText = "DELETE FROM PEGAWAI where ID_PEGAWAI = " & "'" & tb_idpeg.Text & "'"
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
        comm2.CommandText = "Select count(*) from PEGAWAI where ID_PEGAWAI = '" + tb_idpeg.Text + "'"
        affectedrows = comm2.ExecuteScalar()
        If (affectedrows <> 0) Then
            MessageBox.Show("Data Ada")
            comm.CommandText = "Select * from PEGAWAI where ID_PEGAWAI = '" + tb_idpeg.Text + "'"
            reader = comm.ExecuteReader
            While reader.Read
                tb_namadep.Text = reader(1).ToString
                tb_namabel.Text = reader(2).ToString
                If (reader(3).ToString = "PEREMPUAN") Then
                    rb_perem.Select()
                Else
                    rb_laki.Select()
                End If
                tb_umur.Text = reader(4).ToString
                tb_alamat.Text = reader(5).ToString


            End While
        Else
            MessageBox.Show("Data Tidak Ada")
        End If
    End Sub

    Private Sub atur_ulang_Click(sender As Object, e As EventArgs) Handles atur_ulang.Click
        tb_idpeg.Text = " "
        tb_namadep.Text = " "
        tb_namabel.Text = " "
            rb_perem.Checked = False
            rb_laki.Checked = False
        tb_umur.Text = " "
        tb_alamat.Text = " "

    End Sub
End Class