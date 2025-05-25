Module Module1

    Sub Main()
        Dim a As Integer
        Dim b As Long
        Dim c, r As Double
        Dim k As Single = 2.5

        a = 10
        Console.WriteLine("the integer value of a is {0}", a)
        b = a
        Console.WriteLine("the long value of b after conversion int to long is {0}", b)
        c = b
        Console.WriteLine("the double value of c after conversion long to double is {0}", c)
        Console.WriteLine("the single value of k before conversion is {0}", k)
        Console.WriteLine("the double value of r after conversion single to double is {0}", r)
        Console.ReadKey()

    End Sub

End Module
