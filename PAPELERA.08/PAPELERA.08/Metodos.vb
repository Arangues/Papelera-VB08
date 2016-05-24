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

    Public Sub LimpiarGroupBox(ByVal Grupo As Windows.Forms.GroupBox)
        Dim miControl As Object
        For Each miControl In Grupo.Controls
            If miControl.GetType Is GetType(System.Windows.Forms.TextBox) Then
                miControl.Clear()
            End If
            System.Windows.Forms.Application.DoEvents()
        Next
    End Sub

End Class
