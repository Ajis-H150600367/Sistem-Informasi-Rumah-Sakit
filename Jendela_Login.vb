Public Class Jendela_Login

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim formlogin As New Login_Master
        Login_Master.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim formlogin As New User_Login
        User_Login.Show()
        Me.Hide()
    End Sub
End Class