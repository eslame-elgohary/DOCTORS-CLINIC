Public Class DOF3A_PATION_FRM
    Dim ARABIC As New ClassConvertNO
    Sub SHOW_DETA(CODE_)
        '=========== ربط رأس الفاتورة =============
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_MAML WHERE ADD_CODE ='" & CODE_ & "'", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("يرجى التأكد من كود الأيصال", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!ADD_CODE
            TXT_DATE.Text = DR!ADD_DATE
            KHAZINA_CODE.Text = DR!CODE_KHAZINA
            PA_CODE.Text = DR!ADD_PA_CODE
            TXT_MONY.Text = DR!ADD_SAFY

            USER_ADD.Text = DR!ADD_USER_ADD
            DATE_ADD.Text = DR!ADD_DATE_ADD
            TIME_ADD.Text = DR!ADD_TIME_ADD

            DELETBTN.Enabled = True
            EDITBTN.Enabled = True
            SAVEBTN.Enabled = False
            TIMEREDIT.Enabled = True
            TIMERADD.Enabled = False
            TXT_RASED.Text = Val(Val(TXT_ALL.Text) - Val(TXT_ADD.Text)) + Val(TXT_MONY.Text)
        End If
    End Sub
    Private Sub DOF3A_PATION_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEWBTN_Click(sender, e)
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
    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles NEWBTN.Click
        TIMERADD.Enabled = True
        TIMEREDIT.Enabled = False
        '""""""""""""""" تنظيف الشاشة """""""""""""
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is ComboBox Then GroupBox1.Controls(I).Text = ""
        Next

        '""""""""""""""" الترقيم التلقائي """"""""""""""
        TXT_CODE.Text = CODE_GENE("ADD_MONY_MAML", "ID") + 1
        '""""""""""""""""""""""""""""""
        EDITBTN.Enabled = False
        DELETBTN.Enabled = False
        SAVEBTN.Enabled = True

        FILL_KHAZINA_CODE()
        PA_NAME.Select()
        FILL_KHAZINA()
        PATIENTDATA.Clear()
        PATIENTTableAdapter.Fill(PATIENTDATA.PATIENT)
    End Sub
    Sub FILL_KHAZINA_CODE()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            KHAZINA_CODE.Text = DT.Rows(I).Item("KH_CODE")
        Next
    End Sub

    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click

        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("M1").ToString = True Then
                '========= قيود الادخال =======================
                If PA_NAME.Text = "" Then
                    MessageBox.Show("برجاء ادخال اسم المريض", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PA_NAME.Select()
                    Exit Sub
                End If
                If TXT_MONY.Text = "" Then
                    MessageBox.Show("برجاء ادخال المبلغ المستلم من المريض  ", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TXT_MONY.Select()
                    Exit Sub
                End If
                '================= تخزين بيانات الصنف في قاعدة البيانات =============
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_MAML WHERE ADD_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count > 0 Then
                    If MessageBox.Show("يوجد أيصال أخر لهذا المريض اليوم،هل تريد الأضافة", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then Exit Sub
                Else
                    '""""""""""""""" الترقيم التلقائي """"""""""""""
                    TXT_CODE.Text = CODE_GENE("ADD_MONY_MAML", "ID") + 1
                    '""""""""""""""""""""""""""""""
                    Dim DR = DT.NewRow
                    DR!ADD_CODE = TXT_CODE.Text
                    DR!ADD_CODE2 = "0"
                    DR!ADD_DATE = TXT_DATE.Text
                    DR!ADD_TYPE = "دفعات"
                    DR!CODE_KHAZINA = KHAZINA_CODE.Text
                    DR!ADD_PA_CODE = PA_CODE.Text
                    DR!ADD_MAML_CODE = "0"
                    DR!ADD_TOTAL = TXT_MONY.Text
                    DR!ADD_DIS = "0"
                    DR!ADD_SAFY = TXT_MONY.Text
                    DR!ADD_SAFY_AR = SAFY_AR.Text
                    DR!ADD_STAT = True
                    DR!ADD_USER_ADD = USER_ADD.Text
                    DR!ADD_DATE_ADD = DATE_ADD.Text
                    DR!ADD_TIME_ADD = TIME_ADD.Text
                    DR!ADD_USER_EDIT = "0"
                    DR!ADD_DATE_EDIT = "0"
                    DR!ADD_TIME_EDIT = "0"

                    DT.Rows.Add(DR)
                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                End If
                '============================== أضافة تفاصيل الايصال ========================
                Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_DT_MAML", SqlConn)
                DA1.Fill(DT)

                Dim DR1 = DT.NewRow
                DR1!ADD_CODE = TXT_CODE.Text
                DR1!ADD_DATE = TXT_DATE.Text
                DR1!NAME_MAML = ""
                DR1!MID = ""
                DR1!CODE_MAML = ""
                DR1!CODE_THLEL = ""
                DR1!NAME_THLEL = ""
                DR1!PRICE_THLEL = ""
                DR1!STAT_DT = True
                DT.Rows.Add(DR1)
                Dim CMD_ As New SqlClient.SqlCommandBuilder(DA1)
                DA1.Update(DT)

                '============================== أضافة تفاصيل للخزينة ========================
                Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA_DT", SqlConn)
                DA2.Fill(DT)
                Dim DR2 = DT.NewRow
                DR2!KHAZINA_CODE = KHAZINA_CODE.Text
                DR2!KHAZINA_DATE = TXT_DATE.Text
                DR2!CODE_DT = TXT_CODE.Text
                DR2!CODE_DT2 = "2"
                DR2!KHAZINA_NAME_ACTION = "أيصال أستلام نقدية رقم " & TXT_CODE.Text & " دفعة من مريض "
                DR2!KHAZINA_IN = TXT_MONY.Text
                DR2!KHAZINA_OUT = "0"
                DR2!MONY_TYPE = "نقدي"
                DR2!STAT_KHAZINA = True
                DT.Rows.Add(DR2)
                Dim CMD2_ As New SqlClient.SqlCommandBuilder(DA2)
                DA2.Update(DT)
                '==========================================================================
                Dim DA3 As New SqlClient.SqlDataAdapter("SELECT * FROM PATION_MONY_DT", SqlConn)
                DA3.Fill(DT)
                Dim DR3 = DT.NewRow
                DR3!ADD_CODE = TXT_CODE.Text
                DR3!ADD_CODE2 = "0"
                DR3!ADD_DATE = TXT_DATE.Text
                DR3!PA_CODE = PA_CODE.Text
                DR3!ACTION_NAME = "دفعة من مريض بالأيصال رقم " & TXT_CODE.Text
                DR3!SAFY_MAML = "0"
                DR3!ADD_MAML = TXT_MONY.Text
                DR3!BAKY_MAML = "0"
                DR3!STAT = True
                DT.Rows.Add(DR3)
                Dim CMD3 As New SqlClient.SqlCommandBuilder(DA3)
                DA3.Update(DT)
                '==========================================================================
                PRINTBTN_Click(sender, e)
                MessageBox.Show("تمت عملية حفظ بيانات الأيصال بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NEWBTN_Click(sender, e)

            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub EDITBTN_Click(sender As Object, e As EventArgs) Handles EDITBTN.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("M2").ToString = True Then
                '========= قيود الادخال =======================
                If PA_NAME.Text = "" Then
                    MessageBox.Show("برجاء ادخال اسم المريض", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PA_NAME.Select()
                    Exit Sub
                End If
                If TXT_MONY.Text = "" Then
                    MessageBox.Show("برجاء ادخال المبلغ المستلم من المريض  ", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TXT_MONY.Select()
                    Exit Sub
                End If

                '================= تخزين بيانات الصنف في قاعدة البيانات =============
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_MAML WHERE ADD_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count = 0 Then
                    MessageBox.Show("يوجد أيصال أخر لهذا المريض اليوم، يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim DR = DT.Rows(0)
                    DR!ADD_CODE = TXT_CODE.Text
                    DR!ADD_CODE2 = "0"
                    DR!ADD_DATE = TXT_DATE.Text
                    DR!ADD_TYPE = "دفعات"
                    DR!CODE_KHAZINA = KHAZINA_CODE.Text
                    DR!ADD_PA_CODE = PA_CODE.Text
                    DR!ADD_MAML_CODE = "0"
                    DR!ADD_TOTAL = TXT_MONY.Text
                    DR!ADD_DIS = "0"
                    DR!ADD_SAFY = TXT_MONY.Text
                    DR!ADD_SAFY_AR = SAFY_AR.Text
                    DR!ADD_STAT = True

                    DR!ADD_USER_EDIT = USER_EDIT.Text
                    DR!ADD_DATE_EDIT = DATE_EDIT.Text
                    DR!ADD_TIME_EDIT = TIME_EDIT.Text

                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                End If
                '==========================================================================
                Dim CMD_DEL2 As New SqlClient.SqlCommand
                CMD_DEL2.Connection = SqlConn
                CMD_DEL2.CommandText = "DELETE FROM KHAZINA_DT WHERE CODE_DT ='" & TXT_CODE.Text & "' AND CODE_DT2 = '2' "
                CMD_DEL2.ExecuteNonQuery()
                '============================== أضافة الخزينة ========================
                Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA_DT", SqlConn)
                DA2.Fill(DT)
                Dim DR2 = DT.NewRow
                DR2!KHAZINA_CODE = KHAZINA_CODE.Text
                DR2!KHAZINA_DATE = TXT_DATE.Text
                DR2!CODE_DT = TXT_CODE.Text
                DR2!CODE_DT2 = "2"
                DR2!KHAZINA_NAME_ACTION = "أيصال أستلام نقدية رقم " & TXT_CODE.Text & " دفعة من مريض "
                DR2!KHAZINA_IN = TXT_MONY.Text
                DR2!KHAZINA_OUT = "0"
                DR2!MONY_TYPE = "نقدي"
                DR2!STAT_KHAZINA = True
                DR2!STAT_KHAZINA = True
                DT.Rows.Add(DR2)
                Dim CMD2_ As New SqlClient.SqlCommandBuilder(DA2)
                DA2.Update(DT)
                '===============================================================================
                Dim CMD_DEL3 As New SqlClient.SqlCommand
                CMD_DEL3.Connection = SqlConn
                CMD_DEL3.CommandText = "DELETE FROM PATION_MONY_DT WHERE ADD_CODE ='" & TXT_CODE.Text & "' AND ADD_CODE2 = '0' "
                CMD_DEL3.ExecuteNonQuery()
                '=======================================الحساب===================================
                Dim DA3 As New SqlClient.SqlDataAdapter("SELECT * FROM PATION_MONY_DT", SqlConn)
                DA3.Fill(DT)
                Dim DR3 = DT.NewRow
                DR3!ADD_CODE = TXT_CODE.Text
                DR3!ADD_CODE2 = "0"
                DR3!ADD_DATE = TXT_DATE.Text
                DR3!PA_CODE = PA_CODE.Text
                DR3!ACTION_NAME = "دفعة من مريض بالأيصال رقم " & TXT_CODE.Text
                DR3!SAFY_MAML = "0"
                DR3!ADD_MAML = TXT_MONY.Text
                DR3!BAKY_MAML = "0"
                DR3!STAT = True
                DT.Rows.Add(DR3)
                Dim CMD3 As New SqlClient.SqlCommandBuilder(DA3)
                DA3.Update(DT)
                '==========================================================================
                PRINTBTN_Click(sender, e)
                MessageBox.Show("تمت عملية تعديل بيانات الأيصال بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NEWBTN_Click(sender, e)

            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub DELETBTN_Click(sender As Object, e As EventArgs) Handles DELETBTN.Click

        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("M3").ToString = True Then
                If MessageBox.Show("هل ترغب في حذف بيانات الأيصال ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub
                '================= تخزين بيانات الصنف في قاعدة البيانات =============
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_MAML WHERE ADD_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count = 0 Then
                    MessageBox.Show("يوجد أيصال أخر لهذا المريض اليوم، يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim DR = DT.Rows(0)

                    DR!ADD_STAT = False
                    DR!ADD_USER_EDIT = USER_EDIT.Text
                    DR!ADD_DATE_EDIT = DATE_EDIT.Text
                    DR!ADD_TIME_EDIT = TIME_EDIT.Text

                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                End If

                '=====================================حذف التفاصيل من الأيصال ========================
                Dim DT1 As New DataTable
                Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_DT_MAML WHERE ADD_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                DA1.Fill(DT1)
                Dim DR1 = DT1.Rows(0)

                DR1!STAT_DT = False
                Dim SAVE1 As New SqlClient.SqlCommandBuilder(DA1)
                DA1.Update(DT1)
                '=====================================حذف التفاصيل من الخزينة ========================
                Dim DT2 As New DataTable
                Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA_DT WHERE CODE_DT = '" & TXT_CODE.Text & "'AND CODE_DT2 = '2'", SqlConn)
                DA2.Fill(DT2)
                Dim DR2 = DT2.Rows(0)
                DR2!STAT_KHAZINA = False
                Dim SAVE2 As New SqlClient.SqlCommandBuilder(DA2)
                DA2.Update(DT2)
                '=============================================  حذف من حساب المريض =============================
                Dim DT3 As New DataTable
                Dim DA3 As New SqlClient.SqlDataAdapter("SELECT * FROM PATION_MONY_DT WHERE ADD_CODE ='" & TXT_CODE.Text & "'AND ADD_CODE2 = '0' ", SqlConn)
                DA3.Fill(DT3)
                Dim DR3 = DT3.Rows(0)

                DR3!STAT = False

                Dim CMD3 As New SqlClient.SqlCommandBuilder(DA3)
                DA3.Update(DT3)

                MessageBox.Show("تمت عملية حذف بيانات الأيصال بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NEWBTN_Click(sender, e)
            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub SEARCHBTN_Click(sender As Object, e As EventArgs) Handles SEARCHBTN.Click
        SEARCH_ADD_MONYD.ShowDialog()
    End Sub

    Private Sub PRINTBTN_Click(sender As Object, e As EventArgs) Handles PRINTBTN.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("M4").ToString = True Then
                '===========================================================

                Dim DT As New DataTable
                With DT
                    .Columns.Add("ADD_CODE")
                    .Columns.Add("ADD_DATE")
                    .Columns.Add("ADD_PA_CODE")
                    .Columns.Add("PA_NAME")
                    .Columns.Add("KHAZINA_NAME")
                    .Columns.Add("ADD_SAFY")
                    .Columns.Add("ADD_SAFY_AR")
                End With
                DT.Rows.Add(TXT_CODE.Text, TXT_DATE.Text, PA_CODE.Text, PA_NAME.Text, KHAZINA_NAME.Text, TXT_MONY.Text, SAFY_AR.Text)
                Dim REP As New DOF3A_PATION_CRS
                REP.SetDataSource(DT)
                Dim FRM As New REPFORALL
                FRM.CrystalReportViewer1.ReportSource = REP
                FRM.ShowDialog()
                '=============================================================
            Else
                MessageBox.Show("عفوا ليس لديك صلاحية للطباعة برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Close()
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
    Private Sub PA_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PA_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME='" & PA_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            PA_CODE.Text = DT.Rows(I).Item("PA_CODE")
        Next
        '===================== اجمالى الفواتير ==========================================
        Try
            Dim sql As String = "SELECT coalesce(sum(SAFY_MAML), 0) FROM PATIENT_RASED_VIWE WHERE PA_NAME='" & PA_NAME.Text & "'"
            Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(sql, SqlConn)
            Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
            Dim dt1 As DataTable = New DataTable
            da1.Fill(dt1)
            TXT_ALL.Text = dt1.Rows(0)(0).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
            SqlConn.Close()
        End Try
        '===================== اجمالى الدفعات ========================================
        Try
            Dim sql1 As String = "SELECT coalesce(sum(ADD_MAML), 0) FROM PATIENT_RASED_VIWE WHERE PA_NAME='" & PA_NAME.Text & "'"
            Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand(sql1, SqlConn)
            Dim da11 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
            Dim dt11 As DataTable = New DataTable
            da11.Fill(dt11)
            TXT_ADD.Text = dt11.Rows(0)(0).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
            SqlConn.Close()
        End Try
        '===========================================================
        TXT_RASED.Text = Val(TXT_ALL.Text) - Val(TXT_ADD.Text)
    End Sub

    Private Sub TXT_MONY_TextChanged(sender As Object, e As EventArgs) Handles TXT_MONY.TextChanged
        If TXT_MONY.Text = "" Then
            SAFY_AR.Text = ""
        Else
            SAFY_AR.Text = ARABIC.ConvertToArabic(TXT_MONY.Text)
        End If

    End Sub

    Private Sub PA_CODE_TextChanged(sender As Object, e As EventArgs) Handles PA_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_CODE='" & PA_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            PA_NAME.Text = DT.Rows(I).Item("PA_NAME")
        Next
        '===================== اجمالى الفواتير ==========================================
        Try
            Dim sql As String = "SELECT coalesce(sum(SAFY_MAML), 0) FROM PATIENT_RASED_VIWE WHERE PA_NAME='" & PA_NAME.Text & "'"
            Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(sql, SqlConn)
            Dim da1 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd)
            Dim dt1 As DataTable = New DataTable
            da1.Fill(dt1)
            TXT_ALL.Text = dt1.Rows(0)(0).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
            SqlConn.Close()
        End Try
        '===================== اجمالى الدفعات ========================================
        Try
            Dim sql1 As String = "SELECT coalesce(sum(ADD_MAML), 0) FROM PATIENT_RASED_VIWE WHERE PA_NAME='" & PA_NAME.Text & "'"
            Dim cmd1 As SqlClient.SqlCommand = New SqlClient.SqlCommand(sql1, SqlConn)
            Dim da11 As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter(cmd1)
            Dim dt11 As DataTable = New DataTable
            da11.Fill(dt11)
            TXT_ADD.Text = dt11.Rows(0)(0).ToString
        Catch ex As Exception
            MsgBox(ex.Message)
            SqlConn.Close()
        End Try
        '===========================================================
    End Sub

    Private Sub TXT_MONY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MONY.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Then
            Else
                MsgBox("من فضلك ادخل رقم صحيح فقط")
                e.Handled = True
            End If
        End If
    End Sub
End Class