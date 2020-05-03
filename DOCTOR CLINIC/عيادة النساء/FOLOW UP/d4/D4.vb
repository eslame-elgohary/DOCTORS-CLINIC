Public Class D4

    Sub SHOW_DETA(CODE_)
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM E4D_HISTORY WHERE CODE_4D = '" & CODE_ & "'  ", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("THE 4D IS NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!CODE_4D
            TXT_NAME.Text = DR!NAME_4D
            TXT_DATE.Text = DR!DATE_4D
            BTN_EDIT.Enabled = True
            BTN_DELET.Enabled = True
            BTN_SAVE.Enabled = False
        End If
    End Sub
    Private Sub D4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        TXT_CODE.Text = CODE_GENE("E4D_HISTORY", "ID") + 1
        TXT_PA_CODE.Text = FOLLOWUPFRM.TXT_PA_CODE.Text
        TXT_NAME.Text = ""
        TXT_DATE.Text = Date.Today
        BTN_EDIT.Enabled = False
        BTN_DELET.Enabled = False
        BTN_SAVE.Enabled = True
        FILL_DGV(DataGridView1, "SELECT * FROM E4D_HISTORY WHERE STAT_4D ='TRUE' AND PA_CODE_4D='" & TXT_PA_CODE.Text & "'")
    End Sub

    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        If TXT_NAME.Text = "" Then
            MessageBox.Show("PLEASE ENTER 4D INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_NAME.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM E4D_HISTORY ", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.NewRow
        DR!CODE_4D = TXT_CODE.Text
        DR!PA_CODE_4D = TXT_PA_CODE.Text
        DR!NAME_4D = TXT_NAME.Text
        DR!DATE_4D = TXT_DATE.Text
        DR!STAT_4D = True
        DT.Rows.Add(DR)
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("THE 4D INFORMATION IS SAVED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        BTN_NEW_Click(sender, e)

    End Sub

    Private Sub BTN_EDIT_Click(sender As Object, e As EventArgs) Handles BTN_EDIT.Click
        If TXT_NAME.Text = "" Then
            MessageBox.Show("PLEASE ENTER 4D INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_NAME.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM E4D_HISTORY WHERE CODE_4D ='" & TXT_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.Rows(0)
        DR!CODE_4D = TXT_CODE.Text
        DR!PA_CODE_4D = TXT_PA_CODE.Text
        DR!NAME_4D = TXT_NAME.Text
        DR!DATE_4D = TXT_DATE.Text
        DR!STAT_4D = True

        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("THE 4D INFORMATION IS EDIT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_DELET_Click(sender As Object, e As EventArgs) Handles BTN_DELET.Click
        If MessageBox.Show("DO YOU WANT DELET IT ?", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM E4D_HISTORY WHERE CODE_4D ='" & TXT_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.Rows(0)

        DR!STAT_4D = False

        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("THE 4D INFORMATION IS DELET", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Me.Close()
    End Sub
    Private Sub TXT_PA_CODE_TextChanged(sender As Object, e As EventArgs) Handles TXT_PA_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_CODE ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA_NAME.Text = DT.Rows(I).Item("PA_NAME")
        Next
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