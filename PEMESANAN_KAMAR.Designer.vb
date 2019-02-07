<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PEMESANAN_KAMAR
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cek_in = New System.Windows.Forms.DateTimePicker()
        Me.tb_idjeniskamar = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bt_cari = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.tb_idkamar = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tb_idpel = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tb_idpesan = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.id_pesan_kamar = New System.Windows.Forms.Label()
        Me.cek_out = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bt_kembali = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bt_simpan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.tabel_pemesanan_kamar = New System.Windows.Forms.DataGridView()
        Me.atur_ulang = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bt_perbarui = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bt_hitung = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.tabel_pemesanan_kamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cek_in
        '
        Me.cek_in.CustomFormat = "dd-MM-yyyy"
        Me.cek_in.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cek_in.Location = New System.Drawing.Point(547, 83)
        Me.cek_in.Name = "cek_in"
        Me.cek_in.Size = New System.Drawing.Size(104, 20)
        Me.cek_in.TabIndex = 91
        Me.cek_in.Value = New Date(2018, 12, 15, 0, 0, 0, 0)
        '
        'tb_idjeniskamar
        '
        Me.tb_idjeniskamar.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_idjeniskamar.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_idjeniskamar.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_idjeniskamar.BorderThickness = 1
        Me.tb_idjeniskamar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_idjeniskamar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_idjeniskamar.ForeColor = System.Drawing.Color.Black
        Me.tb_idjeniskamar.isPassword = False
        Me.tb_idjeniskamar.Location = New System.Drawing.Point(139, 214)
        Me.tb_idjeniskamar.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_idjeniskamar.Name = "tb_idjeniskamar"
        Me.tb_idjeniskamar.Size = New System.Drawing.Size(163, 24)
        Me.tb_idjeniskamar.TabIndex = 88
        Me.tb_idjeniskamar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(440, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "CEK IN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "ID JENIS KAMAR"
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
        Me.bt_cari.Location = New System.Drawing.Point(322, 83)
        Me.bt_cari.Name = "bt_cari"
        Me.bt_cari.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_cari.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_cari.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_cari.selected = False
        Me.bt_cari.Size = New System.Drawing.Size(74, 24)
        Me.bt_cari.TabIndex = 85
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
        Me.tb_idkamar.Location = New System.Drawing.Point(139, 169)
        Me.tb_idkamar.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_idkamar.Name = "tb_idkamar"
        Me.tb_idkamar.Size = New System.Drawing.Size(163, 24)
        Me.tb_idkamar.TabIndex = 84
        Me.tb_idkamar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_idpel
        '
        Me.tb_idpel.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_idpel.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_idpel.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_idpel.BorderThickness = 1
        Me.tb_idpel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_idpel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_idpel.ForeColor = System.Drawing.Color.Black
        Me.tb_idpel.isPassword = False
        Me.tb_idpel.Location = New System.Drawing.Point(139, 126)
        Me.tb_idpel.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_idpel.Name = "tb_idpel"
        Me.tb_idpel.Size = New System.Drawing.Size(163, 24)
        Me.tb_idpel.TabIndex = 83
        Me.tb_idpel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_idpesan
        '
        Me.tb_idpesan.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_idpesan.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_idpesan.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_idpesan.BorderThickness = 1
        Me.tb_idpesan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_idpesan.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_idpesan.ForeColor = System.Drawing.Color.Black
        Me.tb_idpesan.isPassword = False
        Me.tb_idpesan.Location = New System.Drawing.Point(139, 83)
        Me.tb_idpesan.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_idpesan.Name = "tb_idpesan"
        Me.tb_idpesan.Size = New System.Drawing.Size(163, 24)
        Me.tb_idpesan.TabIndex = 82
        Me.tb_idpesan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "ID KAMAR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "ID PELANGGAN"
        '
        'id_pesan_kamar
        '
        Me.id_pesan_kamar.AutoSize = True
        Me.id_pesan_kamar.Location = New System.Drawing.Point(34, 94)
        Me.id_pesan_kamar.Name = "id_pesan_kamar"
        Me.id_pesan_kamar.Size = New System.Drawing.Size(98, 13)
        Me.id_pesan_kamar.TabIndex = 78
        Me.id_pesan_kamar.Text = "ID PESAN KAMAR"
        '
        'cek_out
        '
        Me.cek_out.CustomFormat = "dd-MM-yyyy"
        Me.cek_out.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cek_out.Location = New System.Drawing.Point(547, 123)
        Me.cek_out.Name = "cek_out"
        Me.cek_out.Size = New System.Drawing.Size(104, 20)
        Me.cek_out.TabIndex = 93
        Me.cek_out.Value = New Date(2018, 12, 15, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(440, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "CEK OUT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(437, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "TOTAL BAYAR"
        '
        'total
        '
        Me.total.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.Location = New System.Drawing.Point(542, 162)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(186, 76)
        Me.total.TabIndex = 95
        Me.total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(269, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(261, 28)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "PEMESANAN KAMAR"
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
        Me.bt_kembali.Location = New System.Drawing.Point(313, 277)
        Me.bt_kembali.Name = "bt_kembali"
        Me.bt_kembali.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_kembali.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_kembali.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_kembali.selected = False
        Me.bt_kembali.Size = New System.Drawing.Size(74, 24)
        Me.bt_kembali.TabIndex = 99
        Me.bt_kembali.Text = "KEMBALI"
        Me.bt_kembali.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bt_kembali.Textcolor = System.Drawing.Color.White
        Me.bt_kembali.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.bt_simpan.Location = New System.Drawing.Point(141, 277)
        Me.bt_simpan.Name = "bt_simpan"
        Me.bt_simpan.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_simpan.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_simpan.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_simpan.selected = False
        Me.bt_simpan.Size = New System.Drawing.Size(74, 24)
        Me.bt_simpan.TabIndex = 97
        Me.bt_simpan.Text = "SIMPAN"
        Me.bt_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bt_simpan.Textcolor = System.Drawing.Color.White
        Me.bt_simpan.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tabel_pemesanan_kamar
        '
        Me.tabel_pemesanan_kamar.BackgroundColor = System.Drawing.Color.Turquoise
        Me.tabel_pemesanan_kamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Turquoise
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabel_pemesanan_kamar.DefaultCellStyle = DataGridViewCellStyle2
        Me.tabel_pemesanan_kamar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabel_pemesanan_kamar.Location = New System.Drawing.Point(0, 336)
        Me.tabel_pemesanan_kamar.Name = "tabel_pemesanan_kamar"
        Me.tabel_pemesanan_kamar.Size = New System.Drawing.Size(840, 267)
        Me.tabel_pemesanan_kamar.TabIndex = 100
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
        Me.atur_ulang.Location = New System.Drawing.Point(673, 40)
        Me.atur_ulang.Name = "atur_ulang"
        Me.atur_ulang.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.atur_ulang.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.atur_ulang.OnHoverTextColor = System.Drawing.Color.White
        Me.atur_ulang.selected = False
        Me.atur_ulang.Size = New System.Drawing.Size(103, 24)
        Me.atur_ulang.TabIndex = 101
        Me.atur_ulang.Text = "ATUR ULANG"
        Me.atur_ulang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.atur_ulang.Textcolor = System.Drawing.Color.White
        Me.atur_ulang.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.bt_perbarui.Location = New System.Drawing.Point(221, 277)
        Me.bt_perbarui.Name = "bt_perbarui"
        Me.bt_perbarui.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_perbarui.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_perbarui.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_perbarui.selected = False
        Me.bt_perbarui.Size = New System.Drawing.Size(86, 24)
        Me.bt_perbarui.TabIndex = 102
        Me.bt_perbarui.Text = "PERBARUI"
        Me.bt_perbarui.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bt_perbarui.Textcolor = System.Drawing.Color.White
        Me.bt_perbarui.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.bt_hitung.Location = New System.Drawing.Point(547, 256)
        Me.bt_hitung.Name = "bt_hitung"
        Me.bt_hitung.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_hitung.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_hitung.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_hitung.selected = False
        Me.bt_hitung.Size = New System.Drawing.Size(74, 24)
        Me.bt_hitung.TabIndex = 103
        Me.bt_hitung.Text = "HITUNG"
        Me.bt_hitung.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bt_hitung.Textcolor = System.Drawing.Color.White
        Me.bt_hitung.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PEMESANAN_KAMAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 603)
        Me.Controls.Add(Me.bt_hitung)
        Me.Controls.Add(Me.bt_perbarui)
        Me.Controls.Add(Me.atur_ulang)
        Me.Controls.Add(Me.tabel_pemesanan_kamar)
        Me.Controls.Add(Me.bt_kembali)
        Me.Controls.Add(Me.bt_simpan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cek_out)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cek_in)
        Me.Controls.Add(Me.tb_idjeniskamar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bt_cari)
        Me.Controls.Add(Me.tb_idkamar)
        Me.Controls.Add(Me.tb_idpel)
        Me.Controls.Add(Me.tb_idpesan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.id_pesan_kamar)
        Me.Name = "PEMESANAN_KAMAR"
        Me.Text = "PEMESANAN_KAMAR"
        CType(Me.tabel_pemesanan_kamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cek_in As System.Windows.Forms.DateTimePicker
    Friend WithEvents tb_idjeniskamar As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bt_cari As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents tb_idkamar As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tb_idpel As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tb_idpesan As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents id_pesan_kamar As System.Windows.Forms.Label
    Friend WithEvents cek_out As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents total As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents bt_kembali As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bt_simpan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents tabel_pemesanan_kamar As System.Windows.Forms.DataGridView
    Friend WithEvents atur_ulang As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bt_perbarui As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bt_hitung As Bunifu.Framework.UI.BunifuFlatButton
End Class
