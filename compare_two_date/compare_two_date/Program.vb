Imports System

Module Program
    Sub Main(args As String())
        'VB.NET program to compare two dates.

        Dim date1 As New DateTime(2020, 3, 22)
        Dim date2 As New DateTime(2021, 5, 25)

        If (date1 < date2) Then
            Console.WriteLine("{0} is less than {1}", date1, date2)
        Else
            Console.WriteLine("{0} is less than {1}", date2, date1)
        End If

    End Sub
End Module
