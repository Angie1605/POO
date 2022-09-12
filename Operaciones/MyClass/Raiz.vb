Public Class Raiz : Inherits Operaciones

    Public Sub New(num1 As Integer, num2 As Integer)
        MyBase.New(num1, num2)
    End Sub

    Function raiz() As Integer
        Return (Num11 ^ (1 / Num21))
    End Function
End Class
