

Module Module1
    Public Class B
        Public Overridable Sub GetInfo()
            Console.WriteLine("Learn C# Tutorial")
        End Sub
    End Class
    Public Class D
        Inherits B
        Public Overrides Sub GetInfo()
            Console.WriteLine("Welcome ")
        End Sub
    End Class
    Sub Main()
        Dim d As D = New D()
        d.GetInfo()
        Dim b As B = New B()
        b.GetInfo()
        Console.WriteLine("Press Enter Key to Exit..")
        Console.ReadLine()
    End Sub




End Module
