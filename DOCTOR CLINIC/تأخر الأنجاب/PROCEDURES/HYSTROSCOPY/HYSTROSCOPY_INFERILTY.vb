Public Class HYSTROSCOPY_INFERILTY
    Sub SHOW_DETA(CODE_)
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM HYSTROSCOPY_INFERILTY WHERE CODE_HYSTROSCOPY_INFERILTY = '" & CODE_ & "'  ", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("THE NAME HYSTROSCOPY IS NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE_HYSTROSCOPY_INFERILTY.Text = DR!CODE_HYSTROSCOPY_INFERILTY
            TXT_PA_CODE.Text = DR!CODE_PA_HYSTROSCOPY_INFERILTY
            TXT_DATE_HYSTROSCOPY_INFERILTY.Text = DR!DATE_HYSTROSCOPY_INFERILTY
            TXT_PLACE_HYSTROSCOPY_INFERILTY.Text = DR!PLACE_HYSTROSCOPY_INFERILTY
            TXT_CERVIX_HYSTROSCOPY_INFERILTY.Text = DR!CERVIX_HYSTROSCOPY_INFERILTY
            TXT_CAVITY_HYSTROSCOPY_INFERILTY.Text = DR!CAVITY_HYSTROSCOPY_INFERILTY

            BTN_EDIT.Enabled = True
            BTN_DELET.Enabled = True
            BTN_SAVE.Enabled = False
        End If
    End Sub
    Private Sub HYSTROSCOPY_INFERILTY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_PA_CODE.Text = ENGABFRM.TXT_PA_CODE.Text
        TXT_PA_NAME.Text = ENGABFRM.TXT_PA_NAME.Text
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        TXT_CODE_HYSTROSCOPY_INFERILTY.Text = CODE_GENE("HYSTROSCOPY_INFERILTY", "ID") + 1
        TXT_DATE_HYSTROSCOPY_INFERILTY.Text = Date.Today
        TXT_PLACE_HYSTROSCOPY_INFERILTY.Text = ""
        TXT_CERVIX_HYSTROSCOPY_INFERILTY.Text = ""
        TXT_CAVITY_HYSTROSCOPY_INFERILTY.Text = ""
        TXT_PLACE_HYSTROSCOPY_INFERILTY.Select()
        BTN_EDIT.Enabled = False
        BTN_DELET.Enabled = False
        BTN_SAVE.Enabled = True
        FILL_DGV(DataGridView1, "SELECT * FROM HYSTROSCOPY_INFERILTY WHERE STAT_HYSTROSCOPY_INFERILTY ='TRUE' AND CODE_PA_HYSTROSCOPY_INFERILTY='" & TXT_PA_CODE.Text & "'")

    End Sub

    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        If TXT_PLACE_HYSTROSCOPY_INFERILTY.Text = "" Then
            MessageBox.Show("يرجى أدخال مكان الأشعة ؟", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PLACE_HYSTROSCOPY_INFERILTY.Select()
            Exit Sub
        End If
        '=========================================
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HYSTROSCOPY_INFERILTY ", SqlConn)
        DA.Fill(DT)

        Dim DR = DT.NewRow
        DR!CODE_HYSTROSCOPY_INFERILTY = TXT_CODE_HYSTROSCOPY_INFERILTY.Text
        DR!CODE_PA_HYSTROSCOPY_INFERILTY = TXT_PA_CODE.Text
        DR!DATE_HYSTROSCOPY_INFERILTY = TXT_DATE_HYSTROSCOPY_INFERILTY.Text
        DR!PLACE_HYSTROSCOPY_INFERILTY = TXT_PLACE_HYSTROSCOPY_INFERILTY.Text
        DR!CERVIX_HYSTROSCOPY_INFERILTY = TXT_CERVIX_HYSTROSCOPY_INFERILTY.Text
        DR!CAVITY_HYSTROSCOPY_INFERILTY = TXT_CAVITY_HYSTROSCOPY_INFERILTY.Text
        DR!STAT_HYSTROSCOPY_INFERILTY = True
        DT.Rows.Add(DR)
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("تم عملية التسجيل بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BTN_NEW_Click(sender, e)

    End Sub

    Private Sub BTN_EDIT_Click(sender As Object, e As EventArgs) Handles BTN_EDIT.Click
        If TXT_PLACE_HYSTROSCOPY_INFERILTY.Text = "" Then
            MessageBox.Show("يرجى أدخال مكان الأشعة ؟", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PLACE_HYSTROSCOPY_INFERILTY.Select()
            Exit Sub
        End If
        '=========================================
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HYSTROSCOPY_INFERILTY WHERE CODE_HYSTROSCOPY_INFERILTY ='" & TXT_CODE_HYSTROSCOPY_INFERILTY.Text & "'  ", SqlConn)
        DA.Fill(DT)

        Dim DR = DT.Rows(0)
        DR!CODE_HYSTROSCOPY_INFERILTY = TXT_CODE_HYSTROSCOPY_INFERILTY.Text
        DR!CODE_PA_HYSTROSCOPY_INFERILTY = TXT_PA_CODE.Text
        DR!DATE_HYSTROSCOPY_INFERILTY = TXT_DATE_HYSTROSCOPY_INFERILTY.Text
        DR!PLACE_HYSTROSCOPY_INFERILTY = TXT_PLACE_HYSTROSCOPY_INFERILTY.Text
        DR!CERVIX_HYSTROSCOPY_INFERILTY = TXT_CERVIX_HYSTROSCOPY_INFERILTY.Text
        DR!CAVITY_HYSTROSCOPY_INFERILTY = TXT_CAVITY_HYSTROSCOPY_INFERILTY.Text
        DR!STAT_HYSTROSCOPY_INFERILTY = True

        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("تم عملية التعديل بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_DELET_Click(sender As Object, e As EventArgs) Handles BTN_DELET.Click
        If TXT_PLACE_HYSTROSCOPY_INFERILTY.Text = "" Then
            MessageBox.Show("يرجى أدخال مكان الأشعة ؟", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PLACE_HYSTROSCOPY_INFERILTY.Select()
            Exit Sub
        End If
        '=========================================
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HYSTROSCOPY_INFERILTY WHERE CODE_HYSTROSCOPY_INFERILTY ='" & TXT_CODE_HYSTROSCOPY_INFERILTY.Text & "'  ", SqlConn)
        DA.Fill(DT)

        Dim DR = DT.Rows(0)

        DR!STAT_HYSTROSCOPY_INFERILTY = False

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