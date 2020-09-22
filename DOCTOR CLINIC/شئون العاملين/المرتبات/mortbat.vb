Public Class mortbat
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
    Sub EMP_FILL()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM EMP WHERE EMP_STAT='TRUE'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_NAME_EMP.Items.Add(DT.Rows(I).Item("EMP_NAME"))
        Next
    End Sub
    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles NEWBTN.Click
        '""""""""""""""" تنظيف الشاشة """""""""""""
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        EMP_FILL()
        TXT_NAME_EMP.Text = ""
        TXT_HDOR.Text = Date.Now.ToString("HH:mm")
        TXT_ENSRAF.Text = Date.Now.ToString("HH:mm")
        TXT_DATE.Text = Date.Today

    End Sub

    Private Sub mortbat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEWBTN_Click(sender, e)
    End Sub

    Sub D2E2A()

        Dim time1 As Date = Date.Parse(Me.TXT_HDOR_M.Text)
        Dim time2 As Date = Date.Parse(Me.TXT_ENSRAF_M.Text)

        Dim time3 As Date = Date.Parse(Me.TXT_HDOR.Text)
        Dim time4 As Date = Date.Parse(Me.TXT_ENSRAF.Text)

        T2.Text = DateDiff(DateInterval.Minute, time1, time2)

        T3.Text = DateDiff(DateInterval.Minute, time3, time4)

    End Sub
    Sub THWEL()
        Dim TOTALM As Double
        TOTALM = Val(TXT_RATEB.Text) / 26
        Dim TOTALH As Double
        TOTALH = TOTALM / 8
        Dim TOTALM1 As Double
        TOTALM1 = TOTALH / 60

        T1.Text = TOTALM1

        T4.Text = Val(T3.Text) - Val(T2.Text)
        Q_EDAFY.Text = Val(T4.Text) * Val(T1.Text)

    End Sub
    Private Sub BTN_ADD_MOA3ED_Click(sender As Object, e As EventArgs) Handles BTN_ADD_MOA3ED.Click
        D2E2A()
        THWEL()

        MessageBox.Show("تمام")

        Dim BAR As Integer
        '======= اضافة سجل للداتا جريد ===========
        Dgv.Rows.Add()
        BAR = Dgv.Rows.Count - 1
        Dgv(0, BAR).Value = TXT_DATE.Text
        Dgv(1, BAR).Value = TXT_HDOR.Text
        Dgv(2, BAR).Value = TXT_ENSRAF.Text
        Dgv(3, BAR).Value = T4.Text
        Dgv(4, BAR).Value = Q_EDAFY.Text

        '=================================
        T4.Text = ""
        Q_EDAFY.Text = ""
        T3.Text = ""
        TXT_HDOR.Text = "00:00"
        TXT_ENSRAF.Text = "00:00"
        TXT_DATE.Text = TXT_DATE.Value.AddDays(1)
        TXT_HDOR.Select()

    End Sub

    Private Sub EDITBTN_Click(sender As Object, e As EventArgs) Handles EDITBTN.Click
    End Sub

    Private Sub TXT_NAME_EMP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_NAME_EMP.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM EMP WHERE EMP_NAME='" & TXT_NAME_EMP.Text & "'", SqlConn)
        DA.Fill(DT)

        For I = 0 To DT.Rows.Count - 1
            TXT_CODE_EMP.Text = DT.Rows(I).Item("EMP_CODE")
            TXT_HDOR_M.Text = DT.Rows(I).Item("EMP_HDOR")
            TXT_ENSRAF_M.Text = DT.Rows(I).Item("EMP_ENSRAF")
            TXT_ENSRAF_M.Text = DT.Rows(I).Item("EMP_ENSRAF")
            TXT_RATEB.Text = DT.Rows(I).Item("EMP_MORTAB")
        Next

        D2E2A()
        THWEL()

    End Sub

    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click

    End Sub
End Class