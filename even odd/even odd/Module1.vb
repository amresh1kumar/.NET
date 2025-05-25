Module Module1

    Sub Main()
        Dim ch As Integer
        Dim i As Integer
        Console.WriteLine("enter your choice")
        ch = Console.ReadLine

        Select Case ch

            Case 1
                For i = 1 To 100 Step 1
                    If (i Mod 2 = 0) Then
                        'Console.Write("even number is:{0}", i)
                        Console.WriteLine()
                    Else
                        'Console.Write("odd number is :{0}", i)
                    End If

                Next

            Case 2
                For i = 1 To 100 Step 1
                    If (i Mod 2 = 0) Then
                        Console.Write("even number is:{0}", i)

                    Else
                        Console.Write("odd number is :{0}", i)
                        Console.WriteLine()
                    End If

                Next

            Case 3
                For i = 1 To 5 Step 1
                    For j = 1 To 5 - i
                        Console.WriteLine(i)
                    Next
                    Console.WriteLine()

                Next
                Console.ReadLine()
        End Select


    End Sub

End Module
