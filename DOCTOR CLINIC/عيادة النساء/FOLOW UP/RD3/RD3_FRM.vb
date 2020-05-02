Public Class RD3_FRM
    Sub SHOW_DETA(CODE_)
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM RD3_TEST WHERE CODE_RD3 = '" & CODE_ & "'  ", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("THE TEST 3RD IS NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!CODE_RD3
            RD3_hb.Text = DR!HB_RD3
            RD3_plt.Text = DR!PLT_RD3
            RD3_pc.Text = DR!PC_RD3
            RD3_SGPT.Text = DR!SGPT_RD3
            RD3_CREAT.Text = DR!CREAT_RD3
            RD3_HOUR.Text = DR!HOUR_RD3
            RD3_TSH.Text = DR!TSH_RD3
            RD3_rbs.Text = DR!RBS_RD3
            RD3_urine.Text = DR!URINE_RD3


            BTN_EDIT.Enabled = True
            BTN_DELET.Enabled = True
            BTN_SAVE.Enabled = False
        End If
    End Sub
    Private Sub RD3_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        TXT_CODE.Text = CODE_GENE("RD3_TEST", "ID") + 1
        TXT_PA_CODE.Text = FOLOUP.TXT_PA_CODE.Text
        '===================================================================
        RD3_hb.Text = ""
        RD3_plt.Text = ""
        RD3_pc.Text = ""
        RD3_SGPT.Text = ""
        RD3_CREAT.Text = ""
        RD3_HOUR.Text = ""
        RD3_TSH.Text = ""
        RD3_rbs.Text = ""
        RD3_urine.Text = ""
        '========================================================================

        BTN_EDIT.Enabled = False
        BTN_DELET.Enabled = False
        BTN_SAVE.Enabled = True
        FILL_DGV(DataGridView1, "SELECT * FROM RD3_TEST WHERE STAT_RD3 ='TRUE' AND CODE_PA_RD3 ='" & TXT_PA_CODE.Text & "'")
    End Sub

    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        'If RD3_hb.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER HB% INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    RD3_hb.Select()
        '    Exit Sub
        'End If
        'If RD3_plt.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER PLT INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    RD3_plt.Select()
        '    Exit Sub
        'End If
        'If RD3_pc.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER PC INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    RD3_pc.Select()
        '    Exit Sub
        'End If
        'If RD3_SGPT.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER Hbac1 INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    RD3_SGPT.Select()
        '    Exit Sub
        'End If
        'If RD3_CREAT.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER TsH INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    RD3_CREAT.Select()
        '    Exit Sub
        'End If
        'If RD3_HOUR.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER TOXO.IgM INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    RD3_HOUR.Select()
        '    Exit Sub
        'End If
        'If RD3_TSH.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER CMV.IgM INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    RD3_TSH.Select()
        '    Exit Sub
        'End If
        'If RD3_rbs.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER RBS INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    RD3_rbs.Select()
        '    Exit Sub
        'End If
        'If RD3_urine.Text = "" Then
        '    MessageBox.Show("PLEASE ENTER URINE INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    RD3_urine.Select()
        '    Exit Sub
        'End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM RD3_TEST ", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.NewRow
        DR!CODE_RD3 = TXT_CODE.Text
        DR!CODE_PA_RD3 = TXT_PA_CODE.Text
        DR!HB_RD3 = RD3_hb.Text
        DR!PLT_RD3 = RD3_plt.Text
        DR!PC_RD3 = RD3_pc.Text
        DR!SGPT_RD3 = RD3_SGPT.Text
        DR!CREAT_RD3 = RD3_CREAT.Text
        DR!HOUR_RD3 = RD3_HOUR.Text
        DR!TSH_RD3 = RD3_TSH.Text
        DR!RBS_RD3 = RD3_rbs.Text
        DR!URINE_RD3 = RD3_urine.Text
        DR!STAT_RD3 = True
        DT.Rows.Add(DR)
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("THE 3RD trimester INFORMATION IS SAVED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        BTN_NEW_Click(sender, e)

    End Sub

    Private Sub BTN_EDIT_Click(sender As Object, e As EventArgs) Handles BTN_EDIT.Click
        If RD3_hb.Text = "" Then
            MessageBox.Show("PLEASE ENTER HB% INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RD3_hb.Select()
            Exit Sub
        End If
        If RD3_plt.Text = "" Then
            MessageBox.Show("PLEASE ENTER PLT INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RD3_plt.Select()
            Exit Sub
        End If
        If RD3_pc.Text = "" Then
            MessageBox.Show("PLEASE ENTER PC INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RD3_pc.Select()
            Exit Sub
        End If
        If RD3_SGPT.Text = "" Then
            MessageBox.Show("PLEASE ENTER Hbac1 INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RD3_SGPT.Select()
            Exit Sub
        End If
        If RD3_CREAT.Text = "" Then
            MessageBox.Show("PLEASE ENTER TsH INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RD3_CREAT.Select()
            Exit Sub
        End If
        If RD3_HOUR.Text = "" Then
            MessageBox.Show("PLEASE ENTER TOXO.IgM INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RD3_HOUR.Select()
            Exit Sub
        End If
        If RD3_TSH.Text = "" Then
            MessageBox.Show("PLEASE ENTER CMV.IgM INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RD3_TSH.Select()
            Exit Sub
        End If
        If RD3_rbs.Text = "" Then
            MessageBox.Show("PLEASE ENTER RBS INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RD3_rbs.Select()
            Exit Sub
        End If
        If RD3_urine.Text = "" Then
            MessageBox.Show("PLEASE ENTER URINE INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RD3_urine.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM RD3_TEST WHERE CODE_RD3='" & TXT_CODE.Text & "' ", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.Rows(0)
        DR!CODE_RD3 = TXT_CODE.Text
        DR!CODE_PA_RD3 = TXT_PA_CODE.Text
        DR!HB_RD3 = RD3_hb.Text
        DR!PLT_RD3 = RD3_plt.Text
        DR!PC_RD3 = RD3_pc.Text
        DR!SGPT_RD3 = RD3_SGPT.Text
        DR!CREAT_RD3 = RD3_CREAT.Text
        DR!HOUR_RD3 = RD3_HOUR.Text
        DR!TSH_RD3 = RD3_TSH.Text
        DR!RBS_RD3 = RD3_rbs.Text
        DR!URINE_RD3 = RD3_urine.Text
        DR!STAT_RD3 = True
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("THE 3RD trimester INFORMATION IS EDIT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        BTN_NEW_Click(sender, e)

    End Sub

    Private Sub BTN_DELET_Click(sender As Object, e As EventArgs) Handles BTN_DELET.Click
        If MessageBox.Show("DO YOU WANT DELET IT ?", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM RD3_TEST WHERE CODE_RD3='" & TXT_CODE.Text & "' ", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.Rows(0)

        DR!STAT_RD3 = False

        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("THE 3RD trimester INFORMATION IS DELET", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        BTN_NEW_Click(sender, e)
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