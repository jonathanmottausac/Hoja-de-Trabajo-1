Imports System

Module Program
    Sub Main(args As String())
        Dim Ladoa, Ladob, Ladoc As Double
        Console.Write("Lado A: ")
        Ladoa = Double.Parse(Console.ReadLine())
        Console.Write("Lado B: ")
        Ladob = Double.Parse(Console.ReadLine())
        Console.Write("Lado c: ")
        Ladoc = Double.Parse(Console.ReadLine())
        If Ladoa = Ladob And Ladoa = Ladoc Then
            Console.WriteLine("*********************************")
            Console.WriteLine("Resultado")
            Console.WriteLine("Equilatero")
        End If
        If (Ladoa = Ladob And Ladoa <> Ladoc) Or (Ladoa = Ladoc And Ladoa <> Ladob) Or (Ladob = Ladoc And Ladob <> Ladoa) Then
            Console.WriteLine("*********************************")
            Console.WriteLine("Resultado")
            Console.WriteLine("Isosceles")
        End If
    End Sub
End Module