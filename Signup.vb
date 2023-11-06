Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class Signup
    Private Sub btnSignupMYSQL_Click(sender As Object, e As EventArgs) Handles btnSignupMYSQL.Click
        Myconnection = New MySqlConnection(MyconnectionString)
        Try
            Myconnection.Open()




            Dim query As String = "INSERT INTO tbl_login (username,password,firstname,middlename,lastname) VALUES (@Username,@Password,@Fname,@Mname,@Lname)"
            Dim cmd As New MySqlCommand(query, Myconnection)

            cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
            cmd.Parameters.AddWithValue("@Fname", txtFname.Text)
            cmd.Parameters.AddWithValue("@Mname", txtMname.Text)
            cmd.Parameters.AddWithValue("@Lname", txtLname.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Sucesss Sign Up")
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        Finally
            Myconnection.Close()
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Logn.Show()
        Me.Hide()
    End Sub

    Private Sub btnSignupmssql_Click(sender As Object, e As EventArgs) Handles btnSignupmssql.Click
        MSconnection = New SqlConnection(MSconnectionString)
        Try
            MSconnection.Open()

            Dim query As String = "INSERT INTO tbl_login (username,password,firstname,middlename,lastname) VALUES (@Username,@Password,@Fname,@Mname,@Lname)"
            Dim MScommand As New SqlCommand(query, MSconnection)
            MScommand.Parameters.AddWithValue("@Username", txtUsername.Text)
            MScommand.Parameters.AddWithValue("@Password", txtPassword.Text)
            MScommand.Parameters.AddWithValue("@Fname", txtFname.Text)
            MScommand.Parameters.AddWithValue("@Mname", txtMname.Text)
            MScommand.Parameters.AddWithValue("@Lname", txtLname.Text)
            MScommand.ExecuteNonQuery()

            MessageBox.Show("Success Sign Up")
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        Finally
            MSconnection.Close()
        End Try
    End Sub
End Class