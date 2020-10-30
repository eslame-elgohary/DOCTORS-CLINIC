Public Class ADD_MONY_T3AQOD
    Dim ARABIC As New ClassConvertNO
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
    Sub FILL_T3AQOD()
        TXT_T3AQOD_NAME.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM T3AQOD_2020 WHERE T3AQOD_STAT='TRUE'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_T3AQOD_NAME.Items.Add(DT.Rows(I).Item("T3AQOD_NAME"))
        Next
    End Sub
    Private Sub TXT_T3AQOD_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_T3AQOD_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM T3AQOD_2020 WHERE T3AQOD_NAME='" & TXT_T3AQOD_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_T3AQOD_CODE.Text = DT.Rows(I).Item("T3AQOD_CODE")
        Next

        '============================================================
        FILL_TKHASOS()
        '=================================
        TXT_TKHASOS.Text = ""
        TXT_TKHASOS_CODE.Text = ""
        TXT_DOCTOR.Text = ""
        TXT_DOCTOR_CODE.Text = ""
        TXT_ACTION.Text = ""
        TXT_COVER.Text = ""
        TXT_MONY_ACTION.Text = ""
        TXT_MONY_GHA.Text = ""
        TXT_MONY_PA.Text = ""
        DataGridView1.Rows.Clear()
        CALC()
    End Sub
    Sub FILL_TKHASOS()
        TXT_TKHASOS.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT DISTINCT TAKH_NAME FROM T3AQOD2020_V WHERE T3AQOD_STAT='TRUE' AND T3AQOD_CODE = '" & TXT_T3AQOD_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_TKHASOS.Items.Add(DT.Rows(I).Item("TAKH_NAME"))
        Next
    End Sub
    Private Sub TXT_TKHASOS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_TKHASOS.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM T3AQOD2020_V WHERE TAKH_NAME ='" & TXT_TKHASOS.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_TKHASOS_CODE.Text = DT.Rows(I).Item("T5ASOS_CODE")
        Next


        TXT_DOCTOR.Text = ""
        TXT_DOCTOR_CODE.Text = ""
        TXT_ACTION.Text = ""
        TXT_COVER.Text = ""
        TXT_MONY_ACTION.Text = ""
        TXT_MONY_GHA.Text = ""
        TXT_MONY_PA.Text = ""
        DataGridView1.Rows.Clear()
        CALC()

        FILL_DOCTORS()
    End Sub
    Sub FILL_DOCTORS()
        '============ تنظيف باقى الشاشات ============================
        TXT_ACTION.Items.Clear()
        TXT_COVER.Items.Clear()
        TXT_MONY_ACTION.Text = ""
        TXT_MONY_GHA.Text = ""
        TXT_MONY_PA.Text = ""
        '============================================================
        TXT_DOCTOR.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT DISTINCT  DO_NAME FROM T3AQOD2020_V WHERE T3AQOD_STAT='TRUE' AND T3AQOD_CODE = '" & TXT_T3AQOD_CODE.Text & "'AND T5ASOS_CODE ='" & TXT_TKHASOS_CODE.Text & "' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_DOCTOR.Items.Add(DT.Rows(I).Item("DO_NAME"))
        Next
    End Sub
    Private Sub TXT_DOCTOR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_DOCTOR.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM T3AQOD2020_V WHERE DO_NAME ='" & TXT_DOCTOR.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_DOCTOR_CODE.Text = DT.Rows(I).Item("DOCTOR_CODE")
        Next

        TXT_ACTION.Text = ""
        TXT_COVER.Text = ""
        TXT_MONY_ACTION.Text = ""
        TXT_MONY_GHA.Text = ""
        TXT_MONY_PA.Text = ""
        DataGridView1.Rows.Clear()
        CALC()
        FILL_ACTION()
    End Sub
    Sub FILL_ACTION()
        '============ تنظيف باقى الشاشات ============================
        TXT_COVER.Items.Clear()
        TXT_MONY_ACTION.Text = ""
        TXT_MONY_GHA.Text = ""
        TXT_MONY_PA.Text = ""
        '============================================================
        TXT_ACTION.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM T3AQOD2020_V WHERE T3AQOD_STAT='TRUE' AND T3AQOD_CODE = '" & TXT_T3AQOD_CODE.Text & "'AND DOCTOR_CODE ='" & TXT_DOCTOR_CODE.Text & "' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_ACTION.Items.Add(DT.Rows(I).Item("ACTION_NAME"))
        Next
    End Sub
    Private Sub TXT_ACTOION_DOCTOR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_ACTION.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM T3AQOD2020_V WHERE T3AQOD_STAT='TRUE' AND T3AQOD_CODE = '" & TXT_T3AQOD_CODE.Text & "'AND DOCTOR_CODE ='" & TXT_DOCTOR_CODE.Text & "'  AND ACTION_NAME ='" & TXT_ACTION.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_MONY_ACTION.Text = DT.Rows(I).Item("ACTION_PRICE")
        Next
        FILL_COVER()
    End Sub
    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Dispose()
    End Sub

    Private Sub ADD_MONY_T3AQOD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEWBTN_Click(sender, e)
        TXT_DATE.Text = ZIARA2020.TXT_DATE.Text
        TXT_PA_CODE.Text = ZIARA2020.TXT_PA_CODE_H.Text
        'TXT_TKHASOS_CODE.Text = ZIARA2020.TXT_TKHASOS_CODE.Text
        'TXT_DOCTOR_CODE.Text = ZIARA2020.TXT_DOCTOR_CODE.Text

    End Sub

    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles NEWBTN.Click
        Me.PATIENTTableAdapter.Fill(Me.PATIENTDATA.PATIENT)
        FILL_T3AQOD()
        TXT_PA_NAME.Text = ""
        '""""""""""""""" تنظيف الشاشة """""""""""""
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is ComboBox Then GroupBox1.Controls(I).Text = ""
        Next
        For I = 0 To GroupBox2.Controls.Count - 1
            If TypeOf GroupBox2.Controls(I) Is TextBox Then GroupBox2.Controls(I).Text = ""
        Next
        For I = 0 To GroupBox2.Controls.Count - 1
            If TypeOf GroupBox2.Controls(I) Is ComboBox Then GroupBox2.Controls(I).Text = ""
        Next
        For I = 0 To GroupBox3.Controls.Count - 1
            If TypeOf GroupBox3.Controls(I) Is TextBox Then GroupBox3.Controls(I).Text = ""
        Next
        For I = 0 To GroupBox3.Controls.Count - 1
            If TypeOf GroupBox3.Controls(I) Is ComboBox Then GroupBox3.Controls(I).Text = ""
        Next
        DataGridView1.Rows.Clear()
        FILL_KHAZINA_CODE()
        FILL_KHAZINA()
        TXT_TYPEMONY.SelectedIndex = 0
        TXT_BAKY.Text = ""
        TXT_RASED_NEW.Text = ""
        '=======================================================================
        TXT_CODE.Text = CODE_GENE("ADD_MONY_DOCTOR_T3AQOD", "ID") + 1
        '========================================================================
        EDITBTN.Enabled = False
        DELETBTN.Enabled = False
        SAVEBTN.Enabled = True
        TIMERADD.Enabled = True
        TIMEREDIT.Enabled = False
        PRINTBTN.Enabled = True
        BTN_ADD_ACTION.Enabled = True
        DataGridView1.Enabled = True

    End Sub

    Private Sub TXT_PA_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_PA_NAME.SelectedIndexChanged

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME='" & TXT_PA_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA_CODE.Text = DT.Rows(I).Item("PA_CODE")
            TXT_PA_TEL.Text = DT.Rows(I).Item("PA_TEL")
            TXT_PA_CODE2.Text = DT.Rows(I).Item("PA_CODE2")
        Next

        '===================== اجمالى الفواتير ==========================================
        Try
            Dim sql As String = "SELECT coalesce(sum(SAFY_MAML), 0) FROM PATIENT_RASED_VIWE WHERE PA_NAME='" & TXT_PA_NAME.Text & "'"
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
            Dim sql1 As String = "SELECT coalesce(sum(ADD_MAML), 0) FROM PATIENT_RASED_VIWE WHERE PA_NAME='" & TXT_PA_NAME.Text & "'"
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
        '============================================================
        FILL_TKHASOS()
        '=================================
        TXT_TKHASOS.Text = ""
        TXT_TKHASOS_CODE.Text = ""
        TXT_DOCTOR.Text = ""
        TXT_DOCTOR_CODE.Text = ""
        TXT_ACTION.Text = ""
        TXT_COVER.Text = ""
        TXT_MONY_ACTION.Text = ""
        TXT_MONY_GHA.Text = ""
        TXT_MONY_PA.Text = ""
        DataGridView1.Rows.Clear()
        CALC()
    End Sub

    Private Sub TXT_COVER_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_COVER.SelectedIndexChanged
        If TXT_COVER.SelectedIndex = 0 Then
            TXT_MONY_PA.Text = "0"
            TXT_MONY_GHA.Text = TXT_MONY_ACTION.Text
        Else
            TXT_MONY_PA.Text = Val(TXT_MONY_ACTION.Text) - Val(Val(TXT_COVER.Text) * Val(TXT_MONY_ACTION.Text) / 100)
            TXT_MONY_GHA.Text = Val(TXT_MONY_ACTION.Text) - Val(TXT_MONY_PA.Text)
        End If

    End Sub
    Sub FILL_COVER()
        TXT_COVER.Items.Clear()
        TXT_COVER.Items.Add("Direct")
        TXT_COVER.Items.Add("95%")
        TXT_COVER.Items.Add("90%")
        TXT_COVER.Items.Add("85%")
        TXT_COVER.Items.Add("80%")
        TXT_COVER.Items.Add("75%")
        TXT_COVER.Items.Add("70%")
        TXT_COVER.Items.Add("65%")
        TXT_COVER.Items.Add("60%")
        TXT_COVER.Items.Add("55%")
        TXT_COVER.Items.Add("50%")
        TXT_COVER.Items.Add("45%")
        TXT_COVER.Items.Add("40%")
        TXT_COVER.Items.Add("35%")
        TXT_COVER.Items.Add("30%")
        TXT_COVER.Items.Add("25%")
        TXT_COVER.Items.Add("20%")
        TXT_COVER.Items.Add("15%")
        TXT_COVER.Items.Add("10%")
        TXT_COVER.Items.Add("5%")
        TXT_COVER.Items.Add("0%")
    End Sub

    Private Sub BTN_ADD_ACTION_Click(sender As Object, e As EventArgs) Handles BTN_ADD_ACTION.Click
        If TXT_MONY_ACTION.Text = "" Then
            MessageBox.Show("من فضلك أختار الخدمة")
            TXT_ACTION.Select()
            Exit Sub
        End If
        If TXT_MONY_PA.Text = "" Then
            MessageBox.Show("من فضلك أدخل نسبة التغطية")
            TXT_COVER.Select()
            Exit Sub
        End If
        Dim BAR As Integer
        '======= اضافة سجل للداتا جريد ===========
        DataGridView1.Rows.Add()
        BAR = DataGridView1.Rows.Count - 1
        DataGridView1(0, BAR).Value = TXT_ACTION.Text
        DataGridView1(1, BAR).Value = TXT_MONY_ACTION.Text
        DataGridView1(2, BAR).Value = TXT_MONY_GHA.Text
        DataGridView1(3, BAR).Value = TXT_MONY_PA.Text


        TXT_ACTION.Text = ""
        TXT_COVER.Text = ""
        TXT_MONY_ACTION.Text = ""
        TXT_MONY_GHA.Text = ""
        TXT_MONY_PA.Text = ""
        TXT_ACTION.Select()
        CALC()
    End Sub
    Sub CALC()
        '==== انشاء العملية الحسابية =======
        Dim TOTAL_ As Double

        For I = 0 To DataGridView1.Rows.Count - 1
            TOTAL_ = Val(TOTAL_) + Val(DataGridView1.Rows(I).Cells(1).Value)
        Next
        TXT_TOTAL.Text = Val(TOTAL_)


        Dim TOTAL_PA As Double
        For I = 0 To DataGridView1.Rows.Count - 1
            TOTAL_PA = Val(TOTAL_PA) + Val(DataGridView1.Rows(I).Cells(3).Value)
        Next
        TXT_TOTAL_PA.Text = Val(TOTAL_PA)

        Dim TOTAL_GHA As Double
        For I = 0 To DataGridView1.Rows.Count - 1
            TOTAL_GHA = Val(TOTAL_GHA) + Val(DataGridView1.Rows(I).Cells(2).Value)
        Next
        TXT_TOTAL_GHA.Text = Val(TOTAL_GHA)
    End Sub

    Private Sub TXT_MONY_TextChanged(sender As Object, e As EventArgs) Handles TXT_MONY.TextChanged
        TXT_BAKY.Text = Val(TXT_TOTAL_PA.Text) - Val(TXT_MONY.Text)

        TXT_RASED_NEW.Text = Val(TXT_BAKY.Text) + Val(TXT_RASED.Text)

        If Val(TXT_MONY.Text) > 0 Then
            SAFY_AR.Text = ARABIC.ConvertToArabic(TXT_MONY.Text)
        Else
            SAFY_AR.Text = ""
        End If
    End Sub

    Private Sub TXT_MONY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MONY.KeyPress
        PressOnlyNumeric(e)   ' إدخال أرقام فقط
    End Sub

    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click
        '====================حفظ العيادة=============================

        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("M1").ToString = True Then
                CALC()

                TXT_BAKY.Text = Val(TXT_TOTAL_PA.Text) - Val(TXT_MONY.Text)

                TXT_RASED_NEW.Text = Val(TXT_BAKY.Text) + Val(TXT_RASED.Text)

                If Val(TXT_MONY.Text) > 0 Then
                    SAFY_AR.Text = ARABIC.ConvertToArabic(TXT_MONY.Text)
                Else
                    SAFY_AR.Text = ""
                End If

                '========= قيود الادخال =======================
                If TXT_PA_NAME.Text = "" Then
                    MessageBox.Show("برجاء ادخال اسم المريض", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_PA_NAME.Select()
                    Exit Sub
                End If
                If TXT_TYPEMONY.Text = "" Then
                    MessageBox.Show("يرجى أختيار طريقة الدفع", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_TYPEMONY.Select()
                    Exit Sub
                End If

                If DataGridView1.Rows.Count < 1 Then
                    MessageBox.Show("يرجى أختيار الأجراء المطلوب", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_ACTION.Select()
                    Exit Sub
                End If
                If TXT_MONY.Text = "" Then
                    MessageBox.Show("يرجى أدخال المبلغ المستلم", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_MONY.Select()
                    Exit Sub
                End If
                '================= التخزين فى الحجز ========================================
                Dim REEM As String
                REEM = "SELECT * FROM HAGEZ WHERE DOCTORS_CODE = '" & TXT_DOCTOR_CODE.Text & "'  AND PA_CODE = '" & TXT_PA_CODE.Text & "' AND DATE_HAGEZ = '" & TXT_DATE.Text & "'"
                Dim DTE As New DataTable
                Dim DAE As New SqlClient.SqlDataAdapter(REEM, SqlConn)
                DAE.Fill(DTE)
                If DTE.Rows.Count = 0 Then
                    MessageBox.Show("الأنتباه ان تاريخ الأيصال نفس تاريخ الحجز للمريض")
                    TXT_DATE.Select()
                    Exit Sub
                Else
                    For I = 0 To DataGridView1.Rows.Count - 1
                        Dim DRE = DTE.Rows(0)
                        DRE!ACTION = "تعاقدات"
                        DRE!STAT_COLORE = "7"
                        Dim SAVEE As New SqlClient.SqlCommandBuilder(DAE)
                        DAE.Update(DTE)
                    Next
                End If

                '================= تخزين بيانات الصنف في قاعدة البيانات =============

                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_DOCTOR_T3AQOD WHERE ADD_DATE = '" & TXT_DATE.Text & "' AND ADD_CODE_DOCTOR = '" & TXT_DOCTOR_CODE.Text & "' AND ADD_CODE_PA = '" & TXT_PA_CODE.Text & "' AND ADD_STAT='TRUE' ", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count > 0 Then
                    If MessageBox.Show("المريض له أيصال فى نفس اليوم لنفس الطبيب ، هل ترغب فى الأستمرار ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.No Then
                        TXT_PA_NAME.Select()
                        Exit Sub
                    Else
                        '""""""""""""""" الترقيم التلقائي """"""""""""""
                        TXT_CODE.Text = CODE_GENE("ADD_MONY_DOCTOR_T3AQOD", "ID") + 1
                        '""""""""""""""""""""""""""""""

                        Dim DR = DT.NewRow
                        DR!ADD_CODE = TXT_CODE.Text
                        DR!ADD_DATE = TXT_DATE.Text
                        DR!ADD_CODE_GHA = TXT_T3AQOD_CODE.Text
                        DR!ADD_TYPE = "تعاقدات"
                        DR!ADD_KHAZINA_CODE = KHAZINA_CODE.Text
                        DR!ADD_CODE_PA = TXT_PA_CODE.Text
                        DR!ADD_CODE_TKHSOS = TXT_TKHASOS_CODE.Text
                        DR!ADD_CODE_DOCTOR = TXT_DOCTOR_CODE.Text
                        DR!ADD_CARD_NUMBER = TXT_NUMPER_CARD_PA.Text
                        DR!ADD_MONY_TOTAL = TXT_TOTAL.Text
                        DR!ADD_MONY_GHA = TXT_TOTAL_GHA.Text
                        DR!ADD_MONY_PA = TXT_TOTAL_PA.Text
                        DR!ADD_MONY_TYPE = TXT_TYPEMONY.Text
                        DR!ADD_MADFO3_MONY = TXT_MONY.Text
                        DR!ADD_AR_MONY = SAFY_AR.Text
                        DR!ADD_STAT = True
                        DR!ADD_USER_ADD = USER_ADD.Text
                        DR!ADD_DATE_ADD = DATE_ADD.Text
                        DR!ADD_TIME_ADD = TIME_ADD.Text
                        DT.Rows.Add(DR)
                        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                        DA.Update(DT)

                        '============================== أضافة تفاصيل الايصال ========================
                        Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_DOCTOR_T3AQOD_DT", SqlConn)
                        DA1.Fill(DT)
                        For I = 0 To DataGridView1.Rows.Count - 1
                            Dim DR1 = DT.NewRow
                            DR1!ADD_CODE = TXT_CODE.Text
                            DR1!ADD_DATE = TXT_DATE.Text
                            DR1!ADD_ACTION = DataGridView1.Rows(I).Cells(0).Value
                            DR1!ADD_MONY_ACTION = DataGridView1.Rows(I).Cells(1).Value
                            DR1!ADD_MONY_GHA = DataGridView1.Rows(I).Cells(2).Value
                            DR1!ADD_MONY_PA = DataGridView1.Rows(I).Cells(3).Value
                            DR1!STAT_DT = True
                            DT.Rows.Add(DR1)
                            Dim CMD_ As New SqlClient.SqlCommandBuilder(DA1)
                            DA1.Update(DT)
                        Next

                        '============================== أضافة تفاصيل للخزينة ========================

                        Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA_DT", SqlConn)
                        DA2.Fill(DT)
                        Dim DR2 = DT.NewRow
                        DR2!KHAZINA_CODE = KHAZINA_CODE.Text
                        DR2!KHAZINA_DATE = TXT_DATE.Text
                        DR2!CODE_DT = TXT_CODE.Text
                        DR2!CODE_DT2 = "1000"
                        DR2!KHAZINA_NAME_ACTION = "أيصال أستلام نقدية رقم " & TXT_CODE.Text & " تعاقدات "
                        DR2!KHAZINA_IN = TXT_MONY.Text
                        DR2!MONY_TYPE = TXT_TYPEMONY.Text
                        DR2!KHAZINA_OUT = "0"
                        DR2!STAT_KHAZINA = True
                        DT.Rows.Add(DR2)
                        Dim CMD2_ As New SqlClient.SqlCommandBuilder(DA2)
                        DA2.Update(DT)

                        '==================================التخزين فى حساب المريض ========================================

                        Dim DA3 As New SqlClient.SqlDataAdapter("SELECT * FROM PATION_MONY_DT", SqlConn)
                        DA3.Fill(DT)
                        Dim DR3 = DT.NewRow
                        DR3!ADD_CODE = TXT_CODE.Text
                        DR3!ADD_CODE2 = "10"
                        DR3!ADD_DATE = TXT_DATE.Text
                        DR3!PA_CODE = TXT_PA_CODE.Text
                        DR3!ACTION_NAME = "أيصال عيادات تعاقدات رقم " & TXT_CODE.Text
                        DR3!SAFY_MAML = TXT_MONY.Text
                        DR3!ADD_MAML = TXT_MONY.Text
                        DR3!BAKY_MAML = TXT_BAKY.Text
                        DR3!STAT = True
                        DT.Rows.Add(DR3)
                        Dim CMD3 As New SqlClient.SqlCommandBuilder(DA3)
                        DA3.Update(DT)

                        PRINTBTN_Click(sender, e)

                        MessageBox.Show("تمت عملية حفظ بيانات الأيصال بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        NEWBTN_Click(sender, e)

                    End If
                Else

                    '""""""""""""""" الترقيم التلقائي """"""""""""""
                    TXT_CODE.Text = CODE_GENE("ADD_MONY_DOCTOR_T3AQOD", "ID") + 1
                    '""""""""""""""""""""""""""""""

                    Dim DR = DT.NewRow
                    DR!ADD_CODE = TXT_CODE.Text
                    DR!ADD_DATE = TXT_DATE.Text
                    DR!ADD_CODE_GHA = TXT_T3AQOD_CODE.Text
                    DR!ADD_TYPE = "تعاقدات"
                    DR!ADD_KHAZINA_CODE = KHAZINA_CODE.Text
                    DR!ADD_CODE_PA = TXT_PA_CODE.Text
                    DR!ADD_CODE_TKHSOS = TXT_TKHASOS_CODE.Text
                    DR!ADD_CODE_DOCTOR = TXT_DOCTOR_CODE.Text
                    DR!ADD_CARD_NUMBER = TXT_NUMPER_CARD_PA.Text
                    DR!ADD_MONY_TOTAL = TXT_TOTAL.Text
                    DR!ADD_MONY_GHA = TXT_TOTAL_GHA.Text
                    DR!ADD_MONY_PA = TXT_TOTAL_PA.Text
                    DR!ADD_MONY_TYPE = TXT_TYPEMONY.Text
                    DR!ADD_MADFO3_MONY = TXT_MONY.Text
                    DR!ADD_AR_MONY = SAFY_AR.Text
                    DR!ADD_STAT = True
                    DR!ADD_USER_ADD = USER_ADD.Text
                    DR!ADD_DATE_ADD = DATE_ADD.Text
                    DR!ADD_TIME_ADD = TIME_ADD.Text
                    DT.Rows.Add(DR)
                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)

                    '============================== أضافة تفاصيل الايصال ========================
                    Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_DOCTOR_T3AQOD_DT", SqlConn)
                    DA1.Fill(DT)
                    For I = 0 To DataGridView1.Rows.Count - 1
                        Dim DR1 = DT.NewRow
                        DR1!ADD_CODE = TXT_CODE.Text
                        DR1!ADD_DATE = TXT_DATE.Text
                        DR1!ADD_ACTION = DataGridView1.Rows(I).Cells(0).Value
                        DR1!ADD_MONY_ACTION = DataGridView1.Rows(I).Cells(1).Value
                        DR1!ADD_MONY_GHA = DataGridView1.Rows(I).Cells(2).Value
                        DR1!ADD_MONY_PA = DataGridView1.Rows(I).Cells(3).Value
                        DR1!STAT_DT = True
                        DT.Rows.Add(DR1)
                        Dim CMD_ As New SqlClient.SqlCommandBuilder(DA1)
                        DA1.Update(DT)
                    Next

                    '============================== أضافة تفاصيل للخزينة ========================

                    Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA_DT", SqlConn)
                    DA2.Fill(DT)
                    Dim DR2 = DT.NewRow
                    DR2!KHAZINA_CODE = KHAZINA_CODE.Text
                    DR2!KHAZINA_DATE = TXT_DATE.Text
                    DR2!CODE_DT = TXT_CODE.Text
                    DR2!CODE_DT2 = "1000"
                    DR2!KHAZINA_NAME_ACTION = "أيصال أستلام نقدية رقم " & TXT_CODE.Text & " تعاقدات "
                    DR2!KHAZINA_IN = TXT_MONY.Text
                    DR2!MONY_TYPE = TXT_TYPEMONY.Text
                    DR2!KHAZINA_OUT = "0"
                    DR2!STAT_KHAZINA = True
                    DT.Rows.Add(DR2)
                    Dim CMD2_ As New SqlClient.SqlCommandBuilder(DA2)
                    DA2.Update(DT)

                    '==================================التخزين فى حساب المريض ========================================

                    Dim DA3 As New SqlClient.SqlDataAdapter("SELECT * FROM PATION_MONY_DT", SqlConn)
                    DA3.Fill(DT)
                    Dim DR3 = DT.NewRow
                    DR3!ADD_CODE = TXT_CODE.Text
                    DR3!ADD_CODE2 = "10"
                    DR3!ADD_DATE = TXT_DATE.Text
                    DR3!PA_CODE = TXT_PA_CODE.Text
                    DR3!ACTION_NAME = "أيصال عيادات تعاقدات رقم " & TXT_CODE.Text
                    DR3!SAFY_MAML = TXT_MONY.Text
                    DR3!ADD_MAML = TXT_MONY.Text
                    DR3!BAKY_MAML = TXT_BAKY.Text
                    DR3!STAT = True
                    DT.Rows.Add(DR3)
                    Dim CMD3 As New SqlClient.SqlCommandBuilder(DA3)
                    DA3.Update(DT)

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

    End Sub

    Private Sub DELETBTN_Click(sender As Object, e As EventArgs) Handles DELETBTN.Click

    End Sub

    Private Sub SEARCHBTN_Click(sender As Object, e As EventArgs) Handles SEARCHBTN.Click
        SEARCH_ADD_MONY_DOCTOR_T3AQOD.ShowDialog()
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
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_DOCTOR_T3AQODAT WHERE ADD_CODE ='" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)
                Dim REP As New ADD_MONY_DOCTOR_T3AQOD_CRS
                REP.SetDataSource(DT)
                REP.SetParameterValue(0, TXT_RASED.Text)
                REP.SetParameterValue(1, TXT_RASED_NEW.Text)
                Dim FRM As New ADD_MONY_CRS
                FRM.CrystalReportViewer1.ReportSource = REP
                FRM.ShowDialog()

                '=============================================================
            Else
                MessageBox.Show("عفوا ليس لديك صلاحية للطباعة برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If




    End Sub

    Private Sub TXT_TKHASOS_CODE_TextChanged(sender As Object, e As EventArgs) Handles TXT_TKHASOS_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM T3AQOD2020_V WHERE T5ASOS_CODE='" & TXT_TKHASOS_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_TKHASOS.Text = DT.Rows(I).Item("TAKH_NAME")
        Next
    End Sub

    Private Sub TXT_PA_CODE_TextChanged(sender As Object, e As EventArgs) Handles TXT_PA_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_CODE='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA_NAME.Text = DT.Rows(I).Item("PA_NAME")
            TXT_PA_TEL.Text = DT.Rows(I).Item("PA_TEL")
            TXT_PA_CODE2.Text = DT.Rows(I).Item("PA_CODE2")
        Next
        '===================== اجمالى الفواتير ==========================================
        Try
            Dim sql As String = "SELECT coalesce(sum(SAFY_MAML), 0) FROM PATIENT_RASED_VIWE WHERE PA_NAME='" & TXT_PA_NAME.Text & "'"
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
            Dim sql1 As String = "SELECT coalesce(sum(ADD_MAML), 0) FROM PATIENT_RASED_VIWE WHERE PA_NAME='" & TXT_PA_NAME.Text & "'"
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

    Private Sub TXT_DOCTOR_CODE_TextChanged(sender As Object, e As EventArgs) Handles TXT_DOCTOR_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM T3AQOD2020_V WHERE  DOCTOR_CODE ='" & TXT_DOCTOR_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_DOCTOR.Text = DT.Rows(I).Item("DO_NAME")
        Next
        FILL_ACTION()
    End Sub

    Private Sub TXT_T3AQOD_CODE_TextChanged(sender As Object, e As EventArgs) Handles TXT_T3AQOD_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM T3AQOD_2020 WHERE T3AQOD_CODE ='" & TXT_T3AQOD_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_T3AQOD_NAME.Text = DT.Rows(I).Item("T3AQOD_NAME")
        Next
    End Sub
    Sub SHOW_DETA(CODE_)
        DataGridView1.Rows.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_DOCTOR_T3AQOD WHERE ADD_CODE = '" & CODE_ & "' ", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("لا يوجد أيصالات بهذا الرقم ؟", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else

            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!ADD_CODE
            TXT_DATE.Text = DR!ADD_DATE
            TXT_T3AQOD_CODE.Text = DR!ADD_CODE_GHA
            TXT_PA_CODE.Text = DR!ADD_CODE_PA
            TXT_TKHASOS_CODE.Text = DR!ADD_CODE_TKHSOS
            TXT_DOCTOR_CODE.Text = DR!ADD_CODE_DOCTOR
            TXT_NUMPER_CARD_PA.Text = DR!ADD_CARD_NUMBER
            TXT_TOTAL.Text = DR!ADD_MONY_TOTAL
            TXT_TOTAL_GHA.Text = DR!ADD_MONY_GHA
            TXT_TOTAL_PA.Text = DR!ADD_MONY_PA
            TXT_TYPEMONY.Text = DR!ADD_MONY_TYPE
            TXT_MONY.Text = DR!ADD_MADFO3_MONY
            SAFY_AR.Text = DR!ADD_AR_MONY

            USER_ADD.Text = DR!ADD_USER_ADD
            DATE_ADD.Text = DR!ADD_DATE_ADD
            TIME_ADD.Text = DR!ADD_TIME_ADD

            '============================== أضافة تفاصيل الايصال ========================
            Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_DOCTOR_T3AQOD_DT WHERE ADD_CODE ='" & CODE_ & "'", SqlConn)
            DA1.Fill(DT)
            For I = 0 To DataGridView1.Rows.Count - 1
                Dim DR1 = DT.Rows(0)
                DataGridView1.Rows.Add()
                DataGridView1.Rows(I).Cells(0).Value = DR1!ADD_ACTION
                DataGridView1.Rows(I).Cells(1).Value = DR1!ADD_MONY_ACTION
                DataGridView1.Rows(I).Cells(2).Value = DR1!ADD_MONY_GHA
                DataGridView1.Rows(I).Cells(3).Value = DR1!ADD_MONY_PA


            Next

            DELETBTN.Enabled = True
            EDITBTN.Enabled = True
            SAVEBTN.Enabled = False
            TIMEREDIT.Enabled = True
            TIMERADD.Enabled = False

        End If
    End Sub
End Class