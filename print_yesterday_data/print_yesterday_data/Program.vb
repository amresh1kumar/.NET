Imports System

Module Program
    Sub Main(args As String())
        'VB.NET program to print yesterday's date.

        Dim today As DateTime = DateTime.Now
            Dim yesterday As DateTime

            yesterday = today - New TimeSpan(1, 0, 0, 0)

            Console.WriteLine("Yesterday: {0}/{1}/{2}", yesterday.Day, yesterday.Month, yesterday.Year)

    End Sub
End Module
