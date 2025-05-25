Imports System.Data.SqlClient
Public Class ItemDashboard

    Private Sub ItemDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\.NET\College Project\College Project\college_project.mdf;Integrated Security=True;Connect Timeout=30")
        con.Open()

        'Total Items
        Dim item_cmd As New SqlCommand
        Dim item_stmt As String
        Dim itemtotalcount As String
        item_stmt = "SELECT count(*) FROM ItemTbl"
        item_cmd = New SqlCommand(item_stmt, con)
        itemtotalcount = item_cmd.ExecuteScalar()
        Button1.Text = "Total Items :" + itemtotalcount
        con.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
    'logout
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim obj = New Items
        obj.Show()
        Me.Hide()
    End Sub
    'exit
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if you want to exit", "Items", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class