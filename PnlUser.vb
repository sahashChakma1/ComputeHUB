Imports System.Data.SqlClient

Public Class PnlUser
    Structure Product
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
                .Name = NameText.Text,
                .Phoneno = PhoneText.Text,
                .Email = EmailText.Text,
                .Gender = Gender.Text
            }

            ' Add the new product to the list
            productList.Add(newProduct)

            ' Clear textboxes after adding the product
            ClearTextBoxes()

            ' Refresh DataGridView
            RefreshDataGridView()

            ' Save product to SQL Server database
            SaveProductToDatabase(newProduct)
        Catch ex As FormatException
            MessageBox.Show("Please enter valid values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RefreshDataGridView()
        ' Clear existing rows in DataGridView
        DataGridView.Rows.Clear()

        ' Add products from the list to the DataGridView
        For Each product As Product In productList
            DataGridView.Rows.Add(product.Name, product.Phoneno, product.Email, product.Gender)
        Next
    End Sub

    Private Sub ClearTextBoxes()
        ' Clear textboxes
        NameText.Text = ""
        PhoneText.Text = ""
        EmailText.Text = ""
        Gender.Text = ""
    End Sub

    Private Sub SaveProductToDatabase(ByVal product As Product)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO [User] (Name, Phoneno, Email, Gender) VALUES (@Name, @Phoneno, @Email, @Gender)"
                Using command As New SqlCommand(query, connection)
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

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        ' Check if a row is selected
        If DataGridView.SelectedRows.Count > 0 Then
            ' Get the index of the selected row
            Dim rowIndex As Integer = DataGridView.SelectedRows(0).Index

            ' Check if the index is within the valid range of productList
            If rowIndex >= 0 AndAlso rowIndex < productList.Count Then
                ' Get the product from the productList at the selected index
                Dim selectedProduct As Product = productList(rowIndex)

                ' Populate the text boxes with the details of the selected product
                NameText.Text = selectedProduct.Name
                PhoneText.Text = selectedProduct.Phoneno
                EmailText.Text = selectedProduct.Email
                Gender.Text = selectedProduct.Gender

                ' Remove the selected product from the productList
                productList.RemoveAt(rowIndex)

                ' Remove the selected row from the DataGridView
                DataGridView.Rows.RemoveAt(rowIndex)

                ' Update the product in the database
                UpdateProductInDatabase(selectedProduct)
            Else
                MessageBox.Show("Invalid row index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select a product to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        ' Implement delete functionality here
        Dim rowIndex As Integer = DataGridView.CurrentRow.Index

        If rowIndex >= 0 AndAlso rowIndex < DataGridView.Rows.Count Then
            ' Get the product name from the selected row
            Dim productName As String = DataGridView.Rows(rowIndex).Cells(0).Value.ToString()

            If MessageBox.Show($"Are you sure you want to delete the product '{productName}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ' Find the index of the product in the productList
                Dim productIndex As Integer = productList.FindIndex(Function(p) p.Name = productName)

                ' Check if the product exists in the list
                If productIndex >= 0 Then
                    ' Remove the product from the list
                    productList.RemoveAt(productIndex)

                    ' Delete the product from the database
                    DeleteProductFromDatabase(productName)

                    ' Remove the row from the DataGridView
                    DataGridView.Rows.RemoveAt(rowIndex)
                Else
                    MessageBox.Show("Product not found in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("Please select a product to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DeleteProductFromDatabase(ByVal productName As String)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "DELETE FROM [User] WHERE Name = @Name"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Name", productName)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Product deleted successfully.")
                    Else
                        MessageBox.Show("Error deleting product from database: No rows affected.")
                    End If
                End Using
            End Using
        Catch ex As SqlException
            MessageBox.Show("SQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error deleting product from database: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateProductInDatabase(ByVal product As Product)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "UPDATE [User] SET Phoneno = @Phoneno, Email = @Email, Gender = @Gender WHERE Name = @Name"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Name", product.Name)
                    command.Parameters.AddWithValue("@Phoneno", product.Phoneno)
                    command.Parameters.AddWithValue("@Email", product.Email)
                    command.Parameters.AddWithValue("@Gender", product.Gender)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Product updated successfully.")
                    Else
                        MessageBox.Show("Error updating product in database: No rows affected.")
                    End If
                End Using
            End Using
        Catch ex As SqlException
            MessageBox.Show("SQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error updating product in database: " & ex.Message)
        End Try
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up DataGridView columns
        DataGridView.ColumnCount = 4
        DataGridView.Columns(0).Name = "Name"
        DataGridView.Columns(1).Name = "Phoneno"
        DataGridView.Columns(2).Name = "Email"
        DataGridView.Columns(3).Name = "Gender"

        ' Load data from the database into the DataGridView
        LoadDataIntoDataGridView()
    End Sub

    Private Sub LoadDataIntoDataGridView()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT Name, Phoneno, Email, Gender FROM [User]"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim name As String = reader("Name").ToString()
                            Dim phoneno As String = reader("Phoneno").ToString()
                            Dim email As String = reader("Email").ToString()
                            Dim gender As String = reader("Gender").ToString()
                            DataGridView.Rows.Add(name, phoneno, email, gender)
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
