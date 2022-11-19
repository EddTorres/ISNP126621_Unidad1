Module Ejercicio10
    Sub main()

        Console.WriteLine("Calculo e informacion sobre empleados solicitado.")

        Dim a As Integer = 5
        Dim b(a) As String
        Dim c(a) As Double
        Dim d(a) As Double

        For i = 0 To a - 1

            Console.WriteLine("Ingresar el nombre del empleado {0}", i + 1)
            b.SetValue(Console.ReadLine(), i)
            Console.WriteLine("Ingresar las horas diarias laboradas del empleado {0}", i + 1)
            c.SetValue(Convert.ToDouble(Console.ReadLine()), i)
            Console.WriteLine("Ingrese el salario por hora laboral del empleado {0}", i + 1)
            d.SetValue(Convert.ToDouble(Console.ReadLine()), i)

        Next

        Dim e As Double = 5
        Dim f = ""
        Dim g = 0

        For i = 0 To a - 1
            Dim h As String = b.ElementAt(i)
            Dim j As String = c.ElementAt(i)
            Dim k As String = d.ElementAt(i)
            Dim l As Double = j * e
            Dim m As Double = l * k

            Console.WriteLine("El empleado {0} trabaja {1} horas a la semana, el salario semanal corresponde a: ${2}", h, l, m)

            If l > g Then
                g = l
                f = h
            End If

        Next
        Console.WriteLine("El empleado que trabajo mas horas es: {0}, trabajo {1} horas durante la semana", f, g)

        Console.ReadLine()

    End Sub
End Module
