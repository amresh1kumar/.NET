Imports System

Module Program
    Class A
        Public Overridable Sub input()
            Console.WriteLine("INSIDE A")
        End Sub
    End Class

    Class B : Inherits A
        Public Overrides Sub input()
            Console.WriteLine("INSIDE B")
        End Sub
    End Class

    Sub Main()
        Dim obj As B = New B
        obj.input()
        Dim obj1 As A = New A
        obj1.input()
        Console.ReadKey()
    End Sub
End Module
