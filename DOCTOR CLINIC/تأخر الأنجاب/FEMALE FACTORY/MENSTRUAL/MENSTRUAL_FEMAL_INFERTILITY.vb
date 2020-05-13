Public Class MENSTRUAL_FEMAL_INFERTILITY
    Sub SHOW_DETA(CODE_)
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM MENSTRUAL_FEMAL_INFERTILTY WHERE CODE_MENSTRUAL_FEMAL_INFERTILTY = '" & CODE_ & "'  ", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("THE NAME MENSTRUAL IS NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE_MENSTRUAL_FEMAL_INFERTILTY.Text = DR!CODE_MENSTRUAL_FEMAL_INFERTILTY
            TXT_PA_CODE.Text = DR!CODE_PA_MENSTRUAL_FEMAL_INFERTILTY
            TXT_NAME_MENSTRUAL_FEMALE.Text = DR!NAME_MENSTRUAL_FEMAL_INFERTILTY

            BTN_EDIT.Enabled = True
            BTN_DELET.Enabled = True
            BTN_SAVE.Enabled = False
        End If
    End Sub
    Private Sub MENSTRUAL_FEMAL_INFERTILITY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_PA_CODE.Text = ENGABFRM.TXT_PA_CODE.Text
        TXT_PA_NAME.Text = ENGABFRM.TXT_PA_NAME.Text
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        TXT_CODE_MENSTRUAL_FEMAL_INFERTILTY.Text = CODE_GENE("MENSTRUAL_FEMAL_INFERTILTY", "ID") + 1
        BTN_EDIT.Enabled = False
        BTN_DELET.Enabled = False
        BTN_SAVE.Enabled = True
        TXT_NAME_MENSTRUAL_FEMALE.Text = ""
        TXT_NAME_MENSTRUAL_FEMALE.Select()
        FILL_DGV(DataGridView1, "SELECT * FROM MENSTRUAL_FEMAL_INFERTILTY WHERE STAT_MENSTRUAL_FEMAL_INFERTILTY ='TRUE' AND CODE_PA_MENSTRUAL_FEMAL_INFERTILTY='" & TXT_PA_CODE.Text & "'ORDER BY ID DESC ")
    End Sub

    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM MENSTRUAL_FEMAL_INFERTILTY", SqlConn)
        DA.Fill(DT)

        Dim DR = DT.NewRow
        DR!CODE_MENSTRUAL_FEMAL_INFERTILTY = TXT_CODE_MENSTRUAL_FEMAL_INFERTILTY.Text
        DR!CODE_PA_MENSTRUAL_FEMAL_INFERTILTY = TXT_PA_CODE.Text
        DR!NAME_MENSTRUAL_FEMAL_INFERTILTY = TXT_NAME_MENSTRUAL_FEMALE.Text
        DR!STAT_MENSTRUAL_FEMAL_INFERTILTY = True
        DT.Rows.Add(DR)
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)

        MessageBox.Show("THE MENSTRUAL_FEMAL_INFERTILTY INFORMATION IS SAVED", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_EDIT_Click(sender As Object, e As EventArgs) Handles BTN_EDIT.Click
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM MENSTRUAL_FEMAL_INFERTILTY WHERE CODE_MENSTRUAL_FEMAL_INFERTILTY ='" & TXT_CODE_MENSTRUAL_FEMAL_INFERTILTY.Text & "'", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("Please enter valid data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim DR = DT.Rows(0)
            DR!CODE_MENSTRUAL_FEMAL_INFERTILTY = TXT_CODE_MENSTRUAL_FEMAL_INFERTILTY.Text
            DR!CODE_PA_MENSTRUAL_FEMAL_INFERTILTY = TXT_PA_CODE.Text
            DR!NAME_MENSTRUAL_FEMAL_INFERTILTY = TXT_NAME_MENSTRUAL_FEMALE.Text
            DR!STAT_MENSTRUAL_FEMAL_INFERTILTY = True

            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)

            MessageBox.Show("THE MENSTRUAL FEMALE INFERTILTY INFORMATION IS EDIT", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BTN_NEW_Click(sender, e)
        End If

    End Sub

    Private Sub BTN_DELET_Click(sender As Object, e As EventArgs) Handles BTN_DELET.Click
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM MENSTRUAL_FEMAL_INFERTILTY WHERE CODE_MENSTRUAL_FEMAL_INFERTILTY ='" & TXT_CODE_MENSTRUAL_FEMAL_INFERTILTY.Text & "'", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("Please enter valid data", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Dim DR = DT.Rows(0)

            DR!STAT_MENSTRUAL_FEMAL_INFERTILTY = False

            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            MessageBox.Show("THE MENSTRUAL FEMAL INFERTILTY INFORMATION IS DELET", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BTN_NEW_Click(sender, e)
        End If
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