﻿Public Class REP_HAGEZ
    Private Sub REP_HAGEZ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_START_DATE.Text = Date.Today
        TXT_END_DATE.Text = Date.Today
        TXT_PA_CODE.Text = ""
        TXT_PA_NAME.Text = ""
        CH_PA.Checked = False
        FILL_PATION()
    End Sub
    Sub FILL_PATION()
        TXT_PA_NAME.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE STAT = 'TRUE' ", SqlConn)
        DA.Fill(DT)
        For IA = 0 To DT.Rows.Count - 1
            TXT_PA_NAME.Items.Add(DT.Rows(IA).Item("PA_NAME"))
        Next
    End Sub
    Private Sub TXT_PA_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_PA_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME='" & TXT_PA_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA_CODE.Text = DT.Rows(I).Item("PA_CODE")
        Next
    End Sub
    Private Sub CH_PA_CheckedChanged(sender As Object, e As EventArgs) Handles CH_PA.CheckedChanged
        If CH_PA.Checked = True Then
            TXT_PA_NAME.Enabled = True
            TXT_PA_NAME.Text = ""
            TXT_PA_CODE.Text = ""
        Else
            TXT_PA_NAME.Enabled = False
            TXT_PA_NAME.Text = ""
            TXT_PA_CODE.Text = ""

        End If
    End Sub
    Private Sub BTN_VIWE_Click(sender As Object, e As EventArgs) Handles BTN_VIWE.Click

        If CH_PA.Checked = True And TXT_PA_CODE.Text = "" Then
            MessageBox.Show("يرجى ادخال اسم المريض", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        End If
        '=================================================================
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ_V WHERE DATE_H_A >='" & TXT_START_DATE.Text & "' AND DATE_H_A <='" & TXT_END_DATE.Text & "'", SqlConn)
        DA.Fill(DT)

        Dim REP As New HAGEZ_REP_CRS
        REP.SetDataSource(DT)
        REP.SetParameterValue(0, TXT_START_DATE.Text)
        REP.SetParameterValue(1, TXT_END_DATE.Text)
        REP.SetParameterValue(2, TXT_PA_CODE.Text)

        Dim FRM As New REPFORALL
        FRM.CrystalReportViewer1.ReportSource = REP
        FRM.ShowDialog()

    End Sub

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Me.Close()
    End Sub
End Class