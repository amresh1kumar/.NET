'Imports System.Data.OleDb
'Imports System.Data
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim user_name As String
        Dim email, phone_number As String
        user_name = TextBox1.Text
        'email = TextBox1.Text
        phone_number = TextBox1.Text
        Dim password As String
        password = TextBox2.Text
        If user_name = "" Or password = "" Then
            MsgBox("Please fill the all information")

        ElseIf TextBox1.Text = "amresh011" Or "123456" And TextBox2.Text = "2004" Then
            MsgBox("Login success")
            Form2.Show()
            Me.Hide()

        Else
            MsgBox("Login failed")

        End If

        'Dim pass As String

        ' If TextBox1.Text = "" Or TextBox2.Text = "" Then
        'MsgBox("Please Fill all the information")
        'Else
        'user_name = TextBox1.Text
        'password = TextBox2.Text

        'Dim querry As String = "Select Password From Table1 where Username = '" & user_name & "';"
        'Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Amresh\OneDrive\Documents\Database1.accdb"
        'Dim conne = New OleDbConnection(dbsource)
        'Dim cmd As New OleDbCommand(querry, conne)
        'conne.Open()

        'Try
        'pass = cmd.ExecuteScalar().ToString

        'Catch ex As Exception
        'MsgBox(" Username Does not exist")


        'End Try
        'If password = pass Then
        'MsgBox("Login Success")
        'Form2.Show()
        'If Form2.Visible Then
        'Me.Hide()
        '
        'End If
        'Else
        'MsgBox("Login Failed ")
        'TextBox1.Clear()
        'TextBox2.Clear()
        '

        ' End If



        ' End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = True
        Else
            TextBox2.UseSystemPasswordChar = False


        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
