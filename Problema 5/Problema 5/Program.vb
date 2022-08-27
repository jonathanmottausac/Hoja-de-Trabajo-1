Imports System

Module Program
    Sub Main(args As String())
        Dim nota1, nota2, nota3, prom As Integer

        Console.Write("Nota Matemática:")
        nota1 = Console.ReadLine()
        Console.Write("Nota Física:")
        nota2 = Console.ReadLine()
        Console.Write("Nota Programación:")
        nota3 = Console.ReadLine()
        prom = ((nota1 + nota2 + nota3) / 3)

        If prom < 61 Then
            Console.WriteLine("***********************************")
            Console.WriteLine("Resultado:")
            Console.WriteLine("Promedio: " & prom)
            Console.WriteLine("Reprobado")
        End If
        If prom >= 61 And prom < 81 Then
            Console.WriteLine("***********************************")
            Console.WriteLine("Resultado:")
            Console.WriteLine("Promedio: " & prom)
            Console.WriteLine("Regular")
        End If
        If prom > 80 Then
            Console.WriteLine("***********************************")
            Console.WriteLine("Resultado:")
            Console.WriteLine("Promedio: " & prom)
            Console.WriteLine("Excelente")
        End If

    End Sub
End Module