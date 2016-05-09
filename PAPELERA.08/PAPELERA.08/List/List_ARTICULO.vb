Imports System.Data.SqlClient
Public Class frm_ARTICULO
    Dim M_borrar, verificar As New Metodos
    Dim Class_conexion As New Class_Conexion
    Dim Class_Articulo As New Class_Articulos
    Dim accion_ As String


    Public Property articulo() As Class_Articulos
        Get
            Return Class_Articulo
        End Get
        Set(ByVal value As Class_Articulos)
            Class_Articulo = value
        End Set
    End Property

    Public Property accion() As String
        Get
            Return accion_
        End Get
        Set(ByVal value As String)
            accion_ = value
        End Set
    End Property
    Public Property borrar() As Metodos
        Get
            Return M_borrar
        End Get
        Set(ByVal value As Metodos)
            M_borrar = value
        End Set
    End Property


    Private Sub frm_ARTICULO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Class_Articulo.consultarTodos(dvg_ARTICULOS)
    End Sub
    Private Sub txt_buscar_nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_buscar_nombre.TextChanged

        Dim buscar As New SqlDataAdapter("select * from ARTICULOS where NOMBRE like '%" + txt_buscar_nombre.Text + "%'", Class_conexion.objConexion)
        Dim ds As New DataSet()
        buscar.Fill(ds, "ARTICULOS")
        dvg_ARTICULOS.DataSource = ds.Tables(0)

    End Sub

    Private Sub TXT_BUSCAR_CODIGO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_BUSCAR_CODIGO.TextChanged
        Dim buscar As New SqlDataAdapter("select * from ARTICULOS where COD_BARRAS like '%" + TXT_BUSCAR_CODIGO.Text + "%'", Class_conexion.objConexion)
        Dim ds As New DataSet()
        buscar.Fill(ds, "ARTICULOS")
        dvg_ARTICULOS.DataSource = ds.Tables(0)
    End Sub

    Private Sub cmb_agregar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_agregar.Click
        If txt_COD_BARRAS.Text = "" Or txt_NOMBRE.Text = "" Or comb_CF_CATEGORIA.Text = "" Or txt_PRECIO_UNITARIO.Text = "" Or txt_PRECIO_VENTA.Text = "" Or txt_STOCK.Text = "" Or txt_STOCK_MIN.Text = "" Or txt_STOCK_MAX.Text = "" Then
            MsgBox("Hay campos vacios")
            Exit Sub
        Else
            Dim pregunta As DialogResult = MsgBox("Se agregara un articulo", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "registro")
            Class_Articulo.codigo = txt_COD_BARRAS.Text
            Class_Articulo.nombre = txt_NOMBRE.Text
            Class_Articulo.categoria = comb_CF_CATEGORIA.Text
            Class_Articulo.precio_unitario = txt_PRECIO_UNITARIO.Text
            Class_Articulo.precio_venta = txt_PRECIO_VENTA.Text
            Class_Articulo.stock = txt_STOCK.Text
            Class_Articulo.stock_min = txt_STOCK_MIN.Text
            Class_Articulo.stock_max = txt_STOCK_MAX.Text
            articulo.Insertar(articulo)
            articulo.consultarTodos(dvg_ARTICULOS)
            borrar.limpiar_TextBox(Me)
            Class_conexion.objConexion.Close()
        End If
    End Sub

    Private Sub dvg_ARTICULOS_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dvg_ARTICULOS.CellClick
        txt_id.Text = dvg_ARTICULOS.Item("ID_ART", dvg_ARTICULOS.CurrentRow.Index).Value
        txt_COD_BARRAS.Text = dvg_ARTICULOS.Item("COD_BARRAS", dvg_ARTICULOS.CurrentRow.Index).Value
        txt_NOMBRE.Text = dvg_ARTICULOS.Item("NOMBRE", dvg_ARTICULOS.CurrentRow.Index).Value
        comb_CF_CATEGORIA.Text = dvg_ARTICULOS.Item("CF_CATEGORIA", dvg_ARTICULOS.CurrentRow.Index).Value
        txt_PRECIO_UNITARIO.Text = dvg_ARTICULOS.Item("PRECIO_UNITARIO", dvg_ARTICULOS.CurrentRow.Index).Value
        txt_PRECIO_VENTA.Text = dvg_ARTICULOS.Item("PRECIO_VENTA", dvg_ARTICULOS.CurrentRow.Index).Value
        txt_STOCK.Text = dvg_ARTICULOS.Item("STOCK", dvg_ARTICULOS.CurrentRow.Index).Value
        txt_STOCK_MIN.Text = dvg_ARTICULOS.Item("STOCK_MIN", dvg_ARTICULOS.CurrentRow.Index).Value
        txt_STOCK_MAX.Text = dvg_ARTICULOS.Item("STOCK_MAX", dvg_ARTICULOS.CurrentRow.Index).Value
    End Sub
    Private Sub Limpiar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Limpiar.Click
        borrar.limpiar_TextBox(Me)
    End Sub

    Private Sub cmb_modificar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmb_modificar.Click
        If txt_COD_BARRAS.Text = "" Or txt_NOMBRE.Text = "" Or comb_CF_CATEGORIA.Text = "" Or txt_PRECIO_UNITARIO.Text = "" Or txt_PRECIO_VENTA.Text = "" Or txt_STOCK.Text = "" Or txt_STOCK_MIN.Text = "" Or txt_STOCK_MAX.Text = "" Then
            MsgBox("Hay campos vacios")
            Exit Sub
        Else
            Dim pregunta As DialogResult = MsgBox("¿ Desea realizar las moficaciones al articulo n°" & " " & CStr(txt_id.Text) & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Modificar registro")
            Class_Articulo.id = txt_id.Text
            Class_Articulo.codigo = txt_COD_BARRAS.Text
            Class_Articulo.nombre = txt_NOMBRE.Text
            Class_Articulo.categoria = comb_CF_CATEGORIA.Text
            Class_Articulo.precio_unitario = txt_PRECIO_UNITARIO.Text
            Class_Articulo.precio_venta = txt_PRECIO_VENTA.Text
            Class_Articulo.stock = txt_STOCK.Text
            Class_Articulo.stock_min = txt_STOCK_MIN.Text
            Class_Articulo.stock_max = txt_STOCK_MAX.Text
            articulo.Modificar(articulo)
            articulo.consultarTodos(dvg_ARTICULOS)
            borrar.limpiar_TextBox(Me)
            Class_conexion.objConexion.Close()
        End If
    End Sub

    Private Sub cmb_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Eliminar.Click
        If txt_COD_BARRAS.Text = "" Or txt_NOMBRE.Text = "" Or comb_CF_CATEGORIA.Text = "" Or txt_PRECIO_UNITARIO.Text = "" Or txt_PRECIO_VENTA.Text = "" Or txt_STOCK.Text = "" Or txt_STOCK_MIN.Text = "" Or txt_STOCK_MAX.Text = "" Then
            MsgBox("Hay campos vacios")
            Exit Sub
        Else
            Class_Articulo.Borrar(dvg_ARTICULOS.Item("ID_ART", dvg_ARTICULOS.CurrentRow.Index).Value)
            Class_Articulo.consultarTodos(dvg_ARTICULOS)
            borrar.limpiar_TextBox(Me)
        End If
    End Sub
End Class


