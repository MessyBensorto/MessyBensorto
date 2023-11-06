Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class MSSQL_MYSQL_TestConnection
    Private Sub btnMysql_Click(sender As Object, e As EventArgs) Handles btnMysql.Click
        Myconnection = New MySqlConnection(MyconnectionString)
        Try
            Myconnection = New MySqlConnection(MyconnectionString)
            Myconnection.Open()
            If Myconnection.State = ConnectionState.Open Then
                MessageBox.Show("Connection Successful")
            Else
                MessageBox.Show("Connection Falied")
            End If
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        Finally
            If Myconnection IsNot Nothing Then
                Myconnection.Close()
            End If
            Signup.Show()
            Me.Hide()
        End Try
    End Sub

    Private Sub btnMSSQL_Click(sender As Object, e As EventArgs) Handles btnMSSQL.Click

        MSconnection = New SqlConnection(MSconnectionString)
        Try
            MSconnection.Open()
            If MSconnection.State = ConnectionState.Open Then
                MessageBox.Show("Connection Success")
                Signup.Show()
                Me.Hide()
            Else
                MessageBox.Show("Connection Falied")

            End If
        Catch ex As SqlException
            MessageBox.Show("Error:" & ex.Message)
        Finally
            MSconnection.Close()

        End Try
    End Sub
End Class