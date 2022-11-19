Module Ejercicio11

    Public Function MayorDeEdad(a As Integer) As Boolean

        If a < 18 Then
            Return False
        Else
            Return True
        End If

    End Function

    Sub main()

        Console.WriteLine("Funcion para validar si una persona es mayor de edad o no.")

        Console.WriteLine("Ingrese la edad de la persona: ")

        Dim edad As Integer = Convert.ToInt32(Console.ReadLine())

        If MayorDeEdad(edad) Then
            Console.WriteLine("La persona es mayor de edad")
        Else
            Console.WriteLine("La persona es menor de edad")
        End If

        Console.ReadLine()

    End Sub

End Module
