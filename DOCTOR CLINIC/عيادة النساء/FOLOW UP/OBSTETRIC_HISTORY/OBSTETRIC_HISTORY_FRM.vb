﻿Public Class OBSTETRIC_HISTORY_FRM
    Sub SHOW_DETA(CODE_)
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM OBSTETRIC_HISTORY WHERE CODE_OBSTETRIC = '" & CODE_ & "'  ", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("THE OBSTETRIC HISTORY IS NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!CODE_OBSTETRIC
            TXT_NAME.Text = DR!NAME_OBSTETRIC
            BTN_EDIT.Enabled = True
            BTN_DELET.Enabled = True
            BTN_SAVE.Enabled = False
        End If
    End Sub
    Private Sub OBSTETRIC_HISTORY_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        TXT_CODE.Text = CODE_GENE("OBSTETRIC_HISTORY", "ID") + 1
        TXT_PA_CODE.Text = FOLLOWUPFRM.TXT_PA_CODE.Text
        TXT_NAME.Text = ""
        BTN_EDIT.Enabled = False
        BTN_DELET.Enabled = False
        BTN_SAVE.Enabled = True
        FILL_DGV(DataGridView1, "SELECT * FROM OBSTETRIC_HISTORY WHERE STAT_OBSTETRIC ='TRUE' AND PA_CODE_OBSTETRIC ='" & TXT_PA_CODE.Text & "'")
    End Sub

    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        If TXT_NAME.Text = "" Then
            MessageBox.Show("PLEASE ENTER OBSTETRIC HISTORY INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_NAME.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM OBSTETRIC_HISTORY ", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.NewRow
        DR!CODE_OBSTETRIC = TXT_CODE.Text
        DR!PA_CODE_OBSTETRIC = TXT_PA_CODE.Text
        DR!NAME_OBSTETRIC = TXT_NAME.Text
        DR!STAT_OBSTETRIC = True
        DT.Rows.Add(DR)
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("THE OBSTETRIC HISTORY INFORMATION IS SAVED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        BTN_NEW_Click(sender, e)

    End Sub

    Private Sub BTN_EDIT_Click(sender As Object, e As EventArgs) Handles BTN_EDIT.Click
        If TXT_NAME.Text = "" Then
            MessageBox.Show("PLEASE ENTER OBSTETRIC HISTORY INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_NAME.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM OBSTETRIC_HISTORY WHERE CODE_OBSTETRIC='" & TXT_CODE.Text & "' ", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.Rows(0)
        DR!CODE_OBSTETRIC = TXT_CODE.Text
        DR!PA_CODE_OBSTETRIC = TXT_PA_CODE.Text
        DR!NAME_OBSTETRIC = TXT_NAME.Text
        DR!STAT_OBSTETRIC = True

        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("THE OBSTETRIC HISTORY INFORMATION IS EDIT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_DELET_Click(sender As Object, e As EventArgs) Handles BTN_DELET.Click
        If MessageBox.Show("DO YOU WANT DELET IT ?", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM OBSTETRIC_HISTORY WHERE CODE_OBSTETRIC='" & TXT_CODE.Text & "' ", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.Rows(0)

        DR!STAT_OBSTETRIC = False

        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("THE OBSTETRIC HISTORY INFORMATION IS DELET", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub TXT_PA_CODE_TextChanged(sender As Object, e As EventArgs) Handles TXT_PA_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_CODE ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA_NAME.Text = DT.Rows(I).Item("PA_NAME")
        Next
    End Sub
End Class