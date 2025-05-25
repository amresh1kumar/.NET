Module Module1
    Class User
        Public name, location As String
        ' Default Constructor
        Public Sub New()
            name = "Suresh Dasari"
            location = "Hyderabad"
        End Sub
        ' Parameterized Constructor
        Public Sub New(ByVal a As String, ByVal b As String)
            name = a
            location = b
        End Sub
    End Class
    Sub Main()
        ' Default Constructor will be called
        Dim user As User = New User()
        ' Parameterized Constructor will be called
        Dim user1 As User = New User("Rohini Alavala", "Guntur")
        Console.WriteLine(user.name & ", " & user.location)
        Console.WriteLine(user1.name & ", " & user1.location)
        Console.WriteLine(vbLf & "Press Enter Key to Exit..")
        Console.ReadLine()
    End Sub
End Module