Public Class T3AQOD_FRM2020
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
    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Dispose()
    End Sub

    Private Sub T3AQOD_FRM2020_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEWBTN_Click(sender, e)
    End Sub
    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles NEWBTN.Click
        '""""""""""""""" تنظيف الشاشة """""""""""""
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is ComboBox Then GroupBox1.Controls(I).Text = ""
        Next
        DataGridView1.Rows.Clear()
        TXT_TKHASOS.Items.Clear()
        TXT_DOCTOR.Items.Clear()
        TXT_ACTION.Items.Clear()
        '""""""""""""""" الترقيم التلقائي """"""""""""""
        TXT_CODE.Text = CODE_GENE("T3AQOD_2020", "ID") + 1
        '""""""""""""""""""""""""""""""
        TXT_DATE_START.Text = Date.Today
        TXT_DATE_END.Text = Date.Today
        EDITBTN.Enabled = False
        DELETBTN.Enabled = False
        SAVEBTN.Enabled = True
        TIMERADD.Enabled = True
        TIMEREDIT.Enabled = False
        '=====================================================
        FILL_TKHASOS()
        TXT_NAME.Select()
    End Sub
    Sub FILL_TKHASOS()
        TXT_TKHASOS.Items.Clear()
        TXT_DOCTOR.Items.Clear()
        TXT_ACTION.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM TKHASOS WHERE STAT='TRUE'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_TKHASOS.Items.Add(DT.Rows(I).Item("TAKH_NAME"))
        Next
    End Sub

    Private Sub TXT_TKHASOS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_TKHASOS.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM TKHASOS WHERE TAKH_NAME='" & TXT_TKHASOS.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_TKHASOS_CODE.Text = DT.Rows(I).Item("TAKH_CODE")
        Next
        TXT_DOCTOR.Text = ""
        TXT_DOCTOR_CODE.Text = ""
        TXT_ACTION.Text = ""
        TXT_MONY_ACTION.Text = ""
        FILL_DOCTOR()
    End Sub
    Sub FILL_DOCTOR()
        TXT_DOCTOR.Items.Clear()
        TXT_ACTION.Items.Clear()
        Dim DT4 As New DataTable
        Dim DA4 As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORS WHERE STAT='TRUE' AND DO_TKHSOS_CODE = '" & TXT_TKHASOS_CODE.Text & "'", SqlConn)
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
            TXT_DOCTOR_CODE.Text = DT.Rows(I).Item("DO_CODE")
        Next
        TXT_ACTION.Text = ""
        TXT_MONY_ACTION.Text = ""
        FILL_DOCTOR_DT()

    End Sub
    Sub FILL_DOCTOR_DT()
        TXT_ACTION.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORSDT WHERE DO_CODE = '" & TXT_DOCTOR_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_ACTION.Items.Add(DT.Rows(I).Item("DOT_NAME"))
        Next
    End Sub
    Private Sub ACTIVE_DOCTOR_Click(sender As Object, e As EventArgs) Handles ACTIVE_DOCTOR.Click
        If TXT_ACTION.SelectedIndex = -1 Then
            MessageBox.Show("من فضلك أختار الخدمة")
            TXT_ACTION.Select()
            Exit Sub
        End If
        If TXT_MONY_ACTION.Text = "" Then
            MessageBox.Show("من فضلك أدخل قيمة الخدمة")
            TXT_MONY_ACTION.Select()
            Exit Sub
        End If
        Dim BAR As Integer
        '======= اضافة سجل للداتا جريد ===========
        DataGridView1.Rows.Add()
        BAR = DataGridView1.Rows.Count - 1
        DataGridView1(0, BAR).Value = TXT_TKHASOS_CODE.Text
        DataGridView1(1, BAR).Value = TXT_TKHASOS.Text
        DataGridView1(2, BAR).Value = TXT_DOCTOR_CODE.Text
        DataGridView1(3, BAR).Value = TXT_DOCTOR.Text
        DataGridView1(4, BAR).Value = TXT_ACTION.Text
        DataGridView1(5, BAR).Value = TXT_MONY_ACTION.Text

        TXT_ACTION.Text = ""
        TXT_MONY_ACTION.Text = ""

        TXT_ACTION.Select()
    End Sub

    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("K1").ToString = True Then

                If TXT_NAME.Text = "" Then
                    MessageBox.Show("يرجى أدخال أسم جهة التعاقد", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_NAME.Select()
                    Exit Sub
                End If
                If TXT_DATE_END.Text = TXT_DATE_START.Text Then
                    MessageBox.Show("لايمكن ان يكون تاريخ بدء التعاقد وانتهائه متشابهان", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_DATE_END.Select()
                    Exit Sub
                End If
                If DataGridView1.Rows.Count < 1 Then
                    MessageBox.Show("يرجى أختيار الأجراءات المطلوبة", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_ACTION.Select()
                    Exit Sub
                End If

                '==========================================================
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM T3AQOD_2020 WHERE T3AQOD_NAME='" & TXT_NAME.Text & "' AND T3AQOD_STAT='TRUE'", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count > 0 Then
                    MessageBox.Show("يوجد تعاقد لنفس الجهة", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    Dim DR = DT.NewRow
                    DR!T3AQOD_CODE = TXT_CODE.Text
                    DR!T3AQOD_NAME = TXT_NAME.Text
                    DR!T3AQOD_DATE_START = TXT_DATE_START.Value
                    DR!T3AQOD__DATE_END = TXT_DATE_END.Value
                    DR!T3AQOD_STAT = True
                    DR!USER_ADD = USER_ADD.Text
                    DR!DATE_ADD = DATE_ADD.Text
                    DR!TIME_ADD = TIME_ADD.Text
                    DT.Rows.Add(DR)
                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)

                    '=============== DTELS ================
                    Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM T3AQOD_DT2020", SqlConn)
                    DA1.Fill(DT)
                    For I = 0 To DataGridView1.Rows.Count - 1
                        Dim DR1 = DT.NewRow
                        DR1!T3AQOD_CODE = TXT_CODE.Text
                        DR1!T5ASOS_CODE = DataGridView1.Rows(I).Cells(0).Value
                        DR1!DOCTOR_CODE = DataGridView1.Rows(I).Cells(2).Value
                        DR1!ACTION_NAME = DataGridView1.Rows(I).Cells(4).Value
                        DR1!ACTION_PRICE = DataGridView1.Rows(I).Cells(5).Value
                        DR1!STAT_DT = True
                        DT.Rows.Add(DR1)
                        Dim CMD_ As New SqlClient.SqlCommandBuilder(DA1)
                        DA1.Update(DT)
                    Next

                End If


                MessageBox.Show("تمت عملية حفظ البيانات  بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)

                NEWBTN_Click(sender, e)

            End If

        Else
            MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub EDITBTN_Click(sender As Object, e As EventArgs) Handles EDITBTN.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("K2").ToString = True Then

                If TXT_NAME.Text = "" Then
                    MessageBox.Show("يرجى أدخال أسم جهة التعاقد", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_NAME.Select()
                    Exit Sub
                End If
                If TXT_DATE_END.Text = TXT_DATE_START.Text Then
                    MessageBox.Show("لايمكن ان يكون تاريخ بدء التعاقد وانتهائه متشابهان", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_DATE_END.Select()
                    Exit Sub
                End If
                If DataGridView1.Rows.Count < 1 Then
                    MessageBox.Show("يرجى أختيار الأجراءات المطلوبة", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_ACTION.Select()
                    Exit Sub
                End If

                '==========================================================
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM T3AQOD_2020 WHERE T3AQOD_CODE ='" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count = 0 Then
                    MessageBox.Show("لا يوجد تعاقد للتعديل عليه", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    Dim DR = DT.Rows(0)
                    DR!T3AQOD_CODE = TXT_CODE.Text
                    DR!T3AQOD_NAME = TXT_NAME.Text
                    DR!T3AQOD_DATE_START = TXT_DATE_START.Value
                    DR!T3AQOD__DATE_END = TXT_DATE_END.Value
                    DR!T3AQOD_STAT = True
                    DR!USER_EDIT = USER_EDIT.Text
                    DR!DATE_EDIT = DATE_EDIT.Text
                    DR!TIME_EDIT = TIME_EDIT.Text

                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)


                    '================= DELET DTELS =============================
                    Dim CMD_DEL2 As New SqlClient.SqlCommand
                    CMD_DEL2.Connection = SqlConn
                    CMD_DEL2.CommandText = "DELETE FROM T3AQOD_DT2020 WHERE T3AQOD_CODE ='" & TXT_CODE.Text & "'"
                    CMD_DEL2.ExecuteNonQuery()
                    '=============== DTELS ================
                    Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM T3AQOD_DT2020", SqlConn)
                    DA1.Fill(DT)
                    For I = 0 To DataGridView1.Rows.Count - 1
                        Dim DR1 = DT.NewRow
                        DR1!T3AQOD_CODE = TXT_CODE.Text
                        DR1!T5ASOS_CODE = DataGridView1.Rows(I).Cells(0).Value
                        DR1!DOCTOR_CODE = DataGridView1.Rows(I).Cells(2).Value
                        DR1!ACTION_NAME = DataGridView1.Rows(I).Cells(4).Value
                        DR1!ACTION_PRICE = DataGridView1.Rows(I).Cells(5).Value
                        DR1!STAT_DT = True
                        DT.Rows.Add(DR1)
                        Dim CMD_ As New SqlClient.SqlCommandBuilder(DA1)
                        DA1.Update(DT)
                    Next


                End If


                MessageBox.Show("تمت عملية تعديل البيانات بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)

                NEWBTN_Click(sender, e)

            End If

        Else
            MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub DELETBTN_Click(sender As Object, e As EventArgs) Handles DELETBTN.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("K3").ToString = True Then

                '==========================================================
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM T3AQOD_2020 WHERE T3AQOD_CODE ='" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count = 0 Then
                    MessageBox.Show("لا يوجد تعاقد للتعديل عليه", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    Dim DR = DT.Rows(0)

                    DR!T3AQOD_STAT = False
                    DR!USER_EDIT = USER_EDIT.Text
                    DR!DATE_EDIT = DATE_EDIT.Text
                    DR!TIME_EDIT = TIME_EDIT.Text

                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)

                End If

                MessageBox.Show("تمت عملية حذف البيانات بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)

                NEWBTN_Click(sender, e)

            End If

        Else
            MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub PRINTBTN_Click(sender As Object, e As EventArgs) Handles PRINTBTN.Click

    End Sub

    Private Sub SEARCHBTN_Click(sender As Object, e As EventArgs) Handles SEARCHBTN.Click
        SEARCH_T3AQOD2020.ShowDialog()
    End Sub
    Sub SHOW_DETA(CODE_)
        DataGridView1.Rows.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM T3AQOD_2020 WHERE T3AQOD_CODE ='" & CODE_ & "'", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("لا يوجد تعاقد للتعديل عليه", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!T3AQOD_CODE
            TXT_NAME.Text = DR!T3AQOD_NAME
            TXT_DATE_START.Text = DR!T3AQOD_DATE_START
            TXT_DATE_END.Text = DR!T3AQOD__DATE_END
            USER_ADD.Text = DR!USER_ADD
            DATE_ADD.Text = DR!DATE_ADD
            TIME_ADD.Text = DR!TIME_ADD

            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)

            '=============== DTELS ================
            Dim DT10 As New DataTable
            Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM T3AQOD2020_V WHERE T3AQOD_CODE ='" & CODE_ & "'", SqlConn)
            DA1.Fill(DT10)
            For I = 0 To DT10.Rows.Count - 1
                DataGridView1.Rows.Add()
                DataGridView1.Rows(I).Cells(0).Value = DT10.Rows(I).Item("T5ASOS_CODE")
                DataGridView1.Rows(I).Cells(1).Value = DT10.Rows(I).Item("DO_TKHSOS")
                DataGridView1.Rows(I).Cells(2).Value = DT10.Rows(I).Item("DOCTOR_CODE")
                DataGridView1.Rows(I).Cells(3).Value = DT10.Rows(I).Item("DO_NAME")
                DataGridView1.Rows(I).Cells(4).Value = DT10.Rows(I).Item("ACTION_NAME")
                DataGridView1.Rows(I).Cells(5).Value = DT10.Rows(I).Item("ACTION_PRICE")

                Dim CMD_ As New SqlClient.SqlCommandBuilder(DA1)
                DA1.Update(DT)
            Next

            DELETBTN.Enabled = True
            EDITBTN.Enabled = True
            SAVEBTN.Enabled = False
            TIMEREDIT.Enabled = True
            TIMERADD.Enabled = False
            PRINTBTN.Enabled = False

        End If
    End Sub
End Class