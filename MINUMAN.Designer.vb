﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MINUMAN
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabel_minuman = New System.Windows.Forms.DataGridView()
        Me.bt_kembali = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bt_hapus = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bt_simpan = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.bt_cari = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.tb_harga = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tb_menu = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.tb_idminuman = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.atur_ulang = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.tabel_minuman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabel_minuman
        '
        Me.tabel_minuman.BackgroundColor = System.Drawing.Color.Turquoise
        Me.tabel_minuman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Turquoise
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tabel_minuman.DefaultCellStyle = DataGridViewCellStyle6
        Me.tabel_minuman.Location = New System.Drawing.Point(411, 89)
        Me.tabel_minuman.Name = "tabel_minuman"
        Me.tabel_minuman.Size = New System.Drawing.Size(365, 267)
        Me.tabel_minuman.TabIndex = 45
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
        Me.bt_kembali.Location = New System.Drawing.Point(331, 243)
        Me.bt_kembali.Name = "bt_kembali"
        Me.bt_kembali.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_kembali.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_kembali.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_kembali.selected = False
        Me.bt_kembali.Size = New System.Drawing.Size(74, 24)
        Me.bt_kembali.TabIndex = 44
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
        Me.bt_hapus.Location = New System.Drawing.Point(239, 243)
        Me.bt_hapus.Name = "bt_hapus"
        Me.bt_hapus.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_hapus.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_hapus.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_hapus.selected = False
        Me.bt_hapus.Size = New System.Drawing.Size(74, 24)
        Me.bt_hapus.TabIndex = 43
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
        Me.bt_simpan.Location = New System.Drawing.Point(150, 243)
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
        Me.bt_cari.Location = New System.Drawing.Point(331, 103)
        Me.bt_cari.Name = "bt_cari"
        Me.bt_cari.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.bt_cari.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bt_cari.OnHoverTextColor = System.Drawing.Color.White
        Me.bt_cari.selected = False
        Me.bt_cari.Size = New System.Drawing.Size(74, 24)
        Me.bt_cari.TabIndex = 41
        Me.bt_cari.Text = "Cari"
        Me.bt_cari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.bt_cari.Textcolor = System.Drawing.Color.White
        Me.bt_cari.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.tb_harga.Location = New System.Drawing.Point(150, 193)
        Me.tb_harga.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_harga.Name = "tb_harga"
        Me.tb_harga.Size = New System.Drawing.Size(163, 23)
        Me.tb_harga.TabIndex = 40
        Me.tb_harga.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_menu
        '
        Me.tb_menu.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_menu.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_menu.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_menu.BorderThickness = 1
        Me.tb_menu.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_menu.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_menu.ForeColor = System.Drawing.Color.Black
        Me.tb_menu.isPassword = False
        Me.tb_menu.Location = New System.Drawing.Point(150, 147)
        Me.tb_menu.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tb_menu.Name = "tb_menu"
        Me.tb_menu.Size = New System.Drawing.Size(163, 23)
        Me.tb_menu.TabIndex = 39
        Me.tb_menu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tb_idminuman
        '
        Me.tb_idminuman.BorderColorFocused = System.Drawing.Color.DarkCyan
        Me.tb_idminuman.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_idminuman.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.tb_idminuman.BorderThickness = 1
        Me.tb_idminuman.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_idminuman.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_idminuman.ForeColor = System.Drawing.Color.Black
        Me.tb_idminuman.isPassword = False
        Me.tb_idminuman.Location = New System.Drawing.Point(150, 103)
        Me.tb_idminuman.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_idminuman.Name = "tb_idminuman"
        Me.tb_idminuman.Size = New System.Drawing.Size(163, 24)
        Me.tb_idminuman.TabIndex = 38
        Me.tb_idminuman.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "HARGA MINUMAN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "MENU MINUMAN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "ID MINUMAN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(326, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 28)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "MINUMAN"
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
        Me.atur_ulang.Location = New System.Drawing.Point(673, 48)
        Me.atur_ulang.Name = "atur_ulang"
        Me.atur_ulang.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.atur_ulang.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.atur_ulang.OnHoverTextColor = System.Drawing.Color.White
        Me.atur_ulang.selected = False
        Me.atur_ulang.Size = New System.Drawing.Size(103, 24)
        Me.atur_ulang.TabIndex = 51
        Me.atur_ulang.Text = "ATUR ULANG"
        Me.atur_ulang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.atur_ulang.Textcolor = System.Drawing.Color.White
        Me.atur_ulang.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MINUMAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 383)
        Me.Controls.Add(Me.atur_ulang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tabel_minuman)
        Me.Controls.Add(Me.bt_kembali)
        Me.Controls.Add(Me.bt_hapus)
        Me.Controls.Add(Me.bt_simpan)
        Me.Controls.Add(Me.bt_cari)
        Me.Controls.Add(Me.tb_harga)
        Me.Controls.Add(Me.tb_menu)
        Me.Controls.Add(Me.tb_idminuman)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "MINUMAN"
        Me.Text = "Form1"
        CType(Me.tabel_minuman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabel_minuman As System.Windows.Forms.DataGridView
    Friend WithEvents bt_kembali As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bt_hapus As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bt_simpan As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents bt_cari As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents tb_harga As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tb_menu As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents tb_idminuman As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents atur_ulang As Bunifu.Framework.UI.BunifuFlatButton
End Class
