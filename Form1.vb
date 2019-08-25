Imports MYSQL.DATA.MYSQLCLIENT


Public Class Form1
    Dim MYCONN As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       

        MYCONN = New MySqlConnection

        MYCONN.ConnectionString = "server=localhost; userid=root; password=; database=VOTING"
        Dim reader As MySqlDataReader
        Try
            MYCONN.Open()
            Dim Query As String
            Query =
"insert into VOTING.VOTE (GAF) VALUES ('" & CheckBox1.Text & "') "
            COMMAND = New MySqlCommand(Query, MYCONN)
            reader = COMMAND.ExecuteReader
            MessageBox.Show("THANK YOU FOR VOTING!")

            MYCONN.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MYCONN.Dispose()
            SECRETARY.Show()
            Me.Hide()
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MYCONN = New MySqlConnection

        MYCONN.ConnectionString = "server=localhost; userid=root; password=; database=VOTING"
        Dim reader As MySqlDataReader
        Try
            MYCONN.Open()
            Dim Query As String
            Query =
"insert into VOTING.VOTE (RAHIM) VALUES ('" & CheckBox2.Text & "') "
            COMMAND = New MySqlCommand(Query, MYCONN)
            reader = COMMAND.ExecuteReader
            MessageBox.Show("THANK YOU FOR VOTING!")

            MYCONN.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MYCONN.Dispose()
            SECRETARY.Show()
            Me.Hide()
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
      

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        MYCONN = New MySqlConnection

        MYCONN.ConnectionString = "server=localhost; userid=root; password=; database=VOTING"
        Dim reader As MySqlDataReader
        Try
            MYCONN.Open()
            Dim Query As String
            Query =
"insert into VOTING.VOTE (TOTAL_VOTES) VALUES ('" & CheckBox3.Text & "') "
            COMMAND = New MySqlCommand(Query, MYCONN)
            reader = COMMAND.ExecuteReader
            MessageBox.Show("THANK YOU FOR VOTING!")

            MYCONN.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MYCONN.Dispose()
            SECRETARY.Show()
            Me.Hide()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SECRETARY.Show()
        Me.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        LOGIN.Show()
        Me.Hide()

    End Sub
End Class
