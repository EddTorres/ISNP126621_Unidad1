Module Ejercicio09

    Sub main()

        Console.WriteLine("Validar en base a las calificaciones si un estudiante aprobo o reprobo")

        Dim a(5) As Double
        Dim c As Double = 0
        Dim b As Double = 0.0
        Dim e As Integer = 6

        Console.WriteLine("Ingresar la calificacion 1 de 6")
        a(0) = Console.ReadLine
        Console.WriteLine("Ingresar la calificacion 2 de 6")
        a(1) = Console.ReadLine
        Console.WriteLine("Ingresar la calificacion 3 de 6")
        a(2) = Console.ReadLine
        Console.WriteLine("Ingresar la calificacion 4 de 6")
        a(3) = Console.ReadLine
        Console.WriteLine("Ingresar la calificacion 5 de 6")
        a(4) = Console.ReadLine
        Console.WriteLine("Ingresar la calificacion 6 de 6")
        a(5) = Console.ReadLine

        Dim m = a.ElementAt(0)
        Dim n = a.ElementAt(0)

        For Each c In a
            b += c
            If c > m Then
                m = c
            End If

            If c < n Then
                n = c
            End If
        Next

        Dim d As Double = b / a.Length

        Console.WriteLine("Nota Mayor: {0}", m)
        Console.WriteLine("Nota Menor: {0}", n)
        Console.WriteLine("Promedio de notas: {0}", d)
        If d >= e Then
            Console.WriteLine("El estudiante aprobo la materia.")
        Else
            Console.WriteLine("El estudiante no aprobo la materia.")
        End If

        Console.ReadLine()

    End Sub

End Module
