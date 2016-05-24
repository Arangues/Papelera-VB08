Imports System.Data.SqlClient                  'creamos 3 librerias para realizar la conexion
Imports System.Windows.Forms
Public Class frm_Factura
    Dim Class_Conexion As New Class_Conexion
    Dim eliminar_tect As New Metodos
    Private Sub frm_Factura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Class_Conexion As New Class_Conexion


        Dim buscar As New SqlDataAdapter("SELECT COD_BARRAS,NOMBRE,PRECIO_VENTA FROM ARTICULOS", Class_Conexion.objConexion)
        Dim ds As New DataSet()
        buscar.Fill(ds, "ARTICULOS")
        dgv_facturas_prod.DataSource = ds.Tables(0)

    End Sub

    Private Sub dgv_facturas_prod_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_facturas_prod.CellClick
        Try
            txt_codigo_art.Text = dgv_facturas_prod.Item("COD_BARRAS", dgv_facturas_prod.CurrentRow.Index).Value
            txt_nombre_art.Text = dgv_facturas_prod.Item("NOMBRE", dgv_facturas_prod.CurrentRow.Index).Value
            txt_preciov_art.Text = dgv_facturas_prod.Item("PRECIO_VENTA", dgv_facturas_prod.CurrentRow.Index).Value
            txt_codigo_art.Text = dgv_facturas_prod.Item("COD_BARRAS", dgv_facturas_prod.CurrentRow.Index).Value


        Catch ex As Exception

        End Try
        
    End Sub
    Private Sub txt_buscar_nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_buscar_nombre.TextChanged
        Dim buscar As New SqlDataAdapter("select * from ARTICULOS where NOMBRE like '%" + txt_buscar_nombre.Text + "%'", Class_Conexion.objConexion)
        Dim ds As New DataSet()
        buscar.Fill(ds, "ARTICULOS")
        dgv_facturas_prod.DataSource = ds.Tables(0)
    End Sub

    Private Sub TXT_BUSCAR_CODIGO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_BUSCAR_CODIGO.TextChanged
        Dim buscar As New SqlDataAdapter("select * from ARTICULOS where COD_BARRAS like '%" + TXT_BUSCAR_CODIGO.Text + "%'", Class_conexion.objConexion)
        Dim ds As New DataSet()
        buscar.Fill(ds, "ARTICULOS")
        dgv_facturas_prod.DataSource = ds.Tables(0)
    End Sub

  
    Private Sub cmb_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Agregar.Click
        Dim Cantidad As Integer = txt_cantidad.Text
        Dim subtotal As Decimal
        subtotal = CDbl(Cantidad) * CDbl(txt_preciov_art.Text)
        dgv_detalles.Rows.Add(txt_codigo_art.Text, txt_nombre_art.Text, txt_preciov_art.Text, txt_cantidad.Text, subtotal)
        Dim total As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()
        For Each fila In dgv_detalles.Rows
            total += Convert.ToDouble(fila.Cells("Subtotal").Value)
        Next
        Dim pagar As String
        pagar = Convert.ToString(total)
        txt_Pagar.Text = pagar

    End Sub

    Private Sub cmb_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Eliminar.Click
        dgv_detalles.Rows.Remove(dgv_detalles.CurrentRow)
        Dim total As Double = 0
        Dim fila As DataGridViewRow = New DataGridViewRow()
        For Each fila In dgv_detalles.Rows
            total += Convert.ToDouble(fila.Cells("Subtotal").Value)
        Next
        Dim pagar As String
        pagar = "$" + Convert.ToString(total)
        txt_Pagar.Text = pagar
        'txt_vuelto.Text = Val(txt_Pagar.Text) - Val(txt_pago_con.Text)
    End Sub


 
    Private Sub txt_pago_con_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pago_con.KeyPress

        If Asc(e.KeyChar) = 13 Then
            txt_vuelto.Text = Val(txt_pago_con.Text) - Val(txt_Pagar.Text)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Cobrar.Click


        Dim agregar As SqlCommand = New SqlCommand("insert into DETALLE values (@COD_BARRAS,@NOMBRE,@PRECIO,@CANTIDAD,@TOTAL)", Class_Conexion.objConexion)
        Dim pregunta As DialogResult = MsgBox("Esta Seguro de generar una nueva factura?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "registro")
        Dim fila As DataGridViewRow = New DataGridViewRow()
        Try

            For Each fila In dgv_detalles.Rows
                agregar.Parameters.Clear()
                agregar.Parameters.AddWithValue("@COD_BARRAS", Convert.ToInt32(fila.Cells("Codigo").Value))
                agregar.Parameters.AddWithValue("@NOMBRE", Convert.ToString(fila.Cells("Nombre").Value))
                agregar.Parameters.AddWithValue("@PRECIO", Convert.ToDecimal(fila.Cells("Precio").Value))
                agregar.Parameters.AddWithValue("@CANTIDAD", Convert.ToInt32(fila.Cells("Cantidad").Value))
                agregar.Parameters.AddWithValue("@TOTAL", Convert.ToDecimal(txt_Pagar.Text))


                Class_Conexion.objConexion.Open()
                agregar.ExecuteNonQuery()
                Class_Conexion.objConexion.Close()

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        eliminar_tect.limpiar_TextBox(Me)
        eliminar_tect.LimpiarGroupBox(Me.GroupBox1)
        eliminar_tect.LimpiarGroupBox(Me.GroupBox2)
        eliminar_tect.LimpiarGroupBox(Me.GroupBox3)
        eliminar_tect.LimpiarGroupBox(Me.GroupBox4)
        dgv_detalles.Rows.Clear()
    End Sub

  
End Class