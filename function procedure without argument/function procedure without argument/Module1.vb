Module Module1

    Function square() As Integer
        Dim a As Integer = 8
        Dim s As Integer
        s = a * a
        Return s


    End Function

    Sub Main()

        Dim x As Integer
        x = square() 'function call'
        Console.WriteLine("square {0}", x)
        Console.ReadKey()
    End Sub

End Module
