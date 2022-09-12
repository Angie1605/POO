Module Module1

    Sub Main()
        Dim option1 As Integer
        Dim lado As Double
        Dim ancho As Double
        Dim alto As Double
        Dim radio As Double
        Console.WriteLine("Seleccione la figura geometrica")
        Console.WriteLine("1. Cuadrado  ")
        Console.WriteLine("2. Rectangulo ")
        Console.WriteLine("3. Triangulo ")
        Console.WriteLine("4. Romboide ")
        Console.WriteLine("5. Circulo ")
        option1 = Console.ReadLine
        Select Case option1
            Case 1

                Console.WriteLine("Ingresar el lado del cuadrado")
                Lado = Console.ReadLine
                Dim figura As Cuadrado = New Cuadrado(lado, 0, 0, 0)
                Console.WriteLine("El area del cuadrado es: " & figura.CalcularArea)
                Console.WriteLine("El perimetro del cuadrado es: " & figura.CalcularPerimetro)

            Case 2

                Console.WriteLine("Ingresar la base del rectangulo")
                ancho = Console.ReadLine
                Console.WriteLine("Ingresar el alto del rectangulo")
                alto = Console.ReadLine
                Dim figura As Rectangulo = New Rectangulo(0, ancho, alto, 0)
                Console.WriteLine("El area del rectangulo es: " & figura.CalcularArea)
                Console.WriteLine("El perimetro del rectangulo es: " & figura.CalcularPerimetro)

            Case 3
                Dim lado2 As Double
                Dim lado3 As Double
                Console.WriteLine("Ingresar la base del triangulo")
                ancho = Console.ReadLine
                Console.WriteLine("Ingresar el alto del triangulo")
                alto = Console.ReadLine
                Console.WriteLine("Ingresar el lado 1 del triangulo")
                lado = Console.ReadLine
                Console.WriteLine("Ingresar el lado 2 del triangulo")
                lado2 = Console.ReadLine
                Console.WriteLine("Ingresar el lado 3 del triangulo")
                lado3 = Console.ReadLine
                Dim figura As Triangulo = New Triangulo(lado, ancho, alto, 0, lado2, lado3)
                Console.WriteLine("El area del triangulo es: " & figura.CalcularArea)
                Console.WriteLine("El perimetro del triangulo es: " & figura.CalcularPerimetro)

            Case 4
                Console.WriteLine("Ingresar la base del rommboide")
                ancho = Console.ReadLine
                Console.WriteLine("Ingresar el alto del romboide")
                alto = Console.ReadLine
                Dim figura As Romboide = New Romboide(0, ancho, alto, 0)
                Console.WriteLine("El area del romboide es: " & figura.CalcularArea)
                Console.WriteLine("El perimetro del romboide es: " & figura.CalcularPerimetro)
            Case 5
                Console.WriteLine("Ingresar el radio del circulo")
                radio = Console.ReadLine
                Dim figura As Circulo = New Circulo(0, 0, 0, radio)
                Console.WriteLine("El area del circulo es: " & figura.CalcularArea)
                Console.WriteLine("El perimetro del circulo es: " & figura.CalcularPerimetro)



        End Select

    End Sub

End Module
