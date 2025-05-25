Imports System.Data.OleDb
Public Class Form1
    Dim cn As OleDbConnection
    Dim cmd As OleDbCommand
    Dim da As OleDbDataAdapter
    Dim dt As DataTable
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\.NET\Student Information\Database4.accdb")
        cn.Open()
        MsgBox("Database connected")
        cn.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cmd = New OleDbCommand("insert into reg values(" & Val(TextBox1.Text) & ",'" & TextBox2.Text & "'," & Val(TextBox3.Text) & ",'" & TextBox4.Text & "')", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Record Inserted successfully")
        clear()
    End Sub
    Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '  clear()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cmd = New OleDbCommand("update reg set Sname ='" & TextBox2.Text & "', Contact =" & Val(TextBox3.Text) & ", City ='" & TextBox4.Text & "' where ID=" & Val(TextBox1.Text) & "  ", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Record Update successfully")
        clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        da = New OleDbDataAdapter
        dt = New DataTable
        cmd = New OleDbCommand("select * from reg where ID =" & Val(TextBox1.Text) & "", cn)
        cn.Open()
        da.SelectCommand = cmd
        da.Fill(dt)
        cn.Close()
        TextBox1.Text = dt.Rows(0).Item(0)
        TextBox2.Text = dt.Rows(0).Item(1)
        TextBox3.Text = dt.Rows(0).Item(2)
        TextBox4.Text = dt.Rows(0).Item(3)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cmd = New OleDbCommand("delete from reg where ID=" & Val(TextBox1.Text) & " ", cn)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Record deleted successfully")
        clear()
    End Sub
End Class
