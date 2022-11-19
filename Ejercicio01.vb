Module Ejercicio01

    Sub Main()

        Dim edad As Integer

        Console.WriteLine("Determinar la mayoria de edad de una persona en base a su edad")

        Console.WriteLine("Escriba su edad:")
        edad = Console.ReadLine

        If edad >= 18 Then
            Console.WriteLine("Usted es mayor de edad")
        Else
            Console.WriteLine("Usted es menor de edad")
        End If

        Console.ReadLine()

    End Sub

End Module