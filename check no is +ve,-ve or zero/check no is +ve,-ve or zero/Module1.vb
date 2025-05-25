Module Module1

    Sub Main()
        Dim num As Integer
        Console.WriteLine("Enter number for num")
        num = Console.ReadLine
        If (num > 0) Then
            Console.WriteLine("{0} is positive", num)
        ElseIf (num < 0) Then
            Console.WriteLine("{0} is negative", num)
        Else
            Console.WriteLine("{0} is zero", num)
        End If
        Console.ReadKey()
    End Sub

End Module
