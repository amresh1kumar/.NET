Module Module1
    Public Class Rectangle
        Public length As Integer
        Public Breadth As Integer

        Public Sub setLength(ByVal len As Integer)
            length = len
        End Sub

        Public Sub setBreadth(ByVal bre As Integer)
            Breadth = bre
        End Sub

        Public Function GetArea() As Integer
            Return length * Breadth
        End Function

        Public Function GetParameter() As Integer
            Return 2 * (length + Breadth)
        End Function
    End Class


    Sub Main()
        Dim rect As Rectangle = New Rectangle() 'create an object 
        Dim rect2 As Rectangle = New Rectangle() 'create an object 
        Dim area, para As Integer
        'rect specification 
        rect.setLength(5)
        rect.setBreadth(6)

        'rect2 specification 
        rect2.setLength(5)
        rect2.setBreadth(10)

        'Area of rectangle 
        area = rect.GetArea()
        Console.WriteLine(" Area of Rectangle is {0}", area)
        para = rect2.GetParameter()
        Console.WriteLine(" Parameter of Rectangle is {0}", para)
        Console.WriteLine(" Press any key to exit...")
        Console.ReadKey()
    End Sub

End Module
