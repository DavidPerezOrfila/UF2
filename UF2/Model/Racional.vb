Public Class Racional
    'Definimos las propiedades de la clase como private para que desde el exterior no se modifiquen'

    Private numerador As Integer
    Private denominador As Integer

    'Se crea el método con la función pública new que será el constructor utilizando los set
    'tanto de denominador como de numerador comprobamos que el valor introducido por el usuario sea correcto

    Public Sub New(ByVal numerador As Integer, ByVal denominador As Integer)
        Me.setNumerador(numerador)
        Me.setDenominador(denominador)

    End Sub

    'Se crea el método con la función pública new que será el segundo constructor'
    'Cuando se crea un método sin que le pase atributos entre valores el compilador diferenciará entre uno y otro
    'Para que el random no se repita en el operando1 y operando2 dentro del new random utilizaremos la hora del sistema en 
    'milisegundos para que dé un número aleatorio diferente: System.DateTime.Now.Millisecond
    Public Sub New()
        Static r As New Random(System.DateTime.Now.Millisecond)
        Me.setNumerador(r.Next(0, 10))
        Me.setDenominador(r.Next(1, 10))
    End Sub

    'Se crea el método function multiplicar que recibe un Racional y devuelve un Racional'

    Public Function multiplicar(ByVal r2 As Racional) As Racional
        Dim nuevoNumerador As Integer
        Dim nuevoDenominador As Integer
        Dim resultado As Racional
        'Se crean dos variables para realizar la multiplicación y otra variable para mostrar el resultado con el comando
        'Return nos devuelva el resultado de la operación'
        nuevoNumerador = Me.getNumerador() * r2.getNumerador()
        nuevoDenominador = Me.getDenominador() * r2.getDenominador()
        resultado = New Racional(nuevoNumerador, nuevoDenominador)

        Return (resultado)

    End Function
    Public Function dividir(ByVal r2 As Racional) As Racional
        Dim nuevoNumerador As Integer
        Dim nuevoDenominador As Integer
        Dim resultado As Racional
        'Se crean dos variables para realizar la multiplicación y otra variable para mostrar el resultado con el comando
        'Return nos devuelva el resultado de la operación'
        nuevoNumerador = Me.getNumerador() / r2.getNumerador()
        nuevoDenominador = Me.getDenominador() / r2.getDenominador()
        resultado = New Racional(nuevoNumerador, nuevoDenominador)

        Return (resultado)
    End Function
    Public Function esigual(ByRef r2 As Racional) As Boolean

        Return Me.getNumerador() = r2.getNumerador() And Me.getDenominador() = r2.getDenominador()

    End Function

    Public Function getNumerador() As Integer
        Return Me.numerador
    End Function

    Public Function getDenominador() As Integer
        Return Me.denominador
    End Function
    Public Sub setNumerador(ByVal numerador As Integer)
        Me.numerador = numerador
    End Sub
    Public Sub setDenominador(ByVal denominador As Integer)
        If denominador = 0 Then
            Throw New Exception("Denominador no válido!")
        End If
        Me.denominador = denominador
    End Sub
End Class
