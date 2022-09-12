Public Class Rectangulo : Inherits Figuras

    Public Sub New(lado As Double, ancho As Double, alto As Double, radio As Double)
        MyBase.New(lado, ancho, alto, radio)
    End Sub

    Public Function CalcularArea()
        Return (Ancho1 * Alto1)
    End Function
    Public Function CalcularPerimetro()
        Return ((2 * Ancho1) + (2 * Alto1))
    End Function


End Class
