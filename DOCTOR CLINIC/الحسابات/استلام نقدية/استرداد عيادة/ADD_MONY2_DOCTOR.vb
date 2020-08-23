Public Class ADD_MONY2_DOCTOR
    Dim ARABIC As New ClassConvertNO

    Sub DATEF()
        Dim DATEDAY As Date
        Dim DATELAST As Date
        Dim FDATE As Integer
        DATEDAY = TXT_DATE_TODAY.Value
        DATELAST = TXT_DATE.Value
        FDATE = DateDiff(DateInterval.Day, DATELAST, DATEDAY)
        TXT_DAY.Text = FDATE
    End Sub
    Sub SHOW_DETA(CODE_)
        DataGridView1.Rows.Clear()
        '=========== ربط رأس الفاتورة =============
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_DOCTOR WHERE ADD_CODE ='" & CODE_ & "'", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("يرجى التأكد من كود الأيصال", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!ADD_CODE
            TXT_DATE.Text = DR!ADD_DATE
            KHAZINA_CODE.Text = DR!CODE_KHAZINA
            PA_CODE.Text = DR!ADD_PA_CODE
            TA_CODE_TKHASOS.Text = DR!ADD_TKHASOS_CODE
            CODE_DOCTOR.Text = DR!ADD_DOCTOR_CODE
            TOTAL.Text = DR!ADD_TOTAL
            DISCOUNT.Text = DR!ADD_DIS
            SAFY.Text = DR!ADD_SAFY
            SAFY_AR.Text = DR!ADD_SAFY_AR
            TXT_TYPEMONY.Text = DR!ADD_TYPE_MONY
            USER_ADD.Text = DR!ADD_USER_ADD
            DATE_ADD.Text = DR!ADD_DATE_ADD
            TIME_ADD.Text = DR!ADD_TIME_ADD

            '=========== ربط تفاصيل الفاتورة =============
            Dim DT10 As New DataTable
            Dim DA10 As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_DT_DOCTOR WHERE ADD_CODE = '" & CODE_ & "'", SqlConn)
            DA10.Fill(DT10)
            For I = 0 To DT10.Rows.Count - 1
                DataGridView1.Rows.Add()
                DataGridView1.Rows(I).Cells(0).Value = DT10.Rows(I).Item("CODE_ACTION")
                DataGridView1.Rows(I).Cells(2).Value = DT10.Rows(I).Item("NAME_ACTION")
                DataGridView1.Rows(I).Cells(3).Value = DT10.Rows(I).Item("PRICE_DOCE")
                DataGridView1.Rows(I).Cells(1).Value = DT10.Rows(I).Item("MID")
            Next
            For I = 0 To DataGridView1.Rows.Count - 1
                TXT_M.Text = Val(DataGridView1.Rows(I).Cells(1).Value) + 1
            Next

            DELETBTN.Enabled = True
            EDITBTN.Enabled = True
            SAVEBTN.Enabled = False
            TIMEREDIT.Enabled = True
            TIMERADD.Enabled = False
            PRINTBTN.Enabled = False
            CALC()
        End If
    End Sub
    Sub CALC()
        '==== انشاء العملية الحسابية =======
        Dim TOTAL_ As Double

        For I = 0 To DataGridView1.Rows.Count - 1
            TOTAL_ = Val(TOTAL_) + Val(DataGridView1.Rows(I).Cells(3).Value)
        Next
        TOTAL.Text = Val(TOTAL_)
        SAFY.Text = Val(TOTAL.Text) - Val(DISCOUNT.Text)

        If Val(TOTAL.Text) > 0 Then
            SAFY_AR.Text = ARABIC.ConvertToArabic(SAFY.Text)
        Else
            SAFY_AR.Text = ""
        End If
    End Sub
    Private Sub ADD_MONY2_DOCTOR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '  If ZIARA2020.ShowDialog Then

        NEWBTN_Click(sender, e)

        'TXT_DATE.Text = ZIARA2020.TXT_DATE.Text
        'PA_CODE.Text = ZIARA2020.TXT_PA_CODE_H.Text
        'TA_CODE_TKHASOS.Text = ZIARA2020.TXT_TKHASOS_CODE.Text
        'CODE_DOCTOR.Text = ZIARA2020.TXT_DOCTOR_CODE.Text

        'Else
        '    NEWBTN_Click(sender, e)
        'End If
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
        DataGridView1.Rows.Clear()
        TA_TKHASOS.Items.Clear()
        TXT_DOCTOR.Items.Clear()
        TXT_ACTION.Items.Clear()
        '""""""""""""""" الترقيم التلقائي """"""""""""""
        'TXT_CODE.Text = CODE_GENE("ADD_MONY_DOCTOR", "ID") + 1
        '""""""""""""""""""""""""""""""
        'EDITBTN.Enabled = False
        'DELETBTN.Enabled = False
        SAVEBTN.Enabled = True
        TIMERADD.Enabled = True
        TIMEREDIT.Enabled = False
        'PRINTBTN.Enabled = True
        'TXT_M.Text = "1"
        'FILL_KHAZINA_CODE()
        'CALC()
        'FILL_KHAZINA()
        ''=====================================================
        'PATIENTDATA.Clear()
        'PATIENTTableAdapter.Fill(PATIENTDATA.PATIENT)
        'PA_NAME.Text = ""
        'PA_NAME.Select()
        'TXT_TYPEMONY.SelectedIndex = 0
        TXT_DATE.Value = Date.Today
        TXT_DATE_TODAY.Value = Date.Today
        TXT_CODE.Select()
    End Sub
    Sub SHOW_DETA2(CODE2_)

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
        DataGridView1.Rows.Clear()
        TA_TKHASOS.Items.Clear()
        TXT_DOCTOR.Items.Clear()
        TXT_ACTION.Items.Clear()
        '""""""""""""""" الترقيم التلقائي """"""""""""""
        TXT_CODE.Text = CODE_GENE("ADD_MONY_DOCTOR", "ID") + 1
        '""""""""""""""""""""""""""""""
        EDITBTN.Enabled = False
        DELETBTN.Enabled = False
        SAVEBTN.Enabled = True
        TIMERADD.Enabled = True
        TIMEREDIT.Enabled = False
        PRINTBTN.Enabled = True
        TXT_M.Text = "1"
        FILL_KHAZINA_CODE()
        CALC()
        FILL_KHAZINA()
        '=====================================================
        PATIENTDATA.Clear()
        PATIENTTableAdapter.Fill(PATIENTDATA.PATIENT)
        PA_NAME.Text = ""
        PA_NAME.Select()
        TXT_TYPEMONY.SelectedIndex = 0

        '=========== ربط رأس الفاتورة =============
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID ='" & CODE2_ & "'", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("يرجى التأكد من تحديد أسم المريض الصحيح", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)

            TXT_DATE.Text = DR!DATE_HAGEZ

            PA_CODE.Text = DR!PA_CODE

            TA_CODE_TKHASOS.Text = DR!TKHASOS_CODE

            CODE_DOCTOR.Text = DR!DOCTORS_CODE



        End If
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
    Private Sub PA_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PA_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME='" & PA_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            PA_CODE.Text = DT.Rows(I).Item("PA_CODE")
            TXT_AGE.Text = DT.Rows(I).Item("PA_AGE")
            TXT_PA_TYPE.Text = DT.Rows(I).Item("PA_TYPE")
        Next
        FILL_TKHASOS()


    End Sub
    Sub FILL_TKHASOS()
        DataGridView1.Rows.Clear()
        CALC()
        TXT_M.Text = "1"
        TA_TKHASOS.Items.Clear()
        TXT_DOCTOR.Items.Clear()
        TXT_ACTION.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM TKHASOS WHERE STAT='TRUE'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TA_TKHASOS.Items.Add(DT.Rows(I).Item("TAKH_NAME"))
        Next
    End Sub

    Private Sub TA_TKHASOS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TA_TKHASOS.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM TKHASOS WHERE TAKH_NAME='" & TA_TKHASOS.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TA_CODE_TKHASOS.Text = DT.Rows(I).Item("TAKH_CODE")
        Next
        TXT_DOCTOR.Text = ""
        CODE_DOCTOR.Text = ""
        TXT_ACTION.Text = ""
        TXT_ACTION_CODE.Text = ""
        TXT_PRICE.Text = ""
        FILL_DOCTOR()
    End Sub
    Sub FILL_DOCTOR()
        DataGridView1.Rows.Clear()
        CALC()
        TXT_M.Text = "1"
        TXT_DOCTOR.Items.Clear()
        TXT_ACTION.Items.Clear()
        Dim DT4 As New DataTable
        Dim DA4 As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORS WHERE STAT='TRUE' AND DO_TKHSOS_CODE = '" & TA_CODE_TKHASOS.Text & "'", SqlConn)
        DA4.Fill(DT4)
        For I4 = 0 To DT4.Rows.Count - 1
            TXT_DOCTOR.Items.Add(DT4.Rows(I4).Item("DO_NAME"))
        Next
    End Sub

    Private Sub TXT_DOCTOR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_DOCTOR.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORS WHERE DO_NAME='" & TXT_DOCTOR.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            CODE_DOCTOR.Text = DT.Rows(I).Item("DO_CODE")
        Next
        TXT_ACTION.Text = ""
        TXT_ACTION_CODE.Text = ""
        TXT_PRICE.Text = ""
        FILL_DOCTOR_DT()

    End Sub
    Sub FILL_DOCTOR_DT()
        TXT_ACTION.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORSDT WHERE DO_CODE = '" & CODE_DOCTOR.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_ACTION.Items.Add(DT.Rows(I).Item("DOT_NAME"))
        Next
    End Sub

    Private Sub TXT_ACTION_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_ACTION.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORSDT WHERE DOT_NAME='" & TXT_ACTION.Text & "'AND DO_CODE= '" & CODE_DOCTOR.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_ACTION_CODE.Text = DT.Rows(I).Item("DOT_M")
            TXT_PRICE.Text = DT.Rows(I).Item("DOT_PA")
        Next
    End Sub

    Private Sub ACTIVE_DOCTOR_Click(sender As Object, e As EventArgs) Handles ACTIVE_DOCTOR.Click

        Dim BAR As Integer
        '======= اضافة سجل للداتا جريد ===========
        DataGridView1.Rows.Add()
        BAR = DataGridView1.Rows.Count - 1
        DataGridView1(0, BAR).Value = TXT_ACTION_CODE.Text
        DataGridView1(2, BAR).Value = TXT_ACTION.Text
        DataGridView1(3, BAR).Value = TXT_PRICE.Text

        DataGridView1(1, BAR).Value = TXT_M.Text
        DISCOUNT.Text = "0"
        CALC()

        TXT_ACTION.Text = ""
        TXT_ACTION_CODE.Text = ""
        TXT_PRICE.Text = ""
        For I = 0 To DataGridView1.Rows.Count - 1
            TXT_M.Text = Val(DataGridView1.Rows(I).Cells(1).Value) + 1
        Next

        TXT_ACTION.Select()
    End Sub

    Private Sub DISCOUNT_TextChanged(sender As Object, e As EventArgs) Handles DISCOUNT.TextChanged
        'CALC()
    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        'For I As Integer = 0 To DataGridView1.Rows.Count - 1
        '    DataGridView1.Rows(I).Cells(4).Value = "حذف"
        '    Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        'Next
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        'For Each ROW As DataGridViewRow In DataGridView1.Rows
        '    If DataGridView1(4, DataGridView1.CurrentRow.Index).Selected = True Then
        '        DataGridView1.Rows.Remove(ROW)
        '    End If
        'Next

        'CALC()
    End Sub

    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click
        '====================حفظ العيادة=============================

        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("M2").ToString = True Then
                If DT0.Rows(0).Item("M3").ToString = False Then
                    If TXT_DAY.Text < "2" Then
                        MessageBox.Show("لايمكن استرداد مر عليه اكثر من يوم", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TXT_CODE.Select()
                        Exit Sub
                    End If
                End If

                '========= قيود الادخال =======================
                If PA_NAME.Text = "" Then
                        MessageBox.Show("برجاء ادخال رقم أيصال الاسترداد", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TXT_CODE.Select()
                        Exit Sub
                    End If

                If SAFY.Text < 1 Then
                    MessageBox.Show("لايمكن أسترداد أيصال بدون قيمة", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_CODE.Select()
                    Exit Sub
                End If


                If TXT_INFO.Text = "" Then
                        MessageBox.Show("يرجى ادخال سبب الأسترداد", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        TXT_INFO.Select()
                        Exit Sub
                    End If
                    '================= التخزين فى الحجز ========================================
                    Dim REEM As String
                    REEM = "SELECT * FROM HAGEZ WHERE DOCTORS_CODE = '" & CODE_DOCTOR.Text & "'  AND PA_CODE = '" & PA_CODE.Text & "' AND DATE_HAGEZ = '" & TXT_DATE.Text & "'"
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
                            DRE!ACTION = ""
                            DRE!STAT_COLORE = "0"

                            Dim SAVEE As New SqlClient.SqlCommandBuilder(DAE)
                            DAE.Update(DTE)
                        Next
                    End If
                    '================= تخزين بيانات الصنف في قاعدة البيانات =============
                    Dim DT As New DataTable
                    Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_DOCTOR WHERE ADD_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                    DA.Fill(DT)
                    If DT.Rows.Count = 0 Then
                        MessageBox.Show("يوجد أيصال أخر لهذا المريض اليوم، يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        Dim DR = DT.Rows(0)
                        DR!ADD_CODE = TXT_CODE.Text
                        DR!ADD_DATE = TXT_DATE.Text
                        DR!ADD_TYPE = "أسترداد عيادات"
                        DR!CODE_KHAZINA = KHAZINA_CODE.Text
                        DR!ADD_PA_CODE = PA_CODE.Text
                        DR!ADD_TKHASOS_CODE = TA_CODE_TKHASOS.Text
                        DR!ADD_DOCTOR_CODE = CODE_DOCTOR.Text
                        DR!ADD_TOTAL = TOTAL.Text
                        DR!ADD_DIS = DISCOUNT.Text
                        DR!ADD_SAFY = SAFY.Text
                        DR!ADD_SAFY_AR = SAFY_AR.Text
                        DR!ADD_INFO = TXT_INFO.Text
                        DR!ADD_TYPE_MONY = TXT_TYPEMONY.Text
                        DR!ADD_STAT = False
                        DR!ADD_USER_EDIT = USER_EDIT.Text
                        DR!ADD_DATE_EDIT = DATE_EDIT.Text
                        DR!ADD_TIME_EDIT = TIME_EDIT.Text

                        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                        DA.Update(DT)
                    End If

                    '=====================================حذف التفاصيل من الخزينة ========================
                    Dim CMD_DEL2 As New SqlClient.SqlCommand
                    CMD_DEL2.Connection = SqlConn
                    CMD_DEL2.CommandText = "DELETE FROM KHAZINA_DT WHERE CODE_DT ='" & TXT_CODE.Text & "'AND CODE_DT2 = '1'"
                    CMD_DEL2.ExecuteNonQuery()
                    '============================== أضافة تفاصيل للخزينة ========================
                    If TXT_TYPEMONY.SelectedIndex = 0 Then
                        Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA_DT WHERE CODE_DT ='" & TXT_CODE.Text & "'AND CODE_DT2 = '1'", SqlConn)
                        DA2.Fill(DT)
                        Dim DR2 = DT.NewRow
                        DR2!KHAZINA_CODE = KHAZINA_CODE.Text
                        DR2!KHAZINA_DATE = TXT_DATE.Text
                        DR2!CODE_DT = TXT_CODE.Text
                        DR2!CODE_DT2 = "1"
                        DR2!KHAZINA_NAME_ACTION = "أيصال أسترداد نقدية رقم " & TXT_CODE.Text & " العيادات "
                        DR2!KHAZINA_IN = "0"
                        DR2!MONY_TYPE = "نقدي"
                        DR2!KHAZINA_OUT = SAFY.Text
                        DR2!STAT_KHAZINA = False
                        DT.Rows.Add(DR2)
                        Dim CMD2_ As New SqlClient.SqlCommandBuilder(DA2)
                        DA2.Update(DT)
                    End If

                    If TXT_TYPEMONY.SelectedIndex = 1 Then
                        Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA_DT WHERE CODE_DT ='" & TXT_CODE.Text & "'AND CODE_DT2 = '1'", SqlConn)
                        DA2.Fill(DT)
                        Dim DR2 = DT.NewRow
                        DR2!KHAZINA_CODE = KHAZINA_CODE.Text
                        DR2!KHAZINA_DATE = TXT_DATE.Text
                        DR2!CODE_DT = TXT_CODE.Text
                        DR2!CODE_DT2 = "1"
                        DR2!KHAZINA_NAME_ACTION = "أيصال أسترداد نقدية فيزا رقم " & TXT_CODE.Text & " العيادات "
                        DR2!KHAZINA_IN = SAFY.Text
                        DR2!KHAZINA_OUT = "0"
                        DR2!MONY_TYPE = "فيزا"
                        DR2!STAT_KHAZINA = False

                        Dim CMD2_ As New SqlClient.SqlCommandBuilder(DA2)
                        DA2.Update(DT)
                    End If
                    If TXT_TYPEMONY.SelectedIndex = 2 Then
                        Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA_DT WHERE CODE_DT ='" & TXT_CODE.Text & "'AND CODE_DT2 = '1'", SqlConn)
                        DA2.Fill(DT)
                        Dim DR2 = DT.NewRow
                        DR2!KHAZINA_CODE = KHAZINA_CODE.Text
                        DR2!KHAZINA_DATE = TXT_DATE.Text
                        DR2!CODE_DT = TXT_CODE.Text
                        DR2!CODE_DT2 = "1"
                        DR2!KHAZINA_NAME_ACTION = "أيصال أسترداد نقدية بريميوم كارد رقم " & TXT_CODE.Text & " العيادات "
                        DR2!KHAZINA_IN = SAFY.Text
                        DR2!KHAZINA_OUT = "0"
                        DR2!MONY_TYPE = "بريميوم كارد"
                        DR2!STAT_KHAZINA = False

                        Dim CMD2_ As New SqlClient.SqlCommandBuilder(DA2)
                        DA2.Update(DT)
                    End If

                    '==========================================================================
                    printedit()
                    ' PRINTBTN_Click(sender, e)
                    MessageBox.Show("تمت عملية أستردادالأيصال بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    NEWBTN_Click(sender, e)
                    'CALC()
                    'Me.Close()

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
            If DT0.Rows(0).Item("M2").ToString = True Then
                '========= قيود الادخال =======================
                CALC()
                If PA_NAME.Text = "" Then
                    MessageBox.Show("برجاء ادخال اسم المريض", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PA_NAME.Select()
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
                '================= التخزين فى الحجز ========================================
                Dim REEM As String
                REEM = "SELECT * FROM HAGEZ WHERE DOCTORS_CODE = '" & CODE_DOCTOR.Text & "'  AND PA_CODE = '" & PA_CODE.Text & "' AND DATE_HAGEZ = '" & TXT_DATE.Text & "'"
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
                        DRE!ACTION = DataGridView1.Rows(I).Cells(2).Value

                        Dim SAVEE As New SqlClient.SqlCommandBuilder(DAE)
                        DAE.Update(DTE)
                    Next
                End If
                '================= تخزين بيانات الصنف في قاعدة البيانات =============
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_DOCTOR WHERE ADD_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count = 0 Then
                    MessageBox.Show("يوجد أيصال أخر لهذا المريض اليوم، يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim DR = DT.Rows(0)
                    DR!ADD_CODE = TXT_CODE.Text
                    DR!ADD_DATE = TXT_DATE.Text
                    DR!ADD_TYPE = "العيادات"
                    DR!CODE_KHAZINA = KHAZINA_CODE.Text
                    DR!ADD_PA_CODE = PA_CODE.Text
                    DR!ADD_TKHASOS_CODE = TA_CODE_TKHASOS.Text
                    DR!ADD_DOCTOR_CODE = CODE_DOCTOR.Text
                    DR!ADD_TOTAL = TOTAL.Text
                    DR!ADD_DIS = DISCOUNT.Text
                    DR!ADD_SAFY = SAFY.Text
                    DR!ADD_SAFY_AR = SAFY_AR.Text
                    DR!ADD_TYPE_MONY = TXT_TYPEMONY.Text
                    DR!ADD_STAT = True
                    DR!ADD_USER_EDIT = USER_EDIT.Text
                    DR!ADD_DATE_EDIT = DATE_EDIT.Text
                    DR!ADD_TIME_EDIT = TIME_EDIT.Text

                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                End If
                '=====================================حذف التفاصيل من الأيصال ========================
                Dim CMD_DEL As New SqlClient.SqlCommand
                CMD_DEL.Connection = SqlConn
                CMD_DEL.CommandText = "DELETE FROM ADD_MONY_DT_DOCTOR WHERE ADD_CODE ='" & TXT_CODE.Text & "'"
                CMD_DEL.ExecuteNonQuery()
                '============================== أضافة تفاصيل الايصال ========================
                Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_DT_DOCTOR WHERE ADD_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                DA1.Fill(DT)
                For I = 0 To DataGridView1.Rows.Count - 1
                    Dim DR1 = DT.NewRow
                    DR1!ADD_CODE = TXT_CODE.Text
                    DR1!ADD_DATE = TXT_DATE.Text
                    DR1!CODE_ACTION = DataGridView1.Rows(I).Cells(0).Value
                    DR1!NAME_ACTION = DataGridView1.Rows(I).Cells(2).Value
                    DR1!PRICE_DOCE = DataGridView1.Rows(I).Cells(3).Value
                    DR1!MID = DataGridView1.Rows(I).Cells(1).Value
                    DR1!STAT_DT = True
                    DT.Rows.Add(DR1)
                    Dim CMD_ As New SqlClient.SqlCommandBuilder(DA1)
                    DA1.Update(DT)
                Next
                '=====================================حذف التفاصيل من الخزينة ========================
                Dim CMD_DEL2 As New SqlClient.SqlCommand
                CMD_DEL2.Connection = SqlConn
                CMD_DEL2.CommandText = "DELETE FROM KHAZINA_DT WHERE CODE_DT ='" & TXT_CODE.Text & "'AND CODE_DT2 = '1'"
                CMD_DEL2.ExecuteNonQuery()
                '============================== أضافة تفاصيل للخزينة ========================
                '============================== أضافة تفاصيل للخزينة ========================
                If TXT_TYPEMONY.SelectedIndex = 0 Then
                    Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA_DT", SqlConn)
                    DA2.Fill(DT)
                    Dim DR2 = DT.NewRow
                    DR2!KHAZINA_CODE = KHAZINA_CODE.Text
                    DR2!KHAZINA_DATE = TXT_DATE.Text
                    DR2!CODE_DT = TXT_CODE.Text
                    DR2!CODE_DT2 = "1"
                    DR2!KHAZINA_NAME_ACTION = "أيصال أستلام نقدية رقم " & TXT_CODE.Text & " العيادات "
                    DR2!KHAZINA_IN = SAFY.Text
                    DR2!MONY_TYPE = "نقدي"
                    DR2!KHAZINA_OUT = "0"
                    DR2!STAT_KHAZINA = True
                    DT.Rows.Add(DR2)
                    Dim CMD2_ As New SqlClient.SqlCommandBuilder(DA2)
                    DA2.Update(DT)
                End If

                If TXT_TYPEMONY.SelectedIndex = 1 Then
                    Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA_DT", SqlConn)
                    DA2.Fill(DT)
                    Dim DR2 = DT.NewRow
                    DR2!KHAZINA_CODE = KHAZINA_CODE.Text
                    DR2!KHAZINA_DATE = TXT_DATE.Text
                    DR2!CODE_DT = TXT_CODE.Text
                    DR2!CODE_DT2 = "1"
                    DR2!KHAZINA_NAME_ACTION = "أيصال أستلام نقدية فيزا رقم " & TXT_CODE.Text & " العيادات "
                    DR2!KHAZINA_IN = SAFY.Text
                    DR2!KHAZINA_OUT = "0"
                    DR2!MONY_TYPE = "فيزا"
                    DR2!STAT_KHAZINA = True
                    DT.Rows.Add(DR2)
                    Dim CMD2_ As New SqlClient.SqlCommandBuilder(DA2)
                    DA2.Update(DT)
                End If
                If TXT_TYPEMONY.SelectedIndex = 2 Then
                    Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA_DT", SqlConn)
                    DA2.Fill(DT)
                    Dim DR2 = DT.NewRow
                    DR2!KHAZINA_CODE = KHAZINA_CODE.Text
                    DR2!KHAZINA_DATE = TXT_DATE.Text
                    DR2!CODE_DT = TXT_CODE.Text
                    DR2!CODE_DT2 = "1"
                    DR2!KHAZINA_NAME_ACTION = "أيصال أستلام نقدية بريميوم كارد رقم " & TXT_CODE.Text & " العيادات "
                    DR2!KHAZINA_IN = SAFY.Text
                    DR2!KHAZINA_OUT = "0"
                    DR2!MONY_TYPE = "بريميوم كارد"
                    DR2!STAT_KHAZINA = True
                    DT.Rows.Add(DR2)
                    Dim CMD2_ As New SqlClient.SqlCommandBuilder(DA2)
                    DA2.Update(DT)
                End If

                '==========================================================================
                printedit()
                ' PRINTBTN_Click(sender, e)
                MessageBox.Show("تمت عملية تعديل بيانات الأيصال بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NEWBTN_Click(sender, e)
                'CALC()
                'Me.Close()
            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub DELETBTN_Click(sender As Object, e As EventArgs) Handles DELETBTN.Click
        '====================حفظ العيادة=============================

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
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_DOCTOR WHERE ADD_CODE = '" & TXT_CODE.Text & "'", SqlConn)
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
                Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_DT_DOCTOR WHERE ADD_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                DA1.Fill(DT1)
                Dim DR1 = DT1.Rows(0)

                DR1!STAT_DT = False
                Dim SAVE1 As New SqlClient.SqlCommandBuilder(DA1)
                DA1.Update(DT1)
                '=====================================حذف التفاصيل من الخزينة ========================
                Dim DT2 As New DataTable
                Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA_DT WHERE CODE_DT = '" & TXT_CODE.Text & "'AND CODE_DT2 = '1'", SqlConn)
                DA2.Fill(DT2)
                Dim DR2 = DT2.Rows(0)
                DR2!STAT_KHAZINA = False
                Dim SAVE2 As New SqlClient.SqlCommandBuilder(DA2)
                DA2.Update(DT2)
                '==========================================================================
                MessageBox.Show("تمت عملية حذف بيانات الأيصال بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NEWBTN_Click(sender, e)
            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub SEARCHBTN_Click(sender As Object, e As EventArgs) Handles SEARCHBTN.Click
        SEARCH_ADD_MONY.ShowDialog()
    End Sub

    Private Sub UNDOBTN_Click(sender As Object, e As EventArgs) Handles UNDOBTN.Click
        SEARCH_ADD_MONY2.ShowDialog()
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
                    .Columns.Add("PA_TYPE")
                    .Columns.Add("PA_AGE")
                    .Columns.Add("KHAZINA_NAME")
                    .Columns.Add("TAKH_NAME")
                    .Columns.Add("DO_NAME")
                    .Columns.Add("MID")
                    .Columns.Add("NAME_ACTION")
                    .Columns.Add("PRICE_DOCE")
                    .Columns.Add("ADD_TOTAL")
                    .Columns.Add("ADD_DIS")
                    .Columns.Add("ADD_SAFY")
                    .Columns.Add("ADD_SAFY_AR")
                    .Columns.Add("ADD_USER_ADD")
                    .Columns.Add("ADD_TYPE_MONY")
                End With
                For I As Integer = 0 To DataGridView1.Rows.Count - 1
                    If DataGridView1.Rows(I).Cells(0).Value <> Nothing Then
                        DT.Rows.Add(CODE_GENE("ADD_MONY_DOCTOR", "ID") + 1, TXT_DATE.Text, PA_CODE.Text, PA_NAME.Text, TXT_PA_TYPE.Text, TXT_AGE.Text, KHAZINA_NAME.Text, TA_TKHASOS.Text, TXT_DOCTOR.Text, DataGridView1.Rows(I).Cells(1).Value, DataGridView1.Rows(I).Cells(2).Value, DataGridView1.Rows(I).Cells(3).Value, TOTAL.Text, DISCOUNT.Text, SAFY.Text, SAFY_AR.Text, USER_ADD.Text, TXT_TYPEMONY.Text)
                    End If
                Next
                Dim REP As New ADD_MONY_REP
                REP.SetDataSource(DT)
                Dim FRM As New ADD_MONY_CRS
                FRM.CrystalReportViewer1.ReportSource = REP
                FRM.ShowDialog()
                '=============================================================
            Else
                MessageBox.Show("عفوا ليس لديك صلاحية للطباعة برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub
    Sub printedit()
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
                    .Columns.Add("PA_TYPE")
                    .Columns.Add("PA_AGE")
                    .Columns.Add("KHAZINA_NAME")
                    .Columns.Add("TAKH_NAME")
                    .Columns.Add("DO_NAME")
                    .Columns.Add("MID")
                    .Columns.Add("NAME_ACTION")
                    .Columns.Add("PRICE_DOCE")
                    .Columns.Add("ADD_TOTAL")
                    .Columns.Add("ADD_DIS")
                    .Columns.Add("ADD_SAFY")
                    .Columns.Add("ADD_SAFY_AR")
                    .Columns.Add("ADD_USER_ADD")
                    .Columns.Add("ADD_TYPE_MONY")
                End With
                For I As Integer = 0 To DataGridView1.Rows.Count - 1
                    If DataGridView1.Rows(I).Cells(0).Value <> Nothing Then
                        DT.Rows.Add(TXT_CODE.Text, TXT_DATE.Text, PA_CODE.Text, PA_NAME.Text, TXT_PA_TYPE.Text, TXT_AGE.Text, KHAZINA_NAME.Text, TA_TKHASOS.Text, TXT_DOCTOR.Text, DataGridView1.Rows(I).Cells(1).Value, DataGridView1.Rows(I).Cells(2).Value, DataGridView1.Rows(I).Cells(3).Value, TOTAL.Text, DISCOUNT.Text, SAFY.Text, SAFY_AR.Text, USER_ADD.Text, TXT_TYPEMONY.Text)
                    End If
                Next
                Dim REP As New ADD_MONY2_REP
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

    Private Sub PA_CODE_TextChanged(sender As Object, e As EventArgs) Handles PA_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_CODE='" & PA_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            PA_NAME.Text = DT.Rows(I).Item("PA_NAME")
            TXT_AGE.Text = DT.Rows(I).Item("PA_AGE")
            TXT_PA_TYPE.Text = DT.Rows(I).Item("PA_TYPE")
        Next
    End Sub

    Private Sub TA_CODE_TKHASOS_TextChanged(sender As Object, e As EventArgs) Handles TA_CODE_TKHASOS.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM TKHASOS WHERE TAKH_CODE ='" & TA_CODE_TKHASOS.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TA_TKHASOS.Text = DT.Rows(I).Item("TAKH_NAME")
        Next
    End Sub

    Private Sub CODE_DOCTOR_TextChanged(sender As Object, e As EventArgs) Handles CODE_DOCTOR.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORS WHERE DO_CODE ='" & CODE_DOCTOR.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_DOCTOR.Text = DT.Rows(I).Item("DO_NAME")
        Next
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
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
    Private Sub DISCOUNT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DISCOUNT.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Then
            Else
                MsgBox("من فضلك ادخل رقم صحيح فقط")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ADD_MONY2_DOCTOR_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'If e.KeyCode = Keys.P AndAlso e.Control Then
        '    PRINTBTN_Click(sender, e)
        'End If
        'If e.KeyCode = Keys.S AndAlso e.Control Then
        '    SAVEBTN_Click(sender, e)
        'End If
        'If e.KeyCode = Keys.E AndAlso e.Control Then
        '    EDITBTN_Click(sender, e)
        'End If
    End Sub

    Private Sub LAST_COME_Click(sender As Object, e As EventArgs) Handles LAST_COME.Click
        If PA_NAME.Text = "" Then
            MessageBox.Show("برجاء ادخال اسم المريض", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
            PA_NAME.Select()
            Exit Sub
        End If
        If CODE_DOCTOR.Text = "" Then
            MessageBox.Show("برجاء ادخال اسم الطبيب", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TXT_DOCTOR.Select()
            Exit Sub
        End If
        LASTCOMEFRM.ShowDialog()
    End Sub

    Private Sub TXT_CODE_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_CODE.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
            Try

                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_DOCTOR WHERE ADD_CODE ='" & TXT_CODE.Text & "' AND ADD_STAT = 'TRUE' ", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count = 0 Then
                    MessageBox.Show("يرجى التأكد من كود الأيصال", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    Dim DR = DT.Rows(0)

                    TXT_DATE.Text = DR!ADD_DATE
                    KHAZINA_CODE.Text = DR!CODE_KHAZINA
                    PA_CODE.Text = DR!ADD_PA_CODE
                    TA_CODE_TKHASOS.Text = DR!ADD_TKHASOS_CODE
                    CODE_DOCTOR.Text = DR!ADD_DOCTOR_CODE
                    TOTAL.Text = DR!ADD_TOTAL
                    DISCOUNT.Text = DR!ADD_DIS
                    SAFY.Text = DR!ADD_SAFY
                    SAFY_AR.Text = DR!ADD_SAFY_AR
                    TXT_TYPEMONY.Text = DR!ADD_TYPE_MONY
                    USER_ADD.Text = DR!ADD_USER_ADD
                    DATE_ADD.Text = DR!ADD_DATE_ADD
                    TIME_ADD.Text = DR!ADD_TIME_ADD

                    '=========== ربط تفاصيل الفاتورة =============
                    Dim DT10 As New DataTable
                    Dim DA10 As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_DT_DOCTOR WHERE ADD_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                    DA10.Fill(DT10)
                    For I = 0 To DT10.Rows.Count - 1
                        DataGridView1.Rows.Clear()
                        DataGridView1.Rows.Add()
                        DataGridView1.Rows(I).Cells(0).Value = DT10.Rows(I).Item("CODE_ACTION")
                        DataGridView1.Rows(I).Cells(2).Value = DT10.Rows(I).Item("NAME_ACTION")
                        DataGridView1.Rows(I).Cells(3).Value = DT10.Rows(I).Item("PRICE_DOCE")
                        DataGridView1.Rows(I).Cells(1).Value = DT10.Rows(I).Item("MID")
                    Next

                    TIMEREDIT.Enabled = True
                    TIMERADD.Enabled = False
                    CALC()
                    DATEF()
                End If

            Catch ex As Exception

            End Try
        End If




    End Sub

End Class