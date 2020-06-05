Public Class REP_ENGAB_CLOSE
    Private Sub REP_ENGAB_CLOSE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FILL_PATION()
        T_CHANG.Enabled = False
        TXT_CODE2.Text = ""
        TXT_PA_NAME.Select()
    End Sub

    Private Sub BTN_INFERTILITY_Click(sender As Object, e As EventArgs) Handles BTN_INFERTILITY.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("يرجي أختيار أسم المريض", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        End If

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM INFERTILITY_FOLLOWUP_TEMP WHERE STAT_INFERTILITY = 'TRUE' AND CODE_PA_PERSONAL_INFERTILITY ='" & TXT_PA_CODE.Text & "' ", SqlConn)
        DA.Fill(DT)
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
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM INFERTILITY_HISTORY_V_TEMP WHERE STAT_INFERT_HIS='TRUE' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA_NAME.Items.Add(DT.Rows(I).Item("PA_NAME"))
        Next
    End Sub

    Private Sub T_CHANG_Tick(sender As Object, e As EventArgs) Handles T_CHANG.Tick
        '============================
        TXT_CODE100.Text = CODE_GENE("R_DOCTOR", "ID") + 1
        '================ PLAN ========================
        FILL_DGV(DataGridView4, "SELECT * FROM PLAN_INFERT_TEMP WHERE STAT_PLAN_INFERT ='TRUE' AND CODE_PA_PLAN_INFERT='" & TXT_PA_CODE.Text & "' ORDER BY DATE_PLAN_INFERT DESC ")
        '================ TESTER ========================
        FILL_DGV(DataGridView1, "SELECT * FROM TEST_INFERT_TEMP WHERE STAT_TEST_INFERT ='TRUE' AND CODE_PA_TEST_INFERT='" & TXT_PA_CODE.Text & "' ORDER BY ID DESC ")
        '==================================================
        '=========== LAST PHARM ======================
        FILL_DGV(DataGridView2, "SELECT * FROM R_DOC_V_ENGAB WHERE R_STAT ='TRUE' AND R_DATE ='" & TXT_DATE_VISIT1.Text & "' AND R_CODE_PA = '" & TXT_PA_CODE.Text & "' AND R_CODE_FOLOWUP = 'ENGAB' ORDER BY ID DESC")
        '================ 4d ========================
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM E4D_INFERT_TEMP WHERE STAT_4D_INFERT ='TRUE' AND CODE_PA_4D_INFERT = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
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
        Dim DA1 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM LAPAROSCOPY_INFERILTY_TEMP WHERE STAT_LAPAROSCOPY_INFERILTY ='TRUE' AND CODE_PA_LAPAROSCOPY_INFERILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
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
        Dim DA2 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM HSG_INFERILTY_TEMP WHERE STAT_HSG_INFERILTY ='TRUE' AND CODE_PA_HSG_INFERILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
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
        Dim DA3 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM HYSTROSCOPY_INFERILTY_TEMP WHERE STAT_HYSTROSCOPY_INFERILTY ='TRUE' AND CODE_PA_HYSTROSCOPY_INFERILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
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
        Dim DA4 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM MEDICAL_FEMAL_INFERTILTY_TEMP WHERE STAT_MEDICAL_FEMAL_INFERTILTY ='TRUE' AND CODE_PA_MEDICAL_FEMAL_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
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
        Dim DA5 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM FAMILY_FEMAL_INFERTILTY_TEMP WHERE STAT_FAMILY_FEMAL_INFERTILTY ='TRUE' AND CODE_PA_FAMILY_FEMAL_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
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
        Dim DA6 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM OBSTETRIC_FEMAL_INFERTILTY_TEMP WHERE STAT_OBSTETRIC_FEMAL_INFERTILTY ='TRUE' AND CODE_PA_OBSTETRIC_FEMAL_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
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
        Dim DA7 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM VAGINAL_FEMAL_INFERTILTY_TEMP WHERE STAT_VAGINAL_FEMAL_INFERTILTY ='TRUE' AND CODE_PA_VAGINAL_FEMAL_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
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
        Dim DA8 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM HIRUTISM_FEMAL_INFERTILTY_TEMP WHERE STAT_HIRUTISM_FEMAL_INFERTILTY ='TRUE' AND CODE_PA_HIRUTISM_FEMAL_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
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
        Dim DA9 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM SURGICAL_FEMAL_INFERTILTY_TEMP WHERE STAT_SURGICAL_FEMAL_INFERTILTY ='TRUE' AND CODE_PA_SURGICAL_FEMAL_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
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
        Dim DA10 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM MENSTRUAL_FEMAL_INFERTILTY_TEMP WHERE STAT_MENSTRUAL_FEMAL_INFERTILTY ='TRUE' AND CODE_PA_MENSTRUAL_FEMAL_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
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
        Dim DA11 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM CONTRACEPTION_FEMAL_INFERTILTY_TEMP WHERE STAT_CONTRACEPTION_FEMAL_INFERTILTY ='TRUE' AND CODE_PA_CONTRACEPTION_FEMAL_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
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
        Dim DA12 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM WEIGHT_GAIN_FEMAL_INFERTILTY_TEMP WHERE STAT_WEIGHT_GAIN_FEMAL_INFERTILTY ='TRUE' AND CODE_PA_WEIGHT_GAIN_FEMAL_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
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
        Dim DA13 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM ICSI_FEMAL_INFERTILTY_TEMP WHERE STAT_ICSI_FEMAL_INFERTILTY ='TRUE' AND CODE_PA_ICSI_FEMAL_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
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
        Dim DA14 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM MEDICAL_MALE_INFERTILTY_TEMP WHERE STAT_MEDICAL_MALE_INFERTILTY ='TRUE' AND CODE_PA_MEDICAL_MALE_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
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
        Dim DA15 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM SURGICAL_MALE_INFERTILTY_TEMP WHERE STAT_SURGICAL_MALE_INFERTILTY ='TRUE' AND CODE_PA_SURGICAL_MALE_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
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
        Dim DA16 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM SCROTAL_DOPPLER_MALE_INFERTILTY_TEMP WHERE STAT_SCROTAL_DOPPLER_MALE_INFERTILTY ='TRUE' AND CODE_PA_SCROTAL_DOPPLER_MALE_INFERTILTY = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
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
        Dim DA17 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM SEMAN_TEMP WHERE STAT_SEMAN ='TRUE' AND CODE_PA_SEMAN = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
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
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM INFERTILITY_HISTORY_V_TEMP WHERE PA_NAME ='" & TXT_PA_NAME.Text & "' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA_CODE.Text = DT.Rows(I).Item("PA_CODE")
            TXT_AGE.Text = DT.Rows(I).Item("PA_AGE")
            TXT_AGE2.Text = DT.Rows(I).Item("AGE2_INFERT_HIS")
            TXT_COMPLEAN.Text = DT.Rows(I).Item("COMPIN_INFERT_HIS")
            TXT_DATE_MARRIED.Value = DT.Rows(I).Item("DATE_MARED_INFERT_HIS")
            TXT_INFO.Text = DT.Rows(I).Item("INFO2_INFERT_HIS")
            TXT_NAME2.Text = DT.Rows(I).Item("PA_NAME2")
            TXT_CODE2.Text = DT.Rows(I).Item("PA_CODE2")
        Next
        T_CHANG.Enabled = True
        '=================== LAST VISET ====================
        Dim DT100 As New DataTable
        Dim DA100 As New SqlClient.SqlDataAdapter("SELECT * FROM INFERTILITY_FOLLOWUP_TEMP WHERE STAT_INFERTILITY = 'TRUE' AND CODE_PA_PERSONAL_INFERTILITY ='" & TXT_PA_CODE.Text & "' ", SqlConn)
        DA100.Fill(DT100)
        For I = 0 To DT100.Rows.Count - 1
            TXT_RECOMMENDATION2.Text = DT100.Rows(I).Item("RECOMMENDATION_INFERTILITY")
            TXT_ULTRASOUND2.Text = DT100.Rows(I).Item("ULTRA_SOUND_INFERTILITY")
            TXT_DATE_LMP1.Value = DT100.Rows(I).Item("DATE_LMP_INFERTILITY")
            TXT_DATE_VISIT1.Value = DT100.Rows(I).Item("DATE_VISET_INFERTILITY")
        Next
        '=========================================================================================================

    End Sub

    Private Sub PLANBTN_Click(sender As Object, e As EventArgs) Handles PLANBTN.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("يرجي أختيار أسم المريض", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        End If

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PLAN_INFERT_TEMP WHERE STAT_PLAN_INFERT='TRUE' AND CODE_PA_PLAN_INFERT ='" & TXT_PA_CODE.Text & "' ORDER BY ID DESC ", SqlConn)
        DA.Fill(DT)

        Dim REP As New ENGABREB_PLAN
        REP.SetDataSource(DT)

        REP.SetParameterValue(0, TXT_PA_NAME.Text)
        REP.SetParameterValue(1, TXT_AGE.Text)
        REP.SetParameterValue(2, TXT_DATE_MARRIED.Text)
        REP.SetParameterValue(3, TXT_NAME2.Text)
        REP.SetParameterValue(4, TXT_AGE2.Text)
        REP.SetParameterValue(5, TXT_INFO.Text)

        Dim FRM As New REPFORALL
        FRM.CrystalReportViewer1.ReportSource = REP
        FRM.ShowDialog()
    End Sub

    Private Sub InvestigationsBTN_Click(sender As Object, e As EventArgs) Handles InvestigationsBTN.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("يرجي أختيار أسم المريض", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        End If

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM TEST_INFERT_TEMP WHERE STAT_TEST_INFERT='TRUE' AND CODE_PA_TEST_INFERT ='" & TXT_PA_CODE.Text & "' ORDER BY ID DESC ", SqlConn)
        DA.Fill(DT)
        Dim REP As New ENGABREB_TEST
        REP.SetDataSource(DT)
        REP.SetParameterValue(0, TXT_PA_NAME.Text)
        REP.SetParameterValue(1, TXT_AGE.Text)
        REP.SetParameterValue(2, TXT_DATE_MARRIED.Text)
        REP.SetParameterValue(3, TXT_NAME2.Text)
        REP.SetParameterValue(4, TXT_AGE2.Text)
        REP.SetParameterValue(5, TXT_INFO.Text)
        Dim FRM As New REPFORALL
        FRM.CrystalReportViewer1.ReportSource = REP
        FRM.ShowDialog()
    End Sub
End Class