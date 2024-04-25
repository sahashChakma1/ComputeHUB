
Imports System.Data.SqlClient

<DebuggerDisplay("{GetDebuggerDisplay(),nq}")>
Public Class Register


    Private Sub BACK_Click(sender As Object, e As EventArgs) Handles BACK.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Me.Close()
    End Sub

    Private Sub CreateBox_Click(sender As Object, e As EventArgs) Handles CreateBox.Click
        Dim Name As String = Namebox.Text
        Dim Username As String = UserNameBox.Text
        Dim Password As String = PasswordBox.Text
        Dim ConfirmPassword As String = ConfirmPassBox.Text

        If Password <> ConfirmPassword Then
            MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Corrected connection string
        Dim connectionString As String = "Data Source=SAHASH\SQLEXPRESS;Initial Catalog=Register;Integrated Security=True"
        Dim query As String = "INSERT INTO dbo.Regis VALUES (@Name, @Username, @Password, @ConfirmPassword)"

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Name", Name)
                    command.Parameters.AddWithValue("@Username", Username)
                    command.Parameters.AddWithValue("@Password", Password)
                    command.Parameters.AddWithValue("@ConfirmPassword", ConfirmPassword)
                    command.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearFields()
        Namebox.Clear()
        UserNameBox.Clear()
        PasswordBox.Clear()
        ConfirmPassBox.Clear()
    End Sub

    Private Function GetDebuggerDisplay() As String
        Return ToString()
    End Function


End Class
