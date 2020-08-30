Public Class CONVERT_KHAZINA_FRM
    Sub SHOW_DETA(CODE_)
        '=========== ربط رأس الفاتورة =============
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM CONVERT_KHAZINA WHERE CON_CODE ='" & CODE_ & "'", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("يرجى التأكد من كود الأيصال", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!CON_CODE
            TXT_DATE.Text = DR!CON_DATE
            CODE_KHAZINA1.Text = DR!KHAZINA1_CODE
            CODE_KHAZINA2.Text = DR!KHAZINA2_CODE
            MONY1.Text = DR!MONY1
            MONY2.Text = DR!MONY2

            USER_ADD.Text = DR!USER_ADD
            DATE_ADD.Text = DR!DATE_ADD
            TIME_ADD.Text = DR!TIME_ADD

            DELETBTN.Enabled = True
            EDITBTN.Enabled = True
            SAVEBTN.Enabled = False
            TIMEREDIT.Enabled = True
            TIMERADD.Enabled = False

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

        '""""""""""""""" الترقيم التلقائي """"""""""""""
        TXT_CODE.Text = CODE_GENE("CONVERT_KHAZINA", "ID") + 1
        '""""""""""""""""""""""""""""""
        EDITBTN.Enabled = False
        DELETBTN.Enabled = False
        SAVEBTN.Enabled = True
        TIMERADD.Enabled = True
        TIMEREDIT.Enabled = False
        MONY1.Enabled = False
        MONY2.Enabled = False
        Timer1.Enabled = True
        FILL_KHAZINA()

    End Sub
    Sub FILL_KHAZINA()
        KHAZINA1.Items.Clear()
        KHAZINA2.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA WHERE STAT='TRUE'  ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            KHAZINA1.Items.Add(DT.Rows(I).Item("KHAZINA_NAME"))
            KHAZINA2.Items.Add(DT.Rows(I).Item("KHAZINA_NAME"))
        Next

    End Sub
    Private Sub CONVERT_KHAZINA_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEWBTN_Click(sender, e)
    End Sub

    Private Sub MONY1_TextChanged(sender As Object, e As EventArgs) Handles MONY1.TextChanged

    End Sub

    Private Sub MONY2_TextChanged(sender As Object, e As EventArgs) Handles MONY2.TextChanged

    End Sub

    Private Sub MONY1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MONY1.KeyPress
        'If Char.IsControl(e.KeyChar) = False Then
        '    If Char.IsDigit(e.KeyChar) Then
        '    Else
        '        MsgBox("من فضلك ادخل رقم صحيح فقط")
        '        e.Handled = True
        '    End If
        'End If
        PressOnlyNumeric(e)   ' إدخال أرقام فقط
    End Sub

    Private Sub MONY2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MONY2.KeyPress
        'If Char.IsControl(e.KeyChar) = False Then
        '    If Char.IsDigit(e.KeyChar) Then
        '    Else
        '        MsgBox("من فضلك ادخل رقم صحيح فقط")
        '        e.Handled = True
        '    End If
        'End If
        PressOnlyNumeric(e)   ' إدخال أرقام فقط
    End Sub

    Private Sub KHAZINA1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KHAZINA1.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA WHERE KHAZINA_NAME='" & KHAZINA1.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            CODE_KHAZINA1.Text = DT.Rows(I).Item("KHAZINA_CODE")
            START1.Text = DT.Rows(I).Item("KHAZINA_START")
        Next
        FILL_DGV(DataGridView1, "SELECT * FROM KHAZINA_DT WHERE KHAZINA_CODE='" & CODE_KHAZINA1.Text & "'AND STAT_KHAZINA ='TRUE'")

        Dim IN_, OUT_ As Double

        For I = 0 To DataGridView1.Rows.Count - 1
            IN_ = Val(IN_) + Val(DataGridView1.Rows(I).Cells(1).Value)
        Next
        TIN1.Text = Val(IN_)
        For I = 0 To DataGridView1.Rows.Count - 1
            OUT_ = Val(OUT_) + Val(DataGridView1.Rows(I).Cells(2).Value)
        Next
        TOUT1.Text = Val(OUT_)

        RASED1.Text = Val(Val(TIN1.Text) + Val(START1.Text)) - Val(TOUT1.Text)

        If CODE_KHAZINA2.Text = "" Then
            Exit Sub
        Else
            MONY1.Enabled = True
        End If
    End Sub

    Private Sub KHAZINA2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KHAZINA2.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA WHERE KHAZINA_NAME='" & KHAZINA2.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            CODE_KHAZINA2.Text = DT.Rows(I).Item("KHAZINA_CODE")
            START2.Text = DT.Rows(I).Item("KHAZINA_START")
        Next
        FILL_DGV(DataGridView2, "SELECT * FROM KHAZINA_DT WHERE KHAZINA_CODE='" & CODE_KHAZINA2.Text & "'AND STAT_KHAZINA ='TRUE'")

        Dim IN2_, OUT2_ As Double

        For I = 0 To DataGridView2.Rows.Count - 1
            IN2_ = Val(IN2_) + Val(DataGridView2.Rows(I).Cells(1).Value)
        Next
        TIN2.Text = Val(IN2_)
        For I = 0 To DataGridView2.Rows.Count - 1
            OUT2_ = Val(OUT2_) + Val(DataGridView2.Rows(I).Cells(2).Value)
        Next
        TOUT2.Text = Val(OUT2_)

        RASED2.Text = Val(Val(TIN2.Text) + Val(START2.Text)) - Val(TOUT2.Text)

        If CODE_KHAZINA1.Text = "" Then
            Exit Sub
        Else
            MONY1.Enabled = True
        End If

    End Sub

    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click
        '====================حفظ =============================

        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("R1").ToString = True Then
                '========= قيود الادخال =======================
                If KHAZINA1.Text = "" Then
                    MessageBox.Show("برجاء أختيار الخزينة المحول منها", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    KHAZINA1.Select()
                    Exit Sub
                End If
                If KHAZINA2.Text = "" Then
                    MessageBox.Show("برجاء أختيار الخزينة المحول إليها", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    KHAZINA2.Select()
                    Exit Sub
                End If
                If MONY1.Text = "" Then
                    MessageBox.Show("برجاء مبلغ التحويل", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MONY1.Select()
                    Exit Sub
                End If
                If KHAZINA2.Text = KHAZINA1.Text Then
                    MessageBox.Show("لا يمكن التحويل بين نفس الخزينة", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    KHAZINA2.Select()
                    Exit Sub
                End If
                If MONY1.Text > RASED1.Text Then
                    MessageBox.Show("لا يمكن التحويل حيث أن المبلغ المراد تحويلة أكبر من المبلغ المتواجد بالخزينة", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    MONY1.Select()
                    Exit Sub
                End If
                '================= تخزين بيانات الصنف في قاعدة البيانات =============
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM CONVERT_KHAZINA WHERE CON_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count > 0 Then
                    MessageBox.Show("يوجد تحويل أخر بنفس اليوم، يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    '""""""""""""""" الترقيم التلقائي """"""""""""""
                    TXT_CODE.Text = CODE_GENE("CONVERT_KHAZINA", "ID") + 1
                    '""""""""""""""""""""""""""""""
                    Dim DR = DT.NewRow
                    DR!CON_CODE = TXT_CODE.Text
                    DR!CON_DATE = TXT_DATE.Text
                    DR!KHAZINA1_CODE = CODE_KHAZINA1.Text
                    DR!KHAZINA2_CODE = CODE_KHAZINA2.Text
                    DR!MONY1 = MONY1.Text
                    DR!MONY2 = MONY2.Text
                    DR!STAT = True
                    DR!USER_ADD = USER_ADD.Text
                    DR!DATE_ADD = DATE_ADD.Text
                    DR!TIME_ADD = TIME_ADD.Text
                    DR!USER_EDIT = "0"
                    DR!DATE_EDIT = "0"
                    DR!TIME_EDIT = "0"

                    DT.Rows.Add(DR)
                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                End If
                '============================== أضافة تفاصيل للخزينة ========================
                Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA_DT", SqlConn)
                DA2.Fill(DT)
                Dim DR2 = DT.NewRow
                DR2!KHAZINA_CODE = CODE_KHAZINA2.Text
                DR2!KHAZINA_DATE = TXT_DATE.Text
                DR2!CODE_DT = TXT_CODE.Text
                DR2!CODE_DT2 = "4"
                DR2!KHAZINA_NAME_ACTION = "أيصال تحويل نقدية رقم " & TXT_CODE.Text & ""
                DR2!KHAZINA_IN = MONY2.Text
                DR2!KHAZINA_OUT = "0"
                DR2!STAT_KHAZINA = True
                DT.Rows.Add(DR2)
                Dim CMD2_ As New SqlClient.SqlCommandBuilder(DA2)
                DA2.Update(DT)
                '==========================================================================
                Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA_DT", SqlConn)
                DA1.Fill(DT)
                Dim DR1 = DT.NewRow
                DR1!KHAZINA_CODE = CODE_KHAZINA1.Text
                DR1!KHAZINA_DATE = TXT_DATE.Text
                DR1!CODE_DT = TXT_CODE.Text
                DR1!CODE_DT2 = "4"
                DR1!KHAZINA_NAME_ACTION = "أيصال تحويل نقدية رقم " & TXT_CODE.Text & ""
                DR1!KHAZINA_IN = "0"
                DR1!KHAZINA_OUT = MONY1.Text
                DR1!STAT_KHAZINA = True
                DT.Rows.Add(DR1)
                Dim CMD1_ As New SqlClient.SqlCommandBuilder(DA1)
                DA1.Update(DT)
                'PRINTBTN_Click(sender, e)
                MessageBox.Show("تمت عملية التحويل بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NEWBTN_Click(sender, e)

            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub EDITBTN_Click(sender As Object, e As EventArgs) Handles EDITBTN.Click
        '====================تعديل =============================

        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("R2").ToString = True Then
                '========= قيود الادخال =======================
                If KHAZINA1.Text = "" Then
                    MessageBox.Show("برجاء أختيار الخزينة المحول منها", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    KHAZINA1.Select()
                    Exit Sub
                End If
                If KHAZINA2.Text = "" Then
                    MessageBox.Show("برجاء أختيار الخزينة المحول إليها", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    KHAZINA2.Select()
                    Exit Sub
                End If
                If MONY1.Text = "" Then
                    MessageBox.Show("برجاء مبلغ التحويل", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MONY1.Select()
                    Exit Sub
                End If
                If KHAZINA2.Text = KHAZINA1.Text Then
                    MessageBox.Show("لا يمكن التحويل بين نفس الخزينة", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    KHAZINA2.Select()
                    Exit Sub
                End If
                If MONY1.Text > RASED1.Text Then
                    MessageBox.Show("لا يمكن التحويل حيث أن المبلغ المراد تحويلة أكبر من المبلغ المتواجد بالخزينة", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    MONY1.Select()
                    Exit Sub
                End If
                '================= تخزين بيانات الصنف في قاعدة البيانات =============
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM CONVERT_KHAZINA WHERE CON_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count = 0 Then
                    MessageBox.Show("يوجد تحويل أخر بنفس اليوم، يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim DR = DT.Rows(0)
                    DR!CON_CODE = TXT_CODE.Text
                    DR!CON_DATE = TXT_DATE.Text
                    DR!KHAZINA1_CODE = CODE_KHAZINA1.Text
                    DR!KHAZINA2_CODE = CODE_KHAZINA2.Text
                    DR!MONY1 = MONY1.Text
                    DR!MONY2 = MONY2.Text
                    DR!STAT = True
                    DR!USER_ADD = USER_ADD.Text
                    DR!DATE_ADD = DATE_ADD.Text
                    DR!TIME_ADD = TIME_ADD.Text
                    DR!USER_EDIT = USER_EDIT.Text
                    DR!DATE_EDIT = DATE_EDIT.Text
                    DR!TIME_EDIT = TIME_EDIT.Text
                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                End If
                '=====================================حذف التفاصيل من الخزينة ========================
                Dim CMD_DEL2 As New SqlClient.SqlCommand
                CMD_DEL2.Connection = SqlConn
                CMD_DEL2.CommandText = "DELETE FROM KHAZINA_DT WHERE CODE_DT ='" & TXT_CODE.Text & "'AND CODE_DT2 = '4'"
                CMD_DEL2.ExecuteNonQuery()
                '============================== أضافة تفاصيل للخزينة ========================
                Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA_DT", SqlConn)
                DA2.Fill(DT)
                Dim DR2 = DT.NewRow
                DR2!KHAZINA_CODE = CODE_KHAZINA2.Text
                DR2!KHAZINA_DATE = TXT_DATE.Text
                DR2!CODE_DT = TXT_CODE.Text
                DR2!CODE_DT2 = "4"
                DR2!KHAZINA_NAME_ACTION = "أيصال تحويل نقدية رقم " & TXT_CODE.Text & ""
                DR2!KHAZINA_IN = MONY2.Text
                DR2!KHAZINA_OUT = "0"
                DR2!STAT_KHAZINA = True
                DT.Rows.Add(DR2)
                Dim CMD2_ As New SqlClient.SqlCommandBuilder(DA2)
                DA2.Update(DT)
                '==========================================================================
                Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA_DT", SqlConn)
                DA1.Fill(DT)
                Dim DR1 = DT.NewRow
                DR1!KHAZINA_CODE = CODE_KHAZINA1.Text
                DR1!KHAZINA_DATE = TXT_DATE.Text
                DR1!CODE_DT = TXT_CODE.Text
                DR1!CODE_DT2 = "4"
                DR1!KHAZINA_NAME_ACTION = "أيصال تحويل نقدية رقم " & TXT_CODE.Text & ""
                DR1!KHAZINA_IN = "0"
                DR1!KHAZINA_OUT = MONY1.Text
                DR1!STAT_KHAZINA = True
                DT.Rows.Add(DR1)
                Dim CMD1_ As New SqlClient.SqlCommandBuilder(DA1)
                DA1.Update(DT)
                'PRINTBTN_Click(sender, e)
                MessageBox.Show("تمت عملية تعديل التحويل بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NEWBTN_Click(sender, e)

            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub DELETBTN_Click(sender As Object, e As EventArgs) Handles DELETBTN.Click
        '==================== حذف =============================

        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("R3").ToString = True Then
                '========= قيود الادخال =======================
                If KHAZINA1.Text = "" Then
                    MessageBox.Show("برجاء أختيار الخزينة المحول منها", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    KHAZINA1.Select()
                    Exit Sub
                End If
                If KHAZINA2.Text = "" Then
                    MessageBox.Show("برجاء أختيار الخزينة المحول إليها", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    KHAZINA2.Select()
                    Exit Sub
                End If
                If MONY1.Text = "" Then
                    MessageBox.Show("برجاء مبلغ التحويل", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MONY1.Select()
                    Exit Sub
                End If
                If KHAZINA2.Text = KHAZINA1.Text Then
                    MessageBox.Show("لا يمكن التحويل بين نفس الخزينة", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    KHAZINA2.Select()
                    Exit Sub
                End If
                If MONY1.Text > RASED1.Text Then
                    MessageBox.Show("لا يمكن التحويل حيث أن المبلغ المراد تحويلة أكبر من المبلغ المتواجد بالخزينة", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    MONY1.Select()
                    Exit Sub
                End If
                '================= تخزين بيانات الصنف في قاعدة البيانات =============
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM CONVERT_KHAZINA WHERE CON_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count = 0 Then
                    MessageBox.Show("يوجد تحويل أخر بنفس اليوم، يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim DR = DT.Rows(0)

                    DR!STAT = False

                    DR!USER_EDIT = USER_EDIT.Text
                    DR!DATE_EDIT = DATE_EDIT.Text
                    DR!TIME_EDIT = TIME_EDIT.Text
                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                End If
                '============================== أضافة تفاصيل للخزينة ========================
                Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA_DT WHERE CODE_DT ='" & TXT_CODE.Text & "'AND CODE_DT2 = '4'", SqlConn)
                DA2.Fill(DT)
                Dim DR2 = DT.Rows(0)

                DR2!STAT_KHAZINA = False

                Dim CMD2_ As New SqlClient.SqlCommandBuilder(DA2)
                DA2.Update(DT)

                'PRINTBTN_Click(sender, e)
                MessageBox.Show("تمت عملية حذف التحويل بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NEWBTN_Click(sender, e)

            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub SEARCHBTN_Click(sender As Object, e As EventArgs) Handles SEARCHBTN.Click
        SEARCH_CONVERT.ShowDialog()
    End Sub

    Private Sub PRINTBTN_Click(sender As Object, e As EventArgs) Handles PRINTBTN.Click

    End Sub

    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SAFY1.Text = Val(RASED1.Text) - Val(MONY1.Text)
        MONY2.Text = Val(MONY1.Text)
        SAFY2.Text = Val(RASED2.Text) + Val(MONY2.Text)
    End Sub

    Private Sub CODE_KHAZINA1_TextChanged(sender As Object, e As EventArgs) Handles CODE_KHAZINA1.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA WHERE STAT='TRUE' AND KHAZINA_CODE ='" & CODE_KHAZINA1.Text & "' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            KHAZINA1.Text = DT.Rows(I).Item("KHAZINA_NAME")
        Next
    End Sub

    Private Sub CODE_KHAZINA2_TextChanged(sender As Object, e As EventArgs) Handles CODE_KHAZINA2.TextChanged

    End Sub
End Class