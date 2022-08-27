Imports System
Imports System.Console
Module Program
    Sub Main(args As String())
        Dim N_1, N_2, N_3, P, S, T As Integer
        WriteLine("************************************")
        Write("Número 1: ")
        N_1 = ReadLine()
        Write("Número 2: ")
        N_2 = ReadLine()
        Write("Número 3: ")
        N_3 = ReadLine()
        WriteLine("")
        If ((N_1 > N_2) And (N_1 > N_3)) Then
            P = N_1
            If (N_2 > N_3) Then
                S = N_2
                T = N_3
            Else
                S = N_3
                T = N_2
            End If
        Else
            If (N_2 > N_3) Then
                P = N_2
                If (N_1 > N_3) Then
                    S = N_1
                    T = N_3
                Else
                    S = N_3
                    T = N_1
                End If
            Else
                P = N_3
                If (N_1 > N_2) Then
                    S = N_1
                    T = N_2
                Else
                    S = N_2
                    T = N_1
                End If
            End If
        End If
        WriteLine("*************************************")
        WriteLine("Resultado:")
        WriteLine(P)
        WriteLine(S)
        WriteLine(T)
        ReadLine()
    End Sub
End Module
