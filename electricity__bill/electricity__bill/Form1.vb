Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Validate input
        If Not IsNumeric(txtUnits.Text) Then
            MessageBox.Show("Please enter a valid numeric value for electricity units.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Calculate total bill
        Dim units As Double = CDbl(txtUnits.Text)
        Dim totalBill As Double = 0

        ' Debugging output
        Console.WriteLine("Input Units: " & units)

        If units <= 50 Then
            totalBill = units * 0.5
        ElseIf units <= 150 Then
            totalBill = 50 * 0.5 + (units - 50) * 0.75
        ElseIf units <= 250 Then
            totalBill = 50 * 0.5 + 100 * 0.75 + (units - 150) * 1.2
        Else
            totalBill = 50 * 0.5 + 100 * 0.75 + 100 * 1.2 + (units - 250) * 1.5
        End If

        ' Add surcharge
        totalBill *= 1.2

        ' Debugging output
        Console.WriteLine("Total Bill: " & totalBill)

        ' Display result
        lblTotalBill.Text = "Total Electricity Bill: Rs. " & totalBill.ToString("0.00")
    End Sub


End Class
