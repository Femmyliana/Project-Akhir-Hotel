<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UTAMA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UTAMA))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.kamar = New Bunifu.Framework.UI.BunifuTileButton()
        Me.jenis_kamar = New Bunifu.Framework.UI.BunifuTileButton()
        Me.makanan = New Bunifu.Framework.UI.BunifuTileButton()
        Me.minuman = New Bunifu.Framework.UI.BunifuTileButton()
        Me.pegawai = New Bunifu.Framework.UI.BunifuTileButton()
        Me.pesan_kamar = New Bunifu.Framework.UI.BunifuTileButton()
        Me.pelanggan = New Bunifu.Framework.UI.BunifuTileButton()
        Me.pembayaran = New Bunifu.Framework.UI.BunifuTileButton()
        Me.pesan_makan = New Bunifu.Framework.UI.BunifuTileButton()
        Me.pesan_minum = New Bunifu.Framework.UI.BunifuTileButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tutup = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
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
        Me.Label1.Location = New System.Drawing.Point(260, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ADMIN RESERVASI HOTEL"
        '
        'kamar
        '
        Me.kamar.BackColor = System.Drawing.Color.SeaGreen
        Me.kamar.color = System.Drawing.Color.SeaGreen
        Me.kamar.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.kamar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.kamar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kamar.ForeColor = System.Drawing.Color.White
        Me.kamar.Image = CType(resources.GetObject("kamar.Image"), System.Drawing.Image)
        Me.kamar.ImagePosition = 18
        Me.kamar.ImageZoom = 50
        Me.kamar.LabelPosition = 36
        Me.kamar.LabelText = "KAMAR"
        Me.kamar.Location = New System.Drawing.Point(44, 116)
        Me.kamar.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.kamar.Name = "kamar"
        Me.kamar.Size = New System.Drawing.Size(140, 123)
        Me.kamar.TabIndex = 1
        '
        'jenis_kamar
        '
        Me.jenis_kamar.AutoSize = True
        Me.jenis_kamar.BackColor = System.Drawing.Color.SeaGreen
        Me.jenis_kamar.color = System.Drawing.Color.SeaGreen
        Me.jenis_kamar.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.jenis_kamar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.jenis_kamar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jenis_kamar.ForeColor = System.Drawing.Color.White
        Me.jenis_kamar.Image = CType(resources.GetObject("jenis_kamar.Image"), System.Drawing.Image)
        Me.jenis_kamar.ImagePosition = 17
        Me.jenis_kamar.ImageZoom = 50
        Me.jenis_kamar.LabelPosition = 36
        Me.jenis_kamar.LabelText = "JENIS KAMAR"
        Me.jenis_kamar.Location = New System.Drawing.Point(193, 116)
        Me.jenis_kamar.Margin = New System.Windows.Forms.Padding(4)
        Me.jenis_kamar.Name = "jenis_kamar"
        Me.jenis_kamar.Size = New System.Drawing.Size(140, 123)
        Me.jenis_kamar.TabIndex = 2
        '
        'makanan
        '
        Me.makanan.BackColor = System.Drawing.Color.SeaGreen
        Me.makanan.color = System.Drawing.Color.SeaGreen
        Me.makanan.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.makanan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.makanan.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.makanan.ForeColor = System.Drawing.Color.White
        Me.makanan.Image = CType(resources.GetObject("makanan.Image"), System.Drawing.Image)
        Me.makanan.ImagePosition = 18
        Me.makanan.ImageZoom = 50
        Me.makanan.LabelPosition = 36
        Me.makanan.LabelText = "MAKANAN"
        Me.makanan.Location = New System.Drawing.Point(342, 116)
        Me.makanan.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.makanan.Name = "makanan"
        Me.makanan.Size = New System.Drawing.Size(139, 123)
        Me.makanan.TabIndex = 3
        '
        'minuman
        '
        Me.minuman.BackColor = System.Drawing.Color.SeaGreen
        Me.minuman.color = System.Drawing.Color.SeaGreen
        Me.minuman.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.minuman.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minuman.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minuman.ForeColor = System.Drawing.Color.White
        Me.minuman.Image = CType(resources.GetObject("minuman.Image"), System.Drawing.Image)
        Me.minuman.ImagePosition = 18
        Me.minuman.ImageZoom = 50
        Me.minuman.LabelPosition = 36
        Me.minuman.LabelText = "MINUMAN"
        Me.minuman.Location = New System.Drawing.Point(491, 116)
        Me.minuman.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.minuman.Name = "minuman"
        Me.minuman.Size = New System.Drawing.Size(132, 123)
        Me.minuman.TabIndex = 4
        '
        'pegawai
        '
        Me.pegawai.BackColor = System.Drawing.Color.SeaGreen
        Me.pegawai.color = System.Drawing.Color.SeaGreen
        Me.pegawai.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.pegawai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pegawai.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pegawai.ForeColor = System.Drawing.Color.White
        Me.pegawai.Image = CType(resources.GetObject("pegawai.Image"), System.Drawing.Image)
        Me.pegawai.ImagePosition = 18
        Me.pegawai.ImageZoom = 50
        Me.pegawai.LabelPosition = 36
        Me.pegawai.LabelText = "PEGAWAI"
        Me.pegawai.Location = New System.Drawing.Point(633, 116)
        Me.pegawai.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.pegawai.Name = "pegawai"
        Me.pegawai.Size = New System.Drawing.Size(136, 123)
        Me.pegawai.TabIndex = 5
        '
        'pesan_kamar
        '
        Me.pesan_kamar.BackColor = System.Drawing.Color.SeaGreen
        Me.pesan_kamar.color = System.Drawing.Color.SeaGreen
        Me.pesan_kamar.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.pesan_kamar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pesan_kamar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pesan_kamar.ForeColor = System.Drawing.Color.White
        Me.pesan_kamar.Image = CType(resources.GetObject("pesan_kamar.Image"), System.Drawing.Image)
        Me.pesan_kamar.ImagePosition = 18
        Me.pesan_kamar.ImageZoom = 50
        Me.pesan_kamar.LabelPosition = 36
        Me.pesan_kamar.LabelText = "PESAN KAMAR"
        Me.pesan_kamar.Location = New System.Drawing.Point(343, 266)
        Me.pesan_kamar.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.pesan_kamar.Name = "pesan_kamar"
        Me.pesan_kamar.Size = New System.Drawing.Size(138, 117)
        Me.pesan_kamar.TabIndex = 8
        '
        'pelanggan
        '
        Me.pelanggan.AutoSize = True
        Me.pelanggan.BackColor = System.Drawing.Color.SeaGreen
        Me.pelanggan.color = System.Drawing.Color.SeaGreen
        Me.pelanggan.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.pelanggan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pelanggan.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pelanggan.ForeColor = System.Drawing.Color.White
        Me.pelanggan.Image = CType(resources.GetObject("pelanggan.Image"), System.Drawing.Image)
        Me.pelanggan.ImagePosition = 18
        Me.pelanggan.ImageZoom = 50
        Me.pelanggan.LabelPosition = 36
        Me.pelanggan.LabelText = "PELANGGAN"
        Me.pelanggan.Location = New System.Drawing.Point(45, 266)
        Me.pelanggan.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.pelanggan.Name = "pelanggan"
        Me.pelanggan.Size = New System.Drawing.Size(139, 117)
        Me.pelanggan.TabIndex = 9
        '
        'pembayaran
        '
        Me.pembayaran.BackColor = System.Drawing.Color.SeaGreen
        Me.pembayaran.color = System.Drawing.Color.SeaGreen
        Me.pembayaran.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.pembayaran.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pembayaran.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pembayaran.ForeColor = System.Drawing.Color.White
        Me.pembayaran.Image = CType(resources.GetObject("pembayaran.Image"), System.Drawing.Image)
        Me.pembayaran.ImagePosition = 18
        Me.pembayaran.ImageZoom = 50
        Me.pembayaran.LabelPosition = 36
        Me.pembayaran.LabelText = "PEMBAYARAN"
        Me.pembayaran.Location = New System.Drawing.Point(194, 266)
        Me.pembayaran.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.pembayaran.Name = "pembayaran"
        Me.pembayaran.Size = New System.Drawing.Size(139, 117)
        Me.pembayaran.TabIndex = 10
        '
        'pesan_makan
        '
        Me.pesan_makan.AutoSize = True
        Me.pesan_makan.BackColor = System.Drawing.Color.SeaGreen
        Me.pesan_makan.color = System.Drawing.Color.SeaGreen
        Me.pesan_makan.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.pesan_makan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pesan_makan.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pesan_makan.ForeColor = System.Drawing.Color.White
        Me.pesan_makan.Image = CType(resources.GetObject("pesan_makan.Image"), System.Drawing.Image)
        Me.pesan_makan.ImagePosition = 18
        Me.pesan_makan.ImageZoom = 50
        Me.pesan_makan.LabelPosition = 36
        Me.pesan_makan.LabelText = "PESAN MAKAN"
        Me.pesan_makan.Location = New System.Drawing.Point(491, 266)
        Me.pesan_makan.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.pesan_makan.Name = "pesan_makan"
        Me.pesan_makan.Size = New System.Drawing.Size(132, 117)
        Me.pesan_makan.TabIndex = 11
        '
        'pesan_minum
        '
        Me.pesan_minum.BackColor = System.Drawing.Color.SeaGreen
        Me.pesan_minum.color = System.Drawing.Color.SeaGreen
        Me.pesan_minum.colorActive = System.Drawing.Color.MediumSeaGreen
        Me.pesan_minum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pesan_minum.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pesan_minum.ForeColor = System.Drawing.Color.White
        Me.pesan_minum.Image = CType(resources.GetObject("pesan_minum.Image"), System.Drawing.Image)
        Me.pesan_minum.ImagePosition = 18
        Me.pesan_minum.ImageZoom = 50
        Me.pesan_minum.LabelPosition = 36
        Me.pesan_minum.LabelText = "PESAN MINUM"
        Me.pesan_minum.Location = New System.Drawing.Point(633, 266)
        Me.pesan_minum.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.pesan_minum.Name = "pesan_minum"
        Me.pesan_minum.Size = New System.Drawing.Size(136, 117)
        Me.pesan_minum.TabIndex = 12
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel1.Controls.Add(Me.tutup)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 25)
        Me.Panel1.TabIndex = 13
        '
        'tutup
        '
        Me.tutup.AutoSize = True
        Me.tutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tutup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tutup.Location = New System.Drawing.Point(781, 0)
        Me.tutup.Name = "tutup"
        Me.tutup.Size = New System.Drawing.Size(20, 20)
        Me.tutup.TabIndex = 15
        Me.tutup.Text = "X"
        '
        'UTAMA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Turquoise
        Me.ClientSize = New System.Drawing.Size(804, 422)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pesan_minum)
        Me.Controls.Add(Me.pesan_makan)
        Me.Controls.Add(Me.pembayaran)
        Me.Controls.Add(Me.pelanggan)
        Me.Controls.Add(Me.pesan_kamar)
        Me.Controls.Add(Me.pegawai)
        Me.Controls.Add(Me.minuman)
        Me.Controls.Add(Me.makanan)
        Me.Controls.Add(Me.jenis_kamar)
        Me.Controls.Add(Me.kamar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UTAMA"
        Me.Text = "UTAMA"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents pesan_minum As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents pesan_makan As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents pembayaran As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents pelanggan As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents pesan_kamar As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents pegawai As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents minuman As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents makanan As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents jenis_kamar As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents kamar As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tutup As System.Windows.Forms.Label

End Class
