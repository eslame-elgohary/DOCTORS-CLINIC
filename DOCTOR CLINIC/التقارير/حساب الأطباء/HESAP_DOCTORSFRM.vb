Public Class HESAP_DOCTORSFRM

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Me.Close()
    End Sub

    Private Sub HESAP_DOCTORSFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_START_DATE.Text = Date.Today
        TXT_END_DATE.Text = Date.Today
        TXT_DOC_CODE.Text = ""
        TXT_DOC_NAME.Text = ""
        FILL_DOCTORS()
    End Sub
    Sub FILL_DOCTORS()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORS WHERE STAT = 'TRUE'", SqlConn)
        DA.Fill(DT)
        For IA = 0 To DT.Rows.Count - 1
            TXT_DOC_NAME.Items.Add(DT.Rows(IA).Item("DO_NAME"))
        Next

    End Sub
    Private Sub TXT_MAML_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_DOC_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORS WHERE DO_NAME='" & TXT_DOC_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_DOC_CODE.Text = DT.Rows(I).Item("DO_CODE")
        Next
    End Sub

    Private Sub BTN_VIWE_Click(sender As Object, e As EventArgs) Handles BTN_VIWE.Click
        If TXT_DOC_CODE.Text = "" Then
            MessageBox.Show("يرجى ادخال اسم الطبيب", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_DOC_NAME.Select()
            Exit Sub
        End If
        '========================================================================
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PRICE_DOC_V WHERE ADD_DOCTOR_CODE = '" & TXT_DOC_CODE.Text & "' and ADD_DATE > ='" & TXT_START_DATE.Text & "' AND ADD_DATE < ='" & TXT_END_DATE.Text & "'", SqlConn)
        DA.Fill(DT)

        Dim REP As New DOCTOR_HESAP
        REP.SetDataSource(DT)
        REP.SetParameterValue(0, TXT_DOC_NAME.Text)
        REP.SetParameterValue(1, TXT_START_DATE.Text)
        REP.SetParameterValue(2, TXT_END_DATE.Text)


        Dim FRM As New REPFORALL
        FRM.CrystalReportViewer1.ReportSource = REP
        FRM.ShowDialog()

    End Sub
End Class