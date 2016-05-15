<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CLIENTE
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
        Me.txt_nombre = New System.Windows.Forms.TextBox
        Me.txt_direccion = New System.Windows.Forms.TextBox
        Me.txt_localidad = New System.Windows.Forms.TextBox
        Me.txt_numero_email = New System.Windows.Forms.TextBox
        Me.Aceptar = New System.Windows.Forms.Button
        Me.Cancelar = New System.Windows.Forms.Button
        Me.txt_id = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(91, 42)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(211, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(91, 68)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(211, 20)
        Me.txt_direccion.TabIndex = 1
        '
        'txt_localidad
        '
        Me.txt_localidad.Location = New System.Drawing.Point(91, 94)
        Me.txt_localidad.Name = "txt_localidad"
        Me.txt_localidad.Size = New System.Drawing.Size(211, 20)
        Me.txt_localidad.TabIndex = 2
        '
        'txt_numero_email
        '
        Me.txt_numero_email.Location = New System.Drawing.Point(91, 120)
        Me.txt_numero_email.Name = "txt_numero_email"
        Me.txt_numero_email.Size = New System.Drawing.Size(211, 20)
        Me.txt_numero_email.TabIndex = 3
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(146, 159)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 4
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(227, 159)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Cancelar.TabIndex = 5
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(91, 12)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(89, 20)
        Me.txt_id.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Direccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Localidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Email - Tel"
        '
        'frm_CLIENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 196)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.txt_numero_email)
        Me.Controls.Add(Me.txt_localidad)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.txt_nombre)
        Me.Name = "frm_CLIENTE"
        Me.Text = "CLIENTE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents txt_localidad As System.Windows.Forms.TextBox
    Friend WithEvents txt_numero_email As System.Windows.Forms.TextBox
    Friend WithEvents Aceptar As System.Windows.Forms.Button
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
