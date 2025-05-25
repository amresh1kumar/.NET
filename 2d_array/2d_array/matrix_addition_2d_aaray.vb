Module matrix_addition_2d_aaray

    Sub Main()

        Dim array(2, 2) As Integer
        Dim arr(2, 2) As Integer
        Dim i, j, a, b, c, d As Integer
        Dim ch As String

        Dim sum(2, 2) As Integer
        Dim sub1(2, 2) As Integer

        Console.WriteLine("what is your choice:")
        ch = Console.ReadLine
        Select Case ch
            Case "1add"
                Console.WriteLine("Enter element for 1st matrix")
                For i = 1 To 2 Step 1
                    For j = 1 To 2 Step 1
                        array(i, j) = Console.ReadLine
                    Next
                Next
                Console.WriteLine("matrix 1st are:")
                For i = 1 To 2 Step 1
                    For j = 1 To 2 Step 1
                        Console.Write("[{0}]", array(i, j))

                    Next
                    Console.WriteLine()
                Next
                Console.WriteLine("Enter element for 2nd matrix")
                For a = 1 To 2 Step 1
                    For b = 1 To 2 Step 1
                        arr(a, b) = Console.ReadLine
                    Next
                Next
                Console.WriteLine("matrix 2nd are :")
                For a = 1 To 2 Step 1
                    For b = 1 To 2 Step 1
                        Console.Write("[{0}]", arr(a, b))

                    Next
                    Console.WriteLine()
                Next

                Console.WriteLine("addition of matrix is  :")
                For c = 1 To 2 Step 1
                    For d = 1 To 2 Step 1
                        sum(c, d) = array(i, j) + arr(a, b)
                        Console.Write("[{0}]", sum(c, d))
                    Next
                    Console.WriteLine()

                Next
            Case "2add"
                'for taking element in matrix 1st
                Console.WriteLine("Enter element for 1st matrix")
                For i = 1 To 2 Step 1
                    For j = 1 To 2 Step 1
                        array(i, j) = Console.ReadLine
                    Next
                Next
                'for print element of matrix 1st
                Console.WriteLine("matrix 1st are:")
                For i = 1 To 2 Step 1
                    For j = 1 To 2 Step 1
                        Console.Write("[{0}]", array(i, j))

                    Next
                    Console.WriteLine()
                Next
                'for taking element in matrix 2nd
                Console.WriteLine("Enter element for 2nd matrix")
                For i = 1 To 2 Step 1
                    For j = 1 To 2 Step 1
                        array(i, j) = Console.ReadLine
                    Next
                Next
                'for print element of matrix 2nd
                Console.WriteLine("matrix 2nd are :")
                For i = 1 To 2 Step 1
                    For j = 1 To 2 Step 1
                        Console.Write("[{0}]", array(i, j))

                    Next
                    Console.WriteLine()
                Next
                'for addition of two matrix
                Console.WriteLine("addition of matrix is  :")
                For i = 1 To 2 Step 1
                    For j = 1 To 2 Step 1
                        sum(i, j) = array(i, j)+array(i, j)
                        Console.Write("[{0}]", sum(i, j))
                    Next
                    Console.WriteLine()

                Next

            Case "3sub"
                'for taking element in matrix 1st
                Console.WriteLine("Enter element for 1st matrix")
                For i = 1 To 2 Step 1
                    For j = 1 To 2 Step 1
                        array(i, j) = Console.ReadLine
                    Next
                Next
                'for print element of matrix 1st
                Console.WriteLine("matrix 1st are:")
                For i = 1 To 2 Step 1
                    For j = 1 To 2 Step 1
                        Console.Write("[{0}]", array(i, j))

                    Next
                    Console.WriteLine()
                Next
                'for taking element in matrix 2nd
                Console.WriteLine("Enter element for 2nd matrix")
                For i = 1 To 2 Step 1
                    For j = 1 To 2 Step 1
                        array(i, j) = Console.ReadLine
                    Next
                Next
                'for print element of matrix 2nd
                Console.WriteLine("matrix 2nd are :")
                For i = 1 To 2 Step 1
                    For j = 1 To 2 Step 1
                        Console.Write("[{0}]", array(i, j))

                    Next
                    Console.WriteLine()
                Next
                'for subtraction of two matrix
                Console.WriteLine("subtraction of matrix is  :")
                For i = 1 To 2 Step 1
                    For j = 1 To 2 Step 1
                        sub1(i, j) = array(i, j) - array(i, j)
                        Console.Write("[{0}]", sub1(i, j))
                    Next
                    Console.WriteLine()

                Next

                Console.ReadKey()

        End Select

    End Sub

End Module
