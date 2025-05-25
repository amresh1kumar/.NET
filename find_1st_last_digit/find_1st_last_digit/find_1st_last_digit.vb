Module find_1st_last_digit

    Sub Main()

        Dim first, last, n As Integer
        Console.WriteLine("enter any value")
        n = Console.ReadLine
        last = n Mod 10
        Console.WriteLine("last : {0} ", last)
        Do
            n = n / 10
            first = n
        Loop While n >= 10
        Console.Write("first {0}  ", first)



        Console.ReadKey()
        'While (n >= 10)
        'n = n / 10
        'first = n
        'End While
        'Console.WriteLine("first : {0}", first)
        Console.ReadKey()

    End Sub

End Module
