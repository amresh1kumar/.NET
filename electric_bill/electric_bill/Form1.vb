Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim unit As Double
        Dim bill As Double
        unit = TextBox1.Text

        If (unit <= 50) Then
            bill = unit * 0.5

        ElseIf (unit <= 100) Then
            bill = 50 * 5 + (unit - 50) * 0.75

        ElseIf (unit <= 200) Then
            bill = 50 * 5 + 100 * 0.75 + (unit - 100) * 1.2

        ElseIf (unit <= 250) Then
            bill = 50 * 5 + 100 * 0.75 + 100 * 1.5 + (unit - 200) * 1.5
        End If
        bill = 50 * 5 + 100 * 0.75 + 100 * 1.5 + (unit - 250) * 1.5
        bill = bill * 1.2
        bill = Val(TextBox2.Text)



    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
