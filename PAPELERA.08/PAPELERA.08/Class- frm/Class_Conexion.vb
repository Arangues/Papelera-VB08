Imports System.Data
Imports System.Data.SqlClient
Public Class Class_Conexion

    Public Conexion As String = "Server=SGA\SGASQL;Database=BD_PAPELERA;Trusted_Connection=True;"
    Public DataSet As DataSet = New DataSet()
    Public objDataTable As Data.DataTable
    Public objDataAdapter As SqlDataAdapter
    Public objConexion As New SqlConnection(Conexion)
    Public objcomando As SqlCommand
    Public objComandoBuilder As SqlCommandBuilder

    Public Sub conectar()
        ' creamos un metodo try catch para verificar la coenxion
        Try
            objConexion.Open()


        Catch ex As Exception
            MessageBox.Show("ERROR DE CONEXION") 'SI NO SE CONECTA SALE UN MENSAJE DE ERROR
        Finally
            objConexion.Close() 'CIERRA LA CONEXION
        End Try
    End Sub


End Class






















