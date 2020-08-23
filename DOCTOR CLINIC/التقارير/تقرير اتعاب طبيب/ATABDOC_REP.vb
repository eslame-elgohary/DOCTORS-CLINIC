Public Class ATABDOC_REP
    Private Sub ATABDOC_REP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_END_DATE.Text = Date.Today
        TXT_START_DATE.Text = Date.Today
        TXT_MASROUFL_NAME.Text = ""
        FILL_MASROUF()
    End Sub

    Sub FILL_MASROUF()
        TXT_MASROUFL_NAME.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORS WHERE STAT = 'TRUE'", SqlConn)
        DA.Fill(DT)
        For IA = 0 To DT.Rows.Count - 1
            TXT_MASROUFL_NAME.Items.Add(DT.Rows(IA).Item("DO_NAME"))
        Next
    End Sub

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Me.Dispose()
    End Sub

    Private Sub CH_MASROUF_CheckedChanged(sender As Object, e As EventArgs) Handles CH_MASROUF.CheckedChanged
        If CH_MASROUF.Checked = False Then
            TXT_MASROUFL_NAME.Enabled = False
            TXT_MASROUFL_NAME.Text = ""

        Else
            TXT_MASROUFL_NAME.Enabled = True
        End If
    End Sub

    Private Sub BTN_VIWE_Click(sender As Object, e As EventArgs) Handles BTN_VIWE.Click

        If CH_MASROUF.Checked = True And TXT_MASROUFL_NAME.Text = "" Then
            MessageBox.Show("يرجى ادخال المصروف", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_MASROUFL_NAME.Select()
            Exit Sub
        End If
        If TXT_MASROUFL_NAME.Text = "" Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM MASROUF_DT2_V WHERE OUT_DATE >='" & TXT_START_DATE.Text & "' AND OUT_DATE <='" & TXT_END_DATE.Text & "' AND OUT_STAT='TRUE' ", SqlConn)
            DA.Fill(DT)
            Dim REP As New ATABDOC_REP_CRS
            REP.SetDataSource(DT)
            REP.SetParameterValue(0, TXT_START_DATE.Text)
            REP.SetParameterValue(1, TXT_END_DATE.Text)

            Dim FRM As New REPFORALL
            FRM.CrystalReportViewer1.ReportSource = REP
            FRM.ShowDialog()
        Else
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM MASROUF_DT2_V WHERE OUT_TYPE ='" & TXT_MASROUFL_NAME.Text & "' AND OUT_DATE >='" & TXT_START_DATE.Text & "' AND OUT_DATE <='" & TXT_END_DATE.Text & "' AND OUT_STAT='TRUE' ", SqlConn)
            DA.Fill(DT)
            Dim REP As New ATABDOC_REP_CRS2
            REP.SetDataSource(DT)
            REP.SetParameterValue(0, TXT_START_DATE.Text)
            REP.SetParameterValue(1, TXT_END_DATE.Text)

            Dim FRM As New REPFORALL
            FRM.CrystalReportViewer1.ReportSource = REP
            FRM.ShowDialog()
        End If

    End Sub
End Class