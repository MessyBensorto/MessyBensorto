<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MSSQL_MYSQLINTERECORDS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtFname = New System.Windows.Forms.TextBox()
        Me.txtMname = New System.Windows.Forms.TextBox()
        Me.txtLname = New System.Windows.Forms.TextBox()
        Me.btnMySql = New System.Windows.Forms.Button()
        Me.btnMsSql = New System.Windows.Forms.Button()
        Me.course = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnMYloaddata = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnMssqlLoaddata = New System.Windows.Forms.Button()
        Me.btn_update_mssql = New System.Windows.Forms.Button()
        Me.btn_update_mysql = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnDELETEMSSQL = New System.Windows.Forms.Button()
        Me.btnDeletemysql = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Firstname:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Middlename"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Lastname"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(101, 23)
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(134, 28)
        Me.txtID.TabIndex = 4
        '
        'txtFname
        '
        Me.txtFname.Location = New System.Drawing.Point(101, 57)
        Me.txtFname.Multiline = True
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(134, 28)
        Me.txtFname.TabIndex = 5
        '
        'txtMname
        '
        Me.txtMname.Location = New System.Drawing.Point(101, 100)
        Me.txtMname.Multiline = True
        Me.txtMname.Name = "txtMname"
        Me.txtMname.Size = New System.Drawing.Size(134, 28)
        Me.txtMname.TabIndex = 6
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(101, 146)
        Me.txtLname.Multiline = True
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(134, 28)
        Me.txtLname.TabIndex = 7
        '
        'btnMySql
        '
        Me.btnMySql.Location = New System.Drawing.Point(162, 226)
        Me.btnMySql.Name = "btnMySql"
        Me.btnMySql.Size = New System.Drawing.Size(135, 59)
        Me.btnMySql.TabIndex = 8
        Me.btnMySql.Text = "REGSITER (MYSQL)"
        Me.btnMySql.UseVisualStyleBackColor = True
        '
        'btnMsSql
        '
        Me.btnMsSql.Location = New System.Drawing.Point(4, 233)
        Me.btnMsSql.Name = "btnMsSql"
        Me.btnMsSql.Size = New System.Drawing.Size(135, 59)
        Me.btnMsSql.TabIndex = 9
        Me.btnMsSql.Text = "REGSITER (MSSQL)"
        Me.btnMsSql.UseVisualStyleBackColor = True
        '
        'course
        '
        Me.course.FormattingEnabled = True
        Me.course.Items.AddRange(New Object() {"BSIT ", "BSBA", "BSHM", "BST", "BSCRIM", "BSPE", "BSPRMA"})
        Me.course.Location = New System.Drawing.Point(101, 192)
        Me.course.Name = "course"
        Me.course.Size = New System.Drawing.Size(121, 21)
        Me.course.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Course:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(380, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(402, 204)
        Me.DataGridView1.TabIndex = 17
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Idno"
        Me.Column1.HeaderText = "IDNO"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "fullname"
        Me.Column2.HeaderText = "FULLNAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "course"
        Me.Column3.HeaderText = "COURSE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'btnMYloaddata
        '
        Me.btnMYloaddata.Location = New System.Drawing.Point(162, 391)
        Me.btnMYloaddata.Name = "btnMYloaddata"
        Me.btnMYloaddata.Size = New System.Drawing.Size(135, 50)
        Me.btnMYloaddata.TabIndex = 18
        Me.btnMYloaddata.Text = "LOAD RECORDS (MYSQL)"
        Me.btnMYloaddata.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView2.Location = New System.Drawing.Point(380, 311)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(402, 238)
        Me.DataGridView2.TabIndex = 19
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Idno"
        Me.Column4.HeaderText = "IDNO"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "fullname"
        Me.Column5.HeaderText = "FULLNAME"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "course"
        Me.Column6.HeaderText = "COURSE"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'btnMssqlLoaddata
        '
        Me.btnMssqlLoaddata.Location = New System.Drawing.Point(4, 391)
        Me.btnMssqlLoaddata.Name = "btnMssqlLoaddata"
        Me.btnMssqlLoaddata.Size = New System.Drawing.Size(135, 50)
        Me.btnMssqlLoaddata.TabIndex = 20
        Me.btnMssqlLoaddata.Text = "LOAD RECORDS (MSSQL)"
        Me.btnMssqlLoaddata.UseVisualStyleBackColor = True
        '
        'btn_update_mssql
        '
        Me.btn_update_mssql.Location = New System.Drawing.Point(4, 292)
        Me.btn_update_mssql.Name = "btn_update_mssql"
        Me.btn_update_mssql.Size = New System.Drawing.Size(135, 44)
        Me.btn_update_mssql.TabIndex = 21
        Me.btn_update_mssql.Text = "UPDATE (MSSQL) "
        Me.btn_update_mssql.UseVisualStyleBackColor = True
        '
        'btn_update_mysql
        '
        Me.btn_update_mysql.Location = New System.Drawing.Point(162, 291)
        Me.btn_update_mysql.Name = "btn_update_mysql"
        Me.btn_update_mysql.Size = New System.Drawing.Size(135, 44)
        Me.btn_update_mysql.TabIndex = 22
        Me.btn_update_mysql.Text = "UPDATE (MYSQL) "
        Me.btn_update_mysql.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(471, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "DATAGRIDVIEW(MYSQL)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(471, 292)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(189, 16)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "DATAGRIDVIEW (MSSQL)"
        '
        'btnDELETEMSSQL
        '
        Me.btnDELETEMSSQL.Location = New System.Drawing.Point(4, 341)
        Me.btnDELETEMSSQL.Name = "btnDELETEMSSQL"
        Me.btnDELETEMSSQL.Size = New System.Drawing.Size(135, 44)
        Me.btnDELETEMSSQL.TabIndex = 25
        Me.btnDELETEMSSQL.Text = "DELETE (MSSQL) "
        Me.btnDELETEMSSQL.UseVisualStyleBackColor = True
        '
        'btnDeletemysql
        '
        Me.btnDeletemysql.Location = New System.Drawing.Point(162, 341)
        Me.btnDeletemysql.Name = "btnDeletemysql"
        Me.btnDeletemysql.Size = New System.Drawing.Size(135, 44)
        Me.btnDeletemysql.TabIndex = 26
        Me.btnDeletemysql.Text = "DELETE (MYSQL) "
        Me.btnDeletemysql.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(295, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 18)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "SEARCH:"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(380, 12)
        Me.txtSearch.Multiline = True
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(289, 28)
        Me.txtSearch.TabIndex = 28
        '
        'MSSQL_MYSQLINTERECORDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1031, 554)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnDeletemysql)
        Me.Controls.Add(Me.btnDELETEMSSQL)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_update_mysql)
        Me.Controls.Add(Me.btn_update_mssql)
        Me.Controls.Add(Me.btnMssqlLoaddata)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.btnMYloaddata)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.course)
        Me.Controls.Add(Me.btnMsSql)
        Me.Controls.Add(Me.btnMySql)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtMname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MSSQL_MYSQLINTERECORDS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MSSQL_MYSQLINTERECORDS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtMname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents btnMySql As Button
    Friend WithEvents btnMsSql As Button
    Friend WithEvents course As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents btnMYloaddata As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents btnMssqlLoaddata As Button
    Friend WithEvents btn_update_mssql As Button
    Friend WithEvents btn_update_mysql As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnDELETEMSSQL As Button
    Friend WithEvents btnDeletemysql As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSearch As TextBox
End Class
