Imports System

Module Program
    Sub Main(args As String())
        'VB.NET program to print difference of two dates in days.

        Dim diff As TimeSpan
        Dim date1 As New DateTime(2020, 3, 22)
        Dim date2 As New DateTime(2021, 5, 25)

        diff = date2 - date1

        Console.WriteLine("Days: {0}", diff.TotalDays)

    End Sub
End Module
