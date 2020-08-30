Public Class SEARCHPRICETHLELFRM
    Private Sub SEARCHPRICETHLELFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FILL_DGV(DataGridView1, "SELECT * FROM ADD_THLEL_PATION_V WHERE STAT = 'TRUE' ORDER BY ID")
        SELECTORDER.SelectedIndex = 0
        TextBox1.Select()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If SELECTORDER.SelectedIndex = 0 Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter("SELECT * FROM ADD_THLEL_PATION_V WHERE PA_NAME LIKE '%" & TextBox1.Text & "%'", SqlConn)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
        If SELECTORDER.SelectedIndex = 1 Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter("SELECT * FROM ADD_THLEL_PATION_V WHERE ADD_DATE LIKE '%" & TextBox1.Text & "%'", SqlConn)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
        If SELECTORDER.SelectedIndex = 2 Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter("SELECT * FROM ADD_THLEL_PATION_V WHERE ADD_CODE LIKE '%" & TextBox1.Text & "%'", SqlConn)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(3).Value = "عرض"
            Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(3, DataGridView1.CurrentRow.Index).Selected = True Then
            ADDTHLELMAMLPAFRM.SHOW_DETA(DataGridView1.CurrentRow.Cells(0).Value)
            Me.Close()
        End If
    End Sub

End Class