Public Class ST1_FRM
    Sub SHOW_DETA(CODE_)
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM ST1_TEST WHERE CODE_ST1 = '" & CODE_ & "'  ", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("THE TEST 1ST IS NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!CODE_ST1
            st1_hb.Text = DR!HB_ST1
            st1_plt.Text = DR!PLT_ST1
            st1_pc.Text = DR!PC_ST1
            st1_hbac.Text = DR!HBA1C_ST1
            st1_tsh.Text = DR!TSH_ST1
            st1_toxo.Text = DR!TOXO_ST1
            st1_cmv.Text = DR!CMV_ST1
            st1_rbs.Text = DR!RBS_ST1
            st1_urine.Text = DR!URINE_ST1


            BTN_EDIT.Enabled = True
            BTN_DELET.Enabled = True
            BTN_SAVE.Enabled = False
        End If
    End Sub
    Private Sub ST1_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        TXT_CODE.Text = CODE_GENE("ST1_TEST", "ID") + 1
        TXT_PA_CODE.Text = FOLLOWUPFRM.TXT_PA_CODE.Text
        '===================================================================
        st1_hb.Text = ""
        st1_plt.Text = ""
        st1_pc.Text = ""
        st1_hbac.Text = ""
        st1_tsh.Text = ""
        st1_toxo.Text = ""
        st1_cmv.Text = ""
        st1_rbs.Text = ""
        st1_urine.Text = ""
        '========================================================================

        BTN_EDIT.Enabled = False
        BTN_DELET.Enabled = False
        BTN_SAVE.Enabled = True
        FILL_DGV(DataGridView1, "SELECT * FROM ST1_TEST WHERE STAT_ST1 ='TRUE' AND CODE_PA_ST1 ='" & TXT_PA_CODE.Text & "'")
        If DataGridView1.Rows.Count > 0 Then
            DataGridView1_Click(sender, e)
        End If
    End Sub

    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        'If st1_hb.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER HB% INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    st1_hb.Select()
        '    Exit Sub
        'End If
        'If st1_plt.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER PLT INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    st1_plt.Select()
        '    Exit Sub
        'End If
        'If st1_pc.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER PC INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    st1_pc.Select()
        '    Exit Sub
        'End If
        'If st1_hbac.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER Hbac1 INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    st1_hbac.Select()
        '    Exit Sub
        'End If
        'If st1_tsh.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER TsH INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    st1_tsh.Select()
        '    Exit Sub
        'End If
        'If st1_toxo.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER TOXO.IgM INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    st1_toxo.Select()
        '    Exit Sub
        'End If
        'If st1_cmv.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER CMV.IgM INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    st1_cmv.Select()
        '    Exit Sub
        'End If
        'If st1_rbs.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER RBS INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    st1_rbs.Select()
        '    Exit Sub
        'End If
        'If st1_urine.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER URINE INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    st1_urine.Select()
        '    Exit Sub
        'End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ST1_TEST ", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.NewRow
        DR!CODE_ST1 = TXT_CODE.Text
        DR!CODE_PA_ST1 = TXT_PA_CODE.Text
        DR!HB_ST1 = st1_hb.Text
        DR!PLT_ST1 = st1_plt.Text
        DR!PC_ST1 = st1_pc.Text
        DR!HBA1C_ST1 = st1_hbac.Text
        DR!TSH_ST1 = st1_tsh.Text
        DR!TOXO_ST1 = st1_toxo.Text
        DR!CMV_ST1 = st1_cmv.Text
        DR!RBS_ST1 = st1_rbs.Text
        DR!URINE_ST1 = st1_urine.Text
        DR!STAT_ST1 = True
        DT.Rows.Add(DR)
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("THE 1st trimester INFORMATION IS SAVED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ' BTN_NEW_Click(sender, e)
        '===================================================================
        st1_hb.Text = ""
        st1_plt.Text = ""
        st1_pc.Text = ""
        st1_hbac.Text = ""
        st1_tsh.Text = ""
        st1_toxo.Text = ""
        st1_cmv.Text = ""
        st1_rbs.Text = ""
        st1_urine.Text = ""
        '========================================================================
        Me.Close()

    End Sub

    Private Sub BTN_EDIT_Click(sender As Object, e As EventArgs) Handles BTN_EDIT.Click
        'If st1_hb.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER HB% INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    st1_hb.Select()
        '    Exit Sub
        'End If
        'If st1_plt.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER PLT INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    st1_plt.Select()
        '    Exit Sub
        'End If
        'If st1_pc.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER PC INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    st1_pc.Select()
        '    Exit Sub
        'End If
        'If st1_hbac.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER Hbac1 INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    st1_hbac.Select()
        '    Exit Sub
        'End If
        'If st1_tsh.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER TsH INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    st1_tsh.Select()
        '    Exit Sub
        'End If
        'If st1_toxo.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER TOXO.IgM INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    st1_toxo.Select()
        '    Exit Sub
        'End If
        'If st1_cmv.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER CMV.IgM INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    st1_cmv.Select()
        '    Exit Sub
        'End If
        'If st1_rbs.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER RBS INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    st1_rbs.Select()
        '    Exit Sub
        'End If
        'If st1_urine.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER URINE INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    st1_urine.Select()
        '    Exit Sub
        'End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ST1_TEST WHERE CODE_ST1='" & TXT_CODE.Text & "' ", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.Rows(0)
        DR!CODE_ST1 = TXT_CODE.Text
        DR!CODE_PA_ST1 = TXT_PA_CODE.Text
        DR!HB_ST1 = st1_hb.Text
        DR!PLT_ST1 = st1_plt.Text
        DR!PC_ST1 = st1_pc.Text
        DR!HBA1C_ST1 = st1_hbac.Text
        DR!TSH_ST1 = st1_tsh.Text
        DR!TOXO_ST1 = st1_toxo.Text
        DR!CMV_ST1 = st1_cmv.Text
        DR!RBS_ST1 = st1_rbs.Text
        DR!URINE_ST1 = st1_urine.Text
        DR!STAT_ST1 = True
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("THE 1st trimester INFORMATION IS EDIT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ' BTN_NEW_Click(sender, e)
        '===================================================================
        st1_hb.Text = ""
        st1_plt.Text = ""
        st1_pc.Text = ""
        st1_hbac.Text = ""
        st1_tsh.Text = ""
        st1_toxo.Text = ""
        st1_cmv.Text = ""
        st1_rbs.Text = ""
        st1_urine.Text = ""
        '========================================================================
        Me.Close()

    End Sub

    Private Sub BTN_DELET_Click(sender As Object, e As EventArgs) Handles BTN_DELET.Click
        If MessageBox.Show("DO YOU WANT DELET IT ?", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ST1_TEST WHERE CODE_ST1='" & TXT_CODE.Text & "' ", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.Rows(0)

        DR!STAT_ST1 = False

        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("THE 1st trimester INFORMATION IS DELET", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ' BTN_NEW_Click(sender, e)
        '===================================================================
        st1_hb.Text = ""
        st1_plt.Text = ""
        st1_pc.Text = ""
        st1_hbac.Text = ""
        st1_tsh.Text = ""
        st1_toxo.Text = ""
        st1_cmv.Text = ""
        st1_rbs.Text = ""
        st1_urine.Text = ""
        '========================================================================
        Me.Close()
    End Sub

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Me.Close()
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(1, DataGridView1.CurrentRow.Index).Selected = True Then
            SHOW_DETA(DataGridView1.CurrentRow.Cells(0).Value)
        End If
    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(1).Value = "عرض"
            Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub

    Private Sub TXT_PA_CODE_TextChanged(sender As Object, e As EventArgs) Handles TXT_PA_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_CODE ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA_NAME.Text = DT.Rows(I).Item("PA_NAME")
        Next
    End Sub
End Class