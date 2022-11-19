Module Ejercicio04
    Sub Main()

        Console.WriteLine("Calcular poliza total en base a variantes indicadas.")


        Dim poliza As String
        Console.WriteLine("Escriba si su poliza es tipo A o B:")
        poliza = Console.ReadLine()
        Dim cuota As Double = 500
        Dim porcentaje As Double = 0
        Dim edad As Integer
        Dim adicional As Double = cuota * (porcentaje / 100)
        Dim final As Double = cuota + adicional

        If poliza = "B" Then
            cuota = 250
        End If

        Console.WriteLine("¿Bebe alcohol? [Si/No]")

        If Console.ReadLine() = "Si" Then
            Console.WriteLine("Se le sumara 10% a su cargo final")
            porcentaje += 10
        End If

        Console.WriteLine("¿Utiliza lentes? [Si/No]")

        If Console.ReadLine() = "Si" Then
            Console.WriteLine("Se le sumara 5% a su cargo final")
            porcentaje += 5
        End If

        Console.WriteLine("¿Padece alguna enfermedad? [Si/No]")

        If Console.ReadLine() = "Si" Then
            Console.WriteLine("Se le sumara 5% a su cargo final")
            porcentaje += 5
        End If

        Console.WriteLine("Introduzca la edad: ")

        edad = Console.ReadLine

        If edad > 40 Then
            Console.WriteLine("Se le sumara 20% a su cargo final")
            porcentaje += 20
        Else
            Console.WriteLine("Se le sumara 10% a su cargo final")
            porcentaje += 10
        End If

        Console.WriteLine("Cuota  de poliza base:${0}", cuota)
        Console.WriteLine("Porcentaje aplicado:   {0} %", porcentaje)
        Console.WriteLine("Adicional agregado:    ${0}", adicional)
        Console.WriteLine("Cuota de poliza final: ${0}", final)

        Console.ReadLine()

    End Sub


End Module
