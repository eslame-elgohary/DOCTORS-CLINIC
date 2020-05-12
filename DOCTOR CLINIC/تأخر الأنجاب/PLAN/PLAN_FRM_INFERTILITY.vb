Public Class PLAN_FRM_INFERTILITY
    Sub SHOW_DETA(CODE_)
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM PLAN_INFERT WHERE CODE_PLAN_INFERT = '" & CODE_ & "'  ", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("THE NAME PLAN IS NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE_PLAN.Text = DR!CODE_PLAN_INFERT
            TXT_PA_CODE.Text = DR!CODE_PA_PLAN_INFERT
            TXT_DATE_PLAN.Text = DR!DATE_PLAN_INFERT
            TXT_NAME_PLAN.Text = DR!NAME_PLAN_INFERT

            BTN_EDIT.Enabled = True
            BTN_DELET.Enabled = True
            BTN_SAVE.Enabled = False
        End If
    End Sub
    Private Sub PLAN_FRM_INFERTILITY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_PA_CODE.Text = ENGABFRM.TXT_PA_CODE.Text
        TXT_PA_NAME.Text = ENGABFRM.TXT_PA_NAME.Text
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        TXT_CODE_PLAN.Text = CODE_GENE("PLAN_INFERT", "ID") + 1
        NEPLAN()
        TXT_DATE_PLAN.Value = Date.Today
        TXT_NAME_PLAN.Text = ""
        TXT_NAME_PLAN.Select()
        FILL_DGV(DataGridView1, "SELECT * FROM PLAN_INFERT WHERE STAT_PLAN_INFERT ='TRUE' AND CODE_PA_PLAN_INFERT='" & TXT_PA_CODE.Text & "'ORDER BY DATE_PLAN_INFERT DESC ")
    End Sub

    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PLAN_INFERT", SqlConn)
        DA.Fill(DT)

        Dim DR = DT.NewRow
        DR!CODE_PLAN_INFERT = TXT_CODE_PLAN.Text
        DR!CODE_PA_PLAN_INFERT = TXT_PA_CODE.Text
        DR!DATE_PLAN_INFERT = TXT_DATE_PLAN.Text
        DR!NAME_PLAN_INFERT = TXT_NAME_PLAN.Text
        DR!STAT_PLAN_INFERT = True
        DT.Rows.Add(DR)
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        '======== auto complit =======
        Dim DTAUTO As New DataTable
        Dim DAAUTO As New SqlClient.SqlDataAdapter("SELECT * FROM AUTOCOMPLET_PLAN WHERE NAME = '" & TXT_NAME_PLAN.Text & "'", SqlConn)
        DAAUTO.Fill(DTAUTO)

        If DTAUTO.Rows.Count = 0 Then
            Dim DRAUTO = DTAUTO.NewRow
            DRAUTO!NAME = TXT_NAME_PLAN.Text
            DTAUTO.Rows.Add(DRAUTO)
            Dim SAVEAUTO As New SqlClient.SqlCommandBuilder(DAAUTO)
            DAAUTO.Update(DTAUTO)

        End If
        '=================================================================
        MessageBox.Show("THE PLAN INFORMATION IS SAVED", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_EDIT_Click(sender As Object, e As EventArgs) Handles BTN_EDIT.Click
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PLAN_INFERT WHERE CODE_PLAN_INFERT ='" & TXT_CODE_PLAN.Text & "'", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("Please enter valid data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim DR = DT.Rows(0)
            DR!CODE_PLAN_INFERT = TXT_CODE_PLAN.Text
            DR!CODE_PA_PLAN_INFERT = TXT_PA_CODE.Text
            DR!DATE_PLAN_INFERT = TXT_DATE_PLAN.Text
            DR!NAME_PLAN_INFERT = TXT_NAME_PLAN.Text
            DR!STAT_PLAN_INFERT = True

            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)

            '======== auto complit =======
            Dim DTAUTO As New DataTable
            Dim DAAUTO As New SqlClient.SqlDataAdapter("SELECT * FROM AUTOCOMPLET_PLAN WHERE NAME = '" & TXT_NAME_PLAN.Text & "'", SqlConn)
            DAAUTO.Fill(DTAUTO)

            If DTAUTO.Rows.Count = 0 Then
                Dim DRAUTO = DTAUTO.NewRow
                DRAUTO!NAME = TXT_NAME_PLAN.Text
                DTAUTO.Rows.Add(DRAUTO)
                Dim SAVEAUTO As New SqlClient.SqlCommandBuilder(DAAUTO)
                DAAUTO.Update(DTAUTO)

            End If
            '=================================================================

            MessageBox.Show("THE PLAN INFORMATION IS EDIT", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BTN_NEW_Click(sender, e)
        End If

    End Sub

    Private Sub BTN_DELET_Click(sender As Object, e As EventArgs) Handles BTN_DELET.Click
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PLAN_INFERT WHERE CODE_PLAN_INFERT ='" & TXT_CODE_PLAN.Text & "'", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("Please enter valid data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim DR = DT.Rows(0)

            DR!STAT_PLAN_INFERT = False

            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            MessageBox.Show("THE PLAN INFORMATION IS DELET", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BTN_NEW_Click(sender, e)
        End If
    End Sub

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Me.Close()
    End Sub
    Sub NEPLAN()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM AUTOCOMPLET_PLAN", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            Dim DAAUTOCOMPLIT As New AutoCompleteStringCollection
            For I As Integer = 0 To DT.Rows.Count - 1
                DAAUTOCOMPLIT.Add(DT.Rows(I)("NAME"))
            Next
            TXT_NAME_PLAN.AutoCompleteCustomSource = DAAUTOCOMPLIT
            TXT_NAME_PLAN.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            TXT_NAME_PLAN.AutoCompleteSource = AutoCompleteSource.CustomSource
        End If
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(2, DataGridView1.CurrentRow.Index).Selected = True Then
            SHOW_DETA(DataGridView1.CurrentRow.Cells(0).Value)
        End If
    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(2).Value = "عرض"
            Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub

End Class