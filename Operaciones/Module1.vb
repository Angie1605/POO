Module Module1

    Sub Main()
        Dim num1 As Integer
        Dim num2 As Integer
        Dim option1 As Integer
        Console.WriteLine("Introduzca el primer numero: ")
        num1 = Console.ReadLine
        Console.WriteLine("Introduzca el segundo numero: ")
        num2 = Console.ReadLine
        Console.WriteLine("Seleccione una opcion ")
        Console.WriteLine("1. Suma ")
        Console.WriteLine("2. Resta ")
        Console.WriteLine("3. Multiplicacion ")
        Console.WriteLine("4. Division ")
        Console.WriteLine("5. Potencia ")
        Console.WriteLine("6. Raiz ")
        option1 = Console.ReadLine
        Select Case option1
            Case 1
                Console.WriteLine("La suma de {0} y {1} es: ", num1, num2)
                Dim OperacionesGeneral As Suma = New Suma(num1, num2)
                Console.WriteLine(OperacionesGeneral.suma())
            Case 2
                Console.WriteLine("La resta de {0} y {1} es: ", num1, num2)
                Dim OperacionesGeneral As Resta = New Resta(num1, num2)
                Console.WriteLine(OperacionesGeneral.resta())
            Case 3
                Console.WriteLine("La multiplicacion de {0} y {1} es: ", num1, num2)
                Dim OperacionesGeneral As Multiplicacion = New Multiplicacion(num1, num2)
                Console.WriteLine(OperacionesGeneral.multiplicacion())
            Case 4
                Console.WriteLine("La division de {0} entre {1} es: ", num1, num2)
                Dim OperacionesGeneral As Division = New Division(num1, num2)
                Console.WriteLine(OperacionesGeneral.division())
            Case 5
                Console.WriteLine("La potencia de {0} elevado a {1} es: ", num1, num2)
                Dim OperacionesGeneral As Potencia = New Potencia(num1, num2)
                Console.WriteLine(OperacionesGeneral.potencia())
            Case 6
                Console.WriteLine("La raiz {0} de {1} es: ", num1, num2)
                Dim OperacionesGeneral As Raiz = New Raiz(num1, num2)
                Console.WriteLine(OperacionesGeneral.raiz())

        End Select

        'Dim OperacionesGeneral As Operaciones = New Operaciones(num1, num2)
        'Console.WriteLine(OperacionesGeneral.Suma())

    End Sub

End Module
