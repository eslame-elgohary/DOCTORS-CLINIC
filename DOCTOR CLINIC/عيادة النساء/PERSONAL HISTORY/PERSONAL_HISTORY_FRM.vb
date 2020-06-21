Public Class PERSONAL_HISTORY_FRM
    Sub SHOW_DETA(CODE_)
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM PERSONAL_HISTORY WHERE CODE_PERS = '" & CODE_ & "'  ", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("THE PERSONAL HISTORY IS NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!CODE_PERS
            TXT_PA_CODE.Text = DR!CODE_PA_PERS
            MARED_DEAT.Value = DR!DATE_MARED_PERS
            LMP_DATE.Value = DR!LMP_PERS
            EDP_DATE.Value = DR!EDP_PERS
            TXT_RH.Text = DR!RH_PERS
            TXT_ABO.Text = DR!ABO_PERS
            BTN_EDIT.Enabled = True
            BTN_DELET.Enabled = True
            BTN_SAVE.Enabled = False
        End If
    End Sub
    Private Sub PERSONAL_HISTORY_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click

        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        PATIENTDATA.Clear()
        PATIENTTableAdapter.Fill(PATIENTDATA.PATIENT)
        PATIENTDATA.Clear()
        PATIENTTableAdapter.Fill(PATIENTDATA.PATIENT)
        TXT_CODE.Text = CODE_GENE("PERSONAL_HISTORY", "ID") + 1
        TXT_NAME.Text = ""
        MARED_DEAT.Value = Date.Today
        LMP_DATE.Value = Date.Today
        EDP_DATE.Value = Date.Today
        TXT_ABO.Text = ""
        TXT_RH.Text = ""
        TXT_SEARCH.Text = ""
        BTN_EDIT.Enabled = False
        BTN_DELET.Enabled = False
        BTN_SAVE.Enabled = True
        FILL_DGV(DataGridView1, "SELECT * FROM PERSONAL_HISTORY_V WHERE STAT_PERS ='TRUE' ORDER BY CODE_PERS")

    End Sub

    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("M101").ToString = True Then
                '===================================================================================================
                If TXT_PA_CODE.Text = "" Then
                    MessageBox.Show("PLEASE ENTER NAME PATION ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_NAME.Select()
                    Exit Sub
                End If
                If TXT_RH.Text = "" Then
                    MessageBox.Show("PLEASE ENTER RH FOR PATION ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_RH.Select()
                    Exit Sub
                End If
                If TXT_ABO.Text = "" Then
                    MessageBox.Show("PLEASE ENTER ABO FOR PATION ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_ABO.Select()
                    Exit Sub
                End If
                '=======================================================================================

                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM PERSONAL_HISTORY WHERE CODE_PA_PERS = '" & TXT_PA_CODE.Text & "' ", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count > 0 Then
                    MessageBox.Show("THE PERSONAL HISTORY IS NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim DR = DT.NewRow
                    DR!CODE_PERS = TXT_CODE.Text
                    DR!CODE_PA_PERS = TXT_PA_CODE.Text
                    DR!DATE_MARED_PERS = MARED_DEAT.Value
                    DR!LMP_PERS = LMP_DATE.Value
                    DR!EDP_PERS = EDP_DATE.Value
                    DR!RH_PERS = TXT_RH.Text
                    DR!ABO_PERS = TXT_ABO.Text
                    DR!STAT_PERS = True
                    DT.Rows.Add(DR)
                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    MessageBox.Show("THE PERSONAL HISTORY INFORMATION HAS BEEN SUCCESSFULLY SAVED", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    BTN_NEW_Click(sender, e)
                End If
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
            If DT0.Rows(0).Item("M102").ToString = True Then

                '===================================================================================================
                If TXT_PA_CODE.Text = "" Then
                    MessageBox.Show("PLEASE ENTER NAME PATION ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_NAME.Select()
                    Exit Sub
                End If
                If TXT_RH.Text = "" Then
                    MessageBox.Show("PLEASE ENTER RH FOR PATION ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_RH.Select()
                    Exit Sub
                End If
                If TXT_ABO.Text = "" Then
                    MessageBox.Show("PLEASE ENTER ABO FOR PATION ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_ABO.Select()
                    Exit Sub
                End If
                '=======================================================================================

                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM PERSONAL_HISTORY WHERE CODE_PERS = '" & TXT_CODE.Text & "' ", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count = 0 Then
                    MessageBox.Show("THE PERSONAL HISTORY IS NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim DR = DT.Rows(0)
                    DR!CODE_PERS = TXT_CODE.Text
                    DR!CODE_PA_PERS = TXT_PA_CODE.Text
                    DR!DATE_MARED_PERS = MARED_DEAT.Value
                    DR!LMP_PERS = LMP_DATE.Value
                    DR!EDP_PERS = EDP_DATE.Value
                    DR!RH_PERS = TXT_RH.Text
                    DR!ABO_PERS = TXT_ABO.Text
                    DR!STAT_PERS = True

                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    MessageBox.Show("THE PERSONAL HISTORY INFORMATION HAS BEEN SUCCESSFULLY EDIT", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    BTN_NEW_Click(sender, e)
                End If
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
            If DT0.Rows(0).Item("M103").ToString = True Then

                '=======================================================================================
                If MessageBox.Show("DO YOU NEED DELET THE PERSONAL HISTORY INFORMATION ", "HELP!!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub

                Dim DT As New DataTable
                    Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM PERSONAL_HISTORY WHERE CODE_PERS = '" & TXT_CODE.Text & "' ", SqlConn)
                    DA.Fill(DT)
                    If DT.Rows.Count = 0 Then
                        MessageBox.Show("THE PERSONAL HISTORY IS NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Dim DR = DT.Rows(0)

                        DR!STAT_PERS = False

                        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                        DA.Update(DT)
                        MessageBox.Show("THE PERSONAL HISTORY INFORMATION HAS BEEN SUCCESSFULLY DELET", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        BTN_NEW_Click(sender, e)
                    End If
                Else
                    MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Me.Close()
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(3, DataGridView1.CurrentRow.Index).Selected = True Then
            SHOW_DETA(DataGridView1.CurrentRow.Cells(0).Value)
        End If
    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(3).Value = "عرض"
            Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TXT_SEARCH.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter
        DT.Clear()
        DA = New SqlClient.SqlDataAdapter("SELECT * FROM PERSONAL_HISTORY_V WHERE STAT_PERS='TRUE' AND PA_NAME LIKE '%" & TXT_SEARCH.Text & "%'", SqlConn)
        DA.Fill(DT)
        DataGridView1.DataSource = DT.DefaultView
    End Sub

    Private Sub TXT_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME='" & TXT_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA_CODE.Text = DT.Rows(I).Item("PA_CODE")
            TXT_AGE.Text = DT.Rows(I).Item("PA_AGE")
            TXT_NAME2.Text = DT.Rows(I).Item("PA_NAME2")
        Next
    End Sub

    Private Sub TXT_PA_CODE_TextChanged(sender As Object, e As EventArgs) Handles TXT_PA_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_CODE='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_NAME.Text = DT.Rows(I).Item("PA_NAME")
            TXT_AGE.Text = DT.Rows(I).Item("PA_AGE")
            TXT_NAME2.Text = DT.Rows(I).Item("PA_NAME2")
        Next
    End Sub

    Private Sub PERSONAL_HISTORY_FRM_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.S AndAlso e.Control Then
            BTN_SAVE_Click(sender, e)
        End If
        If e.KeyCode = Keys.E AndAlso e.Control Then
            BTN_EDIT_Click(sender, e)
        End If
    End Sub
End Class