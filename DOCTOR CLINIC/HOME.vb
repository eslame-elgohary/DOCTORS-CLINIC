Imports System.ComponentModel

Public Class HOME
    Private Sub HOME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        open_connection()
        Timer1.Start()
        T_DATE.Text = Date.Today
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        T_TIME.Text = TimeOfDay
        T_DATE.Text = Date.Today
        ESLAME()
        MACHINBTN.Text = My.Computer.Name
        MASSEG()

    End Sub
    Sub ESLAME()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT TOP 1 REALY_NAME FROM ESLAME_LO WHERE MA='" & My.Computer.Name & "' ORDER BY ID DESC ", SqlConn)
        DA.Fill(DT)
        Dim SHOW_ As String = BindingContext(DT).Position
        T_USERS.Text = DT.Rows(SHOW_).Item("REALY_NAME")

        Dim DT1 As New DataTable
        Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM ESLAME WHERE REAL_NAME = '" & T_USERS.Text & "'", SqlConn)
        DA1.Fill(DT1)
        For S = 0 To DT1.Rows.Count - 1
            CODE_USERBT.Text = DT1.Rows(S).Item("CODE_USER")
        Next

    End Sub
    Sub MASSEG()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT TOP 1 MASSSS FROM TP_MASEG WHERE CODE_U='" & CODE_USERBT.Text & "' ORDER BY ID DESC ", SqlConn)
        DA.Fill(DT)

        Dim SHOW2_ As String = BindingContext(DT).Position
        If DT.Rows.Count = 0 Then
            MASEGETXT.Visible = False
            MASEGETXT.Text = ""
        Else
            MASEGETXT.Visible = True
            MASEGETXT.Text = DT.Rows(SHOW2_).Item("MASSSS")
        End If
    End Sub
    Private Sub STB_EXIT_Click(sender As Object, e As EventArgs) Handles STB_EXIT.Click
        If MessageBox.Show("هل ترغب فى عمل نسخة أحتياطية للبرنامج ؟", "رسالة تنبيه", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                ROLES("UP", BACKUPFRM)
            Catch EX As Exception
            End Try
        End If

        Me.Close()
    End Sub

    Private Sub BT_EXIT_Click(sender As Object, e As EventArgs) Handles BT_EXIT.Click
        Me.Close()
    End Sub

    Private Sub REGBTN_Click(sender As Object, e As EventArgs) Handles REGBTN.Click

        ROWHA.ShowDialog()
    End Sub

    Private Sub MASSEGADMIN_BTN_Click(sender As Object, e As EventArgs) Handles MASSEGADMIN_BTN.Click
        MASSEGADMIN.ShowDialog()
    End Sub

    Private Sub BT_PATIONT_Click(sender As Object, e As EventArgs) Handles BT_PATIONT.Click
        Try
            ROLES("A", PATIENT)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub HOME_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.A Then
            BT_PATIONT_Click(sender, e)
        End If
        If e.KeyCode = Keys.B Then
            BT_DOCTORS_Click(sender, e)
        End If
        If e.KeyCode = Keys.C Then
            TKHASOSBTN_Click(sender, e)
        End If
        If e.KeyCode = Keys.F1 Then
            HELPBTN_Click(sender, e)
        End If
        If e.KeyCode = Keys.D Then
            BT_PHARM_Click(sender, e)
        End If
        If e.KeyCode = Keys.E Then
            BT_GOR3A_Click(sender, e)
        End If
        If e.KeyCode = Keys.F Then
            BT_MAML_Click(sender, e)
        End If
        If e.KeyCode = Keys.G Then
            BT_THALEL_Click(sender, e)
        End If
        If e.KeyCode = Keys.H Then
            BT_PRICE_THALIL_Click(sender, e)
        End If
        If e.KeyCode = Keys.I Then
            BT_USERS_Click(sender, e)
        End If
        If e.KeyCode = Keys.J Then
            BT_USERS_DT_Click(sender, e)
        End If
        If e.KeyCode = Keys.K Then
            BTN_ADD_T3AKODAT_Click(sender, e)
        End If
        If e.KeyCode = Keys.L Then
            BT_KHAZINA_Click(sender, e)
        End If
        If e.KeyCode = Keys.M Then
            BT_CONVERT_KHAZINA_Click(sender, e)
        End If
        If e.KeyCode = Keys.N Then
            BT_MASROUF_Click(sender, e)
        End If
        If e.KeyCode = Keys.F6 Then
            BT_ADDMONY_DOCTOR_Click(sender, e)
        End If
        If e.KeyCode = Keys.F7 Then
            BT_ADDMONY_MAML_Click(sender, e)
        End If
        If e.KeyCode = Keys.F10 Then
            BT_SALE_FATO_Click(sender, e)
        End If
        If e.KeyCode = Keys.F12 Then
            BT_RESALE_FATO_Click(sender, e)
        End If




    End Sub

    Private Sub BT_DOCTORS_Click(sender As Object, e As EventArgs) Handles BT_DOCTORS.Click
        Try
            ROLES("B", DOCTORSFRM)
        Catch EX As Exception

        End Try

    End Sub

    Private Sub TKHASOSBTN_Click(sender As Object, e As EventArgs) Handles TKHASOSBTN.Click
        Try
            ROLES("C", TKHASOS)
        Catch EX As Exception

        End Try

    End Sub

    Private Sub BT_PHARM_Click(sender As Object, e As EventArgs) Handles BT_PHARM.Click
        Try
            ROLES("D", PHARM)
        Catch EX As Exception

        End Try

    End Sub

    Private Sub BT_GOR3A_Click(sender As Object, e As EventArgs) Handles BT_GOR3A.Click
        Try
            ROLES("E0", GOR3AFRM)
        Catch EX As Exception

        End Try

    End Sub

    Private Sub BT_THALEL_Click(sender As Object, e As EventArgs) Handles BT_THALEL.Click
        Try
            ROLES("G", THALELFRM)
        Catch EX As Exception

        End Try

    End Sub

    Private Sub BT_PRICE_THALIL_Click(sender As Object, e As EventArgs) Handles BT_PRICE_THALIL.Click
        Try
            ROLES("H", PRICE_THL_FRM)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub BT_MAML_Click(sender As Object, e As EventArgs) Handles BT_MAML.Click

        Try
            ROLES("F", MAMLFRM)
        Catch EX As Exception

        End Try

    End Sub

    Private Sub BT_PATENT_REP_Click(sender As Object, e As EventArgs) Handles BT_PATENT_REP.Click
        PATIENT_REP.ShowDialog()
    End Sub

    Private Sub BT_USERS_Click(sender As Object, e As EventArgs) Handles BT_USERS.Click
        Try
            ROLES("I", USERSFRM)
        Catch EX As Exception

        End Try

    End Sub

    Private Sub BT_USERS_DT_Click(sender As Object, e As EventArgs) Handles BT_USERS_DT.Click
        Try
            ROLES("J", USERSLAHFRM)
        Catch EX As Exception

        End Try

    End Sub
    Private Sub BT_KHAZINA_Click(sender As Object, e As EventArgs) Handles BT_KHAZINA.Click
        Try
            ROLES("L", KHAZINAFRM)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub BT_ADDMONY_Click(sender As Object, e As EventArgs) Handles BT_ADDMONY.Click

    End Sub

    Private Sub BT_MASROUF_Click(sender As Object, e As EventArgs) Handles BT_MASROUF.Click
        Try
            ROLES("N", MASROF)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub BT_ADDMONY_DOCTOR_Click(sender As Object, e As EventArgs) Handles BT_ADDMONY_DOCTOR.Click
        Try
            ROLES("M", ADD_MONY_DOCTOR)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub BT_MASROF_DT_Click(sender As Object, e As EventArgs) Handles BT_MASROF_DT.Click
        Try
            ROLES("O", SARF_MASRUF_FRM)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub BT_JOGOUT_Click(sender As Object, e As EventArgs) Handles BT_JOGOUT.Click
        LOGIN.Show()
        Me.Close()
    End Sub

    Private Sub BT_SALE_FATO_Click(sender As Object, e As EventArgs) Handles BT_SALE_FATO.Click
        Try
            ROLES("P", ELAG_FRM)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub BT_ADDMONY_MAML_Click(sender As Object, e As EventArgs) Handles BT_ADDMONY_MAML.Click
        Try
            ROLES("M", ADD_MONY_MAML)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub BT_CONVERT_KHAZINA_Click(sender As Object, e As EventArgs) Handles BT_CONVERT_KHAZINA.Click
        Try
            ROLES("R", CONVERT_KHAZINA_FRM)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub BTL_CONVERTKHAZINA_Click(sender As Object, e As EventArgs) Handles BTL_CONVERTKHAZINA.Click
        Try
            ROLES("R", CONVERT_KHAZINA_FRM)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub BT_TSWIA_Click(sender As Object, e As EventArgs) Handles BT_TSWIA.Click
        TSWIA_KHAZINA.ShowDialog()
    End Sub

    Private Sub BT_RESALE_FATO_Click(sender As Object, e As EventArgs) Handles BT_RESALE_FATO.Click
        Try
            ROLES("R", THLEL_FRM_ROSHTA)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub STB_RESALSE_Click(sender As Object, e As EventArgs) Handles STB_RESALSE.Click
        HAGEZ_PATEINT.ShowDialog()
    End Sub

    Private Sub BTNBACKUP_Click(sender As Object, e As EventArgs) Handles BTNBACKUP.Click
        Try
            ROLES("UP", BACKUPFRM)
        Catch EX As Exception
        End Try

    End Sub

    Private Sub BTN_REP_KHAZINA_Click(sender As Object, e As EventArgs) Handles BTN_REP_KHAZINA.Click
        REPORT_KHAZINAFRM.ShowDialog()
    End Sub

    Private Sub BTN_ZIARAFRM_Click(sender As Object, e As EventArgs) Handles BTN_ZIARAFRM.Click
        ZIARAFRM.ShowDialog()
    End Sub

    Private Sub STB_SALSE_Click(sender As Object, e As EventArgs) Handles STB_SALSE.Click
        ZIARAFRM.ShowDialog()
    End Sub

    Private Sub HELPBTN_Click(sender As Object, e As EventArgs) Handles HELPBTN.Click
        HELPFRM.ShowDialog()
    End Sub

    Private Sub LABTOLABToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LABTOLABToolStripMenuItem.Click
        LABTOLAB_V.ShowDialog()
    End Sub

    Private Sub BT_HESAP_DOC_FRM_Click(sender As Object, e As EventArgs) Handles BT_HESAP_DOC_FRM.Click
        HESAP_DOCTORSFRM.ShowDialog()
    End Sub

    Private Sub BT_SMS_Click(sender As Object, e As EventArgs) Handles BT_SMS.Click
        MASSEGADMIN.ShowDialog()
    End Sub

    Private Sub BTN_ADD_MONY_DOCT_Click(sender As Object, e As EventArgs) Handles BTN_ADD_MONY_DOCT.Click
        Try
            ROLES("M", ADD_MONY_DOCTOR)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub BT_ADDTHLEL_PATION_Click(sender As Object, e As EventArgs) Handles BT_ADDTHLEL_PATION.Click
        Try
            ROLES("Q20", ADDTHLELMAMLPAFRM)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Try
            ROLES("M", ADD_MONY_MAML)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub BTN_PA_HESAPFRM_Click(sender As Object, e As EventArgs) Handles BTN_PA_HESAPFRM.Click
        PA_HESAP_FRM.ShowDialog()
    End Sub

    Private Sub BTN_PA_DOF3A_Click(sender As Object, e As EventArgs) Handles BTN_PA_DOF3A.Click
        Try
            ROLES("Q", DOF3A_PATION_FRM)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub BTN_ADD_THLELFORPATION_Click(sender As Object, e As EventArgs) Handles BTN_ADD_THLELFORPATION.Click
        Try
            ROLES("Q20", ADDTHLELMAMLPAFRM)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub FffffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FffffToolStripMenuItem.Click
        Try
            ROLES("N100", womencliniccomplinfrm)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub PERSONALHISTORYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PERSONALHISTORYToolStripMenuItem.Click
        Try
            ROLES("M100", PERSONAL_HISTORY_FRM)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub PFOLOWUPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PFOLOWUPToolStripMenuItem.Click
        Try
            ROLES("S100", FOLLOWUPFRM)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub FOLOWUPCARDCLOSEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FOLOWUPCARDCLOSEToolStripMenuItem.Click

        Try
            ROLES("S100", REP_FOLOWUP_CLOSE)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub PERSONALHISTORYFORINFERTILITYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PERSONALHISTORYFORINFERTILITYToolStripMenuItem.Click
        Try
            ROLES("M100", HISTORY_ENGAB)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub INFERTILITYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INFERTILITYToolStripMenuItem.Click
        Try
            ROLES("S100", ENGABFRM)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub REP_HAGEZ_PA_Click(sender As Object, e As EventArgs) Handles REP_HAGEZ_PA.Click
        REP_HAGEZ.ShowDialog()
    End Sub
    Private Sub BTN_HAGEZ_FRM_Click(sender As Object, e As EventArgs) Handles BTN_HAGEZ_FRM.Click
        HAGEZ_PATEINT.ShowDialog()
    End Sub

    Private Sub INFERTILITYCARDCLOSEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INFERTILITYCARDCLOSEToolStripMenuItem.Click

        Try
            ROLES("S100", REP_ENGAB_CLOSE)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub BTN_ADD_T3AKODAT_Click(sender As Object, e As EventArgs) Handles BTN_ADD_T3AKODAT.Click
        'Try
        '    ROLES("K", T3AKODATFRM)
        'Catch EX As Exception

        'End Try
        T3AQOD.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            ROLES("M", ADD_DOCTOR_T3AQOD_MONY)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub BTN_T3AQOD_ADD_MONY_DOC_Click(sender As Object, e As EventArgs) Handles BTN_T3AQOD_ADD_MONY_DOC.Click
        Try
            ROLES("M", ADD_DOCTOR_T3AQOD_MONY)
        Catch EX As Exception

        End Try
    End Sub

    Private Sub inter_control_Click(sender As Object, e As EventArgs) Handles inter_control.Click
        If IO.File.Exists("C:\Program Files (x86)\Acapela Group\Acapela Multimedia\academo.exe") Then
            Process.Start("C:\Program Files (x86)\Acapela Group\Acapela Multimedia\academo.exe")
        Else
            MessageBox.Show("هذا الجهاز غير مؤهل للتشغيل ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        test.ShowDialog()
    End Sub
End Class