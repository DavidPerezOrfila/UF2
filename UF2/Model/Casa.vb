Public Class Casa
    'Creamos las propiedades de la clase casa. Un string para los materiales
    Private material As String
    Private derribada As Boolean
    'Creamos la funcion new 
    Public Sub New(ByVal material As String)
        Me.material = material
        Me.derribada = False
    End Sub
    Public Sub derribar()
        Me.derribada = True
    End Sub
    Public Function getMaterial() As String
        Return Me.material
    End Function
    Public Function getderribada() As Boolean
        Return Me.derribada
    End Function
End Class
