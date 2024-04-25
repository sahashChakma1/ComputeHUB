Imports System.Data.SqlClient
Imports ComputeHUB.PnlEmployee
Imports System.IO

Public Class PnlUser
    Structure Product
        Dim CustID As Integer
        Dim Name As String
        Dim Phoneno As String
        Dim Email As String
        Dim Gender As String
    End Structure

    Dim productList As New List(Of Product)
    Dim connectionString As String = "Data Source=SAHASH\SQLEXPRESS;Integrated Security=True;Initial Catalog=Register"

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Try
            Dim newProduct As New Product With {
                .CustID = Convert.ToInt32(CustIdText.Text),
                .Name = NameText.Text,
                .Phoneno = PhoneText.Text,
                .Email = EmailText.Text,
                .Gender = Gender.Text
            }

            ' Save product to SQL Server database
            SaveProductToDatabase(newProduct)

            ' Add the new product to the list after successful database insertion
            productList.Add(newProduct)

            ' Refresh DataGridView
            RefreshDataGridView()

            ' Clear textboxes after adding the product
            ClearTextBoxes()
        Catch ex As FormatException
            MessageBox.Show("Please enter valid values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RefreshDataGridView()
        DataGridView.Rows.Clear()
        For Each product As Product In productList
            DataGridView.Rows.Add(product.CustID, product.Name, product.Phoneno, product.Email, product.Gender)
        Next
    End Sub

    Private Sub ClearTextBoxes()
        CustIdText.Text = ""
        NameText.Text = ""
        PhoneText.Text = ""
        EmailText.Text = ""
        Gender.Text = ""
    End Sub

    Private Sub SaveProductToDatabase(ByVal product As Product)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT INTO [User] (CustID, Name, Phoneno, Email, Gender) VALUES (@CustID, @Name, @Phoneno, @Email, @Gender)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@CustID", product.CustID)
                    command.Parameters.AddWithValue("@Name", product.Name)
                    command.Parameters.AddWithValue("@Phoneno", product.Phoneno)
                    command.Parameters.AddWithValue("@Email", product.Email)
                    command.Parameters.AddWithValue("@Gender", product.Gender)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Product saved successfully.")
                    Else
                        MessageBox.Show("Error saving product to database: No rows affected.")
                    End If
                End Using
            End Using
        Catch ex As SqlException
            MessageBox.Show("SQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error saving product to database: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            Dim rowIndex As Integer = DataGridView.CurrentRow.Index
            If rowIndex >= 0 AndAlso rowIndex < DataGridView.Rows.Count Then
                Dim productName As String = DataGridView.Rows(rowIndex).Cells(1).Value.ToString() ' Name column
                If MessageBox.Show($"Are you sure you want to delete the product '{productName}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim product As Product = productList.Find(Function(p) p.Name = productName)
                    If Not product.Equals(Nothing) Then
                        DeleteProductFromDatabase(productName)
                        productList.Remove(product)
                        DataGridView.Rows.RemoveAt(rowIndex)
                        MessageBox.Show("Product deleted successfully.")
                    Else
                        MessageBox.Show("Product not found in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("Please select a product to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error deleting product: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DeleteProductFromDatabase(ByVal productName As String)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "DELETE FROM [User] WHERE Name = @Name"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Name", productName)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        MessageBox.Show("Product not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As SqlException
            MessageBox.Show("SQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error deleting product from database: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView.ColumnCount = 5
        DataGridView.Columns(0).Name = "CustID"
        DataGridView.Columns(1).Name = "Name"
        DataGridView.Columns(2).Name = "Phoneno"
        DataGridView.Columns(3).Name = "Email"
        DataGridView.Columns(4).Name = "Gender"
        LoadDataIntoDataGridView()
    End Sub

    Private Sub LoadDataIntoDataGridView()
        Try
            DataGridView.Rows.Clear()
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT CustID, Name, Phoneno, Email, Gender FROM [User]"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim custID As Integer = Convert.ToInt32(reader("CustID"))
                            Dim name As String = reader("Name").ToString()
                            Dim phoneno As String = reader("Phoneno").ToString()
                            Dim email As String = reader("Email").ToString()
                            Dim gender As String = reader("Gender").ToString()
                            DataGridView.Rows.Add(custID, name, phoneno, email, gender)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As SqlException
            MessageBox.Show("SQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error loading data into DataGridView: " & ex.Message)
        End Try
    End Sub

End Class
