Public Class FATO_AMLIAT_FRM
    Dim ARABIC As New ClassConvertNO

    Sub SHOW_DETA(CODE_)
        DataGridView1.Rows.Clear()
        '=========== ربط رأس الفاتورة =============
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM FATO_MASTER WHERE FATO_CODE ='" & CODE_ & "'", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("يرجى التأكد من رقم الفاتورة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!FATO_CODE
            TXT_PA_CODE.Text = DR!PA_CODE
            TXT_DATE.Text = DR!FATO_DATE
            TXT_HOSPITAL.Text = DR!FATO_HOSPITAL
            TXT_GHA.Text = DR!FATO_GHA
            TXT_TYPE_INFO.Text = DR!FATO_INFO
            TOTAL.Text = DR!FATO_TOTAL
            SAFY_AR.Text = DR!FATO_TOTAL_AR

            USER_ADD.Text = DR!FATO_USER_ADD
            DATE_ADD.Text = DR!FATO_DATE_ADD
            TIME_ADD.Text = DR!FATO_TIME_ADD

            '=========== ربط تفاصيل الفاتورة =============
            Dim DT10 As New DataTable
            Dim DA10 As New SqlClient.SqlDataAdapter("SELECT * FROM FATO_DT WHERE FATO_CODE = '" & CODE_ & "'", SqlConn)
            DA10.Fill(DT10)
            For I = 0 To DT10.Rows.Count - 1
                DataGridView1.Rows.Add()
                DataGridView1.Rows(I).Cells(0).Value = DT10.Rows(I).Item("FATO_ACTION")
                DataGridView1.Rows(I).Cells(1).Value = DT10.Rows(I).Item("FATO_PRICE_ACTION")

            Next


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
            TOTAL_ = Val(TOTAL_) + Val(DataGridView1.Rows(I).Cells(1).Value)
        Next
        TOTAL.Text = Val(TOTAL_)

        If Val(TOTAL.Text) > 0 Then
            SAFY_AR.Text = ARABIC.ConvertToArabic(TOTAL.Text)
        Else
            SAFY_AR.Text = ""
        End If
    End Sub
    Sub HOSPITALYA()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HOSPITALYA ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_HOSPITAL.Items.Add(DT.Rows(I).Item("HOSPITAL"))
        Next
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
    Private Sub TXT_PA_NAME_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles TXT_PA_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME='" & TXT_PA_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA_CODE.Text = DT.Rows(I).Item("PA_CODE")
            TXT_PA_CODE2.Text = DT.Rows(I).Item("PA_CODE2")
        Next
    End Sub

    Private Sub FATO_AMLIAT_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEWBTN_Click(sender, e)
    End Sub

    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles NEWBTN.Click
        '""""""""""""""" تنظيف الشاشة """""""""""""
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        DataGridView1.Rows.Clear()
        '""""""""""""""" الترقيم التلقائي """"""""""""""
        TXT_CODE.Text = CODE_GENE("FATO_MASTER", "ID") + 1
        '""""""""""""""""""""""""""""""
        EDITBTN.Enabled = False
        SAVEBTN.Enabled = True
        TIMERADD.Enabled = True
        TIMEREDIT.Enabled = False

        CALC()
        HOSPITALYA()
        '=====================================================
        Me.PATIENTDATA.Clear()
        Me.PATIENTTableAdapter.Fill(Me.PATIENTDATA.PATIENT)
        TXT_PA_NAME.Text = ""
        TXT_HOSPITAL.Text = ""
    End Sub

    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Dispose()
    End Sub

    Private Sub ACTIVE_DOCTOR_Click_1(sender As Object, e As EventArgs) Handles ACTIVE_DOCTOR.Click
        Dim BAR As Integer
        '======= اضافة سجل للداتا جريد ===========
        DataGridView1.Rows.Add()
        BAR = DataGridView1.Rows.Count - 1
        DataGridView1(0, BAR).Value = TXT_NAME_ACTION.Text
        DataGridView1(1, BAR).Value = TXT_QUMA_ACTION.Text
        CALC()

        TXT_NAME_ACTION.Text = ""
        TXT_QUMA_ACTION.Text = ""
        TXT_NAME_ACTION.Select()
    End Sub

    Private Sub TXT_QUMA_ACTION_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_QUMA_ACTION.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Then
            Else
                MsgBox("من فضلك ادخل رقم صحيح فقط")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TXT_CODE_TextChanged(sender As Object, e As EventArgs) Handles TXT_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_CODE='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA_NAME.Text = DT.Rows(I).Item("PA_NAME")
            TXT_PA_CODE2.Text = DT.Rows(I).Item("PA_CODE2")
        Next
    End Sub

    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM FATO_MASTER ", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.NewRow
        DR!FATO_CODE = TXT_CODE.Text
        DR!PA_CODE = TXT_PA_CODE.Text
        DR!FATO_DATE = TXT_DATE.Text
        DR!FATO_HOSPITAL = TXT_HOSPITAL.Text
        DR!FATO_GHA = TXT_GHA.Text
        DR!FATO_INFO = TXT_TYPE_INFO.Text
        DR!FATO_TOTAL = TOTAL.Text
        DR!FATO_TOTAL_AR = SAFY_AR.Text
        DR!FATO_STAT = True
        DR!FATO_USER_ADD = USER_ADD.Text
        DR!FATO_DATE_ADD = DATE_ADD.Text
        DR!FATO_TIME_ADD = TIME_ADD.Text

        DT.Rows.Add(DR)
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)

        Dim DT1 As New DataTable
        Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM FATO_DT ", SqlConn)
        DA1.Fill(DT1)

        For I = 0 To DataGridView1.Rows.Count - 1
            Dim DR1 = DT1.NewRow
            DR1!FATO_CODE = TXT_CODE.Text
            DR1!FATO_DATE = TXT_DATE.Text
            DR1!FATO_ACTION = DataGridView1.Rows(I).Cells(0).Value
            DR1!FATO_PRICE_ACTION = DataGridView1.Rows(I).Cells(1).Value

            DT1.Rows.Add(DR1)
            Dim CMD_ As New SqlClient.SqlCommandBuilder(DA1)
            DA1.Update(DT1)

        Next

        PRINTBTN_Click(sender, e)

        MessageBox.Show("تمت عملية الحفظ بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)

        NEWBTN_Click(sender, e)

    End Sub

    Private Sub EDITBTN_Click(sender As Object, e As EventArgs) Handles EDITBTN.Click
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM FATO_MASTER WHERE FATO_CODE = '" & TXT_CODE.Text & "' ", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.Rows(0)
        DR!FATO_CODE = TXT_CODE.Text
        DR!PA_CODE = TXT_PA_CODE.Text
        DR!FATO_DATE = TXT_DATE.Text
        DR!FATO_HOSPITAL = TXT_HOSPITAL.Text
        DR!FATO_GHA = TXT_GHA.Text
        DR!FATO_INFO = TXT_TYPE_INFO.Text
        DR!FATO_TOTAL = TOTAL.Text
        DR!FATO_TOTAL_AR = SAFY_AR.Text
        DR!FATO_STAT = True

        DR!FATO_USER_EDIT = USER_EDIT.Text
        DR!FATO_DATE_EDIT = DATE_EDIT.Text
        DR!FATO_TIME_EDIT = TIME_EDIT.Text

        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)

        Dim DT1 As New DataTable
        Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM FATO_DT WHERE FATO_CODE = '" & TXT_CODE.Text & "' ", SqlConn)
        DA1.Fill(DT1)

        For I = 0 To DataGridView1.Rows.Count - 1
            Dim DR1 = DT1.Rows(0)
            DR1!FATO_CODE = TXT_CODE.Text
            DR1!FATO_DATE = TXT_DATE.Text
            DR1!FATO_ACTION = DataGridView1.Rows(I).Cells(0).Value
            DR1!FATO_PRICE_ACTION = DataGridView1.Rows(I).Cells(1).Value


            Dim CMD_ As New SqlClient.SqlCommandBuilder(DA1)
            DA1.Update(DT1)

        Next

        PRINTBTN_Click(sender, e)

        MessageBox.Show("تمت عملية التعديل بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)

        NEWBTN_Click(sender, e)
    End Sub

    Private Sub DELETBTN_Click(sender As Object, e As EventArgs) Handles DELETBTN.Click

    End Sub

    Private Sub SEARCHBTN_Click(sender As Object, e As EventArgs) Handles SEARCHBTN.Click
        SEARCH_FATO_RS.ShowDialog()
    End Sub

    Private Sub PRINTBTN_Click(sender As Object, e As EventArgs) Handles PRINTBTN.Click

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM FATO_RS_V WHERE FATO_CODE='" & TXT_CODE.Text & "'", SqlConn)
        DA.Fill(DT)

        Dim REP As New FATO_RS_CRS
        REP.SetDataSource(DT)

        Dim FRM As New REPFORALL
        FRM.CrystalReportViewer1.ReportSource = REP
        FRM.ShowDialog()
    End Sub
End Class