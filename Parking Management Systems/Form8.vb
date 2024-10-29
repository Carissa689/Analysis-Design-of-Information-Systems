Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = plat
        Label3.Text = Form7.TextBox2.Text
        Label5.Text = (Val(Form7.TextBox6.Text) - Val(Form7.TextBox5.Text))
    End Sub
End Class