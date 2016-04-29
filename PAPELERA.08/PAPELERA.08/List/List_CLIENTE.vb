Public Class List_CLIENTE
    Private Class_Cliente As New Class_CLIENTE
    Private Sub List_CLIENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Class_Cliente.consultarTodos(dgv_CLIENTE)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frm_CLIENTE.accion = "Insertar"
        frm_CLIENTE.ShowDialog()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        frm_CLIENTE.accion = "Modificar"
        frm_CLIENTE.cliente = Class_Cliente
        frm_CLIENTE.ShowDialog()
    End Sub
    Private Sub dgv_CLIENTE_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_CLIENTE.CellClick
        Class_Cliente.id = dgv_CLIENTE.Item("ID_CLIENTE", dgv_CLIENTE.CurrentRow.Index).Value
        Class_Cliente.nombre = dgv_CLIENTE.Item("NOMBRE", dgv_CLIENTE.CurrentRow.Index).Value
        Class_Cliente.direccion = dgv_CLIENTE.Item("DIRECCION", dgv_CLIENTE.CurrentRow.Index).Value
        Class_Cliente.localidad = dgv_CLIENTE.Item("LOCALIDAD", dgv_CLIENTE.CurrentRow.Index).Value
        Class_Cliente.telefono_email = dgv_CLIENTE.Item("TELEFONO_EMAIL", dgv_CLIENTE.CurrentRow.Index).Value
        
    End Sub
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Class_Cliente.Borrar(dgv_CLIENTE.Item("ID_CLIENTE", dgv_CLIENTE.CurrentRow.Index).Value)
        Class_Cliente.consultarTodos(dgv_CLIENTE)
    End Sub
End Class
