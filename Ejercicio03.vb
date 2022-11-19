Module Ejercicio03
    Sub Main()

        Console.WriteLine("Determinar en base al monto de compra el descuento a aplicar y total a pagar")

        Dim mon, tot As Decimal

        Console.WriteLine("Escriba el numero monto de compra:")
        mon = Console.ReadLine

        If mon > 0 And mon < 250 Then
            Console.WriteLine("Su descuento es de 5%")
            tot = mon - mon * 0.05
            Console.WriteLine("Su total es: {0} ", tot)
        ElseIf 250 <= mon And mon < 500 Then
            Console.WriteLine("Su descuento es de 10%")
            tot = mon - mon * 0.1
            Console.WriteLine("Su total es: {0} ", tot)
        ElseIf 500 <= mon And mon < 1000 Then
            Console.WriteLine("Su descuento es de 20%")
            tot = mon - mon * 0.2
            Console.WriteLine("Su total es: {0} ", tot)
        ElseIf 1000 <= mon Then
            Console.WriteLine("Su descuento es de 30%")
            tot = mon - mon * 0.3
            Console.WriteLine("Su total es: {0} ", tot)
        Else
            Console.WriteLine("Su monto de compra no es valido, validar por favor.")


        End If

        Console.ReadLine()

    End Sub

End Module
