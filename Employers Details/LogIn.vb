Public Class LogIn
    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "chamod" Then
            If TextBox2.Text = "kanishka" Then
                Home.Show()
                Me.Hide()




            Else MessageBox.Show("Password incorrect")






            End If
        Else MessageBox.Show("Login Faild")
        End If


    End Sub
End Class
