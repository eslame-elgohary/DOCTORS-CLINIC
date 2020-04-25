Public Class SEARCH_FOLOWUP_FRM
    Private Sub SEARCH_FOLOWUP_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        K1.SelectedIndex = 0
        FILL_DGV(DataGridView1, "SELECT * FROM FOLOWUP_VIEWS_2 WHERE STAT_FOLOWUP ='TRUE' ORDER BY ID DESC")
    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(3).Value = "عرض"
            Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(3, DataGridView1.CurrentRow.Index).Selected = True Then
            FOLOUP.SHOW_DETA(DataGridView1.CurrentRow.Cells(0).Value)
            Me.Close()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If K1.SelectedIndex = 1 Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter("SELECT * FROM FOLOWUP_VIEWS_2 WHERE STAT_FOLOWUP ='TRUE' AND CODE_FOLOWUP LIKE '%" & TextBox1.Text & "%' ORDER BY ID DESC", SqlConn)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
        If K1.SelectedIndex = 0 Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter("SELECT * FROM FOLOWUP_VIEWS_2 WHERE STAT_FOLOWUP ='TRUE' AND PA_NAME LIKE '%" & TextBox1.Text & "%' ORDER BY ID DESC", SqlConn)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
    End Sub
End Class