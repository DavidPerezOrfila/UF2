Public Class Form1
    Dim operando1 As Racional
    Dim operando2 As Racional
    Dim resultusu As Racional
    Dim resultok As Racional

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Todos los métodos debemos de añadirle paréntesis vacios para diferenciarlos de las propiedades
        Me.operando1 = New Racional()
        Op1NumTxtbox.Text = Me.operando1.getNumerador().ToString()
        Op1DenTxtBox.Text = Me.operando1.getDenominador().ToString()


        Me.operando2 = New Racional()
        Op2NumTxtbox.Text = Me.operando2.getNumerador().ToString()
        Op2DenTxtBox.Text = Me.operando2.getDenominador().ToString()

        Dim num, den As Integer
        num = Me.operando1.getnumerador()
        den = Me.operando2.getdenominador()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        resultusu = New Racional(CInt(ResNumTxtBox.Text), CInt(ResDenTxtBox.Text))
        resultok = operando1.multiplicar(operando2)

        If resultusu.esigual(resultok) Then
            resultado.Text = "Correcto!"
        Else
            resultado.Text = "ERROR!"
        End If
    End Sub
End Class
