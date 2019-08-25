Public Class CANDIDATES_PICS

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SECRETARY.Label1.Text = "HELLO"
        Me.Refresh()
        System.Threading.Thread.Sleep(40)
        SECRETARY.Label1.Text = InputBox("ENTER THE CANDIDATE NAME :")
        '  Form1.Label1.Refresh()

      
        If SECRETARY.OpenFileDialog1.ShowDialog = DialogResult.OK Then SECRETARY.PictureBox1.Image =
Image.FromFile(SECRETARY.OpenFileDialog1.FileName)
        Me.Refresh()




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        If ComboBox1.SelectedItem = "FCAN_OF_PRES" Or ComboBox1.SelectedItem = "SCAN_OF_PRES" Or ComboBox1.SelectedItem = "TCAN_OF_PRES" Then
            Form1.Show()
            Me.Hide()

        End If

        If ComboBox1.SelectedItem = "FCAN_OF_SEC" Or ComboBox1.SelectedItem = "SCAN_OF_SEC" Or ComboBox1.SelectedItem = "TCAN_OF_SEC" Then
            SECRETARY.Show()
            Me.Hide()

        End If

        If ComboBox1.SelectedItem = "FCAND_NAME" Or ComboBox1.SelectedItem = "SCAND_NAME" Or ComboBox1.SelectedItem = "TCAND_NAME" Then
            SUM_RESULTS.Show()
            Me.Hide()

        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SECRETARY.Label3.Text = "HELLO"
        Me.Refresh()
        System.Threading.Thread.Sleep(40)
        SECRETARY.Label3.Text = InputBox("ENTER THE CANDIDATE NAME :")
        '  Form1.Label1.Refresh()

        If SECRETARY.OpenFileDialog3.ShowDialog = DialogResult.OK Then SECRETARY.PictureBox3.Image =
Image.FromFile(SECRETARY.OpenFileDialog3.FileName)
    End Sub

   
    Private Sub Button5_Click(sender As Object, e As EventArgs)
        SECRETARY.Label1.Text = "HELLO"
        Me.Refresh()
        System.Threading.Thread.Sleep(40)
        SECRETARY.Label1.Text = InputBox("ENTER THE CANDIDATE NAME :")
        '  Form1.Label1.Refresh()
    End Sub

    Private Sub CANDIDATES_PICS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Form1.Label3.Text = "HELLO"
        Me.Refresh()
        System.Threading.Thread.Sleep(40)
        Form1.Label3.Text = InputBox("ENTER THE CANDIDATE NAME :")
        '  Form1.Label1.Refresh()

        If Form1.OpenFileDialog3.ShowDialog = DialogResult.OK Then Form1.PictureBox3.Image =
Image.FromFile(Form1.OpenFileDialog3.FileName)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SECRETARY.Label2.Text = "HELLO"
        Me.Refresh()
        System.Threading.Thread.Sleep(40)
        Form1.Label2.Text = InputBox("ENTER THE CANDIDATE NAME :")
        '  Form1.Label1.Refresh()

        If SECRETARY.OpenFileDialog2.ShowDialog = DialogResult.OK Then SECRETARY.PictureBox2.Image =
Image.FromFile(Form1.OpenFileDialog2.FileName)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form1.Label2.Text = "HELLO"
        Me.Refresh()
        System.Threading.Thread.Sleep(40)
        Form1.Label2.Text = InputBox("ENTER THE CANDIDATE NAME :")
        '  Form1.Label1.Refresh()

        If Form1.OpenFileDialog2.ShowDialog = DialogResult.OK Then Form1.PictureBox2.Image =
Image.FromFile(Form1.OpenFileDialog2.FileName)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles FCAN.Click
        Form1.Label1.Text = "HELLO"
        Me.Refresh()
        System.Threading.Thread.Sleep(40)
        Form1.Label1.Text = InputBox("ENTER THE CANDIDATE NAME :")
        '  Form1.Label1.Refresh()

        If Form1.OpenFileDialog1.ShowDialog = DialogResult.OK Then Form1.PictureBox1.Image =
Image.FromFile(Form1.OpenFileDialog1.FileName)
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        SUM_RESULTS.Label5.Text = "HELLO"
        Me.Refresh()
        System.Threading.Thread.Sleep(40)
        SUM_RESULTS.Label5.Text = InputBox("ENTER THE CANDIDATE NAME:")

        SUM_RESULTS.Label1.Text = "HELLO"
        Me.Refresh()
        System.Threading.Thread.Sleep(40)
        SUM_RESULTS.Label1.Text = InputBox("CONFIRM THE CANDIDATE NAME:")
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        SUM_RESULTS.Label6.Text = "HELLO"
        Me.Refresh()
        System.Threading.Thread.Sleep(40)
        SUM_RESULTS.Label6.Text = InputBox("ENTER THE CANDIDATE NAME:")

        SUM_RESULTS.Label2.Text = "HELLO"
        Me.Refresh()
        System.Threading.Thread.Sleep(40)
        SUM_RESULTS.Label2.Text = InputBox("CONFIRM THE CANDIDATE NAME:")
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        SUM_RESULTS.Label7.Text = "HELLO"
        Me.Refresh()
        System.Threading.Thread.Sleep(40)
        SUM_RESULTS.Label7.Text = InputBox("ENTER THE CANDIDATE NAME:")

        SUM_RESULTS.Label3.Text = "HELLO"
        Me.Refresh()
        System.Threading.Thread.Sleep(40)
        SUM_RESULTS.Label3.Text = InputBox("CONFIRM THE CANDIDATE NAME:")
    End Sub
End Class