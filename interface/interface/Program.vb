Imports System

Module Program
    Interface student
        Sub input(ByVal a As Integer)

    End Interface
    Class studentdetail
        Implements student

        Public Sub input(ByVal a As Integer) Implements student.input
            Console.WriteLine("Roll no of student:{0}", a)

        End Sub
    End Class
    Class B
        Implements student

        Public Sub input(ByVal a As Integer) Implements student.input
            Console.WriteLine("Roll no of student:{0}", a)

        End Sub
    End Class
    Sub Main()
        Dim obj As student = New studentdetail
        Dim q As student = New B
        obj.input("123")
        obj.input("1")
        Console.ReadKey()




    End Sub
End Module
