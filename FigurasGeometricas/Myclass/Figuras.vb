Public Class Figuras

    Private lado As Double
    Private ancho As Double
    Private alto As Double
    Private radio As Double

    Public Sub New(lado As Double, ancho As Double, alto As Double, radio As Double)
        Me.Lado1 = lado
        Me.Ancho1 = ancho
        Me.Alto1 = alto
        Me.Radio1 = radio
    End Sub

    Public Property Lado1 As Double
        Get
            Return lado
        End Get
        Set(value As Double)
            lado = value
        End Set
    End Property

    Public Property Ancho1 As Double
        Get
            Return ancho
        End Get
        Set(value As Double)
            ancho = value
        End Set
    End Property

    Public Property Alto1 As Double
        Get
            Return alto
        End Get
        Set(value As Double)
            alto = value
        End Set
    End Property

    Public Property Radio1 As Double
        Get
            Return radio
        End Get
        Set(value As Double)
            radio = value
        End Set
    End Property
End Class
