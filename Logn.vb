Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class Logn
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Myconnection = New MySqlConnection(MyconnectionString)
        Try
            Myconnection.Open
            Dim Query As String = "select * from tbl_login WHERE username = @Username AND password = @Password"
            Dim cmd As New MySqlCommand(query, Myconnection)

            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Welocome to Golden State College School Records")
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        Finally
            Myconnection.Close()
            MSSQL_MYSQLINTERECORDS.Show()
            Me.Hide()
        End Try
    End Sub

    Private Sub btnLoginMSSQL_Click(sender As Object, e As EventArgs) Handles btnLoginMSSQL.Click
        MSconnection = New SqlConnection(MSconnectionString)
        Try
            MSconnection.Open()
            Dim Query As String = "select * from tbl_login WHERE username = @Username AND password = @Password"
            Dim command As New SqlCommand(Query, MSconnection)

            command.Parameters.AddWithValue("@Username", txtUsername.Text)
            command.Parameters.AddWithValue("@Password", txtPassword.Text)
            command.ExecuteNonQuery()

            MessageBox.Show("Welocome to Golden State College School Records")
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        Finally
            MSconnection.Close()
            MSSQL_MYSQLINTERECORDS.Show()
            Me.Hide()
        End Try
    End Sub
End Class