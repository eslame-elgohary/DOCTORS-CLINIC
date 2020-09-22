Public Class MASROUF_REP
    Private Sub MASROUF_REP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_END_DATE.Text = Date.Today
        TXT_START_DATE.Text = Date.Today
        TXT_MASROUFL_NAME.Text = ""
        TXT_MASROUFL_CODE.Text = ""
        FILL_MASROUF()
    End Sub

    Sub FILL_MASROUF()
        TXT_MASROUFL_NAME.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM MASROUF WHERE STAT = 'TRUE'", SqlConn)
        DA.Fill(DT)
        For IA = 0 To DT.Rows.Count - 1
            TXT_MASROUFL_NAME.Items.Add(DT.Rows(IA).Item("MASROF_NAME"))
        Next
    End Sub

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Me.Dispose()
    End Sub

    Private Sub CH_MASROUF_CheckedChanged(sender As Object, e As EventArgs) Handles CH_MASROUF.CheckedChanged
        If CH_MASROUF.Checked = False Then
            TXT_MASROUFL_NAME.Enabled = False
            TXT_MASROUFL_NAME.Text = ""
            TXT_MASROUFL_CODE.Text = ""
        Else
            TXT_MASROUFL_NAME.Enabled = True
        End If
    End Sub

    Private Sub BTN_VIWE_Click(sender As Object, e As EventArgs) Handles BTN_VIWE.Click

        If CH_MASROUF.Checked = True And TXT_MASROUFL_CODE.Text = "" Then
            MessageBox.Show("يرجى ادخال المصروف", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_MASROUFL_NAME.Select()
            Exit Sub
        End If
        If TXT_MASROUFL_CODE.Text = "" Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM MASROUF_DT_V WHERE OUT_DATE >='" & TXT_START_DATE.Text & "' AND OUT_DATE <='" & TXT_END_DATE.Text & "' AND OUT_STAT='TRUE' AND OUT_TYPE='مصروفات' ", SqlConn)
            DA.Fill(DT)
            Dim REP As New MASROUF_REP_CRS
            REP.SetDataSource(DT)
            REP.SetParameterValue(0, TXT_START_DATE.Text)
            REP.SetParameterValue(1, TXT_END_DATE.Text)

            Dim FRM As New REPFORALL
            FRM.CrystalReportViewer1.ReportSource = REP
            FRM.ShowDialog()
        Else
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM MASROUF_DT_V WHERE CODE_ACTION ='" & TXT_MASROUFL_CODE.Text & "' AND OUT_DATE >='" & TXT_START_DATE.Text & "' AND OUT_DATE <='" & TXT_END_DATE.Text & "' AND OUT_STAT='TRUE' AND OUT_TYPE='مصروفات' ", SqlConn)
            DA.Fill(DT)
            Dim REP As New MASROUF_REP_CRS
            REP.SetDataSource(DT)
            REP.SetParameterValue(0, TXT_START_DATE.Text)
            REP.SetParameterValue(1, TXT_END_DATE.Text)

            Dim FRM As New REPFORALL
            FRM.CrystalReportViewer1.ReportSource = REP
            FRM.ShowDialog()
        End If

    End Sub

    Private Sub TXT_MASROUFL_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_MASROUFL_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM MASROUF WHERE STAT = 'TRUE' AND MASROF_NAME ='" & TXT_MASROUFL_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For IA = 0 To DT.Rows.Count - 1
            TXT_MASROUFL_CODE.Text = DT.Rows(IA).Item("MASROF_CODE")
        Next
    End Sub
End Class