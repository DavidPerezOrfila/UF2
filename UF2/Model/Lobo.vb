Public Class Lobo
    'Se crea la propiedad casa y la propiedad quemado
    Private casa As Casa
    Private quemado As Boolean

    Public Sub New()
        Me.quemado = False
    End Sub

    Public Sub soplar()
        If casa.getMaterial <> "ladrillo" Then
            Me.casa.derribar()
        Else
            Me.quemado = True
        End If

    End Sub
    Public Sub ir(ByVal casaNueva As Casa)
        Me.casa = casaNueva
    End Sub
End Class
 Then