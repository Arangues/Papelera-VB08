Public Class Metodos
    Dim verifado_ As String
    Public Property validar() As Integer
        Get
            Return verifado_
        End Get
        Set(ByVal value As Integer)
            verifado_ = value
        End Set
    End Property
    Public Sub limpiar_TextBox(ByVal formulario As Form)
        For Each Control As Control In formulario.Controls
            If TypeOf Control Is TextBox Or TypeOf Control Is ComboBox Then
                Control.Text = ""
            End If
        Next
    End Sub



End Class
