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

    'Se crea el método function multiplicar que recibe un Racional y devuelve un Racional'

    Public Function multiplicar(ByVal r As Racional) As Racional
        Dim nuevoNumerador As Integer
        Dim nuevoDenominador As Integer
        Dim resultado As Racional
        'Se crean dos variables para realizar la multiplicación y otra variable para mostrar el resultado con el comando
        'Return nos devuelva el resultado de la operación'
        nuevoNumerador = Me.numerador * r.numerador
        nuevoDenominador = Me.denominador * r.denominador
        resultado = New Racional(nuevoNumerador, nuevoDenominador)

        Return (resultado)

    End Function

End Class
