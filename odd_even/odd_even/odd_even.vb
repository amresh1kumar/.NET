Module odd_even

    Sub Main()
        Dim choice As String
        Dim i As Integer
        Console.WriteLine("what is your choice :")
        choice = Console.ReadLine
        Select Case choice
            Case "ch"
                For i = 1 To 200 Step 1
                    If (i Mod 2 = 0) Then
                        Console.WriteLine("the number is even:{0}", i)
                        Console.WriteLine()
                    Else
                        Console.WriteLine("the number is odd :{0}", i)
                    End If

                Next
            Case "ch1"
                For i = 1 To 200 Step 1
                    If (i Mod 2 = 0) Then
                        'Console.WriteLine("the number is even:{0}", i)
                        ' Console.WriteLine()
                    Else
                        Console.WriteLine("the number is odd :{0}", i)
                        Console.WriteLine()
                    End If

                Next

                Console.ReadKey()
        End Select


    End Sub

End Module
