Module Module1

    Sub Main()


        Dim choice As String
        Dim length As Integer
        Dim breadth As Integer
        Dim react_area As Integer
        Dim square_area As Integer
        Console.WriteLine("what is your choice: ")
        choice = Console.ReadLine

        Select Case choice

            Case "rectangle"

                Console.WriteLine("Enter the value of length: ")
                length = Console.ReadLine

                Console.WriteLine("Enter the value of breadth: ")
                breadth = Console.ReadLine

                react_area = length * breadth

                Console.WriteLine("The area of the rectangle is: {0}", react_area)

            Case "square"

                Console.WriteLine("Enter the value of length ")
                length = Console.ReadLine
                square_area = length * length
                Console.WriteLine("The area of the square is: {0}", square_area)

        End Select


    End Sub

End Module