Public Class frm_CLIENTE
    Private Class_Conexion As New Class_Conexion
    Private Accion_ As String
    Private cliente_ As New Class_CLIENTE
    Public Property cliente() As Class_CLIENTE
        Get
            Return cliente_
        End Get
        Set(ByVal value As Class_CLIENTE)
            cliente_ = value
        End Set
    End Property

    Public Property accion() As String
        Get
            Return Accion_
        End Get
        Set(ByVal value As String)
            Accion_ = value
        End Set
    End Property


    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub


    Private Sub frmCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If accion = "Insertar" Then
            Me.Text = "Agregar_Cliente"
            txt_nombre.Text = ""
            txt_direccion.Text = ""
            txt_localidad.Text = ""
            txt_numero_email.Text = ""
        Else
            Me.Text = "Modificar Cliente"
            txt_id.Text = cliente.id
            txt_nombre.Text = cliente.nombre
            txt_direccion.Text = cliente.direccion
            txt_localidad.Text = cliente.localidad
            txt_numero_email.Text = cliente.telefono_email
        End If
    End Sub

    Private Sub Aceptar_Click(sender As Object, e As EventArgs) Handles Aceptar.Click

        Dim pregunta As DialogResult = MsgBox("¿ Desea realizar las moficaciones al ciente n°" & " " & CStr(txt_id.Text) & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Modificar registro")
        cliente.nombre = txt_nombre.Text
        cliente.direccion = txt_direccion.Text
        cliente.localidad = txt_localidad.Text
        cliente.telefono_email = txt_numero_email.Text

        If accion = "Insertar" Then
            cliente.Insertar(cliente)
        Else
            cliente.id = txt_id.Text
            cliente.Modificar(cliente)
        End If
        cliente.consultarTodos(List_CLIENTE.dgv_CLIENTE)
        Class_Conexion.objConexion.Close()
        Me.Close()
    End Sub
End Class

