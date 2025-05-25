Module Module1

    Sub Main()

        Dim i As Integer
        Dim j As Integer
        Dim ch As String

        Console.WriteLine("what is your ch")
        ch = Console.ReadLine
        Select Case ch
            Case "ch1"
                For i = 1 To 5 Step 1
                    For j = 1 To 5 - i Step 1
                        Console.Write(i & " ")

                    Next
                    Console.WriteLine()

                Next
        End Select
        Console.ReadKey()

    End Sub

End Module
