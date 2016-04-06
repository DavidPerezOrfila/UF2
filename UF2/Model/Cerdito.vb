Public Class Cerdito
    'Creamos una propiedad privada llamada Casa; al no existir creamos una nueva clase que llamaremos Casa.vb
    'Creamos una propiedad llamada nombre para otorgarle un nombre al cerdito para que cuando se cree el cerdito
    Private casa As Casa
    Private nombre As String

    'El constructor New se crea con un public sub ya que no devuelve valor. Restringuiendo los valores que puede recibir 
    'el nombre
    Public Sub New(ByVal nombre As String)
        Me.setNombre(nombre)

    End Sub

    Public Function getNombre() As String
        Return Me.nombre
    End Function

    'En el setter comprobamos que el nombre del Cerdito se llame igual que una de las tres opciones posibles y si no es así
    'de un mensaje de excepción
    Public Sub setNombre(ByVal nombre As String)
        If nombre <> "small" And nombre <> "medium" And nombre <> "big" Then
            Throw New Exception("Nombre no válido!")
            Me.nombre = nombre
        End If
    End Sub
    'Creamos el método construir y va a recibir como valor el material de la casa
    Public Function construir(ByVal material As String) As Casa
        Me.casa = New Casa(material)
        Return Me.casa
    End Function

    Public Sub ir(ByVal casaNueva As Casa)
        Me.casa = casaNueva
    End Sub
End Class
