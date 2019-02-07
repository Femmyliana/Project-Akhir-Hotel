Imports System.Data.SqlClient

Public Class PELANGGAN
    Dim connectionString As String = "server=DESKTOP-FPLP4BF; " & "database=HOTEL; " & "integrated security=true"
    Dim conn As SqlConnection
    Dim comm As SqlCommand
    Dim comm2 As SqlCommand
    Dim reader As SqlDataReader
    Dim affectedrows As Integer
    Dim affectedrows2 As Integer
    Dim jk As String
    Dim st As String

    Private Sub PELANGGAN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        comm2.CommandText = "Select count(*) from PELANGGAN where ID_PELANGGAN = '" + tb_idpel.Text + "'"
        affectedrows = comm2.ExecuteScalar()

        If (affectedrows <> 0) Then
            If (rb_perem.Checked) Then
                jk = "PEREMPUAN"
            Else
                jk = "LAKI-LAKI"
            End If

            comm.CommandText = "UPDATE PELANGGAN SET NAMA_DEPAN_PELANGGAN = " & "'" & tb_namadep.Text & "'" & ",NAMA_BELAKANG_PELANGGAN = '" & tb_namabel.Text & "'" & ", JENIS_KELAMIN = '" & jk & "'" & ", TEMPAT_LAHIR = '" & tb_tempatlhr.Text & "'" & ", TANGGAL_LAHIR = '" & tb_tgllhr.Text & "'" & ", KEBANGSAAN = '" & tb_kebangsaan.Text & "'" & ", NO_TELEPON = '" & tb_notel.Text & "'" & ", ALAMAT = '" & tb_alamat.Text & "'" & " where id_pelanggan = '" & tb_idpel.Text & "'"
            comm.ExecuteNonQuery()
            MessageBox.Show("Data telah diupdate")
            LoadTabel()
        Else
            If (rb_perem.Checked) Then
                jk = "PEREMPUAN"
            Else
                jk = "LAKI-LAKI"
            End If

            comm.CommandText = "INSERT INTO PELANGGAN VALUES ('" & tb_idpel.Text & "'" & ",'" & tb_namadep.Text & "'" & ",'" & tb_namabel.Text & "'" & ",'" & jk & "'" & ",'" & tb_tempatlhr.Text & "'" & ",'" & tb_tgllhr.Text & "'" & " ,'" & tb_kebangsaan.Text & "'" & " ,'" & tb_notel.Text & "'" & " ,'" & tb_alamat.Text & "'" & ")"
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
        comm.CommandText = "Select*from PELANGGAN"
        tampildata.SelectCommand = comm
        datatabel.Tables.Clear()
        tampildata.Fill(datatabel, "PELANGGAN")
        tabel_pelanggan.DataSource = datatabel.Tables("PELANGGAN")
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

        comm2.CommandText = "Select count(*) from PELANGGAN where ID_PELANGGAN = '" + tb_idpel.Text + "'"
        affectedrows = comm2.ExecuteScalar()
        If (affectedrows <> 0) Then
            Dim pesan_user As String
            pesan_user = MsgBox("Yakin Hapus Data ?",
                       MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Hapus Data")
            If (pesan_user = vbYes) Then
                comm.CommandText = "DELETE FROM PELANGGAN where ID_PELANGGAN = " & "'" & tb_idpel.Text & "'"
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
        comm2.CommandText = "Select count(*) from PELANGGAN where ID_PELANGGAN = '" + tb_idpel.Text + "'"
        affectedrows = comm2.ExecuteScalar()
        If (affectedrows <> 0) Then
            MessageBox.Show("Data Ada")
            comm.CommandText = "Select * from PELANGGAN where ID_PELANGGAN = '" + tb_idpel.Text + "'"
            reader = comm.ExecuteReader
            While reader.Read
                tb_namadep.Text = reader(1).ToString
                tb_namabel.Text = reader(2).ToString
                If (reader(3).ToString = "PEREMPUAN") Then
                    rb_perem.Select()
                Else
                    rb_laki.Select()
                End If
                tb_tempatlhr.Text = reader(4).ToString
                tb_tgllhr.Text = reader(5).ToString
                tb_kebangsaan.Text = reader(6).ToString
                tb_notel.Text = reader(7).ToString
                tb_alamat.Text = reader(8).ToString


            End While
        Else
            MessageBox.Show("Data Tidak Ada")
        End If

    End Sub

    Private Sub atur_ulang_Click(sender As Object, e As EventArgs) Handles atur_ulang.Click
        tb_idpel.Text = " "
        tb_namadep.Text = " "
        tb_namabel.Text = " "
        rb_perem.Checked = False
        rb_laki.Checked = False
        tb_tempatlhr.Text = " "
        tb_tgllhr.Checked = False
        tb_kebangsaan.Text = " "
        tb_notel.Text = " "
        tb_alamat.Text = " "
    End Sub

    Private Sub tabel_pegawai_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabel_pelanggan.CellContentClick

    End Sub

    Private Sub tb_notel_OnValueChanged(sender As Object, e As EventArgs) Handles tb_notel.OnValueChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub tb_kebangsaan_OnValueChanged(sender As Object, e As EventArgs) Handles tb_kebangsaan.OnValueChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub tb_tgllhr_ValueChanged(sender As Object, e As EventArgs) Handles tb_tgllhr.ValueChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub tb_tempatlhr_OnValueChanged(sender As Object, e As EventArgs) Handles tb_tempatlhr.OnValueChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub rb_laki_CheckedChanged(sender As Object, e As EventArgs) Handles rb_laki.CheckedChanged

    End Sub

    Private Sub rb_perem_CheckedChanged(sender As Object, e As EventArgs) Handles rb_perem.CheckedChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub tb_namabel_OnValueChanged(sender As Object, e As EventArgs) Handles tb_namabel.OnValueChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub tb_namadep_OnValueChanged(sender As Object, e As EventArgs) Handles tb_namadep.OnValueChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub nama_dep_Click(sender As Object, e As EventArgs) Handles nama_dep.Click

    End Sub

    Private Sub tb_idpel_OnValueChanged(sender As Object, e As EventArgs) Handles tb_idpel.OnValueChanged

    End Sub
End Class