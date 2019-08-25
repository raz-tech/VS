Imports MySql.Data.MySqlClient
Public Class LOGIN
    Dim MYSQLCONN As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim attempt As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ADMIN_LOGIN.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        MYSQLCONN = New MySqlConnection
        Dim Reader As MySqlDataReader
        MYSQLCONN.ConnectionString =
            "server=localhost;userid=root;password=;database=voting"


        Try
            MYSQLCONN.Open()
            Dim query As String
            query = "select * from voting.DEPARTMENT where STDID='" & TextBox1.Text & " ' and password='" & TextBox2.Text & "'"

            COMMAND = New MySqlCommand(query, MYSQLCONN)
            Reader = COMMAND.ExecuteReader
            '' Dim ID, ADMIN_ID, TL_ID As String
            Dim count As Integer
            Dim ATTEMPT As Integer
            count = 0
            While Reader.Read
                count = count + 1
            End While
            If count = 1 Then
                If ATTEMPT = 1 Then

                End If
                Form1.Show()
                Me.Hide()
                TextBox1.Clear()
                TextBox2.Clear()

            ElseIf (ATTEMPT > 1) Then
                MessageBox.Show("YOU ALREADY VOTED")

            Else
                MessageBox.Show("User id and Passowrd not match")
            End If

            MYSQLCONN.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            MYSQLCONN.Dispose()
        End Try

      
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Location.X + Label1.Width < 0 Then
            Label1.Location = New Point(Me.Width, Label1.Location.Y)

        Else
            Label1.Location = New Point(Label1.Location.X - 5, Label1.Location.Y)
        End If
    End Sub
End Class