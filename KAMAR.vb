Imports System.Data.SqlClient

Public Class KAMAR
    Dim connectionString As String = "server=DESKTOP-FPLP4BF; " & "database=HOTEL; " & "integrated security=true"
    Dim conn As SqlConnection
    Dim comm As SqlCommand
    Dim comm2 As SqlCommand
    Dim reader As SqlDataReader
    Dim affectedrows As Integer
    Dim affectedrows2 As Integer
    Dim jk As String
    Dim st As String


    Private Sub KAMAR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Public Sub LoadTabel()
        Dim tampildata As New SqlDataAdapter
        Dim datatabel As New DataSet
        conn = New SqlConnection(connectionString)
        conn.Open()
        comm = New SqlCommand()
        comm.Connection = conn
        comm.CommandType = CommandType.Text
        comm.CommandText = "select K.ID_KAMAR,K.ID_JENIS,K.HARGA AS HARGA_NORMAL ,H.HARGA_EVENT,H.STATUS from dbo.HARGA_EVENT_TAHUNBARU ('',DEFAULT,3000000) H JOIN KAMAR K ON H.ID_KAMAR = K.ID_KAMAR "
        tampildata.SelectCommand = comm
        datatabel.Tables.Clear()
        tampildata.Fill(datatabel, "kamar")
        tabel_kamar.DataSource = datatabel.Tables("kamar")
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

   
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        UTAMA.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    
    Private Sub bt_event_Click(sender As Object, e As EventArgs) Handles bt_event.Click
        Using comm As New SqlClient.SqlCommand("SELECT dbo.HARGA_EVENT_TAHUNBARU", conn)
            comm.Parameters.AddWithValue("@id_kamar", tb_idkamar.Text)
            comm.Parameters.AddWithValue("@min", tb_range_min.Text)
            comm.Parameters.AddWithValue("@max", tb_range_max.Text)
            reader = comm.ExecuteReader
            While reader.Read
                tb_idjenis.Text = reader(2).ToString
                tb_idkamar.Text = reader(1).ToString
                tb_harga.Text = reader(3).ToString
            End While
        End Using

    End Sub

End Class



