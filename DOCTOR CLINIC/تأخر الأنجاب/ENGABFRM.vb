Public Class ENGABFRM
    Sub SHOW_DETA(CODE_)
        DataGridView3.Rows.Clear()
        '=========== ربط رأس الفاتورة =============
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM INFERTILITY_FOLLOWUP WHERE CODE_INFER_FOLLOW ='" & CODE_ & "'", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("يرجى التأكد من كود المريض", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!CODE_INFER_FOLLOW
            TXT_PA_CODE.Text = DR!CODE_PA_PERSONAL_INFERTILITY
            TXT_DATE_VISIT.Value = DR!DATE_VISET_INFERTILITY
            TXT_DATE_VISIT1.Value = DR!DATE_VISET_INFERTILITY
            TXT_DATE_LMP.Value = DR!DATE_LMP_INFERTILITY
            TXT_DATE_LMP1.Value = DR!DATE_LMP_INFERTILITY
            TXT_ULTRASOUND.Text = DR!ULTRA_SOUND_INFERTILITY
            TXT_ULTRASOUND2.Text = DR!ULTRA_SOUND_INFERTILITY
            TXT_RECOMMENDATION.Text = DR!RECOMMENDATION_INFERTILITY
            TXT_RECOMMENDATION2.Text = DR!RECOMMENDATION_INFERTILITY

            '=========== ربط تفاصيل الفاتورة =============
            Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM R_DOC_V_ENGAB WHERE R_STAT ='TRUE' AND R_DATE ='" & TXT_DATE_VISIT.Text & "' AND R_CODE_PA = '" & TXT_PA_CODE.Text & "' AND R_CODE_FOLOWUP = 'ENGAB' ", SqlConn)
            Dim DT1 As New DataTable
            DA1.Fill(DT1)
            If DT1.Rows.Count > 0 Then
                T_Change.Enabled = False
                For I1 = 0 To DT1.Rows.Count - 1
                    TXT_CODE100.Text = DT1.Rows(I1).Item("R_CODE")
                    DataGridView3.Rows.Add()
                    DataGridView3.Rows(I1).Cells(0).Value = DT1.Rows(I1).Item("R_DT_CODE")
                    DataGridView3.Rows(I1).Cells(1).Value = DT1.Rows(I1).Item("R_DT_PHARM")
                    DataGridView3.Rows(I1).Cells(2).Value = DT1.Rows(I1).Item("R_DT_NO3")
                    DataGridView3.Rows(I1).Cells(3).Value = DT1.Rows(I1).Item("R_DT_GOR3A")
                    DataGridView3.Rows(I1).Cells(4).Value = DT1.Rows(I1).Item("R_DT_CODE2")
                Next
            Else
                TXT_CODE100.Text = CODE_GENE("R_DOCTOR", "ID") + 1
            End If
        End If
        DELETBTN.Enabled = True
        EDITBTN.Enabled = True
        SAVEBTN.Enabled = False


    End Sub
    Sub CALCDATE()
        Dim DATEDAY As Date
        Dim DATELAST As Date
        Dim FDATE As Integer

        DATEDAY = TXT_DATE_VISIT.Value
        DATELAST = TXT_DATE_LMP.Value
        FDATE = DateDiff(DateInterval.Day, DATELAST, DATEDAY)
        TXT_FDATE.Text = "DAY : " & FDATE
    End Sub
    Sub CALCDATE1()
        Dim DATEDAY As Date
        Dim DATELAST As Date
        Dim FDATE As Integer

        DATEDAY = TXT_DATE_VISIT1.Value
        DATELAST = TXT_DATE_LMP1.Value
        FDATE = DateDiff(DateInterval.Day, DATELAST, DATEDAY)
        TXT_FDATE1.Text = "DAY : " & FDATE
    End Sub

    Private Sub TXT_DATE_VISITNEW_ValueChanged(sender As Object, e As EventArgs) Handles TXT_DATE_VISIT.ValueChanged
        CALCDATE()
    End Sub

    Private Sub TXT_DATE_VISITLAST_ValueChanged(sender As Object, e As EventArgs) Handles TXT_DATE_LMP.ValueChanged
        CALCDATE()
    End Sub

    Private Sub ENGABFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEWBTN_Click(sender, e)
    End Sub

    Private Sub TXT_DATE_VISITNEW1_ValueChanged(sender As Object, e As EventArgs) Handles TXT_DATE_VISIT1.ValueChanged
        CALCDATE1()
    End Sub

    Private Sub TXT_DATE_VISITLAST1_ValueChanged(sender As Object, e As EventArgs) Handles TXT_DATE_LMP1.ValueChanged
        CALCDATE1()
    End Sub
    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles NEWBTN.Click
        TXT_CODE.Text = CODE_GENE("INFERTILITY_FOLLOWUP", "ID") + 1

        TXT_PA_CODE.Text = ""
        TXT_PA_NAME.Text = ""
        TXT_NAME2.Text = ""
        TXT_AGE.Text = ""
        TXT_AGE2.Text = ""
        TXT_INFO.Text = ""
        TXT_COMPLEAN.Text = ""
        TXT_DATE_MARRIED.Value = Date.Today
        T_Change.Enabled = True
        '====================================================

        TXT_DATE_VISIT.Text = Date.Today
        TXT_DATE_LMP.Text = Date.Today
        TXT_DATE_VISIT1.Text = Date.Today
        TXT_DATE_LMP1.Text = Date.Today
        EDITBTN.Enabled = False
        DELETBTN.Enabled = False
        SAVEBTN.Enabled = True
        FILL_PATION()
        FILL_PHARM()
        TXT_PA_NAME.Select()
        '""""""""""""""" تنظيف الشاشة الأدوية """""""""""""
        For I = 0 To GroupBox21.Controls.Count - 1
            If TypeOf GroupBox21.Controls(I) Is TextBox Then GroupBox21.Controls(I).Text = ""
        Next
        For I = 0 To GroupBox21.Controls.Count - 1
            If TypeOf GroupBox21.Controls(I) Is ComboBox Then GroupBox21.Controls(I).Text = ""
        Next
        TXT_RECOMMENDATION.Text = ""
        TXT_ULTRASOUND.Text = ""
        DataGridView3.Rows.Clear()


    End Sub
    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click
        If TXT_DATE_VISIT.Value = TXT_DATE_LMP.Value Then
            MessageBox.Show("PLEAS INSERT THE DATE L.M.P ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_DATE_LMP.Select()
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM INFERTILITY_FOLLOWUP", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.NewRow
        DR!CODE_INFER_FOLLOW = TXT_CODE.Text
        DR!CODE_PA_PERSONAL_INFERTILITY = TXT_PA_CODE.Text
        DR!DATE_VISET_INFERTILITY = TXT_DATE_VISIT.Text
        DR!DATE_LMP_INFERTILITY = TXT_DATE_LMP.Text
        DR!ULTRA_SOUND_INFERTILITY = TXT_ULTRASOUND.Text
        DR!RECOMMENDATION_INFERTILITY = TXT_RECOMMENDATION.Text
        DR!STAT_INFERTILITY = True
        DT.Rows.Add(DR)
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)

        Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM R_DOCTOR", SqlConn)
        DA2.Fill(DT)
        If DataGridView3.Rows.Count > 0 Then

            Dim DR2 = DT.NewRow
            DR2!R_CODE = TXT_CODE100.Text
            DR2!R_CODE_FOLOWUP = "ENGAB"
            DR2!R_DATE = TXT_DATE_VISIT.Text
            DR2!R_CODE_DOC = "1"
            DR2!R_CODE_PA = TXT_PA_CODE.Text
            DR2!R_HRARA = "0"
            DR2!R_D = "0"
            DR2!R_KG = "0"
            DR2!R_INFO = "متابعة أنجاب"
            DR2!R_STAT = True
            DR2!USER_ADD = "0"
            DR2!DATE_ADD = "0"
            DR2!TIME_ADD = "0"
            DR2!USER_EDIT = "0"
            DR2!DATE_EDIT = "0"
            DR2!TIME_EDIT = "0"

            DT.Rows.Add(DR2)
            Dim CMD_ As New SqlClient.SqlCommandBuilder(DA2)
            DA2.Update(DT)

            Dim DA3 As New SqlClient.SqlDataAdapter("SELECT * FROM R_DOCTOR_DT", SqlConn)
            DA3.Fill(DT)
            For I = 0 To DataGridView3.Rows.Count - 1
                Dim DR3 = DT.NewRow
                DR3!R_CODE_DT = TXT_CODE100.Text
                DR3!R_DATE = TXT_DATE_VISIT.Text
                DR3!R_DT_CODE = DataGridView3.Rows(I).Cells(0).Value
                DR3!R_DT_PHARM = DataGridView3.Rows(I).Cells(1).Value
                DR3!R_DT_NO3 = DataGridView3.Rows(I).Cells(2).Value
                DR3!R_DT_CODE2 = DataGridView3.Rows(I).Cells(3).Value
                DR3!R_DT_GOR3A = DataGridView3.Rows(I).Cells(4).Value
                DR3!STAT_DT = True
                DT.Rows.Add(DR3)
                Dim CMD1_ As New SqlClient.SqlCommandBuilder(DA3)
                DA3.Update(DT)
            Next
        End If



        MessageBox.Show("تمت عملية الحفظ بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        NEWBTN_Click(sender, e)

    End Sub

    Private Sub EDITBTN_Click(sender As Object, e As EventArgs) Handles EDITBTN.Click
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM INFERTILITY_FOLLOWUP WHERE CODE_INFER_FOLLOW = '" & TXT_CODE.Text & "' ", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.Rows(0)
        DR!CODE_INFER_FOLLOW = TXT_CODE.Text
        DR!CODE_PA_PERSONAL_INFERTILITY = TXT_PA_CODE.Text
        DR!DATE_VISET_INFERTILITY = TXT_DATE_VISIT.Text
        DR!DATE_LMP_INFERTILITY = TXT_DATE_LMP.Text
        DR!ULTRA_SOUND_INFERTILITY = TXT_ULTRASOUND.Text
        DR!RECOMMENDATION_INFERTILITY = TXT_RECOMMENDATION.Text
        DR!STAT_INFERTILITY = True
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        '===================================================================================
        Dim DT2 As New DataTable
        Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM R_DOCTOR WHERE R_CODE = '" & TXT_CODE100.Text & "'", SqlConn)
        DA2.Fill(DT2)
        Dim DR2 = DT2.Rows(0)
        DR2!R_CODE = TXT_CODE100.Text
        DR2!R_CODE_FOLOWUP = "ENGAB"
        DR2!R_DATE = TXT_DATE_VISIT.Text
        DR2!R_CODE_DOC = "1"
        DR2!R_CODE_PA = TXT_PA_CODE.Text
        DR2!R_HRARA = "20"
        DR2!R_D = "0"
        DR2!R_KG = "0"
        DR2!R_INFO = "متابعة أنجاب"
        DR2!R_STAT = True
        DR2!USER_ADD = "0"
        DR2!DATE_ADD = "0"
        DR2!TIME_ADD = "0"
        DR2!USER_EDIT = "0"
        DR2!DATE_EDIT = "0"
        DR2!TIME_EDIT = "0"
        Dim CMD_ As New SqlClient.SqlCommandBuilder(DA2)
        DA2.Update(DT)
        '===========================DELET DETILS========================
        Dim CMD_DEL As New SqlClient.SqlCommand
        CMD_DEL.Connection = SqlConn
        CMD_DEL.CommandText = "DELETE FROM R_DOCTOR_DT WHERE R_CODE_DT ='" & TXT_CODE100.Text & "'"
        CMD_DEL.ExecuteNonQuery()
        '===============================================================
        Dim DT3 As New DataTable
        Dim DA3 As New SqlClient.SqlDataAdapter("SELECT * FROM R_DOCTOR_DT", SqlConn)
        DA3.Fill(DT3)
        For I = 0 To DataGridView3.Rows.Count - 1
            Dim DR3 = DT3.NewRow
            DR3!R_CODE_DT = TXT_CODE100.Text
            DR3!R_DATE = TXT_DATE_VISIT.Text
            DR3!R_DT_CODE = DataGridView3.Rows(I).Cells(0).Value
            DR3!R_DT_PHARM = DataGridView3.Rows(I).Cells(1).Value
            DR3!R_DT_NO3 = DataGridView3.Rows(I).Cells(2).Value
            DR3!R_DT_CODE2 = DataGridView3.Rows(I).Cells(3).Value
            DR3!R_DT_GOR3A = DataGridView3.Rows(I).Cells(4).Value
            DR3!STAT_DT = True
            DT3.Rows.Add(DR3)
            Dim CMD1_ As New SqlClient.SqlCommandBuilder(DA3)
            DA3.Update(DT3)
        Next

        MessageBox.Show("تمت عملية التعديل بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        NEWBTN_Click(sender, e)
    End Sub

    Private Sub DELETBTN_Click(sender As Object, e As EventArgs) Handles DELETBTN.Click
        If MessageBox.Show("Do you need delet this viset ? ", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM INFERTILITY_FOLLOWUP WHERE CODE_INFER_FOLLOW = '" & TXT_CODE.Text & "' ", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.Rows(0)

        DR!STAT_INFERTILITY = False
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)
        '===================================================================================
        Dim DT2 As New DataTable
        Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM R_DOCTOR WHERE R_CODE = '" & TXT_CODE100.Text & "'", SqlConn)
        DA2.Fill(DT2)
        Dim DR2 = DT2.Rows(0)

        DR2!R_STAT = False

        Dim CMD_ As New SqlClient.SqlCommandBuilder(DA2)
        DA2.Update(DT)

        MessageBox.Show("تمت عملية الحذف بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        NEWBTN_Click(sender, e)
    End Sub

    Private Sub SEARCHBTN_Click(sender As Object, e As EventArgs) Handles SEARCHBTN.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("Please enter the patient's name ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            SEARCH_ENGABFRM.ShowDialog()
        End If
    End Sub

    Private Sub BTN_FOLOWUP_Click(sender As Object, e As EventArgs) Handles BTN_FOLOWUP.Click
        Dim DT As New DataTable
        With DT
            .Columns.Add("DATE_TEST_INFERT")
            .Columns.Add("NAME_PALCE_TEST_INFERT")
            .Columns.Add("NAME_TEST_INFERT")
            .Columns.Add("RESULT_TEST_INFERT")

            .Columns.Add("DATE_PLAN_INFERT")
            .Columns.Add("NAME_PLAN_INFERT")

        End With
        For I = 0 To DataGridView1.Rows.Count - 1 And DataGridView4.Rows.Count - 1
            DT.Rows.Add(DataGridView1.Rows(I).Cells(2).Value,
             DataGridView1.Rows(I).Cells(1).Value,
                        DataGridView1.Rows(I).Cells(3).Value,
                        DataGridView1.Rows(I).Cells(4).Value,
                        DataGridView4.Rows(I).Cells(0).Value,
                        DataGridView4.Rows(I).Cells(1).Value)

        Next

        Dim REP As New ENGABREB
        REP.SetDataSource(DT)
        REP.SetParameterValue(0, TXT_M_MEDICAL.Text)
        REP.SetParameterValue(1, TXT_M_DOPPLER.Text)
        REP.SetParameterValue(2, TXT_M_SURGICAL.Text)
        REP.SetParameterValue(3, TXT_M_DATESEMAN.Text)
        REP.SetParameterValue(4, TXT_M_PLACSEMAN.Text)
        REP.SetParameterValue(5, TXT_M_SPERMSEMAN.Text)
        REP.SetParameterValue(6, TXT_M_MOTILITYSEMAN.Text)
        REP.SetParameterValue(7, TXT_M_ABNORMALSEMAN.Text)
        REP.SetParameterValue(8, TXT_PA_NAME.Text)
        REP.SetParameterValue(9, TXT_AGE.Text)
        REP.SetParameterValue(10, TXT_DATE_MARRIED.Text)
        REP.SetParameterValue(11, TXT_NAME2.Text)
        REP.SetParameterValue(12, TXT_AGE2.Text)
        REP.SetParameterValue(13, TXT_INFO.Text)
        REP.SetParameterValue(14, TXT_F_MEDICAL.Text)
        REP.SetParameterValue(15, TXT_F_FAMILY.Text)
        REP.SetParameterValue(16, TXT_F_OBSTETRIC.Text)
        REP.SetParameterValue(17, TXT_F_VAGINAL.Text)
        REP.SetParameterValue(18, TXT_F_HIRSUTISM.Text)
        REP.SetParameterValue(19, TXT_F_SURGICAL.Text)
        REP.SetParameterValue(20, TXT_F_MENSTRUAL.Text)
        REP.SetParameterValue(21, TXT_F_CONTRACPTION.Text)
        REP.SetParameterValue(22, TXT_F_WEIGHT.Text)
        REP.SetParameterValue(23, TXT_F_IUI.Text)

        Dim FRM As New REPFORALL
        FRM.CrystalReportViewer1.ReportSource = REP
        FRM.ShowDialog()
    End Sub
    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub
    Sub FILL_PATION()
        TXT_PA_NAME.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM INFERTILITY_HISTORY_V WHERE STAT_INFERT_HIS='TRUE' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA_NAME.Items.Add(DT.Rows(I).Item("PA_NAME"))
        Next
    End Sub
    Sub FILL_PHARM()
        TXT_NAME_PHARM.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PHARM WHERE STAT='TRUE'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_NAME_PHARM.Items.Add(DT.Rows(I).Item("PH_NAME"))
        Next
    End Sub
    Private Sub TXT_NAME_PHARM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_NAME_PHARM.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PHARM WHERE PH_NAME='" & TXT_NAME_PHARM.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_CODE_PHARM.Text = DT.Rows(I).Item("PH_CODE")
            TXT_NO3_PHARM.Text = DT.Rows(I).Item("PH_NO3")
        Next
        FILL_GOR3A()
    End Sub

    Private Sub TXT_PA_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_PA_NAME.SelectedIndexChanged
        '=====================================================
        TXT_DATE_VISIT.Text = Date.Today
        TXT_DATE_LMP.Text = Date.Today
        TXT_DATE_VISIT1.Text = Date.Today
        TXT_DATE_LMP1.Text = Date.Today
        '""""""""""""""" تنظيف الشاشة الأدوية """""""""""""
        For I = 0 To GroupBox21.Controls.Count - 1
            If TypeOf GroupBox21.Controls(I) Is TextBox Then GroupBox21.Controls(I).Text = ""
        Next
        For I = 0 To GroupBox21.Controls.Count - 1
            If TypeOf GroupBox21.Controls(I) Is ComboBox Then GroupBox21.Controls(I).Text = ""
        Next
        TXT_RECOMMENDATION.Text = ""
        TXT_ULTRASOUND.Text = ""
        DataGridView3.Rows.Clear()
        '====================================================
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM INFERTILITY_HISTORY_V WHERE PA_NAME ='" & TXT_PA_NAME.Text & "' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA_CODE.Text = DT.Rows(I).Item("PA_CODE")
            TXT_AGE.Text = DT.Rows(I).Item("PA_AGE")
            TXT_AGE2.Text = DT.Rows(I).Item("AGE2_INFERT_HIS")
            TXT_COMPLEAN.Text = DT.Rows(I).Item("COMPIN_INFERT_HIS")
            TXT_DATE_MARRIED.Value = DT.Rows(I).Item("DATE_MARED_INFERT_HIS")
            TXT_INFO.Text = DT.Rows(I).Item("INFO2_INFERT_HIS")
            TXT_NAME2.Text = DT.Rows(I).Item("PA_NAME2")
        Next
        T_Change.Enabled = True
        '=================== LAST VISET ====================
        Dim DT100 As New DataTable
        Dim DA100 As New SqlClient.SqlDataAdapter("SELECT * FROM INFERTILITY_FOLLOWUP WHERE STAT_INFERTILITY = 'TRUE' AND CODE_PA_PERSONAL_INFERTILITY ='" & TXT_PA_CODE.Text & "' ", SqlConn)
        DA100.Fill(DT100)
        For I = 0 To DT100.Rows.Count - 1
            TXT_RECOMMENDATION2.Text = DT100.Rows(I).Item("RECOMMENDATION_INFERTILITY")
            TXT_ULTRASOUND2.Text = DT100.Rows(I).Item("ULTRA_SOUND_INFERTILITY")
            TXT_DATE_LMP1.Value = DT100.Rows(I).Item("DATE_LMP_INFERTILITY")
            TXT_DATE_VISIT1.Value = DT100.Rows(I).Item("DATE_VISET_INFERTILITY")
        Next
        '================ VISET FOR PRINT ========================
        'FILL_DGV(DataGridView5, "SELECT * FROM INFERTILITY_FOLLOWUP WHERE STAT_INFERTILITY ='True' AND CODE_PA_PERSONAL_INFERTILITY='" & TXT_PA_CODE.Text & "'")

    End Sub

    Private Sub TXT_PA_CODE_TextChanged(sender As Object, e As EventArgs) Handles TXT_PA_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM INFERTILITY_HISTORY_V WHERE PA_CODE ='" & TXT_PA_CODE.Text & "' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA_NAME.Text = DT.Rows(I).Item("PA_NAME")
            TXT_AGE.Text = DT.Rows(I).Item("PA_AGE")
            TXT_AGE2.Text = DT.Rows(I).Item("AGE2_INFERT_HIS")
            TXT_COMPLEAN.Text = DT.Rows(I).Item("COMPIN_INFERT_HIS")
            TXT_DATE_MARRIED.Value = DT.Rows(I).Item("DATE_MARED_INFERT_HIS")
            TXT_INFO.Text = DT.Rows(I).Item("INFO2_INFERT_HIS")
            TXT_NAME2.Text = DT.Rows(I).Item("PA_NAME2")
        Next
        T_Change.Enabled = True

    End Sub

    Private Sub T_Change_Tick(sender As Object, e As EventArgs) Handles T_Change.Tick
        '============================
        TXT_CODE100.Text = CODE_GENE("R_DOCTOR", "ID") + 1
        '================ PLAN ========================
        FILL_DGV(DataGridView4, "SELECT * FROM PLAN_INFERT WHERE STAT_PLAN_INFERT ='TRUE' AND CODE_PA_PLAN_INFERT='" & TXT_PA_CODE.Text & "' ORDER BY DATE_PLAN_INFERT DESC ")
        '================ TESTER ========================
        FILL_DGV(DataGridView1, "SELECT * FROM TEST_INFERT WHERE STAT_TEST_INFERT ='TRUE' AND CODE_PA_TEST_INFERT='" & TXT_PA_CODE.Text & "' ORDER BY ID DESC ")
        '==================================================
        '=========== LAST PHARM ======================
        FILL_DGV(DataGridView2, "SELECT * FROM R_DOC_V_ENGAB WHERE R_STAT ='TRUE' AND R_DATE ='" & TXT_DATE_VISIT1.Text & "' AND R_CODE_PA = '" & TXT_PA_CODE.Text & "' AND R_CODE_FOLOWUP = 'ENGAB' ORDER BY ID DESC")
        '================ 4d ========================
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM E4D_INFERT WHERE STAT_4D_INFERT ='TRUE' AND CODE_PA_4D_INFERT = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            For I = 0 To DT.Rows.Count - 1
                TXT_DATE_4D.Value = DT.Rows(I).Item("DATE_4D_INFERT")
                TXT_PLACE_4D.Text = DT.Rows(I).Item("PLACE_4D_INFERT")
                TXT_UTRERUS_4D.Text = DT.Rows(I).Item("UTERUS_4D_INFERT")
                TXT_OVARIES_4D.Text = DT.Rows(I).Item("OVARIES_4D_INFERT")
                TXT_DOPPLER_4D.Text = DT.Rows(I).Item("DOPPLER_4D_INFERT")
            Next
        Else
            TXT_DATE_4D.Value = Date.Today
            TXT_PLACE_4D.Text = ""
            TXT_UTRERUS_4D.Text = ""
            TXT_OVARIES_4D.Text = ""
            TXT_DOPPLER_4D.Text = ""
        End If
        '====================== LAPAROSCOPY ========================
        Dim DT1 As New DataTable
        Dim DA1 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM LAPAROSCOPY_INFERILTY WHERE STAT_LAPAROSCOPY_INFERILTY ='TRUE' AND CODE_PA_LAPAROSCOPY_INFERILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
        DA1.Fill(DT1)
        If DT1.Rows.Count > 0 Then
            For I = 0 To DT1.Rows.Count - 1
                TXT_DATE_LAPAROSCOPY.Value = DT1.Rows(I).Item("DATE_LAPAROSCOPY_INFERILTY")
                TXT_PLACE_LAPAROSCOPY.Text = DT1.Rows(I).Item("PLACE_LAPAROSCOPY_INFERILTY")
                TXT_UTERUS_LAPAROSCOPY.Text = DT1.Rows(I).Item("UTERUS_LAPAROSCOPY_INFERILTY")
                TXT_OVARIES_LAPAROSCOPY.Text = DT1.Rows(I).Item("OVARIES_LAPAROSCOPY_INFERILTY")
                TXT_TUBES_LAPAROSCOPY.Text = DT1.Rows(I).Item("TUBES_LAPAROSCOPY_INFERILTY")
            Next
        Else
            TXT_DATE_LAPAROSCOPY.Value = Date.Today
            TXT_PLACE_LAPAROSCOPY.Text = ""
            TXT_UTERUS_LAPAROSCOPY.Text = ""
            TXT_OVARIES_LAPAROSCOPY.Text = ""
            TXT_TUBES_LAPAROSCOPY.Text = ""
        End If
        '====================== HSG ========================
        Dim DT2 As New DataTable
        Dim DA2 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM HSG_INFERILTY WHERE STAT_HSG_INFERILTY ='TRUE' AND CODE_PA_HSG_INFERILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
        DA2.Fill(DT2)
        If DT2.Rows.Count > 0 Then
            For I = 0 To DT2.Rows.Count - 1
                TXT_DATE_HSG.Value = DT2.Rows(I).Item("DATE_HSG_INFERILTY")
                TXT_PLACE_HSG.Text = DT2.Rows(I).Item("PLACE_HSG_INFERILTY")
                TXT_UTERUS_HSG.Text = DT2.Rows(I).Item("UTERUS_HSG_INFERILTY")
                TXT_TUBES_HSG.Text = DT2.Rows(I).Item("TUBES_HSG_INFERILTY")
            Next
        Else
            TXT_DATE_HSG.Value = Date.Today
            TXT_PLACE_HSG.Text = ""
            TXT_UTERUS_HSG.Text = ""
            TXT_TUBES_HSG.Text = ""
        End If
        '====================== HSG ========================
        Dim DT3 As New DataTable
        Dim DA3 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM HYSTROSCOPY_INFERILTY WHERE STAT_HYSTROSCOPY_INFERILTY ='TRUE' AND CODE_PA_HYSTROSCOPY_INFERILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
        DA3.Fill(DT3)
        If DT3.Rows.Count > 0 Then
            For I = 0 To DT3.Rows.Count - 1
                TXT_DATE_Hystroscopy.Value = DT3.Rows(I).Item("DATE_HYSTROSCOPY_INFERILTY")
                TXT_PLACE_Hystroscopy.Text = DT3.Rows(I).Item("PLACE_HYSTROSCOPY_INFERILTY")
                TXT_CERVIX_Hystroscopy.Text = DT3.Rows(I).Item("CERVIX_HYSTROSCOPY_INFERILTY")
                TXT_CAVITY_Hystroscopy.Text = DT3.Rows(I).Item("CAVITY_HYSTROSCOPY_INFERILTY")
            Next
        Else
            TXT_DATE_Hystroscopy.Value = Date.Today
            TXT_PLACE_Hystroscopy.Text = ""
            TXT_CERVIX_Hystroscopy.Text = ""
            TXT_CAVITY_Hystroscopy.Text = ""
        End If
        '====================== MEDICAL FEMAL ========================
        Dim DT4 As New DataTable
        Dim DA4 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM MEDICAL_FEMAL_INFERTILTY WHERE STAT_MEDICAL_FEMAL_INFERTILTY ='TRUE' AND CODE_PA_MEDICAL_FEMAL_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
        DA4.Fill(DT4)
        If DT4.Rows.Count > 0 Then
            For I = 0 To DT4.Rows.Count - 1
                TXT_F_MEDICAL.Text = DT4.Rows(I).Item("NAME_MEDICAL_FEMAL_INFERTILTY")
            Next
        Else
            TXT_F_MEDICAL.Text = ""
        End If
        '====================== FAMILY FEMAL ========================
        Dim DT5 As New DataTable
        Dim DA5 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM FAMILY_FEMAL_INFERTILTY WHERE STAT_FAMILY_FEMAL_INFERTILTY ='TRUE' AND CODE_PA_FAMILY_FEMAL_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
        DA5.Fill(DT5)
        If DT5.Rows.Count > 0 Then
            For I = 0 To DT5.Rows.Count - 1
                TXT_F_FAMILY.Text = DT5.Rows(I).Item("NAME_FAMILY_FEMAL_INFERTILTY")
            Next
        Else
            TXT_F_FAMILY.Text = ""
        End If
        '====================== OBSTETRIC FEMAL ========================
        Dim DT6 As New DataTable
        Dim DA6 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM OBSTETRIC_FEMAL_INFERTILTY WHERE STAT_OBSTETRIC_FEMAL_INFERTILTY ='TRUE' AND CODE_PA_OBSTETRIC_FEMAL_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
        DA6.Fill(DT6)
        If DT6.Rows.Count > 0 Then
            For I = 0 To DT6.Rows.Count - 1
                TXT_F_OBSTETRIC.Text = DT6.Rows(I).Item("NAME_OBSTETRIC_FEMAL_INFERTILTY")
            Next
        Else
            TXT_F_OBSTETRIC.Text = ""
        End If
        '====================== VAGINAL FEMAL ========================
        Dim DT7 As New DataTable
        Dim DA7 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM VAGINAL_FEMAL_INFERTILTY WHERE STAT_VAGINAL_FEMAL_INFERTILTY ='TRUE' AND CODE_PA_VAGINAL_FEMAL_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
        DA7.Fill(DT7)
        If DT7.Rows.Count > 0 Then
            For I = 0 To DT7.Rows.Count - 1
                TXT_F_VAGINAL.Text = DT7.Rows(I).Item("NAME_VAGINAL_FEMAL_INFERTILTY")
            Next
        Else
            TXT_F_VAGINAL.Text = ""
        End If
        '====================== HIRUTISM FEMAL ========================
        Dim DT8 As New DataTable
        Dim DA8 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM HIRUTISM_FEMAL_INFERTILTY WHERE STAT_HIRUTISM_FEMAL_INFERTILTY ='TRUE' AND CODE_PA_HIRUTISM_FEMAL_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
        DA8.Fill(DT8)
        If DT8.Rows.Count > 0 Then
            For I = 0 To DT8.Rows.Count - 1
                TXT_F_HIRSUTISM.Text = DT8.Rows(I).Item("NAME_HIRUTISM_FEMAL_INFERTILTY")
            Next
        Else
            TXT_F_HIRSUTISM.Text = ""
        End If
        '====================== SURGICAL FEMAL ========================
        Dim DT9 As New DataTable
        Dim DA9 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM SURGICAL_FEMAL_INFERTILTY WHERE STAT_SURGICAL_FEMAL_INFERTILTY ='TRUE' AND CODE_PA_SURGICAL_FEMAL_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
        DA9.Fill(DT9)
        If DT9.Rows.Count > 0 Then
            For I = 0 To DT9.Rows.Count - 1
                TXT_F_SURGICAL.Text = DT9.Rows(I).Item("NAME_SURGICAL_FEMAL_INFERTILTY")
            Next
        Else
            TXT_F_SURGICAL.Text = ""
        End If
        '====================== MENSTRUAL FEMAL ========================
        Dim DT10 As New DataTable
        Dim DA10 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM MENSTRUAL_FEMAL_INFERTILTY WHERE STAT_MENSTRUAL_FEMAL_INFERTILTY ='TRUE' AND CODE_PA_MENSTRUAL_FEMAL_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
        DA10.Fill(DT10)
        If DT10.Rows.Count > 0 Then
            For I = 0 To DT10.Rows.Count - 1
                TXT_F_MENSTRUAL.Text = DT10.Rows(I).Item("NAME_MENSTRUAL_FEMAL_INFERTILTY")
            Next
        Else
            TXT_F_MENSTRUAL.Text = ""
        End If
        '====================== CONTRACEPTION FEMAL ========================
        Dim DT11 As New DataTable
        Dim DA11 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM CONTRACEPTION_FEMAL_INFERTILTY WHERE STAT_CONTRACEPTION_FEMAL_INFERTILTY ='TRUE' AND CODE_PA_CONTRACEPTION_FEMAL_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
        DA11.Fill(DT11)
        If DT11.Rows.Count > 0 Then
            For I = 0 To DT11.Rows.Count - 1
                TXT_F_CONTRACPTION.Text = DT11.Rows(I).Item("NAME_CONTRACEPTION_FEMAL_INFERTILTY")
            Next
        Else
            TXT_F_CONTRACPTION.Text = ""
        End If
        '====================== WEIGHT GAIN FEMAL ========================
        Dim DT12 As New DataTable
        Dim DA12 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM WEIGHT_GAIN_FEMAL_INFERTILTY WHERE STAT_WEIGHT_GAIN_FEMAL_INFERTILTY ='TRUE' AND CODE_PA_WEIGHT_GAIN_FEMAL_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
        DA12.Fill(DT12)
        If DT12.Rows.Count > 0 Then
            For I = 0 To DT12.Rows.Count - 1
                TXT_F_WEIGHT.Text = DT12.Rows(I).Item("NAME_WEIGHT_GAIN_FEMAL_INFERTILTY")
            Next
        Else
            TXT_F_WEIGHT.Text = ""
        End If
        '====================== ICSI FEMAL ========================
        Dim DT13 As New DataTable
        Dim DA13 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM ICSI_FEMAL_INFERTILTY WHERE STAT_ICSI_FEMAL_INFERTILTY ='TRUE' AND CODE_PA_ICSI_FEMAL_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
        DA13.Fill(DT13)
        If DT13.Rows.Count > 0 Then
            For I = 0 To DT13.Rows.Count - 1
                TXT_F_IUI.Text = DT13.Rows(I).Item("NAME_ICSI_FEMAL_INFERTILTY")
            Next
        Else
            TXT_F_IUI.Text = ""
        End If
        '====================== MEDICAL MALE ========================
        Dim DT14 As New DataTable
        Dim DA14 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM MEDICAL_MALE_INFERTILTY WHERE STAT_MEDICAL_MALE_INFERTILTY ='TRUE' AND CODE_PA_MEDICAL_MALE_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
        DA14.Fill(DT14)
        If DT14.Rows.Count > 0 Then
            For I = 0 To DT14.Rows.Count - 1
                TXT_M_MEDICAL.Text = DT14.Rows(I).Item("NAME_MEDICAL_MALE_INFERTILTY")
            Next
        Else
            TXT_M_MEDICAL.Text = ""
        End If
        '====================== SURGICAL MALE ========================
        Dim DT15 As New DataTable
        Dim DA15 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM SURGICAL_MALE_INFERTILTY WHERE STAT_SURGICAL_MALE_INFERTILTY ='TRUE' AND CODE_PA_SURGICAL_MALE_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
        DA15.Fill(DT15)
        If DT15.Rows.Count > 0 Then
            For I = 0 To DT15.Rows.Count - 1
                TXT_M_SURGICAL.Text = DT15.Rows(I).Item("NAME_SURGICAL_MALE_INFERTILTY")
            Next
        Else
            TXT_M_SURGICAL.Text = ""
        End If
        '====================== SCROTAL DOPPLER MALE ========================
        Dim DT16 As New DataTable
        Dim DA16 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM SCROTAL_DOPPLER_MALE_INFERTILTY WHERE STAT_SCROTAL_DOPPLER_MALE_INFERTILTY ='TRUE' AND CODE_PA_SCROTAL_DOPPLER_MALE_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
        DA16.Fill(DT16)
        If DT16.Rows.Count > 0 Then
            For I = 0 To DT16.Rows.Count - 1
                TXT_M_DOPPLER.Text = DT16.Rows(I).Item("NAME_SCROTAL_DOPPLER_MALE_INFERTILTY")
            Next
        Else
            TXT_M_DOPPLER.Text = ""
        End If
        '====================== SEMAN ANALSES MALE ========================
        Dim DT17 As New DataTable
        Dim DA17 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM SEMAN WHERE STAT_SEMAN ='TRUE' AND CODE_PA_SEMAN = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
        DA17.Fill(DT17)
        If DT17.Rows.Count > 0 Then
            For I = 0 To DT17.Rows.Count - 1
                TXT_M_DATESEMAN.Text = DT17.Rows(I).Item("DATE_SEMAN")
                TXT_M_PLACSEMAN.Text = DT17.Rows(I).Item("PLACE_SEMAN")
                TXT_M_SPERMSEMAN.Text = DT17.Rows(I).Item("SPERM_SEMAN")
                TXT_M_ABNORMALSEMAN.Text = DT17.Rows(I).Item("ABNORMAL_SEMAN")
                TXT_M_MOTILITYSEMAN.Text = DT17.Rows(I).Item("MOTILITY_SEMAN")
            Next
        Else
            TXT_M_DATESEMAN.Text = Date.Today
            TXT_M_PLACSEMAN.Text = ""
            TXT_M_SPERMSEMAN.Text = ""
            TXT_M_ABNORMALSEMAN.Text = ""
            TXT_M_MOTILITYSEMAN.Text = ""
        End If
    End Sub


    Private Sub BTN_ADD_PLAN_Click(sender As Object, e As EventArgs) Handles BTN_ADD_PLAN.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("Please enter the patient's name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            PLAN_FRM_INFERTILITY.ShowDialog()
        End If

    End Sub

    Private Sub ADD_TEST_BTN_Click(sender As Object, e As EventArgs) Handles ADD_TEST_BTN.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("Please enter the patient's name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            TEST_FRM_INFERTILITY.ShowDialog()
        End If
    End Sub

    Private Sub BTN_ADD_4D_Click(sender As Object, e As EventArgs) Handles BTN_ADD_4D.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("Please enter the patient's name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            E4D_INFERILTY.ShowDialog()
        End If
    End Sub

    Private Sub BTN_ADD_LAPAROSCOPY_Click(sender As Object, e As EventArgs) Handles BTN_ADD_LAPAROSCOPY.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("Please enter the patient's name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            LAPAROSCOPY_INFERILTY.ShowDialog()
        End If
    End Sub

    Private Sub BTN_ADD_HSG_Click(sender As Object, e As EventArgs) Handles BTN_ADD_HSG.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("Please enter the patient's name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            HSG_INFERILTY.ShowDialog()
        End If
    End Sub

    Private Sub BTN_ADD_Hystroscopy_Click(sender As Object, e As EventArgs) Handles BTN_ADD_Hystroscopy.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("Please enter the patient's name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            HYSTROSCOPY_INFERILTY.ShowDialog()
        End If
    End Sub


    Private Sub BTN_F_ADD_MEDICAL_Click(sender As Object, e As EventArgs) Handles BTN_F_ADD_MEDICAL.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("Please enter the patient's name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            MEDICAL_FEMAL_INFERTILITY.ShowDialog()
        End If
    End Sub

    Private Sub BTN_F_ADD_FAMILY_Click(sender As Object, e As EventArgs) Handles BTN_F_ADD_FAMILY.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("Please enter the patient's name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            FAMILY_FEMAL_INFERTILITY.ShowDialog()
        End If
    End Sub

    Private Sub BTN_F_ADD_OBSTETRIC_Click(sender As Object, e As EventArgs) Handles BTN_F_ADD_OBSTETRIC.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("Please enter the patient's name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            OBSTETRIC_FEMAL_INFERTILITY.ShowDialog()
        End If
    End Sub

    Private Sub BTN_F_ADD_VAGINAL_Click(sender As Object, e As EventArgs) Handles BTN_F_ADD_VAGINAL.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("Please enter the patient's name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            VAGINAL_FEMAL_INFERTILITY.ShowDialog()
        End If
    End Sub

    Private Sub BTN_F_ADD_HIRSUTISM_Click(sender As Object, e As EventArgs) Handles BTN_F_ADD_HIRSUTISM.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("Please enter the patient's name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            HIRUTISM_FEMAL_INFERTILITY.ShowDialog()
        End If
    End Sub

    Private Sub BTN_F_ADD_SURGICAL_Click(sender As Object, e As EventArgs) Handles BTN_F_ADD_SURGICAL.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("Please enter the patient's name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            SURGICAL_FEMAL_INFERTILITY.ShowDialog()
        End If
    End Sub

    Private Sub BTN_F_ADD_MENSTRUAL_Click(sender As Object, e As EventArgs) Handles BTN_F_ADD_MENSTRUAL.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("Please enter the patient's name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            MENSTRUAL_FEMAL_INFERTILITY.ShowDialog()
        End If
    End Sub

    Private Sub BTN_F_ADD_CONTRACEPTION_Click(sender As Object, e As EventArgs) Handles BTN_F_ADD_CONTRACEPTION.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("Please enter the patient's name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            CONTRACEPTION_FEMAL_INFERTILITY.ShowDialog()
        End If
    End Sub

    Private Sub BTN_F_ADD_WEIGHT_Click(sender As Object, e As EventArgs) Handles BTN_F_ADD_WEIGHT.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("Please enter the patient's name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            WEIGHT_GAIN_FEMAL_INFERTILITY.ShowDialog()
        End If
    End Sub

    Private Sub BTN_F_ADD_IUI_Click(sender As Object, e As EventArgs) Handles BTN_F_ADD_IUI.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("Please enter the patient's name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            ICSI_FEMAL_INFERTILITY.ShowDialog()
        End If
    End Sub

    Private Sub BTN_ADD_M_MEDICAL_Click(sender As Object, e As EventArgs) Handles BTN_ADD_M_MEDICAL.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("Please enter the patient's name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            MEDICAL_MALE_INFERTILITY.ShowDialog()
        End If
    End Sub

    Private Sub BTN_ADD_M_SURGICAL_Click(sender As Object, e As EventArgs) Handles BTN_ADD_M_SURGICAL.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("Please enter the patient's name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            SURGICAL_MALE_INFERTILITY.ShowDialog()
        End If
    End Sub

    Private Sub BTN_ADD_M_DOPLER_Click(sender As Object, e As EventArgs) Handles BTN_ADD_M_DOPLER.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("Please enter the patient's name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            SCROTAL_DOPPLER_MALE_INFERTILITY.ShowDialog()
        End If
    End Sub
    Private Sub BTN_ADD_M_SEMAN_Click(sender As Object, e As EventArgs) Handles BTN_ADD_M_SEMAN.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("Please enter the patient's name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            SEMAN_ANALYSIS_INFERILTY.ShowDialog()
        End If
    End Sub
    Sub FILL_GOR3A()
        TXT_NAME_GOR3A.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM GOR3A WHERE STAT='TRUE' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_NAME_GOR3A.Items.Add(DT.Rows(I).Item("GOR_NAME"))
        Next
    End Sub
    Private Sub TXT_NAME_GOR3A_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_NAME_GOR3A.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM GOR3A WHERE GOR_NAME='" & TXT_NAME_GOR3A.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_CODE_GOR3A.Text = DT.Rows(I).Item("GOR_CODE")

        Next
    End Sub

    Private Sub BTN_PHARM_Click(sender As Object, e As EventArgs) Handles BTN_PHARM.Click
        If TXT_CODE_PHARM.Text = "" Then
            MessageBox.Show("عفوا ليس هناك أدوية لاضافتها", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_NAME_PHARM.Select()
        Else
            If TXT_CODE_GOR3A.Text = "" Then
                MessageBox.Show("عفوا ليس هناك جرعة للأدوية المختارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TXT_NAME_GOR3A.Select()
            Else

                Dim BAR As Integer
                '======= اضافة سجل للداتا جريد ===========
                DataGridView3.Rows.Add()
                BAR = DataGridView3.Rows.Count - 1
                DataGridView3(0, BAR).Value = TXT_CODE_PHARM.Text
                DataGridView3(1, BAR).Value = TXT_NAME_PHARM.Text
                DataGridView3(2, BAR).Value = TXT_NO3_PHARM.Text
                DataGridView3(3, BAR).Value = TXT_CODE_GOR3A.Text
                DataGridView3(4, BAR).Value = TXT_NAME_GOR3A.Text

                TXT_CODE_PHARM.Text = ""
                TXT_NAME_PHARM.Text = ""
                TXT_NO3_PHARM.Text = ""
                TXT_CODE_GOR3A.Text = ""
                TXT_NAME_GOR3A.Text = ""

                TXT_NAME_PHARM.Select()
            End If
        End If
    End Sub

    Private Sub BTN_BABY_Click(sender As Object, e As EventArgs) Handles BTN_BABY.Click

    End Sub
End Class