Public Class ADDTHLELMAMLPAFRM
    Dim ARABIC As New ClassConvertNO
    Sub SHOW_DETA(CODE_)
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_THLEL_PATION WHERE ADD_CODE = '" & CODE_ & "'", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("بيانات التحاليل غير موجودة", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!ADD_CODE
            TXT_DATE.Text = DR!ADD_DATE
            PA_CODE.Text = DR!PA_CODE
            MAML_CODE.Text = DR!MAML_CODE
            USER_ADD.Text = DR!USER_ADD
            DATE_ADD.Text = DR!DATE_ADD
            TIME_ADD.Text = DR!TIME_ADD
            Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_THLEL_PATION_DT WHERE ADD_THLEL = '" & CODE_ & "'", SqlConn)
            DA1.Fill(DT)
            '========================== detels =================
            For I = 0 To DataGridView1.Rows.Count - 1
                Dim DR1 = DT.Rows(0)
                DataGridView1.Rows(I).Cells(1).Value = DR1!MID
                DataGridView1.Rows(I).Cells(2).Value = DR1!CODE_MAML
                DataGridView1.Rows(I).Cells(3).Value = DR1!CODE_THLEL
                DataGridView1.Rows(I).Cells(4).Value = DR1!NAME_THLEL
                DataGridView1.Rows(I).Cells(5).Value = DR1!PRICE_THLEL
                DataGridView1.Rows(I).Cells(6).Value = DR1!PRICE_LABTO
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
    Private Sub ADDTHLELMAMLPAFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        For I = 0 To GroupBox2.Controls.Count - 1
            If TypeOf GroupBox2.Controls(I) Is TextBox Then GroupBox2.Controls(I).Text = ""
        Next
        For I = 0 To GroupBox2.Controls.Count - 1
            If TypeOf GroupBox2.Controls(I) Is ComboBox Then GroupBox2.Controls(I).Text = ""
        Next
        '""""""""""""""" الترقيم التلقائي """"""""""""""
        TXT_CODE.Text = CODE_GENE("ADD_THLEL_PATION", "ID") + 1
        '""""""""""""""""""""""""""""""
        DataGridView1.Rows.Clear()
        MAML_NAME.Items.Clear()
        TH_NAME.Items.Clear()
        TXT_M.Text = "1"
        TIMERADD.Enabled = True
        TIMEREDIT.Enabled = False
        EDITBTN.Enabled = False
        DELETBTN.Enabled = False
        SAVEBTN.Enabled = True
        PA_NAME.Select()
        FILL_PATIENT()
    End Sub

    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("Q21").ToString = True Then
                '=============================================ROOLS===================================

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
                '====================================================================================
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_THLEL_PATION ", SqlConn)
                DA.Fill(DT)
                Dim DR = DT.NewRow
                DR!ADD_CODE = TXT_CODE.Text
                DR!ADD_DATE = TXT_DATE.Text
                DR!PA_CODE = PA_CODE.Text
                DR!MAML_CODE = MAML_CODE.Text
                DR!STAT = True
                DR!USER_ADD = USER_ADD.Text
                DR!DATE_ADD = DATE_ADD.Text
                DR!TIME_ADD = TIME_ADD.Text
                DR!USER_EDIT = "0"
                DR!TIME_EDIT = "0"
                DR!DATE_EDIT = "0"
                DT.Rows.Add(DR)
                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                '=========================================DETELS==========================================
                Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_THLEL_PATION_DT ", SqlConn)
                DA1.Fill(DT)
                For I = 0 To DataGridView1.Rows.Count - 1
                    Dim DR1 = DT.NewRow
                    DR1!ADD_THLEL = TXT_CODE.Text
                    DR1!ADD_DATE = TXT_DATE.Text
                    DR1!MID = DataGridView1.Rows(I).Cells(1).Value
                    DR1!CODE_MAML = DataGridView1.Rows(I).Cells(2).Value
                    DR1!CODE_THLEL = DataGridView1.Rows(I).Cells(3).Value
                    DR1!NAME_THLEL = DataGridView1.Rows(I).Cells(4).Value
                    DR1!PRICE_THLEL = DataGridView1.Rows(I).Cells(5).Value
                    DR1!PRICE_LABTO = DataGridView1.Rows(I).Cells(6).Value

                    DR1!STAT_DT = True
                    DT.Rows.Add(DR1)
                    Dim CMD_ As New SqlClient.SqlCommandBuilder(DA1)
                    DA1.Update(DT)
                Next

                MessageBox.Show("تمت عملية حفظ بيانات التحاليل بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NEWBTN_Click(sender, e)
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
            If DT0.Rows(0).Item("Q22").ToString = True Then
                '=============================================ROOLS===================================

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
                '====================================================================================
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_THLEL_PATION WHERE ADD_CODE='" & TXT_CODE.Text & "' ", SqlConn)
                DA.Fill(DT)
                Dim DR = DT.Rows(0)
                DR!ADD_CODE = TXT_CODE.Text
                DR!ADD_DATE = TXT_DATE.Text
                DR!PA_CODE = PA_CODE.Text
                DR!MAML_CODE = MAML_CODE.Text
                DR!STAT = True
                DR!USER_EDIT = USER_EDIT.Text
                DR!TIME_EDIT = TIME_EDIT.Text
                DR!DATE_EDIT = DATE_EDIT.Text

                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                '========================= DELET DETELS ====================================================
                Dim CMD_DEL As New SqlClient.SqlCommand
                CMD_DEL.Connection = SqlConn
                CMD_DEL.CommandText = "DELETE FROM ADD_THLEL_PATION_DT WHERE ADD_THLEL ='" & TXT_CODE.Text & "'"
                CMD_DEL.ExecuteNonQuery()
                '=========================================DETELS==========================================
                Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_THLEL_PATION_DT  ", SqlConn)
                DA1.Fill(DT)
                For I = 0 To DataGridView1.Rows.Count - 1
                    Dim DR1 = DT.NewRow
                    DR1!ADD_THLEL = TXT_CODE.Text
                    DR1!ADD_DATE = TXT_DATE.Text
                    DR1!MID = DataGridView1.Rows(I).Cells(1).Value
                    DR1!CODE_MAML = DataGridView1.Rows(I).Cells(2).Value
                    DR1!CODE_THLEL = DataGridView1.Rows(I).Cells(3).Value
                    DR1!NAME_THLEL = DataGridView1.Rows(I).Cells(4).Value
                    DR1!PRICE_THLEL = DataGridView1.Rows(I).Cells(5).Value
                    DR1!PRICE_LABTO = DataGridView1.Rows(I).Cells(6).Value

                    DR1!STAT_DT = True
                    DT.Rows.Add(DR1)
                    Dim CMD_ As New SqlClient.SqlCommandBuilder(DA1)
                    DA1.Update(DT)
                Next

                MessageBox.Show("تمت عملية تعديل بيانات التحاليل بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NEWBTN_Click(sender, e)



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
            If DT0.Rows(0).Item("Q23").ToString = True Then
                '====================================================================================
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_THLEL_PATION WHERE ADD_CODE='" & TXT_CODE.Text & "' ", SqlConn)
                DA.Fill(DT)
                Dim DR = DT.Rows(0)

                DR!STAT = False
                DR!USER_EDIT = USER_EDIT.Text
                DR!TIME_EDIT = TIME_EDIT.Text
                DR!DATE_EDIT = DATE_EDIT.Text

                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)

                '=========================================DETELS==========================================
                Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM ADD_THLEL_PATION_DT WHERE ADD_THLEL='" & TXT_CODE.Text & "'  ", SqlConn)
                DA1.Fill(DT)
                For I = 0 To DataGridView1.Rows.Count - 1
                    Dim DR1 = DT.Rows(0)

                    DR1!STAT_DT = False

                    Dim CMD_ As New SqlClient.SqlCommandBuilder(DA1)
                    DA1.Update(DT)
                Next

                MessageBox.Show("تمت عملية حذف بيانات التحاليل بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NEWBTN_Click(sender, e)




            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub SEARCHBTN_Click(sender As Object, e As EventArgs) Handles SEARCHBTN.Click

    End Sub

    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub

    Private Sub TIM_CALC_Tick(sender As Object, e As EventArgs) Handles TIM_CALC.Tick
        CALC()
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
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PRICETHLEL WHERE STAT='TRUE' AND THLIL_NAME ='" & TH_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TH_CODE.Text = DT.Rows(I).Item("THLIL_CODE")
            TH_PRICE.Text = DT.Rows(I).Item("PRICEEG")
            TH_PRICE_LAP.Text = DT.Rows(I).Item("PRICELAP")
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
        DataGridView1(3, BAR).Value = TH_CODE.Text
        DataGridView1(4, BAR).Value = TH_NAME.Text
        DataGridView1(5, BAR).Value = TH_PRICE.Text
        DataGridView1(6, BAR).Value = TH_PRICE_LAP.Text

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

    Private Sub PRINTBTN_Click(sender As Object, e As EventArgs) Handles PRINTBTN.Click
        'Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        'Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        'Dim DS0 As New DataSet
        'ADP0.Fill(DS0)
        'Dim DT0 = DS0.Tables(0)
        'If DT0.Rows.Count > 0 Then
        '    If DT0.Rows(0).Item("24").ToString = True Then




        '    Else
        '        MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

        '    End If
        'End If
    End Sub
End Class