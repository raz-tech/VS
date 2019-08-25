Imports MySql.Data.MySqlClient
Public Class SECRETARY
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
            Command = New MySqlCommand(Query, MYCONN)
            reader = Command.ExecuteReader
            MessageBox.Show("THANK YOU FOR VOTING!")

            MYCONN.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MYCONN.Dispose()

        End Try

        Me.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Me.Refresh()


    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Me.Refresh()

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
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
"insert into VOTING.VOTE (GAF) VALUES ('" & CheckBox1.Text & "') "
            COMMAND = New MySqlCommand(Query, MYCONN)
            reader = COMMAND.ExecuteReader
            MessageBox.Show("THANK YOU FOR VOTING!")

            MYCONN.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MYCONN.Dispose()
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
"insert into VOTING.VOTE (GAF) VALUES ('" & CheckBox1.Text & "') "
            COMMAND = New MySqlCommand(Query, MYCONN)
            reader = COMMAND.ExecuteReader
            MessageBox.Show("THANK YOU FOR VOTING!")

            MYCONN.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MYCONN.Dispose()
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LOGIN.Show()
        Me.Hide()

    End Sub
End Class