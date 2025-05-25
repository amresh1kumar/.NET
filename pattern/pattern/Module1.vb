Module Module1

    Sub Main()
        Dim choice As String
        Dim i As Integer
        Dim j As Integer
        Console.WriteLine("enter your choice:")
        choice = Console.ReadLine
        'Print 1
        'print 1 2
        'Print 1 2 3
        'Print 1 2 3 4 

        Select Case choice
            Case "ch1"
                For i = 1 To 4

                    For j = 1 To i
                        Console.Write(j)
                    Next
                    Console.WriteLine()

                Next
                'case 2 
                'Print 1 1 1 1
                'Print 2 2 2
                'Print 3 3
                'Print 4
            Case "ch2"
                For i = 1 To 5 Step 1
                    For j = 1 To 5 - i Step 1
                        Console.Write(i & " ")

                    Next
                    Console.WriteLine()

                Next
                Console.ReadKey()




        End Select

    End Sub

End Module
