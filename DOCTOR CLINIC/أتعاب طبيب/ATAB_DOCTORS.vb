Public Class ATAB_DOCTORS
    Dim ARABIC As New ClassConvertNO

    Sub SHOW_DETA(CODE_)
        '=========== ربط رأس الفاتورة =============
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM OUT_MASROUF WHERE OUT_CODE ='" & CODE_ & "'", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("يرجى التأكد من كود الأيصال", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!OUT_CODE
            TXT_DATE.Text = DR!OUT_DATE
            KHAZINA_CODE.Text = DR!CODE_KHAZINA
            TXT_DOCTOR.Text = DR!OUT_TYPE
            USER_ADD.Text = DR!OUT_USER_ADD
            DATE_ADD.Text = DR!OUT_DATE_ADD
            TIME_ADD.Text = DR!OUT_TIME_ADD

            EDITBTN.Enabled = True
            SAVEBTN.Enabled = False
            TIMEREDIT.Enabled = True
            TIMERADD.Enabled = False

        End If
    End Sub

    Sub FILL_DOCTOR()
        TXT_DOCTOR.Text = ""
        TXT_DOCTOR_CODE.Text = ""
        TXT_DOCTOR.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORS WHERE STAT='TRUE' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_DOCTOR.Items.Add(DT.Rows(I).Item("DO_NAME"))
        Next
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
    Sub FILL_KHAZINA_CODE()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            KHAZINA_CODE.Text = DT.Rows(I).Item("KH_CODE")
        Next
    End Sub
    Private Sub KHAZINA_CODE_TextChanged(sender As Object, e As EventArgs) Handles KHAZINA_CODE.TextChanged
        FILL_KHAZINA()
    End Sub
    Sub FILL_KHAZINA()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA WHERE STAT='TRUE' AND KHAZINA_CODE ='" & KHAZINA_CODE.Text & "' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            KHAZINA_NAME.Text = DT.Rows(I).Item("KHAZINA_NAME")
        Next
    End Sub
    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles NEWBTN.Click
        FILL_KHAZINA_CODE()
        EDITBTN.Enabled = False
        SAVEBTN.Enabled = True
        TIMERADD.Enabled = True
        TIMEREDIT.Enabled = False
        FILL_KHAZINA()
        '""""""""""""""" الترقيم التلقائي """"""""""""""
        TXT_CODE.Text = CODE_GENE("OUT_MASROUF", "ID") + 1
        '""""""""""""""""""""""""""""""
        FILL_DOCTOR()
        TXT_TYPEMONY.Text = ""
        TXT_DATE.Text = Date.Today
        ACTIVE_DOCTOR_Click(sender, e)
    End Sub

    Private Sub TXT_DOCTOR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_DOCTOR.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORS WHERE  DO_NAME='" & TXT_DOCTOR.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_DOCTOR_CODE.Text = DT.Rows(I).Item("DO_CODE")
            TXT_TYPEMONY.Text = DT.Rows(I).Item("DO_TYPEYMONY")
        Next
        ' ACTIVE_DOCTOR_Click(sender, e)
        If TXT_TYPEMONY.Text = "يومي" Then

        End If
    End Sub

    Private Sub ATAB_DOCTORS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEWBTN_Click(sender, e)
    End Sub

    Private Sub ACTIVE_DOCTOR_Click(sender As Object, e As EventArgs) Handles ACTIVE_DOCTOR.Click
        Dim KARMA As String
        KARMA = "SELECT * FROM BADR_V2 WHERE DATE_HAGEZ='" & TXT_DATE.Text & "' AND ADD_STAT='TRUE' AND DOCTORS_CODE='" & TXT_DOCTOR_CODE.Text & "'"
        FILL_DGV(DataGridView1, KARMA)

        Dim TOTAL_ As Double
        For I = 0 To DataGridView1.Rows.Count - 1
            TOTAL_ = Val(TOTAL_) + Val(DataGridView1.Rows(I).Cells(3).Value)
        Next

        TXT_TOTAL.Text = Val(TOTAL_)

        If Val(TXT_TOTAL.Text) > 0 Then
            SAFY_AR.Text = ARABIC.ConvertToArabic(TXT_TOTAL.Text)
        Else
            SAFY_AR.Text = ""
        End If

    End Sub

    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Dispose()
    End Sub

    Private Sub TXT_DOCTOR_CODE_TextChanged(sender As Object, e As EventArgs) Handles TXT_DOCTOR_CODE.TextChanged
        ACTIVE_DOCTOR_Click(sender, e)
    End Sub

    Private Sub TXT_DATE_ValueChanged(sender As Object, e As EventArgs) Handles TXT_DATE.ValueChanged
        ACTIVE_DOCTOR_Click(sender, e)
    End Sub

    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click
        '====================حفظ العيادة=============================

        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("O1").ToString = True Then
                '========= قيود الادخال =======================
                If TXT_TOTAL.Text < 1 Then
                    MessageBox.Show("يرجى التأكد من التاريخ حيث ان الطبيب ليس له اتعاب فى ذلك اليوم ", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_DOCTOR.Select()
                    Exit Sub
                End If

                Dim REEMDT As New DataTable
                Dim REEMDA As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA_DT WHERE KHAZINA_DATE='" & TXT_DATE.Text & "' AND CODE_DT2='" & TXT_DOCTOR.Text & "'", SqlConn)
                REEMDA.Fill(REEMDT)

                If REEMDT.Rows.Count > 0 Then
                    MessageBox.Show("يوجد أيصال أتعاب اخر لهذا الطبيب اليوم، يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    '================= تخزين بيانات الصنف في قاعدة البيانات =============
                    Dim DT As New DataTable
                    Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM OUT_MASROUF WHERE OUT_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                    DA.Fill(DT)
                    If DT.Rows.Count > 0 Then
                        MessageBox.Show("يوجد أيصال أخر لهذا المصروف اليوم، يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        '""""""""""""""" الترقيم التلقائي """"""""""""""
                        TXT_CODE.Text = CODE_GENE("OUT_MASROUF", "ID") + 1
                        '""""""""""""""""""""""""""""""
                        Dim DR = DT.NewRow
                        DR!OUT_CODE = TXT_CODE.Text
                        DR!OUT_DATE = TXT_DATE.Text
                        DR!OUT_TYPE = TXT_DOCTOR.Text
                        DR!CODE_KHAZINA = KHAZINA_CODE.Text
                        DR!OUT_TOTAL = TXT_TOTAL.Text
                        DR!OUT_DIS = "0"
                        DR!OUT_SAFY = TXT_TOTAL.Text
                        DR!OUT_SAFY_AR = SAFY_AR.Text
                        DR!OUT_STAT = True
                        DR!OUT_USER_ADD = USER_ADD.Text
                        DR!OUT_DATE_ADD = DATE_ADD.Text
                        DR!OUT_TIME_ADD = TIME_ADD.Text
                        DR!OUT_USER_EDIT = "0"
                        DR!OUT_DATE_EDIT = "0"
                        DR!OUT_TIME_EDIT = "0"

                        DT.Rows.Add(DR)
                        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                        DA.Update(DT)
                    End If
                    '============================== أضافة تفاصيل الايصال ========================
                    Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM OUT_DT2_MASROUF", SqlConn)
                    DA1.Fill(DT)
                    For I = 0 To DataGridView1.Rows.Count - 1
                        Dim DR1 = DT.NewRow
                        DR1!OUT_CODE = TXT_CODE.Text
                        DR1!OUT_DATE = TXT_DATE.Text
                        DR1!NAME_ACTION = DataGridView1.Rows(I).Cells(0).Value
                        DR1!COUNT_PA = DataGridView1.Rows(I).Cells(1).Value
                        DR1!ACTION_PRICE = DataGridView1.Rows(I).Cells(2).Value
                        DR1!TOTAL_ACTION = DataGridView1.Rows(I).Cells(3).Value

                        DT.Rows.Add(DR1)
                        Dim CMD_ As New SqlClient.SqlCommandBuilder(DA1)
                        DA1.Update(DT)
                    Next
                    '==========================================================================
                    '============================== أضافة تفاصيل للخزينة ========================
                    Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA_DT", SqlConn)
                    DA2.Fill(DT)
                    Dim DR2 = DT.NewRow
                    DR2!KHAZINA_CODE = KHAZINA_CODE.Text
                    DR2!KHAZINA_DATE = TXT_DATE.Text
                    DR2!CODE_DT = TXT_CODE.Text
                    DR2!CODE_DT2 = TXT_DOCTOR.Text
                    DR2!KHAZINA_NAME_ACTION = "أيصال صرف نقدية رقم " & TXT_CODE.Text & " أتعاب طبيب "
                    DR2!KHAZINA_IN = "0"
                    DR2!KHAZINA_OUT = TXT_TOTAL.Text
                    DR2!MONY_TYPE = "نقدي"
                    DR2!STAT_KHAZINA = True
                    DT.Rows.Add(DR2)
                    Dim CMD2_ As New SqlClient.SqlCommandBuilder(DA2)
                    DA2.Update(DT)

                    '==========================================================================
                    PRINTBTN_Click(sender, e)
                    MessageBox.Show("تمت عملية حفظ بيانات الأيصال بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    NEWBTN_Click(sender, e)
                End If
            Else
                    MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            End If

    End Sub

    Private Sub EDITBTN_Click(sender As Object, e As EventArgs) Handles EDITBTN.Click
        '====================حفظ العيادة=============================

        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("O1").ToString = True Then

                '================= تخزين بيانات الصنف في قاعدة البيانات =============
                Dim DT As New DataTable
                    Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM OUT_MASROUF WHERE OUT_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                    DA.Fill(DT)
                    If DT.Rows.Count = 0 Then
                        MessageBox.Show("يوجد أيصال أخر لهذا المصروف اليوم، يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        Dim DR = DT.Rows(0)
                        DR!OUT_CODE = TXT_CODE.Text
                        DR!OUT_DATE = TXT_DATE.Text
                        DR!OUT_TYPE = TXT_DOCTOR.Text
                        DR!CODE_KHAZINA = KHAZINA_CODE.Text
                        DR!OUT_TOTAL = TXT_TOTAL.Text
                        DR!OUT_DIS = "0"
                        DR!OUT_SAFY = TXT_TOTAL.Text
                        DR!OUT_SAFY_AR = SAFY_AR.Text
                        DR!OUT_STAT = True

                        DR!OUT_USER_EDIT = USER_EDIT.Text
                        DR!OUT_DATE_EDIT = DATE_EDIT.Text
                        DR!OUT_TIME_EDIT = TIME_EDIT.Text

                        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                        DA.Update(DT)
                    End If
                '===========================================حذف تفاصيل الأيصال=====================================
                Dim CMD_DEL As New SqlClient.SqlCommand
                CMD_DEL.Connection = SqlConn
                CMD_DEL.CommandText = "DELETE FROM OUT_DT2_MASROUF WHERE OUT_CODE ='" & TXT_CODE.Text & "'"
                CMD_DEL.ExecuteNonQuery()

                '============================== أضافة تفاصيل الايصال ========================
                Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM OUT_DT2_MASROUF", SqlConn)
                    DA1.Fill(DT)
                    For I = 0 To DataGridView1.Rows.Count - 1
                        Dim DR1 = DT.NewRow
                        DR1!OUT_CODE = TXT_CODE.Text
                        DR1!OUT_DATE = TXT_DATE.Text
                        DR1!NAME_ACTION = DataGridView1.Rows(I).Cells(0).Value
                        DR1!COUNT_PA = DataGridView1.Rows(I).Cells(1).Value
                        DR1!ACTION_PRICE = DataGridView1.Rows(I).Cells(2).Value
                        DR1!TOTAL_ACTION = DataGridView1.Rows(I).Cells(3).Value
                    DT.Rows.Add(DR1)
                    Dim CMD_ As New SqlClient.SqlCommandBuilder(DA1)
                        DA1.Update(DT)
                    Next
                '======================================حذف التفاصيل من الخزينة====================================
                Dim CMD_DEL2 As New SqlClient.SqlCommand
                CMD_DEL2.Connection = SqlConn
                CMD_DEL2.CommandText = "DELETE FROM KHAZINA_DT WHERE CODE_DT ='" & TXT_CODE.Text & "'"
                CMD_DEL2.ExecuteNonQuery()
                '============================== أضافة تفاصيل للخزينة ========================
                Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA_DT", SqlConn)
                    DA2.Fill(DT)
                    Dim DR2 = DT.NewRow
                    DR2!KHAZINA_CODE = KHAZINA_CODE.Text
                    DR2!KHAZINA_DATE = TXT_DATE.Text
                    DR2!CODE_DT = TXT_CODE.Text
                    DR2!CODE_DT2 = TXT_DOCTOR.Text
                    DR2!KHAZINA_NAME_ACTION = "أيصال صرف نقدية رقم " & TXT_CODE.Text & " أتعاب طبيب "
                    DR2!KHAZINA_IN = "0"
                    DR2!KHAZINA_OUT = TXT_TOTAL.Text
                    DR2!MONY_TYPE = "نقدي"
                    DR2!STAT_KHAZINA = True
                    DT.Rows.Add(DR2)
                    Dim CMD2_ As New SqlClient.SqlCommandBuilder(DA2)
                    DA2.Update(DT)

                '==========================================================================
                PRINTBTN_Click(sender, e)
                MessageBox.Show("تمت عملية تعديل بيانات الأيصال بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NEWBTN_Click(sender, e)
                End If
            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

    End Sub

    Private Sub SEARCHBTN_Click(sender As Object, e As EventArgs) Handles SEARCHBTN.Click
        SEARCH_ATAB_DOCTORS.ShowDialog()
    End Sub

    Private Sub PRINTBTN_Click(sender As Object, e As EventArgs) Handles PRINTBTN.Click
        Dim DT As New DataTable
        Dim KARMA As String
        KARMA = "SELECT * FROM BADR_V WHERE DATE_HAGEZ='" & TXT_DATE.Text & "' AND ADD_STAT='TRUE' AND DOCTORS_CODE='" & TXT_DOCTOR_CODE.Text & "'"
        Dim DA As New SqlClient.SqlDataAdapter(KARMA, SqlConn)
        DA.Fill(DT)

        Dim REP As New MALGHE_HAGEZ_ATAB
        REP.SetDataSource(DT)
        Dim FRM As New REPFORALL
        FRM.CrystalReportViewer1.ReportSource = REP
        FRM.ShowDialog()







    End Sub
End Class