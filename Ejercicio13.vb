Module Ejercicio13

    Function nummay(a As Integer()) As Integer
        Dim b As Integer = a.ElementAt(0)
        For Each c In a
            If c > b Then
                b = c
            End If
        Next
        Return b

    End Function

    Sub main()

        Console.WriteLine("Funcion para detectar el mayor numero en un array.")

        Dim a As Integer = 5
        Dim b(a) As Integer

        For i = 0 To a - 1
            Console.WriteLine("Ingrese el numero {0} de 5 a evaluar", i + 1)
            b.SetValue(Convert.ToInt32(Console.ReadLine()), i)
        Next

        Dim may As Integer = nummay(b)
        Console.WriteLine("De los 5 numeros ingresados el mayor es: {0}", may)

        Console.ReadLine()

    End Sub


End Module
