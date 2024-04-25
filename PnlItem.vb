Imports System.Data.SqlClient

Public Class PnlItem

    Structure Items
        Dim ID As Integer
        Dim Item As String
        Dim Category As String
        Dim Price As Double
        Dim Stock As Integer
        Dim Brand As String
    End Structure

    Private Const V As String = ""
    Dim productList As New List(Of Items)
    Dim connectionString As String = "Data Source=SAHASH\SQLEXPRESS;Integrated Security=True;Initial Catalog=Register"

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Try
            Dim newProduct As New Items With {
                .ID = If(String.IsNullOrEmpty(IDText.Text), -1, CInt(IDText.Text)), ' Convert.ToInt32(IDText.Text)
                .Item = ItemText.Text,
                .Category = CategoryText.Text,
                .Price = CDbl(PriceText.Text),
                .Stock = CInt(StockText.Text),
                .Brand = BrandText.Text
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
            MessageBox.Show("Please enter valid numerical values for Price, Stock, and ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub RefreshDataGridView()
        ' Clear existing rows in DataGridView
        DataGridView1.Rows.Clear()

        ' Add products from the list to the DataGridView
        For Each product As Items In productList
            DataGridView1.Rows.Add(product.ID, product.Item, product.Category, product.Price, product.Stock, product.Brand)
        Next
    End Sub

    Private Sub ClearTextBoxes()
        ' Clear textboxes
        IDText.Text = ""
        ItemText.Text = ""
        CategoryText.Text = V
        PriceText.Text = ""
        StockText.Text = ""
        BrandText.Text = ""
    End Sub

    Private Sub SaveProductToDatabase(ByVal product As Items)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO dbo.Items (ID, Item, Category, Price, Stock, Brand) VALUES (@ID, @Item, @Category, @Price, @Stock, @Brand)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ID", product.ID)
                    command.Parameters.AddWithValue("@Item", product.Item)
                    command.Parameters.AddWithValue("@Category", product.Category)
                    command.Parameters.AddWithValue("@Price", product.Price)
                    command.Parameters.AddWithValue("@Stock", product.Stock)
                    command.Parameters.AddWithValue("@Brand", product.Brand)
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
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Get the index of the selected row
            Dim rowIndex As Integer = DataGridView1.SelectedRows(0).Index

            ' Check if the index is within the valid range of productList
            If rowIndex >= 0 AndAlso rowIndex < productList.Count Then
                ' Get the product from the productList at the selected index
                Dim selectedProduct As Items = productList(rowIndex)

                ' Populate the text boxes with the details of the selected product
                IDText.Text = selectedProduct.ID.ToString()
                ItemText.Text = selectedProduct.Item
                CategoryText.Text = selectedProduct.Category
                PriceText.Text = selectedProduct.Price.ToString()
                StockText.Text = selectedProduct.Stock.ToString()
                BrandText.Text = selectedProduct.Brand

                ' Remove the selected product from the productList
                productList.RemoveAt(rowIndex)

                ' Remove the selected row from the DataGridView
                DataGridView1.Rows.RemoveAt(rowIndex)

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
        Dim rowIndex As Integer = DataGridView1.CurrentRow.Index

        If rowIndex >= 0 AndAlso rowIndex < DataGridView1.Rows.Count Then
            ' Get the product ID from the selected row
            Dim productID As Integer = CInt(DataGridView1.Rows(rowIndex).Cells(0).Value)

            If MessageBox.Show($"Are you sure you want to delete the product with ID '{productID}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ' Find the index of the product in the productList
                Dim productIndex As Integer = productList.FindIndex(Function(p) p.ID = productID)

                ' Check if the product exists in the list
                If productIndex >= 0 Then
                    ' Remove the product from the list
                    productList.RemoveAt(productIndex)

                    ' Delete the product from the database
                    DeleteProductFromDatabase(productID)

                    ' Remove the row from the DataGridView
                    DataGridView1.Rows.RemoveAt(rowIndex)
                Else
                    MessageBox.Show("Product not found in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("Please select a product to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub DeleteProductFromDatabase(ByVal productID As Integer)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "DELETE FROM dbo.Items WHERE ID = @ID"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ID", productID)
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

    Private Sub UpdateProductInDatabase(ByVal product As Items)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "UPDATE dbo.Items SET Item = @Item, Category = @Category, Price = @Price, Stock = @Stock, Brand = @Brand WHERE ID = @ID"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ID", product.ID)
                    command.Parameters.AddWithValue("@Item", product.Item)
                    command.Parameters.AddWithValue("@Category", product.Category)
                    command.Parameters.AddWithValue("@Price", product.Price)
                    command.Parameters.AddWithValue("@Stock", product.Stock)
                    command.Parameters.AddWithValue("@Brand", product.Brand)
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

    Private Sub PnlItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up DataGridView columns
        DataGridView1.ColumnCount = 6
        DataGridView1.Columns(0).Name = "ID"
        DataGridView1.Columns(1).Name = "Item"
        DataGridView1.Columns(2).Name = "Category"
        DataGridView1.Columns(3).Name = "Price"
        DataGridView1.Columns(4).Name = "Stock"
        DataGridView1.Columns(5).Name = "Brand"

        ' Retrieve data from the database and populate the DataGridView
        PopulateDataGridView()
    End Sub

    Private Sub PopulateDataGridView()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT ID, Item, Category, Price, Stock, Brand FROM dbo.Items"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim item As New Items With {
                                .ID = CInt(reader("ID")),
                                .Item = reader("Item").ToString(),
                                .Category = reader("Category").ToString(),
                                .Price = CDbl(reader("Price")),
                                .Stock = CInt(reader("Stock")),
                                .Brand = reader("Brand").ToString()
                            }

                            ' Add the item to the productList
                            productList.Add(item)

                            ' Add the item to the DataGridView
                            DataGridView1.Rows.Add(item.ID, item.Item, item.Category, item.Price, item.Stock, item.Brand)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As SqlException
            MessageBox.Show("SQL Error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub


End Class
