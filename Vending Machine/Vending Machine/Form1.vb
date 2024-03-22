Public Class Form1
    Dim WithEvents CS As New CoinSlot

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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CS.CoinReturn()
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub CS_CoinReturnEvent(d As Integer, q As Integer, dm As Integer, n As Integer) Handles CS.CoinReturnEvent
        If d > 0 Then
            DollarsPB.Visible = True
        Else
            DollarsPB.Visible = False
        End If
        If q > 0 Then
            QuartersPB.Visible = True
        Else
            QuartersPB.Visible = False
        End If
        If dm > 0 Then
            DImesPB.Visible = True
        Else
            DImesPB.Visible = False
        End If
        If n > 0 Then
            NicklesPB.Visible = True
        Else
            NicklesPB.Visible = False
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Select Case IDTextBox.Text
            Case ProductControl1.ProductID
                CS.Buy(ProductControl1)
            Case 2

            Case Else
        End Select
        Select Case IDTextBox.Text
            Case ProductControl2.ProductID
                CS.Buy(ProductControl2)
            Case 2

            Case Else
        End Select
        Select Case IDTextBox.Text
            Case ProductControl3.ProductID
                CS.Buy(ProductControl3)
            Case 2

            Case Else
        End Select
        Select Case IDTextBox.Text
            Case ProductControl4.ProductID
                CS.Buy(ProductControl4)
            Case 2

            Case Else
        End Select
        Select Case IDTextBox.Text
            Case ProductControl5.ProductID
                CS.Buy(ProductControl5)
            Case 2

            Case Else
        End Select
        Select Case IDTextBox.Text
            Case ProductControl6.ProductID
                CS.Buy(ProductControl6)
            Case 2

            Case Else
        End Select
        TotalLabel.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub CS_Dispence(p As Image) Handles CS.Dispence
        ProductPictureBox.Image = p
    End Sub
End Class
