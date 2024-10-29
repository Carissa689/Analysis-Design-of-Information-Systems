Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = plat
        Label3.Text = Form5.TextBox2.Text
        Label5.Text = (Val(Form5.TextBox6.Text) - Val(Form5.TextBox5.Text))
    End Sub
End Class