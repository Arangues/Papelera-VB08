<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ARTICULO
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dvg_ARTICULOS = New System.Windows.Forms.DataGridView()
        Me.cmb_agregar = New System.Windows.Forms.Button()
        Me.cmb_Eliminar = New System.Windows.Forms.Button()
        Me.cmb_modificar = New System.Windows.Forms.Button()
        Me.txt_COD_BARRAS = New System.Windows.Forms.TextBox()
        Me.comb_CF_CATEGORIA = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_PRECIO_UNITARIO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_PRECIO_VENTA = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_STOCK = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_STOCK_MIN = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_STOCK_MAX = New System.Windows.Forms.TextBox()
        Me.txt_buscar_nombre = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_BUSCAR_CODIGO = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Funsiones = New System.Windows.Forms.GroupBox()
        Me.Limpiar = New System.Windows.Forms.Button()
        CType(Me.dvg_ARTICULOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Funsiones.SuspendLayout()
        Me.SuspendLayout()
        '
        'dvg_ARTICULOS
        '
        Me.dvg_ARTICULOS.AllowUserToOrderColumns = True
        Me.dvg_ARTICULOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvg_ARTICULOS.Location = New System.Drawing.Point(299, 56)
        Me.dvg_ARTICULOS.Name = "dvg_ARTICULOS"
        Me.dvg_ARTICULOS.ReadOnly = True
        Me.dvg_ARTICULOS.Size = New System.Drawing.Size(956, 265)
        Me.dvg_ARTICULOS.TabIndex = 0
        '
        'cmb_agregar
        '
        Me.cmb_agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_agregar.Location = New System.Drawing.Point(8, 19)
        Me.cmb_agregar.Name = "cmb_agregar"
        Me.cmb_agregar.Size = New System.Drawing.Size(75, 23)
        Me.cmb_agregar.TabIndex = 2
        Me.cmb_agregar.Text = "Agregar"
        Me.cmb_agregar.UseVisualStyleBackColor = True
        '
        'cmb_Eliminar
        '
        Me.cmb_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_Eliminar.Location = New System.Drawing.Point(200, 19)
        Me.cmb_Eliminar.Name = "cmb_Eliminar"
        Me.cmb_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmb_Eliminar.TabIndex = 5
        Me.cmb_Eliminar.Text = "Eliminar"
        Me.cmb_Eliminar.UseVisualStyleBackColor = True
        '
        'cmb_modificar
        '
        Me.cmb_modificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_modificar.Location = New System.Drawing.Point(100, 19)
        Me.cmb_modificar.Name = "cmb_modificar"
        Me.cmb_modificar.Size = New System.Drawing.Size(75, 23)
        Me.cmb_modificar.TabIndex = 4
        Me.cmb_modificar.Text = "Modificar"
        Me.cmb_modificar.UseVisualStyleBackColor = True
        '
        'txt_COD_BARRAS
        '
        Me.txt_COD_BARRAS.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_COD_BARRAS.Location = New System.Drawing.Point(92, 105)
        Me.txt_COD_BARRAS.Name = "txt_COD_BARRAS"
        Me.txt_COD_BARRAS.Size = New System.Drawing.Size(86, 20)
        Me.txt_COD_BARRAS.TabIndex = 6
        '
        'comb_CF_CATEGORIA
        '
        Me.comb_CF_CATEGORIA.FormattingEnabled = True
        Me.comb_CF_CATEGORIA.Location = New System.Drawing.Point(92, 156)
        Me.comb_CF_CATEGORIA.Name = "comb_CF_CATEGORIA"
        Me.comb_CF_CATEGORIA.Size = New System.Drawing.Size(186, 21)
        Me.comb_CF_CATEGORIA.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(30, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Cod.Barra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(40, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nombre"
        '
        'txt_NOMBRE
        '
        Me.txt_NOMBRE.Location = New System.Drawing.Point(92, 131)
        Me.txt_NOMBRE.Name = "txt_NOMBRE"
        Me.txt_NOMBRE.Size = New System.Drawing.Size(186, 20)
        Me.txt_NOMBRE.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(32, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Categoria"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(12, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Precio Unitario"
        '
        'txt_PRECIO_UNITARIO
        '
        Me.txt_PRECIO_UNITARIO.Location = New System.Drawing.Point(92, 183)
        Me.txt_PRECIO_UNITARIO.Name = "txt_PRECIO_UNITARIO"
        Me.txt_PRECIO_UNITARIO.Size = New System.Drawing.Size(86, 20)
        Me.txt_PRECIO_UNITARIO.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(19, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Precio Venta"
        '
        'txt_PRECIO_VENTA
        '
        Me.txt_PRECIO_VENTA.Location = New System.Drawing.Point(92, 209)
        Me.txt_PRECIO_VENTA.Name = "txt_PRECIO_VENTA"
        Me.txt_PRECIO_VENTA.Size = New System.Drawing.Size(86, 20)
        Me.txt_PRECIO_VENTA.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(49, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Stock"
        '
        'txt_STOCK
        '
        Me.txt_STOCK.Location = New System.Drawing.Point(92, 235)
        Me.txt_STOCK.Name = "txt_STOCK"
        Me.txt_STOCK.Size = New System.Drawing.Size(86, 20)
        Me.txt_STOCK.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(30, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 15)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Stock Min"
        '
        'txt_STOCK_MIN
        '
        Me.txt_STOCK_MIN.Location = New System.Drawing.Point(92, 261)
        Me.txt_STOCK_MIN.Name = "txt_STOCK_MIN"
        Me.txt_STOCK_MIN.Size = New System.Drawing.Size(86, 20)
        Me.txt_STOCK_MIN.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(30, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 15)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Stock Max"
        '
        'txt_STOCK_MAX
        '
        Me.txt_STOCK_MAX.Location = New System.Drawing.Point(92, 287)
        Me.txt_STOCK_MAX.Name = "txt_STOCK_MAX"
        Me.txt_STOCK_MAX.Size = New System.Drawing.Size(86, 20)
        Me.txt_STOCK_MAX.TabIndex = 21
        '
        'txt_buscar_nombre
        '
        Me.txt_buscar_nombre.Location = New System.Drawing.Point(463, 33)
        Me.txt_buscar_nombre.Name = "txt_buscar_nombre"
        Me.txt_buscar_nombre.Size = New System.Drawing.Size(247, 20)
        Me.txt_buscar_nombre.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(359, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 15)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Buscar por nombre"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(725, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 15)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Buscar por codigo"
        '
        'TXT_BUSCAR_CODIGO
        '
        Me.TXT_BUSCAR_CODIGO.Location = New System.Drawing.Point(826, 33)
        Me.TXT_BUSCAR_CODIGO.Name = "TXT_BUSCAR_CODIGO"
        Me.TXT_BUSCAR_CODIGO.Size = New System.Drawing.Size(247, 20)
        Me.TXT_BUSCAR_CODIGO.TabIndex = 25
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoriasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1267, 24)
        Me.MenuStrip1.TabIndex = 27
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.CategoriasToolStripMenuItem.Text = "Categorias"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(68, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 15)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Id"
        '
        'txt_id
        '
        Me.txt_id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_id.Location = New System.Drawing.Point(92, 79)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(86, 20)
        Me.txt_id.TabIndex = 28
        '
        'Funsiones
        '
        Me.Funsiones.Controls.Add(Me.cmb_modificar)
        Me.Funsiones.Controls.Add(Me.cmb_agregar)
        Me.Funsiones.Controls.Add(Me.cmb_Eliminar)
        Me.Funsiones.Location = New System.Drawing.Point(12, 24)
        Me.Funsiones.Name = "Funsiones"
        Me.Funsiones.Size = New System.Drawing.Size(281, 52)
        Me.Funsiones.TabIndex = 31
        Me.Funsiones.TabStop = False
        Me.Funsiones.Text = "Funsiones"
        '
        'Limpiar
        '
        Me.Limpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Limpiar.Location = New System.Drawing.Point(203, 299)
        Me.Limpiar.Name = "Limpiar"
        Me.Limpiar.Size = New System.Drawing.Size(75, 23)
        Me.Limpiar.TabIndex = 32
        Me.Limpiar.Text = "Limpiar"
        Me.Limpiar.UseVisualStyleBackColor = True
        '
        'frm_ARTICULO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1267, 334)
        Me.Controls.Add(Me.Limpiar)
        Me.Controls.Add(Me.Funsiones)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TXT_BUSCAR_CODIGO)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_buscar_nombre)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_STOCK_MAX)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_STOCK_MIN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_STOCK)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_PRECIO_VENTA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_PRECIO_UNITARIO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_NOMBRE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comb_CF_CATEGORIA)
        Me.Controls.Add(Me.txt_COD_BARRAS)
        Me.Controls.Add(Me.dvg_ARTICULOS)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_ARTICULO"
        Me.Text = "ARTICULO"
        CType(Me.dvg_ARTICULOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Funsiones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dvg_ARTICULOS As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_agregar As System.Windows.Forms.Button
    Friend WithEvents cmb_Eliminar As System.Windows.Forms.Button
    Friend WithEvents cmb_modificar As System.Windows.Forms.Button
    Friend WithEvents txt_COD_BARRAS As System.Windows.Forms.TextBox
    Friend WithEvents comb_CF_CATEGORIA As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_PRECIO_UNITARIO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_PRECIO_VENTA As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_STOCK As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_STOCK_MIN As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_STOCK_MAX As System.Windows.Forms.TextBox
    Friend WithEvents txt_buscar_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXT_BUSCAR_CODIGO As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CategoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Funsiones As System.Windows.Forms.GroupBox
    Friend WithEvents Limpiar As System.Windows.Forms.Button
End Class
