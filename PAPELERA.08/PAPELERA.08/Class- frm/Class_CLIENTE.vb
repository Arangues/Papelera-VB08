Imports System.Data
Imports System.Data.SqlClient
Public Class Class_CLIENTE
    Dim Class_Conexion As New Class_Conexion
    Private id_ As Integer
    Private nombre_ As String
    Private direccion_ As String
    Private localidad_ As String
    Private telefono_email_ As String

    Public Property id() As Integer
        Get
            Return id_
        End Get
        Set(ByVal value As Integer)
            id_ = value
        End Set
    End Property
    Public Property nombre() As String
        Get
            Return nombre_
        End Get
        Set(ByVal value As String)
            nombre_ = value
        End Set
    End Property
    Public Property direccion() As String
        Get
            Return direccion_
        End Get
        Set(ByVal value As String)
            direccion_ = value
        End Set
    End Property
    Public Property localidad As String
        Get
            Return localidad_
        End Get
        Set(ByVal value As String)
            localidad_ = value
        End Set
    End Property

    Public Property telefono_email As String
        Get
            Return telefono_email_
        End Get
        Set(ByVal value As String)
            telefono_email_ = value
        End Set
    End Property
    ' creamos un metodo para llenar un DataGridView
    Public Sub consultarTodos(ByVal tabla As DataGridView)
        Try
            'creamos un obj de tipo SqlCommand (" texto de consulta , la conexion de la clase conexion )
            Dim objComando As New SqlCommand("PCONSULTACLIENTE", Class_Conexion.objConexion)
            objComando.CommandType = CommandType.StoredProcedure ' ejcuta el preocedimiento almacenado de sql
            Dim objDataTable As New Data.DataTable 'instanciamos un obj de tipo SqlDataAdapter
            Dim objDataAdapter As New SqlDataAdapter(objComando) ' instanciamos un obj de tipo  SqlDataAdapter 
            '(donde se le asigna  un procedimiento almacenado
            Class_Conexion.objConexion.Open()
            objDataAdapter.Fill(objDataTable) 'llenamos al DataTable con registros
            tabla.DataSource = objDataTable ' los registro del DataTable se muestran en la tabla con el DataSource
            Class_Conexion.objConexion.Close() ' Cierro la conexion 
        Catch ex As Exception

        End Try
        

    End Sub

    Public Sub Insertar(ByVal cliente As Class_CLIENTE)
        Try
            Class_Conexion.objConexion.Close()
            Dim objComando As New SqlCommand("Pa_insertarcliente", Class_Conexion.objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("nombre", cliente.nombre)
            objComando.Parameters.AddWithValue("@direccion", cliente.direccion)
            objComando.Parameters.AddWithValue("@localidad", localidad)
            objComando.Parameters.AddWithValue("@telefono_email", telefono_email)
            Class_Conexion.objConexion.Open()
            objComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Class_Conexion.objConexion.Close()
        End Try
      
    End Sub
    Public Sub Modificar(ByVal cliente As Class_CLIENTE)
        Try
            Class_Conexion.objConexion.Open()
            Dim objComando As New SqlCommand("Pa_modificarcliente", Class_Conexion.objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.Add("@id", SqlDbType.Int)
            objComando.Parameters.Add("@nombre", SqlDbType.VarChar)
            objComando.Parameters.Add("@direccion", SqlDbType.VarChar)
            objComando.Parameters.Add("@localidad", SqlDbType.VarChar)
            objComando.Parameters.Add("@telefono_email", SqlDbType.VarChar)
            objComando.Parameters("@id").Value = cliente.id
            objComando.Parameters("@nombre").Value = cliente.nombre
            objComando.Parameters("@direccion").Value = cliente.direccion
            objComando.Parameters("@localidad").Value = cliente.localidad
            objComando.Parameters("@telefono_email").Value = cliente.telefono_email
            objComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Class_Conexion.objConexion.Close()
        End Try
    End Sub
    Public Sub Borrar(ByVal idCliente As Integer)
        Try
            Class_Conexion.objConexion.Open()
            Dim objComando As New SqlCommand("PA_EliminarCliente", Class_Conexion.objConexion)
            objComando.CommandType = CommandType.StoredProcedure
            objComando.Parameters.AddWithValue("@id", idCliente)
            objComando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Class_Conexion.objConexion.Close()
        End Try
    End Sub





End Class
