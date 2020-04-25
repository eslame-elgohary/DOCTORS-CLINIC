Public Class REP_FOLOWUP_CLOSE
    Private Sub REP_FOLOWUP_CLOSE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FILL_PATION()
        T_CHANG.Enabled = False
        TXT_CODE2.Text = ""
        TXT_PA_NAME.Select()
    End Sub

    Private Sub BTN_FOLOWUP_Click(sender As Object, e As EventArgs) Handles BTN_FOLOWUP.Click

        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("PLEASE ENTER THE NAME PATIENT ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM FOLOW_V_CLOSE WHERE STAT_FOLOWUP ='TRUE' AND PA_CODE_FOLOWUP = '" & TXT_PA_CODE.Text & "'", SqlConn)
            DA.Fill(DT)

            Dim REP As New FOLOWUPREP
            REP.SetDataSource(DT)
            REP.SetParameterValue(0, TXT_4D.Text)
            REP.SetParameterValue(1, TXT_FETAL.Text)
            REP.SetParameterValue(2, TXT_DATE_MARRIED.Text)
            REP.SetParameterValue(3, TXT_DATE_LMP.Text)
            REP.SetParameterValue(4, TXT_RH.Text)
            REP.SetParameterValue(5, TXT_ABO.Text)
            REP.SetParameterValue(6, TXT_OBSTETRIC.Text)
            REP.SetParameterValue(7, TXT_DATE_EDD.Text)
            REP.SetParameterValue(8, st1_hb.Text)
            REP.SetParameterValue(9, st1_plt.Text)
            REP.SetParameterValue(10, st1_pc.Text)
            REP.SetParameterValue(11, st1_cmv.Text)
            REP.SetParameterValue(12, st1_hbac.Text)
            REP.SetParameterValue(13, st1_rbs.Text)
            REP.SetParameterValue(14, st1_tsh.Text)
            REP.SetParameterValue(15, st1_urine.Text)
            REP.SetParameterValue(16, st1_toxo.Text)
            REP.SetParameterValue(17, ND2_hb.Text)
            REP.SetParameterValue(18, ND2_plt.Text)
            REP.SetParameterValue(19, ND2_pc.Text)
            REP.SetParameterValue(20, ND2_LONIZED.Text)
            REP.SetParameterValue(21, ND2_HOUR.Text)
            REP.SetParameterValue(22, ND2_TSH.Text)
            REP.SetParameterValue(23, ND2_TOTAL.Text)
            REP.SetParameterValue(24, ND2_urine.Text)
            REP.SetParameterValue(25, RD3_hb.Text)
            REP.SetParameterValue(26, RD3_plt.Text)
            REP.SetParameterValue(27, RD3_pc.Text)
            REP.SetParameterValue(28, RD3_rbs.Text)
            REP.SetParameterValue(29, RD3_SGPT.Text)
            REP.SetParameterValue(30, RD3_TSH.Text)
            REP.SetParameterValue(31, RD3_CREAT.Text)
            REP.SetParameterValue(32, RD3_urine.Text)
            REP.SetParameterValue(33, RD3_HOUR.Text)

            Dim FRM As New REPFORALL
            FRM.CrystalReportViewer1.ReportSource = REP
            FRM.ShowDialog()
        End If

    End Sub

    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub
    Sub FILL_PATION()
        TXT_PA_NAME.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PERSONAL_HISTORY_TEMP,PATIENT WHERE CODE_PA_PERS=PA_CODE AND STAT_PERS='TRUE' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA_NAME.Items.Add(DT.Rows(I).Item("PA_NAME"))
        Next
    End Sub

    Private Sub T_CHANG_Tick(sender As Object, e As EventArgs) Handles T_CHANG.Tick
        '======================== 4D ===============================
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM E4D_HISTORY_TEMP WHERE STAT_4D ='TRUE' AND PA_CODE_4D = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            For I = 0 To DT.Rows.Count - 1
                TXT_4D.Text = DT.Rows(I).Item("NAME_4D")
            Next
        Else
            TXT_4D.Text = ""
        End If
        '=========================== OBSTETRIC HISTORY=======================================
        Dim DT1 As New DataTable
        Dim DA1 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM OBSTETRIC_HISTORY_TEMP WHERE STAT_OBSTETRIC ='TRUE' AND PA_CODE_OBSTETRIC = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC ", SqlConn)
        DA1.Fill(DT1)
        If DT1.Rows.Count > 0 Then
            For I = 0 To DT1.Rows.Count - 1
                TXT_OBSTETRIC.Text = DT1.Rows(I).Item("NAME_OBSTETRIC")
            Next
        Else
            TXT_OBSTETRIC.Text = ""
        End If

        '=========================== FETAL DOPPLER =======================================
        Dim DT2 As New DataTable
        Dim DA2 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM FETAL_HISTORY_TEMP WHERE STAT_FETAL ='TRUE' AND PA_CODE_FETAL = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC ", SqlConn)
        DA2.Fill(DT2)
        If DT2.Rows.Count > 0 Then
            For I = 0 To DT2.Rows.Count - 1
                TXT_FETAL.Text = DT2.Rows(I).Item("NAME_FETAL")
            Next
        Else
            TXT_FETAL.Text = ""
        End If

        '=================== 1st ====================================================
        Dim DT3 As New DataTable
        Dim DA3 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM ST1_TEST_TEMP WHERE STAT_ST1 ='TRUE' AND CODE_PA_ST1 = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC ", SqlConn)
        DA3.Fill(DT3)
        If DT3.Rows.Count > 0 Then
            For I = 0 To DT3.Rows.Count - 1
                st1_hb.Text = DT3.Rows(I).Item("HB_ST1")
                st1_plt.Text = DT3.Rows(I).Item("PLT_ST1")
                st1_pc.Text = DT3.Rows(I).Item("PC_ST1")
                st1_hbac.Text = DT3.Rows(I).Item("HBA1C_ST1")
                st1_tsh.Text = DT3.Rows(I).Item("TSH_ST1")
                st1_toxo.Text = DT3.Rows(I).Item("TOXO_ST1")
                st1_cmv.Text = DT3.Rows(I).Item("CMV_ST1")
                st1_rbs.Text = DT3.Rows(I).Item("RBS_ST1")
                st1_urine.Text = DT3.Rows(I).Item("URINE_ST1")
            Next
        Else
            st1_hb.Text = ""
            st1_plt.Text = ""
            st1_pc.Text = ""
            st1_hbac.Text = ""
            st1_tsh.Text = ""
            st1_toxo.Text = ""
            st1_cmv.Text = ""
            st1_rbs.Text = ""
            st1_urine.Text = ""

        End If
        '================================ 2nd ============================================
        Dim DT4 As New DataTable
        Dim DA4 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM ND2_TEST_TEMP WHERE STAT_ND2 ='TRUE' AND CODE_PA_ND2 = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC ", SqlConn)
        DA4.Fill(DT4)
        If DT1.Rows.Count > 0 Then
            For I = 0 To DT4.Rows.Count - 1
                ND2_hb.Text = DT4.Rows(I).Item("HB_ND2")
                ND2_plt.Text = DT4.Rows(I).Item("PLT_ND2")
                ND2_pc.Text = DT4.Rows(I).Item("PC_ND2")
                ND2_HOUR.Text = DT4.Rows(I).Item("HOUR_ND2")
                ND2_TOTAL.Text = DT4.Rows(I).Item("TOTAL_ND2")
                ND2_LONIZED.Text = DT4.Rows(I).Item("LONIZED_ND2")
                ND2_TSH.Text = DT4.Rows(I).Item("TSH_ND2")
                ND2_urine.Text = DT4.Rows(I).Item("URINE_ND2")
            Next
        Else
            ND2_hb.Text = ""
            ND2_plt.Text = ""
            ND2_pc.Text = ""
            ND2_HOUR.Text = ""
            ND2_TOTAL.Text = ""
            ND2_LONIZED.Text = ""
            ND2_TSH.Text = ""
            ND2_urine.Text = ""
        End If
        '================================ 3rd ============================================
        Dim DT5 As New DataTable
        Dim DA5 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM RD3_TEST_TEMP WHERE STAT_RD3 ='TRUE' AND CODE_PA_RD3 = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC ", SqlConn)
        DA5.Fill(DT5)
        If DT1.Rows.Count > 0 Then
            For I = 0 To DT5.Rows.Count - 1
                RD3_hb.Text = DT5.Rows(I).Item("HB_RD3")
                RD3_plt.Text = DT5.Rows(I).Item("PLT_RD3")
                RD3_pc.Text = DT5.Rows(I).Item("PC_RD3")
                RD3_SGPT.Text = DT5.Rows(I).Item("SGPT_RD3")
                RD3_CREAT.Text = DT5.Rows(I).Item("CREAT_RD3")
                RD3_HOUR.Text = DT5.Rows(I).Item("HOUR_RD3")
                RD3_TSH.Text = DT5.Rows(I).Item("TSH_RD3")
                RD3_rbs.Text = DT5.Rows(I).Item("RBS_RD3")
                RD3_urine.Text = DT5.Rows(I).Item("URINE_RD3")
            Next
        Else
            RD3_hb.Text = ""
            RD3_plt.Text = ""
            RD3_pc.Text = ""
            RD3_SGPT.Text = ""
            RD3_CREAT.Text = ""
            RD3_HOUR.Text = ""
            RD3_TSH.Text = ""
            RD3_rbs.Text = ""
            RD3_urine.Text = ""
        End If
    End Sub

    Private Sub TXT_PA_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_PA_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PERSONAL_HISTORY_V_2 WHERE PA_NAME ='" & TXT_PA_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA_CODE.Text = DT.Rows(I).Item("PA_CODE")
            TXT_AGE.Text = DT.Rows(I).Item("PA_AGE")
            TXT_NAME2.Text = DT.Rows(I).Item("PA_NAME2")
            TXT_CODE2.Text = DT.Rows(I).Item("PA_CODE2")
            TXT_DATE_MARRIED.Text = DT.Rows(I).Item("DATE_MARED_PERS")
            TXT_DATE_LMP.Text = DT.Rows(I).Item("LMP_PERS")
            TXT_DATE_EDD.Text = DT.Rows(I).Item("EDP_PERS")
            TXT_RH.Text = DT.Rows(I).Item("RH_PERS")
            TXT_ABO.Text = DT.Rows(I).Item("ABO_PERS")
        Next
        '=================================================================================
        '=========================================================================================================
        T_CHANG.Enabled = True
    End Sub

    Private Sub ALL_Prescription_Click(sender As Object, e As EventArgs) Handles ALL_Prescription.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("PLEASE ENTER THE NAME PATIENT ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM HISTORY_PATION WHERE R_STAT ='TRUE' AND R_CODE_PA = '" & TXT_PA_CODE.Text & "' AND R_CODE_DOC='1'", SqlConn)
            DA.Fill(DT)

            Dim REP As New HISTORY_PATION_CRS
            REP.SetDataSource(DT)
            Dim FRM As New HISTORY_PATION_FRM_REP
            FRM.CrystalReportViewer1.ReportSource = REP
            FRM.ShowDialog()
        End If
    End Sub
End Class