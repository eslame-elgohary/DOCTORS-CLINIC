Public Class TEST_FRM_INFERTILITY
    Sub SHOW_DETA(CODE_)
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM TEST_INFERT WHERE CODE_TEST_INFERT = '" & CODE_ & "'  ", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("THE NAME TEST IS NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE_TEST.Text = DR!CODE_TEST_INFERT
            TXT_PA_CODE.Text = DR!CODE_PA_TEST_INFERT
            TXT_DATE_TEST.Value = DR!DATE_TEST_INFERT
            TXT_NAME_PALCE_TEST.Text = DR!NAME_PALCE_TEST_INFERT
            TXT_RESULT_TEST.Text = DR!RESULT_TEST_INFERT
            TXT_TESTNAME.Text = DR!NAME_TEST_INFERT

            BTN_EDIT.Enabled = True
            BTN_DELET.Enabled = True
            BTN_SAVE.Enabled = False
        End If
    End Sub
    Private Sub TEST_FRM_INFERTILITY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_PA_CODE.Text = ENGABFRM.TXT_PA_CODE.Text
        TXT_PA_NAME.Text = ENGABFRM.TXT_PA_NAME.Text
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        TXT_CODE_TEST.Text = CODE_GENE("TEST_INFERT", "ID") + 1
        Tester()
        TXT_DATE_TEST.Value = Date.Today
        TXT_NAME_PALCE_TEST.Text = ""
        TXT_TESTNAME.Text = ""
        TXT_RESULT_TEST.Text = ""
        TXT_NAME_PALCE_TEST.Select()
        PLACE()
        FILL_DGV(DataGridView1, "SELECT * FROM TEST_INFERT WHERE STAT_TEST_INFERT ='TRUE' AND CODE_PA_TEST_INFERT='" & TXT_PA_CODE.Text & "'")
    End Sub

    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM TEST_INFERT", SqlConn)
        DA.Fill(DT)

        Dim DR = DT.NewRow
        DR!CODE_TEST_INFERT = TXT_CODE_TEST.Text
        DR!CODE_PA_TEST_INFERT = TXT_PA_CODE.Text
        DR!DATE_TEST_INFERT = TXT_DATE_TEST.Text
        DR!NAME_PALCE_TEST_INFERT = TXT_NAME_PALCE_TEST.Text
        DR!RESULT_TEST_INFERT = TXT_RESULT_TEST.Text
        DR!NAME_TEST_INFERT = TXT_TESTNAME.Text
        DR!STAT_TEST_INFERT = True
        DT.Rows.Add(DR)
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)

        '======== auto complit =======
        Dim DTAUTO As New DataTable
        Dim DAAUTO As New SqlClient.SqlDataAdapter("SELECT * FROM AUTOCOMPLET_PLACE WHERE NAME = '" & TXT_NAME_PALCE_TEST.Text & "'", SqlConn)
        DAAUTO.Fill(DTAUTO)

        If DTAUTO.Rows.Count = 0 Then
            Dim DRAUTO = DTAUTO.NewRow
            DRAUTO!NAME = TXT_NAME_PALCE_TEST.Text
            DTAUTO.Rows.Add(DRAUTO)
            Dim SAVEAUTO As New SqlClient.SqlCommandBuilder(DAAUTO)
            DAAUTO.Update(DTAUTO)

        End If
        '=================================================================

        MessageBox.Show("THE TEST INFORMATION IS SAVED", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_EDIT_Click(sender As Object, e As EventArgs) Handles BTN_EDIT.Click
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM TEST_INFERT WHERE CODE_TEST_INFERT ='" & TXT_CODE_TEST.Text & "'", SqlConn)
        DA.Fill(DT)

        If DT.Rows.Count = 0 Then
            MessageBox.Show("Please enter valid data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            DR!CODE_TEST_INFERT = TXT_CODE_TEST.Text
            DR!CODE_PA_TEST_INFERT = TXT_PA_CODE.Text
            DR!DATE_TEST_INFERT = TXT_DATE_TEST.Text
            DR!NAME_PALCE_TEST_INFERT = TXT_NAME_PALCE_TEST.Text
            DR!RESULT_TEST_INFERT = TXT_RESULT_TEST.Text
            DR!NAME_TEST_INFERT = TXT_TESTNAME.Text
            DR!STAT_TEST_INFERT = True

            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)

            '======== auto complit =======
            Dim DTAUTO As New DataTable
            Dim DAAUTO As New SqlClient.SqlDataAdapter("SELECT * FROM AUTOCOMPLET_PLACE WHERE NAME = '" & TXT_NAME_PALCE_TEST.Text & "'", SqlConn)
            DAAUTO.Fill(DTAUTO)

            If DTAUTO.Rows.Count = 0 Then
                Dim DRAUTO = DTAUTO.NewRow
                DRAUTO!NAME = TXT_NAME_PALCE_TEST.Text
                DTAUTO.Rows.Add(DRAUTO)
                Dim SAVEAUTO As New SqlClient.SqlCommandBuilder(DAAUTO)
                DAAUTO.Update(DTAUTO)

            End If
            '=================================================================

            MessageBox.Show("THE TEST INFORMATION IS EDIT", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BTN_NEW_Click(sender, e)
        End If

    End Sub

    Private Sub BTN_DELET_Click(sender As Object, e As EventArgs) Handles BTN_DELET.Click
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM TEST_INFERT WHERE CODE_TEST_INFERT ='" & TXT_CODE_TEST.Text & "'", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("Please enter valid data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim DR = DT.Rows(0)

            DR!STAT_TEST_INFERT = False

            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            MessageBox.Show("THE TEST INFORMATION IS DELET", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BTN_NEW_Click(sender, e)
        End If
    End Sub

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Me.Close()
    End Sub
    Sub Tester()
        TXT_TESTNAME.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM THALEL WHERE STAT='TRUE' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_TESTNAME.Items.Add(DT.Rows(I).Item("TAH_NAME"))
        Next
    End Sub
    Sub PLACE()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM AUTOCOMPLET_PLACE", SqlConn)
        DA.Fill(DT)

        Dim DAAUTOCOMPLIT As New AutoCompleteStringCollection
        For I As Integer = 0 To DT.Rows.Count - 1
            DAAUTOCOMPLIT.Add(DT.Rows(I)("NAME"))
        Next
        TXT_NAME_PALCE_TEST.AutoCompleteCustomSource = DAAUTOCOMPLIT
        TXT_NAME_PALCE_TEST.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        TXT_NAME_PALCE_TEST.AutoCompleteSource = AutoCompleteSource.CustomSource

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