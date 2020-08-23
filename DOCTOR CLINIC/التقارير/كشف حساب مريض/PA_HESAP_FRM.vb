Public Class PA_HESAP_FRM
    Private Sub PA_HESAP_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PATIENTDATA.PATIENT' table. You can move, or remove it, as needed.
        Me.PATIENTTableAdapter.Fill(Me.PATIENTDATA.PATIENT)
        START_DATE.Value = Date.Today
        END_DATE.Value = Date.Today
        TXT_CODE.Text = ""
        TXT_NAME.Text = ""
    End Sub

    Private Sub BTN_PRENT_Click(sender As Object, e As EventArgs) Handles BTN_PRENT.Click
        If CH_PA.Checked = True Then

            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT_RASED_VIWE WHERE ADD_DATE > ='" & START_DATE.Text & "' AND ADD_DATE < ='" & END_DATE.Text & "'", SqlConn)
            DA.Fill(DT)

            Dim REP As New RASED_PATION_CRS
            REP.SetDataSource(DT)

            REP.SetParameterValue(0, START_DATE.Text)
            REP.SetParameterValue(1, END_DATE.Text)


            Dim FRM As New REPFORALL
            FRM.CrystalReportViewer1.ReportSource = REP
            FRM.ShowDialog()

        Else

            If TXT_CODE.Text = "" Then
                MessageBox.Show("يرجى ادخال اسم المريض", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TXT_NAME.Select()
                Exit Sub
            End If
            '========================================================================
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT_RASED_VIWE WHERE PA_CODE = '" & TXT_CODE.Text & "' and ADD_DATE > ='" & START_DATE.Text & "' AND ADD_DATE < ='" & END_DATE.Text & "'", SqlConn)
            DA.Fill(DT)

            Dim REP As New RASED_PATION_CRS
            REP.SetDataSource(DT)
            REP.SetParameterValue(0, START_DATE.Text)
            REP.SetParameterValue(1, END_DATE.Text)


            Dim FRM As New REPFORALL
            FRM.CrystalReportViewer1.ReportSource = REP
            FRM.ShowDialog()
        End If

    End Sub

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Me.Dispose()
    End Sub
    Private Sub TXT_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME ='" & TXT_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_CODE.Text = DT.Rows(I).Item("PA_CODE")
        Next
    End Sub

    Private Sub CH_PA_CheckedChanged(sender As Object, e As EventArgs) Handles CH_PA.CheckedChanged
        If CH_PA.Checked = False Then
            TXT_NAME.Enabled = True
        Else
            TXT_NAME.Enabled = False
            TXT_NAME.Text = ""
            TXT_CODE.Text = ""
        End If
    End Sub
End Class