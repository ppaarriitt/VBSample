Public Class frmlab2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim total As Integer
        Dim Commitment5 As Integer
        Dim Commitment10 As Integer
        total = Val(txttotal1.Text) + Val(txttotal2.Text)
        lbltotal.Text = total
        Commitment5 = Val(txttotal1.Text) * 0.05
        Commitment10 = Val(txttotal2.Text) * 0.1
        lbltotalcom.Text = Commitment5 + Commitment10

    End Sub

    Private Sub lbltotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbltotal.Click

    End Sub
End Class