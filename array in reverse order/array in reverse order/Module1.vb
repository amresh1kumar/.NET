Module Module1

    Sub Main()
        Dim arr(5), i, j As Integer

        Console.WriteLine("enter array elements")
        For i = 0 To 5 Step 1
            arr(i) = Console.ReadLine

        Next

        For i = 0 To 5 Step 1
            Console.WriteLine("array elements are:{0}", arr(i))
        Next
        For i = arr.Length - 1 To 0 Step -1
            'arr(j) = Console.ReadLine
            Console.WriteLine("array in reverse order:{0}", arr(i))

        Next
        Console.ReadLine()
    End Sub

End Module
