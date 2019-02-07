<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PELANGGAN
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
        Me.rb_laki = New System.Windows.Forms.RadioButton()
        Me.rb_perem = New System.Windows.Forms.RadioButton()
        Me.tb_tempatlhr = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabel_pelanggan = New System.Windows.Forms.DataGridView()
        Me.bt_kembali = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bt_hapus = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bt_simpan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bt_cari = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.tb_namabel = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tb_namadep = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tb_idpel = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nama_dep = New System.Windows.Forms.Label()
        Me.tb_kebangsaan = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tb_notel = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_alamat = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tb_tgllhr = New System.Windows.Forms.DateTimePicker()
        CType(Me.tabel_pelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.atur_ulang.TabIndex = 70
        Me.atur_ulang.Text = "ATUR ULANG"
        Me.atur_ulang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.atur_ulang.Textcolor = System.Drawing.Color.White
        Me.atur_ulang.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'rb_laki
        '
        Me.rb_laki.AutoSize = True
        Me.rb_laki.Location = New System.Drawing.Point(227, 192)
        Me.rb_laki.Name = "rb_laki"
        Me.rb_laki.Size = New System.Drawing.Size(64, 17)
        Me.rb_laki.TabIndex = 69
        Me.rb_laki.TabStop = True
        Me.rb_laki.Text = "Laki-laki"
        Me.rb_laki.UseVisualStyleBackColor = True
        '
        'rb_perem
        '
        Me.rb_perem.AutoSize = True
        Me.rb_perem.Location = New System.Drawing.Point(130, 192)
        Me.rb_perem.Name = "rb_perem"
        Me.rb_perem.Size = New System.Drawing.Size(79, 17)
        Me.rb_perem.TabIndex = 68
        Me.rb_perem.TabStop = True
        Me.rb_perem.Text = "Perempuan"
        Me.rb_perem.UseVisualStyleBackColor = True
        '
        'tb_tempatlhr
        '
        Me.tb_tempatlhr.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_tempatlhr.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_tempatlhr.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_tempatlhr.BorderThickness = 1
        Me.tb_tempatlhr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_tempatlhr.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_tempatlhr.ForeColor = System.Drawing.Color.Black
        Me.tb_tempatlhr.isPassword = False
        Me.tb_tempatlhr.Location = New System.Drawing.Point(128, 221)
        Me.tb_tempatlhr.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_tempatlhr.Name = "tb_tempatlhr"
        Me.tb_tempatlhr.Size = New System.Drawing.Size(163, 24)
        Me.tb_tempatlhr.TabIndex = 66
        Me.tb_tempatlhr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "TANGGAL_LAHIR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "TEMPAT_LAHIR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(322, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 28)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "PELANGGAN"
        '
        'tabel_pelanggan
        '
        Me.tabel_pelanggan.BackgroundColor = System.Drawing.Color.Turquoise
        Me.tabel_pelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Turquoise
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabel_pelanggan.DefaultCellStyle = DataGridViewCellStyle1
        Me.tabel_pelanggan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tabel_pelanggan.Location = New System.Drawing.Point(0, 383)
        Me.tabel_pelanggan.Name = "tabel_pelanggan"
        Me.tabel_pelanggan.Size = New System.Drawing.Size(788, 267)
        Me.tabel_pelanggan.TabIndex = 62
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
        Me.bt_kembali.Location = New System.Drawing.Point(311, 325)
        Me.bt_kembali.Name = "bt_kembali"
        Me.bt_kembali.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_kembali.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_kembali.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_kembali.selected = False
        Me.bt_kembali.Size = New System.Drawing.Size(74, 24)
        Me.bt_kembali.TabIndex = 61
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
        Me.bt_hapus.Location = New System.Drawing.Point(219, 325)
        Me.bt_hapus.Name = "bt_hapus"
        Me.bt_hapus.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_hapus.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_hapus.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_hapus.selected = False
        Me.bt_hapus.Size = New System.Drawing.Size(74, 24)
        Me.bt_hapus.TabIndex = 60
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
        Me.bt_simpan.Location = New System.Drawing.Point(130, 325)
        Me.bt_simpan.Name = "bt_simpan"
        Me.bt_simpan.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_simpan.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_simpan.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_simpan.selected = False
        Me.bt_simpan.Size = New System.Drawing.Size(74, 24)
        Me.bt_simpan.TabIndex = 59
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
        Me.bt_cari.Location = New System.Drawing.Point(311, 57)
        Me.bt_cari.Name = "bt_cari"
        Me.bt_cari.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_cari.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_cari.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_cari.selected = False
        Me.bt_cari.Size = New System.Drawing.Size(74, 24)
        Me.bt_cari.TabIndex = 58
        Me.bt_cari.Text = "CARI"
        Me.bt_cari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bt_cari.Textcolor = System.Drawing.Color.White
        Me.bt_cari.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tb_namabel
        '
        Me.tb_namabel.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_namabel.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_namabel.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_namabel.BorderThickness = 1
        Me.tb_namabel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_namabel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_namabel.ForeColor = System.Drawing.Color.Black
        Me.tb_namabel.isPassword = False
        Me.tb_namabel.Location = New System.Drawing.Point(128, 143)
        Me.tb_namabel.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_namabel.Name = "tb_namabel"
        Me.tb_namabel.Size = New System.Drawing.Size(163, 24)
        Me.tb_namabel.TabIndex = 57
        Me.tb_namabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_namadep
        '
        Me.tb_namadep.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_namadep.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_namadep.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_namadep.BorderThickness = 1
        Me.tb_namadep.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_namadep.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_namadep.ForeColor = System.Drawing.Color.Black
        Me.tb_namadep.isPassword = False
        Me.tb_namadep.Location = New System.Drawing.Point(128, 100)
        Me.tb_namadep.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_namadep.Name = "tb_namadep"
        Me.tb_namadep.Size = New System.Drawing.Size(163, 24)
        Me.tb_namadep.TabIndex = 56
        Me.tb_namadep.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.tb_idpel.Location = New System.Drawing.Point(128, 57)
        Me.tb_idpel.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_idpel.Name = "tb_idpel"
        Me.tb_idpel.Size = New System.Drawing.Size(163, 24)
        Me.tb_idpel.TabIndex = 55
        Me.tb_idpel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "JENIS KELAMIN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "NAMA BELAKANG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "NAMA DEPAN"
        '
        'nama_dep
        '
        Me.nama_dep.AutoSize = True
        Me.nama_dep.Location = New System.Drawing.Point(23, 68)
        Me.nama_dep.Name = "nama_dep"
        Me.nama_dep.Size = New System.Drawing.Size(87, 13)
        Me.nama_dep.TabIndex = 51
        Me.nama_dep.Text = "ID PELANGGAN"
        '
        'tb_kebangsaan
        '
        Me.tb_kebangsaan.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_kebangsaan.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_kebangsaan.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_kebangsaan.BorderThickness = 1
        Me.tb_kebangsaan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_kebangsaan.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_kebangsaan.ForeColor = System.Drawing.Color.Black
        Me.tb_kebangsaan.isPassword = False
        Me.tb_kebangsaan.Location = New System.Drawing.Point(528, 101)
        Me.tb_kebangsaan.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_kebangsaan.Name = "tb_kebangsaan"
        Me.tb_kebangsaan.Size = New System.Drawing.Size(163, 24)
        Me.tb_kebangsaan.TabIndex = 72
        Me.tb_kebangsaan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(415, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "KEBANGSAAN"
        '
        'tb_notel
        '
        Me.tb_notel.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_notel.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_notel.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_notel.BorderThickness = 1
        Me.tb_notel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_notel.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_notel.ForeColor = System.Drawing.Color.Black
        Me.tb_notel.isPassword = False
        Me.tb_notel.Location = New System.Drawing.Point(528, 143)
        Me.tb_notel.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_notel.Name = "tb_notel"
        Me.tb_notel.Size = New System.Drawing.Size(163, 24)
        Me.tb_notel.TabIndex = 74
        Me.tb_notel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(415, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "NO TELEPON"
        '
        'tb_alamat
        '
        Me.tb_alamat.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_alamat.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_alamat.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_alamat.BorderThickness = 1
        Me.tb_alamat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_alamat.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_alamat.ForeColor = System.Drawing.Color.Black
        Me.tb_alamat.isPassword = False
        Me.tb_alamat.Location = New System.Drawing.Point(528, 195)
        Me.tb_alamat.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_alamat.Name = "tb_alamat"
        Me.tb_alamat.Size = New System.Drawing.Size(163, 24)
        Me.tb_alamat.TabIndex = 76
        Me.tb_alamat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(415, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "ALAMAT"
        '
        'tb_tgllhr
        '
        Me.tb_tgllhr.CustomFormat = "dd-MM-yyyy"
        Me.tb_tgllhr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tb_tgllhr.Location = New System.Drawing.Point(130, 270)
        Me.tb_tgllhr.Name = "tb_tgllhr"
        Me.tb_tgllhr.Size = New System.Drawing.Size(104, 20)
        Me.tb_tgllhr.TabIndex = 77
        Me.tb_tgllhr.Value = New Date(2018, 12, 15, 0, 0, 0, 0)
        '
        'PELANGGAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 650)
        Me.Controls.Add(Me.tb_tgllhr)
        Me.Controls.Add(Me.tb_alamat)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tb_notel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tb_kebangsaan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.atur_ulang)
        Me.Controls.Add(Me.rb_laki)
        Me.Controls.Add(Me.rb_perem)
        Me.Controls.Add(Me.tb_tempatlhr)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tabel_pelanggan)
        Me.Controls.Add(Me.bt_kembali)
        Me.Controls.Add(Me.bt_hapus)
        Me.Controls.Add(Me.bt_simpan)
        Me.Controls.Add(Me.bt_cari)
        Me.Controls.Add(Me.tb_namabel)
        Me.Controls.Add(Me.tb_namadep)
        Me.Controls.Add(Me.tb_idpel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nama_dep)
        Me.Name = "PELANGGAN"
        Me.Text = "Form1"
        CType(Me.tabel_pelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents atur_ulang As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents rb_laki As System.Windows.Forms.RadioButton
    Friend WithEvents rb_perem As System.Windows.Forms.RadioButton
    Friend WithEvents tb_tempatlhr As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabel_pelanggan As System.Windows.Forms.DataGridView
    Friend WithEvents bt_kembali As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bt_hapus As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bt_simpan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bt_cari As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents tb_namabel As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tb_namadep As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tb_idpel As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nama_dep As System.Windows.Forms.Label
    Friend WithEvents tb_kebangsaan As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tb_notel As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tb_alamat As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tb_tgllhr As System.Windows.Forms.DateTimePicker
End Class
