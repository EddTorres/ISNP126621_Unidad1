Module Ejercicio02
    Sub Main()

        Console.WriteLine("Determinar si el numero ingresado es positivo o negativo")

        Dim numero As Decimal

        Console.WriteLine("Escriba el numero a evaluar:")
        numero = Console.ReadLine

        If numero > 0 Then
            Console.WriteLine("Su numero es positivo")
        ElseIf numero < 0 Then
            Console.WriteLine("Su numero es negativo")
        Else
            Console.WriteLine("Su numero es cero")
        End If

        Console.ReadLine()

    End Sub

End Module
