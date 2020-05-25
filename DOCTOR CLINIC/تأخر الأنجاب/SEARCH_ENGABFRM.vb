Public Class SEARCH_ENGABFRM
    Private Sub SEARCH_ENGABFRM_Load(sender As Object, e As EventArgs) Handles Me.Load
        FILL_DGV(DataGridView1, "SELECT * FROM INFERTILITY_FOLLOWUP WHERE STAT_INFERTILITY = 'TRUE' AND CODE_PA_PERSONAL_INFERTILITY='" & ENGABFRM.TXT_PA_CODE.Text & "' ORDER BY ID DESC")
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(4).Value = "View"
            Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(4, DataGridView1.CurrentRow.Index).Selected = True Then
            ENGABFRM.SHOW_DETA(DataGridView1.CurrentRow.Cells(0).Value)
            Me.Close()
        End If
    End Sub
End Class