Module Ejercicio05

    Sub Main()

        Console.WriteLine("Calcular la suma de numeros consecutivos desde uno hasta el numero indicado")

        Dim num, tot As Integer

        Console.WriteLine("Escriba el numero hasta donde desea calcular la suma total:")
        num = Console.ReadLine

        tot = (num * (num + 1) / 2)
        Console.WriteLine("El total de la suma es: {0}", tot)

        Console.ReadLine()

    End Sub

End Module
