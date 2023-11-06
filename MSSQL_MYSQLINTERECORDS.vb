Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class MSSQL_MYSQLINTERECORDS
    Public Sub MsloadData()
        MSconnection = New SqlConnection(MSconnectionString)
        Dim mscommand As New SqlCommand("SELECT idno, CONCAT(firstname, ' ',middlename, ' ', lastname) AS fullname,course FROM tbl_info;", MSconnection)

        Dim da As New SqlDataAdapter(mscommand)
        Dim dt As New DataTable

        da.Fill(dt)
        DataGridView2.DataSource = dt

    End Sub
    Public Sub MyLoadData()
        Myconnection = New MySqlConnection(MyconnectionString)

        Dim MYcommand As New MySqlCommand("SELECT idno, CONCAT(firstname, ' ', middlename, ' ', lastname) AS fullname,course FROM tbl_info;", Myconnection)

        Dim da As New MySqlDataAdapter(MYcommand)
        Dim dt As New DataTable

        da.Fill(dt)
        DataGridView1.DataSource = dt


    End Sub
    Private Sub btnMySql_Click(sender As Object, e As EventArgs) Handles btnMySql.Click
        Myconnection = New MySqlConnection(MyconnectionString)
        Try
            Myconnection.Open()

            Dim selectedCourse As String = course.SelectedItem.ToString()


            Dim query As String = "INSERT INTO tbl_info (Idno,firstname,middlename,lastname,course) VALUES (@id,@Fname,@Mname,@Lname,@Course)"
            Dim cmd As New MySqlCommand(query, Myconnection)

            cmd.Parameters.AddWithValue("@id", txtID.Text)
            cmd.Parameters.AddWithValue("@Fname", txtFname.Text)
            cmd.Parameters.AddWithValue("@Mname", txtMname.Text)
            cmd.Parameters.AddWithValue("@Lname", txtLname.Text)
            cmd.Parameters.AddWithValue("@Course", selectedCourse)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Record Insert Sucesss")
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        Finally
            Myconnection.Close()
        End Try
    End Sub

    Private Sub btnMsSql_Click(sender As Object, e As EventArgs) Handles btnMsSql.Click
        MSconnection = New SqlConnection(MSconnectionString)
        Try
            MSconnection.Open()

            Dim selectedCourse As String = course.SelectedItem.ToString()



            Dim query As String = "INSERT INTO tbl_info (Idno,firstname,middlename,lastname,course) VALUES (@ID,@Fname,@Mname,@Lname,@Course)"
            Dim MScommand As New SqlCommand(query, MSconnection)
            MScommand.Parameters.AddWithValue("@Id", txtID.Text)
            MScommand.Parameters.AddWithValue("@Fname", txtFname.Text)
            MScommand.Parameters.AddWithValue("@Mname", txtMname.Text)
            MScommand.Parameters.AddWithValue("@Lname", txtLname.Text)
            MScommand.Parameters.AddWithValue("@Course", selectedCourse)
            MScommand.ExecuteNonQuery()

            MessageBox.Show("Records Inserted Successfully")
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        Finally
            MSconnection.Close()
        End Try
    End Sub

    Private Sub btnMYloaddata_Click(sender As Object, e As EventArgs) Handles btnMYloaddata.Click
        MyLoadData()


    End Sub

    Private Sub btnMssqlLoaddata_Click(sender As Object, e As EventArgs) Handles btnMssqlLoaddata.Click
        MsloadData()
    End Sub

    Private Sub btninsertmysql_Click(sender As Object, e As EventArgs) Handles btn_update_mysql.Click
        Myconnection = New MySqlConnection(MyconnectionString)

        Dim idno As String = txtID.Text

        Try
            Myconnection.Open()
            Dim query As String = "UPDATE tbl_info SET idno = @ID, firstname = @Fname, middlename = @Mname, lastname = @Lname, course = @Course WHERE idno = @ID"
            Dim MYcommand As New MySqlCommand(query, Myconnection)

            MYcommand.Parameters.AddWithValue("@ID", txtID.Text)
            MYcommand.Parameters.AddWithValue("@Fname", txtFname.Text)
            MYcommand.Parameters.AddWithValue("@Mname", txtMname.Text)
            MYcommand.Parameters.AddWithValue("@Lname", txtLname.Text)
            MYcommand.Parameters.AddWithValue("@Course", course.SelectedItem.ToString())

            MYcommand.ExecuteNonQuery()

            MessageBox.Show("Records Updated Succesfully!")
            MsloadData()
            MyLoadData()
        Catch ex As Exception
        Finally
            Myconnection.Dispose()


        End Try
    End Sub





    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        Myconnection = New MySqlConnection(MyconnectionString)

        Try

            Myconnection.Open()

            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)

            txtID.Text = dr.Cells(0).Value.ToString()
            course.Text = dr.Cells(2).Value.ToString()

            Dim query As String = "SELECT firstname, middlename, lastname FROM tbl_info WHERE idno = @ID"
            Dim MYcommand As New MySqlCommand(query, Myconnection)
            MYcommand.Parameters.AddWithValue("@ID", txtID.Text)

            Dim Reader As MySqlDataReader = MYcommand.ExecuteReader()

            If Reader.Read() Then
                txtFname.Text = Reader("firstname").ToString()
                txtMname.Text = Reader("middlename").ToString()
                txtLname.Text = Reader("lastname").ToString()
            Else
                MessageBox.Show("Student not found.")
            End If
            Reader.Close()


        Catch ex As Exception
        Finally
            Myconnection.Close()
        End Try
    End Sub

    Private Sub DataGridView2_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView2.MouseClick
        MSconnection = New SqlConnection(MSconnectionString)

        Try

            MSconnection.Open()

            Dim dr As DataGridViewRow = DataGridView2.SelectedRows(0)

            txtID.Text = dr.Cells(0).Value.ToString()
            course.Text = dr.Cells(2).Value.ToString()

            Dim query As String = "SELECT firstname, middlename, lastname FROM tbl_info WHERE idno = @ID"
            Dim MScommand As New SqlCommand(query, MSconnection)
            MScommand.Parameters.AddWithValue("@ID", txtID.Text)

            Dim Reader As SqlDataReader = MScommand.ExecuteReader()

            If Reader.Read() Then
                txtFname.Text = Reader("firstname").ToString()
                txtMname.Text = Reader("middlename").ToString()
                txtLname.Text = Reader("lastname").ToString()
            Else
                MessageBox.Show("Student not found.")
            End If
            Reader.Close()


        Catch ex As Exception
        Finally
            MSconnection.Close()
        End Try
    End Sub

    Private Sub btn_update_mssql_Click(sender As Object, e As EventArgs) Handles btn_update_mssql.Click
        MSconnection = New SqlConnection(MSconnectionString)

        Dim idno As String = txtID.Text

        Try
            MSconnection.Open()
            Dim query As String = "UPDATE tbl_info SET idno = @ID, firstname = @Fname, middlename = @Mname, lastname = @Lname, course = @Course WHERE idno = @ID"
            Dim MScommand As New SqlCommand(query, MSconnection)

            MScommand.Parameters.AddWithValue("@ID", txtID.Text)
            MScommand.Parameters.AddWithValue("@Fname", txtFname.Text)
            MScommand.Parameters.AddWithValue("@Mname", txtMname.Text)
            MScommand.Parameters.AddWithValue("@Lname", txtLname.Text)
            MScommand.Parameters.AddWithValue("@Course", course.SelectedItem.ToString())

            MScommand.ExecuteNonQuery()

            MessageBox.Show("Records Updated Succesfully!")
            MsloadData()
            MyLoadData()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDELETEMSSQL_Click(sender As Object, e As EventArgs) Handles btnDELETEMSSQL.Click
        MSconnection = New SqlConnection(MSconnectionString)

        Try
            MSconnection.Open()
            Dim query As String = "DELETE FROM tbl_info WHERE idno = @ID"
            Dim MScommand As New SqlCommand(query, MSconnection)
            MScommand.Parameters.AddWithValue("@ID", txtID.Text)

            MScommand.ExecuteNonQuery()
            MessageBox.Show("Records Deleted Successfully!")
            MsloadData()
        Catch ex As SqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            MSconnection.Close()
        End Try
    End Sub

    Private Sub btnDeletemysql_Click(sender As Object, e As EventArgs) Handles btnDeletemysql.Click
        Myconnection = New MySqlConnection(MyconnectionString)

        Try
            Myconnection.Open()
            Dim query As String = "DELETE FROM tbl_info WHERE idno = @ID"
            Dim MYcommand As New MySqlCommand(query, Myconnection)
            MYcommand.Parameters.AddWithValue("@ID", txtID.Text)

            MYcommand.ExecuteNonQuery()
            MessageBox.Show("Records Deleted Successfully!")
            MyLoadData()
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        Finally
            Myconnection.Close()
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            MSconnection.Open()

            Dim MScommand As New SqlCommand("SELECT idno, CONCAT(firstname, ' ', middlename, ' ', lastname) AS fullname, course FROM tbl_info WHERE firstname LIKE @holder OR lastname LIKE @holder;", MSconnection)
            MScommand.Parameters.AddWithValue("@holder", txtSearch.Text & "%")

            Dim da As New SqlDataAdapter(MScommand)
            Dim dt As New DataTable

            da.Fill(dt)
            DataGridView2.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            MSconnection.Close()
        End Try

        Try
            Myconnection.Open()

            Dim MYcommand As New MySqlCommand("SELECT idno, CONCAT(firstname, ' ', middlename, ' ', lastname) AS fullname, course FROM tbl_info WHERE firstname LIKE @holder OR lastname LIKE @holder;", Myconnection)
            MYcommand.Parameters.AddWithValue("@holder", txtSearch.Text & "%")

            Dim dta As New MySqlDataAdapter(MYcommand)
            Dim dtl As New DataTable

            dta.Fill(dtl)
            DataGridView1.DataSource = dtl
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            Myconnection.Close()
        End Try
    End Sub
End Class