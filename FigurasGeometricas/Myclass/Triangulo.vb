Public Class Triangulo : Inherits Figuras
    Private lado2 As Double
    Private lado3 As Double

    Public Sub New(lado As Double, ancho As Double, alto As Double, radio As Double, lado2 As Double, lado3 As Double)
        MyBase.New(lado, ancho, alto, radio)
        Me.Lado21 = lado2
        Me.Lado31 = lado3

    End Sub

    Public Property Lado21 As Double
        Get
            Return lado2
        End Get
        Set(value As Double)
            lado2 = value
        End Set
    End Property

    Public Property Lado31 As Double
        Get
            Return lado3
        End Get
        Set(value As Double)
            lado3 = value
        End Set
    End Property

    Public Function CalcularArea()
        Return ((Ancho1 * Alto1) / 2)
    End Function
    Public Function CalcularPerimetro()
        Return (Lado1 * Lado21 * Lado31)
    End Function



End Class
