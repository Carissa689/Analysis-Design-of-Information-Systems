Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If password.Text = "blabla" Then
            Dim beranda As New Form3
            nama = username.Text
            Form3.Show()
            Me.Close()
        End If
    End Sub
End Class
