Imports System.Data
Imports System.Data.SqlClient
Public Class Class_Articulos
    Inherits Class_Conexion
    Dim Class_Conexion As New Class_Conexion
    Dim id_ As Integer
    Dim codigo_ As Integer
    Dim nombre_ As String
    Dim categoria_ As String
    Dim precio_unitario_ As Decimal
    Dim precio_venta_ As Decimal
    Dim stock_ As Integer
    Dim stock_min_ As Integer
    Dim stock_max_ As Integer

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property

    Public Property codigo As Integer
        Get
            Return codigo_
        End Get
        Set(ByVal value As Integer)
            codigo_ = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return nombre_
        End Get
        Set(value As String)
            nombre_ = value
        End Set
    End Property

    Public Property categoria() As String
        Get
            Return categoria_
        End Get
        Set(value As String)
            categoria_ = value
        End Set
    End Property

    Public Property precio_unitario() As Decimal
        Get
            Return precio_unitario_
        End Get
        Set(value As Decimal)
            precio_unitario_ = value
        End Set
    End Property

    Public Property precio_venta() As Decimal
        Get
            Return precio_venta_
        End Get
        Set(value As Decimal)
            precio_venta_ = value
        End Set
    End Property

    Public Property stock() As Integer
        Get
            Return stock_
        End Get
        Set(value As Integer)
            stock_ = value
        End Set
    End Property

    Public Property stock_min() As Integer
        Get
            Return stock_min_
        End Get
        Set(value As Integer)
            stock_min_ = value
        End Set
    End Property

    Public Property stock_max() As Integer
        Get
            Return stock_max_
        End Get
        Set(value As Integer)
            stock_max_ = value
        End Set
    End Property


    Public Sub consultarTodos(ByVal tabla As DataGridView)
        Try
            Class_Conexion.objConexion.Open()
            Dim objComando As New SqlCommand("Mostrar_Articulo", Class_Conexion.objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            Dim objDataTable As New Data.DataTable
            Dim objDataAdapter As New SqlDataAdapter(objComando)
            objDataAdapter.Fill(objDataTable)
            tabla.DataSource = objDataTable
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Class_Conexion.objConexion.Close()
        End Try
    End Sub

    Public Sub Insertar(ByVal articulos As Class_Articulos)
        Try
            Class_Conexion.objConexion.Open()
            Dim objComando As New SqlCommand("Pa_insertarArticulos", Class_Conexion.objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@codigo", articulos.codigo)
            objComando.Parameters.AddWithValue("@nombre", articulos.nombre)
            objComando.Parameters.AddWithValue("@categoria", articulos.categoria)
            objComando.Parameters.AddWithValue("@precio_unitario", articulos.precio_unitario)
            objComando.Parameters.AddWithValue("@precio_venta", articulos.precio_venta)
            objComando.Parameters.AddWithValue("@stock", articulos.stock)
            objComando.Parameters.AddWithValue("@stock_min", articulos.stock_min)
            objComando.Parameters.AddWithValue("@stock_max", articulos.stock_max)
            objComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Class_Conexion.objConexion.Close()
        End Try
    End Sub

    Public Sub Modificar(ByVal articulos As Class_Articulos)
        Try
            Class_Conexion.objConexion.Open()
            Dim objComando As New SqlCommand("Pa_modificarArticulos", Class_Conexion.objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@id", articulos.id)
            objComando.Parameters.AddWithValue("@codigo", articulos.codigo)
            objComando.Parameters.AddWithValue("@nombre", articulos.nombre)
            objComando.Parameters.AddWithValue("@categoria", articulos.categoria)
            objComando.Parameters.AddWithValue("@precio_unitario", articulos.precio_unitario)
            objComando.Parameters.AddWithValue("@precio_venta", articulos.precio_venta)
            objComando.Parameters.AddWithValue("@stock", articulos.stock)
            objComando.Parameters.AddWithValue("@stock_min", articulos.stock_min)
            objComando.Parameters.AddWithValue("@stock_max", articulos.stock_max)

            objComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Class_Conexion.objConexion.Close()
        End Try
    End Sub
    Public Sub Borrar(ByVal idArticulo As Integer)
        Try
            Class_Conexion.objConexion.Open()
            Dim objComando As New SqlCommand("PA_EliminarArticulo", Class_Conexion.objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@id", idArticulo)
            objComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Class_Conexion.objConexion.Close()
        End Try
    End Sub

End Class
