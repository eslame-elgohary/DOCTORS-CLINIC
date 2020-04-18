Public Class PATIENT_REP
    Sub FILL_PATIENT()
        PA_NAME.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            PA_NAME.Items.Add(DT.Rows(I).Item("PA_NAME"))
        Next
    End Sub
    Private Sub PRINTBTN_Click(sender As Object, e As EventArgs) Handles PRINTBTN.Click
        Dim DT As New DataTable
        With DT
            .Columns.Add("PA_CODE")
            .Columns.Add("PA_NAME")
            .Columns.Add("PA_TEL")
            .Columns.Add("PA_AGE")
            .Columns.Add("PA_TYPE")
            .Columns.Add("PA_NAME2")
            .Columns.Add("PA_TEL2")
            .Columns.Add("PA_CHI")
            .Columns.Add("PA_OP")
            .Columns.Add("PA_CODE2")
            .Columns.Add("STAT")
        End With
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(I).Cells(0).Value <> Nothing Then
                DT.Rows.Add(DataGridView1.Rows(I).Cells(0).Value, DataGridView1.Rows(I).Cells(1).Value, DataGridView1.Rows(I).Cells(2).Value, DataGridView1.Rows(I).Cells(3).Value, DataGridView1.Rows(I).Cells(4).Value, DataGridView1.Rows(I).Cells(5).Value, DataGridView1.Rows(I).Cells(6).Value, DataGridView1.Rows(I).Cells(7).Value, DataGridView1.Rows(I).Cells(8).Value, DataGridView1.Rows(I).Cells(9).Value, DataGridView1.Rows(I).Cells(10).Value)
            End If
        Next
        Dim REP As New PATIENT_CRS_ALL
        REP.SetDataSource(DT)

        Me.CrystalReportViewer1.ReportSource = REP

    End Sub

    Private Sub PATIENT_REP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FILL_DGV(DataGridView1, "SELECT * FROM PATIENT ORDER BY PA_CODE")
        PA_CHEK.Checked = False
        PA_NAME.Enabled = False
        FILL_PATIENT()
    End Sub

    Private Sub PA_CHEK_CheckedChanged(sender As Object, e As EventArgs) Handles PA_CHEK.CheckedChanged
        If PA_CHEK.Checked = True Then
            PA_NAME.Enabled = True
        Else
            PA_NAME.Enabled = False
            PA_NAME.Text = ""
            FILL_DGV(DataGridView1, "SELECT * FROM PATIENT ORDER BY PA_CODE")

        End If
    End Sub

    Private Sub PA_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PA_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter
        DT.Clear()
        DA = New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME LIKE '%" & PA_NAME.Text & "%'", SqlConn)
        DA.Fill(DT)
        DataGridView1.DataSource = DT.DefaultView
    End Sub
End Class