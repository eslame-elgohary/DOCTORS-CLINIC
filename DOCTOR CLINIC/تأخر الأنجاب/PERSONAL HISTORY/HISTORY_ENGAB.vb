Public Class HISTORY_ENGAB
    Sub SHOW_DETA(CODE_)
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM INFERTILITY_HISTORY WHERE CODE_INFERT_HIS = '" & CODE_ & "'  ", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("THE PERSONAL HISTORY IS NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!CODE_INFERT_HIS
            TXT_PA_CODE.Text = DR!PA_CODE_INFERT_HIS
            TXT_DATE_MARRIED.Value = DR!DATE_MARED_INFERT_HIS
            TXT_COMPIN.Text = DR!COMPIN_INFERT_HIS
            TXT_AGE2.Text = DR!AGE2_INFERT_HIS
            TXT_INFO2.Text = DR!INFO2_INFERT_HIS
            BTN_EDIT.Enabled = True
            BTN_DELET.Enabled = True
            BTN_SAVE.Enabled = False
        End If
    End Sub
    Private Sub HISTORY_ENGAB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click

        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next

        TXT_CODE.Text = CODE_GENE("INFERTILITY_HISTORY", "ID") + 1
        TXT_DATE_MARRIED.Value = Date.Today
        TXT_SEARCH.Text = ""
        TXT_NAME_PA.Text = ""
        TXT_COMPIN.Text = ""
        BTN_EDIT.Enabled = False
        BTN_DELET.Enabled = False
        BTN_SAVE.Enabled = True
        FILL_DGV(DataGridView1, "SELECT * FROM INFERTILITY_HISTORY_V WHERE STAT_INFERT_HIS ='TRUE' ORDER BY CODE_INFERT_HIS")
        FILL_PATION()
        FILL_COMPLAINT()
        TXT_NAME_PA.Select()
        TXT_INFO2.SelectedIndex = 0

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
                    TXT_NAME_PA.Select()
                    Exit Sub
                End If
                If TXT_COMPIN.Text = "" Then
                    MessageBox.Show("PLEASE ENTER Complaint FOR PATION ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_COMPIN.Select()
                    Exit Sub
                End If
                If TXT_AGE2.Text = "" Then
                    MessageBox.Show("PLEASE ENTER Age Husband FOR PATION ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_AGE2.Select()
                    Exit Sub
                End If
                '=======================================================================================

                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM INFERTILITY_HISTORY WHERE CODE_INFERT_HIS = '" & TXT_PA_CODE.Text & "' ", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count > 0 Then
                    MessageBox.Show("THE PERSONAL HISTORY IS NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim DR = DT.NewRow
                    DR!CODE_INFERT_HIS = TXT_CODE.Text
                    DR!PA_CODE_INFERT_HIS = TXT_PA_CODE.Text
                    DR!DATE_MARED_INFERT_HIS = TXT_DATE_MARRIED.Value
                    DR!COMPIN_INFERT_HIS = TXT_COMPIN.Text
                    DR!AGE2_INFERT_HIS = TXT_AGE2.Text
                    DR!INFO2_INFERT_HIS = TXT_INFO2.Text
                    DR!STAT_INFERT_HIS = True
                    DT.Rows.Add(DR)
                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    MessageBox.Show("THE PERSONAL HISTORY INFORMATION HAS BEEN SUCCESSFULLY SAVED", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                    TXT_NAME_PA.Select()
                    Exit Sub
                End If
                If TXT_COMPIN.Text = "" Then
                    MessageBox.Show("PLEASE ENTER Complaint FOR PATION ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_COMPIN.Select()
                    Exit Sub
                End If
                If TXT_AGE2.Text = "" Then
                    MessageBox.Show("PLEASE ENTER Age Husband FOR PATION ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_AGE2.Select()
                    Exit Sub
                End If
                '=======================================================================================

                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM  INFERTILITY_HISTORY WHERE CODE_INFERT_HIS = '" & TXT_CODE.Text & "' ", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count = 0 Then
                    MessageBox.Show("THE PERSONAL HISTORY IS NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim DR = DT.Rows(0)
                    DR!CODE_INFERT_HIS = TXT_CODE.Text
                    DR!PA_CODE_INFERT_HIS = TXT_PA_CODE.Text
                    DR!DATE_MARED_INFERT_HIS = TXT_DATE_MARRIED.Value
                    DR!COMPIN_INFERT_HIS = TXT_COMPIN.Text
                    DR!AGE2_INFERT_HIS = TXT_AGE2.Text
                    DR!INFO2_INFERT_HIS = TXT_INFO2.Text
                    DR!STAT_INFERT_HIS = True

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

                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM  INFERTILITY_HISTORY WHERE CODE_INFERT_HIS = '" & TXT_CODE.Text & "' ", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count = 0 Then
                    MessageBox.Show("THE PERSONAL HISTORY IS NOT FOUND", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim DR = DT.Rows(0)

                    DR!STAT_INFERT_HIS = False

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
        DA = New SqlClient.SqlDataAdapter("SELECT * FROM INFERTILITY_HISTORY_V WHERE STAT_INFERT_HIS='TRUE' AND PA_NAME LIKE '%" & TXT_SEARCH.Text & "%'", SqlConn)
        DA.Fill(DT)
        DataGridView1.DataSource = DT.DefaultView
    End Sub
    Sub FILL_PATION()
        TXT_NAME_PA.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE STAT='TRUE' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_NAME_PA.Items.Add(DT.Rows(I).Item("PA_NAME"))
        Next
    End Sub

    Private Sub TXT_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_NAME_PA.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME='" & TXT_NAME_PA.Text & "'", SqlConn)
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
            TXT_NAME_PA.Text = DT.Rows(I).Item("PA_NAME")
            TXT_AGE.Text = DT.Rows(I).Item("PA_AGE")
            TXT_NAME2.Text = DT.Rows(I).Item("PA_NAME2")
        Next
    End Sub
    Sub FILL_COMPLAINT()
        TXT_COMPIN.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM NESA_SHKWA WHERE STAT_NESA_SHKWA='TRUE' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_COMPIN.Items.Add(DT.Rows(I).Item("NAME_NESA_SHKWA"))
        Next
    End Sub

    Private Sub HISTORY_ENGAB_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.S AndAlso e.Control Then
            BTN_SAVE_Click(sender, e)
        End If
        If e.KeyCode = Keys.E AndAlso e.Control Then
            BTN_EDIT_Click(sender, e)
        End If

    End Sub
End Class