Public Class Cuadrado : Inherits Figuras

    Public Sub New(lado As Double, ancho As Double, alto As Double, radio As Double)
        MyBase.New(lado, ancho, alto, radio)
    End Sub




    Public Function CalcularArea()
        Return (Lado1 ^ 2)
    End Function
    Public Function CalcularPerimetro()
        Return (Lado1 * 4)
    End Function

End Class
