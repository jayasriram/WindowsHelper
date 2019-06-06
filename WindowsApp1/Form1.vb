Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblHelloWorld.Click
        Process.Start("D:\2019\ORT")
    End Sub

    Private Sub btnClickThis_Click(sender As Object, e As EventArgs) Handles btnClickThis.Click
        'lblHelloWorld.Text = "Hello World!"
        Process.Start("https://google.com")
        'ControlPaint.Dark(black)

    End Sub

    Private Sub btnORT_Click(sender As Object, e As EventArgs) Handles btnORT.Click
        Process.Start("D:\2019\ORT")
    End Sub

    Private Sub btnSSLLabs_Click(sender As Object, e As EventArgs) Handles btnSSLLabs.Click
        Process.Start("https://www.ssllabs.com/ssltest/")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = True
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop

    End Sub

    Private Sub btnPostman_Click(sender As Object, e As EventArgs) Handles btnPostman.Click
        Process.Start("D:\Tools\Postman-win64-6.1.4-Setup.exe")
    End Sub
End Class
