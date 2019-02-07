<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PEGAWAI
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
        Me.bt_kembali = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bt_hapus = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bt_simpan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bt_cari = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.tb_namabel = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tb_namadep = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tb_idpeg = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nama_dep = New System.Windows.Forms.Label()
        Me.tabel_pegawai = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_umur = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tb_alamat = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.rb_perem = New System.Windows.Forms.RadioButton()
        Me.rb_laki = New System.Windows.Forms.RadioButton()
        Me.atur_ulang = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.tabel_pegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.bt_kembali.Location = New System.Drawing.Point(322, 336)
        Me.bt_kembali.Name = "bt_kembali"
        Me.bt_kembali.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_kembali.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_kembali.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_kembali.selected = False
        Me.bt_kembali.Size = New System.Drawing.Size(74, 24)
        Me.bt_kembali.TabIndex = 40
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
        Me.bt_hapus.Location = New System.Drawing.Point(230, 336)
        Me.bt_hapus.Name = "bt_hapus"
        Me.bt_hapus.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_hapus.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_hapus.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_hapus.selected = False
        Me.bt_hapus.Size = New System.Drawing.Size(74, 24)
        Me.bt_hapus.TabIndex = 39
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
        Me.bt_simpan.Location = New System.Drawing.Point(141, 336)
        Me.bt_simpan.Name = "bt_simpan"
        Me.bt_simpan.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_simpan.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_simpan.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_simpan.selected = False
        Me.bt_simpan.Size = New System.Drawing.Size(74, 24)
        Me.bt_simpan.TabIndex = 38
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
        Me.bt_cari.Location = New System.Drawing.Point(322, 68)
        Me.bt_cari.Name = "bt_cari"
        Me.bt_cari.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_cari.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_cari.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_cari.selected = False
        Me.bt_cari.Size = New System.Drawing.Size(74, 24)
        Me.bt_cari.TabIndex = 37
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
        Me.tb_namabel.Location = New System.Drawing.Point(139, 154)
        Me.tb_namabel.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_namabel.Name = "tb_namabel"
        Me.tb_namabel.Size = New System.Drawing.Size(163, 24)
        Me.tb_namabel.TabIndex = 36
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
        Me.tb_namadep.Location = New System.Drawing.Point(139, 111)
        Me.tb_namadep.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_namadep.Name = "tb_namadep"
        Me.tb_namadep.Size = New System.Drawing.Size(163, 24)
        Me.tb_namadep.TabIndex = 35
        Me.tb_namadep.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.tb_idpeg.Location = New System.Drawing.Point(139, 68)
        Me.tb_idpeg.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_idpeg.Name = "tb_idpeg"
        Me.tb_idpeg.Size = New System.Drawing.Size(163, 24)
        Me.tb_idpeg.TabIndex = 34
        Me.tb_idpeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "JENIS KELAMIN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "NAMA BELAKANG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "NAMA DEPAN"
        '
        'nama_dep
        '
        Me.nama_dep.AutoSize = True
        Me.nama_dep.Location = New System.Drawing.Point(34, 79)
        Me.nama_dep.Name = "nama_dep"
        Me.nama_dep.Size = New System.Drawing.Size(71, 13)
        Me.nama_dep.TabIndex = 30
        Me.nama_dep.Text = "ID PEGAWAI"
        '
        'tabel_pegawai
        '
        Me.tabel_pegawai.BackgroundColor = System.Drawing.Color.Turquoise
        Me.tabel_pegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Turquoise
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabel_pegawai.DefaultCellStyle = DataGridViewCellStyle2
        Me.tabel_pegawai.Location = New System.Drawing.Point(411, 79)
        Me.tabel_pegawai.Name = "tabel_pegawai"
        Me.tabel_pegawai.Size = New System.Drawing.Size(365, 267)
        Me.tabel_pegawai.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(333, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 28)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "PEGAWAI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "UMUR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "ALAMAT"
        '
        'tb_umur
        '
        Me.tb_umur.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_umur.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_umur.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_umur.BorderThickness = 1
        Me.tb_umur.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_umur.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_umur.ForeColor = System.Drawing.Color.Black
        Me.tb_umur.isPassword = False
        Me.tb_umur.Location = New System.Drawing.Point(139, 244)
        Me.tb_umur.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_umur.Name = "tb_umur"
        Me.tb_umur.Size = New System.Drawing.Size(163, 24)
        Me.tb_umur.TabIndex = 46
        Me.tb_umur.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.tb_alamat.Location = New System.Drawing.Point(139, 282)
        Me.tb_alamat.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_alamat.Name = "tb_alamat"
        Me.tb_alamat.Size = New System.Drawing.Size(163, 24)
        Me.tb_alamat.TabIndex = 47
        Me.tb_alamat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'rb_perem
        '
        Me.rb_perem.AutoSize = True
        Me.rb_perem.Location = New System.Drawing.Point(141, 211)
        Me.rb_perem.Name = "rb_perem"
        Me.rb_perem.Size = New System.Drawing.Size(79, 17)
        Me.rb_perem.TabIndex = 48
        Me.rb_perem.TabStop = True
        Me.rb_perem.Text = "Perempuan"
        Me.rb_perem.UseVisualStyleBackColor = True
        '
        'rb_laki
        '
        Me.rb_laki.AutoSize = True
        Me.rb_laki.Location = New System.Drawing.Point(252, 211)
        Me.rb_laki.Name = "rb_laki"
        Me.rb_laki.Size = New System.Drawing.Size(64, 17)
        Me.rb_laki.TabIndex = 49
        Me.rb_laki.TabStop = True
        Me.rb_laki.Text = "Laki-laki"
        Me.rb_laki.UseVisualStyleBackColor = True
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
        Me.atur_ulang.Location = New System.Drawing.Point(673, 36)
        Me.atur_ulang.Name = "atur_ulang"
        Me.atur_ulang.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.atur_ulang.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.atur_ulang.OnHoverTextColor = System.Drawing.Color.White
        Me.atur_ulang.selected = False
        Me.atur_ulang.Size = New System.Drawing.Size(103, 24)
        Me.atur_ulang.TabIndex = 50
        Me.atur_ulang.Text = "ATUR ULANG"
        Me.atur_ulang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.atur_ulang.Textcolor = System.Drawing.Color.White
        Me.atur_ulang.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PEGAWAI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 413)
        Me.Controls.Add(Me.atur_ulang)
        Me.Controls.Add(Me.rb_laki)
        Me.Controls.Add(Me.rb_perem)
        Me.Controls.Add(Me.tb_alamat)
        Me.Controls.Add(Me.tb_umur)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tabel_pegawai)
        Me.Controls.Add(Me.bt_kembali)
        Me.Controls.Add(Me.bt_hapus)
        Me.Controls.Add(Me.bt_simpan)
        Me.Controls.Add(Me.bt_cari)
        Me.Controls.Add(Me.tb_namabel)
        Me.Controls.Add(Me.tb_namadep)
        Me.Controls.Add(Me.tb_idpeg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nama_dep)
        Me.Name = "PEGAWAI"
        Me.Text = "Form1"
        CType(Me.tabel_pegawai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_kembali As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bt_hapus As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bt_simpan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bt_cari As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents tb_namabel As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tb_namadep As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tb_idpeg As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nama_dep As System.Windows.Forms.Label
    Friend WithEvents tabel_pegawai As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_umur As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tb_alamat As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents rb_perem As System.Windows.Forms.RadioButton
    Friend WithEvents rb_laki As System.Windows.Forms.RadioButton
    Friend WithEvents atur_ulang As Bunifu.Framework.UI.BunifuFlatButton
End Class
