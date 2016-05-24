Public Class frm_menu
    Dim CLASS_CONEXION As New Class_Conexion
    Private Sub MENU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CLASS_CONEXION.conectar()



    End Sub

    Private Sub ClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        List_CLIENTE.Show()
    End Sub

    Private Sub ArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArticulosToolStripMenuItem.Click
        frm_ARTICULO.Show()
    End Sub

    Private Sub FacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasToolStripMenuItem.Click
        frm_Factura.Show()
        CLASS_CONEXION.objConexion.Close()
    End Sub
End Class