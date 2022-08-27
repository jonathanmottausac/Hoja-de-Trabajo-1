Imports System
Module Program
    Sub Main(args As String())
        Dim cont As Double
        Dim num1 As Double
        Console.Write("Ingresar Numero:")
        num1 = Console.ReadLine()
        If num1 >= 0 Then
            Console.WriteLine("************************************")
            Console.WriteLine("El número es positivo")
            While cont <= num1
                cont = cont + 2
                Console.WriteLine(cont - 2)
            End While
        End If
        If num1 < 0 Then
            Console.WriteLine("************************************")
            Console.WriteLine("El número es negativo")
            For i = 0 To num1 Step -0.5
                Console.WriteLine(i)
            Next
        End If
    End Sub
End Module