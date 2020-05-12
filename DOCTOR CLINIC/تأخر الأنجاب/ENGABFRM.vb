Public Class ENGABFRM

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