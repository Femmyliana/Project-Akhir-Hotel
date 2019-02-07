<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PEMESANAN_MAKANAN
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.tabel_makanan = New System.Windows.Forms.DataGridView()
        Me.bt_hapus = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bt_perbarui = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bt_simpan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bt_cari = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.tb_idkamar = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tb_idpelanggan = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tb_pesan_makanan = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_idmakanan = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_jumlah_pesan = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lb_totalbayar = New System.Windows.Forms.Label()
        Me.atur_ulang = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bt_hitung = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.tabel_makanan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'tabel_makanan
        '
        Me.tabel_makanan.BackgroundColor = System.Drawing.Color.Turquoise
        Me.tabel_makanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Turquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabel_makanan.DefaultCellStyle = DataGridViewCellStyle1
        Me.tabel_makanan.Location = New System.Drawing.Point(418, 106)
        Me.tabel_makanan.Name = "tabel_makanan"
        Me.tabel_makanan.Size = New System.Drawing.Size(365, 267)
        Me.tabel_makanan.TabIndex = 45
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
        Me.bt_hapus.Location = New System.Drawing.Point(329, 386)
        Me.bt_hapus.Name = "bt_hapus"
        Me.bt_hapus.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_hapus.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_hapus.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_hapus.selected = False
        Me.bt_hapus.Size = New System.Drawing.Size(74, 24)
        Me.bt_hapus.TabIndex = 44
        Me.bt_hapus.Text = "HAPUS"
        Me.bt_hapus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bt_hapus.Textcolor = System.Drawing.Color.White
        Me.bt_hapus.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bt_perbarui
        '
        Me.bt_perbarui.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_perbarui.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_perbarui.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_perbarui.BorderRadius = 0
        Me.bt_perbarui.ButtonText = "PERBARUI"
        Me.bt_perbarui.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_perbarui.DisabledColor = System.Drawing.Color.Gray
        Me.bt_perbarui.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_perbarui.Iconcolor = System.Drawing.Color.Transparent
        Me.bt_perbarui.Iconimage = Nothing
        Me.bt_perbarui.Iconimage_right = Nothing
        Me.bt_perbarui.Iconimage_right_Selected = Nothing
        Me.bt_perbarui.Iconimage_Selected = Nothing
        Me.bt_perbarui.IconMarginLeft = 0
        Me.bt_perbarui.IconMarginRight = 0
        Me.bt_perbarui.IconRightVisible = True
        Me.bt_perbarui.IconRightZoom = 0.0R
        Me.bt_perbarui.IconVisible = True
        Me.bt_perbarui.IconZoom = 90.0R
        Me.bt_perbarui.IsTab = False
        Me.bt_perbarui.Location = New System.Drawing.Point(237, 386)
        Me.bt_perbarui.Name = "bt_perbarui"
        Me.bt_perbarui.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_perbarui.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_perbarui.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_perbarui.selected = False
        Me.bt_perbarui.Size = New System.Drawing.Size(86, 24)
        Me.bt_perbarui.TabIndex = 43
        Me.bt_perbarui.Text = "PERBARUI"
        Me.bt_perbarui.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bt_perbarui.Textcolor = System.Drawing.Color.White
        Me.bt_perbarui.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.bt_simpan.Location = New System.Drawing.Point(157, 386)
        Me.bt_simpan.Name = "bt_simpan"
        Me.bt_simpan.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_simpan.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_simpan.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_simpan.selected = False
        Me.bt_simpan.Size = New System.Drawing.Size(74, 24)
        Me.bt_simpan.TabIndex = 42
        Me.bt_simpan.Text = "SIMPAN"
        Me.bt_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bt_simpan.Textcolor = System.Drawing.Color.White
        Me.bt_simpan.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.bt_cari.Location = New System.Drawing.Point(338, 106)
        Me.bt_cari.Name = "bt_cari"
        Me.bt_cari.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_cari.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_cari.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_cari.selected = False
        Me.bt_cari.Size = New System.Drawing.Size(74, 24)
        Me.bt_cari.TabIndex = 41
        Me.bt_cari.Text = "CARI"
        Me.bt_cari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bt_cari.Textcolor = System.Drawing.Color.White
        Me.bt_cari.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tb_idkamar
        '
        Me.tb_idkamar.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_idkamar.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_idkamar.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_idkamar.BorderThickness = 1
        Me.tb_idkamar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_idkamar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_idkamar.ForeColor = System.Drawing.Color.Black
        Me.tb_idkamar.isPassword = False
        Me.tb_idkamar.Location = New System.Drawing.Point(157, 196)
        Me.tb_idkamar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_idkamar.Name = "tb_idkamar"
        Me.tb_idkamar.Size = New System.Drawing.Size(163, 23)
        Me.tb_idkamar.TabIndex = 40
        Me.tb_idkamar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.tb_idpelanggan.Location = New System.Drawing.Point(157, 150)
        Me.tb_idpelanggan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_idpelanggan.Name = "tb_idpelanggan"
        Me.tb_idpelanggan.Size = New System.Drawing.Size(163, 23)
        Me.tb_idpelanggan.TabIndex = 39
        Me.tb_idpelanggan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_pesan_makanan
        '
        Me.tb_pesan_makanan.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_pesan_makanan.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_pesan_makanan.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_pesan_makanan.BorderThickness = 1
        Me.tb_pesan_makanan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_pesan_makanan.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_pesan_makanan.ForeColor = System.Drawing.Color.Black
        Me.tb_pesan_makanan.isPassword = False
        Me.tb_pesan_makanan.Location = New System.Drawing.Point(157, 106)
        Me.tb_pesan_makanan.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_pesan_makanan.Name = "tb_pesan_makanan"
        Me.tb_pesan_makanan.Size = New System.Drawing.Size(163, 24)
        Me.tb_pesan_makanan.TabIndex = 38
        Me.tb_pesan_makanan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "ID KAMAR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "ID PELANGGAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "ID PESAN MAKANAN"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 25)
        Me.Panel1.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(781, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 28)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "PEMESANAN MAKANAN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "ID MAKANAN"
        '
        'tb_idmakanan
        '
        Me.tb_idmakanan.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_idmakanan.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_idmakanan.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_idmakanan.BorderThickness = 1
        Me.tb_idmakanan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_idmakanan.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_idmakanan.ForeColor = System.Drawing.Color.Black
        Me.tb_idmakanan.isPassword = False
        Me.tb_idmakanan.Location = New System.Drawing.Point(157, 241)
        Me.tb_idmakanan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_idmakanan.Name = "tb_idmakanan"
        Me.tb_idmakanan.Size = New System.Drawing.Size(163, 23)
        Me.tb_idmakanan.TabIndex = 49
        Me.tb_idmakanan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 299)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "JUMLAH PESAN"
        '
        'tb_jumlah_pesan
        '
        Me.tb_jumlah_pesan.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_jumlah_pesan.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_jumlah_pesan.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_jumlah_pesan.BorderThickness = 1
        Me.tb_jumlah_pesan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_jumlah_pesan.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_jumlah_pesan.ForeColor = System.Drawing.Color.Black
        Me.tb_jumlah_pesan.isPassword = False
        Me.tb_jumlah_pesan.Location = New System.Drawing.Point(157, 289)
        Me.tb_jumlah_pesan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_jumlah_pesan.Name = "tb_jumlah_pesan"
        Me.tb_jumlah_pesan.Size = New System.Drawing.Size(163, 23)
        Me.tb_jumlah_pesan.TabIndex = 51
        Me.tb_jumlah_pesan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 348)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "TOTAL BAYAR"
        '
        'lb_totalbayar
        '
        Me.lb_totalbayar.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_totalbayar.Location = New System.Drawing.Point(157, 336)
        Me.lb_totalbayar.Name = "lb_totalbayar"
        Me.lb_totalbayar.Size = New System.Drawing.Size(166, 25)
        Me.lb_totalbayar.TabIndex = 53
        Me.lb_totalbayar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.atur_ulang.Location = New System.Drawing.Point(680, 65)
        Me.atur_ulang.Name = "atur_ulang"
        Me.atur_ulang.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.atur_ulang.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.atur_ulang.OnHoverTextColor = System.Drawing.Color.White
        Me.atur_ulang.selected = False
        Me.atur_ulang.Size = New System.Drawing.Size(103, 24)
        Me.atur_ulang.TabIndex = 54
        Me.atur_ulang.Text = "ATUR ULANG"
        Me.atur_ulang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.atur_ulang.Textcolor = System.Drawing.Color.White
        Me.atur_ulang.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'bt_hitung
        '
        Me.bt_hitung.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_hitung.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_hitung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_hitung.BorderRadius = 0
        Me.bt_hitung.ButtonText = "HITUNG"
        Me.bt_hitung.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_hitung.DisabledColor = System.Drawing.Color.Gray
        Me.bt_hitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_hitung.Iconcolor = System.Drawing.Color.Transparent
        Me.bt_hitung.Iconimage = Nothing
        Me.bt_hitung.Iconimage_right = Nothing
        Me.bt_hitung.Iconimage_right_Selected = Nothing
        Me.bt_hitung.Iconimage_Selected = Nothing
        Me.bt_hitung.IconMarginLeft = 0
        Me.bt_hitung.IconMarginRight = 0
        Me.bt_hitung.IconRightVisible = True
        Me.bt_hitung.IconRightZoom = 0.0R
        Me.bt_hitung.IconVisible = True
        Me.bt_hitung.IconZoom = 90.0R
        Me.bt_hitung.IsTab = False
        Me.bt_hitung.Location = New System.Drawing.Point(338, 289)
        Me.bt_hitung.Name = "bt_hitung"
        Me.bt_hitung.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_hitung.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_hitung.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_hitung.selected = False
        Me.bt_hitung.Size = New System.Drawing.Size(74, 24)
        Me.bt_hitung.TabIndex = 55
        Me.bt_hitung.Text = "HITUNG"
        Me.bt_hitung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bt_hitung.Textcolor = System.Drawing.Color.White
        Me.bt_hitung.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PEMESANAN_MAKANAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(804, 436)
        Me.Controls.Add(Me.bt_hitung)
        Me.Controls.Add(Me.atur_ulang)
        Me.Controls.Add(Me.lb_totalbayar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tb_jumlah_pesan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tb_idmakanan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tabel_makanan)
        Me.Controls.Add(Me.bt_hapus)
        Me.Controls.Add(Me.bt_perbarui)
        Me.Controls.Add(Me.bt_simpan)
        Me.Controls.Add(Me.bt_cari)
        Me.Controls.Add(Me.tb_idkamar)
        Me.Controls.Add(Me.tb_idpelanggan)
        Me.Controls.Add(Me.tb_pesan_makanan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PEMESANAN_MAKANAN"
        Me.Text = "Form1"
        CType(Me.tabel_makanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents tabel_makanan As System.Windows.Forms.DataGridView
    Friend WithEvents bt_hapus As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bt_perbarui As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bt_simpan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bt_cari As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents tb_idkamar As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tb_idpelanggan As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tb_pesan_makanan As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tb_jumlah_pesan As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb_idmakanan As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lb_totalbayar As System.Windows.Forms.Label
    Friend WithEvents atur_ulang As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bt_hitung As Bunifu.Framework.UI.BunifuFlatButton
End Class
