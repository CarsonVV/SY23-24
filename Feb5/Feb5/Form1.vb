Public Class Form1
    Dim C As New Clicker1
    Dim C2 As New Clicker1
    Dim C3 As New Clicker1
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        C.increment = NumericUpDown1.Value
        C.click()
        TextBox1.Text = C.count
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        C.reset()
        TextBox1.Text = C.count
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        C.increment = NumericUpDown2.Value
        C2.click()
        TextBox2.Text = C2.count
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        C2.reset()
        TextBox2.Text = C2.count
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        C.increment = NumericUpDown3.Value
        C3.click()
        TextBox3.Text = C3.count
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        C3.reset()
        TextBox3.Text = C3.count
    End Sub
End Class
