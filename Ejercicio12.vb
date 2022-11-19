Module Ejercicio12

    Public Function operaciones(a As Double, b As Double, c As String) As Double
        If c = "Suma" Then
            Return a + b
        End If

        If c = "Resta" Then
            Return a - b
        End If
        If c = "Multiplicacion" Then
            Return a * b
        End If
    End Function
    Sub main()

        Console.WriteLine("Funcion para realizar operaciones numericas.")

        Dim a, b As Double
        Dim c As String

        Console.WriteLine("Ingrese el primer numero a evaluar")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo numero a evaluar")
        b = Console.ReadLine
        Console.WriteLine("Ingrese si desea realizar Suma, Resta o Multiplicacion")
        c = Console.ReadLine

        Console.WriteLine("El resultado de la operacion indicada es: {0}", operaciones(a, b, c))

        Console.ReadLine()

    End Sub



End Module
