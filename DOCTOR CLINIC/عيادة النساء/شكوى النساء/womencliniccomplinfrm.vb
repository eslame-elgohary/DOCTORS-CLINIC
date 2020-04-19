Public Class womencliniccomplinfrm
    Sub SHOW_DETA(CODE_)
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM NESA_SHKWA WHERE CODE_NESA_SHKWA = '" & CODE_ & "'  ", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("THE COMPLAINT IS NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!CODE_NESA_SHKWA
            TXT_NAME.Text = DR!NAME_NESA_SHKWA
            BTN_EDIT.Enabled = True
            BTN_DELET.Enabled = True
            BTN_SAVE.Enabled = False
        End If
    End Sub
    Private Sub womencliniccomplinfrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        TXT_CODE.Text = CODE_GENE("NESA_SHKWA", "ID") + 1
        TXT_NAME.Text = ""
        BTN_EDIT.Enabled = False
        BTN_DELET.Enabled = False
        BTN_SAVE.Enabled = True
        FILL_DGV(DataGridView1, "SELECT * FROM NESA_SHKWA WHERE STAT_NESA_SHKWA='TRUE' ORDER BY CODE_NESA_SHKWA")
    End Sub

    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("N101").ToString = True Then
                If TXT_NAME.Text = "" Then
                    MessageBox.Show("PLEASE ENTER YOUR COMPLAINT INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM NESA_SHKWA ", SqlConn)
                DA.Fill(DT)
                Dim DR = DT.NewRow
                DR!CODE_NESA_SHKWA = TXT_CODE.Text
                DR!NAME_NESA_SHKWA = TXT_NAME.Text
                DR!STAT_NESA_SHKWA = True
                DT.Rows.Add(DR)
                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                MessageBox.Show(" THE COMPLAINT INFORMATION HAS BEEN SUCCESSFULLY SAVED", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BTN_NEW_Click(sender, e)


            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub BTN_EDIT_Click(sender As Object, e As EventArgs) Handles BTN_EDIT.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("N102").ToString = True Then
                If TXT_NAME.Text = "" Then
                    MessageBox.Show("PLEASE ENTER YOUR COMPLAINT INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM NESA_SHKWA WHERE CODE_NESA_SHKWA = '" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)

                Dim DR = DT.Rows(0)
                DR!CODE_NESA_SHKWA = TXT_CODE.Text
                DR!NAME_NESA_SHKWA = TXT_NAME.Text
                DR!STAT_NESA_SHKWA = True

                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                MessageBox.Show(" THE COMPLAINT INFORMATION HAS BEEN SUCCESSFULLY EDIT", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BTN_NEW_Click(sender, e)


            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub BTN_DELET_Click(sender As Object, e As EventArgs) Handles BTN_DELET.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("N103").ToString = True Then
                If TXT_NAME.Text = "" Then
                    MessageBox.Show("PLEASE ENTER YOUR COMPLAINT INFORMATION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM NESA_SHKWA WHERE CODE_NESA_SHKWA = '" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)

                Dim DR = DT.Rows(0)

                DR!STAT_NESA_SHKWA = False

                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                MessageBox.Show(" THE COMPLAINT INFORMATION HAS BEEN SUCCESSFULLY DELET", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BTN_NEW_Click(sender, e)

            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
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
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(2).Value = "عرض"
            Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub
End Class