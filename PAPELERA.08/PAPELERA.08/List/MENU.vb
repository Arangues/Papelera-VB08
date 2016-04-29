Public Class frm_menu
    Dim CLASS_CONEXION As New Class_Conexion
    Private Sub MENU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CLASS_CONEXION.conectar()
        CLASS_CONEXION.objConexion.Close()


    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        List_CLIENTE.Show()
    End Sub

    Private Sub ArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArticulosToolStripMenuItem.Click
        frm_ARTICULO.Show()
    End Sub
End Class