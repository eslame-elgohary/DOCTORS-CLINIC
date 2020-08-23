Public Class SEARCH_ATAB_DOCTORS
    Private Sub SEARCH_ATAB_DOCTORS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FILL_DGV(DataGridView1, "SELECT * FROM OUT_MASROUF WHERE OUT_STAT = 'TRUE'AND OUT_TYPE <> 'مصروفات' ORDER BY ID DESC")
        SELECTORDER.SelectedIndex = 0
        TextBox1.Select()
    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(4).Value = "عرض"
            Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(4, DataGridView1.CurrentRow.Index).Selected = True Then
            ATAB_DOCTORS.SHOW_DETA(DataGridView1.CurrentRow.Cells(0).Value)
            Me.Close()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If SELECTORDER.SelectedIndex = 0 Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter("SELECT * FROM OUT_MASROUF WHERE OUT_STAT = 'TRUE'AND OUT_TYPE <> 'مصروفات' AND OUT_CODE LIKE '%" & TextBox1.Text & "%'", SqlConn)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
        If SELECTORDER.SelectedIndex = 1 Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter("SELECT * FROM OUT_MASROUF WHERE OUT_STAT = 'TRUE'AND OUT_TYPE <> 'مصروفات' AND OUT_TYPE LIKE '%" & TextBox1.Text & "%'", SqlConn)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
    End Sub
End Class