Imports System.Runtime.CompilerServices
Imports Guna.UI2.WinForms
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.Web.UI.HtmlControls

Public Class Login

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Register.Show()
        Me.Hide()
    End Sub
    Private Sub Guna2CustomCheckBox1_Click(sender As Object, e As EventArgs) Handles Guna2CustomCheckBox1.Click
        If Guna2CustomCheckBox1.Checked = False Then
            Password.PasswordChar = "*"
        Else
            Password.PasswordChar = ""
        End If
    End Sub

    Private Sub BtnLogIn_Click(sender As Object, e As EventArgs) Handles BtnLogIn.Click
        ' Get the connection string
        Dim connectionString As String = "Data Source=SAHASH\SQLEXPRESS;Initial Catalog=Register;Integrated Security=True"

        ' Create and open a connection to the database
        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' Create a SqlCommand object with the SQL query and the connection
            Dim command As New SqlCommand("SELECT * FROM dbo.Regis WHERE Username=@Username AND Password=@Password", connection)

            ' Add parameters to the SQL command
            command.Parameters.AddWithValue("@Username", UserName.Text)
            command.Parameters.AddWithValue("@Password", Password.Text)

            ' Execute the command to fetch data
            Dim reader As SqlDataReader = command.ExecuteReader()

            ' Check if any rows were returned
            If reader.HasRows Then
                ' Login successful
                MessageBox.Show("Login successful!")

                ' Check if the logged-in user is an admin
                If IsAdmin(UserName.Text) Then
                    ' If admin, show the admin dashboard
                    Dim adminDashboardForm As New Dashboard()
                    adminDashboardForm.Show()
                Else
                    ' If not admin, show the regular dashboard
                    Dim homeForm As New Home()
                    homeForm.Show()
                End If
            Else
                ' Login failed
                MessageBox.Show("Invalid username or password. Please try again.")
            End If

            ' Close the SqlDataReader and the connection
            reader.Close()
        End Using
    End Sub

    Private Function IsAdmin(username As String) As Boolean
        ' This function checks if the username is an admin.
        ' You can implement your logic to determine if a user is an admin.
        ' For demonstration, let's assume the username "admin" is an admin user.
        Return username.ToLower() = "admin"
    End Function

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
