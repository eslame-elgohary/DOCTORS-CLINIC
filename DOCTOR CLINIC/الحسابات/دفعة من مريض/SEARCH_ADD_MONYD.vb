Public Class SEARCH_ADD_MONYD
    Private Sub SEARCH_ADD_MONYD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FILL_DGV(DataGridView1, "SELECT * FROM ADD_MONY_MAML,PATIENT WHERE PA_CODE = ADD_PA_CODE AND ADD_STAT='TRUE' AND ADD_CODE2 = '0' ORDER BY ADD_MONY_MAML.ID DESC")
        K1.SelectedIndex = 1
    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(4).Value = "عرض"
            Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(4, DataGridView1.CurrentRow.Index).Selected = True Then
            DOF3A_PATION_FRM.SHOW_DETA(DataGridView1.CurrentRow.Cells(0).Value)
            Me.Close()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If K1.SelectedIndex = 0 Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT,ADD_MONY_MAML WHERE PA_CODE = ADD_PA_CODE AND ADD_STAT='TRUE' AND ADD_CODE2 = '0' AND ADD_CODE LIKE '%" & TextBox1.Text & "%'", SqlConn)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
        If K1.SelectedIndex = 1 Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT,ADD_MONY_MAML WHERE PA_CODE = ADD_PA_CODE AND ADD_STAT='TRUE' AND ADD_CODE2 = '0' AND PA_NAME LIKE '%" & TextBox1.Text & "%'", SqlConn)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
    End Sub
End Class