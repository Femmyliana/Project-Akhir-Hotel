<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PEMBAYARAN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.atur_ulang = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.tabel_pemesanan_kamar = New System.Windows.Forms.DataGridView()
        Me.bt_kembali = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bt_hapus = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bt_simpan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tgl_pembayaran = New System.Windows.Forms.DateTimePicker()
        Me.tb_idpelanggan = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bt_cari = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.tb_idpesanmakanan = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tb_idpeg = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tb_idpembayaran = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.id_pesan_kamar = New System.Windows.Forms.Label()
        Me.tb_idpesankamar = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_idpesanminuman = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.tabel_pemesanan_kamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'atur_ulang
        '
        Me.atur_ulang.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.atur_ulang.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.atur_ulang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.atur_ulang.BorderRadius = 0
        Me.atur_ulang.ButtonText = "ATUR ULANG"
        Me.atur_ulang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.atur_ulang.DisabledColor = System.Drawing.Color.Gray
        Me.atur_ulang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.atur_ulang.Iconcolor = System.Drawing.Color.Transparent
        Me.atur_ulang.Iconimage = Nothing
        Me.atur_ulang.Iconimage_right = Nothing
        Me.atur_ulang.Iconimage_right_Selected = Nothing
        Me.atur_ulang.Iconimage_Selected = Nothing
        Me.atur_ulang.IconMarginLeft = 0
        Me.atur_ulang.IconMarginRight = 0
        Me.atur_ulang.IconRightVisible = True
        Me.atur_ulang.IconRightZoom = 0.0R
        Me.atur_ulang.IconVisible = True
        Me.atur_ulang.IconZoom = 90.0R
        Me.atur_ulang.IsTab = False
        Me.atur_ulang.Location = New System.Drawing.Point(673, 27)
        Me.atur_ulang.Name = "atur_ulang"
        Me.atur_ulang.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.atur_ulang.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.atur_ulang.OnHoverTextColor = System.Drawing.Color.White
        Me.atur_ulang.selected = False
        Me.atur_ulang.Size = New System.Drawing.Size(103, 24)
        Me.atur_ulang.TabIndex = 122
        Me.atur_ulang.Text = "ATUR ULANG"
        Me.atur_ulang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.atur_ulang.Textcolor = System.Drawing.Color.White
        Me.atur_ulang.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tabel_pemesanan_kamar
        '
        Me.tabel_pemesanan_kamar.BackgroundColor = System.Drawing.Color.Turquoise
        Me.tabel_pemesanan_kamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Turquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabel_pemesanan_kamar.DefaultCellStyle = DataGridViewCellStyle1
        Me.tabel_pemesanan_kamar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabel_pemesanan_kamar.Location = New System.Drawing.Point(0, 336)
        Me.tabel_pemesanan_kamar.Name = "tabel_pemesanan_kamar"
        Me.tabel_pemesanan_kamar.Size = New System.Drawing.Size(788, 267)
        Me.tabel_pemesanan_kamar.TabIndex = 121
        '
        'bt_kembali
        '
        Me.bt_kembali.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_kembali.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_kembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_kembali.BorderRadius = 0
        Me.bt_kembali.ButtonText = "KEMBALI"
        Me.bt_kembali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_kembali.DisabledColor = System.Drawing.Color.Gray
        Me.bt_kembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_kembali.Iconcolor = System.Drawing.Color.Transparent
        Me.bt_kembali.Iconimage = Nothing
        Me.bt_kembali.Iconimage_right = Nothing
        Me.bt_kembali.Iconimage_right_Selected = Nothing
        Me.bt_kembali.Iconimage_Selected = Nothing
        Me.bt_kembali.IconMarginLeft = 0
        Me.bt_kembali.IconMarginRight = 0
        Me.bt_kembali.IconRightVisible = True
        Me.bt_kembali.IconRightZoom = 0.0R
        Me.bt_kembali.IconVisible = True
        Me.bt_kembali.IconZoom = 90.0R
        Me.bt_kembali.IsTab = False
        Me.bt_kembali.Location = New System.Drawing.Point(322, 264)
        Me.bt_kembali.Name = "bt_kembali"
        Me.bt_kembali.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_kembali.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_kembali.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_kembali.selected = False
        Me.bt_kembali.Size = New System.Drawing.Size(74, 24)
        Me.bt_kembali.TabIndex = 120
        Me.bt_kembali.Text = "KEMBALI"
        Me.bt_kembali.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bt_kembali.Textcolor = System.Drawing.Color.White
        Me.bt_kembali.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bt_hapus
        '
        Me.bt_hapus.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_hapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_hapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_hapus.BorderRadius = 0
        Me.bt_hapus.ButtonText = "HAPUS"
        Me.bt_hapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_hapus.DisabledColor = System.Drawing.Color.Gray
        Me.bt_hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_hapus.Iconcolor = System.Drawing.Color.Transparent
        Me.bt_hapus.Iconimage = Nothing
        Me.bt_hapus.Iconimage_right = Nothing
        Me.bt_hapus.Iconimage_right_Selected = Nothing
        Me.bt_hapus.Iconimage_Selected = Nothing
        Me.bt_hapus.IconMarginLeft = 0
        Me.bt_hapus.IconMarginRight = 0
        Me.bt_hapus.IconRightVisible = True
        Me.bt_hapus.IconRightZoom = 0.0R
        Me.bt_hapus.IconVisible = True
        Me.bt_hapus.IconZoom = 90.0R
        Me.bt_hapus.IsTab = False
        Me.bt_hapus.Location = New System.Drawing.Point(230, 264)
        Me.bt_hapus.Name = "bt_hapus"
        Me.bt_hapus.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_hapus.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_hapus.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_hapus.selected = False
        Me.bt_hapus.Size = New System.Drawing.Size(74, 24)
        Me.bt_hapus.TabIndex = 119
        Me.bt_hapus.Text = "HAPUS"
        Me.bt_hapus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bt_hapus.Textcolor = System.Drawing.Color.White
        Me.bt_hapus.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bt_simpan
        '
        Me.bt_simpan.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_simpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_simpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_simpan.BorderRadius = 0
        Me.bt_simpan.ButtonText = "SIMPAN"
        Me.bt_simpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_simpan.DisabledColor = System.Drawing.Color.Gray
        Me.bt_simpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_simpan.Iconcolor = System.Drawing.Color.Transparent
        Me.bt_simpan.Iconimage = Nothing
        Me.bt_simpan.Iconimage_right = Nothing
        Me.bt_simpan.Iconimage_right_Selected = Nothing
        Me.bt_simpan.Iconimage_Selected = Nothing
        Me.bt_simpan.IconMarginLeft = 0
        Me.bt_simpan.IconMarginRight = 0
        Me.bt_simpan.IconRightVisible = True
        Me.bt_simpan.IconRightZoom = 0.0R
        Me.bt_simpan.IconVisible = True
        Me.bt_simpan.IconZoom = 90.0R
        Me.bt_simpan.IsTab = False
        Me.bt_simpan.Location = New System.Drawing.Point(141, 264)
        Me.bt_simpan.Name = "bt_simpan"
        Me.bt_simpan.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_simpan.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_simpan.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_simpan.selected = False
        Me.bt_simpan.Size = New System.Drawing.Size(74, 24)
        Me.bt_simpan.TabIndex = 118
        Me.bt_simpan.Text = "SIMPAN"
        Me.bt_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bt_simpan.Textcolor = System.Drawing.Color.White
        Me.bt_simpan.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(269, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(182, 28)
        Me.Label8.TabIndex = 117
        Me.Label8.Text = "PEMBAYARAN"
        '
        'total
        '
        Me.total.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.Location = New System.Drawing.Point(559, 196)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(186, 55)
        Me.total.TabIndex = 116
        Me.total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(427, 220)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 13)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "TOTAL KESELURUHAN"
        '
        'tgl_pembayaran
        '
        Me.tgl_pembayaran.CustomFormat = "dd-MM-yyyy"
        Me.tgl_pembayaran.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tgl_pembayaran.Location = New System.Drawing.Point(186, 160)
        Me.tgl_pembayaran.Name = "tgl_pembayaran"
        Me.tgl_pembayaran.Size = New System.Drawing.Size(104, 20)
        Me.tgl_pembayaran.TabIndex = 112
        Me.tgl_pembayaran.Value = New Date(2018, 12, 15, 0, 0, 0, 0)
        '
        'tb_idpelanggan
        '
        Me.tb_idpelanggan.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_idpelanggan.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_idpelanggan.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_idpelanggan.BorderThickness = 1
        Me.tb_idpelanggan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_idpelanggan.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_idpelanggan.ForeColor = System.Drawing.Color.Black
        Me.tb_idpelanggan.isPassword = False
        Me.tb_idpelanggan.Location = New System.Drawing.Point(139, 201)
        Me.tb_idpelanggan.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_idpelanggan.Name = "tb_idpelanggan"
        Me.tb_idpelanggan.Size = New System.Drawing.Size(163, 24)
        Me.tb_idpelanggan.TabIndex = 111
        Me.tb_idpelanggan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "TANGGAL PEMBAYARAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "ID PELANGGAN"
        '
        'bt_cari
        '
        Me.bt_cari.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_cari.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_cari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_cari.BorderRadius = 0
        Me.bt_cari.ButtonText = "CARI"
        Me.bt_cari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_cari.DisabledColor = System.Drawing.Color.Gray
        Me.bt_cari.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_cari.Iconcolor = System.Drawing.Color.Transparent
        Me.bt_cari.Iconimage = Nothing
        Me.bt_cari.Iconimage_right = Nothing
        Me.bt_cari.Iconimage_right_Selected = Nothing
        Me.bt_cari.Iconimage_Selected = Nothing
        Me.bt_cari.IconMarginLeft = 0
        Me.bt_cari.IconMarginRight = 0
        Me.bt_cari.IconRightVisible = True
        Me.bt_cari.IconRightZoom = 0.0R
        Me.bt_cari.IconVisible = True
        Me.bt_cari.IconZoom = 90.0R
        Me.bt_cari.IsTab = False
        Me.bt_cari.Location = New System.Drawing.Point(322, 70)
        Me.bt_cari.Name = "bt_cari"
        Me.bt_cari.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_cari.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_cari.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_cari.selected = False
        Me.bt_cari.Size = New System.Drawing.Size(74, 24)
        Me.bt_cari.TabIndex = 108
        Me.bt_cari.Text = "CARI"
        Me.bt_cari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bt_cari.Textcolor = System.Drawing.Color.White
        Me.bt_cari.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tb_idpesanmakanan
        '
        Me.tb_idpesanmakanan.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_idpesanmakanan.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_idpesanmakanan.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_idpesanmakanan.BorderThickness = 1
        Me.tb_idpesanmakanan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_idpesanmakanan.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_idpesanmakanan.ForeColor = System.Drawing.Color.Black
        Me.tb_idpesanmakanan.isPassword = False
        Me.tb_idpesanmakanan.Location = New System.Drawing.Point(547, 113)
        Me.tb_idpesanmakanan.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_idpesanmakanan.Name = "tb_idpesanmakanan"
        Me.tb_idpesanmakanan.Size = New System.Drawing.Size(163, 24)
        Me.tb_idpesanmakanan.TabIndex = 107
        Me.tb_idpesanmakanan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_idpeg
        '
        Me.tb_idpeg.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_idpeg.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_idpeg.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_idpeg.BorderThickness = 1
        Me.tb_idpeg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_idpeg.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_idpeg.ForeColor = System.Drawing.Color.Black
        Me.tb_idpeg.isPassword = False
        Me.tb_idpeg.Location = New System.Drawing.Point(139, 113)
        Me.tb_idpeg.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_idpeg.Name = "tb_idpeg"
        Me.tb_idpeg.Size = New System.Drawing.Size(163, 24)
        Me.tb_idpeg.TabIndex = 106
        Me.tb_idpeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_idpembayaran
        '
        Me.tb_idpembayaran.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_idpembayaran.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_idpembayaran.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_idpembayaran.BorderThickness = 1
        Me.tb_idpembayaran.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_idpembayaran.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_idpembayaran.ForeColor = System.Drawing.Color.Black
        Me.tb_idpembayaran.isPassword = False
        Me.tb_idpembayaran.Location = New System.Drawing.Point(139, 70)
        Me.tb_idpembayaran.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_idpembayaran.Name = "tb_idpembayaran"
        Me.tb_idpembayaran.Size = New System.Drawing.Size(163, 24)
        Me.tb_idpembayaran.TabIndex = 105
        Me.tb_idpembayaran.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(427, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "ID PESAN MAKANAN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "ID PEGAWAI"
        '
        'id_pesan_kamar
        '
        Me.id_pesan_kamar.AutoSize = True
        Me.id_pesan_kamar.Location = New System.Drawing.Point(34, 81)
        Me.id_pesan_kamar.Name = "id_pesan_kamar"
        Me.id_pesan_kamar.Size = New System.Drawing.Size(95, 13)
        Me.id_pesan_kamar.TabIndex = 102
        Me.id_pesan_kamar.Text = "ID PEMBAYARAN"
        '
        'tb_idpesankamar
        '
        Me.tb_idpesankamar.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_idpesankamar.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_idpesankamar.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_idpesankamar.BorderThickness = 1
        Me.tb_idpesankamar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_idpesankamar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_idpesankamar.ForeColor = System.Drawing.Color.Black
        Me.tb_idpesankamar.isPassword = False
        Me.tb_idpesankamar.Location = New System.Drawing.Point(547, 70)
        Me.tb_idpesankamar.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_idpesankamar.Name = "tb_idpesankamar"
        Me.tb_idpesankamar.Size = New System.Drawing.Size(163, 24)
        Me.tb_idpesankamar.TabIndex = 124
        Me.tb_idpesankamar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(427, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 123
        Me.Label7.Text = "ID PESAN KAMAR"
        '
        'tb_idpesanminuman
        '
        Me.tb_idpesanminuman.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_idpesanminuman.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_idpesanminuman.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_idpesanminuman.BorderThickness = 1
        Me.tb_idpesanminuman.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_idpesanminuman.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_idpesanminuman.ForeColor = System.Drawing.Color.Black
        Me.tb_idpesanminuman.isPassword = False
        Me.tb_idpesanminuman.Location = New System.Drawing.Point(547, 155)
        Me.tb_idpesanminuman.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_idpesanminuman.Name = "tb_idpesanminuman"
        Me.tb_idpesanminuman.Size = New System.Drawing.Size(163, 24)
        Me.tb_idpesanminuman.TabIndex = 126
        Me.tb_idpesanminuman.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(427, 166)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 13)
        Me.Label9.TabIndex = 125
        Me.Label9.Text = "ID PESAN MINUMAN"
        '
        'PEMBAYARAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 603)
        Me.Controls.Add(Me.tb_idpesanminuman)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tb_idpesankamar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.atur_ulang)
        Me.Controls.Add(Me.tabel_pemesanan_kamar)
        Me.Controls.Add(Me.bt_kembali)
        Me.Controls.Add(Me.bt_hapus)
        Me.Controls.Add(Me.bt_simpan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tgl_pembayaran)
        Me.Controls.Add(Me.tb_idpelanggan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bt_cari)
        Me.Controls.Add(Me.tb_idpesanmakanan)
        Me.Controls.Add(Me.tb_idpeg)
        Me.Controls.Add(Me.tb_idpembayaran)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.id_pesan_kamar)
        Me.Name = "PEMBAYARAN"
        Me.Text = "Form1"
        CType(Me.tabel_pemesanan_kamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents atur_ulang As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents tabel_pemesanan_kamar As System.Windows.Forms.DataGridView
    Friend WithEvents bt_kembali As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bt_hapus As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bt_simpan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents total As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tgl_pembayaran As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_idpelanggan As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bt_cari As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents tb_idpesanmakanan As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tb_idpeg As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tb_idpembayaran As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents id_pesan_kamar As System.Windows.Forms.Label
    Friend WithEvents tb_idpesankamar As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb_idpesanminuman As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
