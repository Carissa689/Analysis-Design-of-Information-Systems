Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label13.Text = nama
    End Sub

    Private Sub Panel1_Click(sender As Object, e As PaintEventArgs) Handles Panel1.Click
        Dim mobil As New Form5
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim mobil As New Form5
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub Panel2_Click(sender As Object, e As PaintEventArgs) Handles Panel2.Click
        Dim motor As New Form7
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim motor As New Form7
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub Panel3_Click(sender As Object, e As PaintEventArgs) Handles Panel3.Click
        Dim motor As New Form9
        Form9.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim motor As New Form9
        Form9.Show()
        Me.Close()
    End Sub

End Class