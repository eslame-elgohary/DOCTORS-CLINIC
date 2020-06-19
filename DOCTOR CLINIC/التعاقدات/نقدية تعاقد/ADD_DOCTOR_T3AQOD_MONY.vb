Public Class ADD_DOCTOR_T3AQOD_MONY
    Dim ARABIC As New ClassConvertNO
    Sub CALC()
        '==== انشاء العملية الحسابية =======
        Dim TOTAL_ As Double
        For I = 0 To DataGridView1.Rows.Count - 1
            TOTAL_ = Val(TOTAL_) + Val(DataGridView1.Rows(I).Cells(3).Value)
        Next
        TOTAL.Text = Val(TOTAL_)

        If Val(TOTAL.Text) > 0 Then
            SAFY_AR.Text = ARABIC.ConvertToArabic(TOTAL.Text)
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
    Private Sub ADD_IMAGE_Click(sender As Object, e As EventArgs) Handles ADD_IMAGE.Click
        OpenFileDialog1.Filter = "JPG|*.jpg|PNG|*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            L2020.Visible = False
        End If
    End Sub

    Private Sub ADD_DOCTOR_T3AQOD_MONY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PATIENTDATA.PATIENT' table. You can move, or remove it, as needed.
        Me.PATIENTTableAdapter.Fill(Me.PATIENTDATA.PATIENT)
        NEWBTN_Click(sender, e)
    End Sub
    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles NEWBTN.Click
        PictureBox1.Image = Nothing
        L2020.Visible = True
        '""""""""""""""" تنظيف الشاشة """""""""""""
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is ComboBox Then GroupBox1.Controls(I).Text = ""
        Next
        DataGridView1.Rows.Clear()
        TA_TKHASOS.Items.Clear()
        TXT_DOCTOR.Items.Clear()
        TXT_ACTION.Items.Clear()
        '""""""""""""""" الترقيم التلقائي """"""""""""""
        TXT_CODE.Text = CODE_GENE("ADD_MONY_DOCTOR", "ID") + 1
        '""""""""""""""""""""""""""""""
        EDITBTN.Enabled = False
        DELETBTN.Enabled = False
        SAVEBTN.Enabled = True
        TIMERADD.Enabled = True
        TIMEREDIT.Enabled = False
        FILL_KHAZINA_CODE()
        '===================================================
        PATIENTDATA.Clear()
        PATIENTTableAdapter.Fill(PATIENTDATA.PATIENT)
        PA_NAME.Text = ""
        PA_NAME.Select()
        '================================================
        CALC()
        FILL_KHAZINA()
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
    Sub FILL_PATIENT()
        PA_NAME.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE STAT='TRUE' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            PA_NAME.Items.Add(DT.Rows(I).Item("PA_NAME"))

        Next
    End Sub
    Private Sub PA_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PA_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME='" & PA_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            PA_CODE.Text = DT.Rows(I).Item("PA_CODE")
            TXT_TEL1.Text = DT.Rows(I).Item("PA_AGE")
            TXT_TEL2.Text = DT.Rows(I).Item("PA_TYPE")
        Next
    End Sub

    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click

    End Sub

    Private Sub EDITBTN_Click(sender As Object, e As EventArgs) Handles EDITBTN.Click

    End Sub

    Private Sub DELETBTN_Click(sender As Object, e As EventArgs) Handles DELETBTN.Click

    End Sub

    Private Sub SEARCHBTN_Click(sender As Object, e As EventArgs) Handles SEARCHBTN.Click

    End Sub

    Private Sub UNDOBTN_Click(sender As Object, e As EventArgs) Handles UNDOBTN.Click

    End Sub

    Private Sub PRINTBTN_Click(sender As Object, e As EventArgs) Handles PRINTBTN.Click

    End Sub

    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub
End Class