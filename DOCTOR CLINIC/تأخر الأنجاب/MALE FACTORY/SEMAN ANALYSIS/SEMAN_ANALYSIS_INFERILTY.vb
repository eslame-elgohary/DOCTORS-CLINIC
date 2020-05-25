Public Class SEMAN_ANALYSIS_INFERILTY
    Sub SHOW_DETA(CODE_)
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM SEMAN WHERE CODE_SEMAN = '" & CODE_ & "'  ", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("THE TEST SEMAN IS NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE_SEMAN.Text = DR!CODE_SEMAN
            TXT_PA_CODE.Text = DR!CODE_PA_SEMAN
            TXT_DATE_SEMAN.Text = DR!DATE_SEMAN
            TXT_NAME_SEMAN.Text = DR!PLACE_SEMAN
            TXT_NOOF_SPERM.Text = DR!SPERM_SEMAN
            TXT_MOTILITY.Text = DR!MOTILITY_SEMAN
            TXT_ABNORMAL.Text = DR!ABNORMAL_SEMAN

            BTN_EDIT.Enabled = True
            BTN_DELET.Enabled = True
            BTN_SAVE.Enabled = False
        End If
    End Sub
    Private Sub SEMAN_ANALYSIS_INFERILTY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_PA_CODE.Text = ENGABFRM.TXT_PA_CODE.Text
        TXT_PA_NAME.Text = ENGABFRM.TXT_PA_NAME.Text
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        TXT_CODE_SEMAN.Text = CODE_GENE("SEMAN", "ID") + 1
        BTN_EDIT.Enabled = False
        BTN_DELET.Enabled = False
        BTN_SAVE.Enabled = True
        TXT_ABNORMAL.Text = ""
        TXT_DATE_SEMAN.Value = Date.Today
        TXT_MOTILITY.Text = ""
        TXT_NAME_SEMAN.Text = ""
        TXT_NOOF_SPERM.Text = ""
        TXT_NAME_SEMAN.Select()
        FILL_DGV(DataGridView1, "SELECT * FROM SEMAN WHERE STAT_SEMAN ='TRUE' AND CODE_PA_SEMAN ='" & TXT_PA_CODE.Text & "'ORDER BY ID DESC ")

    End Sub

    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click

        If TXT_NAME_SEMAN.Text = "" Then
            MessageBox.Show("يرجى أدخال مكان التحليل", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_NAME_SEMAN.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM SEMAN ", SqlConn)
        DA.Fill(DT)

        Dim DR = DT.NewRow
        DR!CODE_SEMAN = TXT_CODE_SEMAN.Text
        DR!CODE_PA_SEMAN = TXT_PA_CODE.Text
        DR!DATE_SEMAN = TXT_DATE_SEMAN.Text
        DR!PLACE_SEMAN = TXT_NAME_SEMAN.Text
        DR!SPERM_SEMAN = TXT_NOOF_SPERM.Text
        DR!MOTILITY_SEMAN = TXT_MOTILITY.Text
        DR!ABNORMAL_SEMAN = TXT_ABNORMAL.Text
        DR!STAT_SEMAN = True
        DT.Rows.Add(DR)
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("تم عملية الحفظ بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BTN_NEW_Click(sender, e)

    End Sub

    Private Sub BTN_EDIT_Click(sender As Object, e As EventArgs) Handles BTN_EDIT.Click
        If TXT_NAME_SEMAN.Text = "" Then
            MessageBox.Show("يرجى أدخال مكان التحليل", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_NAME_SEMAN.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM SEMAN WHERE CODE_SEMAN='" & TXT_CODE_SEMAN.Text & "' ", SqlConn)
        DA.Fill(DT)

        Dim DR = DT.Rows(0)
        DR!CODE_SEMAN = TXT_CODE_SEMAN.Text
        DR!CODE_PA_SEMAN = TXT_PA_CODE.Text
        DR!DATE_SEMAN = TXT_DATE_SEMAN.Text
        DR!PLACE_SEMAN = TXT_NAME_SEMAN.Text
        DR!SPERM_SEMAN = TXT_NOOF_SPERM.Text
        DR!MOTILITY_SEMAN = TXT_MOTILITY.Text
        DR!ABNORMAL_SEMAN = TXT_ABNORMAL.Text
        DR!STAT_SEMAN = True

        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("تم عملية التعديل بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BTN_NEW_Click(sender, e)

    End Sub

    Private Sub BTN_DELET_Click(sender As Object, e As EventArgs) Handles BTN_DELET.Click
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM SEMAN WHERE CODE_SEMAN='" & TXT_CODE_SEMAN.Text & "' ", SqlConn)
        DA.Fill(DT)

        Dim DR = DT.Rows(0)

        DR!STAT_SEMAN = False

        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("تم عملية الحذف بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Me.Close()
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(2, DataGridView1.CurrentRow.Index).Selected = True Then
            SHOW_DETA(DataGridView1.CurrentRow.Cells(0).Value)
        End If
    End Sub
End Class