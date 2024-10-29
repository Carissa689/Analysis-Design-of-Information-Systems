Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = plat
        Label3.Text = Form9.TextBox2.Text
        Label5.Text = (Val(Form9.TextBox6.Text) - Val(Form9.TextBox5.Text))
    End Sub
End Class