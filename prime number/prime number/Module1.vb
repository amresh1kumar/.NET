Module Module1

    Sub Main()
        Dim choice As String
        Dim i As Integer
        Dim j As Integer


        Console.WriteLine("what is your choice :")
        choice = Console.ReadLine
        Select Case choice
            Case "ch1"
                For i = 2 To 100
                    Dim num As Boolean = True
                    For j = 1 To i - 1
                        If i Mod j = 0 Then
                            num = False
                            Exit For

                        End If
                        Console.WriteLine(i)

                    Next
                    If num Then

                    End If
                Next

        End Select

    End Sub

End Module
