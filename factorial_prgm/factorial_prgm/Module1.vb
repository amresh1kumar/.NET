Module Module1

    Sub Main()
        Dim i, n As Integer
        Dim fact As Integer = 1


        Console.WriteLine("enter element ")
        n = Console.ReadLine()

        For i = 1 To n Step 1
            fact = fact * i
        Next
        Console.WriteLine("factorial is {1}={0}", fact, n)






        Console.ReadKey()


    End Sub

End Module
