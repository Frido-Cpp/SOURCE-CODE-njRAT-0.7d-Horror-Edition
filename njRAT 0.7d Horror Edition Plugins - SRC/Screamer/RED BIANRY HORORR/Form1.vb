Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim screenHeight As Integer = My.Computer.Screen.WorkingArea.Height
        Dim screenWidth As Integer = My.Computer.Screen.WorkingArea.Width
        Label1.Text = My.Computer.Screen.WorkingArea.Height
        Label2.Text = My.Computer.Screen.WorkingArea.Width
        My.Computer.Audio.Play(My.Resources.kefka, AudioPlayMode.Background)
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub


    Public Sub fade_out()
        For FadeOut = 90 To 10 Step -10
            Me.Opacity = FadeOut / 100
            Me.Refresh()
            Threading.Thread.Sleep(50)
        Next
    End Sub


End Class
