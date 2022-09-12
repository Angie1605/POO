Public Class Circulo : Inherits Figuras

    Public Sub New(lado As Double, ancho As Double, alto As Double, radio As Double)
        MyBase.New(lado, ancho, alto, radio)
    End Sub

    Public Function CalcularArea()
        Return (Math.PI * (Radio1 ^ 2))
    End Function
    Public Function CalcularPerimetro()
        Return (2 * Radio1 * Math.PI)
    End Function





End Class
