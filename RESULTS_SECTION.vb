Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class RESULTS_SECTION
    Dim MYCONN As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.Refresh()

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MYCONN = New MySqlConnection

        MYCONN.ConnectionString = "server=localhost; userid=root; password=; database=VOTING"
        Dim reader As MySqlDataReader
        Try
            MYCONN.Open()
            Dim Query As String
            Query =
"SELECT COUNT(GAF) FROM VOTING.VOTE"
            COMMAND = New MySqlCommand(Query, MYCONN)
            reader = COMMAND.ExecuteReader
            MessageBox.Show("CLICK OK TO SEE THE RESULTS")

            While reader.Read
                TextBox1.Text = reader.GetString(0)
            End While
            reader.Close()


            Query =
"SELECT COUNT(RAHIM) FROM VOTING.VOTE"
            COMMAND = New MySqlCommand(Query, MYCONN)
            reader = COMMAND.ExecuteReader
            '   MessageBox.Show("CLICK OK TO SEE RAHIM TOTAL VOTES")

            While reader.Read
                TextBox2.Text = reader.GetString(0)
            End While
            reader.Close()

            MYCONN.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MYCONN.Dispose()
        End Try

        MYCONN = New MySqlConnection

        MYCONN.ConnectionString = "server=localhost; userid=root; password=; database=VOTING"
        '  Dim reader As MySqlDataReader
        Try
            MYCONN.Open()
            Dim Query As String
            Query =
"SELECT COUNT(TOTAL_VOTES) FROM VOTING.VOTE"
            COMMAND = New MySqlCommand(Query, MYCONN)
            reader = COMMAND.ExecuteReader
            '   MessageBox.Show("CLICK OK TO SEE THE RESULTS")

            While reader.Read
                TextBox4.Text = reader.GetString(0)
            End While
            reader.Close()
            MYCONN.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MYCONN.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox4.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label5.Text = Format(Val(TextBox1.Text) / Val(TextBox3.Text) * 100, "0.00") & "%"

        Label6.Text = Format(Val(TextBox2.Text) / Val(TextBox3.Text) * 100, "0.00") & "%"
        Label10.Text = Format(Val(TextBox4.Text) / Val(TextBox3.Text) * 100, "0.00") & "%"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        ''  Dim printdialog1 As New PrintDialog
        '' printdialog1.ShowDialog()

        Dim printDlg As New PrintDialog
        Dim printDoc As New PrintDocument
        printDoc.DocumentName = "Print Document"
        printDlg.Document = printDoc
        printDlg.AllowSelection = True
        printDlg.AllowSomePages = True


        If (printDlg.ShowDialog = DialogResult.OK) Then
            printDoc.Print()

        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SECRETARY__RESULTS.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LOGIN.Show()
        Me.Hide()

    End Sub
End Class