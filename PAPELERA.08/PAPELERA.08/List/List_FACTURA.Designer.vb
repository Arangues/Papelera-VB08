<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Factura
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
        Me.dgv_detalles = New System.Windows.Forms.DataGridView
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgv_facturas_prod = New System.Windows.Forms.DataGridView
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TXT_BUSCAR_CODIGO = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_buscar_nombre = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txt_pago_con = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_vuelto = New System.Windows.Forms.TextBox
        Me.txt_Pagar = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmb_Cobrar = New System.Windows.Forms.Button
        Me.txt_preciov_art = New System.Windows.Forms.TextBox
        Me.txt_nombre_art = New System.Windows.Forms.TextBox
        Me.txt_codigo_art = New System.Windows.Forms.TextBox
        Me.txt_cantidad = New System.Windows.Forms.TextBox
        Me.cmb_Agregar = New System.Windows.Forms.Button
        Me.cmb_Eliminar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        CType(Me.dgv_detalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_facturas_prod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_detalles
        '
        Me.dgv_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Nombre, Me.Precio, Me.Cantidad, Me.Subtotal})
        Me.dgv_detalles.Location = New System.Drawing.Point(10, 19)
        Me.dgv_detalles.Name = "dgv_detalles"
        Me.dgv_detalles.Size = New System.Drawing.Size(576, 228)
        Me.dgv_detalles.TabIndex = 0
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ToolTipText = "1"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Subtotal
        '
        Me.Subtotal.HeaderText = "Subtotal"
        Me.Subtotal.Name = "Subtotal"
        '
        'dgv_facturas_prod
        '
        Me.dgv_facturas_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_facturas_prod.Location = New System.Drawing.Point(610, 67)
        Me.dgv_facturas_prod.Name = "dgv_facturas_prod"
        Me.dgv_facturas_prod.ReadOnly = True
        Me.dgv_facturas_prod.Size = New System.Drawing.Size(339, 242)
        Me.dgv_facturas_prod.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Codigo del cliente"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(105, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(105, 49)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(178, 20)
        Me.TextBox2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(21, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre cliente"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(81, 45)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(17, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "N° Factura"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(81, 19)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(17, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Fecha"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(673, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 15)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Buscar por codigo"
        '
        'TXT_BUSCAR_CODIGO
        '
        Me.TXT_BUSCAR_CODIGO.Location = New System.Drawing.Point(774, 38)
        Me.TXT_BUSCAR_CODIGO.Name = "TXT_BUSCAR_CODIGO"
        Me.TXT_BUSCAR_CODIGO.Size = New System.Drawing.Size(138, 20)
        Me.TXT_BUSCAR_CODIGO.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Window
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(670, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 15)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Buscar por nombre"
        '
        'txt_buscar_nombre
        '
        Me.txt_buscar_nombre.Location = New System.Drawing.Point(774, 12)
        Me.txt_buscar_nombre.Name = "txt_buscar_nombre"
        Me.txt_buscar_nombre.Size = New System.Drawing.Size(138, 20)
        Me.txt_buscar_nombre.TabIndex = 27
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(12, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(334, 88)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cliente"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextBox9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TextBox8)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(334, 88)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos factura"
        '
        'txt_pago_con
        '
        Me.txt_pago_con.Location = New System.Drawing.Point(673, 315)
        Me.txt_pago_con.Name = "txt_pago_con"
        Me.txt_pago_con.Size = New System.Drawing.Size(100, 20)
        Me.txt_pago_con.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(788, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Devolver"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(609, 318)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Pagon con"
        '
        'txt_vuelto
        '
        Me.txt_vuelto.Location = New System.Drawing.Point(848, 315)
        Me.txt_vuelto.Name = "txt_vuelto"
        Me.txt_vuelto.Size = New System.Drawing.Size(100, 20)
        Me.txt_vuelto.TabIndex = 38
        '
        'txt_Pagar
        '
        Me.txt_Pagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Pagar.Font = New System.Drawing.Font("Impact", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Pagar.Location = New System.Drawing.Point(792, 365)
        Me.txt_Pagar.Multiline = True
        Me.txt_Pagar.Name = "txt_Pagar"
        Me.txt_Pagar.Size = New System.Drawing.Size(108, 39)
        Me.txt_Pagar.TabIndex = 40
        Me.txt_Pagar.Text = "0,00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Cursor = System.Windows.Forms.Cursors.No
        Me.Label13.Font = New System.Drawing.Font("Impact", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(610, 370)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(176, 34)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Neto a pagar $"
        '
        'cmb_Cobrar
        '
        Me.cmb_Cobrar.Location = New System.Drawing.Point(681, 417)
        Me.cmb_Cobrar.Name = "cmb_Cobrar"
        Me.cmb_Cobrar.Size = New System.Drawing.Size(158, 36)
        Me.cmb_Cobrar.TabIndex = 41
        Me.cmb_Cobrar.Text = "Cobrar"
        Me.cmb_Cobrar.UseVisualStyleBackColor = True
        '
        'txt_preciov_art
        '
        Me.txt_preciov_art.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_preciov_art.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_preciov_art.Location = New System.Drawing.Point(70, 81)
        Me.txt_preciov_art.Name = "txt_preciov_art"
        Me.txt_preciov_art.ReadOnly = True
        Me.txt_preciov_art.Size = New System.Drawing.Size(160, 23)
        Me.txt_preciov_art.TabIndex = 13
        '
        'txt_nombre_art
        '
        Me.txt_nombre_art.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_nombre_art.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nombre_art.Location = New System.Drawing.Point(70, 55)
        Me.txt_nombre_art.Name = "txt_nombre_art"
        Me.txt_nombre_art.ReadOnly = True
        Me.txt_nombre_art.Size = New System.Drawing.Size(160, 23)
        Me.txt_nombre_art.TabIndex = 9
        '
        'txt_codigo_art
        '
        Me.txt_codigo_art.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_codigo_art.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_codigo_art.Location = New System.Drawing.Point(70, 29)
        Me.txt_codigo_art.Name = "txt_codigo_art"
        Me.txt_codigo_art.ReadOnly = True
        Me.txt_codigo_art.Size = New System.Drawing.Size(160, 23)
        Me.txt_codigo_art.TabIndex = 7
        '
        'txt_cantidad
        '
        Me.txt_cantidad.BackColor = System.Drawing.Color.AntiqueWhite
        Me.txt_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad.Location = New System.Drawing.Point(70, 110)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(160, 23)
        Me.txt_cantidad.TabIndex = 15
        '
        'cmb_Agregar
        '
        Me.cmb_Agregar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmb_Agregar.Location = New System.Drawing.Point(40, 156)
        Me.cmb_Agregar.Name = "cmb_Agregar"
        Me.cmb_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.cmb_Agregar.TabIndex = 16
        Me.cmb_Agregar.Text = "Agregar"
        Me.cmb_Agregar.UseVisualStyleBackColor = True
        '
        'cmb_Eliminar
        '
        Me.cmb_Eliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmb_Eliminar.Location = New System.Drawing.Point(121, 156)
        Me.cmb_Eliminar.Name = "cmb_Eliminar"
        Me.cmb_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.cmb_Eliminar.TabIndex = 17
        Me.cmb_Eliminar.Text = "Eliminar"
        Me.cmb_Eliminar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(24, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Codigo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(20, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(27, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Precio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(20, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Cantidad"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmb_Eliminar)
        Me.GroupBox1.Controls.Add(Me.txt_cantidad)
        Me.GroupBox1.Controls.Add(Me.cmb_Agregar)
        Me.GroupBox1.Controls.Add(Me.txt_codigo_art)
        Me.GroupBox1.Controls.Add(Me.txt_nombre_art)
        Me.GroupBox1.Controls.Add(Me.txt_preciov_art)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(352, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 195)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Articulos"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgv_detalles)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 213)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(592, 258)
        Me.GroupBox4.TabIndex = 34
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle factura"
        '
        'frm_Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(961, 480)
        Me.Controls.Add(Me.cmb_Cobrar)
        Me.Controls.Add(Me.txt_Pagar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_pago_con)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_vuelto)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TXT_BUSCAR_CODIGO)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_buscar_nombre)
        Me.Controls.Add(Me.dgv_facturas_prod)
        Me.Name = "frm_Factura"
        Me.Text = "FACTURA"
        CType(Me.dgv_detalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_facturas_prod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_detalles As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_facturas_prod As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXT_BUSCAR_CODIGO As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_buscar_nombre As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_pago_con As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_vuelto As System.Windows.Forms.TextBox
    Friend WithEvents txt_Pagar As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmb_Cobrar As System.Windows.Forms.Button
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_preciov_art As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_art As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo_art As System.Windows.Forms.TextBox
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents cmb_Agregar As System.Windows.Forms.Button
    Friend WithEvents cmb_Eliminar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
End Class
