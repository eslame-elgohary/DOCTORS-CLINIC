Public Class ZIARA2020

    Private Sub BTN_TAKED_Click(sender As Object, e As EventArgs) Handles BTN_TAKED.Click
        If TXT_TKHASOS_CODE.Text = "" Then
            MessageBox.Show("يرجى أختيار العيادة")
            TXT_TKHSOS.Select()
            Exit Sub
        End If

        If TXT_DOCTOR_CODE.Text = "" Then
            MessageBox.Show("يرجى أختيار الطبيب ")
            TXT_DOCTOR.Select()
            Exit Sub
        End If
        DOC_NAME.Text = TXT_DOCTOR.Text
        DATE_NAME.Text = TXT_DATE.Text
        DOC_NAME_P3.Text = TXT_DOCTOR.Text
        DATE_NAME_P3.Text = TXT_DATE.Text
        P_HAGEZ.Visible = True

        Me.PATIENTTableAdapter.Fill(Me.PATIENTDATA.PATIENT)

        NEWBTN_Click(sender, e)

    End Sub

    Private Sub ZIARA2020_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FRIST_OPEN()
    End Sub
    Sub FRIST_OPEN()
        P_HAGEZ.Visible = False
        TXT_DATE.Value = Date.Today
        P_HAGEZ.Visible = False
        CH_DATE.Visible = True
        CH_DATE.Checked = True
        BTN_TAKED.Visible = True
        TKHASOS_FILL()
    End Sub
    Sub TKHASOS_FILL()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM TKHASOS WHERE STAT='TRUE'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_TKHSOS.Items.Add(DT.Rows(I).Item("TAKH_NAME"))
        Next
    End Sub
    Sub FILL_DOCTOR()
        TXT_DOCTOR.Text = ""
        TXT_DOCTOR_CODE.Text = ""
        TXT_DOCTOR.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORS WHERE STAT='TRUE' AND DO_TKHSOS_CODE = '" & TXT_TKHASOS_CODE.Text & "' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_DOCTOR.Items.Add(DT.Rows(I).Item("DO_NAME"))
        Next
    End Sub
    Sub ACTION_DOCTORS()
        TXT_ACTION.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORSDT WHERE DO_CODE = '" & TXT_DOCTOR_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_ACTION.Items.Add(DT.Rows(I).Item("DOT_NAME"))
        Next
    End Sub
    Sub ACTION_DOCTORS2()
        TXT_ACTION2.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORSDT WHERE DO_CODE = '" & TXT_DOCTOR_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_ACTION2.Items.Add(DT.Rows(I).Item("DOT_NAME"))
        Next
    End Sub

    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles NEWBTN.Click
        G_EDIT.Visible = False
        EDITBTN.Visible = True
        CH_TEL.Checked = True
        CH_TEL.Visible = True
        SAVEBTN.Visible = True
        BTN_CHANG.Visible = True
        BTN_TAKED.Visible = True
        P_CHANG.Visible = False
        GroupBox1.Enabled = True
        ACTION_DOCTORS()
        TRQEM_AUTO()
        '======================== تنظيف الشاشة ==============================
        PA_NAME.Text = ""
        PA_NAME.Select()
        TXT_TEL.Text = ""
        TXT_ACTION.Text = ""
        TXT_ACTION_PRIC.Text = ""
        TXT_ADRRES.Text = ""
        TXT_FILL.Text = ""
        '====================== DATAGRIDVIEW ================
        Dim ESO As String
        ESO = " SELECT        dbo.PATIENT.PA_NAME, dbo.PATIENT.PA_TEL, dbo.PATIENT.PA_CODE2, dbo.HAGEZ.ACTION, dbo.HAGEZ.DATE_HAGEZ, dbo.HAGEZ.DOCTORS_CODE, dbo.HAGEZ.TKHASOS_CODE, dbo.HAGEZ.ID, dbo.HAGEZ.ADRRES, 
                         dbo.HAGEZ.CODE_HAGEZ, dbo.HAGEZ.STAT_COLORE, dbo.HAGEZ.INFO_STAT
FROM            dbo.PATIENT INNER JOIN
                         dbo.HAGEZ ON dbo.PATIENT.PA_CODE = dbo.HAGEZ.PA_CODE 
WHERE DATE_HAGEZ='" & TXT_DATE.Text & "' AND DOCTORS_CODE='" & TXT_DOCTOR_CODE.Text & "' ORDER BY ID"
        FILL_DGV(DataGridView1, ESO)
    End Sub
    Sub TRQEM_AUTO()
        '""""""""""""""" الترقيم التلقائي """"""""""""""
        Dim DT00 As New DataTable
        Dim DA00 As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE DOCTORS_CODE = '" & TXT_DOCTOR_CODE.Text & "'  AND DATE_HAGEZ = '" & TXT_DATE.Text & "' ORDER BY ID ", SqlConn)
        DA00.Fill(DT00)
        If DT00.Rows.Count <> 0 Then
            Dim I0 = DT00.Rows.Count - 1
            TXT_CODE.Text = Val(DT00.Rows(I0).Item("CODE_HAGEZ")) + 1
        Else
            TXT_CODE.Text = "1"
        End If
    End Sub
    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        '  Me.Close()
        Me.Dispose()
    End Sub

    Private Sub TXT_TKHSOS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_TKHSOS.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM TKHASOS WHERE TAKH_NAME='" & TXT_TKHSOS.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_TKHASOS_CODE.Text = DT.Rows(I).Item("TAKH_CODE")
        Next
        FILL_DOCTOR()
        If G_EDIT.Visible = True Then
            BTN_TAKED.Visible = False
        Else
            TXT_DATE.Value = Date.Today
            P_HAGEZ.Visible = False
            CH_DATE.Visible = True
            CH_DATE.Checked = True
            BTN_TAKED.Visible = True
        End If

    End Sub
    Private Sub TXT_DOCTOR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_DOCTOR.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORS WHERE  DO_NAME='" & TXT_DOCTOR.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_DOCTOR_CODE.Text = DT.Rows(I).Item("DO_CODE")
        Next
        If G_EDIT.Visible = True Then
            TRQEM_AUTO()
            ACTION_DOCTORS2()
        End If
    End Sub

    Private Sub CH_DATE_CheckedChanged(sender As Object, e As EventArgs) Handles CH_DATE.CheckedChanged
        If CH_DATE.Checked = True Then
            TXT_DATE.Enabled = False
        Else
            TXT_DATE.Enabled = True
            CH_DATE.Visible = False
        End If

    End Sub

    Private Sub TXT_ACTION_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_ACTION.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORSDT WHERE DOT_NAME = '" & TXT_ACTION.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_ACTION_PRIC.Text = DT.Rows(I).Item("DOT_PA")
        Next
    End Sub

    Private Sub PA_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PA_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME = '" & PA_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_CODE_PA.Text = DT.Rows(I).Item("PA_CODE")
            TXT_TEL.Text = DT.Rows(I).Item("PA_TEL")
            TXT_FILL.Text = DT.Rows(I).Item("PA_CODE2")
        Next
    End Sub

    Private Sub CH_TEL_CheckedChanged(sender As Object, e As EventArgs) Handles CH_TEL.CheckedChanged
        If CH_TEL.Checked = True Then
            TXT_TEL.Enabled = False
            TXT_TEL.BackColor = Color.White
        Else
            TXT_TEL.Enabled = True
            TXT_TEL.BackColor = Color.Aqua
            CH_TEL.Visible = False
        End If
    End Sub

    Private Sub BTN_CHANG_Click(sender As Object, e As EventArgs) Handles BTN_CHANG.Click
        '=====================================================================
        PA_NAME.Text = ""
        TXT_TEL.Text = ""
        TXT_ACTION.Text = ""
        TXT_ACTION_PRIC.Text = ""
        TXT_ADRRES.Text = ""
        TXT_FILL.Text = ""
        '============================================================
        EDITBTN.Visible = False
        GroupBox1.Enabled = False
        P_CHANG.Visible = True
        BTN_CHANG.Visible = False
        SAVEBTN.Visible = False
        HAGEZ_FILL()
    End Sub

    Sub HAGEZ_FILL()
        HAGEZ1.Items.Clear()
        HAGEZ2.Items.Clear()
        Dim F As String
        F = "SELECT       dbo.HAGEZ.ID, dbo.HAGEZ.CODE_HAGEZ, dbo.HAGEZ.PA_CODE, dbo.PATIENT.PA_NAME, dbo.HAGEZ.TKHASOS_CODE, dbo.HAGEZ.DOCTORS_CODE, dbo.HAGEZ.DATE_HAGEZ
FROM            dbo.HAGEZ INNER JOIN
                         dbo.PATIENT ON dbo.HAGEZ.PA_CODE = dbo.PATIENT.PA_CODE
WHERE DATE_HAGEZ='" & TXT_DATE.Text & "' AND DOCTORS_CODE='" & TXT_DOCTOR_CODE.Text & "' ORDER BY ID"

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(F, SqlConn)
        DA.Fill(DT)

        For I = 0 To DT.Rows.Count - 1
            HAGEZ1.Items.Add(DT.Rows(I).Item("CODE_HAGEZ"))
            HAGEZ2.Items.Add(DT.Rows(I).Item("CODE_HAGEZ"))
        Next
    End Sub

    Private Sub EDITBTN_Click(sender As Object, e As EventArgs) Handles EDITBTN.Click
        '=====================================================================
        PA_NAME.Text = ""
        TXT_TEL.Text = ""
        TXT_ACTION.Text = ""
        TXT_ACTION_PRIC.Text = ""
        TXT_ADRRES.Text = ""
        TXT_FILL.Text = ""
        '============================================================
        BTN_CHANG.Visible = False
        G_EDIT.Visible = True
        EDITBTN.Visible = False
        CH_TEL2.Checked = True
        CH_TEL2.Visible = True
        GroupBox1.Enabled = False
        SAVEBTN.Visible = False
        ACTION_DOCTORS2()

        '======================== تنظيف الشاشة ==============================
        PA_NAME2.Text = ""
        PA_NAME2.Select()
        TXT_TEL2.Text = ""
        TXT_ACTION2.Text = ""
        TXT_ACTION_PRIC2.Text = ""
        TXT_ADRRES2.Text = ""
        TXT_FILL2.Text = ""
        TXT_ID.Text = ""
        TXT_CODE2.Text = ""
        PATINT_FILL()
    End Sub
    Sub PATINT_FILL()
        PA_NAME2.Items.Clear()

        Dim F As String
        F = "SELECT        dbo.HAGEZ.PA_CODE, dbo.HAGEZ.ID, dbo.PATIENT.PA_NAME, dbo.HAGEZ.TKHASOS_CODE, dbo.HAGEZ.DOCTORS_CODE, dbo.HAGEZ.DATE_HAGEZ
FROM            dbo.HAGEZ INNER JOIN
                         dbo.PATIENT ON dbo.HAGEZ.PA_CODE = dbo.PATIENT.PA_CODE
WHERE DATE_HAGEZ='" & TXT_DATE.Text & "' AND DOCTORS_CODE='" & TXT_DOCTOR_CODE.Text & "' "

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(F, SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            PA_NAME2.Items.Add(DT.Rows(I).Item("PA_NAME"))
        Next
    End Sub

    Private Sub TXT_ACTION2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_ACTION2.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORSDT WHERE DOT_NAME = '" & TXT_ACTION2.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_ACTION_PRIC2.Text = DT.Rows(I).Item("DOT_PA")
        Next
    End Sub

    Private Sub CH_TEL2_CheckedChanged(sender As Object, e As EventArgs) Handles CH_TEL2.CheckedChanged
        If CH_TEL2.Checked = True Then
            TXT_TEL2.Enabled = False
            TXT_TEL2.BackColor = Color.White
        Else
            TXT_TEL2.Enabled = True
            TXT_TEL2.BackColor = Color.Aqua
            CH_TEL2.Visible = False
        End If
    End Sub

    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click
        If TXT_CODE_PA.Text = "" Then
            MessageBox.Show("يرجى أختيار أسم المريض ")
            PA_NAME.Select()
            Exit Sub
        End If

        If TXT_ACTION_PRIC.Text = "" Then
            MessageBox.Show("يرجى أختيار الأجراء المطلوب ")
            TXT_ACTION.Select()
            Exit Sub
        End If
        TRQEM_AUTO()

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.NewRow
        DR!TKHASOS_CODE = TXT_TKHASOS_CODE.Text
        DR!DOCTORS_CODE = TXT_DOCTOR_CODE.Text
        DR!DATE_HAGEZ = TXT_DATE.Text
        DR!PA_CODE = TXT_CODE_PA.Text
        DR!ACTION = TXT_ACTION.Text
        DR!PRICE_ACTION = TXT_ACTION_PRIC.Text
        DR!ADRRES = TXT_ADRRES.Text
        DR!CODE_HAGEZ = TXT_CODE.Text
        DR!ADD_USER = HOME.T_USERS.Text
        DR!DATE_ADD_USER = Date.Now
        DR!STAT_COLORE = "0"
        DR!INFO_STAT = " "
        DT.Rows.Add(DR)
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("تمت عملية حفظ بيانات الحجز بنجاح ورقم الحجز هو " & ">>>> " & TXT_CODE.Text, "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        NEWBTN_Click(sender, e)
    End Sub

    Private Sub PA_NAME2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PA_NAME2.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME = '" & PA_NAME2.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_CODE_PA2.Text = DT.Rows(I).Item("PA_CODE")
            TXT_TEL2.Text = DT.Rows(I).Item("PA_TEL")
            TXT_FILL2.Text = DT.Rows(I).Item("PA_CODE2")
        Next
        Dim DT1 As New DataTable
        Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE PA_CODE ='" & TXT_CODE_PA2.Text & "' AND DATE_HAGEZ='" & TXT_DATE.Text & "' AND DOCTORS_CODE='" & TXT_DOCTOR_CODE.Text & "' ", SqlConn)
        DA1.Fill(DT1)

        For I1 = 0 To DT1.Rows.Count - 1
            TXT_ADRRES2.Text = DT1.Rows(I1).Item("ADRRES")
            TXT_ID.Text = DT1.Rows(I1).Item("ID")
            TXT_CODE2.Text = DT1.Rows(I1).Item("CODE_HAGEZ")
            TXT_ACTION2.Text = DT1.Rows(I1).Item("ACTION")
        Next
    End Sub

    Private Sub G_EDITBTN_Click(sender As Object, e As EventArgs) Handles G_EDITBTN.Click
        If TXT_CODE_PA2.Text = "" Then
            MessageBox.Show("يرجى أختيار أسم المريض ")
            PA_NAME2.Select()
            Exit Sub
        End If

        If TXT_ACTION_PRIC2.Text = "" Then
            MessageBox.Show("يرجى أختيار الأجراء المطلوب ")
            TXT_ACTION2.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID.Text & "'", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.Rows(0)
        DR!TKHASOS_CODE = TXT_TKHASOS_CODE.Text
        DR!DOCTORS_CODE = TXT_DOCTOR_CODE.Text
        DR!DATE_HAGEZ = TXT_DATE.Text
        DR!PA_CODE = TXT_CODE_PA2.Text
        DR!ACTION = TXT_ACTION2.Text
        DR!PRICE_ACTION = TXT_ACTION_PRIC2.Text
        DR!ADRRES = TXT_ADRRES2.Text
        DR!CODE_HAGEZ = TXT_CODE2.Text
        DR!EDIT_USER = HOME.T_USERS.Text
        DR!DATE_EDIT_USER = Date.Now

        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        MessageBox.Show("تمت عملية تعديل بيانات الحجز بنجاح لرقم الحجز  " & ">>>> " & TXT_CODE2.Text, "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '==================== تنظيف الشاشة =================================
        PA_NAME2.Text = ""
        TXT_TEL2.Text = ""
        TXT_ACTION2.Text = ""
        TXT_ACTION_PRIC2.Text = ""
        TXT_ADRRES2.Text = ""
        TXT_FILL2.Text = ""
        TXT_ID.Text = ""
        TXT_CODE2.Text = ""
        NEWBTN_Click(sender, e)
    End Sub

    Private Sub HAGEZ1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles HAGEZ1.SelectedIndexChanged
        Dim F As String
        F = "SELECT        dbo.HAGEZ.CODE_HAGEZ, dbo.HAGEZ.ID, dbo.HAGEZ.PA_CODE, dbo.PATIENT.PA_NAME, dbo.PATIENT.PA_CODE AS Expr1, dbo.HAGEZ.TKHASOS_CODE, dbo.HAGEZ.DOCTORS_CODE, dbo.HAGEZ.DATE_HAGEZ, 
                         dbo.HAGEZ.ACTION, dbo.HAGEZ.PRICE_ACTION, dbo.HAGEZ.ADRRES, dbo.HAGEZ.STAT_COLORE, dbo.HAGEZ.INFO_STAT
FROM            dbo.HAGEZ INNER JOIN
                         dbo.PATIENT ON dbo.HAGEZ.PA_CODE = dbo.PATIENT.PA_CODE
WHERE DATE_HAGEZ='" & TXT_DATE.Text & "' AND DOCTORS_CODE='" & TXT_DOCTOR_CODE.Text & "' AND CODE_HAGEZ='" & HAGEZ1.Text & "' "

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(F, SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_NAME1.Text = DT.Rows(I).Item("PA_NAME")
            TXT_HAGEZ1_ID.Text = DT.Rows(I).Item("ID")
            TXT_NAME1_CODE.Text = DT.Rows(I).Item("PA_CODE")
            TXT_NAME1_ACTION.Text = DT.Rows(I).Item("ACTION")
            TXT_NAME1_PRICE.Text = DT.Rows(I).Item("PRICE_ACTION")
            TXT_NAME1_ADRRES.Text = DT.Rows(I).Item("ADRRES")
            TXT_NAME1_COLOR.Text = DT.Rows(I).Item("STAT_COLORE")
            TXT_NAME1_INFO.Text = DT.Rows(I).Item("INFO_STAT")
        Next
    End Sub

    Private Sub HAGEZ2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles HAGEZ2.SelectedIndexChanged
        Dim F As String
        F = "SELECT        dbo.HAGEZ.CODE_HAGEZ, dbo.HAGEZ.ID, dbo.HAGEZ.PA_CODE, dbo.PATIENT.PA_NAME, dbo.PATIENT.PA_CODE AS Expr1, dbo.HAGEZ.TKHASOS_CODE, dbo.HAGEZ.DOCTORS_CODE, dbo.HAGEZ.DATE_HAGEZ, 
                         dbo.HAGEZ.ACTION, dbo.HAGEZ.PRICE_ACTION, dbo.HAGEZ.ADRRES, dbo.HAGEZ.STAT_COLORE, dbo.HAGEZ.INFO_STAT
FROM            dbo.HAGEZ INNER JOIN
                         dbo.PATIENT ON dbo.HAGEZ.PA_CODE = dbo.PATIENT.PA_CODE
WHERE DATE_HAGEZ='" & TXT_DATE.Text & "' AND DOCTORS_CODE='" & TXT_DOCTOR_CODE.Text & "' AND CODE_HAGEZ='" & HAGEZ2.Text & "' "

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(F, SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_NAME2.Text = DT.Rows(I).Item("PA_NAME")
            TXT_HAGEZ2_ID.Text = DT.Rows(I).Item("ID")
            TXT_NAME2_CODE.Text = DT.Rows(I).Item("PA_CODE")
            TXT_NAME2_ACTION.Text = DT.Rows(I).Item("ACTION")
            TXT_NAME2_PRICE.Text = DT.Rows(I).Item("PRICE_ACTION")
            TXT_NAME2_ADRRES.Text = DT.Rows(I).Item("ADRRES")
            TXT_NAME2_COLOR.Text = DT.Rows(I).Item("STAT_COLORE")
            TXT_NAME2_INFO.Text = DT.Rows(I).Item("INFO_STAT")
        Next
    End Sub

    Private Sub BTN_XCHANG_Click(sender As Object, e As EventArgs) Handles BTN_XCHANG.Click

        If TXT_HAGEZ1_ID.Text = "" Then
            MessageBox.Show("يرجى أختيار أسم المريض ")
            HAGEZ1.Select()
            Exit Sub
        End If

        If TXT_HAGEZ2_ID.Text = "" Then
            MessageBox.Show("يرجى أختيار أسم المريض ")
            HAGEZ2.Select()
            Exit Sub
        End If

        '====================================تعديل الاسم الأول ========================
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID='" & TXT_HAGEZ1_ID.Text & "'", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.Rows(0)
        DR!PA_CODE = TXT_NAME2_CODE.Text
        DR!ACTION = TXT_NAME2_ACTION.Text
        DR!PRICE_ACTION = TXT_NAME2_PRICE.Text
        DR!ADRRES = TXT_NAME2_ADRRES.Text
        DR!STAT_COLORE = TXT_NAME2_COLOR.Text
        DR!INFO_STAT = TXT_NAME2_INFO.Text
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        '============================ تعديل الاسم الثاني ========================
        Dim DT1 As New DataTable
        Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID='" & TXT_HAGEZ2_ID.Text & "'", SqlConn)
        DA1.Fill(DT1)
        Dim DR1 = DT1.Rows(0)
        DR1!PA_CODE = TXT_NAME1_CODE.Text
        DR1!ACTION = TXT_NAME1_ACTION.Text
        DR1!PRICE_ACTION = TXT_NAME1_PRICE.Text
        DR1!ADRRES = TXT_NAME1_ADRRES.Text
        DR1!STAT_COLORE = TXT_NAME1_COLOR.Text
        DR1!INFO_STAT = TXT_NAME1_INFO.Text
        Dim SAVE1 As New SqlClient.SqlCommandBuilder(DA1)
        DA1.Update(DT1)

        MessageBox.Show("تمت عملية التبديل بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '============================ تنظيف الشاشة ===============================
        HAGEZ2.Text = ""
        TXT_NAME2.Text = ""
        TXT_HAGEZ2_ID.Text = ""
        TXT_NAME2_CODE.Text = ""
        TXT_NAME2_ACTION.Text = ""
        TXT_NAME2_PRICE.Text = ""
        TXT_NAME2_ADRRES.Text = ""
        TXT_NAME2_COLOR.Text = ""
        TXT_NAME2_INFO.Text = ""

        HAGEZ1.Text = ""
        TXT_NAME1.Text = ""
        TXT_HAGEZ1_ID.Text = ""
        TXT_NAME1_CODE.Text = ""
        TXT_NAME1_ACTION.Text = ""
        TXT_NAME1_PRICE.Text = ""
        TXT_NAME1_ADRRES.Text = ""
        TXT_NAME1_COLOR.Text = ""
        TXT_NAME1_INFO.Text = ""

        NEWBTN_Click(sender, e)

    End Sub

    Private Sub ADD_PA_Click(sender As Object, e As EventArgs) Handles ADD_PA.Click
        PATIENT.ShowDialog()
    End Sub

    Private Sub REFRESH_BTN_Click(sender As Object, e As EventArgs) Handles REFRESH_BTN.Click
        '====================== DATAGRIDVIEW ================
        Dim ESO As String
        ESO = " SELECT        dbo.PATIENT.PA_NAME, dbo.PATIENT.PA_TEL, dbo.PATIENT.PA_CODE2, dbo.HAGEZ.ACTION, dbo.HAGEZ.DATE_HAGEZ, dbo.HAGEZ.DOCTORS_CODE, dbo.HAGEZ.TKHASOS_CODE, dbo.HAGEZ.ID, dbo.HAGEZ.ADRRES, 
                         dbo.HAGEZ.CODE_HAGEZ, dbo.HAGEZ.STAT_COLORE, dbo.HAGEZ.INFO_STAT
FROM            dbo.PATIENT INNER JOIN
                         dbo.HAGEZ ON dbo.PATIENT.PA_CODE = dbo.HAGEZ.PA_CODE 
WHERE DATE_HAGEZ='" & TXT_DATE.Text & "' AND DOCTORS_CODE='" & TXT_DOCTOR_CODE.Text & "' ORDER BY ID"
        FILL_DGV(DataGridView1, ESO)

        For Each r As DataGridViewRow In DataGridView1.Rows
            Select Case r.Cells.Item(7).Value
                Case "1" 'المريض حضر
                    r.Cells.Item(1).Style.BackColor = P_M.BackColor
                Case "2" ' تم الكشف
                    r.DefaultCellStyle.BackColor = P_END.BackColor
                Case "3" 'مجانا 
                    r.DefaultCellStyle.BackColor = P_FREE.BackColor
                Case "4" ' المريض طلب التأجيل
                    r.DefaultCellStyle.BackColor = P_TAGEL.BackColor
                Case "5" ' الألغاء
                    r.DefaultCellStyle.BackColor = P_DELET.BackColor
                Case "0" ' لم يحضر
                    r.Cells.Item(1).Style.BackColor = P_NOTCOME.BackColor
                    r.Cells.Item(2).Style.BackColor = P_NOTCOME.BackColor
                    r.Cells.Item(3).Style.BackColor = P_NOTCOME.BackColor
                    r.Cells.Item(4).Style.BackColor = P_NOTCOME.BackColor
                    r.Cells.Item(5).Style.BackColor = P_NOTCOME.BackColor
                Case Else

            End Select

            Select Case r.Cells.Item(6).Value
                Case " "
                    ' الاتصال
                    r.Cells.Item(6).Style.BackColor = P_NOTCOME.BackColor
                Case Else
                    r.Cells.Item(6).Style.BackColor = P_CALL.BackColor
            End Select
        Next

        DataGridView1_Click(sender, e)
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            For Each r As DataGridViewRow In DataGridView1.SelectedRows
                TXT_ID_H.Text = r.Cells.Item(0).Value
                TXT_NUM_H.Text = r.Cells.Item(1).Value
                TXT_INFO_H_DATAGRID.Text = r.Cells.Item(6).Value
            Next
        Else
            TXT_ID_H.Text = ""
            TXT_NUM_H.Text = ""
            TXT_INFO_H_DATAGRID.Text = ""
        End If
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click
        If TXT_ID_H.Text = "" Then
            MessageBox.Show("يرجى أختيار المريض  من الجدول بالأسفل", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            If DataGridView1.SelectedRows.Count > 0 Then
                If MessageBox.Show("هل أنت متأكد أن المريض رقم " & TXT_NUM_H.Text & " حضر ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub

                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID_H.Text & "'", SqlConn)
                Dim DT As New DataTable
                DA.Fill(DT)
                Dim DR = DT.Rows(0)
                DR!STAT_COLORE = "1"

                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)

                REFRESH_BTN_Click(sender, e)

            End If
        End If
    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click
        If TXT_ID_H.Text = "" Then
            MessageBox.Show("يرجى أختيار المريض  من الجدول بالأسفل", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            If DataGridView1.SelectedRows.Count > 0 Then
                If MessageBox.Show("هل أنت متأكد أن المريض رقم " & TXT_NUM_H.Text & " يرغب فى التأجيل ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub

                'For Each r As DataGridViewRow In DataGridView1.SelectedRows
                '    r.DefaultCellStyle.BackColor = P_TAGEL.BackColor
                'Next
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID_H.Text & "'", SqlConn)
                Dim DT As New DataTable
                DA.Fill(DT)
                Dim DR = DT.Rows(0)
                DR!STAT_COLORE = "4"

                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                REFRESH_BTN_Click(sender, e)

            End If
        End If
    End Sub

    Private Sub REFRESH_BTN_P3_Click(sender As Object, e As EventArgs) Handles REFRESH_BTN_P3.Click
        Dim KARMA As String
        KARMA = "SELECT        TOP (100) PERCENT TKHASOS_CODE, DOCTORS_CODE, DATE_HAGEZ, COUNT(ACTION) AS COUNT_ACTION, ACTION, STAT_COLORE
        FROM            dbo.HAGEZ
        GROUP BY TKHASOS_CODE, DOCTORS_CODE, DATE_HAGEZ, ACTION, STAT_COLORE
        HAVING        (NOT (ACTION IS NULL)) AND (DOCTORS_CODE = '" & TXT_DOCTOR_CODE.Text & "') AND (DATE_HAGEZ = '" & TXT_DATE.Text & "') AND (STAT_COLORE = '2')"

        FILL_DGV(DG2, KARMA)

        Dim KARMA3 As String
        KARMA3 = "SELECT        TOP (100) PERCENT dbo.HAGEZ.DOCTORS_CODE, dbo.HAGEZ.DATE_HAGEZ, COUNT(dbo.HAGEZ.STAT_COLORE) AS COLOR, dbo.HAGEZ.STAT_COLORE, dbo.HAGEZ_COLOR.NAME
FROM            dbo.HAGEZ INNER JOIN
                         dbo.HAGEZ_COLOR ON dbo.HAGEZ.STAT_COLORE = dbo.HAGEZ_COLOR.COLOR
GROUP BY dbo.HAGEZ.DOCTORS_CODE, dbo.HAGEZ.DATE_HAGEZ, dbo.HAGEZ.STAT_COLORE, dbo.HAGEZ_COLOR.NAME
HAVING        (NOT (COUNT(dbo.HAGEZ.STAT_COLORE) IS NULL)) AND (dbo.HAGEZ.DATE_HAGEZ = '" & TXT_DATE.Text & "') AND (dbo.HAGEZ.DOCTORS_CODE = '" & TXT_DOCTOR_CODE.Text & "')"
        FILL_DGV(DG3, KARMA3)
    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
        If TXT_ID_H.Text = "" Then
            MessageBox.Show("يرجى أختيار المريض  من الجدول بالأسفل", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            If DataGridView1.SelectedRows.Count > 0 Then
                If MessageBox.Show("هل أنت متأكد أن المريض رقم " & TXT_NUM_H.Text & " مجانا ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub

                'For Each r As DataGridViewRow In DataGridView1.SelectedRows
                '    r.DefaultCellStyle.BackColor = P_FREE.BackColor
                'Next
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID_H.Text & "'", SqlConn)
                Dim DT As New DataTable
                DA.Fill(DT)
                Dim DR = DT.Rows(0)
                DR!STAT_COLORE = "3"

                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                REFRESH_BTN_Click(sender, e)

            End If
        End If
    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click
        If TXT_ID_H.Text = "" Then
            MessageBox.Show("يرجى أختيار المريض  من الجدول بالأسفل", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            If DataGridView1.SelectedRows.Count > 0 Then
                If MessageBox.Show("هل أنت متأكد أن المريض رقم " & TXT_NUM_H.Text & " يرغب فى الألغاء ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub

                'For Each r As DataGridViewRow In DataGridView1.SelectedRows
                '    r.DefaultCellStyle.BackColor = P_DELET.BackColor
                'Next
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID_H.Text & "'", SqlConn)
                Dim DT As New DataTable
                DA.Fill(DT)
                Dim DR = DT.Rows(0)
                DR!STAT_COLORE = "5"

                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                REFRESH_BTN_Click(sender, e)

            End If
        End If
    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click
        If TXT_ID_H.Text = "" Then
            MessageBox.Show("يرجى أختيار المريض  من الجدول بالأسفل", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            If DataGridView1.SelectedRows.Count > 0 Then
                If MessageBox.Show("هل أنت متأكد أن المريض رقم " & TXT_NUM_H.Text & " لم يحضر الى العيادة ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub

                'For Each r As DataGridViewRow In DataGridView1.SelectedRows
                '    r.DefaultCellStyle.BackColor = P_NOTCOME.BackColor
                'Next
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID_H.Text & "'", SqlConn)
                Dim DT As New DataTable
                DA.Fill(DT)
                Dim DR = DT.Rows(0)
                DR!STAT_COLORE = "0"

                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                REFRESH_BTN_Click(sender, e)

            End If
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        If TXT_ID_H.Text = "" Then
            MessageBox.Show("يرجى أختيار المريض  من الجدول بالأسفل", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            If DataGridView1.SelectedRows.Count > 0 Then
                If MessageBox.Show("هل أنت متأكد أن المريض رقم " & TXT_NUM_H.Text & " تم الأتصال به الأن ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub

                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID_H.Text & "'", SqlConn)
                Dim DT As New DataTable
                DA.Fill(DT)
                Dim DR = DT.Rows(0)
                DR!INFO_STAT = TXT_INFO_H_DATAGRID.Text & " , " & Date.Now
                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                REFRESH_BTN_Click(sender, e)

            End If
        End If
    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click
        If TXT_ID_H.Text = "" Then
            MessageBox.Show("يرجى أختيار المريض  من الجدول بالأسفل", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            If DataGridView1.SelectedRows.Count > 0 Then
                If MessageBox.Show("هل أنت متأكد أن المريض رقم " & TXT_NUM_H.Text & " سيقوم بالدفع ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub

                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID_H.Text & "'", SqlConn)
                Dim DT As New DataTable
                DA.Fill(DT)
                Dim DR = DT.Rows(0)
                DR!STAT_COLORE = "2"

                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                REFRESH_BTN_Click(sender, e)
            End If
        End If
        If MessageBox.Show("هل ترغب في فتح أيصال استلام النقدية للمريض رقم  " & TXT_NUM_H.Text, "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub

        Try
            ROLES("M", ADD_MONY_DOCTOR)
        Catch EX As Exception

        End Try
    End Sub
End Class