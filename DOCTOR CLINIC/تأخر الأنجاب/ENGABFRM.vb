﻿Public Class ENGABFRM

    Sub CALCDATE()
        Dim DATEDAY As Date
        Dim DATELAST As Date
        Dim FDATE As Integer

        DATEDAY = TXT_DATE_VISITNEW.Value
        DATELAST = TXT_DATE_VISITLAST.Value
        FDATE = DateDiff(DateInterval.Day, DATELAST, DATEDAY)
        TXT_FDATE.Text = "DAY : " & FDATE
    End Sub
    Sub CALCDATE1()
        Dim DATEDAY As Date
        Dim DATELAST As Date
        Dim FDATE As Integer

        DATEDAY = TXT_DATE_VISITNEW1.Value
        DATELAST = TXT_DATE_VISITLAST1.Value
        FDATE = DateDiff(DateInterval.Day, DATELAST, DATEDAY)
        TXT_FDATE1.Text = "DAY : " & FDATE
    End Sub

    Private Sub TXT_DATE_VISITNEW_ValueChanged(sender As Object, e As EventArgs) Handles TXT_DATE_VISITNEW.ValueChanged
        CALCDATE()
    End Sub

    Private Sub TXT_DATE_VISITLAST_ValueChanged(sender As Object, e As EventArgs) Handles TXT_DATE_VISITLAST.ValueChanged
        CALCDATE()
    End Sub

    Private Sub ENGABFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEWBTN_Click(sender, e)
    End Sub

    Private Sub TXT_DATE_VISITNEW1_ValueChanged(sender As Object, e As EventArgs) Handles TXT_DATE_VISITNEW1.ValueChanged
        CALCDATE1()
    End Sub

    Private Sub TXT_DATE_VISITLAST1_ValueChanged(sender As Object, e As EventArgs) Handles TXT_DATE_VISITLAST1.ValueChanged
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

        TXT_DATE_VISITNEW.Text = Date.Today
        TXT_DATE_VISITLAST.Text = Date.Today
        TXT_DATE_VISITNEW1.Text = Date.Today
        TXT_DATE_VISITLAST1.Text = Date.Today
        EDITBTN.Enabled = False
        DELETBTN.Enabled = False
        SAVEBTN.Enabled = True
        FILL_PATION()
        TXT_PA_NAME.Select()

    End Sub
    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click

    End Sub

    Private Sub EDITBTN_Click(sender As Object, e As EventArgs) Handles EDITBTN.Click

    End Sub

    Private Sub DELETBTN_Click(sender As Object, e As EventArgs) Handles DELETBTN.Click

    End Sub

    Private Sub SEARCHBTN_Click(sender As Object, e As EventArgs) Handles SEARCHBTN.Click

    End Sub

    Private Sub BTN_FOLOWUP_Click(sender As Object, e As EventArgs) Handles BTN_FOLOWUP.Click

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

    Private Sub TXT_PA_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_PA_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM INFERTILITY_HISTORY_V WHERE PA_NAME ='" & TXT_PA_NAME.Text & "' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA_CODE.Text = DT.Rows(I).Item("PA_CODE_INFERT_HIS")
            TXT_AGE.Text = DT.Rows(I).Item("PA_AGE")
            TXT_AGE2.Text = DT.Rows(I).Item("AGE2_INFERT_HIS")
            TXT_COMPLEAN.Text = DT.Rows(I).Item("COMPIN_INFERT_HIS")
            TXT_DATE_MARRIED.Value = DT.Rows(I).Item("DATE_MARED_INFERT_HIS")
            TXT_INFO.Text = DT.Rows(I).Item("INFO2_INFERT_HIS")
            TXT_NAME2.Text = DT.Rows(I).Item("PA_NAME2")
        Next
        T_Change.Enabled = True

    End Sub

    Private Sub TXT_PA_CODE_TextChanged(sender As Object, e As EventArgs) Handles TXT_PA_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM INFERTILITY_HISTORY_V WHERE PA_CODE_INFERT_HIS ='" & TXT_PA_CODE.Text & "' ", SqlConn)
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
        '================ PLAN ========================
        FILL_DGV(DataGridView4, "SELECT * FROM PLAN_INFERT WHERE STAT_PLAN_INFERT ='TRUE' AND CODE_PA_PLAN_INFERT='" & TXT_PA_CODE.Text & "' ORDER BY DATE_PLAN_INFERT DESC ")
        '==================================================
        '================ TESTER ========================
        FILL_DGV(DataGridView1, "SELECT * FROM TEST_INFERT WHERE STAT_TEST_INFERT ='TRUE' AND CODE_PA_TEST_INFERT='" & TXT_PA_CODE.Text & "' ORDER BY ID DESC ")
        '==================================================
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
End Class