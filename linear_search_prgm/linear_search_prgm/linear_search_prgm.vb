Module linear_search_prgm

    Sub Main()
        Dim arr(5) As Integer
        Dim num, i, count As Integer
        count = 0
        Console.WriteLine("enter element of array:")
        For i = 0 To 4 Step 1
            arr(i) = Console.ReadLine

        Next
        Console.WriteLine("Enter the value for searching :")
        num = Console.ReadLine
        For i = 0 To 4 Step 1
            If arr(i) = num Then
                count += 1
            End If
        Next
        If count = 0 Then
            Console.WriteLine("value not found ")
        Else
            Console.WriteLine("value found")
        End If
        Console.ReadKey()




    End Sub

End Module
