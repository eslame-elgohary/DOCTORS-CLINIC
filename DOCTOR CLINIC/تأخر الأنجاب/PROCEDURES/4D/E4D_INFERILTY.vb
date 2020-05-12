Public Class E4D_INFERILTY
    Sub SHOW_DETA(CODE_)
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM E4D_INFERT WHERE CODE_4D_INFERT = '" & CODE_ & "'  ", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("THE NAME 4D IS NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE_4D.Text = DR!CODE_4D_INFERT
            TXT_PA_CODE.Text = DR!CODE_PA_4D_INFERT
            TXT_DATE_4D.Value = DR!DATE_4D_INFERT
            TXT_PLACE_4D.Text = DR!PLACE_4D_INFERT
            TXT_UTERUS_4D.Text = DR!UTERUS_4D_INFERT
            TXT_DOPPLER_4D.Text = DR!DOPPLER_4D_INFERT
            TXT_OVARIES_4D.Text = DR!OVARIES_4D_INFERT

            BTN_EDIT.Enabled = True
            BTN_DELET.Enabled = True
            BTN_SAVE.Enabled = False
        End If
    End Sub
    Private Sub E4D_INFERILTY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_PA_CODE.Text = ENGABFRM.TXT_PA_CODE.Text
        TXT_PA_NAME.Text = ENGABFRM.TXT_PA_NAME.Text
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        TXT_CODE_4D.Text = CODE_GENE("E4D_INFERT", "ID") + 1
        TXT_DATE_4D.Value = Date.Today
        TXT_PLACE_4D.Text = ""
        TXT_UTERUS_4D.Text = ""
        TXT_OVARIES_4D.Text = ""
        TXT_DOPPLER_4D.Text = ""
        BTN_EDIT.Enabled = False
        BTN_DELET.Enabled = False
        BTN_SAVE.Enabled = True
        TXT_PLACE_4D.Select()
        FILL_DGV(DataGridView1, "SELECT * FROM E4D_INFERT WHERE STAT_4D_INFERT ='TRUE' AND CODE_PA_4D_INFERT='" & TXT_PA_CODE.Text & "'")
    End Sub

    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click

        If TXT_PLACE_4D.Text = "" Then
            MessageBox.Show("يرجى أدخال مكان الأشعة ؟", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PLACE_4D.Select()
            Exit Sub
        End If
        '=========================================
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM E4D_INFERT", SqlConn)
        DA.Fill(DT)

        Dim DR = DT.NewRow
        DR!CODE_4D_INFERT = TXT_CODE_4D.Text
        DR!CODE_PA_4D_INFERT = TXT_PA_CODE.Text
        DR!DATE_4D_INFERT = TXT_DATE_4D.Text
        DR!PLACE_4D_INFERT = TXT_PLACE_4D.Text
        DR!UTERUS_4D_INFERT = TXT_UTERUS_4D.Text
        DR!DOPPLER_4D_INFERT = TXT_DOPPLER_4D.Text
        DR!OVARIES_4D_INFERT = TXT_OVARIES_4D.Text
        DR!STAT_4D_INFERT = True
        DT.Rows.Add(DR)
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("تم عملية التسجيل بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BTN_NEW_Click(sender, e)

    End Sub

    Private Sub BTN_EDIT_Click(sender As Object, e As EventArgs) Handles BTN_EDIT.Click

        If TXT_PLACE_4D.Text = "" Then
            MessageBox.Show("يرجى أدخال مكان الأشعة ؟", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PLACE_4D.Select()
            Exit Sub
        End If
        '=========================================
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM E4D_INFERT WHERE CODE_4D_INFERT = '" & TXT_CODE_4D.Text & "'", SqlConn)
        DA.Fill(DT)

        Dim DR = DT.Rows(0)
        DR!CODE_4D_INFERT = TXT_CODE_4D.Text
        DR!CODE_PA_4D_INFERT = TXT_PA_CODE.Text
        DR!DATE_4D_INFERT = TXT_DATE_4D.Text
        DR!PLACE_4D_INFERT = TXT_PLACE_4D.Text
        DR!UTERUS_4D_INFERT = TXT_UTERUS_4D.Text
        DR!DOPPLER_4D_INFERT = TXT_DOPPLER_4D.Text
        DR!OVARIES_4D_INFERT = TXT_OVARIES_4D.Text
        DR!STAT_4D_INFERT = True

        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("تم عملية التعديل بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_DELET_Click(sender As Object, e As EventArgs) Handles BTN_DELET.Click

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM E4D_INFERT WHERE CODE_4D_INFERT = '" & TXT_CODE_4D.Text & "'", SqlConn)
        DA.Fill(DT)

        Dim DR = DT.Rows(0)

        DR!STAT_4D_INFERT = False

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
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(2).Value = "عرض"
            Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub
End Class