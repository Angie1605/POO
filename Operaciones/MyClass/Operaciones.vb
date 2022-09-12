Public Class Operaciones

    Private num1 As Integer
    Private num2 As Integer

    Public Sub New(num1 As Integer, num2 As Integer)
        Me.num1 = num1
        Me.num2 = num2
    End Sub

    Public Property Num11 As Integer
        Get
            Return num1
        End Get
        Set(value As Integer)
            num1 = value
        End Set
    End Property

    Public Property Num21 As Integer
        Get
            Return num2
        End Get
        Set(value As Integer)
            num2 = value
        End Set
    End Property






End Class
