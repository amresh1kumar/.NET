Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form2_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Form1.Show()

    End Sub
End Class