Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim info As ProcessStartInfo = New ProcessStartInfo("bash", "-c ""python3 getFollowersCount.py " & TextBox1.Text & """") With {
            .RedirectStandardOutput = True,
            .RedirectStandardError = True,
            .CreateNoWindow = True,
            .UseShellExecute = False
        }
        Dim p As Process = Process.Start(info)
        Dim output As String = p.StandardOutput.ReadToEnd.TrimEnd
        MsgBox(TextBox1.Text & ", you have " & output & " followers.")
    End Sub
End Class
