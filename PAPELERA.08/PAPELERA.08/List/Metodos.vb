Public Class Metodos
    Public Sub limpiar_TextBox(ByVal formulario As Form)
        For Each Control As Control In formulario.Controls
            If TypeOf Control Is TextBox Or TypeOf Control Is ComboBox Then
                Control.Text = ""
            End If
        Next
    End Sub
End Class
