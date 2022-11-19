Module Ejercicio07
    Sub Main()

        Console.WriteLine("Calcular el ahorro total en un año.")

        Dim rise As Double = 3
        Dim ahorro As Double
        Dim meses = New String() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
        Dim total As Double
        Dim mes As String

        Console.WriteLine("Ingrese ahorro mensual:")
        ahorro = Console.ReadLine
        For Each mes In meses
            total += ahorro + rise
            Console.WriteLine("{0} ${1}", mes, total)
        Next

        Console.WriteLine("El total ahorrado en un año es: ${0}", total)

        Console.ReadLine()

    End Sub

End Module
