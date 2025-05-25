Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim phy, che, bio, math, comp As Integer
        Dim per As Double
        phy = TextBox1.Text
        che = TextBox2.Text
        bio = TextBox3.Text
        math = TextBox4.Text
        comp = TextBox5.Text
        per = (phy + che + bio + math + comp) / 500 * 100
        TextBox6.Text = per

        If per >= 90 Then
            TextBox7.Text = "A"
        ElseIf per >= 80 Then
            TextBox7.Text = "B"
        ElseIf per >= 70 Then
            TextBox7.Text = "c"
        ElseIf per >= 60 Then
            TextBox7.Text = "D"
        ElseIf per >= 40 Then
            TextBox7.Text = "E"
        Else
            TextBox7.Text = "F"

        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class
