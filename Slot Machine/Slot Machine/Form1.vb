Public Class Form1
    Dim CS As New CoinSlot

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CS.insertQuarters()
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CS.insertDollars()
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CS.insertDimes()
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CS.insertNickles()
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub
    Public Sub spin()
        ' generate random number 
        Dim Rand As New Random
        Dim r As Integer
        r = Rand.Next(ImageList1.Images.Count)
        Label1.Text = r
        Label2.Text = r
        Label3.Text = r
        'Show picture from image list
        PictureBox1.Image = ImageList1.Images(r)
        PictureBox2.Image = ImageList1.Images(r)
        PictureBox3.Image = ImageList1.Images(r)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        spin()
    End Sub

    Private Sub SpinButton_Click(sender As Object, e As EventArgs) Handles SpinButton.Click
        Timer1.Enabled = Not Timer1.Enabled
    End Sub

End Class
