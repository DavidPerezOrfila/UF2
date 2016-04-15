Public Class Los3Cerditos

    Dim small As Cerdito
    Dim medium As Cerdito
    Dim big As Cerdito
    Dim Lobo As Lobo
    Dim paja As Casa
    Dim madera As Casa
    Dim ladrillo As Casa


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text = "Érase una vez... tres cerditos que decidieron emanciparse y vivir cada uno en su propia casa"
        PictureBox1.Visible = True
        small = New Cerdito("small")
        medium = New Cerdito("medium")
        big = New Cerdito("big")
        Lobo = New Lobo()
        PictureBox1.ImageLocation = "http://bit.ly/1SceJ2A"
        Button1.Visible = False
        Button2.Visible = True
        TextBox1.Visible = True
        My.Computer.Audio.Play(My.Resources.loboFeroz, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Los3Cerditos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Visible = False
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button6.Visible = False
        Button7.Visible = False
        TextBox2.Visible = False
        Button8.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Visible = False
        PictureBox1.ImageLocation = "https://i.ytimg.com/vi/yFHQnRbslMw/hqdefault.jpg"
        small.ir(paja)
        paja = Me.small.construir("paja")
        TextBox1.Text = "Small fue el primero en construir su propia casa y decidió construirla de paja"
        Button3.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button2.Visible = False
        medium.ir(madera)
        madera = Me.medium.construir("madera")
        TextBox1.Text = "Medium fue el segundo en construir su propia casa y decidió construirla de madera"
        PictureBox1.ImageLocation = "http://lalupa3.webcindario.com/clasicos/imagenes/cerditos2.jpg"
        Button4.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button3.Visible = False
        big.ir(ladrillo)
        ladrillo = Me.big.construir("ladrillo")
        TextBox1.Text = "Big que era el hermano mayor y más responsable de todos, decidió construirse la casa a base de ladrillos y cemento"
        PictureBox1.ImageLocation = "http://bit.ly/25Pt7Ic"
        Button5.Visible = True

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button4.Visible = False
        TextBox1.Text = "En el bosque vivía un malvado Lobo que era temido por todos los animalitos del bosque"
        PictureBox1.ImageLocation = "http://bit.ly/1qc6Kff"
        Button6.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button5.Visible = False
        Lobo.ir(paja)
        PictureBox2.Visible = True
        PictureBox2.ImageLocation = "http://bit.ly/1qc6Kff"
        PictureBox1.ImageLocation = "https://i.ytimg.com/vi/yFHQnRbslMw/hqdefault.jpg"
        TextBox1.Text = "El lobo hacía muchos días que no comía nada, así que fue a casa de Small para destruirla y comérselo"
        Button7.Visible = True
    End Sub
    Public Tiempo As New System.Timers.Timer

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Lobo.soplar()
        Button6.Visible = False
        Button8.Visible = True
        TextBox1.Text = "Soplaré, soplaré y tu casa destruiré!!!"
        PictureBox1.ImageLocation = "https://i.ytimg.com/vi/yFHQnRbslMw/hqdefault.jpg"
        PictureBox2.ImageLocation = "http://bit.ly/1YjqjNU"
        Tiempo.Interval = 1000 ' Un segundo
        Tiempo.Enabled = True ' Crono encendido
        AddHandler Tiempo.Elapsed, AddressOf cambiarImagen


    End Sub
    Public Sub cambiarImagen()          ' Despues de 1s cambiar imagen

        PictureBox1.ImageLocation = "http://bit.ly/1RVJA42"
        Tiempo.Enabled = False   ' Parar el Crono



    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button7.Visible = False
        If PictureBox1.ImageLocation = "http://bit.ly/1RVJA42" Then

            TextBox2.Visible = True
            TextBox1.Visible = False
            TextBox2.Text = "El lobo sopló tan fuerte que la casa destruyo y el cerdito huyó!"

        End If
        small.ir(madera)
    End Sub
End Class