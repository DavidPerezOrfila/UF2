<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Op1NumTxtbox = New System.Windows.Forms.TextBox()
        Me.Op2NumTxtbox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Op1DenTxtBox = New System.Windows.Forms.TextBox()
        Me.Op2DenTxtBox = New System.Windows.Forms.TextBox()
        Me.ResNumTxtBox = New System.Windows.Forms.TextBox()
        Me.ResDenTxtBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.resultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Op1NumTxtbox
        '
        Me.Op1NumTxtbox.Location = New System.Drawing.Point(18, 57)
        Me.Op1NumTxtbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Op1NumTxtbox.Name = "Op1NumTxtbox"
        Me.Op1NumTxtbox.Size = New System.Drawing.Size(148, 26)
        Me.Op1NumTxtbox.TabIndex = 0
        '
        'Op2NumTxtbox
        '
        Me.Op2NumTxtbox.Location = New System.Drawing.Point(258, 57)
        Me.Op2NumTxtbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Op2NumTxtbox.Name = "Op2NumTxtbox"
        Me.Op2NumTxtbox.Size = New System.Drawing.Size(148, 26)
        Me.Op2NumTxtbox.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(274, 228)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Comprobar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Op1DenTxtBox
        '
        Me.Op1DenTxtBox.Location = New System.Drawing.Point(18, 137)
        Me.Op1DenTxtBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Op1DenTxtBox.Name = "Op1DenTxtBox"
        Me.Op1DenTxtBox.Size = New System.Drawing.Size(148, 26)
        Me.Op1DenTxtBox.TabIndex = 3
        '
        'Op2DenTxtBox
        '
        Me.Op2DenTxtBox.Location = New System.Drawing.Point(258, 137)
        Me.Op2DenTxtBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Op2DenTxtBox.Name = "Op2DenTxtBox"
        Me.Op2DenTxtBox.Size = New System.Drawing.Size(148, 26)
        Me.Op2DenTxtBox.TabIndex = 4
        '
        'ResNumTxtBox
        '
        Me.ResNumTxtBox.Location = New System.Drawing.Point(507, 57)
        Me.ResNumTxtBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ResNumTxtBox.Name = "ResNumTxtBox"
        Me.ResNumTxtBox.Size = New System.Drawing.Size(148, 26)
        Me.ResNumTxtBox.TabIndex = 5
        '
        'ResDenTxtBox
        '
        Me.ResDenTxtBox.Location = New System.Drawing.Point(507, 137)
        Me.ResDenTxtBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ResDenTxtBox.Name = "ResDenTxtBox"
        Me.ResDenTxtBox.Size = New System.Drawing.Size(148, 26)
        Me.ResDenTxtBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(429, 105)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "="
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "X"
        '
        'resultado
        '
        Me.resultado.AutoSize = True
        Me.resultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultado.Location = New System.Drawing.Point(283, 302)
        Me.resultado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(94, 24)
        Me.resultado.TabIndex = 9
        Me.resultado.Text = "Resultado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 391)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ResDenTxtBox)
        Me.Controls.Add(Me.ResNumTxtBox)
        Me.Controls.Add(Me.Op2DenTxtBox)
        Me.Controls.Add(Me.Op1DenTxtBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Op2NumTxtbox)
        Me.Controls.Add(Me.Op1NumTxtbox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Op1NumTxtbox As TextBox
    Friend WithEvents Op2NumTxtbox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Op1DenTxtBox As TextBox
    Friend WithEvents Op2DenTxtBox As TextBox
    Friend WithEvents ResNumTxtBox As TextBox
    Friend WithEvents ResDenTxtBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents resultado As Label
End Class
