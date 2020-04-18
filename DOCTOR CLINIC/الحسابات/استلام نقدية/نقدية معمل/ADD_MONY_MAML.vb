Public Class ADD_MONY_MAML
    Dim ARABIC As New ClassConvertNO
    Sub SHOW_DETA(CODE_)
        DataGridView1.Rows.Clear()
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
            MAML_CODE.Text = DR!ADD_MAML_CODE
            TOTAL.Text = DR!ADD_TOTAL
            DISCOUNT.Text = DR!ADD_DIS
            SAFY.Text = DR!ADD_SAFY
            SAFY_AR.Text = DR!ADD_SAFY_AR

            USER_ADD.Text = DR!ADD_USER_ADD
            DATE_ADD.Text = DR!ADD_DATE_ADD
            TIME_ADD.Text = DR!ADD_TIME_ADD



            Dim DS As New DataSet
            '=========== ربط تفاصيل الفاتورة =============
            DA = New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_DT_MAML WHERE ADD_CODE = '" & CODE_ & "'", SqlConn)
            DS = New DataSet
            DA.Fill(DS)
            DT = DS.Tables(0)
            For I = 0 To DT.Rows.Count - 1
                DataGridView1.Rows.Add()
                DataGridView1.Rows(I).Cells(2).Value = DT.Rows(I).Item("CODE_MAML")
                DataGridView1.Rows(I).Cells(3).Value = DT.Rows(I).Item("NAME_MAML")
                DataGridView1.Rows(I).Cells(4).Value = DT.Rows(I).Item("CODE_THLEL")
                DataGridView1.Rows(I).Cells(5).Value = DT.Rows(I).Item("NAME_THLEL")
                DataGridView1.Rows(I).Cells(6).Value = DT.Rows(I).Item("PRICE_THLEL")
                DataGridView1.Rows(I).Cells(1).Value = DT.Rows(I).Item("MID")


            Next
            For I = 0 To DataGridView1.Rows.Count - 1
                TXT_M.Text = Val(DataGridView1.Rows(I).Cells(1).Value) + 1
            Next

            DELETBTN.Enabled = True
            EDITBTN.Enabled = True
            SAVEBTN.Enabled = False
            TIMEREDIT.Enabled = True
            TIMERADD.Enabled = False
            CALC()
        End If
    End Sub
    Sub CALC()
        '==== انشاء العملية الحسابية =======
        Dim TOTAL_ As Double

        For I = 0 To DataGridView1.Rows.Count - 1
            TOTAL_ = Val(TOTAL_) + Val(DataGridView1.Rows(I).Cells(6).Value)
        Next
        TOTAL.Text = Val(TOTAL_)
        SAFY.Text = Val(TOTAL.Text) - Val(DISCOUNT.Text)

        If Val(TOTAL.Text) > 0 Then
            SAFY_AR.Text = ARABIC.ConvertToArabic(SAFY.Text)
        Else
            SAFY_AR.Text = ""
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
    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles NEWBTN.Click
        TIMERADD.Enabled = True
        TIMEREDIT.Enabled = False
        FILL_KHAZINA()
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
        MAML_NAME.Items.Clear()
        TH_NAME.Items.Clear()

        '""""""""""""""" الترقيم التلقائي """"""""""""""
        TXT_CODE.Text = CODE_GENE("ADD_MONY_MAML", "ID") + 1
        '""""""""""""""""""""""""""""""
        EDITBTN.Enabled = False
        DELETBTN.Enabled = False
        SAVEBTN.Enabled = True
        TXT_M.Text = "1"
        FILL_KHAZINA_CODE()
        PA_NAME.Select()
        FILL_PATIENT()
        CALC()
    End Sub

    Private Sub ADD_MONY_MAML_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEWBTN_Click(sender, e)

    End Sub

    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click
        '====================حفظ العيادة=============================

        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("Q1").ToString = True Then
                '========= قيود الادخال =======================
                If PA_NAME.Text = "" Then
                    MessageBox.Show("برجاء ادخال اسم المريض", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PA_NAME.Select()
                    Exit Sub
                End If
                If TOTAL.Text < 1 Then
                    MessageBox.Show("برجاء ادخال التحاليل المطلوبة ", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TH_NAME.Select()
                    Exit Sub
                End If

                '================= تخزين بيانات الصنف في قاعدة البيانات =============
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_MAML WHERE ADD_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count > 0 Then
                    MessageBox.Show("يوجد أيصال أخر لهذا المريض اليوم، يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim DR = DT.NewRow
                    DR!ADD_CODE = TXT_CODE.Text
                    DR!ADD_DATE = TXT_DATE.Text
                    DR!ADD_TYPE = "المعامل"
                    DR!CODE_KHAZINA = KHAZINA_CODE.Text
                    DR!ADD_PA_CODE = PA_CODE.Text
                    DR!ADD_MAML_CODE = MAML_CODE.Text
                    DR!ADD_TOTAL = TOTAL.Text
                    DR!ADD_DIS = DISCOUNT.Text
                    DR!ADD_SAFY = SAFY.Text
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
                For I = 0 To DataGridView1.Rows.Count - 1
                    Dim DR1 = DT.NewRow
                    DR1!ADD_CODE = TXT_CODE.Text
                    DR1!ADD_DATE = TXT_DATE.Text
                    DR1!MID = DataGridView1.Rows(I).Cells(1).Value
                    DR1!CODE_MAML = DataGridView1.Rows(I).Cells(2).Value
                    DR1!NAME_MAML = DataGridView1.Rows(I).Cells(3).Value
                    DR1!CODE_THLEL = DataGridView1.Rows(I).Cells(4).Value
                    DR1!NAME_THLEL = DataGridView1.Rows(I).Cells(5).Value
                    DR1!PRICE_THLEL = DataGridView1.Rows(I).Cells(6).Value

                    DR1!STAT_DT = True
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
                DR2!CODE_DT2 = "2"
                DR2!KHAZINA_NAME_ACTION = "أيصال أستلام نقدية رقم " & TXT_CODE.Text & " المعمل "
                DR2!KHAZINA_IN = SAFY.Text
                DR2!KHAZINA_OUT = "0"
                DR2!STAT_KHAZINA = True
                DT.Rows.Add(DR2)
                Dim CMD2_ As New SqlClient.SqlCommandBuilder(DA2)
                DA2.Update(DT)

                '==========================================================================
                PRINTBTN_Click(sender, e)
                MessageBox.Show("تمت عملية حفظ بيانات الأيصال بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NEWBTN_Click(sender, e)
                CALC()
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
            If DT0.Rows(0).Item("Q2").ToString = True Then
                '========= قيود الادخال =======================
                If PA_NAME.Text = "" Then
                    MessageBox.Show("برجاء ادخال اسم المريض", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    PA_NAME.Select()
                    Exit Sub
                End If
                If TOTAL.Text < 1 Then
                    MessageBox.Show("برجاء ادخال التحاليل المطلوبة ", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TH_NAME.Select()
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
                    DR!ADD_DATE = TXT_DATE.Text
                    DR!ADD_TYPE = "المعامل"
                    DR!CODE_KHAZINA = KHAZINA_CODE.Text
                    DR!ADD_PA_CODE = PA_CODE.Text
                    DR!ADD_MAML_CODE = MAML_CODE.Text
                    DR!ADD_TOTAL = TOTAL.Text
                    DR!ADD_DIS = DISCOUNT.Text
                    DR!ADD_SAFY = SAFY.Text
                    DR!ADD_SAFY_AR = SAFY_AR.Text
                    DR!ADD_STAT = True
                    DR!ADD_USER_ADD = USER_ADD.Text
                    DR!ADD_DATE_ADD = DATE_ADD.Text
                    DR!ADD_TIME_ADD = TIME_ADD.Text
                    DR!ADD_USER_EDIT = "0"
                    DR!ADD_DATE_EDIT = "0"
                    DR!ADD_TIME_EDIT = "0"

                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                End If

                '=====================================حذف التفاصيل من الأيصال ========================
                Dim CMD_DEL As New SqlClient.SqlCommand
                CMD_DEL.Connection = SqlConn
                CMD_DEL.CommandText = "DELETE FROM ADD_MONY_DT_MAML WHERE ADD_CODE ='" & TXT_CODE.Text & "'"
                CMD_DEL.ExecuteNonQuery()
                '============================== أضافة تفاصيل الايصال ========================
                Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_MONY_DT_MAML", SqlConn)
                DA1.Fill(DT)
                For I = 0 To DataGridView1.Rows.Count - 1
                    Dim DR1 = DT.NewRow
                    DR1!ADD_CODE = TXT_CODE.Text
                    DR1!ADD_DATE = TXT_DATE.Text
                    DR1!MID = DataGridView1.Rows(I).Cells(1).Value
                    DR1!CODE_MAML = DataGridView1.Rows(I).Cells(2).Value
                    DR1!NAME_MAML = DataGridView1.Rows(I).Cells(3).Value
                    DR1!CODE_THLEL = DataGridView1.Rows(I).Cells(4).Value
                    DR1!NAME_THLEL = DataGridView1.Rows(I).Cells(5).Value
                    DR1!PRICE_THLEL = DataGridView1.Rows(I).Cells(6).Value

                    DR1!STAT_DT = True
                    DT.Rows.Add(DR1)
                    Dim CMD_ As New SqlClient.SqlCommandBuilder(DA1)
                    DA1.Update(DT)
                Next
                '==========================================================================
                '=====================================حذف التفاصيل من الخزينة ========================
                Dim CMD_DEL2 As New SqlClient.SqlCommand
                CMD_DEL2.Connection = SqlConn
                CMD_DEL2.CommandText = "DELETE FROM KHAZINA_DT WHERE CODE_DT ='" & TXT_CODE.Text & "'AND CODE_DT2 = '2' "
                CMD_DEL2.ExecuteNonQuery()
                '==========================================================================
                '============================== أضافة تفاصيل للخزينة ========================
                Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA_DT", SqlConn)
                DA2.Fill(DT)
                Dim DR2 = DT.NewRow
                DR2!KHAZINA_CODE = KHAZINA_CODE.Text
                DR2!KHAZINA_DATE = TXT_DATE.Text
                DR2!CODE_DT = TXT_CODE.Text
                DR2!CODE_DT2 = "2"
                DR2!KHAZINA_NAME_ACTION = "أيصال أستلام نقدية رقم " & TXT_CODE.Text & " المعمل "
                DR2!KHAZINA_IN = SAFY.Text
                DR2!KHAZINA_OUT = "0"
                DR2!STAT_KHAZINA = True
                DT.Rows.Add(DR2)
                Dim CMD2_ As New SqlClient.SqlCommandBuilder(DA2)
                DA2.Update(DT)

                '==========================================================================
                PRINTBTN_Click(sender, e)
                MessageBox.Show("تمت عملية حفظ بيانات الأيصال بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NEWBTN_Click(sender, e)
                CALC()
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
            If DT0.Rows(0).Item("Q3").ToString = True Then
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
                '==========================================================================
                MessageBox.Show("تمت عملية حذف بيانات الأيصال بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NEWBTN_Click(sender, e)
                CALC()
            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub SEARCHBTN_Click(sender As Object, e As EventArgs) Handles SEARCHBTN.Click
        SEARCH_ADD_MONY3.ShowDialog()
    End Sub

    Private Sub UNDOBTN_Click(sender As Object, e As EventArgs) Handles UNDOBTN.Click
        SEARCH_ADD_MONY4.ShowDialog()
    End Sub

    Private Sub PRINTBTN_Click(sender As Object, e As EventArgs) Handles PRINTBTN.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("Q4").ToString = True Then
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
                    .Columns.Add("NAME_MAML")
                    .Columns.Add("MID")
                    .Columns.Add("NAME_THLEL")
                    .Columns.Add("PRICE_THLEL")
                    .Columns.Add("ADD_TOTAL")
                    .Columns.Add("ADD_DIS")
                    .Columns.Add("ADD_SAFY")
                    .Columns.Add("ADD_SAFY_AR")
                    .Columns.Add("ADD_USER_ADD")
                End With
                For I As Integer = 0 To DataGridView1.Rows.Count - 1
                    If DataGridView1.Rows(I).Cells(0).Value <> Nothing Then
                        DT.Rows.Add(TXT_CODE.Text, TXT_DATE.Text, PA_CODE.Text, PA_NAME.Text, TXT_PA_TYPE.Text, TXT_AGE.Text, KHAZINA_NAME.Text, MAML_NAME.Text, DataGridView1.Rows(I).Cells(1).Value, DataGridView1.Rows(I).Cells(5).Value, DataGridView1.Rows(I).Cells(6).Value, TOTAL.Text, DISCOUNT.Text, SAFY.Text, SAFY_AR.Text, USER_ADD.Text)
                    End If
                Next
                Dim REP As New ADD_MONY_MAML_REP
                REP.SetDataSource(DT)
                Dim FRM As New ADD_MONY_MAML_CRS
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

    Private Sub ADD_MONY_MAML_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.P AndAlso e.Control Then
            PRINTBTN_Click(sender, e)
        End If
        If e.KeyCode = Keys.S AndAlso e.Control Then
            SAVEBTN_Click(sender, e)
        End If
        If e.KeyCode = Keys.E AndAlso e.Control Then
            EDITBTN_Click(sender, e)
        End If
    End Sub

    Private Sub DISCOUNT_TextChanged(sender As Object, e As EventArgs) Handles DISCOUNT.TextChanged
        CALC()
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
    Sub FILL_PATIENT()
        PA_NAME.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE STAT='TRUE' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            PA_NAME.Items.Add(DT.Rows(I).Item("PA_NAME"))
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
        FILL_MAML()
    End Sub
    Sub FILL_MAML()
        DataGridView1.Rows.Clear()
        CALC()
        TXT_M.Text = "1"
        MAML_NAME.Items.Clear()
        TH_NAME.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM MAML WHERE STAT='TRUE'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            MAML_NAME.Items.Add(DT.Rows(I).Item("MAML_NAME"))
        Next
    End Sub
    Private Sub MAML_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MAML_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM MAML WHERE MAML_NAME='" & MAML_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            MAML_CODE.Text = DT.Rows(I).Item("MAML_CODE")
        Next
        FILL_THLEL()
        TH_NAME.Text = ""
        TH_CODE.Text = ""
        TH_PRICE.Text = ""

    End Sub
    Sub FILL_THLEL()
        DataGridView1.Rows.Clear()
        CALC()
        TXT_M.Text = "1"
        TH_NAME.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PRICETHLEL WHERE STAT='TRUE' AND MAML_CODE='" & MAML_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TH_NAME.Items.Add(DT.Rows(I).Item("THLIL_NAME"))
        Next
    End Sub
    Private Sub TH_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TH_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PRICETHLEL WHERE STAT='TRUE' AND MAML_CODE='" & MAML_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TH_CODE.Text = DT.Rows(I).Item("THLIL_CODE")
            TH_PRICE.Text = DT.Rows(I).Item("PRICEEG")
        Next
    End Sub

    Private Sub ACTIVE_MAML_Click(sender As Object, e As EventArgs) Handles ACTIVE_MAML.Click
        Dim BAR As Integer
        '======= اضافة سجل للداتا جريد ===========
        DataGridView1.Rows.Add()
        BAR = DataGridView1.Rows.Count - 1
        DataGridView1(0, BAR).Value = TXT_CODE.Text
        DataGridView1(1, BAR).Value = TXT_M.Text
        DataGridView1(2, BAR).Value = MAML_CODE.Text
        DataGridView1(3, BAR).Value = MAML_NAME.Text
        DataGridView1(4, BAR).Value = TH_CODE.Text
        DataGridView1(5, BAR).Value = TH_NAME.Text
        DataGridView1(6, BAR).Value = TH_PRICE.Text

        DISCOUNT.Text = "0"
        CALC()

        TH_NAME.Text = ""
        TH_CODE.Text = ""
        TH_PRICE.Text = ""
        For I = 0 To DataGridView1.Rows.Count - 1
            TXT_M.Text = Val(DataGridView1.Rows(I).Cells(1).Value) + 1
        Next
        TH_NAME.Select()
    End Sub
    Private Sub MAML_CODE_TextChanged(sender As Object, e As EventArgs) Handles MAML_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM MAML WHERE MAML_CODE='" & MAML_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            MAML_NAME.Text = DT.Rows(I).Item("MAML_NAME")
        Next
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

    Private Sub TIM_CALC_Tick(sender As Object, e As EventArgs) Handles TIM_CALC.Tick
        CALC()
    End Sub
End Class