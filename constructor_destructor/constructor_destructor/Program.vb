Imports System

Module Program
    Interface myinterface1
        Sub input1(ByVal a As Integer, ByVal b As Integer)
    End Interface
    Interface myinterface2
        Sub input2(ByVal a As Integer, ByVal b As Integer)
    End Interface
    Class demo
        Implements myinterface1, myinterface2
        Public Sub input1(a As Integer, b As Integer) Implements myinterface1.input1
            Console.WriteLine("For Addition and Multiplication")
            Dim c, d As Integer
            Console.WriteLine("Enter value of a")
            a = Console.ReadLine

            Console.WriteLine("Enter value of b")
            b = Console.ReadLine
            c = a + b
            Console.WriteLine("Addition={0}", c)
            d = a - b
            Console.WriteLine("Subtraction={0}", d)
        End Sub
        Public Sub input2(a As Integer, b As Integer) Implements myinterface2.input2
            Console.WriteLine("For Multiplication and division")
            Dim g, h As Integer
            Console.WriteLine("Enter value of a")
            a = Console.ReadLine
            Console.WriteLine("Enter value of b")
            b = Console.ReadLine
            g = a * b
            Console.WriteLine("Multiplication={0}", g)
            h = a Mod b
            Console.WriteLine("Division={0}", h)
        End Sub
    End Class
    Sub Main()
        Dim obj As myinterface1 = New demo
        obj.input1(2, 5)
        Dim obj1 As myinterface2 = New demo
        obj1.input2()
        Console.ReadKey()
    End Sub
End Module
