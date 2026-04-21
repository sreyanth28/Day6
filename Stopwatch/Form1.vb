Public Class Form1

    Dim sec As Integer = 0
    Dim min As Integer = 0
    Dim hr As Integer = 0

    Private WithEvents Timer1 As New Timer()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000

        TextBox1.Text = "00"
        TextBox2.Text = "00"
        TextBox3.Text = "00"

        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
        TextBox3.ReadOnly = True
    End Sub

    ' START
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    ' STOP
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    ' RESET (Save button acting as reset now)
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Stop()

        sec = 0
        min = 0
        hr = 0

        TextBox1.Text = "00"
        TextBox2.Text = "00"
        TextBox3.Text = "00"
    End Sub

    ' TIMER
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        sec += 1

        If sec = 60 Then
            sec = 0
            min += 1
        End If

        If min = 60 Then
            min = 0
            hr += 1
        End If

        TextBox1.Text = hr.ToString("D2")
        TextBox2.Text = min.ToString("D2")
        TextBox3.Text = sec.ToString("D2")
    End Sub

End Class