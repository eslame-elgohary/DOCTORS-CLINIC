Public Class LABTOLAB_V

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Me.Dispose()
    End Sub

    Private Sub LABTOLAB_V_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PATIENTDATA.PATIENT' table. You can move, or remove it, as needed.
        Me.PATIENTTableAdapter.Fill(Me.PATIENTDATA.PATIENT)
        TXT_START_DATE.Text = Date.Today
        TXT_END_DATE.Text = Date.Today
        TXT_MAML_CODE.Text = ""
        TXT_MAML_NAME.Text = ""
        TXT_PA_CODE.Text = ""
        TXT_PA_NAME.Text = ""
        CH_MAML.Checked = False
        CH_PA.Checked = False
        FILL_MAML()
        ' FILL_PATION()
    End Sub
    Sub FILL_MAML()
        TXT_MAML_NAME.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM MAML WHERE STAT = 'TRUE'", SqlConn)
        DA.Fill(DT)
        For IA = 0 To DT.Rows.Count - 1
            TXT_MAML_NAME.Items.Add(DT.Rows(IA).Item("MAML_NAME"))
        Next

    End Sub
    'Sub FILL_PATION()
    '    TXT_PA_NAME.Items.Clear()
    '    Dim DT As New DataTable
    '    Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE STAT = 'TRUE' ", SqlConn)
    '    DA.Fill(DT)
    '    For IA = 0 To DT.Rows.Count - 1
    '        TXT_PA_NAME.Items.Add(DT.Rows(IA).Item("PA_NAME"))
    '    Next
    'End Sub

    Private Sub TXT_MAML_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_MAML_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM MAML WHERE MAML_NAME='" & TXT_MAML_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_MAML_CODE.Text = DT.Rows(I).Item("MAML_CODE")
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

    Private Sub CH_MAML_CheckedChanged(sender As Object, e As EventArgs) Handles CH_MAML.CheckedChanged
        If CH_MAML.Checked = True Then
            TXT_MAML_NAME.Enabled = True
            TXT_MAML_NAME.Text = ""
            TXT_MAML_CODE.Text = ""
        Else
            TXT_MAML_NAME.Enabled = False
            TXT_MAML_NAME.Text = ""
            TXT_MAML_CODE.Text = ""
        End If
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
        If CH_MAML.Checked = True And TXT_MAML_CODE.Text = "" Then
            MessageBox.Show("يرجى ادخال اسم المعمل", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_MAML_NAME.Select()
            Exit Sub
        End If
        '========================================================================
        If CH_PA.Checked = True And TXT_PA_CODE.Text = "" Then
            MessageBox.Show("يرجى ادخال اسم المريض", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        End If
        '=================================================================
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM THLEL_MAML_LABTOLAB_V WHERE ADD_STAT='TRUE'  AND ADD_DATE >='" & TXT_START_DATE.Text & "' AND ADD_DATE <='" & TXT_END_DATE.Text & "'", SqlConn)
        DA.Fill(DT)

        Dim REP As New LABTOLABCRS
        REP.SetDataSource(DT)
        REP.SetParameterValue(0, TXT_START_DATE.Text)
        REP.SetParameterValue(1, TXT_END_DATE.Text)
        REP.SetParameterValue(2, TXT_PA_CODE.Text)
        REP.SetParameterValue(3, TXT_MAML_CODE.Text)

        Dim FRM As New REPFORALL
        FRM.CrystalReportViewer1.ReportSource = REP
        FRM.ShowDialog()

    End Sub
End Class