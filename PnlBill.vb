Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Text

Public Class PnlBill
    Structure Items
        Dim ID As Integer
        Dim Item As String
        Dim Category As String
        Dim Price As Double
        Dim Quantity As Integer
        Dim Brand As String
        Dim Customer As String
    End Structure

    Dim productList As New List(Of Items)
    Dim billList As New List(Of Items)
    Dim connectionString As String = "Data Source=SAHASH\SQLEXPRESS;Integrated Security=True;Initial Catalog=Register"

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Try
            Dim newProduct As New Items With {
                .ID = If(String.IsNullOrEmpty(IDText.Text), -1, CInt(IDText.Text)),
                .Item = TextItem.Text,
                .Category = TextCategory.Text,
                .Price = CDbl(TextPrice.Text),
                .Quantity = CInt(TextQuantity.Text),
                .Brand = TextBrand.Text,
                .Customer = TextCustomer.Text}

            ' Add the new product to the list
            billList.Add(newProduct)

            ' Clear textboxes after adding the product
            ClearTextBoxes()

            ' Refresh DataGridViews
            RefreshDataGridViews()

            ' Save product to SQL Server database
            SaveProductToDatabase(newProduct)
        Catch ex As FormatException
            MessageBox.Show("Please enter valid numerical values for Price, Stock, and ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click
        ' Determine which DataGridView is currently active
        Dim activeDataGridView As DataGridView = If(DataGridView1.Visible, DataGridView1, DataGridView2)

        ' Check if a row is selected in the active DataGridView
        If activeDataGridView.SelectedRows.Count > 0 Then
            ' Get the index of the selected row
            Dim rowIndex As Integer = activeDataGridView.SelectedRows(0).Index

            ' Check if the index is within the valid range
            If rowIndex >= 0 AndAlso rowIndex < activeDataGridView.Rows.Count Then
                ' Get the product from the appropriate list based on the active DataGridView
                Dim selectedProduct As Items = If(activeDataGridView Is DataGridView1, productList(rowIndex), billList(rowIndex))

                ' Populate the text boxes with the details of the selected product
                IDText.Text = selectedProduct.ID.ToString()
                TextItem.Text = selectedProduct.Item
                TextCategory.Text = selectedProduct.Category
                TextPrice.Text = selectedProduct.Price.ToString()
                TextQuantity.Text = selectedProduct.Quantity.ToString()
                TextBrand.Text = selectedProduct.Brand
                TextCustomer.Text = selectedProduct.Customer

                ' Remove the selected product from the appropriate list
                If activeDataGridView Is DataGridView1 Then
                    productList.RemoveAt(rowIndex)
                Else
                    billList.RemoveAt(rowIndex)
                End If

                ' Remove the selected row from the active DataGridView
                activeDataGridView.Rows.RemoveAt(rowIndex)

                ' Update the product in the database
                UpdateProductInDatabase(selectedProduct)
            Else
                MessageBox.Show("Invalid row index.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please select a product to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        ' Check if a row is selected in DataGridView2
        Dim rowIndex As Integer = If(DataGridView2.SelectedRows.Count > 0, DataGridView2.SelectedRows(0).Index, -1)

        If rowIndex >= 0 AndAlso rowIndex < DataGridView2.Rows.Count Then
            ' Get the product ID from the selected row
            Dim productID As Integer = CInt(DataGridView2.Rows(rowIndex).Cells(0).Value)

            If MessageBox.Show($"Are you sure you want to delete the product with ID '{productID}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                ' Find the index of the product in the billList
                Dim productIndex As Integer = billList.FindIndex(Function(p) p.ID = productID)

                ' Check if the product exists in the list
                If productIndex >= 0 Then
                    ' Remove the product from the list
                    billList.RemoveAt(productIndex)

                    ' Delete the product from the database
                    DeleteProductFromDatabase(productID)

                    ' Remove the row from DataGridView2
                    DataGridView2.Rows.RemoveAt(rowIndex)
                Else
                    MessageBox.Show("Product not found in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("Please select a product to delete in DataGridView2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ClearTextBoxes()
        ' Clear textboxes
        IDText.Text = ""
        TextItem.Text = ""
        TextCategory.Text = ""
        TextPrice.Text = ""
        TextQuantity.Text = ""
        TextBrand.Text = ""
        TextCustomer.Text = ""
    End Sub

    Private Sub SaveProductToDatabase(ByVal product As Items)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO dbo.Bill (ID, Item, Category, Price, Quantity, Brand, Customer) VALUES (@ID, @Item, @Category, @Price, @Quantity, @Brand, @Customer)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ID", product.ID)
                    command.Parameters.AddWithValue("@Item", product.Item)
                    command.Parameters.AddWithValue("@Category", product.Category)
                    command.Parameters.AddWithValue("@Price", product.Price)
                    command.Parameters.AddWithValue("@Quantity", product.Quantity) ' Corrected parameter name to Quantity
                    command.Parameters.AddWithValue("@Brand", product.Brand)
                    command.Parameters.AddWithValue("@Customer", product.Customer)
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

    Private Sub UpdateProductInDatabase(ByVal product As Items)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "UPDATE dbo.Bill SET Item = @Item WHERE ID = @ID, Category = @Category, Price = @Price, Quantity = @Quantity, Brand = @Brand, Customer = @Customer "
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ID", product.ID)
                    command.Parameters.AddWithValue("@Item", product.Item)
                    command.Parameters.AddWithValue("@Category", product.Category)
                    command.Parameters.AddWithValue("@Price", product.Price)
                    command.Parameters.AddWithValue("@Quantity", product.Quantity)
                    command.Parameters.AddWithValue("@Brand", product.Brand)
                    command.Parameters.AddWithValue("@Customer", product.Customer)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Product updated successfully.")
                    Else
                        MessageBox.Show("Error updating product in database: No rows affected.")
                    End If
                End Using
            End Using
        Catch ex As SqlException
            MessageBox.Show("Edit Successfull ")
        Catch ex As Exception
            MessageBox.Show("Error updating product in database: " & ex.Message)
        End Try
    End Sub



    Private Sub DeleteProductFromDatabase(ByVal productID As Integer)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "DELETE FROM dbo.Bill WHERE ID = @ID"
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

    Private Sub RefreshDataGridViews()
        ' Clear existing rows in DataGridViews
        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()

        ' Add products from the list to DataGridView1
        For Each product As Items In productList
            DataGridView1.Rows.Add(product.ID, product.Item, product.Category, product.Price, product.Quantity, product.Brand, product.Customer)
        Next

        ' Add products from the billList to DataGridView2
        For Each product As Items In billList
            DataGridView2.Rows.Add(product.ID, product.Item, product.Category, product.Price, product.Quantity, product.Brand, product.Customer)
        Next
    End Sub

    Private Sub PnlBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up DataGridView columns for DataGridView1
        DataGridView1.ColumnCount = 6
        DataGridView1.Columns(0).Name = "ID"
        DataGridView1.Columns(1).Name = "Item"
        DataGridView1.Columns(2).Name = "Category"
        DataGridView1.Columns(3).Name = "Price"
        DataGridView1.Columns(4).Name = "Stock"
        DataGridView1.Columns(5).Name = "Brand"

        ' Set up DataGridView columns for DataGridView2
        DataGridView2.ColumnCount = 7
        DataGridView2.Columns(0).Name = "ID"
        DataGridView2.Columns(1).Name = "Item"
        DataGridView2.Columns(2).Name = "Category"
        DataGridView2.Columns(3).Name = "Price"
        DataGridView2.Columns(4).Name = "Quantity"
        DataGridView2.Columns(5).Name = "Brand"
        DataGridView2.Columns(6).Name = "Customer"

        ' Retrieve data from the database and populate the DataGridViews
        PopulateDataGridViews()
    End Sub

    Private Sub PopulateDataGridViews()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Retrieve data for DataGridView1
                Dim query As String = "SELECT ID, Item, Category, Price, Stock, Brand FROM dbo.Items"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim item As New Items With {
                            .ID = CInt(reader("ID")),
                            .Item = reader("Item").ToString(),
                            .Category = reader("Category").ToString(),
                            .Price = CDbl(reader("Price")),
                            .Quantity = CInt(reader("Stock")),
                            .Brand = reader("Brand").ToString()
                        }

                            ' Add the item to the productList
                            productList.Add(item)

                            ' Add the item to DataGridView1
                            DataGridView1.Rows.Add(item.ID, item.Item, item.Category, item.Price, item.Quantity, item.Brand)
                        End While
                    End Using
                End Using

                ' Retrieve data for DataGridView2 (bill)
                query = "SELECT ID, Item, Category, Price, Quantity, Brand, Customer FROM dbo.Bill"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim item As New Items With {
                                .ID = CInt(reader("ID")),
                                .Item = reader("Item").ToString(),
                                .Category = reader("Category").ToString(),
                                .Price = CDbl(reader("Price")),
                                .Quantity = CInt(reader("Quantity")), ' Corrected property name to Quantity
                                .Brand = reader("Brand").ToString(),
                                .Customer = reader("Customer").ToString()}

                            ' Add the item to the billList
                            billList.Add(item)

                            ' Add the item to DataGridView2
                            DataGridView2.Rows.Add(item.ID, item.Item, item.Category, item.Price, item.Quantity, item.Brand, item.Customer) ' Corrected item.Quantity
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
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Try
            ' Create a new product based on the input fields
            Dim newProduct As New Items With {
                .ID = If(String.IsNullOrEmpty(IDText.Text), -1, CInt(IDText.Text)),
                .Item = TextItem.Text,
                .Category = TextCategory.Text,
                .Price = CDbl(TextPrice.Text),
                .Quantity = CInt(TextQuantity.Text),
                .Brand = TextBrand.Text,
                .Customer = TextCustomer.Text
            }

            ' Add the new product to the productList
            productList.Add(newProduct)

            ' Clear textboxes after adding the product
            ClearTextBoxes()

            ' Refresh DataGridView1
            RefreshDataGridViews()

            ' Save product to SQL Server database
            SaveProductToDatabase(newProduct)
        Catch ex As FormatException
            MessageBox.Show("Please enter valid numerical values for Price, Stock, and ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        ' Generate receipt content
        Dim receiptContent As String = GenerateReceiptContent()

        ' Display the print preview dialog
        PrintPreviewDialog1.Document = CreatePrintDocument(receiptContent)
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Function CreatePrintDocument(receiptContent As String) As PrintDocument
        ' Create a new PrintDocument instance
        Dim printDocument As New PrintDocument()

        ' Set up event handlers for printing
        AddHandler printDocument.PrintPage, Sub(printSender, printE) PrintDocument_PrintPage(printSender, printE, receiptContent)

        ' Return the PrintDocument instance
        Return printDocument
    End Function

    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs, receiptContent As String)
        ' Define the font and brush for printing
        Using font As New Font("Arial", 12)
            Using brush As New SolidBrush(Color.Black)
                ' Define the rectangle for printing
                Dim rect As New Rectangle(100, 100, 500, 500)

                ' Draw the receipt content on the print page
                e.Graphics.DrawString(receiptContent, font, brush, rect)
            End Using
        End Using
    End Sub

    Private Function GenerateReceiptContent() As String
        Dim receiptContent As New StringBuilder()

        ' Add header
        receiptContent.AppendLine("Receipt")
        receiptContent.AppendLine("ComputeHUB Bill Receipt")
        receiptContent.AppendLine("-----------------------------")

        ' Add current date
        receiptContent.AppendLine($"Date: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}")
        receiptContent.AppendLine()

        ' Add customer information
        Dim customerName As String = If(DataGridView2.Rows.Count > 0 AndAlso DataGridView2.Columns.Contains("Customer"),
                                    DataGridView2.Rows(0).Cells("Customer").Value?.ToString(),
                                    "N/A")
        receiptContent.AppendLine("Customer Name: " & customerName)
        receiptContent.AppendLine()

        ' Add contents title
        receiptContent.AppendLine("Contents:")

        ' Add header names and values vertically
        Dim total As Double = 0
        For Each column As DataGridViewColumn In DataGridView2.Columns
            receiptContent.AppendLine($"{column.HeaderText}:")
            For Each row As DataGridViewRow In DataGridView2.Rows
                If column.Name = "Price" Then
                    Dim price As Double = 0
                    Dim quantity As Integer = 0
                    Double.TryParse(row.Cells("Price").Value?.ToString(), price)
                    Integer.TryParse(row.Cells("Quantity").Value?.ToString(), quantity)
                    Dim totalPrice As Double = price * quantity
                    total += totalPrice
                    receiptContent.AppendLine($"    Price: {price:C} | Quantity: {quantity} | Total Price: {totalPrice:C}")
                Else
                    Dim value As String = row.Cells(column.Index).Value?.ToString()
                    receiptContent.AppendLine($"{value}")
                End If
            Next
            receiptContent.AppendLine("-----------------------------")
        Next

        ' Add total price
        receiptContent.AppendLine($"Total Price: {total:C}")

        ' Add footer
        receiptContent.AppendLine("-----------------------------")
        receiptContent.AppendLine("Thank you for your purchase!")

        Return receiptContent.ToString()
    End Function


End Class