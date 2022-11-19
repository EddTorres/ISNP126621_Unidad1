Module Ejercicio08
    Sub Main()

        Console.WriteLine("Calcular la inversion final en los años indicados.")

        Dim i, h As Integer
        Dim a, c, e, f, g As Decimal
        Dim b As Double = 15

        Console.WriteLine("Ingrese depósito de cada mes:")
        a = Console.ReadLine
        c = a * 12

        Console.WriteLine("Ingrese la cantidad de años:")
        h = Console.ReadLine

        For i = 1 To h

            e = c * (b / 100)
            Console.WriteLine("Total de interes acumulado en año {0}: ${1}", i, e)
            f = c + e
            Console.WriteLine("Total de inversion mas interes en año {0}: ${1}", i, f)
            g = f + c
            c = 0
            c += g
        Next

        Console.WriteLine("Total de inversion al final del año {0}: ${1}", h, c)

        Console.ReadLine()

    End Sub
End Module
