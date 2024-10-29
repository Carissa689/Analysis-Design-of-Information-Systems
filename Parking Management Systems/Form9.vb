Public Class Form9
    Private Sub TextBox2_MouseClick(sender As Object, e As EventArgs) Handles TextBox2.MouseClick
        If TextBox2.Text = "brc03" Then
            TextBox3.Text = 10
            TextBox4.Text = 15
        Else
            MessageBox.Show("Barcode Tidak Valid", "Error", MessageBoxButtons.YesNo)
        End If

    End Sub

    Private Sub TextBox5_MouseClick(sender As Object, e As EventArgs) Handles TextBox5.MouseClick
        If ComboBox1.SelectedItem = "Member" Then
            TextBox5.Text = (Val(TextBox4.Text) - Val(TextBox3.Text)) * 5000
        Else
            TextBox5.Text = (Val(TextBox4.Text) - Val(TextBox3.Text)) * 10000
        End If
    End Sub

    Private Sub TextBox6_MouseClick(sender As Object, e As EventArgs) Handles TextBox6.MouseClick
        If ComboBox2.SelectedItem = "E-Money" Then
            TextBox6.Text = TextBox5.Text
        Else
            TextBox6.Text = TextBox6.Text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selesai As New Form6
        plat = TextBox1.Text
        Form10.Show()
        Me.Close()

    End Sub

End Class