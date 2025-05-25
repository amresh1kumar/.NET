Module sum_array_element

    Sub Main()
        Dim arr(5) As Integer
        Dim i, j, n As Integer
        Dim sum As Integer = 0


        For i = 1 To 5
            Console.WriteLine("enter 5 element ")
            arr(i) = Console.ReadLine()

        Next
        For j = 1 To 5
            Console.Write("array element [{0}]", arr(j))
            sum = sum + arr(j)
            Console.WriteLine()


        Next
        Console.Write("sum all array element [{0}]", sum)

        Console.ReadKey()
    End Sub

End Module
