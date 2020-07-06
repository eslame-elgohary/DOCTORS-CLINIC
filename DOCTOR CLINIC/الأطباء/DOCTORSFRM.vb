Public Class DOCTORSFRM
    Sub SHOW_DETA(CODE_)
        DataGridView1.Rows.Clear()
        '=========== ربط رأس الفاتورة =============
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORS WHERE DO_CODE ='" & CODE_ & "'", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("يرجى التأكد من كود الطبيب", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            DO_CODE.Text = DR!DO_CODE
            DO_NAME.Text = DR!DO_NAME
            DO_TEL.Text = DR!DO_TEL
            DO_TEL2.Text = DR!DO_TEL2
            DO_TKHSOS.Text = DR!DO_TKHSOS
            DO_TKHSOS_CODE.Text = DR!DO_TKHSOS_CODE
            USER_ADD.Text = DR!USER_ADD
            DATE_ADD.Text = DR!DATE_ADD
            TIME_ADD.Text = DR!TIME_ADD

            Dim DS As New DataSet
            '=========== ربط تفاصيل الفاتورة =============
            DA = New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORSDT WHERE DO_CODE = '" & CODE_ & "'", SqlConn)
            DS = New DataSet
            DA.Fill(DS)
            DT = DS.Tables(0)
            For I = 0 To DT.Rows.Count - 1
                DataGridView1.Rows.Add()
                DataGridView1.Rows(I).Cells(0).Value = DT.Rows(I).Item("DOT_M")
                DataGridView1.Rows(I).Cells(1).Value = DT.Rows(I).Item("DOT_NAME")
                DataGridView1.Rows(I).Cells(2).Value = DT.Rows(I).Item("DOT_PA")
                DataGridView1.Rows(I).Cells(3).Value = DT.Rows(I).Item("DOT_T3AKOD")
                DataGridView1.Rows(I).Cells(4).Value = DT.Rows(I).Item("DOT_DOCTORS")
                TextBox0.Text = Val(DataGridView1.Rows(I).Cells(0).Value) + 1
            Next
            DELETBTN.Enabled = True
            EDITBTN.Enabled = True
            SAVEBTN.Enabled = False
            TIMEREDIT.Enabled = True
            TIMERADD.Enabled = False
        End If
    End Sub
    Private Sub DOCTORSFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Sub FILL_UNITE()
        DO_TKHSOS.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM TKHASOS", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            DO_TKHSOS.Items.Add(DT.Rows(I).Item("TAKH_NAME"))
        Next
    End Sub
    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles NEWBTN.Click
        TIMERADD.Enabled = True
        TIMEREDIT.Enabled = False
        FILL_UNITE()
        '""""""""""""""" تنظيف الشاشة """""""""""""
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        DataGridView1.Rows.Clear()
        DO_TKHSOS.Text = ""
        '""""""""""""""" الترقيم التلقائي """"""""""""""
        DO_CODE.Text = CODE_GENE("DOCTORS", "ID") + 1
        TextBox0.Text = "1"
        '""""""""""""""""""""""""""""""
        EDITBTN.Enabled = False
        DELETBTN.Enabled = False
        SAVEBTN.Enabled = True
        DO_NAME.Select()
    End Sub

    Private Sub ACEPT_Click(sender As Object, e As EventArgs) Handles ACEPT.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("يرجى أدخال أسم الخدمة ؟", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Select()
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MessageBox.Show("يرجى أدخال قيمة الخدمة ؟", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox2.Select()
            Exit Sub
        End If
        If TextBox3.Text = "" Then
            MessageBox.Show("يرجى أدخال مبلغ التعاقدات ؟", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox3.Select()
            Exit Sub
        End If
        If TextBox4.Text = "" Then
            MessageBox.Show("يرجى أدخال مبلغ الطبيب ؟", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox4.Select()
            Exit Sub
        End If
        Dim BAR_ As Integer
        DataGridView1.Rows.Add()
        BAR_ = DataGridView1.Rows.Count - 1
        DataGridView1(0, BAR_).Value = TextBox0.Text
        DataGridView1(1, BAR_).Value = TextBox1.Text
        DataGridView1(2, BAR_).Value = TextBox2.Text
        DataGridView1(3, BAR_).Value = TextBox3.Text
        DataGridView1(4, BAR_).Value = TextBox4.Text
        TextBox1.Select()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox0.Text = Val(DataGridView1(0, BAR_).Value) + 1

    End Sub
    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub
    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("B1").ToString = True Then

                '========= قيود الادخال =======================
                If DO_NAME.Text = "" Then
                    MessageBox.Show("يرجى أدخال أسم الطبيب ؟", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DO_NAME.Select()
                    Exit Sub
                End If
                If DO_TKHSOS.Text = "" Then
                    MessageBox.Show("يرجى أدخال تخصص الطبيب ؟", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DO_TKHSOS.Select()
                    Exit Sub
                End If
                If DO_TKHSOS_CODE.Text = "" Then
                    MessageBox.Show("يرجى أدخال تخصص الطبيب ؟", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DO_TKHSOS.Select()
                    Exit Sub
                End If
                For I As Integer = 0 To DataGridView1.Rows.Count - 1
                    If DataGridView1.Rows(I).Cells(2).Value = "" Then
                        MessageBox.Show("يرجى التحقق من قيمة الخدمة ", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Next
                '================= =======================================
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORS WHERE DO_NAME = '" & DO_NAME.Text & "'", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count > 0 Then
                    MessageBox.Show("الطبيب موجود مسبقاً ، يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim DR = DT.NewRow
                    DR!DO_CODE = DO_CODE.Text
                    DR!DO_NAME = DO_NAME.Text
                    DR!DO_TEL = DO_TEL2.Text
                    DR!DO_TEL2 = DO_TEL2.Text
                    DR!DO_TKHSOS = DO_TKHSOS.Text
                    DR!DO_TKHSOS_CODE = DO_TKHSOS_CODE.Text
                    DR!STAT = True
                    DR!USER_ADD = USER_ADD.Text
                    DR!DATE_ADD = DATE_ADD.Text
                    DR!TIME_ADD = TIME_ADD.Text
                    DT.Rows.Add(DR)
                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    '======= حفظ تفاصيل الطبيب ===============

                    DA = New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORSDT", SqlConn)
                    DA.Fill(DT)
                    For I = 0 To DataGridView1.Rows.Count - 1

                        Dim DR1 = DT.NewRow
                        DR1!DO_CODE = DO_CODE.Text
                        DR1!DOT_M = DataGridView1.Rows(I).Cells(0).Value
                        DR1!DOT_NAME = DataGridView1.Rows(I).Cells(1).Value
                        DR1!DOT_PA = DataGridView1.Rows(I).Cells(2).Value
                        DR1!DOT_T3AKOD = DataGridView1.Rows(I).Cells(3).Value
                        DR1!DOT_DOCTORS = Val(DataGridView1.Rows(I).Cells(4).Value)
                        DT.Rows.Add(DR1)
                        Dim CMD_ As New SqlClient.SqlCommandBuilder(DA)
                        DA.Update(DT)
                    Next

                    PRINTBTN_Click(sender, e)
                    MessageBox.Show("تمت عملية حفظ بيانات الطبيب بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    NEWBTN_Click(sender, e)
                End If


            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub SEARCHBTN_Click(sender As Object, e As EventArgs) Handles SEARCHBTN.Click
        SEARCH_DOCTOR.ShowDialog()
    End Sub

    Private Sub DELETBTN_Click(sender As Object, e As EventArgs) Handles DELETBTN.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("B3").ToString = True Then
                If MessageBox.Show("هل ترغب في حذف بيانات الطبيب ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub
                '============================  كود الحفظ =====================
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORS WHERE DO_CODE = '" & DO_CODE.Text & "'  ", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count = 0 Then
                    MessageBox.Show("الطبيب غير موجود يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim UPDATE As Integer = BindingContext(DT).Position
                    DT.Rows(UPDATE).Item("STAT") = False
                    DT.Rows(UPDATE).Item("USER_EDIT") = USER_EDIT.Text
                    DT.Rows(UPDATE).Item("DATE_EDIT") = DATE_EDIT.Text
                    DT.Rows(UPDATE).Item("TIME_EDIT") = TIME_EDIT.Text
                    Dim Save As New SqlClient.SqlCommandBuilder(DA)

                    DA.Update(DT)
                    DT.AcceptChanges()
                    MessageBox.Show("تمت عملية حذف بيانات الطبيب بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    NEWBTN_Click(sender, e)

                End If

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
            If DT0.Rows(0).Item("B2").ToString = True Then
                '========= قيود الادخال =======================
                If DO_NAME.Text = "" Then
                    MessageBox.Show("يرجى أدخال أسم الطبيب ؟", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DO_NAME.Select()
                    Exit Sub
                End If
                If DO_TKHSOS.Text = "" Then
                    MessageBox.Show("يرجى أدخال تخصص الطبيب ؟", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DO_TKHSOS.Select()
                    Exit Sub
                End If
                If DO_TKHSOS_CODE.Text = "" Then
                    MessageBox.Show("يرجى أدخال تخصص الطبيب ؟", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    DO_TKHSOS.Select()
                    Exit Sub
                End If
                For I As Integer = 0 To DataGridView1.Rows.Count - 1
                    If DataGridView1.Rows(I).Cells(2).Value = "" Then
                        MessageBox.Show("يرجى التحقق من قيمة الخدمة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Next
                '================= =======================================
                If MessageBox.Show("هل ترغب في تعديل بيانات الطبيب ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then Exit Sub

                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORS WHERE DO_CODE = '" & DO_CODE.Text & "'", SqlConn)
                DA.Fill(DT)

                If DT.Rows.Count = 0 Then
                    MessageBox.Show("الطبيب موجود مسبقاً ، يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim DR = DT.Rows(0)
                    DR!DO_CODE = DO_CODE.Text
                    DR!DO_NAME = DO_NAME.Text
                    DR!DO_TEL = DO_TEL2.Text
                    DR!DO_TEL2 = DO_TEL2.Text
                    DR!DO_TKHSOS = DO_TKHSOS.Text
                    DR!DO_TKHSOS_CODE = DO_TKHSOS_CODE.Text
                    DR!STAT = True
                    DR!USER_ADD = USER_ADD.Text
                    DR!DATE_ADD = DATE_ADD.Text
                    DR!TIME_ADD = TIME_ADD.Text

                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    '================ حذف تفاصيل الطبيب أولاً ثم إضافتها ==========
                    Dim CMD_DEL As New SqlClient.SqlCommand
                    CMD_DEL.Connection = SqlConn
                    CMD_DEL.CommandText = "DELETE FROM DOCTORSDT WHERE DO_CODE ='" & DO_CODE.Text & "'"
                    CMD_DEL.ExecuteNonQuery()
                    '======================================================================
                    '======= تعديل تفاصيل الطبيب ===============

                    DA = New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORSDT", SqlConn)
                    DA.Fill(DT)
                    For I = 0 To DataGridView1.Rows.Count - 1

                        Dim DR1 = DT.NewRow
                        DR1!DO_CODE = DO_CODE.Text
                        DR1!DOT_M = DataGridView1.Rows(I).Cells(0).Value
                        DR1!DOT_NAME = DataGridView1.Rows(I).Cells(1).Value
                        DR1!DOT_PA = DataGridView1.Rows(I).Cells(2).Value
                        DR1!DOT_T3AKOD = DataGridView1.Rows(I).Cells(3).Value
                        DR1!DOT_DOCTORS = Val(DataGridView1.Rows(I).Cells(4).Value)
                        DT.Rows.Add(DR1)
                        Dim CMD_ As New SqlClient.SqlCommandBuilder(DA)
                        DA.Update(DT)
                    Next
                    PRINTBTN_Click(sender, e)

                    MessageBox.Show("تمت عملية تعديل بيانات الطبيب بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    NEWBTN_Click(sender, e)
                End If

            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub UNDOBTN_Click(sender As Object, e As EventArgs) Handles UNDOBTN.Click
        SEARCH_DOCTOR2.ShowDialog()
    End Sub

    Private Sub PRINTBTN_Click(sender As Object, e As EventArgs) Handles PRINTBTN.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("B4").ToString = True Then
                '""""""""""""""""طباعة الفاتورة """"""""""""""
                Dim DT As New DataTable
                With DT
                    .Columns.Add("DO_CODE")
                    .Columns.Add("DO_NAME")
                    .Columns.Add("DO_TKHSOS")
                    .Columns.Add("DO_TEL")
                    .Columns.Add("DO_TEL2")
                    .Columns.Add("USER_ADD")
                    .Columns.Add("DOT_M")
                    .Columns.Add("DOT_NAME")
                    .Columns.Add("DOT_PA")
                    .Columns.Add("DOT_T3AKOD")
                    .Columns.Add("DOT_DOCTORS")
                End With
                For I As Integer = 0 To DataGridView1.Rows.Count - 1
                    If DataGridView1.Rows(I).Cells(0).Value <> Nothing Then
                        DT.Rows.Add(DO_CODE.Text, DO_NAME.Text, DO_TKHSOS.Text, DO_TEL.Text, DO_TEL2.Text, USER_ADD.Text, DataGridView1.Rows(I).Cells(0).Value, DataGridView1.Rows(I).Cells(1).Value, DataGridView1.Rows(I).Cells(2).Value, DataGridView1.Rows(I).Cells(3).Value, DataGridView1.Rows(I).Cells(4).Value)
                    End If
                Next
                Dim REP As New DOCTORS_CRS
                REP.SetDataSource(DT)
                Dim FRM As New DOCTORS_PRINT
                FRM.CrystalReportViewer1.ReportSource = REP
                FRM.ShowDialog()

            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Then
            Else
                MsgBox("من فضلك ادخل رقم صحيح فقط")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Then
            Else
                MsgBox("من فضلك ادخل رقم صحيح فقط")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Then
            Else
                MsgBox("من فضلك ادخل رقم صحيح فقط")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub DO_TKHSOS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DO_TKHSOS.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM TKHASOS WHERE TAKH_NAME = '" & DO_TKHSOS.Text & "'", SqlConn)
        DA.Fill(DT)
        For S = 0 To DT.Rows.Count - 1
            DO_TKHSOS_CODE.Text = DT.Rows(S).Item("TAKH_CODE")
        Next
    End Sub

    Private Sub DOCTORSFRM_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub DO_NAME_KeyDown(sender As Object, e As KeyEventArgs) Handles DO_NAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If

    End Sub

    Private Sub DO_TKHSOS_KeyDown(sender As Object, e As KeyEventArgs) Handles DO_TKHSOS.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub DO_TEL_KeyDown(sender As Object, e As KeyEventArgs) Handles DO_TEL.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub DO_TEL2_KeyDown(sender As Object, e As KeyEventArgs) Handles DO_TEL2.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub
End Class