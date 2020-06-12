Public Class have_baby
    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click
        If MessageBox.Show("هل انت متأكد ان المريضة حامل بالفعل ؟ ", "رسالة تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        '===================================================================================================
        If TXT_RH.Text = "" Then
            MessageBox.Show("PLEASE ENTER RH FOR PATION ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_RH.Select()
            Exit Sub
        End If
        If TXT_ABO.Text = "" Then
            MessageBox.Show("PLEASE ENTER ABO FOR PATION ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_ABO.Select()
            Exit Sub
        End If

        '===================== PERSONAL INFERTILITY ==============================
        Dim DT1 As New DataTable
        Dim DA1 As New SqlClient.SqlDataAdapter(" INSERT INTO INFERTILITY_FOLLOWUP_TEMP SELECT * FROM INFERTILITY_FOLLOWUP WHERE CODE_PA_PERSONAL_INFERTILITY = '" & TXT_PA_CODE.Text & "' ", SqlConn)
        DA1.Fill(DT1)
        '=================================================
        Dim CMD_DEL1 As New SqlClient.SqlCommand
        CMD_DEL1.Connection = SqlConn
        CMD_DEL1.CommandText = "DELETE FROM INFERTILITY_FOLLOWUP WHERE CODE_PA_PERSONAL_INFERTILITY ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL1.ExecuteNonQuery()

        '===================== PLAN ==============================
        Dim DT2 As New DataTable
        Dim DA2 As New SqlClient.SqlDataAdapter("INSERT INTO PLAN_INFERT_TEMP SELECT * FROM PLAN_INFERT WHERE CODE_PA_PLAN_INFERT ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA2.Fill(DT2)
        '=================================================
        Dim CMD_DEL2 As New SqlClient.SqlCommand
        CMD_DEL2.Connection = SqlConn
        CMD_DEL2.CommandText = "DELETE FROM PLAN_INFERT WHERE CODE_PA_PLAN_INFERT ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL2.ExecuteNonQuery()

        '===================== TESTER  ==============================
        Dim DT3 As New DataTable
        Dim DA3 As New SqlClient.SqlDataAdapter("INSERT INTO TEST_INFERT_TEMP SELECT * FROM TEST_INFERT WHERE CODE_PA_TEST_INFERT ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA3.Fill(DT3)
        '=================================================
        Dim CMD_DEL3 As New SqlClient.SqlCommand
        CMD_DEL3.Connection = SqlConn
        CMD_DEL3.CommandText = "DELETE FROM  TEST_INFERT WHERE CODE_PA_TEST_INFERT ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL3.ExecuteNonQuery()

        '===================== 4d  ==============================
        Dim DT4 As New DataTable
        Dim DA4 As New SqlClient.SqlDataAdapter("INSERT INTO E4D_INFERT_TEMP SELECT * FROM E4D_INFERT WHERE CODE_PA_4D_INFERT ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA4.Fill(DT4)
        '=================================================
        Dim CMD_DEL4 As New SqlClient.SqlCommand
        CMD_DEL4.Connection = SqlConn
        CMD_DEL4.CommandText = "DELETE FROM  E4D_INFERT WHERE CODE_PA_4D_INFERT ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL4.ExecuteNonQuery()

        '===================== LAPAROSCOPY  ==============================
        Dim DT5 As New DataTable
        Dim DA5 As New SqlClient.SqlDataAdapter("INSERT INTO LAPAROSCOPY_INFERILTY_TEMP SELECT * FROM LAPAROSCOPY_INFERILTY WHERE CODE_PA_LAPAROSCOPY_INFERILTY ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA5.Fill(DT5)
        '=================================================
        Dim CMD_DEL5 As New SqlClient.SqlCommand
        CMD_DEL5.Connection = SqlConn
        CMD_DEL5.CommandText = "DELETE FROM  LAPAROSCOPY_INFERILTY WHERE CODE_PA_LAPAROSCOPY_INFERILTY ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL5.ExecuteNonQuery()

        '===================== HSG  ==============================
        Dim DT6 As New DataTable
        Dim DA6 As New SqlClient.SqlDataAdapter("INSERT INTO HSG_INFERILTY_TEMP SELECT * FROM HSG_INFERILTY WHERE CODE_PA_HSG_INFERILTY ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA6.Fill(DT6)
        '=================================================
        Dim CMD_DEL6 As New SqlClient.SqlCommand
        CMD_DEL6.Connection = SqlConn
        CMD_DEL6.CommandText = "DELETE FROM  HSG_INFERILTY WHERE CODE_PA_HSG_INFERILTY ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL6.ExecuteNonQuery()

        '===================== Hystroscopy  ==============================
        Dim DT7 As New DataTable
        Dim DA7 As New SqlClient.SqlDataAdapter("INSERT INTO HYSTROSCOPY_INFERILTY_TEMP SELECT * FROM HYSTROSCOPY_INFERILTY WHERE CODE_PA_HYSTROSCOPY_INFERILTY ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA7.Fill(DT7)
        '=================================================
        Dim CMD_DEL7 As New SqlClient.SqlCommand
        CMD_DEL7.Connection = SqlConn
        CMD_DEL7.CommandText = "DELETE FROM  HYSTROSCOPY_INFERILTY WHERE CODE_PA_HYSTROSCOPY_INFERILTY ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL7.ExecuteNonQuery()
        '===================== MEDICAL FEMAL  ==============================
        Dim DT8 As New DataTable
        Dim DA8 As New SqlClient.SqlDataAdapter("INSERT INTO MEDICAL_FEMAL_INFERTILTY_TEMP SELECT * FROM MEDICAL_FEMAL_INFERTILTY WHERE CODE_PA_MEDICAL_FEMAL_INFERTILTY ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA8.Fill(DT8)
        '=================================================
        Dim CMD_DEL8 As New SqlClient.SqlCommand
        CMD_DEL8.Connection = SqlConn
        CMD_DEL8.CommandText = "DELETE FROM  MEDICAL_FEMAL_INFERTILTY WHERE CODE_PA_MEDICAL_FEMAL_INFERTILTY ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL8.ExecuteNonQuery()
        '====================== FAMILY FEMAL ========================
        Dim DT9 As New DataTable
        Dim DA9 As New SqlClient.SqlDataAdapter("INSERT INTO FAMILY_FEMAL_INFERTILTY_TEMP SELECT * FROM FAMILY_FEMAL_INFERTILTY WHERE CODE_PA_FAMILY_FEMAL_INFERTILTY ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA9.Fill(DT9)
        '=================================================
        Dim CMD_DEL9 As New SqlClient.SqlCommand
        CMD_DEL9.Connection = SqlConn
        CMD_DEL9.CommandText = "DELETE FROM  FAMILY_FEMAL_INFERTILTY WHERE CODE_PA_FAMILY_FEMAL_INFERTILTY ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL9.ExecuteNonQuery()
        '====================== OBSTETRIC FEMAL ========================
        Dim DT10 As New DataTable
        Dim DA10 As New SqlClient.SqlDataAdapter("INSERT INTO OBSTETRIC_FEMAL_INFERTILTY_TEMP SELECT * FROM OBSTETRIC_FEMAL_INFERTILTY WHERE CODE_PA_OBSTETRIC_FEMAL_INFERTILTY ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA10.Fill(DT10)
        '=================================================
        Dim CMD_DEL10 As New SqlClient.SqlCommand
        CMD_DEL10.Connection = SqlConn
        CMD_DEL10.CommandText = "DELETE FROM  OBSTETRIC_FEMAL_INFERTILTY WHERE CODE_PA_OBSTETRIC_FEMAL_INFERTILTY ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL10.ExecuteNonQuery()
        '====================== VAGINAL FEMAL ========================
        Dim DT11 As New DataTable
        Dim DA11 As New SqlClient.SqlDataAdapter("INSERT INTO VAGINAL_FEMAL_INFERTILTY_TEMP SELECT * FROM VAGINAL_FEMAL_INFERTILTY WHERE CODE_PA_VAGINAL_FEMAL_INFERTILTY ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA11.Fill(DT11)
        '=================================================
        Dim CMD_DEL11 As New SqlClient.SqlCommand
        CMD_DEL11.Connection = SqlConn
        CMD_DEL11.CommandText = "DELETE FROM  VAGINAL_FEMAL_INFERTILTY WHERE CODE_PA_VAGINAL_FEMAL_INFERTILTY ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL11.ExecuteNonQuery()
        '====================== HIRUTISM FEMAL ========================
        Dim DT12 As New DataTable
        Dim DA12 As New SqlClient.SqlDataAdapter("INSERT INTO HIRUTISM_FEMAL_INFERTILTY_TEMP SELECT * FROM HIRUTISM_FEMAL_INFERTILTY WHERE CODE_PA_HIRUTISM_FEMAL_INFERTILTY ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA12.Fill(DT12)
        '=================================================
        Dim CMD_DEL12 As New SqlClient.SqlCommand
        CMD_DEL12.Connection = SqlConn
        CMD_DEL12.CommandText = "DELETE FROM  HIRUTISM_FEMAL_INFERTILTY WHERE CODE_PA_HIRUTISM_FEMAL_INFERTILTY ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL12.ExecuteNonQuery()
        '====================== SURGICAL FEMAL ========================
        Dim DT13 As New DataTable
        Dim DA13 As New SqlClient.SqlDataAdapter("INSERT INTO SURGICAL_FEMAL_INFERTILTY_TEMP SELECT * FROM SURGICAL_FEMAL_INFERTILTY WHERE CODE_PA_SURGICAL_FEMAL_INFERTILTY ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA13.Fill(DT13)
        '=================================================
        Dim CMD_DEL13 As New SqlClient.SqlCommand
        CMD_DEL13.Connection = SqlConn
        CMD_DEL13.CommandText = "DELETE FROM  SURGICAL_FEMAL_INFERTILTY WHERE CODE_PA_SURGICAL_FEMAL_INFERTILTY ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL13.ExecuteNonQuery()
        '====================== MENSTRUAL FEMAL ========================
        Dim DT14 As New DataTable
        Dim DA14 As New SqlClient.SqlDataAdapter("INSERT INTO MENSTRUAL_FEMAL_INFERTILTY_TEMP SELECT * FROM MENSTRUAL_FEMAL_INFERTILTY WHERE CODE_PA_MENSTRUAL_FEMAL_INFERTILTY ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA14.Fill(DT14)
        '=================================================
        Dim CMD_DEL14 As New SqlClient.SqlCommand
        CMD_DEL14.Connection = SqlConn
        CMD_DEL14.CommandText = "DELETE FROM  MENSTRUAL_FEMAL_INFERTILTY WHERE CODE_PA_MENSTRUAL_FEMAL_INFERTILTY ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL14.ExecuteNonQuery()
        '====================== CONTRACEPTION FEMAL ========================
        Dim DT15 As New DataTable
        Dim DA15 As New SqlClient.SqlDataAdapter("INSERT INTO CONTRACEPTION_FEMAL_INFERTILTY_TEMP SELECT * FROM CONTRACEPTION_FEMAL_INFERTILTY WHERE CODE_PA_CONTRACEPTION_FEMAL_INFERTILTY ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA15.Fill(DT15)
        '=================================================
        Dim CMD_DEL15 As New SqlClient.SqlCommand
        CMD_DEL15.Connection = SqlConn
        CMD_DEL15.CommandText = "DELETE FROM  CONTRACEPTION_FEMAL_INFERTILTY WHERE CODE_PA_CONTRACEPTION_FEMAL_INFERTILTY ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL15.ExecuteNonQuery()
        '====================== WEIGHT GAIN FEMAL ========================
        Dim DT16 As New DataTable
        Dim DA16 As New SqlClient.SqlDataAdapter("INSERT INTO WEIGHT_GAIN_FEMAL_INFERTILTY_TEMP SELECT * FROM WEIGHT_GAIN_FEMAL_INFERTILTY WHERE CODE_PA_WEIGHT_GAIN_FEMAL_INFERTILTY ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA16.Fill(DT16)
        '=================================================
        Dim CMD_DEL16 As New SqlClient.SqlCommand
        CMD_DEL16.Connection = SqlConn
        CMD_DEL16.CommandText = "DELETE FROM  WEIGHT_GAIN_FEMAL_INFERTILTY WHERE CODE_PA_WEIGHT_GAIN_FEMAL_INFERTILTY ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL16.ExecuteNonQuery()
        '====================== ICSI FEMAL ========================
        Dim DT17 As New DataTable
        Dim DA17 As New SqlClient.SqlDataAdapter("INSERT INTO ICSI_FEMAL_INFERTILTY_TEMP SELECT * FROM ICSI_FEMAL_INFERTILTY WHERE CODE_PA_ICSI_FEMAL_INFERTILTY ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA17.Fill(DT17)
        '=================================================
        Dim CMD_DEL17 As New SqlClient.SqlCommand
        CMD_DEL17.Connection = SqlConn
        CMD_DEL17.CommandText = "DELETE FROM  ICSI_FEMAL_INFERTILTY WHERE CODE_PA_ICSI_FEMAL_INFERTILTY ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL17.ExecuteNonQuery()
        '====================== MEDICAL MALE ========================
        Dim DT18 As New DataTable
        Dim DA18 As New SqlClient.SqlDataAdapter("INSERT INTO MEDICAL_MALE_INFERTILTY_TEMP SELECT * FROM MEDICAL_MALE_INFERTILTY WHERE CODE_PA_MEDICAL_MALE_INFERTILTY ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA18.Fill(DT18)
        '=================================================
        Dim CMD_DEL18 As New SqlClient.SqlCommand
        CMD_DEL18.Connection = SqlConn
        CMD_DEL18.CommandText = "DELETE FROM  MEDICAL_MALE_INFERTILTY WHERE CODE_PA_MEDICAL_MALE_INFERTILTY ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL18.ExecuteNonQuery()
        '====================== SURGICAL MALE ========================
        Dim DT19 As New DataTable
        Dim DA19 As New SqlClient.SqlDataAdapter("INSERT INTO SURGICAL_MALE_INFERTILTY_TEMP SELECT * FROM SURGICAL_MALE_INFERTILTY WHERE CODE_PA_SURGICAL_MALE_INFERTILTY ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA19.Fill(DT19)
        '=================================================
        Dim CMD_DEL19 As New SqlClient.SqlCommand
        CMD_DEL19.Connection = SqlConn
        CMD_DEL19.CommandText = "DELETE FROM  SURGICAL_MALE_INFERTILTY WHERE CODE_PA_SURGICAL_MALE_INFERTILTY ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL19.ExecuteNonQuery()
        '====================== SCROTAL DOPPLER MALE ========================
        Dim DT20 As New DataTable
        Dim DA20 As New SqlClient.SqlDataAdapter("INSERT INTO SCROTAL_DOPPLER_MALE_INFERTILTY_TEMP SELECT * FROM SCROTAL_DOPPLER_MALE_INFERTILTY WHERE CODE_PA_SCROTAL_DOPPLER_MALE_INFERTILTY ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA20.Fill(DT20)
        '=================================================
        Dim CMD_DEL20 As New SqlClient.SqlCommand
        CMD_DEL20.Connection = SqlConn
        CMD_DEL20.CommandText = "DELETE FROM  SCROTAL_DOPPLER_MALE_INFERTILTY WHERE CODE_PA_SCROTAL_DOPPLER_MALE_INFERTILTY ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL20.ExecuteNonQuery()
        '====================== SEMAN ANALSES MALE ========================
        Dim DT21 As New DataTable
        Dim DA21 As New SqlClient.SqlDataAdapter("INSERT INTO SEMAN_TEMP SELECT * FROM SEMAN WHERE CODE_PA_SEMAN ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA21.Fill(DT21)
        '=================================================
        Dim CMD_DEL21 As New SqlClient.SqlCommand
        CMD_DEL21.Connection = SqlConn
        CMD_DEL21.CommandText = "DELETE FROM  SEMAN WHERE CODE_PA_SEMAN ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL21.ExecuteNonQuery()

        '====================== INFERTILITY_HISTORY ========================
        Dim DT22 As New DataTable
        Dim DA22 As New SqlClient.SqlDataAdapter("INSERT INTO INFERTILITY_HISTORY_TEMP SELECT * FROM INFERTILITY_HISTORY WHERE PA_CODE_INFERT_HIS ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA22.Fill(DT22)
        '=================================================
        Dim CMD_DEL22 As New SqlClient.SqlCommand
        CMD_DEL22.Connection = SqlConn
        CMD_DEL22.CommandText = "DELETE FROM  INFERTILITY_HISTORY WHERE PA_CODE_INFERT_HIS ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL22.ExecuteNonQuery()
        '========================================================================================================

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM PERSONAL_HISTORY WHERE CODE_PA_PERS = '" & TXT_PA_CODE.Text & "' ", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.NewRow
        DR!CODE_PERS = CODE_GENE("PERSONAL_HISTORY", "ID") + 1
        DR!CODE_PA_PERS = TXT_PA_CODE.Text
        DR!DATE_MARED_PERS = MARED_DEAT.Value
        DR!LMP_PERS = LMP_DATE.Value
        DR!EDP_PERS = EDD_DATE.Value
        DR!RH_PERS = TXT_RH.Text
        DR!ABO_PERS = TXT_ABO.Text
        DR!STAT_PERS = True
        DT.Rows.Add(DR)
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)


        MessageBox.Show("تم تأكيد الأنجاب بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub have_baby_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_PA_CODE.Text = ENGABFRM.TXT_PA_CODE.Text
        TXT_NAME_PA.Text = ENGABFRM.TXT_PA_NAME.Text
        MARED_DEAT.Value = ENGABFRM.TXT_DATE_MARRIED.Value
    End Sub

    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub
End Class