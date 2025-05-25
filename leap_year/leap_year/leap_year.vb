Module leap_year

    Sub Main()
        Dim year As Integer
        Console.WriteLine("enter year :")
        year = Console.ReadLine
        If (year Mod 4 = 0) Then
            Console.WriteLine("enter year is leap year")
        ElseIf (year Mod 400 = 0) And Not (year Mod 100 = 0) Then
            Console.WriteLine("enter year is leap year")
        Else
            Console.WriteLine("enter year is not leap year")
        End If
        Console.ReadKey()

    End Sub


End Module
