Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles lblpc.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblpc.Text = Environ("COMPUTERNAME")
        lblUser.Text = Environ("USERNAME")
    End Sub
End Class
