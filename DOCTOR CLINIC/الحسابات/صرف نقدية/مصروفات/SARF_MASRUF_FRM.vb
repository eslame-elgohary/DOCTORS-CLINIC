Public Class SARF_MASRUF_FRM
    Dim ARABIC As New ClassConvertNO
    Sub SHOW_DETA(CODE_)
        DataGridView1.Rows.Clear()
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
            TOTAL.Text = DR!OUT_TOTAL
            DISCOUNT.Text = DR!OUT_DIS
            SAFY.Text = DR!OUT_SAFY
            SAFY_AR.Text = DR!OUT_SAFY_AR

            USER_ADD.Text = DR!OUT_USER_ADD
            DATE_ADD.Text = DR!OUT_DATE_ADD
            TIME_ADD.Text = DR!OUT_TIME_ADD



            Dim DS As New DataSet
            '=========== ربط تفاصيل الفاتورة =============
            DA = New SqlClient.SqlDataAdapter("SELECT * FROM OUT_DT_MASROUF WHERE OUT_CODE = '" & CODE_ & "'", SqlConn)
            DS = New DataSet
            DA.Fill(DS)
            DT = DS.Tables(0)
            For I = 0 To DT.Rows.Count - 1
                DataGridView1.Rows.Add()
                DataGridView1.Rows(I).Cells(0).Value = DT.Rows(I).Item("CODE_ACTION")
                DataGridView1.Rows(I).Cells(2).Value = DT.Rows(I).Item("NAME_ACTION")
                DataGridView1.Rows(I).Cells(3).Value = DT.Rows(I).Item("PRICE_ACTION")
                DataGridView1.Rows(I).Cells(1).Value = DT.Rows(I).Item("MID")
                DataGridView1.Rows(I).Cells(4).Value = DT.Rows(I).Item("INFO_ACTION")
            Next

            For QQ = 0 To DataGridView1.Rows.Count - 1
                TXT_M.Text = Val(DataGridView1.Rows(QQ).Cells(1).Value) + 1
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
        '""""""""""""""" الترقيم التلقائي """"""""""""""
        TXT_CODE.Text = CODE_GENE("OUT_MASROUF", "ID") + 1
        '""""""""""""""""""""""""""""""
        EDITBTN.Enabled = False
        DELETBTN.Enabled = False
        SAVEBTN.Enabled = True
        TIMERADD.Enabled = True
        TIMEREDIT.Enabled = False
        TXT_M.Text = "1"
        FILL_KHAZINA_CODE()
        TXT_ACTION.Select()
        FILL_MASROUF()
        CALC()
    End Sub

    Private Sub SARF_MASRUF_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEWBTN_Click(sender, e)
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
    Sub FILL_MASROUF()
        TXT_ACTION.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM MASROUF WHERE STAT='TRUE' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_ACTION.Items.Add(DT.Rows(I).Item("MASROF_NAME"))

        Next
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
                CALC()
                If TOTAL.Text < 1 Then
                    MessageBox.Show("برجاء ادخال المصروفات المراد حفظها ", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_ACTION.Select()
                    Exit Sub
                End If
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
                    DR!OUT_TYPE = "مصروفات"
                    DR!CODE_KHAZINA = KHAZINA_CODE.Text

                    DR!OUT_TOTAL = TOTAL.Text
                    DR!OUT_DIS = DISCOUNT.Text
                    DR!OUT_SAFY = SAFY.Text
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
                Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM OUT_DT_MASROUF", SqlConn)
                DA1.Fill(DT)
                For I = 0 To DataGridView1.Rows.Count - 1
                    Dim DR1 = DT.NewRow
                    DR1!OUT_CODE = TXT_CODE.Text
                    DR1!OUT_DATE = TXT_DATE.Text
                    DR1!CODE_ACTION = DataGridView1.Rows(I).Cells(0).Value
                    DR1!NAME_ACTION = DataGridView1.Rows(I).Cells(2).Value
                    DR1!PRICE_ACTION = DataGridView1.Rows(I).Cells(3).Value
                    DR1!MID = DataGridView1.Rows(I).Cells(1).Value
                    DR1!INFO_ACTION = DataGridView1.Rows(I).Cells(4).Value
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
                DR2!KHAZINA_NAME_ACTION = "أيصال صرف نقدية رقم " & TXT_CODE.Text & " المصروفات "
                DR2!KHAZINA_IN = "0"
                DR2!KHAZINA_OUT = SAFY.Text
                DR2!MONY_TYPE = "نقدي"
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
            If DT0.Rows(0).Item("O2").ToString = True Then
                '========= قيود الادخال =======================
                CALC()
                If TOTAL.Text < 1 Then
                    MessageBox.Show("برجاء ادخال المصروفات المراد حفظها ", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_ACTION.Select()
                    Exit Sub
                End If
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
                    DR!OUT_TYPE = "مصروفات"
                    DR!CODE_KHAZINA = KHAZINA_CODE.Text
                    DR!OUT_TOTAL = TOTAL.Text
                    DR!OUT_DIS = DISCOUNT.Text
                    DR!OUT_SAFY = SAFY.Text
                    DR!OUT_SAFY_AR = SAFY_AR.Text
                    DR!OUT_STAT = True

                    DR!OUT_USER_EDIT = USER_EDIT.Text
                    DR!OUT_DATE_EDIT = DATE_EDIT.Text
                    DR!OUT_TIME_EDIT = TIME_EDIT.Text

                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                End If
                '=====================================حذف التفاصيل من الأيصال ========================
                Dim CMD_DEL As New SqlClient.SqlCommand
                CMD_DEL.Connection = SqlConn
                CMD_DEL.CommandText = "DELETE FROM OUT_DT_MASROUF WHERE OUT_CODE ='" & TXT_CODE.Text & "'"
                CMD_DEL.ExecuteNonQuery()

                '============================== أضافة تفاصيل الايصال ========================
                Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM OUT_DT_MASROUF", SqlConn)
                DA1.Fill(DT)
                For I = 0 To DataGridView1.Rows.Count - 1
                    Dim DR1 = DT.NewRow
                    DR1!OUT_CODE = TXT_CODE.Text
                    DR1!OUT_DATE = TXT_DATE.Text
                    DR1!CODE_ACTION = DataGridView1.Rows(I).Cells(0).Value
                    DR1!NAME_ACTION = DataGridView1.Rows(I).Cells(2).Value
                    DR1!PRICE_ACTION = DataGridView1.Rows(I).Cells(3).Value
                    DR1!MID = DataGridView1.Rows(I).Cells(1).Value
                    DR1!INFO_ACTION = DataGridView1.Rows(I).Cells(4).Value
                    DT.Rows.Add(DR1)
                    Dim CMD_ As New SqlClient.SqlCommandBuilder(DA1)
                    DA1.Update(DT)
                Next
                '=====================================حذف التفاصيل من الخزينة ========================
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
                DR2!KHAZINA_NAME_ACTION = "أيصال صرف نقدية رقم " & TXT_CODE.Text & " المصروفات "
                DR2!KHAZINA_IN = "0"
                DR2!KHAZINA_OUT = SAFY.Text
                DR2!MONY_TYPE = "نقدي"
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
        '====================حفظ العيادة=============================

        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("O3").ToString = True Then
                '================= تخزين بيانات الصنف في قاعدة البيانات =============
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM OUT_MASROUF WHERE OUT_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count = 0 Then
                    MessageBox.Show("يوجد أيصال أخر لهذا المصروف اليوم، يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim DR = DT.Rows(0)

                    DR!OUT_STAT = False
                    DR!OUT_USER_EDIT = USER_EDIT.Text
                    DR!OUT_DATE_EDIT = DATE_EDIT.Text
                    DR!OUT_TIME_EDIT = TIME_EDIT.Text

                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                End If

                '=====================================حذف التفاصيل من الأيصال ========================
                Dim CMD_DEL As New SqlClient.SqlCommand
                CMD_DEL.Connection = SqlConn
                CMD_DEL.CommandText = "DELETE FROM OUT_DT_MASROUF WHERE OUT_CODE ='" & TXT_CODE.Text & "'"
                CMD_DEL.ExecuteNonQuery()
                '=====================================حذف التفاصيل من الخزينة ========================
                Dim CMD_DEL2 As New SqlClient.SqlCommand
                CMD_DEL2.Connection = SqlConn
                CMD_DEL2.CommandText = "DELETE FROM KHAZINA_DT WHERE CODE_DT ='" & TXT_CODE.Text & "'"
                CMD_DEL2.ExecuteNonQuery()
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
        SEARCH_MASROUF.ShowDialog()
    End Sub

    Private Sub UNDOBTN_Click(sender As Object, e As EventArgs) Handles UNDOBTN.Click
        SEARCH_MASROUF2.ShowDialog()
    End Sub

    Private Sub PRINTBTN_Click(sender As Object, e As EventArgs) Handles PRINTBTN.Click

    End Sub

    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub

    Private Sub ACTIVE_DOCTOR_Click(sender As Object, e As EventArgs) Handles ACTIVE_DOCTOR.Click
        If TXT_ACTION.SelectedIndex < 0 Then
            MessageBox.Show("برجاء ادخال نوع المصروف ؟ ", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_ACTION.Select()
            Exit Sub
        End If
        If TXT_PRICE.Text = "" Then
            MessageBox.Show("برجاء ادخال قيمة المصروف ؟ ", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PRICE.Select()
            Exit Sub
        End If
        If TXT_PRICE.Text < 1 Then
            MessageBox.Show("برجاء ادخال قيمة المصروف ؟ ", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PRICE.Select()
            Exit Sub
        End If
        If TXT_INFO_ACTION.Text = "" Then
            MessageBox.Show("برجاء ادخال تفاصيل المصروف ؟ ", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_INFO_ACTION.Select()
            Exit Sub
        End If


        Dim BAR As Integer
        '======= اضافة سجل للداتا جريد ===========
        DataGridView1.Rows.Add()
        BAR = DataGridView1.Rows.Count - 1
        DataGridView1(0, BAR).Value = TXT_ACTION_CODE.Text
        DataGridView1(2, BAR).Value = TXT_ACTION.Text
        DataGridView1(3, BAR).Value = TXT_PRICE.Text
        DataGridView1(4, BAR).Value = TXT_INFO_ACTION.Text
        DataGridView1(1, BAR).Value = TXT_M.Text
        DISCOUNT.Text = "0"
        CALC()

        TXT_ACTION.Text = ""
        TXT_ACTION_CODE.Text = ""
        TXT_PRICE.Text = ""
        For QS = 0 To DataGridView1.Rows.Count - 1
            TXT_M.Text = Val(DataGridView1.Rows(QS).Cells(1).Value) + 1
        Next

        TXT_ACTION.Select()
    End Sub

    Private Sub DISCOUNT_TextChanged(sender As Object, e As EventArgs) Handles DISCOUNT.TextChanged
        CALC()
    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        'For I As Integer = 0 To DataGridView1.Rows.Count - 1
        '    DataGridView1.Rows(I).Cells(5).Value = "حذف"
        '    Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        '    TXT_M.Text = Val(DataGridView1.Rows(I).Cells(1).Value) + 1
        'Next

    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        'For Each ROW As DataGridViewRow In DataGridView1.Rows
        '    If DataGridView1(5, DataGridView1.CurrentRow.Index).Selected = True Then
        '        DataGridView1.Rows.Remove(ROW)
        '    End If
        'Next
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
    Private Sub TXT_PRICE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_PRICE.KeyPress
        'If Char.IsControl(e.KeyChar) = False Then
        '    If Char.IsDigit(e.KeyChar) Then
        '    Else
        '        MsgBox("من فضلك ادخل رقم صحيح فقط")
        '        e.Handled = True
        '    End If
        'End If

        PressOnlyNumeric(e)   ' إدخال أرقام فقط

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("N").ToString = True Then
                '===========================================================
                MASROF.ShowDialog()
                '=============================================================
            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub TXT_ACTION_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_ACTION.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM MASROUF WHERE MASROF_NAME='" & TXT_ACTION.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_ACTION_CODE.Text = DT.Rows(I).Item("MASROF_CODE")
        Next
    End Sub

    Private Sub SARF_MASRUF_FRM_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
End Class