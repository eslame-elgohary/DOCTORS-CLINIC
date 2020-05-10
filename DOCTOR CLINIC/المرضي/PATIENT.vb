Public Class PATIENT
    Sub SHOW_DETA(CODE_)
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_CODE = '" & CODE_ & "'", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("بيانات المريض غير موجودة", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            PA_CODE.Text = DR!PA_CODE
            PA_CODE2.Text = DR!PA_CODE2
            PA_NAME.Text = DR!PA_NAME
            PA_NAME2.Text = DR!PA_NAME2
            PA_TEL.Text = DR!PA_TEL
            PA_TEL2.Text = DR!PA_TEL2
            PA_AGE.Text = DR!PA_AGE
            PA_OP_R1.Checked = DR!PA_OP_R1
            PA_OP.Text = DR!PA_OP
            PA_CHI_R1.Checked = DR!PA_CHI_R1
            PA_CHI.Text = DR!PA_CHI
            PA_TYPE.Text = DR!PA_TYPE

            DELETBTN.Enabled = True
            EDITBTN.Enabled = True
            SAVEBTN.Enabled = False
            TIMEREDIT.Enabled = True
            TIMERADD.Enabled = False
            AUTOCHI.Checked = False
            AUTOCHI.Visible = False


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
        AUTOCHI.Visible = True
        AUTOCHI.Checked = True
        '""""""""""""""" تنظيف الشاشة """""""""""""
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        PA_CHI_R1.Checked = True
        PA_OP_R1.Checked = True
        PA_CODE2.Text = ""
        '""""""""""""""" الترقيم التلقائي """"""""""""""
        PA_CODE.Text = CODE_GENE("PATIENT", "ID") + 1
        '""""""""""""""""""""""""""""""


        EDITBTN.Enabled = False
        DELETBTN.Enabled = False
        SAVEBTN.Enabled = True
        PA_NAME.Select()
        PATION()
        PA_NAME.Text = ""

    End Sub
    Sub PATION()
        PA_NAME.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT PA_NAME,STAT FROM PATIENT WHERE STAT = 'TRUE'", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            For I = 0 To DT.Rows.Count - 1
                PA_NAME.Items.Add(DT.Rows(I).Item("PA_NAME"))

            Next

        End If
    End Sub

    Private Sub PATIENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEWBTN_Click(sender, e)
    End Sub

    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub

    Private Sub PA_TEL_KeyDown(sender As Object, e As KeyEventArgs) Handles PA_TEL.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub PA_AGE_KeyDown(sender As Object, e As KeyEventArgs) Handles PA_AGE.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub PA_NAME2_KeyDown(sender As Object, e As KeyEventArgs) Handles PA_NAME2.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub PA_TEL2_KeyDown(sender As Object, e As KeyEventArgs) Handles PA_TEL2.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub PA_OP_R1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub PA_CHI_R1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub PA_CODE2_KeyDown(sender As Object, e As KeyEventArgs) Handles PA_CODE2.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub
    Private Sub PA_NAME_TextChanged(sender As Object, e As EventArgs)
        PA_NAME.BackColor = Color.White
    End Sub
    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("A1").ToString = True Then

                '========= قيود الادخال =======================
                If PA_NAME.Text = "" Then
                    PA_NAME.BackColor = Color.Red
                    PA_NAME.Select()
                    Exit Sub
                End If
                '================= تخزين بيانات الصنف في قاعدة البيانات =============

                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME = '" & PA_NAME.Text & "'", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count > 0 Then
                    MessageBox.Show("المريض موجود مسبقاً ، يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim DR = DT.NewRow
                    DR!PA_CODE = PA_CODE.Text
                    DR!PA_CODE2 = PA_CODE2.Text
                    DR!PA_NAME = PA_NAME.Text
                    DR!PA_NAME2 = PA_NAME2.Text
                    DR!PA_TEL = PA_TEL.Text
                    DR!PA_TEL2 = PA_TEL2.Text
                    DR!PA_AGE = PA_AGE.Text
                    DR!PA_OP_R1 = PA_OP_R1.Checked
                    DR!PA_OP = PA_OP.Text
                    DR!PA_CHI_R1 = PA_CHI_R1.Checked
                    DR!PA_CHI = PA_CHI.Text
                    DR!PA_TYPE = PA_TYPE.Text
                    DR!STAT = True
                    DR!USER_ADD = USER_ADD.Text
                    DR!DATE_ADD = DATE_ADD.Text
                    DR!TIME_ADD = TIME_ADD.Text
                    DT.Rows.Add(DR)
                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    MessageBox.Show("تمت عملية حفظ بيانات المريض بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    NEWBTN_Click(sender, e)
                End If

            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub SEARCHBTN_Click(sender As Object, e As EventArgs) Handles SEARCHBTN.Click
        SEARCH_PATIENT.ShowDialog()
    End Sub

    Private Sub EDITBTN_Click(sender As Object, e As EventArgs) Handles EDITBTN.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("A2").ToString = True Then

                '========= قيود الادخال =======================
                If PA_NAME.Text = "" Then
                    PA_NAME.BackColor = Color.Red
                    PA_NAME.Select()
                    Exit Sub
                End If
                '================= تخزين بيانات الصنف في قاعدة البيانات =============
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_CODE = '" & PA_CODE.Text & "'", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count = 0 Then
                    MessageBox.Show("المريض موجود مسبقاً ، يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim UPDATE = DT.Rows(0)
                    UPDATE!PA_CODE = PA_CODE.Text
                    UPDATE!PA_CODE2 = PA_CODE2.Text
                    UPDATE!PA_NAME = PA_NAME.Text
                    UPDATE!PA_NAME2 = PA_NAME2.Text
                    UPDATE!PA_TEL = PA_TEL.Text
                    UPDATE!PA_TEL2 = PA_TEL2.Text
                    UPDATE!PA_AGE = PA_AGE.Text
                    UPDATE!PA_OP_R1 = PA_OP_R1.Checked
                    UPDATE!PA_OP = PA_OP.Text
                    UPDATE!PA_CHI_R1 = PA_CHI_R1.Checked
                    UPDATE!PA_CHI = PA_CHI.Text
                    UPDATE!PA_TYPE = PA_TYPE.Text
                    UPDATE!STAT = True
                    UPDATE!USER_EDIT = USER_EDIT.Text
                    UPDATE!DATE_EDIT = DATE_EDIT.Text
                    UPDATE!TIME_EDIT = TIME_EDIT.Text
                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    MessageBox.Show("تمت عملية تعديل بيانات المريض بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    NEWBTN_Click(sender, e)


                End If

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
            If DT0.Rows(0).Item("A3").ToString = True Then


                If MessageBox.Show("هل ترغب في حذف بيانات المريض ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub
                '============================  كود الحفظ =====================
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_CODE = '" & PA_CODE.Text & "'  ", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count = 0 Then
                    MessageBox.Show("المريض غير موجود يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim UPDATE = DT.Rows(0)
                    UPDATE!STAT = False
                    UPDATE!USER_EDIT = USER_EDIT.Text
                    UPDATE!DATE_EDIT = DATE_EDIT.Text
                    UPDATE!TIME_EDIT = TIME_EDIT.Text
                    Dim Save As New SqlClient.SqlCommandBuilder(DA)

                    DA.Update(DT)
                    DT.AcceptChanges()
                    MessageBox.Show("تمت عملية حذف بيانات المريض بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    NEWBTN_Click(sender, e)

                End If




            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub UNDOBTN_Click(sender As Object, e As EventArgs) Handles UNDOBTN.Click
        SEARCH_PATIENT2.ShowDialog()
    End Sub

    Private Sub PRINTBTN_Click(sender As Object, e As EventArgs) Handles PRINTBTN.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("A4").ToString = True Then

                Dim DT As New DataTable
                With DT
                    .Columns.Add("PA_CODE")
                    .Columns.Add("PA_CODE2")
                    .Columns.Add("PA_NAME")
                    .Columns.Add("PA_NAME2")
                    .Columns.Add("PA_TEL")
                    .Columns.Add("PA_TEL2")
                    .Columns.Add("PA_OP")
                    .Columns.Add("PA_OP_R1")
                    .Columns.Add("PA_CHI_R1")
                    .Columns.Add("PA_CHI")
                    .Columns.Add("PA_AGE")
                    .Columns.Add("USER_ADD")
                    .Columns.Add("PA_TYPE")

                End With
                'For I As Integer = 0 To DataGridView1.Rows.Count - 1
                '    If DataGridView1.Rows(I).Cells(0).Value <> Nothing Then
                DT.Rows.Add(PA_CODE.Text, PA_CODE2.Text, PA_NAME.Text, PA_NAME2.Text, PA_TEL.Text, PA_TEL2.Text, PA_OP.Text, PA_OP_R1.Checked, PA_CHI_R1.Checked, PA_CHI.Text, PA_AGE.Text, USER_ADD.Text, PA_TYPE.Text)
                '    End If
                'Next
                Dim REP As New PATIENT_CRS
                REP.SetDataSource(DT)
                Dim FRM As New PATIENT_PRINT
                FRM.CrystalReportViewer1.ReportSource = REP
                FRM.ShowDialog()




            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub PATIENT_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub PA_CHI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PA_CHI.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Then
            Else
                MsgBox("من فضلك ادخل رقم صحيح فقط")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PA_TYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PA_TYPE.SelectedIndexChanged
        If PA_TYPE.SelectedIndex = 0 Then
            PA_CHI_R1.Visible = False
        Else
            PA_CHI_R1.Visible = True
        End If
    End Sub

    Private Sub AUTOCHI_CheckedChanged(sender As Object, e As EventArgs) Handles AUTOCHI.CheckedChanged
        If AUTOCHI.Checked = True Then
            AUTOPA.Enabled = True
            PA_CODE2.Enabled = False
        Else
            AUTOPA.Enabled = False
            PA_CODE2.Enabled = True
        End If
    End Sub

    Private Sub AUTOPA_Tick(sender As Object, e As EventArgs) Handles AUTOPA.Tick
        PA_CODE2.Text = CODE_GENE("PATIENT", "ID") + 1
    End Sub

    Private Sub PA_OP_R1_CheckedChanged(sender As Object, e As EventArgs) Handles PA_OP_R1.CheckedChanged
        If PA_OP_R1.Checked = True Then
            PA_OP.Visible = False
            Label8.Visible = False
            PA_OP.Text = "لا يوجد"
        Else

            PA_OP.Visible = True
            Label8.Visible = True

        End If
    End Sub

    Private Sub PA_CHI_R1_CheckedChanged(sender As Object, e As EventArgs) Handles PA_CHI_R1.CheckedChanged
        If PA_CHI_R1.Checked = True Then
            PA_CHI.Visible = False
            Label9.Visible = False
            PA_CHI.Text = "لا يوجد"
        Else
            PA_CHI.Visible = True
            Label9.Visible = True
        End If
    End Sub

    Private Sub PA_NAME_KeyDown(sender As Object, e As KeyEventArgs) Handles PA_NAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
            Try
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME = '" & PA_NAME.Text & "'", SqlConn)
                DA.Fill(DT)

                Dim DR = DT.Rows(0)
                PA_CODE.Text = DR!PA_CODE
                PA_CODE2.Text = DR!PA_CODE2
                PA_NAME.Text = DR!PA_NAME
                PA_NAME2.Text = DR!PA_NAME2
                PA_TEL.Text = DR!PA_TEL
                PA_TEL2.Text = DR!PA_TEL2
                PA_AGE.Text = DR!PA_AGE
                PA_OP_R1.Checked = DR!PA_OP_R1
                PA_OP.Text = DR!PA_OP
                PA_CHI_R1.Checked = DR!PA_CHI_R1
                PA_CHI.Text = DR!PA_CHI
                PA_TYPE.Text = DR!PA_TYPE

                DELETBTN.Enabled = True
                EDITBTN.Enabled = True
                SAVEBTN.Enabled = False
                TIMEREDIT.Enabled = True
                TIMERADD.Enabled = False
                AUTOCHI.Checked = False
                AUTOCHI.Visible = False

            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub PA_TYPE_KeyDown(sender As Object, e As KeyEventArgs) Handles PA_TYPE.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub
End Class