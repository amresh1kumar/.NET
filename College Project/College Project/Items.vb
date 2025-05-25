﻿Imports System.Data.SqlClient

Public Class Items
    Dim con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\.NET\College Project\College Project\college_project.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if you want to exit", "Items", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If iExit = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ItnameTb.Text = "" Or QtyTb.Text = "" Or CatCb.SelectedIndex = -1 Or PriceTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                con.open()
                Dim query = "insert into ItemTbl values('" & ItnameTb.Text & "'," & QtyTb.Text & "," & PriceTb.Text & ", '" & CatCb.SelectedItem.ToString() & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Items saved Successfully")
                con.close()
                DisplayItem()
                clear()

            Catch ex As Exception

            End Try

        End If
    End Sub
    Private Sub clear()
        ItnameTb.Text = ""
        QtyTb.Text = ""
        PriceTb.Text = ""
        CatCb.SelectedIndex = 0

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        clear()
    End Sub
    Private Sub DisplayItem()
        con.open()
        Dim query = "select * from ItemTbl"
        Dim cmd = New SqlCommand(query, con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        con.close()
    End Sub
    Private Sub FilterByCat()
        con.open()
        Dim query = "select * from ItemTbl  where Itcat= '" & SearchCb.SelectedItem.ToString() & "'"
        Dim cmd = New SqlCommand(query, con)
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(cmd)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        ItemDGV.DataSource = ds.Tables(0)
        con.close()
    End Sub
    Dim key = 0

    Private Sub ItemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ItemDGV.CellMouseClick
        Dim row As DataGridViewRow = ItemDGV.Rows(e.RowIndex)
        ItnameTb.Text = row.Cells(1).Value.ToString
        QtyTb.Text = row.Cells(2).Value.ToString
        PriceTb.Text = row.Cells(3).Value.ToString
        CatCb.SelectedItem = row.Cells(4).Value.ToString
        If ItnameTb.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If key = 0 Then
            MsgBox("Select Items To Delete")
        Else
            Try
                con.open()
                Dim query = "delete from ItemTbl where ItId=" & key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Item deleted Successfully")
                con.close()
                DisplayItem()
                clear()

            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ItnameTb.Text = "" Or QtyTb.Text = "" Or CatCb.SelectedIndex = -1 Or PriceTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Try
                con.open()
                Dim query = "Update ItemTbl set ItName='" & ItnameTb.Text & "',ItQty=" & QtyTb.Text & ", ItPrice=" & PriceTb.Text & ",ItCat='" & CatCb.SelectedItem.ToString() & "' where ItId=" & key & ""

                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Item Update Successfully")
                con.close()
                DisplayItem()
                clear()

            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim obj = New Login
        obj.Show()
        Me.Hide()

    End Sub


    Private Sub SearchCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles SearchCb.SelectionChangeCommitted
        FilterByCat()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        DisplayItem()

    End Sub

  

    Private Sub ItemDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemDGV.CellContentClick

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ItemReport.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ItemDashboard.Show()

    End Sub

    Private Sub CatCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CatCb.SelectedIndexChanged

    End Sub
End Class