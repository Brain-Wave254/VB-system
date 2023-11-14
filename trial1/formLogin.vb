Public Class formLogin
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles StaffIdTb.TextChanged

    End Sub

    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Clear()
        PasswordTb.Clear()
        StaffIdTb.Clear()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If PasswordTb.Text = "brainwave" Then
            Form1.Show()
            Me.Hide()
        Else
            MsgBox("wrong user!!!")
        End If
        Clear()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            PasswordTb.PasswordChar = ""
        Else
            PasswordTb.PasswordChar = "*"
        End If

    End Sub
End Class