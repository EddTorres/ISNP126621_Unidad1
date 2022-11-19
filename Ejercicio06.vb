Module Ejercicio06
    Sub Main()

        Console.WriteLine("Tabla de multiplicar del numero indicado")
        Dim num, a, prod As Integer

        Console.WriteLine("Ingrese el numero para crear la tabla de multiplicar: ")
        num = Console.ReadLine

        Console.WriteLine("Tabla de multiplicar del 1 al 10 del numero: {0}", num)

        For a = 1 To 10 Step 1

            prod = num * a

            Console.WriteLine("{0} x {1} = {2}", num, a, prod)

        Next

        Console.ReadLine()

    End Sub

End Module