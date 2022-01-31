Imports System

Module Program
    Sub Main()

        Dim ej As Integer


        Console.WriteLine("Digite el ejercicio que desea aplicar")

        Console.WriteLine("1. positivo y par")
        Console.WriteLine("2. cubo de un entero y multiplo de 3")
        Console.WriteLine("3. cuadrado de un entero y multiplo de 4")
        Console.WriteLine("4. Ponderacion cualitativa")
        Console.WriteLine("5. Pago de los galones")
        Console.WriteLine("6. Monto del internet")
        Console.WriteLine("7. Sueldo por horas")
        Console.WriteLine("8. Calcular intereses")
        Console.WriteLine("9. dos numero y saber cual es positivo")
        Console.WriteLine("10. suma de 3 numeros y inprimir")
        Console.WriteLine("11. suma de 3 numeros impares y imprimir")
        Console.WriteLine("12. iva")


        ej = Console.ReadLine()

        Select Case ej

            Case 1

                'Determinar si un numero es positivo  y par

                Dim n1 As Decimal

                Console.WriteLine("Digite su número para saber si es par y positivo")
                n1 = Console.ReadLine()

                If (n1 Mod 2 = 0) Then
                    Console.WriteLine("El número es par")
                Else
                    Console.WriteLine("El número es impar")
                End If

                If (n1 > 0) Then
                    Console.WriteLine("El número es positivo")
                Else
                    Console.WriteLine("El número es negativo")
                End If

            Case 2

                'calcular el cubo de un número entero ingresado por el usuario solo si, el número es multipo de 3 y 5.

                Dim n As Integer


                Console.WriteLine("Ingrese un número entero que sea multiplo de 3")
                n = Console.ReadLine()

                'If (n > 0) And (n Mod 3 = 0) Then

                'n ^= 3
                'Console.WriteLine("El resultado es: " & n)

                'Else

                'Console.WriteLine("El número ingresado no es entero, ingrese nuevamente un numero entero y multiplo de 3 y 5")
                'n = Console.ReadLine()

                'If (n > 0) And (n Mod 3 = 0) Then

                'n ^= 3
                'Console.WriteLine("El resultado es: " & n)

                'Else

                'End If
                'End If

                If (n > 0) And (n Mod 3 = 0) Then
                    n ^= 3
                    Console.WriteLine("El resultado es: " & n)
                Else
                    Do
                        Console.WriteLine("El numero no era entero o multiplo de 3, ingrese nuevamente")
                        n = Console.ReadLine()

                    Loop Until (n > 0) And (n Mod 3 = 0)

                    n ^= 3
                    Console.WriteLine("El resultado es: " & n)

                End If

            Case 3

                'calcular el cuadrado de un nuemro entero ingresado por el usuario solo si, el numero es multipo  de 4 y 16

                Dim num As Integer

                Console.WriteLine("Ingrese un nuemro entero multiplo de 4")
                num = Console.ReadLine()


                If (num Mod 4 = 0) And (num > 0) Then

                    num ^= 2
                    Console.WriteLine("El total es: " & num)

                Else
                    Do

                        Console.WriteLine("El numero inresado no era entero ni multiplo de 4, vuelva e ingrese el numero")
                        num = Console.ReadLine()

                    Loop Until (num Mod 4 = 0) And (num > 0)


                    num ^= 2
                    Console.WriteLine("El total es: " & num)

                End If

            Case 4

                'Realizar un algoritmo que permita dar una poderacion cualitativa, según una nota cuantitativa: 

                Dim nota As Integer


                Console.WriteLine("Ingrese la nota para uan ponderación cualitativa")
                nota = Console.ReadLine()


                If (nota >= 0 And nota <= 40) Then
                    Console.WriteLine("Pésimo, Aplazado sin oportunidad")
                ElseIf (nota >= 41 And nota <= 45) Then
                    Console.WriteLine("Deficiente, Aplazado a reparación")
                ElseIf (nota >= 46 And nota <= 50) Then
                    Console.WriteLine("Bajo, Aplazado repetir examen")
                ElseIf (nota >= 51 And nota <= 60) Then
                    Console.WriteLine("Regular, No aplazado – Remedial")
                ElseIf (nota >= 61 And nota <= 70) Then
                    Console.WriteLine("Bien")
                ElseIf (nota >= 71 And nota <= 80) Then
                    Console.WriteLine("Muy bien")
                ElseIf (nota >= 81 And nota <= 100) Then
                    Console.WriteLine("Excelente")
                End If

            Case 5

                'Calcular el pago por galones de gasolina de una estación de servicio, según el tipo de gasolina
                'Gasolina Premium Extra: 1 litro: 5.000 pesos
                'Gasolina Premium: 1 litro: 3.900 pesos
                'Gasolina Corriente: 1 litro 3.200 pesos
                'Se debe mostrar la cantidad de gasolina expresada en galones y litros, el cliente pide en galones.

                Dim opt As Integer
                Dim gal As Decimal
                Dim lit As Decimal
                Dim valor As Decimal

                Dim constL As Decimal = 3.78541


                Console.WriteLine("¿Qué cantidad en galones desea?")
                gal = Console.ReadLine()

                Console.WriteLine("¿Qué obcion desea: ")
                Console.WriteLine("1. Gasolina Premium Extra: 1 litro: 5.000 pesos")
                Console.WriteLine("2. Gasolina Premium: 1 litro: 3.900 pesos")
                Console.WriteLine("3. Gasolina Corriente: 1 litro 3.200 pesos")
                opt = Console.ReadLine()


                Select Case opt

                    Case 1

                        Console.WriteLine("Gasolina Premium Extra: 1 litro: 5.000 pesos")
                        Console.WriteLine("La cantidad pedida fue: " & gal & " Galones")

                        lit = gal * constL
                        Console.WriteLine("La cantidad en litros es: " & lit & " Litros")

                        valor = lit * 5000
                        Console.WriteLine("La cantidad a pagar es: " & valor & " Pesos")

                    Case 2

                        Console.WriteLine("Gasolina Premium: 1 litro: 3.900 pesos")
                        Console.WriteLine("La cantidad pedida fue: " & gal & " Galones")

                        lit = gal * constL
                        Console.WriteLine("La cantidad en litros es: " & lit & " Litros")

                        valor = lit * 3900
                        Console.WriteLine("La cantidad a pagar es: " & valor & " Pesos")

                    Case 3

                        Console.WriteLine("Gasolina Corriente: 1 litro 3.200 pesos")
                        Console.WriteLine("La cantidad pedida fue: " & gal & " Galones")

                        lit = gal * constL
                        Console.WriteLine("La cantidad en litros es: " & lit & " Litros")

                        valor = lit * 3200
                        Console.WriteLine("La cantidad a pagar es: " & valor & " Pesos")

                End Select

            Case 6

                 'Calcular el monto a pagar por el servicio de internet según el nivel del cliente y la cantidad de MB:


                    'Canda MB tiene un precio de: 
                    'Nivel 1 : 5000 pesos
                    'Nivel 2 : 7000 pesos
                    'Nivel 3 : 9000 pesos
                    'Nivel 4 : 15000 pesos
                    'Nivel 5 : 22000 pesos
                    'Nivel 6 : 30000 pesos
                    'Todos los demás niveles 35000 pesos

            Case 7

                'Calcular el sueldo a pagar de un trabajador dado que se debe ingresar la cantidad de horas trabajadas y el valor de la hora en pesos

                Dim salario As Integer
                Dim horas As Integer

                Dim pxh As Integer = 7000

                Console.WriteLine("Coloque sus horas tabajadas")
                horas = Console.ReadLine()
                salario = horas * pxh
                Console.WriteLine("Su salaio es: " & salario & " Pesos")

            Case 8

                'Calcular el interés a pagar por un dinero, colocado a generar interés diario.
                'se debe ingresar la cantidad de dinero, los días que lleva generando interés
                'y el interés. Se debe imprimir el interés y la cantidad de dinero más el interés.

                Dim interes As Decimal = (0.03)
                Dim dinero As Decimal
                Dim dias As Integer
                Dim dinInt As Decimal
                Dim toDias As Decimal

                Console.WriteLine("Ingrese el valor que desea retirar")
                dinero = Console.ReadLine()

                Console.WriteLine("Ingrese los días por los que adquirira el prestamo")
                dias = Console.ReadLine

                interes = dinero * (interes)
                Console.WriteLine("El interes por día es: " & interes & " Pesos")

                toDias = interes * dias
                Console.WriteLine("El total de interes por los dias es: " & toDias & " Pesos")

                dinInt = toDias + dinero
                Console.WriteLine("El total a pagar depues de los " & dias & " dias es: " & dinInt & " Pesos")

            Case 9

                'leer dos numeros y determinar ¿cual es positivo?

                Dim n1 As Decimal
                Dim n2 As Decimal

                Console.WriteLine("Ingrese un numero negativo o positivo")
                n1 = Console.ReadLine

                Console.WriteLine("Vuelva he ingrese un numero positivo o negativo")
                n2 = Console.ReadLine

                If n1 > 0 Then
                    Console.WriteLine("El numero " & n1 & " es un numero positivo")
                Else
                    Console.WriteLine("El numero " & n2 & " es un numero positivo")
                End If

            Case 10

                'Realizar un pseudocódigo que sume 3 números e imprimir la suma

                Dim n1 As Decimal
                Dim n2 As Decimal
                Dim n3 As Decimal
                Dim resultado As Decimal


                Console.WriteLine("Ingrese tres numeros para realizar la suma")

                n1 = Console.ReadLine()
                n2 = Console.ReadLine()
                n3 = Console.ReadLine()

                resultado = n1 + n2 + n3

                Console.WriteLine("El total de la suma es: " & resultado)

            Case 11


                Dim n1 As Decimal
                Dim n2 As Decimal
                Dim n3 As Decimal
                Dim resultado As Decimal

                Console.WriteLine("Por favor ingrese 3 numeros impares para la suma")

                n1 = Console.ReadLine()
                n2 = Console.ReadLine()
                n3 = Console.ReadLine()

                If (n1 Mod 2 <> 0) And (n2 Mod 2 <> 0) And (n3 Mod 2 <> 0) Then

                    resultado = n1 + n2 + n3
                    Console.WriteLine("El resultado es: " & resultado)

                Else
                    Do
                        Console.WriteLine("Algun numero no es impar, vuelva he intente")
                        n1 = Console.ReadLine()
                        n2 = Console.ReadLine()
                        n3 = Console.ReadLine()

                    Loop Until (n1 Mod 2 <> 0) And (n2 Mod 2 <> 0) And (n3 Mod 2 <> 0)

                    resultado = n1 + n2 + n3
                    Console.WriteLine("El resultado es: " & resultado)

                End If

            Case 12

                'Dado una compra realizada calcular: El iva e imprimir: la compra sin iva, el iva en pesos y el monto con el iva. Tomar en cuenta que el iva es el 19%

                Dim iva As Decimal = 0.19
                Dim compra As Decimal
                Dim tCompra As Decimal
                Dim tiva As Decimal

                Console.WriteLine("Coloque el monto a pagar")
                compra = Console.ReadLine()

                Console.WriteLine("El total de la compra es: " & compra)

                tiva = compra * iva
                Console.WriteLine("El total del impuesto es: " & tiva)

                tCompra = compra + tiva
                Console.WriteLine("El total con el iva es: " & tCompra)

        End Select

    End Sub
End Module
