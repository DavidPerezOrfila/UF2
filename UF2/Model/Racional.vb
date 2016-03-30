Public Class Racional
    'Definimos las propiedades de la clase como private para que desde el exterior no se modifiquen'

    Private numerador As Integer
    Private denominador As Integer

    'Se crea el método con la función pública new que será el constructor'

    Public Sub New(ByVal numerador As Integer, ByVal denominador As Integer)
        Me.numerador = numerador
        Me.denominador = denominador

    End Sub

    'Se crea el método con la función pública new que será el segundo constructor'

    Public Sub New()
        Dim r As New Random
        Me.numerador = r.Next(1, 10)
        Me.denominador = r.Next(1, 10)
    End Sub

    'Se crea el método function multiplicar que devuelve un Racional'

    Public Function multiplicar() As Racional

    End Function

End Class
