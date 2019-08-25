Public Class SUM_RESULTS

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SUM1, SUM2, SUM3 As Single
        SUM1 = Val(TextBox1.Text) / Val(TextBox4.Text)
        SUM2 = (Val(TextBox2.Text)) / Val(TextBox4.Text)
        SUM3 = Val((TextBox3.Text)) / Val(TextBox4.Text)
        Label8.Text = " GOT " & SUM1 * 100 & "%"
        Label9.Text = " GOT" & SUM2 * 100 & "%"
        Label10.Text = " GOT " & SUM3 * 100 & "%"
    End Sub
End Class