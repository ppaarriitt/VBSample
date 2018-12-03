Public Class frmlab1

    Private Sub bntcalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntcalculate.Click
        lbl1.Text = Val(txtSalary.Text) * 12
        lbl2.Text = Val(lbl1.Text) * 0.05
        lbl3.Text = Val(lbl1.Text) - Val(lbl2.Text)


    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub

    Private Sub IncomeCalculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
