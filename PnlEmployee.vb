Imports System.Data.SqlClient

Public Class PnlEmployee

    Structure Employee
        Dim ID As Integer
        Dim Name As String
        Dim Gender As String
        Dim Phoneno As String
        Dim Address As String
    End Structure

    Dim employeeList As New List(Of Employee)
    Dim connectionString As String = "Data Source=SAHASH\SQLEXPRESS;Integrated Security=True;Initial Catalog=Register"

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        Try
            Dim newEmployee As New Employee() ' Create a new instance of Employee structure

            If String.IsNullOrEmpty(IDEmp.Text) OrElse String.IsNullOrEmpty(EmpName.Text) OrElse String.IsNullOrEmpty(EmpGender.Text) OrElse String.IsNullOrEmpty(EmpPhone.Text) OrElse String.IsNullOrEmpty(EmpAddress.Text) Then
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            newEmployee.ID = Integer.Parse(IDEmp.Text)
            newEmployee.Name = EmpName.Text
            newEmployee.Gender = EmpGender.Text
            newEmployee.Phoneno = EmpPhone.Text
            newEmployee.Address = EmpAddress.Text

            ' Save employee to SQL Server database
            SaveEmployeeToDatabase(newEmployee)

            ' Add the new employee to the list
            employeeList.Add(newEmployee)

            ' Refresh DataGridView
            RefreshDataGridView()

            ' Clear textboxes after adding the employee
            ClearTextBoxes()

            MessageBox.Show("Employee saved successfully.")
        Catch ex As FormatException
            MessageBox.Show("Please enter valid values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error saving employee: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub RefreshDataGridView()
        ' Clear existing rows in DataGridView
        DataGridView.Rows.Clear()

        ' Add employees from the list to the DataGridView
        For Each employee As Employee In employeeList
            DataGridView.Rows.Add(employee.ID, employee.Name, employee.Gender, employee.Phoneno, employee.Address)
        Next
    End Sub

    Private Sub ClearTextBoxes()
        ' Clear textboxes
        IDEmp.Text = ""
        EmpName.Text = ""
        EmpGender.Text = ""
        EmpPhone.Text = ""
        EmpAddress.Text = ""
    End Sub

    Private Sub SaveEmployeeToDatabase(ByVal employee As Employee)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO [Employee] (ID, Name, Gender, Phoneno, Address) VALUES (@ID, @Name, @Gender, @Phoneno, @Address)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ID", employee.ID)
                    command.Parameters.AddWithValue("@Name", employee.Name)
                    command.Parameters.AddWithValue("@Gender", employee.Gender)
                    command.Parameters.AddWithValue("@Phoneno", employee.Phoneno)
                    command.Parameters.AddWithValue("@Address", employee.Address)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        MessageBox.Show("Error saving employee to database: No rows affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As SqlException
            MessageBox.Show("SQL Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error saving employee: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        ' Implement delete functionality here
        If DataGridView.SelectedRows.Count > 0 Then
            Dim rowIndex As Integer = DataGridView.SelectedRows(0).Index

            If rowIndex >= 0 AndAlso rowIndex < DataGridView.Rows.Count Then
                Dim employeeID As Integer = CInt(DataGridView.Rows(rowIndex).Cells(0).Value)

                If MessageBox.Show($"Are you sure you want to delete the employee with ID '{employeeID}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    ' Delete the employee from the database
                    DeleteEmployeeFromDatabase(employeeID)

                    ' Remove the employee from the list
                    Dim employeeIndex As Integer = employeeList.FindIndex(Function(emp) emp.ID = employeeID)
                    If employeeIndex >= 0 Then
                        employeeList.RemoveAt(employeeIndex)
                    End If

                    ' Remove the row from the DataGridView
                    DataGridView.Rows.RemoveAt(rowIndex)

                    MessageBox.Show("Employee deleted successfully.")
                End If
            Else
                MessageBox.Show("Please select an employee to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub DeleteEmployeeFromDatabase(ByVal employeeID As Integer)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "DELETE FROM [Employee] WHERE ID = @ID"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ID", employeeID)
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected = 0 Then
                        MessageBox.Show("Error deleting employee from database: No rows affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As SqlException
            MessageBox.Show("SQL Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error deleting employee: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PnlEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up DataGridView columns
        DataGridView.ColumnCount = 5
        DataGridView.Columns(0).Name = "ID"
        DataGridView.Columns(1).Name = "Name"
        DataGridView.Columns(2).Name = "Gender"
        DataGridView.Columns(3).Name = "Phoneno"
        DataGridView.Columns(4).Name = "Address"

        ' Load data from the database into the DataGridView
        LoadDataIntoDataGridView()
    End Sub

    Private Sub LoadDataIntoDataGridView()
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT ID, Name, Gender, Phoneno, Address FROM [Employee]"
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim id As Integer = CInt(reader("ID"))
                            Dim name As String = reader("Name").ToString()
                            Dim gender As String = reader("Gender").ToString()
                            Dim phoneno As String = reader("Phoneno").ToString()
                            Dim address As String = reader("Address").ToString()
                            DataGridView.Rows.Add(id, name, gender, phoneno, address)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As SqlException
            MessageBox.Show("SQL Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error loading data into DataGridView: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
