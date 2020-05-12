Public Class HSG_INFERILTY
    Sub SHOW_DETA(CODE_)
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM HSG_INFERILTY WHERE CODE_HSG_INFERILTY = '" & CODE_ & "'  ", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("THE NAME 4D IS NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE_HSG_INFERILTY.Text = DR!CODE_HSG_INFERILTY
            TXT_PA_CODE.Text = DR!CODE_PA_HSG_INFERILTY
            TXT_DATE_HSG_INFERILTY.Text = DR!DATE_HSG_INFERILTY
            TXT_PLACE_HSG_INFERILTY.Text = DR!PLACE_HSG_INFERILTY
            TXT_UTERUS_HSG_INFERILTY.Text = DR!UTERUS_HSG_INFERILTY
            TXT_TUBES_HSG_INFERILTY.Text = DR!TUBES_HSG_INFERILTY

            BTN_EDIT.Enabled = True
            BTN_DELET.Enabled = True
            BTN_SAVE.Enabled = False
        End If
    End Sub
    Private Sub HSG_INFERILTY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_PA_CODE.Text = ENGABFRM.TXT_PA_CODE.Text
        TXT_PA_NAME.Text = ENGABFRM.TXT_PA_NAME.Text
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        TXT_CODE_HSG_INFERILTY.Text = CODE_GENE("HSG_INFERILTY", "ID") + 1
        TXT_DATE_HSG_INFERILTY.Value = Date.Today
        TXT_PLACE_HSG_INFERILTY.Text = ""
        TXT_TUBES_HSG_INFERILTY.Text = ""
        TXT_UTERUS_HSG_INFERILTY.Text = ""
        TXT_PLACE_HSG_INFERILTY.Select()
        BTN_EDIT.Enabled = False
        BTN_DELET.Enabled = False
        BTN_SAVE.Enabled = True
        FILL_DGV(DataGridView1, "SELECT * FROM HSG_INFERILTY WHERE STAT_HSG_INFERILTY ='TRUE' AND CODE_PA_HSG_INFERILTY='" & TXT_PA_CODE.Text & "'")
    End Sub

    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        If TXT_PLACE_HSG_INFERILTY.Text = "" Then
            MessageBox.Show("يرجى أدخال مكان الأشعة ؟", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PLACE_HSG_INFERILTY.Select()
            Exit Sub
        End If
        '=========================================
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HSG_INFERILTY ", SqlConn)
        DA.Fill(DT)

        Dim DR = DT.NewRow
        DR!CODE_HSG_INFERILTY = TXT_CODE_HSG_INFERILTY.Text
        DR!CODE_PA_HSG_INFERILTY = TXT_PA_CODE.Text
        DR!DATE_HSG_INFERILTY = TXT_DATE_HSG_INFERILTY.Text
        DR!PLACE_HSG_INFERILTY = TXT_PLACE_HSG_INFERILTY.Text
        DR!UTERUS_HSG_INFERILTY = TXT_UTERUS_HSG_INFERILTY.Text
        DR!TUBES_HSG_INFERILTY = TXT_TUBES_HSG_INFERILTY.Text
        DR!STAT_HSG_INFERILTY = True
        DT.Rows.Add(DR)
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("تم عملية التسجيل بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_EDIT_Click(sender As Object, e As EventArgs) Handles BTN_EDIT.Click
        If TXT_PLACE_HSG_INFERILTY.Text = "" Then
            MessageBox.Show("يرجى أدخال مكان الأشعة ؟", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PLACE_HSG_INFERILTY.Select()
            Exit Sub
        End If
        '=========================================
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HSG_INFERILTY WHERE CODE_HSG_INFERILTY='" & TXT_CODE_HSG_INFERILTY.Text & "'", SqlConn)
        DA.Fill(DT)

        Dim DR = DT.Rows(0)
        DR!CODE_HSG_INFERILTY = TXT_CODE_HSG_INFERILTY.Text
        DR!CODE_PA_HSG_INFERILTY = TXT_PA_CODE.Text
        DR!DATE_HSG_INFERILTY = TXT_DATE_HSG_INFERILTY.Text
        DR!PLACE_HSG_INFERILTY = TXT_PLACE_HSG_INFERILTY.Text
        DR!UTERUS_HSG_INFERILTY = TXT_UTERUS_HSG_INFERILTY.Text
        DR!TUBES_HSG_INFERILTY = TXT_TUBES_HSG_INFERILTY.Text
        DR!STAT_HSG_INFERILTY = True

        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("تم عملية التعديل بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_DELET_Click(sender As Object, e As EventArgs) Handles BTN_DELET.Click
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HSG_INFERILTY WHERE CODE_HSG_INFERILTY='" & TXT_CODE_HSG_INFERILTY.Text & "'", SqlConn)
        DA.Fill(DT)

        Dim DR = DT.Rows(0)

        DR!STAT_HSG_INFERILTY = False

        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("تم عملية التعديل بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
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