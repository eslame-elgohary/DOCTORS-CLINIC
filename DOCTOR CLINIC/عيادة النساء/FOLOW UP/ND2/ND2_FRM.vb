Public Class ND2_FRM
    Sub SHOW_DETA(CODE_)
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM ND2_TEST WHERE CODE_ND2 = '" & CODE_ & "'  ", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("THE TEST 2nd IS NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!CODE_ND2
            ND2_hb.Text = DR!HB_ND2
            ND2_plt.Text = DR!PLT_ND2
            ND2_pc.Text = DR!PC_ND2
            ND2_HOUR.Text = DR!HOUR_ND2
            ND2_TOTAL.Text = DR!TOTAL_ND2
            ND2_LONIZED.Text = DR!LONIZED_ND2
            ND2_TSH.Text = DR!TSH_ND2
            ND2_urine.Text = DR!URINE_ND2

            BTN_EDIT.Enabled = True
            BTN_DELET.Enabled = True
            BTN_SAVE.Enabled = False
        End If
    End Sub
    Private Sub ND2_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        TXT_CODE.Text = CODE_GENE("ND2_TEST", "ID") + 1
        TXT_PA_CODE.Text = FOLOUP.TXT_PA_CODE.Text
        '===================================================================
        ND2_hb.Text = ""
        ND2_plt.Text = ""
        ND2_pc.Text = ""
        ND2_HOUR.Text = ""
        ND2_TOTAL.Text = ""
        ND2_LONIZED.Text = ""
        ND2_TSH.Text = ""
        ND2_urine.Text = ""
        '========================================================================

        BTN_EDIT.Enabled = False
        BTN_DELET.Enabled = False
        BTN_SAVE.Enabled = True
        FILL_DGV(DataGridView1, "SELECT * FROM ND2_TEST WHERE STAT_ND2 ='TRUE' AND CODE_PA_ND2 ='" & TXT_PA_CODE.Text & "'")
    End Sub

    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        If ND2_hb.Text = "" Then
            MessageBox.Show("PLEASE ENTER HB% INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ND2_hb.Select()
            Exit Sub
        End If
        If ND2_plt.Text = "" Then
            MessageBox.Show("PLEASE ENTER PLT INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ND2_plt.Select()
            Exit Sub
        End If
        If ND2_pc.Text = "" Then
            MessageBox.Show("PLEASE ENTER PC INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ND2_pc.Select()
            Exit Sub
        End If
        If ND2_HOUR.Text = "" Then
            MessageBox.Show("PLEASE ENTER Hbac1 INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ND2_HOUR.Select()
            Exit Sub
        End If
        If ND2_TOTAL.Text = "" Then
            MessageBox.Show("PLEASE ENTER TsH INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ND2_TOTAL.Select()
            Exit Sub
        End If
        If ND2_LONIZED.Text = "" Then
            MessageBox.Show("PLEASE ENTER TOXO.IgM INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ND2_LONIZED.Select()
            Exit Sub
        End If
        If ND2_TSH.Text = "" Then
            MessageBox.Show("PLEASE ENTER CMV.IgM INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ND2_TSH.Select()
            Exit Sub
        End If
        If ND2_urine.Text = "" Then
            MessageBox.Show("PLEASE ENTER URINE INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ND2_urine.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ND2_TEST ", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.NewRow
        DR!CODE_ND2 = TXT_CODE.Text
        DR!CODE_PA_ND2 = TXT_PA_CODE.Text
        DR!HB_ND2 = ND2_hb.Text
        DR!PLT_ND2 = ND2_plt.Text
        DR!PC_ND2 = ND2_pc.Text
        DR!HOUR_ND2 = ND2_HOUR.Text
        DR!TOTAL_ND2 = ND2_TOTAL.Text
        DR!LONIZED_ND2 = ND2_LONIZED.Text
        DR!TSH_ND2 = ND2_TSH.Text
        DR!URINE_ND2 = ND2_urine.Text
        DR!STAT_ND2 = True
        DT.Rows.Add(DR)
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("THE 2nd trimester INFORMATION IS SAVED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        BTN_NEW_Click(sender, e)

    End Sub

    Private Sub BTN_EDIT_Click(sender As Object, e As EventArgs) Handles BTN_EDIT.Click
        If ND2_hb.Text = "" Then
            MessageBox.Show("PLEASE ENTER HB% INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ND2_hb.Select()
            Exit Sub
        End If
        If ND2_plt.Text = "" Then
            MessageBox.Show("PLEASE ENTER PLT INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ND2_plt.Select()
            Exit Sub
        End If
        If ND2_pc.Text = "" Then
            MessageBox.Show("PLEASE ENTER PC INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ND2_pc.Select()
            Exit Sub
        End If
        If ND2_HOUR.Text = "" Then
            MessageBox.Show("PLEASE ENTER Hbac1 INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ND2_HOUR.Select()
            Exit Sub
        End If
        If ND2_TOTAL.Text = "" Then
            MessageBox.Show("PLEASE ENTER TsH INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ND2_TOTAL.Select()
            Exit Sub
        End If
        If ND2_LONIZED.Text = "" Then
            MessageBox.Show("PLEASE ENTER TOXO.IgM INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ND2_LONIZED.Select()
            Exit Sub
        End If
        If ND2_TSH.Text = "" Then
            MessageBox.Show("PLEASE ENTER CMV.IgM INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ND2_TSH.Select()
            Exit Sub
        End If
        If ND2_urine.Text = "" Then
            MessageBox.Show("PLEASE ENTER URINE INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ND2_urine.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ND2_TEST WHERE CODE_ND2='" & TXT_CODE.Text & "' ", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.Rows(0)
        DR!CODE_ND2 = TXT_CODE.Text
        DR!CODE_PA_ND2 = TXT_PA_CODE.Text
        DR!HB_ND2 = ND2_hb.Text
        DR!PLT_ND2 = ND2_plt.Text
        DR!PC_ND2 = ND2_pc.Text
        DR!HOUR_ND2 = ND2_HOUR.Text
        DR!TOTAL_ND2 = ND2_TOTAL.Text
        DR!LONIZED_ND2 = ND2_LONIZED.Text
        DR!TSH_ND2 = ND2_TSH.Text
        DR!URINE_ND2 = ND2_urine.Text
        DR!STAT_ND2 = True
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("THE 2nd trimester INFORMATION IS EDIT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        BTN_NEW_Click(sender, e)

    End Sub

    Private Sub BTN_DELET_Click(sender As Object, e As EventArgs) Handles BTN_DELET.Click
        If MessageBox.Show("DO YOU WANT DELET IT ?", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ND2_TEST WHERE CODE_ND2='" & TXT_CODE.Text & "' ", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.Rows(0)

        DR!STAT_ND2 = False

        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("THE 2nd trimester INFORMATION IS DELET", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
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