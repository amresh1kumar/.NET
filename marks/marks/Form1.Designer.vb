<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Button1 = New Button()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveBorder
        Label1.Location = New Point(129, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 15)
        Label1.TabIndex = 0
        Label1.Text = "enter the marks of physics :   "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Blue
        Label2.Location = New Point(129, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ActiveCaption
        Label3.Location = New Point(129, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(164, 15)
        Label3.TabIndex = 2
        Label3.Text = "enter the marks of chemistry :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.CadetBlue
        Label4.Location = New Point(132, 108)
        Label4.Name = "Label4"
        Label4.Size = New Size(161, 15)
        Label4.TabIndex = 3
        Label4.Text = "enter the marks of Biology :   "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ButtonShadow
        Label5.Location = New Point(129, 144)
        Label5.Name = "Label5"
        Label5.Size = New Size(160, 15)
        Label5.TabIndex = 4
        Label5.Text = "enter the marks of maths:      "
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.CadetBlue
        Label6.Location = New Point(129, 190)
        Label6.Name = "Label6"
        Label6.Size = New Size(164, 15)
        Label6.TabIndex = 5
        Label6.Text = "enter the marks of computer :"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.YellowGreen
        TextBox1.Location = New Point(322, 9)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.YellowGreen
        TextBox2.Location = New Point(322, 61)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.YellowGreen
        TextBox3.Location = New Point(322, 100)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 8
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.YellowGreen
        TextBox4.Location = New Point(322, 136)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 9
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.YellowGreen
        TextBox5.Location = New Point(322, 190)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Brown
        Button1.Location = New Point(132, 304)
        Button1.Name = "Button1"
        Button1.Size = New Size(89, 24)
        Button1.TabIndex = 11
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = Color.Brown
        TextBox6.Location = New Point(244, 305)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(76, 23)
        TextBox6.TabIndex = 13
        TextBox6.Text = "Percentage"
        ' 
        ' TextBox7
        ' 
        TextBox7.BackColor = Color.Brown
        TextBox7.Location = New Point(345, 305)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(47, 23)
        TextBox7.TabIndex = 14
        TextBox7.Text = "Grade"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.BurlyWood
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "5"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
End Class
