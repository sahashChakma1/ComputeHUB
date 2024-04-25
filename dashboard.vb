Imports System.Drawing.Text

Public Class Dashboard
    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        Me.Close()
    End Sub

    Sub SwitchPanel(ByVal panel As Form)
        PanelDashboard.Controls.Clear()
        panel.TopLevel = False
        PanelDashboard.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub BtnBrand_Click(sender As Object, e As EventArgs) Handles BtnBrand.Click
        SwitchPanel(PnlItem)
    End Sub

    Private Sub BtnUser_Click(sender As Object, e As EventArgs) Handles BtnUser.Click
        SwitchPanel(PnlUser)
    End Sub
    Private Sub BtnOrder_Click(sender As Object, e As EventArgs) Handles BtnOrder.Click
        SwitchPanel(PnlBill)
    End Sub
    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click

        Dim message As String = "Are You Sure ?"
        Dim tittle As String = "FormClosing"
        Dim Result = MessageBox.Show(message, tittle, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If Result = DialogResult.OK Then
            Login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchPanel(PnlItem)
    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        SwitchPanel(PnlEmployee)
    End Sub


End Class