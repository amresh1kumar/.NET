Module Module1

    Sub linear_search()
        Dim arr(2) As String
        Dim i, num, count As Integer
        ' Console.WriteLine("Take input from user")
        ' For i = 0 To 2 Step 1
        'arr(i) = Console.ReadLine
        '  Next

        ReDim Preserve arr(4)

        '  arr(3) = 15
        ' arr(4) = 16
        Console.WriteLine(" Again take input from user after resize of array")
        For i = 0 To 4 Step 1
            arr(i) = Console.ReadLine

        Next
        For i = 0 To 4 Step 1
            Console.WriteLine("array after preserv:{0}", arr(i))
        Next

        Console.WriteLine("Enter number for searching:")
        num = Console.ReadLine
        For i = 0 To 4 Step 1
            If arr(i) = num Then
                count += 1
            End If
        Next
        If count = 0 Then
            Console.WriteLine(" value not found")
        Else
            Console.WriteLine("value found")
        End If
        '  Console.ReadLine()


    End Sub
    Sub Main()

        linear_search()
        Console.ReadKey()



    End Sub

End Module
