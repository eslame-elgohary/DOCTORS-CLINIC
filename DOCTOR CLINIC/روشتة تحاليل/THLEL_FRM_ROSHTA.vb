﻿Public Class THLEL_FRM_ROSHTA
    Sub SHOW_DETA(CODE_)
        DataGridView1.Rows.Clear()
        '=========== ربط رأس الفاتورة =============
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM R_T_DOCTOR WHERE R_T_CODE ='" & CODE_ & "'", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("يرجى التأكد من كود الروشتة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!R_T_CODE
            TXT_DATE.Text = DR!R_T_DATE
            TXT_CODE_DOCTOR.Text = DR!R_CODE_DOC
            TXT_CODE_PA.Text = DR!R_CODE_PA

            TXT_INFO.Text = DR!R_INFO

            USER_ADD.Text = DR!USER_ADD
            DATE_ADD.Text = DR!DATE_ADD
            TIME_ADD.Text = DR!TIME_ADD



            Dim DS As New DataSet
            '=========== ربط تفاصيل الفاتورة =============
            DA = New SqlClient.SqlDataAdapter("SELECT * FROM R_T_DOCTOR_DT WHERE R_T_CODE_DT = '" & CODE_ & "'", SqlConn)
            DS = New DataSet
            DA.Fill(DS)
            DT = DS.Tables(0)
            For I = 0 To DT.Rows.Count - 1
                DataGridView1.Rows.Add()
                DataGridView1.Rows(I).Cells(0).Value = DT.Rows(I).Item("R_DT_CODE")
                DataGridView1.Rows(I).Cells(1).Value = DT.Rows(I).Item("R_DT_THLEL")

            Next

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
    Sub FILL_PATIENT()
        TXT_NAME_PA.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE STAT='TRUE' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_NAME_PA.Items.Add(DT.Rows(I).Item("PA_NAME"))
        Next
    End Sub
    Sub FILL_DOCTOR()
        TXT_DOCTOR.Items.Clear()
        Dim DT4 As New DataTable
        Dim DA4 As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORS WHERE STAT='TRUE'", SqlConn)
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
            TXT_CODE_DOCTOR.Text = DT.Rows(I).Item("DO_CODE")
            TXT_TKHASOS.Text = DT.Rows(I).Item("DO_TKHSOS")
        Next
    End Sub

    Private Sub TXT_CODE_DOCTOR_TextChanged(sender As Object, e As EventArgs) Handles TXT_CODE_DOCTOR.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORS WHERE DO_CODE='" & TXT_CODE_DOCTOR.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_DOCTOR.Text = DT.Rows(I).Item("DO_NAME")
        Next
    End Sub

    Private Sub TXT_CODE_PA_TextChanged(sender As Object, e As EventArgs) Handles TXT_CODE_PA.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_CODE='" & TXT_CODE_PA.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_NAME_PA.Text = DT.Rows(I).Item("PA_NAME")
            TXT_AGE_PA.Text = DT.Rows(I).Item("PA_AGE")
            TXT_TYPE_PA.Text = DT.Rows(I).Item("PA_TYPE")
            TXT_3MLIAT.Text = DT.Rows(I).Item("PA_OP")
            TXT_CODE2.Text = DT.Rows(I).Item("PA_CODE2")
        Next
    End Sub
    Private Sub TXT_NAME_PA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_NAME_PA.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME='" & TXT_NAME_PA.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_CODE_PA.Text = DT.Rows(I).Item("PA_CODE")
            TXT_AGE_PA.Text = DT.Rows(I).Item("PA_AGE")
            TXT_TYPE_PA.Text = DT.Rows(I).Item("PA_TYPE")
            TXT_3MLIAT.Text = DT.Rows(I).Item("PA_OP")
            TXT_CODE2.Text = DT.Rows(I).Item("PA_CODE2")
        Next
        FILL_DGV(VIWERPATIN, "SELECT * FROM R_DOCTOR,R_DOCTOR_DT,DOCTORS WHERE R_CODE = R_CODE_DT AND R_CODE_DOC = DO_CODE AND R_CODE_PA = '" & TXT_CODE_PA.Text & "'")
    End Sub
    Sub FILL_THLEL()
        TXT_NAME_THLEL.Items.Clear()
        Dim DT4 As New DataTable
        Dim DA4 As New SqlClient.SqlDataAdapter("SELECT * FROM THALEL WHERE STAT='TRUE'", SqlConn)
        DA4.Fill(DT4)
        For I4 = 0 To DT4.Rows.Count - 1
            TXT_NAME_THLEL.Items.Add(DT4.Rows(I4).Item("TAH_NAME"))
        Next
    End Sub
    Private Sub TXT_NAME_THLEL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_NAME_THLEL.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM THALEL WHERE TAH_NAME='" & TXT_NAME_THLEL.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_CODE_THLEL.Text = DT.Rows(I).Item("TAH_CODE")
        Next
    End Sub
    Private Sub TXT_CODE_THLEL_TextChanged(sender As Object, e As EventArgs) Handles TXT_CODE_THLEL.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM THALEL WHERE TAH_CODE='" & TXT_CODE_THLEL.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_NAME_THLEL.Text = DT.Rows(I).Item("TAH_NAME")
        Next
    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(2).Value = "حذف"
            Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        For Each ROW As DataGridViewRow In DataGridView1.Rows
            If DataGridView1(2, DataGridView1.CurrentRow.Index).Selected = True Then
                DataGridView1.Rows.Remove(ROW)
            End If
        Next
    End Sub
    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles NEWBTN.Click
        TIMERADD.Enabled = True
        TIMEREDIT.Enabled = False
        TXT_CODE2.Text = ""
        '""""""""""""""" تنظيف الشاشة """""""""""""
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is ComboBox Then GroupBox1.Controls(I).Text = ""
        Next
        DataGridView1.Rows.Clear()
        '""""""""""""""" الترقيم التلقائي """"""""""""""
        TXT_CODE.Text = CODE_GENE("R_T_DOCTOR", "ID") + 1
        '""""""""""""""""""""""""""""""
        EDITBTN.Enabled = False
        DELETBTN.Enabled = False
        SAVEBTN.Enabled = True
        TIMERADD.Enabled = True
        TIMEREDIT.Enabled = False
        TXT_NAME_PA.Select()

    End Sub

    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click
        '====================حفظ العيادة=============================

        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("R1").ToString = True Then
                '========= قيود الادخال =======================
                If TXT_NAME_PA.Text = "" Then
                    MessageBox.Show("برجاء ادخال اسم المريض", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TXT_NAME_PA.Select()
                    Exit Sub
                End If
                If TXT_DOCTOR.Text = "" Then
                    MessageBox.Show("برجاء ادخال الطبيب المعالج ", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TXT_DOCTOR.Select()
                    Exit Sub
                End If
                '================= تخزين بيانات الصنف في قاعدة البيانات =============
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM R_T_DOCTOR WHERE R_T_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count > 0 Then
                    TXT_CODE.Text = Val(TXT_CODE.Text) + 1
                Else
                    Dim DR = DT.NewRow
                    DR!R_T_CODE = TXT_CODE.Text
                    DR!R_T_DATE = TXT_DATE.Text
                    DR!R_CODE_DOC = TXT_CODE_DOCTOR.Text
                    DR!R_CODE_PA = TXT_CODE_PA.Text
                    DR!R_INFO = TXT_INFO.Text
                    DR!R_STAT = True
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
                '============================== أضافة تفاصيل الايصال ========================
                Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM R_T_DOCTOR_DT", SqlConn)
                DA1.Fill(DT)
                For I = 0 To DataGridView1.Rows.Count - 1
                    Dim DR1 = DT.NewRow
                    DR1!R_T_CODE_DT = TXT_CODE.Text
                    DR1!R_T_DATE = TXT_DATE.Text
                    DR1!R_DT_CODE = DataGridView1.Rows(I).Cells(0).Value
                    DR1!R_DT_THLEL = DataGridView1.Rows(I).Cells(1).Value

                    DR1!STAT_DT = True
                    DT.Rows.Add(DR1)
                    Dim CMD_ As New SqlClient.SqlCommandBuilder(DA1)
                    DA1.Update(DT)
                Next
                '==========================================================================
                PRINTBTN_Click(sender, e)
                MessageBox.Show("تمت عملية حفظ بيانات الروشتة بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NEWBTN_Click(sender, e)

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
            If DT0.Rows(0).Item("R2").ToString = True Then
                '========= قيود الادخال =======================
                If TXT_NAME_PA.Text = "" Then
                    MessageBox.Show("برجاء ادخال اسم المريض", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TXT_NAME_PA.Select()
                    Exit Sub
                End If
                If TXT_DOCTOR.Text = "" Then
                    MessageBox.Show("برجاء ادخال الطبيب المعالج ", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TXT_DOCTOR.Select()
                    Exit Sub
                End If
                '================= تخزين بيانات الصنف في قاعدة البيانات =============
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM R_T_DOCTOR WHERE R_T_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count = 0 Then
                    TXT_CODE.Text = Val(TXT_CODE.Text) + 1
                Else
                    Dim DR = DT.Rows(0)
                    DR!R_T_CODE = TXT_CODE.Text
                    DR!R_T_DATE = TXT_DATE.Text
                    DR!R_CODE_DOC = TXT_CODE_DOCTOR.Text
                    DR!R_CODE_PA = TXT_CODE_PA.Text
                    DR!R_INFO = TXT_INFO.Text
                    DR!R_STAT = True
                    DR!USER_ADD = USER_ADD.Text
                    DR!DATE_ADD = DATE_ADD.Text
                    DR!TIME_ADD = TIME_ADD.Text
                    DR!USER_EDIT = USER_EDIT.Text
                    DR!DATE_EDIT = DATE_EDIT.Text
                    DR!TIME_EDIT = TIME_EDIT.Text

                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                End If
                '============================== أضافة تفاصيل الايصال ========================
                Dim CMD_DEL As New SqlClient.SqlCommand
                CMD_DEL.Connection = SqlConn
                CMD_DEL.CommandText = "DELETE FROM R_T_DOCTOR_DT WHERE R_T_CODE_DT ='" & TXT_CODE.Text & "'"
                CMD_DEL.ExecuteNonQuery()

                '==============================================================================
                Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM R_T_DOCTOR_DT", SqlConn)
                DA1.Fill(DT)
                For I = 0 To DataGridView1.Rows.Count - 1
                    Dim DR1 = DT.NewRow
                    DR1!R_T_CODE_DT = TXT_CODE.Text
                    DR1!R_T_DATE = TXT_DATE.Text
                    DR1!R_DT_CODE = DataGridView1.Rows(I).Cells(0).Value
                    DR1!R_DT_THLEL = DataGridView1.Rows(I).Cells(1).Value

                    DR1!STAT_DT = True
                    DT.Rows.Add(DR1)
                    Dim CMD_ As New SqlClient.SqlCommandBuilder(DA1)
                    DA1.Update(DT)
                Next
                '==========================================================================
                PRINTBTN_Click(sender, e)
                MessageBox.Show("تمت عملية حفظ بيانات الروشتة بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NEWBTN_Click(sender, e)

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
            If DT0.Rows(0).Item("R3").ToString = True Then
                '========= قيود الادخال =======================
                If TXT_NAME_PA.Text = "" Then
                    MessageBox.Show("برجاء ادخال اسم المريض", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TXT_NAME_PA.Select()
                    Exit Sub
                End If
                If TXT_DOCTOR.Text = "" Then
                    MessageBox.Show("برجاء ادخال الطبيب المعالج ", "رسالة تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TXT_DOCTOR.Select()
                    Exit Sub
                End If
                '================= تخزين بيانات الصنف في قاعدة البيانات =============
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM R_T_DOCTOR WHERE R_T_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count = 0 Then
                    TXT_CODE.Text = Val(TXT_CODE.Text) + 1
                Else
                    Dim DR = DT.Rows(0)

                    DR!R_STAT = False

                    DR!USER_EDIT = USER_EDIT.Text
                    DR!DATE_EDIT = DATE_EDIT.Text
                    DR!TIME_EDIT = TIME_EDIT.Text

                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                End If
                '==============================================================================
                Dim DT1 As New DataTable
                Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM R_T_DOCTOR_DT WHERE R_T_CODE_DT = '" & TXT_CODE.Text & "'", SqlConn)
                DA1.Fill(DT1)
                Dim DR1 = DT1.Rows(0)

                DR1!STAT_DT = False
                Dim SAVE1 As New SqlClient.SqlCommandBuilder(DA1)
                DA1.Update(DT1)

                MessageBox.Show("تمت عملية حذف بيانات الروشتة بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NEWBTN_Click(sender, e)

            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub SEARCHBTN_Click(sender As Object, e As EventArgs) Handles SEARCHBTN.Click
        SEARCH_THLEL_R.ShowDialog()
    End Sub

    Private Sub UNDOBTN_Click(sender As Object, e As EventArgs) Handles UNDOBTN.Click
        SEARCH_THLEL_R2.ShowDialog()
    End Sub

    Private Sub PRINTBTN_Click(sender As Object, e As EventArgs) Handles PRINTBTN.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("R4").ToString = True Then
                '===========================================================

                Dim DT As New DataTable
                With DT
                    .Columns.Add("R_T_CODE")
                    .Columns.Add("R_T_DATE")
                    .Columns.Add("R_DT_THLEL")
                    .Columns.Add("PA_NAME")
                    .Columns.Add("DO_NAME")

                End With
                For I As Integer = 0 To DataGridView1.Rows.Count - 1
                    If DataGridView1.Rows(I).Cells(0).Value <> Nothing Then
                        DT.Rows.Add(TXT_CODE.Text, TXT_DATE.Text, DataGridView1.Rows(I).Cells(1).Value, TXT_NAME_PA.Text, TXT_DOCTOR.Text)
                    End If
                Next
                Dim REP As New ROSHTA_T_CRS2
                REP.SetDataSource(DT)
                Dim FRM As New REOSHTA_T_REP
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

    Private Sub THLEL_FRM_ROSHTA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEWBTN_Click(sender, e)
        FILL_PATIENT()
        FILL_DOCTOR()
        FILL_THLEL()
    End Sub

    Private Sub HISTORY_PA_Click(sender As Object, e As EventArgs) Handles HISTORY_PA.Click

        Dim DT As New DataTable
        With DT
            .Columns.Add("PA_NAME")
            .Columns.Add("PA_AGE")
            .Columns.Add("PA_TYPE")
            .Columns.Add("PA_OP")
            .Columns.Add("R_CODE_PA")
            .Columns.Add("R_INFO")
            .Columns.Add("R_DT_PHARM")
            .Columns.Add("R_DT_NO3")
            .Columns.Add("R_DT_GOR3A")
            .Columns.Add("R_DATE")
            .Columns.Add("DO_NAME")
            .Columns.Add("DO_TKHSOS")
        End With
        For I As Integer = 0 To VIWERPATIN.Rows.Count - 1
            If VIWERPATIN.Rows(I).Cells(0).Value <> Nothing Then
                DT.Rows.Add(TXT_NAME_PA.Text, TXT_AGE_PA.Text, TXT_TYPE_PA.Text, TXT_3MLIAT.Text, VIWERPATIN.Rows(I).Cells(0).Value, VIWERPATIN.Rows(I).Cells(1).Value, VIWERPATIN.Rows(I).Cells(2).Value, VIWERPATIN.Rows(I).Cells(3).Value, VIWERPATIN.Rows(I).Cells(4).Value, VIWERPATIN.Rows(I).Cells(5).Value, VIWERPATIN.Rows(I).Cells(6).Value, VIWERPATIN.Rows(I).Cells(7).Value)
            End If
        Next
        Dim REP As New HISTORY_PATION_CRS
        REP.SetDataSource(DT)
        Dim FRM As New HISTORY_PATION_FRM_REP
        FRM.CrystalReportViewer1.ReportSource = REP
        FRM.ShowDialog()
    End Sub

    Private Sub ACTIV_BTN_Click(sender As Object, e As EventArgs) Handles ACTIV_BTN.Click
        If TXT_NAME_THLEL.Text = "" Then
            MessageBox.Show("عفوا ليس هناك تحاليل لاضافتها", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_NAME_THLEL.Select()
            Exit Sub
        Else
            Dim BAR As Integer
            '======= اضافة سجل للداتا جريد ===========
            DataGridView1.Rows.Add()
            BAR = DataGridView1.Rows.Count - 1
            DataGridView1(0, BAR).Value = TXT_CODE_THLEL.Text
            DataGridView1(1, BAR).Value = TXT_NAME_THLEL.Text



            TXT_CODE_THLEL.Text = ""
            TXT_NAME_THLEL.Text = ""

            TXT_NAME_THLEL.Select()
        End If

    End Sub


End Class