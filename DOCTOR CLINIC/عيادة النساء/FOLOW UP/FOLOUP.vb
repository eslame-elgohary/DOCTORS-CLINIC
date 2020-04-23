Public Class FOLOUP
    Private Sub BTN_4D_Click(sender As Object, e As EventArgs) Handles BTN_4D.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("PLEASE ENTER THE NAME PATIENT ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            D4.ShowDialog()
        End If

    End Sub

    Private Sub BTN_FETAL_Click(sender As Object, e As EventArgs) Handles BTN_FETAL.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("PLEASE ENTER THE NAME PATIENT ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            FETAL_DOPLAR_FRM.ShowDialog()
        End If

    End Sub

    Private Sub FOLOUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEWBTN_Click(sender, e)
    End Sub
    Sub FILL_PATION()
        TXT_PA_NAME.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PERSONAL_HISTORY,PATIENT WHERE CODE_PA_PERS=PA_CODE AND STAT_PERS='TRUE' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA_NAME.Items.Add(DT.Rows(I).Item("PA_NAME"))
        Next
    End Sub
    Sub FILL_PHARM()
        TXT_PHARM.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PHARM WHERE STAT='TRUE' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PHARM.Items.Add(DT.Rows(I).Item("PH_NAME"))
        Next
    End Sub
    Sub FILL_GOR3A()
        TXT_GOR3A.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM GOR3A WHERE STAT='TRUE' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_GOR3A.Items.Add(DT.Rows(I).Item("GOR_NAME"))
        Next
    End Sub
    Sub FILL_COMPLAINT()
        TXT_COMPLAIONT.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM NESA_SHKWA WHERE STAT_NESA_SHKWA='TRUE' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_COMPLAIONT.Items.Add(DT.Rows(I).Item("NAME_NESA_SHKWA"))
        Next
    End Sub

    Private Sub TXT_PA_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_PA_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PERSONAL_HISTORY_V WHERE PA_NAME ='" & TXT_PA_NAME.Text & "'", SqlConn)
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
        Dim DT100 As New DataTable
        Dim DA100 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM FOLOWUP_DT WHERE STAT_FOLOWUP ='TRUE' AND PA_CODE_FOLOWUP = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC ", SqlConn)
        DA100.Fill(DT100)
        If DT100.Rows.Count > 0 Then
            For I = 0 To DT100.Rows.Count - 1
                TXT_DATE_LASTVISET.Text = DT100.Rows(I).Item("DATE_FOLOWUP")
                TXT_BP1.Text = DT100.Rows(I).Item("BP_FOLOWUP")
                TXT_W1.Text = DT100.Rows(I).Item("W_FOLOWUP")
                TXT_WEEK1.Text = DT100.Rows(I).Item("WEEKS_FOLOWUP")
                TXT_WEIGHT1.Text = DT100.Rows(I).Item("FET_FOLOWUP")
                TXT_LIQOUR1.Text = DT100.Rows(I).Item("LIQOUR_FOLOWUP")
                TXT_SEX1.Text = DT100.Rows(I).Item("SEX_FOLOWUP")
                TXT_PLACENTA1.Text = DT100.Rows(I).Item("PLACENTA_FOLOWUP")
            Next
            FILL_DGV(DataGridView3, "SELECT * FROM FOLOW_V WHERE STAT_FOLOWUP ='TRUE' AND DATE_FOLOWUP ='" & TXT_DATE_LASTVISET.Text & "' AND PA_CODE_FOLOWUP = '" & TXT_PA_CODE.Text & "'")
            FILL_DGV(DataGridView4, "SELECT * FROM PHARM_V WHERE R_STAT ='TRUE' AND R_DATE ='" & TXT_DATE_LASTVISET.Text & "' AND PA_CODE = '" & TXT_PA_CODE.Text & "'")
        Else
            TXT_DATE_LASTVISET.Text = Date.Today
            TXT_BP1.Text = ""
            TXT_W1.Text = ""
            TXT_WEEK1.Text = ""
            TXT_WEIGHT1.Text = ""
            TXT_LIQOUR1.Text = ""
            TXT_SEX1.Text = ""
            TXT_PLACENTA1.Text = ""
            FILL_DGV(DataGridView3, "SELECT * FROM FOLOW_V WHERE STAT_FOLOWUP ='TRUE' AND DATE_FOLOWUP ='" & TXT_DATE_LASTVISET.Text & "' AND PA_CODE_FOLOWUP = '" & TXT_PA_CODE.Text & "'")
            FILL_DGV(DataGridView4, "SELECT * FROM PHARM_V WHERE R_STAT ='TRUE' AND R_DATE ='" & TXT_DATE_LASTVISET.Text & "' AND PA_CODE = '" & TXT_PA_CODE.Text & "'")

        End If
        '=========================================================================================================
        T_CHANG.Enabled = True
        FILL_PHARM()
        FILL_COMPLAINT()
        FILL_GOR3A()
    End Sub
    Private Sub TXT_PA_CODE_TextChanged(sender As Object, e As EventArgs) Handles TXT_PA_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PERSONAL_HISTORY_V WHERE PA_CODE ='" & TXT_PA_CODE.Text & "'", SqlConn)
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
        T_CHANG.Enabled = True
        FILL_PHARM()
        FILL_COMPLAINT()
        FILL_GOR3A()
    End Sub

    Private Sub BTN_OBSTETRIC_Click(sender As Object, e As EventArgs) Handles BTN_OBSTETRIC.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("PLEASE ENTER THE NAME PATIENT ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            OBSTETRIC_HISTORY_FRM.ShowDialog()
        End If

    End Sub

    Private Sub BTN_1ST_Click(sender As Object, e As EventArgs) Handles BTN_1ST.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("PLEASE ENTER THE NAME PATIENT ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            ST1_FRM.ShowDialog()
        End If
    End Sub

    Private Sub BTN_2ND_Click(sender As Object, e As EventArgs) Handles BTN_2ND.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("PLEASE ENTER THE NAME PATIENT ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            ND2_FRM.ShowDialog()
        End If
    End Sub

    Private Sub BTN_3RD_Click(sender As Object, e As EventArgs) Handles BTN_3RD.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("PLEASE ENTER THE NAME PATIENT ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else
            RD3_FRM.ShowDialog()
        End If
    End Sub

    Private Sub BTN_BABY_Click(sender As Object, e As EventArgs) Handles BTN_BABY.Click
        If TXT_PA_CODE.Text = "" Then
            MessageBox.Show("PLEASE ENTER THE NAME PATIENT ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PA_NAME.Select()
            Exit Sub
        Else

        End If
    End Sub

    Private Sub TXT_PHARM_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_PHARM.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PHARM WHERE PH_NAME ='" & TXT_PHARM.Text & "' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_CODE_PHARM.Text = DT.Rows(I).Item("PH_CODE")
            TXT_NO3.Text = DT.Rows(I).Item("PH_NO3")
        Next
    End Sub

    Private Sub TXT_GOR3A_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_GOR3A.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM GOR3A WHERE GOR_NAME='" & TXT_GOR3A.Text & "' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_CODE_GOR3A.Text = DT.Rows(I).Item("GOR_CODE")
        Next
    End Sub

    Private Sub BTN_PHARM_Click(sender As Object, e As EventArgs) Handles BTN_PHARM.Click
        If TXT_CODE_PHARM.Text = "" Then
            MessageBox.Show("عفوا ليس هناك أدوية لاضافتها", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PHARM.Select()
        Else
            If TXT_CODE_GOR3A.Text = "" Then
                MessageBox.Show("عفوا ليس هناك جرعة للأدوية المختارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TXT_GOR3A.Select()
            Else

                Dim BAR As Integer
                '======= اضافة سجل للداتا جريد ===========
                DataGridView2.Rows.Add()
                BAR = DataGridView2.Rows.Count - 1
                DataGridView2(0, BAR).Value = TXT_CODE_PHARM.Text
                DataGridView2(1, BAR).Value = TXT_PHARM.Text
                DataGridView2(2, BAR).Value = TXT_NO3.Text
                DataGridView2(3, BAR).Value = TXT_CODE_GOR3A.Text
                DataGridView2(4, BAR).Value = TXT_GOR3A.Text

                TXT_CODE_PHARM.Text = ""
                TXT_PHARM.Text = ""
                TXT_NO3.Text = ""
                TXT_CODE_GOR3A.Text = ""
                TXT_GOR3A.Text = ""

                TXT_PHARM.Select()
            End If
        End If
    End Sub

    Private Sub TXT_COMPLAIONT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_COMPLAIONT.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM NESA_SHKWA WHERE NAME_NESA_SHKWA='" & TXT_COMPLAIONT.Text & "' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_CODE_COMPLAIONT.Text = DT.Rows(I).Item("CODE_NESA_SHKWA")
        Next
    End Sub

    Private Sub BTN_COMPLAIONT_Click(sender As Object, e As EventArgs) Handles BTN_COMPLAIONT.Click
        If TXT_CODE_COMPLAIONT.Text = "" Then
            MessageBox.Show("عفوا ليس هناك شكوي مختارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_COMPLAIONT.Select()
        Else

            Dim BAR As Integer
            '======= اضافة سجل للداتا جريد ===========
            DataGridView1.Rows.Add()
            BAR = DataGridView1.Rows.Count - 1
            DataGridView1(0, BAR).Value = TXT_CODE_COMPLAIONT.Text
            DataGridView1(1, BAR).Value = TXT_COMPLAIONT.Text


            TXT_CODE_COMPLAIONT.Text = ""
            TXT_COMPLAIONT.Text = ""

            TXT_COMPLAIONT.Select()
        End If
    End Sub

    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles NEWBTN.Click
        T_CHANG.Enabled = False
        FILL_PATION()
        TXT_4D.Text = ""
        TXT_OBSTETRIC.Text = ""
        TXT_FETAL.Text = ""
        TXT_PA_NAME.Text = ""
        TXT_CODE2.Text = ""
        TXT_DATE_MARRIED.Text = Date.Today
        TXT_DATE_EDD.Text = Date.Today
        TXT_DATE_LMP.Text = Date.Today
        TXT_DATE_TODAY.Text = Date.Today
        TXT_DATE_LASTVISET.Text = Date.Today
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        For I = 0 To GroupBox2.Controls.Count - 1
            If TypeOf GroupBox2.Controls(I) Is TextBox Then GroupBox2.Controls(I).Text = ""
        Next
        For I = 0 To GroupBox3.Controls.Count - 1
            If TypeOf GroupBox3.Controls(I) Is TextBox Then GroupBox3.Controls(I).Text = ""
        Next
        For I = 0 To GroupBox4.Controls.Count - 1
            If TypeOf GroupBox4.Controls(I) Is TextBox Then GroupBox4.Controls(I).Text = ""
        Next

        TXT_CODE_COMPLAIONT.Text = ""
        TXT_COMPLAIONT.Text = ""

        TXT_PHARM.Text = ""
        TXT_NO3.Text = ""
        TXT_CODE_PHARM.Text = ""
        TXT_GOR3A.Items.Clear()
        TXT_CODE_GOR3A.Text = ""

        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()

        FILL_DGV(DataGridView3, "SELECT * FROM FOLOW_V WHERE STAT_FOLOWUP ='TRUE' AND DATE_FOLOWUP ='" & TXT_DATE_LASTVISET.Text & "' AND PA_CODE_FOLOWUP = '" & TXT_PA_CODE.Text & "'")
        FILL_DGV(DataGridView4, "SELECT * FROM PHARM_V WHERE R_STAT ='TRUE' AND R_DATE ='" & TXT_DATE_LASTVISET.Text & "' AND PA_CODE = '" & TXT_PA_CODE.Text & "'")


        TXT_BP.Text = ""
        TXT_W.Text = ""
        TXT_WEEK.Text = ""
        TXT_WIGHT.Text = ""
        TXT_LIQPUR.Text = ""
        TXT_SEX.SelectedIndex = 0
        TXT_PLACENTA.Text = ""

        TXT_BP1.Text = ""
        TXT_W1.Text = ""
        TXT_WEEK1.Text = ""
        TXT_WEIGHT1.Text = ""
        TXT_LIQOUR1.Text = ""
        TXT_SEX1.Text = ""
        TXT_PLACENTA1.Text = ""
        '=====================================================
        TXT_CODE.Text = CODE_GENE("FOLOWUP_DT", "ID") + 1
        '========================================================

        TXT_PA_NAME.Select()

    End Sub

    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("S101").ToString = True Then

                If TXT_PA_CODE.Text = "" Then
                    MessageBox.Show("PLEASE ENTER THE NAME PATIENT ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_PA_NAME.Select()
                    Exit Sub
                End If
                If Not TXT_DATE_TODAY.Text = Date.Today Then
                    If MessageBox.Show("Today's date does not match. Do you want to change? ", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.Yes Then TXT_DATE_TODAY.Select() Exit Sub
                End If

                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM FOLOWUP_DT ", SqlConn)
                DA.Fill(DT)
                Dim DR = DT.NewRow
                DR!DATE_FOLOWUP = TXT_DATE_TODAY.Text
                DR!CODE_FOLOWUP = TXT_CODE.Text
                DR!PA_CODE_FOLOWUP = TXT_PA_CODE.Text
                DR!BP_FOLOWUP = TXT_BP.Text
                DR!W_FOLOWUP = TXT_W.Text
                DR!WEEKS_FOLOWUP = TXT_WEEK.Text
                DR!FET_FOLOWUP = TXT_WIGHT.Text
                DR!LIQOUR_FOLOWUP = TXT_LIQPUR.Text
                DR!SEX_FOLOWUP = TXT_SEX.Text
                DR!PLACENTA_FOLOWUP = TXT_PLACENTA.Text
                DR!STAT_FOLOWUP = True
                DT.Rows.Add(DR)
                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                '=================================================
                Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM FOLOWUP_DTELS", SqlConn)
                DA1.Fill(DT)
                If DataGridView1.Rows.Count > 0 Then
                    For I = 0 To DataGridView1.Rows.Count - 1
                        Dim DR1 = DT.NewRow
                        DR1!CODE_FOLOWUP_DS = TXT_CODE.Text
                        DR1!DATE_FOLOWUP_DS = TXT_DATE_TODAY.Text
                        DR1!PA_CODE_FOLOWUP_DS = TXT_PA_CODE.Text
                        DR1!FOLOWUP_DS_CODE_SHKWA = DataGridView1.Rows(I).Cells(0).Value
                        DR1!STAT_FOLOWUP_DS = True
                        DT.Rows.Add(DR1)
                        Dim CMD_ As New SqlClient.SqlCommandBuilder(DA1)
                        DA1.Update(DT)
                    Next
                End If
                '=================================================================================
                Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM R_DOCTOR", SqlConn)
                DA2.Fill(DT)
                If DataGridView2.Rows.Count > 0 Then

                    Dim DR2 = DT.NewRow
                    DR2!R_CODE = TXT_CODE100.Text
                    DR2!R_CODE_FOLOWUP = TXT_CODE.Text
                    DR2!R_DATE = TXT_DATE_TODAY.Text
                    DR2!R_CODE_DOC = "1"
                    DR2!R_CODE_PA = TXT_PA_CODE.Text
                    DR2!R_HRARA = "0"
                    DR2!R_D = "0"
                    DR2!R_KG = "0"
                    DR2!R_INFO = "متابعة حمل"
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
                    For I = 0 To DataGridView2.Rows.Count - 1
                        Dim DR3 = DT.NewRow
                        DR3!R_CODE_DT = TXT_CODE100.Text
                        DR3!R_DATE = TXT_DATE_TODAY.Text
                        DR3!R_DT_CODE = DataGridView2.Rows(I).Cells(0).Value
                        DR3!R_DT_PHARM = DataGridView2.Rows(I).Cells(1).Value
                        DR3!R_DT_NO3 = DataGridView2.Rows(I).Cells(2).Value
                        DR3!R_DT_CODE2 = DataGridView2.Rows(I).Cells(3).Value
                        DR3!R_DT_GOR3A = DataGridView2.Rows(I).Cells(4).Value
                        DR3!STAT_DT = True
                        DT.Rows.Add(DR3)
                        Dim CMD1_ As New SqlClient.SqlCommandBuilder(DA3)
                        DA3.Update(DT)
                    Next
                End If

                MessageBox.Show("تمت عملية الحفظ بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                NEWBTN_Click(sender, e)

            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub EDITBTN_Click(sender As Object, e As EventArgs) Handles EDITBTN.Click

    End Sub

    Private Sub DELETBTN_Click(sender As Object, e As EventArgs) Handles DELETBTN.Click

    End Sub

    Private Sub SEARCHBTN_Click(sender As Object, e As EventArgs) Handles SEARCHBTN.Click

    End Sub

    Private Sub BTN_PRESCRIPTION_Click(sender As Object, e As EventArgs) Handles BTN_PRESCRIPTION.Click

    End Sub

    Private Sub BTN_FOLOWUP_Click(sender As Object, e As EventArgs) Handles BTN_FOLOWUP.Click

    End Sub

    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub

    Private Sub T_CHANG_Tick(sender As Object, e As EventArgs) Handles T_CHANG.Tick
        '======================== 4D ===============================
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM E4D_HISTORY WHERE STAT_4D ='TRUE' AND PA_CODE_4D = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC  ", SqlConn)
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
        Dim DA1 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM OBSTETRIC_HISTORY WHERE STAT_OBSTETRIC ='TRUE' AND PA_CODE_OBSTETRIC = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC ", SqlConn)
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
        Dim DA2 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM FETAL_HISTORY WHERE STAT_FETAL ='TRUE' AND PA_CODE_FETAL = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC ", SqlConn)
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
        Dim DA3 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM ST1_TEST WHERE STAT_ST1 ='TRUE' AND CODE_PA_ST1 = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC ", SqlConn)
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
        Dim DA4 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM ND2_TEST WHERE STAT_ND2 ='TRUE' AND CODE_PA_ND2 = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC ", SqlConn)
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
        Dim DA5 As New SqlClient.SqlDataAdapter(" SELECT TOP 1 * FROM RD3_TEST WHERE STAT_RD3 ='TRUE' AND CODE_PA_RD3 = '" & TXT_PA_CODE.Text & "' ORDER BY ID DESC ", SqlConn)
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
        TXT_CODE100.Text = CODE_GENE("R_DOCTOR", "ID") + 1
    End Sub

    Private Sub TXT_CODE_PHARM_TextChanged(sender As Object, e As EventArgs) Handles TXT_CODE_PHARM.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PHARM WHERE PH_CODE ='" & TXT_CODE_PHARM.Text & "' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PHARM.Text = DT.Rows(I).Item("PH_NAME")
            TXT_NO3.Text = DT.Rows(I).Item("PH_NO3")
        Next
    End Sub

    Private Sub TXT_CODE_GOR3A_TextChanged(sender As Object, e As EventArgs) Handles TXT_CODE_GOR3A.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM GOR3A WHERE GOR_CODE='" & TXT_CODE_GOR3A.Text & "' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_GOR3A.Text = DT.Rows(I).Item("GOR_NAME")
        Next
    End Sub

    Private Sub TXT_CODE_COMPLAIONT_TextChanged(sender As Object, e As EventArgs) Handles TXT_CODE_COMPLAIONT.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM NESA_SHKWA WHERE CODE_NESA_SHKWA='" & TXT_CODE_COMPLAIONT.Text & "' ", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_COMPLAIONT.Text = DT.Rows(I).Item("NAME_NESA_SHKWA")
        Next
    End Sub
End Class