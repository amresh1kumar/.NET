Module nested_for_loop_pattern

    Sub Main()
        Dim i As Integer = 5
        Dim ch As String

        Console.WriteLine("what is your choice :")
        ch = Console.ReadLine
        Select Case ch
            Case "ch1"

                While i >= 1
                    Dim j As Integer = 1
                    While j <= i
                        Console.Write("*")
                        j += 1

                    End While
                    Console.WriteLine()
                    i -= 1
                End While

            Case "ch2"
                For i = 5 To 1 Step -1

                    For j = 1 To i Step 1
                        Console.Write("*")
                    Next
                    Console.WriteLine()

                Next


        End Select

    End Sub

End Module
