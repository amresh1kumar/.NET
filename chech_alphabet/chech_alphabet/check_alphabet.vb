Module check_alphabet

    Sub Main()
        Dim ch As Char
        Dim ch1 As Double

        Dim choice As Integer

        Console.WriteLine("enter your choice")
        choice = Console.ReadLine
        Select Case choice
            Case 1
                Console.WriteLine("enter any character")
                ch = Console.ReadLine
                If ch >= "a" And ch <= "z" Or ch >= "A" And ch <= "Z" Then
                    Console.WriteLine("{0} is alphabet", ch)
                Else
                    Console.WriteLine("{0} is not alphabet", ch)

                End If
            Case 2
                Console.WriteLine("enter any character")
                ch1 = Console.ReadLine
                If ch1 > 65 And ch1 <= 91 Or ch1 >= 97 And ch1 <= 123 Then
                    Console.WriteLine("{0} is alphabet", ch1)
                Else
                    Console.WriteLine("{0} is not alphabet", ch1)

                End If

        End Select



    End Sub

End Module
