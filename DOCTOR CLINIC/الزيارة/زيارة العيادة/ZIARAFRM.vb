Public Class ZIARAFRM
    Private Sub BTN_EXIT_Click(sender As Object, e As EventArgs) Handles BTN_EXIT.Click
        Me.Close()
    End Sub

    Private Sub TXT_PA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_PA.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME='" & TXT_PA.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA_CODE.Text = DT.Rows(I).Item("PA_CODE")
            TXT_PA_TEL.Text = DT.Rows(I).Item("PA_TEL")
            TXT_PA_TEL2.Text = DT.Rows(I).Item("PA_TEL2")
        Next

    End Sub

    Private Sub TXT_PA_CODE_TextChanged(sender As Object, e As EventArgs) Handles TXT_PA_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_CODE='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA.Text = DT.Rows(I).Item("PA_NAME")
            TXT_PA_TEL.Text = DT.Rows(I).Item("PA_TEL")
            TXT_PA_TEL2.Text = DT.Rows(I).Item("PA_TEL2")
        Next

        Dim DT1 As New DataTable
        Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ_DOCTOR WHERE CODE_PA_H = '" & TXT_PA_CODE.Text & "'", SqlConn)
        DA1.Fill(DT1)
        For I1 = 0 To DT1.Rows.Count - 1
            TXT_DOC_CODE.Text = DT1.Rows(I1).Item("CODE_DOC_H")
            TXT_TKHSOS_CODE.Text = DT1.Rows(I1).Item("CODE_TAKH_H")
            TXT_CODE.Text = DT1.Rows(I1).Item("CODE_H")
        Next
    End Sub

    Private Sub TXT_DOC_CODE_TextChanged(sender As Object, e As EventArgs) Handles TXT_DOC_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORS WHERE DO_CODE='" & TXT_DOC_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_DOC.Text = DT.Rows(I).Item("DO_NAME")
        Next
    End Sub

    Private Sub TXT_TKHSOS_CODE_TextChanged(sender As Object, e As EventArgs) Handles TXT_TKHSOS_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM TKHASOS WHERE TAKH_CODE='" & TXT_TKHSOS_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_TKHSOS.Text = DT.Rows(I).Item("TAKH_NAME")
        Next
    End Sub
    Sub FILL_PATIENT()
        TXT_PA.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT,HAGEZ_DOCTOR WHERE CODE_PA_H = PA_CODE AND PATIENT.STAT='TRUE' AND DATE_H = '" & DATE_TODAY.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA.Items.Add(DT.Rows(I).Item("PA_NAME"))
        Next
    End Sub

    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        FILL_PATIENT()
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is ComboBox Then GroupBox1.Controls(I).Text = ""
        Next
        TXT_CODE.Text = ""
        DATE_TODAY.Text = Date.Today
        FILL_DGV(DataGridView1, "SELECT * FROM HAGEZ_DOCTOR_DT,PATIENT,DOCTORS WHERE CODE_PA_H_A = PA_CODE AND CODE_DOC_H_A = DO_CODE AND DATE_H_A = '" & DATE_TODAY.Text & "'")
    End Sub

    Private Sub ZIARAFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTN_NEW_Click(sender, e)
        'FILL_DGV(DataGridView1, "SELECT * FROM HAGEZ_DOCTOR_DT,PATIENT,DOCTORS WHERE CODE_PA_H_A = PA_CODE AND CODE_DOC_H_A = DO_CODE AND DATE_H_A = '" & DATE_TODAY.Text & "'")
    End Sub

    Private Sub DATE_TODAY_ValueChanged(sender As Object, e As EventArgs) Handles DATE_TODAY.ValueChanged
        FILL_PATIENT()
        FILL_DGV(DataGridView1, "SELECT * FROM HAGEZ_DOCTOR_DT,PATIENT,DOCTORS WHERE CODE_PA_H_A = PA_CODE AND CODE_DOC_H_A = DO_CODE AND DATE_H_A = '" & DATE_TODAY.Text & "'")
    End Sub
    Private Sub BTN_ACTIVE_Click(sender As Object, e As EventArgs) Handles BTN_ACTIVE.Click

        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("يرجى ادخال اسم المريض", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA.Select()
            Exit Sub
        End If
        '===== اجراء تخزين اسم الوحدة ==========
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ_DOCTOR_DT WHERE CODE_PA_H_A = '" & TXT_PA_CODE.Text & "'AND DATE_H_A = '" & DATE_TODAY.Text & "' AND TYPE_A ='الغاء' or TYPE_A ='تأكيد' ", SqlConn)
        DA.Fill(DT)

        If DT.Rows.Count > 0 Then
            MessageBox.Show("المريض تم تأكيد حضورة من قبل", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.NewRow
            DR!CODE_H_A = TXT_CODE.Text
            DR!CODE_PA_H_A = TXT_PA_CODE.Text
            DR!CODE_TKH_H_A = TXT_TKHSOS_CODE.Text
            DR!CODE_DOC_H_A = TXT_DOC_CODE.Text
            DR!DATE_H_A = DATE_TODAY.Text
            DR!TYPE_A = "تأكيد"
            DT.Rows.Add(DR)
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            '===================================================================

            MessageBox.Show("تمت عملية تأكيد الحضور بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BTN_NEW_Click(sender, e)
        End If

    End Sub

    Private Sub BTN_NOACTIVE_Click(sender As Object, e As EventArgs) Handles BTN_NOACTIVE.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("يرجى ادخال اسم المريض", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA.Select()
            Exit Sub
        End If
        '===== اجراء تخزين اسم الوحدة ==========
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ_DOCTOR_DT WHERE CODE_PA_H_A = '" & TXT_PA_CODE.Text & "'AND DATE_H_A = '" & DATE_TODAY.Text & "' AND TYPE_A ='الغاء' or TYPE_A ='تأكيد' ", SqlConn)
        DA.Fill(DT)

        If DT.Rows.Count > 0 Then
            MessageBox.Show("المريض تم تأكيد حضورة من قبل", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.NewRow
            DR!CODE_H_A = TXT_CODE.Text
            DR!CODE_PA_H_A = TXT_PA_CODE.Text
            DR!CODE_TKH_H_A = TXT_TKHSOS_CODE.Text
            DR!CODE_DOC_H_A = TXT_DOC_CODE.Text
            DR!DATE_H_A = DATE_TODAY.Text
            DR!TYPE_A = "الغاء"
            DT.Rows.Add(DR)
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            '===================================================================

            MessageBox.Show("تمت عملية الغاء الحجز بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BTN_NEW_Click(sender, e)
        End If
    End Sub

    Private Sub CALL_BTN_Click(sender As Object, e As EventArgs) Handles CALL_BTN.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("يرجى ادخال اسم المريض", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA.Select()
            Exit Sub
        End If
        If TXT_CALL_INFO.Text = "" Then
            MessageBox.Show("يرجى ادخال ما تم فى المكالمة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_CALL_INFO.Select()
            Exit Sub
        End If
        '===== اجراء تخزين اسم الوحدة ==========
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ_DOCTOR_DT WHERE CODE_PA_H_A = '" & TXT_PA_CODE.Text & "'AND DATE_H_A = '" & DATE_TODAY.Text & "' AND TYPE_A ='الغاء' or TYPE_A ='تأكيد' ", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            MessageBox.Show("المريض تم تأكيد حضورة من قبل", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.NewRow
            DR!CODE_H_A = TXT_CODE.Text
            DR!CODE_PA_H_A = TXT_PA_CODE.Text
            DR!CODE_TKH_H_A = TXT_TKHSOS_CODE.Text
            DR!CODE_DOC_H_A = TXT_DOC_CODE.Text
            DR!DATE_H_A = DATE_TODAY.Text
            DR!TYPE_A = TXT_CALL_INFO.Text & " " & Date.Now
            DT.Rows.Add(DR)
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            '===================================================================

            MessageBox.Show("تمت عملية الأتصال بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BTN_NEW_Click(sender, e)
        End If
    End Sub

    Private Sub SEARCH_BTN_Click(sender As Object, e As EventArgs) Handles SEARCH_BTN.Click
        If TXT_PA.Text = "" Then
            MessageBox.Show("يرجى ادخال اسم المريض", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter
        DT.Clear()
        DA = New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ_DOCTOR_DT,PATIENT,DOCTORS WHERE CODE_PA_H_A = PA_CODE AND CODE_DOC_H_A = DO_CODE AND DATE_H_A = '" & DATE_TODAY.Text & "' AND PA_NAME LIKE '%" & TXT_PA.Text & "%'", SqlConn)
        DA.Fill(DT)
        DataGridView1.DataSource = DT.DefaultView
    End Sub
End Class