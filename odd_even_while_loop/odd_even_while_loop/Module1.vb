Module Module1

    Sub Main()
        Dim choice As String
        Dim i As Integer
        Console.WriteLine("what is your choice :")
        choice = Console.ReadLine
        Select Case choice
            Case "ch"
                While (i <= 20)
                    If (i Mod 2 = 0) Then
                        i = i + 1
                        Console.WriteLine("the number is even:{0}", i)
                        Console.WriteLine()
                    Else
                        Console.WriteLine("the number is odd :{0}", i)
                    End If
                End While
        End Select


    End Sub

End Module
