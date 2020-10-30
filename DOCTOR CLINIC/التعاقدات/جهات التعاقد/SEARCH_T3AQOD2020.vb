Public Class SEARCH_T3AQOD2020
    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Dispose()
    End Sub

    Private Sub SEARCH_T3AQOD2020_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FILL_DGV(DataGridView1, "SELECT * FROM T3AQOD_2020 WHERE T3AQOD_STAT='TRUE'")
        ComboBox1.SelectedIndex = 0
    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(3).Value = "عرض"
            Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(3, DataGridView1.CurrentRow.Index).Selected = True Then
            T3AQOD_FRM2020.SHOW_DETA(DataGridView1.CurrentRow.Cells(0).Value)
            Me.Close()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If ComboBox1.SelectedIndex = 0 Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter("SELECT * FROM T3AQOD_2020 WHERE T3AQOD_STAT='TRUE' AND T3AQOD_CODE LIKE '%" & TextBox1.Text & "%'", SqlConn)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If

        If ComboBox1.SelectedIndex = 1 Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter("SELECT * FROM T3AQOD_2020 WHERE T3AQOD_STAT='TRUE' AND T3AQOD_NAME LIKE '%" & TextBox1.Text & "%'", SqlConn)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If

    End Sub
End Class