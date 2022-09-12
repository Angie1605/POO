Public Class Potencia : Inherits Operaciones

    Public Sub New(num1 As Integer, num2 As Integer)
        MyBase.New(num1, num2)
    End Sub

    Function potencia() As Integer
        Return (Num11 ^ Num21)
    End Function
End Class
