Imports System.Data.SqlClient
Public Class Form1

    Dim conn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Amresh\OneDrive\Documents\SearchTb.mdf;Integrated Security=True;Connect Timeout=30")
    Dim cmd As SqlCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        disp_data()

    End Sub

    '***********************************************************************
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into SearchTbl values('" + TextBox1.Text + "','" + TextBox2.Text + "')"
        cmd.ExecuteNonQuery()
        disp_data()
        TextBox1.Text = ""
        TextBox2.Text = ""
        MsgBox("Record Inserted Successfully")
    End Sub
    Public Sub disp_data()
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from SearchTbl"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)

        DataGridView1.DataSource = dt
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cmd = conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from SearchTbl where MobileNo='" + TextBox3.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)

        DataGridView1.DataSource = dt
    End Sub
End Class

