Public Class T3AKODATFRM
    Sub SHOW_DETA(CODE_)
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM T3AKODAT WHERE TA_CODE = '" & CODE_ & "'", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("بيانات التعاقد غير موجودة", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!TA_CODE
            TXT_NAME.Text = DR!TA_NAME
            TXT_TEL.Text = DR!TA_TEL
            TXT_NESPA.Text = DR!TA_NESBA
            TXT_ADRRES.Text = DR!TA_ADRRES
            TXT_MANGER.Text = DR!TA_MANEGAR
            TXT_INFO.Text = DR!TA_INFO
            CH1.Checked = DR!CH1
            TXT1.Text = DR!TXT1
            CH2.Checked = DR!CH2
            TXT2.Text = DR!TXT2
            CH3.Checked = DR!CH3
            TXT3.Text = DR!TXT3
            CH4.Checked = DR!CH4
            TXT4.Text = DR!TXT4

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
        TIMERADD.Enabled = True
        TIMEREDIT.Enabled = False

        '""""""""""""""" تنظيف الشاشة """""""""""""
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        '""""""""""""""" الترقيم التلقائي """"""""""""""
        TXT_CODE.Text = CODE_GENE("T3AKODAT", "ID") + 1
        '""""""""""""""""""""""""""""""
        EDITBTN.Enabled = False
        DELETBTN.Enabled = False
        SAVEBTN.Enabled = True
        TXT_NAME.Select()
    End Sub

    Private Sub T3AKODATFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEWBTN_Click(sender, e)
    End Sub

    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click

        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("K1").ToString = True Then


                '========= قيود الادخال =======================
                If TXT_NAME.Text = "" Then
                    MessageBox.Show("يرجى ادخال اسم جهة التعاقد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_NAME.Select()
                    Exit Sub
                End If

                If TXT_TEL.Text = "" Then
                    MessageBox.Show("يرجى ادخال تليفون جهة التعاقد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_TEL.Select()
                    Exit Sub
                End If

                If TXT_NESPA.Text = "" Then
                    MessageBox.Show("يرجى ادخال خصم الجهة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_NESPA.Select()
                    Exit Sub
                End If

                '================= تخزين بيانات الصنف في قاعدة البيانات =============

                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM T3AKODAT WHERE TA_NAME = '" & TXT_NAME.Text & "'", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count > 0 Then
                    MessageBox.Show("التعاقد موجود مسبقاً ، يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim DR = DT.NewRow
                    DR!TA_CODE = TXT_CODE.Text
                    DR!TA_NAME = TXT_NAME.Text
                    DR!TA_TEL = TXT_TEL.Text
                    DR!TA_NESBA = TXT_NESPA.Text
                    DR!TA_ADRRES = TXT_ADRRES.Text
                    DR!TA_MANEGAR = TXT_MANGER.Text
                    DR!TA_INFO = TXT_INFO.Text
                    DR!CH1 = CH1.Checked
                    DR!TXT1 = TXT1.Text
                    DR!CH2 = CH2.Checked
                    DR!TXT2 = TXT2.Text
                    DR!CH3 = CH3.Checked
                    DR!TXT3 = TXT3.Text
                    DR!CH4 = CH4.Checked
                    DR!TXT4 = TXT4.Text
                    DR!STAT = True
                    DR!USER_ADD = USER_ADD.Text
                    DR!DATE_ADD = DATE_ADD.Text
                    DR!TIME_ADD = TIME_ADD.Text
                    DT.Rows.Add(DR)
                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    MessageBox.Show("تمت عملية حفظ بيانات التعاقد بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            If DT0.Rows(0).Item("K2").ToString = True Then
                '========= قيود الادخال =======================
                If TXT_NAME.Text = "" Then
                    MessageBox.Show("يرجى ادخال اسم جهة التعاقد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_NAME.Select()
                    Exit Sub
                End If

                If TXT_TEL.Text = "" Then
                    MessageBox.Show("يرجى ادخال تليفون جهة التعاقد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_TEL.Select()
                    Exit Sub
                End If

                If TXT_NESPA.Text = "" Then
                    MessageBox.Show("يرجى ادخال خصم الجهة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_NESPA.Select()
                    Exit Sub
                End If

                '================= تخزين بيانات الصنف في قاعدة البيانات =============

                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM T3AKODAT WHERE TA_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count = 0 Then
                    MessageBox.Show("التعاقد موجود مسبقاً ، يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim DR = DT.Rows(0)
                    DR!TA_CODE = TXT_CODE.Text
                    DR!TA_NAME = TXT_NAME.Text
                    DR!TA_TEL = TXT_TEL.Text
                    DR!TA_NESBA = TXT_NESPA.Text
                    DR!TA_ADRRES = TXT_ADRRES.Text
                    DR!TA_MANEGAR = TXT_MANGER.Text
                    DR!TA_INFO = TXT_INFO.Text
                    DR!CH1 = CH1.Checked
                    DR!TXT1 = TXT1.Text
                    DR!CH2 = CH2.Checked
                    DR!TXT2 = TXT2.Text
                    DR!CH3 = CH3.Checked
                    DR!TXT3 = TXT3.Text
                    DR!CH4 = CH4.Checked
                    DR!TXT4 = TXT4.Text
                    DR!STAT = True
                    DR!USER_ADD = USER_ADD.Text
                    DR!DATE_ADD = DATE_ADD.Text
                    DR!TIME_ADD = TIME_ADD.Text
                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    MessageBox.Show("تمت عملية تعديل بيانات التعاقد بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            If DT0.Rows(0).Item("K3").ToString = True Then

                If MessageBox.Show("هل ترغب في حذف بيانات التعاقد ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub
                '============================  كود الحفظ =====================
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM T3AKODAT WHERE TA_CODE = '" & TXT_CODE.Text & "'  ", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count = 0 Then
                    MessageBox.Show("التعاقد غير موجود يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    Dim UPDATE As Integer = BindingContext(DT).Position
                    DT.Rows(UPDATE).Item("STAT") = False
                    DT.Rows(UPDATE).Item("USER_EDIT") = USER_EDIT.Text
                    DT.Rows(UPDATE).Item("DATE_EDIT") = DATE_EDIT.Text
                    DT.Rows(UPDATE).Item("TIME_EDIT") = TIME_EDIT.Text
                    Dim Save As New SqlClient.SqlCommandBuilder(DA)

                    DA.Update(DT)
                    DT.AcceptChanges()
                    MessageBox.Show("تمت عملية حذف بيانات التعاقد بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    NEWBTN_Click(sender, e)

                End If




            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub PRINTBTN_Click(sender As Object, e As EventArgs) Handles PRINTBTN.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("K4").ToString = True Then
                '===========================================================

                Dim DT As New DataTable
                With DT
                    .Columns.Add("TA_CODE")
                    .Columns.Add("TA_NAME")
                    .Columns.Add("TA_TEL")
                    .Columns.Add("TA_NESBA")
                    .Columns.Add("TA_ADRRES")
                    .Columns.Add("TA_MANEGAR")
                    .Columns.Add("TA_INFO")
                    .Columns.Add("TXT1")
                    .Columns.Add("TXT2")
                    .Columns.Add("TXT3")
                    .Columns.Add("TXT4")
                    .Columns.Add("USER_ADD")
                End With
                'For I As Integer = 0 To DataGridView1.Rows.Count - 1
                '    If DataGridView1.Rows(I).Cells(0).Value <> Nothing Then
                DT.Rows.Add(TXT_CODE.Text, TXT_NAME.Text, TXT_TEL.Text, TXT_NESPA.Text, TXT_ADRRES.Text, TXT_MANGER.Text, TXT_INFO.Text, TXT1.Text, TXT2.Text, TXT3.Text, TXT4.Text, USER_ADD.Text)
                '    End If
                'Next
                Dim REP As New T3AKODAT_REP
                REP.SetDataSource(DT)
                Dim FRM As New T3AKODAT_CRS
                FRM.CrystalReportViewer1.ReportSource = REP
                FRM.ShowDialog()



                '=============================================================
            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub CH1_CheckedChanged(sender As Object, e As EventArgs) Handles CH1.CheckedChanged
        If CH1.Checked = True Then
            TXT1.Visible = True
            TXT1.Text = ""
        Else
            TXT1.Visible = False
            TXT1.Text = "غير متعاقد"
        End If
    End Sub

    Private Sub CH2_CheckedChanged(sender As Object, e As EventArgs) Handles CH2.CheckedChanged
        If CH2.Checked = True Then
            TXT2.Visible = True
            TXT2.Text = ""
        Else
            TXT2.Visible = False
            TXT2.Text = "غير متعاقد"
        End If
    End Sub

    Private Sub CH3_CheckedChanged(sender As Object, e As EventArgs) Handles CH3.CheckedChanged
        If CH3.Checked = True Then
            TXT3.Visible = True
            TXT3.Text = ""
        Else
            TXT3.Visible = False
            TXT3.Text = "غير متعاقد"
        End If
    End Sub

    Private Sub CH4_CheckedChanged(sender As Object, e As EventArgs) Handles CH4.CheckedChanged
        If CH4.Checked = True Then
            TXT4.Visible = True
            TXT4.Text = ""
        Else
            TXT4.Visible = False
            TXT4.Text = "غير متعاقد"
        End If
    End Sub

    Private Sub TXT_NAME_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_NAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub TXT_TEL_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_TEL.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub TXT_NESPA_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_NESPA.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub TXT_ADRRES_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_ADRRES.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub TXT_MANGER_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_MANGER.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub TXT_INFO_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_INFO.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub T3AKODATFRM_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub TXT_NESPA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_NESPA.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Then
            Else
                MsgBox("من فضلك ادخل رقم صحيح فقط")
                e.Handled = True
            End If
        End If
    End Sub



    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub

    Private Sub SEARCHBTN_Click(sender As Object, e As EventArgs) Handles SEARCHBTN.Click
        SEARCH_T3AKOD.ShowDialog()
    End Sub

    Private Sub UNDOBTN_Click(sender As Object, e As EventArgs) Handles UNDOBTN.Click
        SEARCH_T3AKOD2.ShowDialog()
    End Sub
End Class