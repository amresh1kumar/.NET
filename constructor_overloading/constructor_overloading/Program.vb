Imports System

Module Program
    Public Class calculate
        Public Sub New(ByVal radius As Decimal)
            Dim circle As Decimal
            Console.WriteLine("Enter radius of circle :")
            radius = Console.ReadLine
            circle = 3.14 * radius * radius
            Console.WriteLine("Area of circle is {0}", circle)
        End Sub
        Public Sub New(ByVal length As Decimal, ByVal width As Decimal)
            Dim reactangle As Decimal
            Console.WriteLine("Enter length of reactangle :")
            length = Console.ReadLine
            Console.WriteLine("Enter width of reactangle :")
            width = Console.ReadLine
            reactangle = length * width
            Console.WriteLine("Area of circle is {0}", reactangle)
        End Sub
    End Class
    Sub Main()
        Dim r, l, w As Integer
        Dim o1 As calculate = New calculate(r)
        Dim o2 As calculate = New calculate(l, w)
    End Sub
End Module
