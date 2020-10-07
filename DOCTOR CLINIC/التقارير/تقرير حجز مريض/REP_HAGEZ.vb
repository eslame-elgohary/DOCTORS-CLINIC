Public Class REP_HAGEZ
    Private Sub REP_HAGEZ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PATIENTDATA.Clear()
        PATIENTTableAdapter.Fill(PATIENTDATA.PATIENT)
        TXT_START_DATE.Text = Date.Today
        TXT_END_DATE.Text = Date.Today
        TXT_PA_CODE.Text = ""
        TXT_PA_NAME.Text = ""
    End Sub
    Private Sub TXT_PA_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_PA_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME='" & TXT_PA_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA_CODE.Text = DT.Rows(I).Item("PA_CODE")
        Next
    End Sub
    Private Sub BTN_VIWE_Click(sender As Object, e As EventArgs) Handles BTN_VIWE.Click

        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("يرجى ادخال اسم المريض", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        End If
        '=================================================================
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT  * FROM  HAGEZ_V WHERE CODE_PA_H_A ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA.Fill(DT)

        Dim REP As New HAGEZ_REP_CRS
        REP.SetDataSource(DT)
        REP.SetParameterValue(0, TXT_PA_CODE.Text)

        Dim FRM As New REPFORALL
        FRM.CrystalReportViewer1.ReportSource = REP
        FRM.ShowDialog()

    End Sub

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Me.Dispose()
    End Sub
End Class