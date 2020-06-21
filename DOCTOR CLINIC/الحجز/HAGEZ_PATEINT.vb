Public Class HAGEZ_PATEINT
    Sub SHOW_DETA(CODE_)

        '=========== ربط رأس الفاتورة =============
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ_DOCTOR WHERE ID ='" & CODE_ & "'", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("يرجى التأكد من رقم الحجز ", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_ID.Text = DR!ID
            TXT_CODE.Text = DR!CODE_H
            TXT_DATE.Text = DR!DATE_H
            TXT_CODE_PA.Text = DR!CODE_PA_H
            TXT_TKHASOS_CODE.Text = DR!CODE_TAKH_H
            TXT_DOCTOR_CODE.Text = DR!CODE_DOC_H
            CH_DATE.Checked = DR!CH_DATE_H
            USER_ADD.Text = DR!USER_ADD
            DATE_ADD.Text = DR!DATE_ADD
            TIME_ADD.Text = DR!TIME_ADD
            BTN_EDIT.Enabled = True
            BTN_SAVE.Enabled = False
            TIMEREDIT.Enabled = True
            TIMERADD.Enabled = False
            CODE_TIMER.Enabled = False
        End If
    End Sub
    Private Sub BTN_NEW_Click(sender As Object, e As EventArgs) Handles BTN_NEW.Click
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is ComboBox Then GroupBox1.Controls(I).Text = ""
        Next
        TXT_DATE.Text = Date.Today
        BTN_EDIT.Enabled = False
        BTN_SAVE.Enabled = True
        TIMERADD.Enabled = True
        CODE_TIMER.Enabled = True
        TIMEREDIT.Enabled = False
        TXT_ID.Text = CODE_GENE("HAGEZ_DOCTOR", "ID") + 1
        '=========================================
        PATIENTDATA.Clear()
        PATIENTTableAdapter.Fill(PATIENTDATA.PATIENT)
        PA_NAME.Text = ""
        PA_NAME.Select()
        FILL_TKHASOS()
    End Sub

    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        If PA_NAME.Text = "" Then
            MessageBox.Show("برجاء ادخال اسم المريض", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PA_NAME.Select()
            Exit Sub
        End If
        If TXT_TKHSOS.Text = "" Then
            MessageBox.Show("برجاء ادخال العيادة  ", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TXT_TKHSOS.Select()
            Exit Sub
        End If
        If TXT_DOCTOR.Text = "" Then
            MessageBox.Show("برجاء ادخال الطبيب المعالج ", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TXT_DOCTOR.Select()
            Exit Sub
        End If
        '================= تخزين بيانات الصنف في قاعدة البيانات =============
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM  HAGEZ_DOCTOR WHERE CODE_PA_H = '" & TXT_CODE_PA.Text & "'  AND DATE_H = '" & TXT_DATE.Text & "' AND CODE_DOC_H = '" & TXT_DOCTOR_CODE.Text & "'  ", SqlConn)

        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            MessageBox.Show("يوجد حجز لنفس المريض اليوم ، يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim DR = DT.NewRow
            DR!CODE_H = TXT_CODE.Text
            DR!DATE_H = TXT_DATE.Text
            DR!CODE_PA_H = TXT_CODE_PA.Text
            DR!CODE_DOC_H = TXT_DOCTOR_CODE.Text
            DR!CODE_TAKH_H = TXT_TKHASOS_CODE.Text
            DR!CH_DATE_H = CH_DATE.Checked
            DR!USER_ADD = USER_ADD.Text
            DR!DATE_ADD = DATE_ADD.Text
            DR!TIME_ADD = TIME_ADD.Text
            DR!USER_EDIT = "0"
            DR!DATE_EDIT = "0"
            DR!TIME_EDIT = "0"

            DT.Rows.Add(DR)
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            MessageBox.Show("تمت عملية حفظ بيانات الحجز بنجاح ورقم الحجز هو " & ">>>> " & TXT_CODE.Text, "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BTN_NEW_Click(sender, e)
        End If
    End Sub

    Private Sub BTN_EDIT_Click(sender As Object, e As EventArgs) Handles BTN_EDIT.Click
        If PA_NAME.Text = "" Then
            MessageBox.Show("برجاء ادخال اسم المريض", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PA_NAME.Select()
            Exit Sub
        End If
        If TXT_TKHSOS.Text = "" Then
            MessageBox.Show("برجاء ادخال العيادة  ", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TXT_TKHSOS.Select()
            Exit Sub
        End If
        If TXT_DOCTOR.Text = "" Then
            MessageBox.Show("برجاء ادخال الطبيب المعالج ", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TXT_DOCTOR.Select()
            Exit Sub
        End If
        '================= تخزين بيانات الصنف في قاعدة البيانات =============
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ_DOCTOR WHERE ID = '" & TXT_ID.Text & "' ", SqlConn)
        DA.Fill(DT)

        Dim DR = DT.Rows(0)
        DR!CODE_H = TXT_CODE.Text
        DR!DATE_H = TXT_DATE.Text
        DR!CODE_PA_H = TXT_CODE_PA.Text
        DR!CODE_DOC_H = TXT_DOCTOR_CODE.Text
        DR!CODE_TAKH_H = TXT_TKHASOS_CODE.Text
        DR!CH_DATE_H = CH_DATE.Checked

        DR!USER_ADD = USER_ADD.Text
        DR!DATE_ADD = DATE_ADD.Text
        DR!TIME_ADD = TIME_ADD.Text
        DR!USER_EDIT = "0"
        DR!DATE_EDIT = "0"
        DR!TIME_EDIT = "0"


        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)

        MessageBox.Show("تمت عملية تعديل بيانات الحجز بنجاح ورقم الحجز هو " & " ( " & TXT_CODE.Text & " ) ", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        BTN_NEW_Click(sender, e)


    End Sub

    Private Sub BTN_DELET_Click(sender As Object, e As EventArgs) Handles BTN_DELET.Click
        If TXT_DOCTOR_CODE.Text = "" Then
            MessageBox.Show("برجاء ادخال اسم الطبيب", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TXT_DOCTOR.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        With DT
            .Columns.Add("DATE_H")
            .Columns.Add("CODE_H")
            .Columns.Add("PA_NAME")
            .Columns.Add("DO_TKHSOS")
            .Columns.Add("DO_NAME")
            .Columns.Add("PA_TEL")
            .Columns.Add("PA_CODE2")

        End With
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(I).Cells(0).Value <> Nothing Then
                DT.Rows.Add(TXT_DATE.Text, DataGridView1.Rows(I).Cells(0).Value, DataGridView1.Rows(I).Cells(1).Value, DataGridView1.Rows(I).Cells(2).Value, DataGridView1.Rows(I).Cells(3).Value, DataGridView1.Rows(I).Cells(5).Value, DataGridView1.Rows(I).Cells(6).Value)
            End If
        Next
        Dim REP As New HAGEZ_CRS
        REP.SetDataSource(DT)
        Dim FRM As New HAGEZ_REP
        FRM.CrystalReportViewer1.ReportSource = REP
        FRM.ShowDialog()
    End Sub

    Private Sub BTN_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_CLOSE.Click
        Me.Close()
    End Sub

    Private Sub HAGEZ_PATEINT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BTN_NEW_Click(sender, e)
    End Sub

    Private Sub ADD_PA_Click(sender As Object, e As EventArgs) Handles ADD_PA.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("a").ToString = True Then
                '===========================================================
                PATIENT.ShowDialog()
                '=============================================================
            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
    Private Sub TIMERADD_Tick(sender As Object, e As EventArgs) Handles TIMERADD.Tick
        USER_ADD.Text = HOME.T_USERS.Text
        DATE_ADD.Text = Date.Today
        TIME_ADD.Text = TimeOfDay
        EDITNAMEBT.Visible = False
        USER_EDIT.Visible = False
        DATE_EDIT.Visible = False
        TIME_EDIT.Visible = False
    End Sub

    Private Sub TIMEREDIT_Tick(sender As Object, e As EventArgs) Handles TIMEREDIT.Tick
        EDITNAMEBT.Visible = True
        USER_EDIT.Visible = True
        DATE_EDIT.Visible = True
        TIME_EDIT.Visible = True
        USER_EDIT.Text = HOME.T_USERS.Text
        DATE_EDIT.Text = Date.Today
        TIME_EDIT.Text = TimeOfDay
    End Sub
    Sub FILL_TKHASOS()
        TXT_TKHSOS.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM TKHASOS WHERE STAT='TRUE' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_TKHSOS.Items.Add(DT.Rows(I).Item("TAKH_NAME"))
        Next

    End Sub
    Sub FILL_DOCTOR()
        TXT_DOCTOR.Text = ""
        TXT_DOCTOR_CODE.Text = ""
        TXT_DOCTOR.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORS WHERE STAT='TRUE' AND DO_TKHSOS_CODE = '" & TXT_TKHASOS_CODE.Text & "' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_DOCTOR.Items.Add(DT.Rows(I).Item("DO_NAME"))
        Next
    End Sub
    Private Sub TXT_NAME_PA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PA_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME='" & PA_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_CODE_PA.Text = DT.Rows(I).Item("PA_CODE")
            TXT_TEL.Text = DT.Rows(I).Item("PA_TEL")
            TXT_CODE2.Text = DT.Rows(I).Item("PA_TEL2")

        Next
    End Sub

    Private Sub TXT_CODE_PA_TextChanged(sender As Object, e As EventArgs) Handles TXT_CODE_PA.TextChanged
        Try
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_CODE='" & TXT_CODE_PA.Text & "'", SqlConn)
            DA.Fill(DT)
            For I = 0 To DT.Rows.Count - 1
                PA_NAME.Text = DT.Rows(I).Item("PA_NAME")
                TXT_TEL.Text = DT.Rows(I).Item("PA_TEL")
                TXT_CODE2.Text = DT.Rows(I).Item("PA_CODE2")
            Next
        Catch ex As Exception

        End Try




    End Sub

    Private Sub TXT_TKHSOS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_TKHSOS.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM TKHASOS WHERE TAKH_NAME='" & TXT_TKHSOS.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_TKHASOS_CODE.Text = DT.Rows(I).Item("TAKH_CODE")
        Next
        FILL_DOCTOR()
    End Sub

    Private Sub TXT_TKHASOS_CODE_TextChanged(sender As Object, e As EventArgs) Handles TXT_TKHASOS_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM TKHASOS WHERE TAKH_CODE='" & TXT_TKHASOS_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_TKHSOS.Text = DT.Rows(I).Item("TAKH_NAME")
        Next
    End Sub

    Private Sub TXT_DOCTOR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_DOCTOR.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORS WHERE  DO_NAME='" & TXT_DOCTOR.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_DOCTOR_CODE.Text = DT.Rows(I).Item("DO_CODE")
        Next

        FILL_DGV(DataGridView1, "SELECT * FROM HAGEZ_DOCTOR,DOCTORS,PATIENT WHERE CODE_PA_H = PA_CODE AND CODE_DOC_H = DO_CODE AND CODE_DOC_H = '" & TXT_DOCTOR_CODE.Text & "'  AND DATE_H = '" & TXT_DATE.Text & "' ORDER BY HAGEZ_DOCTOR.ID ")
        '""""""""""""""" الترقيم التلقائي """"""""""""""
        Dim DT00 As New DataTable
        Dim DA00 As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ_DOCTOR WHERE CODE_DOC_H = '" & TXT_DOCTOR_CODE.Text & "'  AND DATE_H = '" & TXT_DATE.Text & "' ORDER BY ID ", SqlConn)
        DA00.Fill(DT00)
        If DT00.Rows.Count <> 0 Then
            Dim I0 = DT00.Rows.Count - 1
            TXT_CODE.Text = Val(DT00.Rows(I0).Item("CODE_H")) + 1
        Else
            TXT_CODE.Text = "1"
        End If

        '""""""""""""""""""""""""""""""
    End Sub

    Private Sub TXT_DOCTOR_CODE_TextChanged(sender As Object, e As EventArgs) Handles TXT_DOCTOR_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORS WHERE DO_CODE='" & TXT_DOCTOR_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_DOCTOR.Text = DT.Rows(I).Item("DO_NAME")
        Next
    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(5).Value = "عرض"
            Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        For Each ROW As DataGridViewRow In DataGridView1.Rows
            If DataGridView1(5, DataGridView1.CurrentRow.Index).Selected = True Then
                SHOW_DETA(DataGridView1.CurrentRow.Cells(0).Value)
            End If
        Next
    End Sub

    Private Sub CH_DATE_CheckedChanged(sender As Object, e As EventArgs) Handles CH_DATE.CheckedChanged
        If CH_DATE.Checked = False Then
            TXT_DATE.Enabled = True
        Else
            TXT_DATE.Text = Date.Today
            TXT_DATE.Enabled = False

        End If
    End Sub

    Private Sub TXT_DATE_ValueChanged(sender As Object, e As EventArgs) Handles TXT_DATE.ValueChanged

        FILL_DGV(DataGridView1, "SELECT * FROM HAGEZ_DOCTOR,DOCTORS,PATIENT WHERE CODE_PA_H = PA_CODE AND CODE_DOC_H = DO_CODE AND CODE_DOC_H = '" & TXT_DOCTOR_CODE.Text & "'  AND DATE_H = '" & TXT_DATE.Text & "' ORDER BY HAGEZ_DOCTOR.ID ")
        '""""""""""""""" الترقيم التلقائي """"""""""""""
        Dim DT00 As New DataTable
        Dim DA00 As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ_DOCTOR WHERE CODE_DOC_H = '" & TXT_DOCTOR_CODE.Text & "'  AND DATE_H = '" & TXT_DATE.Text & "' ORDER BY ID ", SqlConn)
        DA00.Fill(DT00)
        If DT00.Rows.Count <> 0 Then
            Dim I0 = DT00.Rows.Count - 1
            TXT_CODE.Text = Val(DT00.Rows(I0).Item("CODE_H")) + 1
        Else
            TXT_CODE.Text = "1"
        End If

        '""""""""""""""""""""""""""""""
    End Sub

    Private Sub CODE_TIMER_Tick(sender As Object, e As EventArgs) Handles CODE_TIMER.Tick
        Dim DT00 As New DataTable
        Dim DA00 As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ_DOCTOR WHERE CODE_DOC_H = '" & TXT_DOCTOR_CODE.Text & "'  AND DATE_H = '" & TXT_DATE.Text & "' ORDER BY ID ", SqlConn)
        DA00.Fill(DT00)
        If DT00.Rows.Count <> 0 Then
            Dim I0 = DT00.Rows.Count - 1
            TXT_CODE.Text = Val(DT00.Rows(I0).Item("CODE_H")) + 1
        Else
            TXT_CODE.Text = "1"
        End If

    End Sub
End Class