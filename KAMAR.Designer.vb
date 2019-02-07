<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KAMAR
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_idkamar = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tb_idjenis = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tb_harga = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.bt_cari = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bt_simpan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bt_hapus = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bt_kembali = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cb_status = New System.Windows.Forms.ComboBox()
        Me.tabel_kamar = New System.Windows.Forms.DataGridView()
        Me.bt_event = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.tb_range_min = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_range_max = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Panel1.SuspendLayout()
        CType(Me.tabel_kamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(350, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "KAMAR"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 25)
        Me.Panel1.TabIndex = 14
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "ID KAMAR"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = " HARGA NORMAL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "HARGA EVENT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(44, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "STATUS"
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
        Me.tb_idkamar.Location = New System.Drawing.Point(132, 111)
        Me.tb_idkamar.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_idkamar.Name = "tb_idkamar"
        Me.tb_idkamar.Size = New System.Drawing.Size(163, 24)
        Me.tb_idkamar.TabIndex = 19
        Me.tb_idkamar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_idjenis
        '
        Me.tb_idjenis.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_idjenis.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_idjenis.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_idjenis.BorderThickness = 1
        Me.tb_idjenis.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_idjenis.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_idjenis.ForeColor = System.Drawing.Color.Black
        Me.tb_idjenis.isPassword = False
        Me.tb_idjenis.Location = New System.Drawing.Point(132, 154)
        Me.tb_idjenis.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_idjenis.Name = "tb_idjenis"
        Me.tb_idjenis.Size = New System.Drawing.Size(163, 24)
        Me.tb_idjenis.TabIndex = 20
        Me.tb_idjenis.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_harga
        '
        Me.tb_harga.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_harga.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_harga.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_harga.BorderThickness = 1
        Me.tb_harga.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_harga.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_harga.ForeColor = System.Drawing.Color.Black
        Me.tb_harga.isPassword = False
        Me.tb_harga.Location = New System.Drawing.Point(132, 200)
        Me.tb_harga.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_harga.Name = "tb_harga"
        Me.tb_harga.Size = New System.Drawing.Size(163, 24)
        Me.tb_harga.TabIndex = 21
        Me.tb_harga.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'bt_cari
        '
        Me.bt_cari.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_cari.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_cari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_cari.BorderRadius = 0
        Me.bt_cari.ButtonText = "Cari"
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
        Me.bt_cari.Location = New System.Drawing.Point(313, 111)
        Me.bt_cari.Name = "bt_cari"
        Me.bt_cari.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_cari.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_cari.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_cari.selected = False
        Me.bt_cari.Size = New System.Drawing.Size(74, 24)
        Me.bt_cari.TabIndex = 23
        Me.bt_cari.Text = "Cari"
        Me.bt_cari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bt_cari.Textcolor = System.Drawing.Color.White
        Me.bt_cari.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.bt_simpan.Location = New System.Drawing.Point(132, 334)
        Me.bt_simpan.Name = "bt_simpan"
        Me.bt_simpan.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_simpan.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_simpan.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_simpan.selected = False
        Me.bt_simpan.Size = New System.Drawing.Size(74, 24)
        Me.bt_simpan.TabIndex = 25
        Me.bt_simpan.Text = "SIMPAN"
        Me.bt_simpan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bt_simpan.Textcolor = System.Drawing.Color.White
        Me.bt_simpan.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.bt_hapus.Location = New System.Drawing.Point(221, 334)
        Me.bt_hapus.Name = "bt_hapus"
        Me.bt_hapus.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_hapus.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_hapus.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_hapus.selected = False
        Me.bt_hapus.Size = New System.Drawing.Size(74, 24)
        Me.bt_hapus.TabIndex = 26
        Me.bt_hapus.Text = "HAPUS"
        Me.bt_hapus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bt_hapus.Textcolor = System.Drawing.Color.White
        Me.bt_hapus.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.bt_kembali.Location = New System.Drawing.Point(313, 334)
        Me.bt_kembali.Name = "bt_kembali"
        Me.bt_kembali.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_kembali.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_kembali.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_kembali.selected = False
        Me.bt_kembali.Size = New System.Drawing.Size(74, 24)
        Me.bt_kembali.TabIndex = 27
        Me.bt_kembali.Text = "KEMBALI"
        Me.bt_kembali.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bt_kembali.Textcolor = System.Drawing.Color.White
        Me.bt_kembali.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cb_status
        '
        Me.cb_status.BackColor = System.Drawing.Color.Honeydew
        Me.cb_status.FormattingEnabled = True
        Me.cb_status.Items.AddRange(New Object() {"KOSONG", "PENUH"})
        Me.cb_status.Location = New System.Drawing.Point(132, 295)
        Me.cb_status.Name = "cb_status"
        Me.cb_status.Size = New System.Drawing.Size(163, 21)
        Me.cb_status.TabIndex = 29
        '
        'tabel_kamar
        '
        Me.tabel_kamar.BackgroundColor = System.Drawing.Color.Turquoise
        Me.tabel_kamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Turquoise
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabel_kamar.DefaultCellStyle = DataGridViewCellStyle2
        Me.tabel_kamar.Location = New System.Drawing.Point(414, 102)
        Me.tabel_kamar.Name = "tabel_kamar"
        Me.tabel_kamar.Size = New System.Drawing.Size(365, 267)
        Me.tabel_kamar.TabIndex = 30
        '
        'bt_event
        '
        Me.bt_event.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_event.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_event.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_event.BorderRadius = 0
        Me.bt_event.ButtonText = "EVENT_TAHUNBARU"
        Me.bt_event.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bt_event.DisabledColor = System.Drawing.Color.Gray
        Me.bt_event.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_event.Iconcolor = System.Drawing.Color.Transparent
        Me.bt_event.Iconimage = Nothing
        Me.bt_event.Iconimage_right = Nothing
        Me.bt_event.Iconimage_right_Selected = Nothing
        Me.bt_event.Iconimage_Selected = Nothing
        Me.bt_event.IconMarginLeft = 0
        Me.bt_event.IconMarginRight = 0
        Me.bt_event.IconRightVisible = True
        Me.bt_event.IconRightZoom = 0.0R
        Me.bt_event.IconVisible = True
        Me.bt_event.IconZoom = 90.0R
        Me.bt_event.IsTab = False
        Me.bt_event.Location = New System.Drawing.Point(132, 375)
        Me.bt_event.Name = "bt_event"
        Me.bt_event.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_event.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_event.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_event.selected = False
        Me.bt_event.Size = New System.Drawing.Size(163, 24)
        Me.bt_event.TabIndex = 31
        Me.bt_event.Text = "EVENT_TAHUNBARU"
        Me.bt_event.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bt_event.Textcolor = System.Drawing.Color.White
        Me.bt_event.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tb_range_min
        '
        Me.tb_range_min.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_range_min.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_range_min.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_range_min.BorderThickness = 1
        Me.tb_range_min.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_range_min.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_range_min.ForeColor = System.Drawing.Color.Black
        Me.tb_range_min.isPassword = False
        Me.tb_range_min.Location = New System.Drawing.Point(132, 241)
        Me.tb_range_min.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_range_min.Name = "tb_range_min"
        Me.tb_range_min.Size = New System.Drawing.Size(105, 24)
        Me.tb_range_min.TabIndex = 33
        Me.tb_range_min.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(44, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "RANGE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(244, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "S/D"
        '
        'tb_range_max
        '
        Me.tb_range_max.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_range_max.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_range_max.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_range_max.BorderThickness = 1
        Me.tb_range_max.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_range_max.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_range_max.ForeColor = System.Drawing.Color.Black
        Me.tb_range_max.isPassword = False
        Me.tb_range_max.Location = New System.Drawing.Point(278, 241)
        Me.tb_range_max.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_range_max.Name = "tb_range_max"
        Me.tb_range_max.Size = New System.Drawing.Size(120, 24)
        Me.tb_range_max.TabIndex = 35
        Me.tb_range_max.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'KAMAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(804, 422)
        Me.Controls.Add(Me.tb_range_max)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tb_range_min)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bt_event)
        Me.Controls.Add(Me.tabel_kamar)
        Me.Controls.Add(Me.cb_status)
        Me.Controls.Add(Me.bt_kembali)
        Me.Controls.Add(Me.bt_hapus)
        Me.Controls.Add(Me.bt_simpan)
        Me.Controls.Add(Me.bt_cari)
        Me.Controls.Add(Me.tb_harga)
        Me.Controls.Add(Me.tb_idjenis)
        Me.Controls.Add(Me.tb_idkamar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "KAMAR"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tabel_kamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tb_idkamar As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_harga As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tb_idjenis As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents bt_cari As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bt_kembali As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bt_hapus As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bt_simpan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cb_status As System.Windows.Forms.ComboBox
    Friend WithEvents tabel_kamar As System.Windows.Forms.DataGridView
    Friend WithEvents bt_event As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents tb_range_max As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tb_range_min As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
