Imports MySql.Data.MySqlClient

Public Class ADMIN_LOGIN
    Dim mysqlconn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        LOGIN.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mysqlconn = New MySqlConnection
        Dim Reader As MySqlDataReader
        mysqlconn.ConnectionString =
            "server=localhost;userid=root;password=;database=voting"


        Try
            mysqlconn.Open()
            Dim query As String
            query = "select * from voting.admin where id='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'"

            Command = New MySqlCommand(query, mysqlconn)
            Reader = Command.ExecuteReader
            '' Dim ID, ADMIN_ID, TL_ID As String
            Dim count As Integer
            count = 0
            While Reader.Read
                count = count + 1
            End While
            If count = 1 Then
               
                RESULTS_SECTION.Show()
                Me.Hide()
                TextBox1.Clear()
                TextBox2.Clear()
            Else

                MessageBox.Show("User id and Passowrd not match")
            End If

            mysqlconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            mysqlconn.Dispose()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        CANDIDATES_PICS.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        mysqlconn = New MySqlConnection
        Dim Reader As MySqlDataReader
        mysqlconn.ConnectionString =
            "server=localhost;userid=root;password=;database=voting"


        Try
            mysqlconn.Open()
            Dim query As String
            query = "select * from voting.manuf where MANF_ID='" & TextBox4.Text & " ' and PASSWORD='" & TextBox3.Text & "'"

            command = New MySqlCommand(query, mysqlconn)
            Reader = command.ExecuteReader
            '' Dim ID, ADMIN_ID, TL_ID As String
            Dim count As Integer
            count = 0
            While Reader.Read
                count = count + 1
            End While
           
            mysqlconn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)

        Finally
            mysqlconn.Dispose()
        End Try
       
      

        If ComboBox1.SelectedItem = "CANDIDATES_PICS_AND_NAMES" Then
            CANDIDATES_PICS.Show()
            Me.Hide()

        ElseIf ComboBox1.SelectedItem = "RESULTS_SUMMATION_AND_PERCENTAGES " Then
            SUM_RESULTS.Show()
            Me.Hide()
        End If
        TextBox1.Clear()
        TextBox2.Clear()




    End Sub
End Class