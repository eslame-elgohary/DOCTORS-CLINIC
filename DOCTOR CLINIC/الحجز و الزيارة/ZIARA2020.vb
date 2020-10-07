Public Class ZIARA2020
    Private Sub BTN_TAKED_Click(sender As Object, e As EventArgs) Handles BTN_TAKED.Click
        If TXT_TKHASOS_CODE.Text = "" Then
            MessageBox.Show("يرجى أختيار العيادة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_TKHSOS.Select()
            Exit Sub
        End If

        If TXT_DOCTOR_CODE.Text = "" Then
            MessageBox.Show("يرجى أختيار الطبيب ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Sub DATEF()
        Dim DATEDAY As Date
        Dim DATELAST As Date
        Dim FDATE As Integer
        DATEDAY = TXT_DATE_TODAY.Value
        DATELAST = TXT_DATE.Value
        FDATE = DateDiff(DateInterval.Day, DATELAST, DATEDAY)
        TXT_DAY.Text = FDATE
    End Sub

    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles NEWBTN.Click
        G_EDIT.Visible = False
        EDITBTN.Visible = True
        CH_TEL.Checked = True
        CH_TEL.Visible = True
        CH_TEL_AQAREP.Checked = True
        CH_TEL_AQAREP.Visible = True
        SAVEBTN.Visible = True
        BTN_CHANG.Visible = True
        BTN_TAKED.Visible = True
        P_CHANG.Visible = False
        GroupBox1.Enabled = True
        TRQEM_AUTO()

        '======================== تنظيف الشاشة ==============================
        PA_NAME.Text = ""
        PA_NAME.Select()
        TXT_TEL.Text = ""
        TXT_ADRRES.Text = ""
        TXT_FILL.Text = ""
        TXT_TEL_AQAREP.Text = ""
        TXT_HUSBEND.Text = ""
        '======================================

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
        End If
        DOC_NAME.Text = TXT_DOCTOR.Text
        DOC_NAME_P3.Text = TXT_DOCTOR.Text
    End Sub

    Private Sub CH_DATE_CheckedChanged(sender As Object, e As EventArgs) Handles CH_DATE.CheckedChanged
        If CH_DATE.Checked = True Then
            TXT_DATE.Enabled = False
        Else
            TXT_DATE.Enabled = True
            CH_DATE.Visible = False
        End If

    End Sub

    Private Sub PA_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PA_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME = '" & PA_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_CODE_PA.Text = DT.Rows(I).Item("PA_CODE")
            TXT_TEL.Text = DT.Rows(I).Item("PA_TEL")
            TXT_FILL.Text = DT.Rows(I).Item("PA_CODE2")
            TXT_TEL_AQAREP.Text = DT.Rows(I).Item("PA_TEL2")
            TXT_HUSBEND.Text = DT.Rows(I).Item("PA_NAME2")
            DELET_20.Text = DT.Rows(I).Item("WALID")
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
        TXT_ADRRES.Text = ""
        TXT_FILL.Text = ""
        TXT_HUSBEND.Text = ""
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
        TXT_ADRRES.Text = ""
        TXT_FILL.Text = ""
        TXT_TEL_AQAREP.Text = ""
        TXT_HUSBEND.Text = ""
        '============================================================
        BTN_CHANG.Visible = False
        G_EDIT.Visible = True
        EDITBTN.Visible = False
        CH_TEL2.Checked = True
        CH_TEL2.Visible = True
        CH_TEL_AQAREP2.Checked = True
        CH_TEL_AQAREP2.Visible = True
        GroupBox1.Enabled = False
        SAVEBTN.Visible = False

        '======================== تنظيف الشاشة ==============================
        PA_NAME2.Text = ""
        PA_NAME2.Select()
        TXT_TEL2.Text = ""
        TXT_ADRRES2.Text = ""
        TXT_FILL2.Text = ""
        TXT_ID.Text = ""
        TXT_CODE2.Text = ""
        TXT_TEL_AQAREP2.Text = ""
        TXT_HUSBEND2.Text = ""
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
        DATEF()
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("M1").ToString = True Then
                If DT0.Rows(0).Item("M3").ToString = False Then
                    If Val(TXT_DAY.Text) >= Val(TXT_DAY2.Text) Then
                        MessageBox.Show("لا يمكن الحجز لمريض بتاريخ سابق")
                        TXT_DATE.Select()
                        Exit Sub
                    End If
                End If
                If TXT_CODE_PA.Text = "" Then
                    MessageBox.Show("يرجى أختيار أسم المريض ")
                    PA_NAME.Select()
                    Exit Sub
                End If
                If Not DELET_20.Text = " " Then
                    MessageBox.Show("عفوا ممنوع الحجز لهذا المريض ")
                    PA_NAME.Select()
                    Exit Sub
                End If
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE DOCTORS_CODE = '" & TXT_DOCTOR_CODE.Text & "' AND DATE_HAGEZ='" & TXT_DATE.Text & "' AND PA_CODE = '" & TXT_CODE_PA.Text & "' ", SqlConn)
                DA.Fill(DT)
                If DT.Rows.Count > 0 Then
                    MessageBox.Show("يوجد حجز اخر لهذا المريض فى نفس اليوم لنفس الطبيب يرجي التأكد", "أنتبة", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    PA_NAME.Select()
                    Exit Sub
                Else
                    If CH_TEL.Checked = False Or CH_TEL_AQAREP.Checked = False Then
                        If MessageBox.Show("هل ترغب فى تعديل رقم الهاتف للمريض", "أنتبة", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then
                            TRQEM_AUTO()
                            Dim DR = DT.NewRow
                            DR!TKHASOS_CODE = TXT_TKHASOS_CODE.Text
                            DR!DOCTORS_CODE = TXT_DOCTOR_CODE.Text
                            DR!DATE_HAGEZ = TXT_DATE.Text
                            DR!PA_CODE = TXT_CODE_PA.Text
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
                        Else
                            TRQEM_AUTO()
                            Dim DR = DT.NewRow
                            DR!TKHASOS_CODE = TXT_TKHASOS_CODE.Text
                            DR!DOCTORS_CODE = TXT_DOCTOR_CODE.Text
                            DR!DATE_HAGEZ = TXT_DATE.Text
                            DR!PA_CODE = TXT_CODE_PA.Text
                            DR!ADRRES = TXT_ADRRES.Text
                            DR!CODE_HAGEZ = TXT_CODE.Text
                            DR!ADD_USER = HOME.T_USERS.Text
                            DR!DATE_ADD_USER = Date.Now
                            DR!STAT_COLORE = "0"
                            DR!INFO_STAT = " "
                            DT.Rows.Add(DR)
                            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                            DA.Update(DT)

                            '==================================================================

                            Dim DT2 As New DataTable
                            Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_CODE = '" & TXT_CODE_PA.Text & "' ", SqlConn)
                            DA2.Fill(DT2)
                            Dim DR2 = DT2.Rows(0)
                            DR2!PA_TEL = TXT_TEL.Text
                            DR2!PA_TEL2 = TXT_TEL_AQAREP.Text
                            Dim SAVE2 As New SqlClient.SqlCommandBuilder(DA2)
                            DA2.Update(DT2)

                            MessageBox.Show("تمت عملية حفظ بيانات الحجز وتعديل رقم الهاتف بنجاح ورقم الحجز هو " & ">>>> " & TXT_CODE.Text, "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            NEWBTN_Click(sender, e)
                        End If
                    Else
                        TRQEM_AUTO()
                        Dim DR = DT.NewRow
                        DR!TKHASOS_CODE = TXT_TKHASOS_CODE.Text
                        DR!DOCTORS_CODE = TXT_DOCTOR_CODE.Text
                        DR!DATE_HAGEZ = TXT_DATE.Text
                        DR!PA_CODE = TXT_CODE_PA.Text
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
                    End If
                End If
            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub PA_NAME2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PA_NAME2.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME = '" & PA_NAME2.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_CODE_PA2.Text = DT.Rows(I).Item("PA_CODE")
            TXT_TEL2.Text = DT.Rows(I).Item("PA_TEL")
            TXT_FILL2.Text = DT.Rows(I).Item("PA_CODE2")
            TXT_TEL_AQAREP2.Text = DT.Rows(I).Item("PA_TEL2")
            TXT_HUSBEND2.Text = DT.Rows(I).Item("PA_NAME2")
        Next
        Dim DT1 As New DataTable
        Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE PA_CODE ='" & TXT_CODE_PA2.Text & "' AND DATE_HAGEZ='" & TXT_DATE.Text & "' AND DOCTORS_CODE='" & TXT_DOCTOR_CODE.Text & "' ", SqlConn)
        DA1.Fill(DT1)

        For I1 = 0 To DT1.Rows.Count - 1
            TXT_ADRRES2.Text = DT1.Rows(I1).Item("ADRRES")
            TXT_ID.Text = DT1.Rows(I1).Item("ID")
            TXT_CODE2.Text = DT1.Rows(I1).Item("CODE_HAGEZ")
        Next
    End Sub

    Private Sub G_EDITBTN_Click(sender As Object, e As EventArgs) Handles G_EDITBTN.Click
        If TXT_CODE_PA2.Text = "" Then
            MessageBox.Show("يرجى أختيار أسم المريض ")
            PA_NAME2.Select()
            Exit Sub
        End If
        If CH_TEL2.Checked = False Or CH_TEL_AQAREP2.Checked = False Then
            If MessageBox.Show("هل ترغب فى تعديل رقم الهاتف للمريض", "أنتبة", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then

                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID.Text & "'", SqlConn)
                DA.Fill(DT)
                Dim DR = DT.Rows(0)
                DR!TKHASOS_CODE = TXT_TKHASOS_CODE.Text
                DR!DOCTORS_CODE = TXT_DOCTOR_CODE.Text
                DR!DATE_HAGEZ = TXT_DATE.Text
                DR!PA_CODE = TXT_CODE_PA2.Text
                ' DR!ACTION = TXT_ACTION2.Text
                ' DR!PRICE_ACTION = TXT_ACTION_PRIC2.Text
                DR!ADRRES = TXT_ADRRES2.Text
                DR!CODE_HAGEZ = TXT_CODE2.Text
                DR!EDIT_USER = HOME.T_USERS.Text
                DR!DATE_EDIT_USER = Date.Now

                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                MessageBox.Show("تمت عملية تعديل بيانات الحجز بنجاح لرقم الحجز  " & ">>>> " & TXT_CODE2.Text, "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID.Text & "'", SqlConn)
                DA.Fill(DT)
                Dim DR = DT.Rows(0)
                DR!TKHASOS_CODE = TXT_TKHASOS_CODE.Text
                DR!DOCTORS_CODE = TXT_DOCTOR_CODE.Text
                DR!DATE_HAGEZ = TXT_DATE.Text
                DR!PA_CODE = TXT_CODE_PA2.Text
                DR!ADRRES = TXT_ADRRES2.Text
                DR!CODE_HAGEZ = TXT_CODE2.Text
                DR!EDIT_USER = HOME.T_USERS.Text
                DR!DATE_EDIT_USER = Date.Now

                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)

                Dim DT2 As New DataTable
                Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_CODE = '" & TXT_CODE_PA2.Text & "' ", SqlConn)
                DA2.Fill(DT2)
                Dim DR2 = DT2.Rows(0)
                DR2!PA_TEL = TXT_TEL2.Text
                DR2!PA_TEL2 = TXT_TEL_AQAREP2.Text
                Dim SAVE2 As New SqlClient.SqlCommandBuilder(DA2)
                DA2.Update(DT2)

                MessageBox.Show("تمت عملية تعديل بيانات الحجز بنجاح لرقم الحجز  " & ">>>> " & TXT_CODE2.Text, "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID.Text & "'", SqlConn)
            DA.Fill(DT)
            Dim DR = DT.Rows(0)
            DR!TKHASOS_CODE = TXT_TKHASOS_CODE.Text
            DR!DOCTORS_CODE = TXT_DOCTOR_CODE.Text
            DR!DATE_HAGEZ = TXT_DATE.Text
            DR!PA_CODE = TXT_CODE_PA2.Text
            DR!ADRRES = TXT_ADRRES2.Text
            DR!CODE_HAGEZ = TXT_CODE2.Text
            DR!EDIT_USER = HOME.T_USERS.Text
            DR!DATE_EDIT_USER = Date.Now

            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            MessageBox.Show("تمت عملية تعديل بيانات الحجز بنجاح لرقم الحجز  " & ">>>> " & TXT_CODE2.Text, "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        '==================== تنظيف الشاشة =================================
        PA_NAME2.Text = ""
        TXT_TEL2.Text = ""
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
            '  TXT_NAME1_ACTION.Text = DT.Rows(I).Item("ACTION")
            '  TXT_NAME1_PRICE.Text = DT.Rows(I).Item("PRICE_ACTION")
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
            ' TXT_NAME2_ACTION.Text = DT.Rows(I).Item("ACTION")
            ' TXT_NAME2_PRICE.Text = DT.Rows(I).Item("PRICE_ACTION")
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
                                 dbo.HAGEZ.CODE_HAGEZ, dbo.HAGEZ.STAT_COLORE, dbo.HAGEZ.INFO_STAT, dbo.HAGEZ.PA_CODE 
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
                TXT_PA_CODE_H.Text = r.Cells.Item(8).Value
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

                '===================== التاكد من ان المريض ليس معمول له فاتورة من قبل ==========================
                Dim DA112 As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID_H.Text & "' AND STAT_COLORE = '2'", SqlConn)
                Dim DT112 As New DataTable
                DA112.Fill(DT112)
                If DT112.Rows.Count > 0 Then
                    MessageBox.Show("المريض له أيصال نقدية ولا يمكن التعديل عليه", "أنتبة", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Dim DA111 As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID_H.Text & "' AND STAT_COLORE = '3'", SqlConn)
                Dim DT111 As New DataTable
                DA111.Fill(DT111)
                If DT111.Rows.Count > 0 Then
                    MessageBox.Show("المريض له أيصال نقدية ولا يمكن التعديل عليه", "أنتبة", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If


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
            '===================== التاكد من ان المريض ليس معمول له فاتورة من قبل ==========================
            Dim DA112 As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID_H.Text & "' AND STAT_COLORE = '2'", SqlConn)
            Dim DT112 As New DataTable
            DA112.Fill(DT112)
            If DT112.Rows.Count > 0 Then
                MessageBox.Show("المريض له أيصال نقدية ولا يمكن التعديل عليه", "أنتبة", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim DA111 As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID_H.Text & "' AND STAT_COLORE = '3'", SqlConn)
            Dim DT111 As New DataTable
            DA111.Fill(DT111)
            If DT111.Rows.Count > 0 Then
                MessageBox.Show("المريض له أيصال نقدية ولا يمكن التعديل عليه", "أنتبة", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

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
                DR!EDIT_USER = HOME.T_USERS.Text
                DR!DATE_EDIT_USER = Date.Now
                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                REFRESH_BTN_Click(sender, e)

            End If
        End If
    End Sub

    Private Sub REFRESH_BTN_P3_Click(sender As Object, e As EventArgs) Handles REFRESH_BTN_P3.Click
        Dim KARMA As String
        'KARMA = "SELECT        TOP (100) PERCENT TKHASOS_CODE, DOCTORS_CODE, DATE_HAGEZ, COUNT(ACTION) AS COUNT_ACTION, ACTION, STAT_COLORE
        'FROM            dbo.HAGEZ
        'GROUP BY TKHASOS_CODE, DOCTORS_CODE, DATE_HAGEZ, ACTION, STAT_COLORE
        'HAVING        (NOT (ACTION IS NULL)) AND (DOCTORS_CODE = '" & TXT_DOCTOR_CODE.Text & "') AND (DATE_HAGEZ = '" & TXT_DATE.Text & "') AND (STAT_COLORE = '2')"

        'KARMA = "SELECT        TOP (100) PERCENT dbo.ADD_MONY_DOCTOR.ADD_DATE, dbo.ADD_MONY_DOCTOR.ADD_DOCTOR_CODE, dbo.ADD_MONY_DOCTOR.ADD_STAT, COUNT(dbo.ADD_MONY_DT_DOCTOR.NAME_ACTION) 
        '                         AS COUNT_ACTION_NAME, dbo.ADD_MONY_DT_DOCTOR.PRICE_DOCE, dbo.ADD_MONY_DT_DOCTOR.NAME_ACTION
        'FROM            dbo.ADD_MONY_DOCTOR INNER JOIN
        '                         dbo.ADD_MONY_DT_DOCTOR ON dbo.ADD_MONY_DOCTOR.ADD_CODE = dbo.ADD_MONY_DT_DOCTOR.ADD_CODE AND dbo.ADD_MONY_DOCTOR.ADD_DATE = dbo.ADD_MONY_DT_DOCTOR.ADD_DATE
        'GROUP BY dbo.ADD_MONY_DOCTOR.ADD_DATE, dbo.ADD_MONY_DOCTOR.ADD_DOCTOR_CODE, dbo.ADD_MONY_DT_DOCTOR.NAME_ACTION, dbo.ADD_MONY_DT_DOCTOR.PRICE_DOCE, dbo.ADD_MONY_DOCTOR.ADD_STAT
        'HAVING        (dbo.ADD_MONY_DOCTOR.ADD_DATE = '" & TXT_DATE.Text & "') AND (dbo.ADD_MONY_DOCTOR.ADD_DOCTOR_CODE = '" & TXT_DOCTOR_CODE.Text & "') AND (dbo.ADD_MONY_DOCTOR.ADD_STAT = 'TRUE') AND (NOT (COUNT(dbo.ADD_MONY_DT_DOCTOR.NAME_ACTION) 
        '                         IS NULL))
        'ORDER BY COUNT(dbo.ADD_MONY_DT_DOCTOR.NAME_ACTION) "



        KARMA = "SELECT        dbo.HAGEZ.DATE_HAGEZ, dbo.ADD_MONY_DT_DOCTOR.NAME_ACTION, COUNT(dbo.ADD_MONY_DT_DOCTOR.NAME_ACTION) AS count_action, dbo.ADD_MONY_DT_DOCTOR.PRICE_DOCE, dbo.HAGEZ.DOCTORS_CODE, 
                                         dbo.ADD_MONY_DOCTOR.ADD_STAT
                FROM            dbo.ADD_MONY_DOCTOR INNER JOIN
                                         dbo.ADD_MONY_DT_DOCTOR ON dbo.ADD_MONY_DOCTOR.ADD_CODE = dbo.ADD_MONY_DT_DOCTOR.ADD_CODE AND dbo.ADD_MONY_DOCTOR.ADD_DATE = dbo.ADD_MONY_DT_DOCTOR.ADD_DATE INNER JOIN
                                         dbo.HAGEZ ON dbo.ADD_MONY_DOCTOR.ADD_DATE = dbo.HAGEZ.DATE_HAGEZ AND dbo.ADD_MONY_DOCTOR.ADD_DOCTOR_CODE = dbo.HAGEZ.DOCTORS_CODE AND 
                                         dbo.ADD_MONY_DOCTOR.ADD_PA_CODE = dbo.HAGEZ.PA_CODE
                GROUP BY dbo.HAGEZ.DATE_HAGEZ, dbo.ADD_MONY_DT_DOCTOR.PRICE_DOCE, dbo.ADD_MONY_DT_DOCTOR.NAME_ACTION, dbo.HAGEZ.DOCTORS_CODE, dbo.ADD_MONY_DOCTOR.ADD_STAT
                HAVING        (dbo.HAGEZ.DOCTORS_CODE = '" & TXT_DOCTOR_CODE.Text & "') AND (dbo.HAGEZ.DATE_HAGEZ = CONVERT(DATETIME, '" & TXT_DATE.Text & "', 102)) AND (dbo.ADD_MONY_DOCTOR.ADD_STAT='True') AND (NOT (COUNT(dbo.ADD_MONY_DT_DOCTOR.NAME_ACTION) IS NULL))"


        FILL_DGV(DG2, KARMA)
        Dim ES As String
        ES = "SELECT * FROM estr WHERE ADD_DATE='" & TXT_DATE.Text & "' AND ADD_DOCTOR_CODE = '" & TXT_DOCTOR_CODE.Text & "' AND ADD_TYPE='أسترداد عيادات' "
        FILL_DGV(DGES, ES)

        Dim KARMA3 As String
        KARMA3 = "SELECT      dbo.HAGEZ.DOCTORS_CODE, dbo.HAGEZ.DATE_HAGEZ, COUNT(dbo.HAGEZ.STAT_COLORE) AS COLOR, dbo.HAGEZ.STAT_COLORE, dbo.HAGEZ_COLOR.NAME
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

            '===================== التاكد من ان المريض ليس معمول له فاتورة من قبل ==========================
            Dim DA111 As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID_H.Text & "' AND STAT_COLORE = '2'", SqlConn)
            Dim DT111 As New DataTable
            DA111.Fill(DT111)
            If DT111.Rows.Count > 0 Then
                MessageBox.Show("المريض له أيصال نقدية ولا يمكن التعديل عليه", "أنتبة", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If DataGridView1.SelectedRows.Count > 0 Then
                If MessageBox.Show("هل أنت متأكد أن المريض رقم " & TXT_NUM_H.Text & " مجانا ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub

                'For Each r As DataGridViewRow In DataGridView1.SelectedRows
                '    r.DefaultCellStyle.BackColor = P_FREE.BackColor
                'Next
                'Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID_H.Text & "'", SqlConn)
                'Dim DT As New DataTable
                'DA.Fill(DT)
                'Dim DR = DT.Rows(0)
                'DR!STAT_COLORE = "3"
                'DR!EDIT_USER = HOME.T_USERS.Text
                'DR!DATE_EDIT_USER = Date.Now
                'Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                'DA.Update(DT)

            End If
            '   If MessageBox.Show("هل ترغب في فتح أيصال استلام النقدية للمريض رقم  " & TXT_NUM_H.Text, "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub


            Try
                ROLES("M", ADD_MONY_DOCTOR)
            Catch EX As Exception

            End Try


            REFRESH_BTN_Click(sender, e)
        End If
    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click
        If TXT_ID_H.Text = "" Then
            MessageBox.Show("يرجى أختيار المريض  من الجدول بالأسفل", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            '===================== التاكد من ان المريض ليس معمول له فاتورة من قبل ==========================
            Dim DA112 As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID_H.Text & "' AND STAT_COLORE = '2'", SqlConn)
            Dim DT112 As New DataTable
            DA112.Fill(DT112)
            If DT112.Rows.Count > 0 Then
                MessageBox.Show("المريض له أيصال نقدية ولا يمكن التعديل عليه", "أنتبة", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim DA111 As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID_H.Text & "' AND STAT_COLORE = '3'", SqlConn)
            Dim DT111 As New DataTable
            DA111.Fill(DT111)
            If DT111.Rows.Count > 0 Then
                MessageBox.Show("المريض له أيصال نقدية ولا يمكن التعديل عليه", "أنتبة", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

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
                DR!EDIT_USER = HOME.T_USERS.Text
                DR!DATE_EDIT_USER = Date.Now
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

            '===================== التاكد من ان المريض ليس معمول له فاتورة من قبل ==========================
            Dim DA112 As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID_H.Text & "' AND STAT_COLORE = '2'", SqlConn)
            Dim DT112 As New DataTable
            DA112.Fill(DT112)
            If DT112.Rows.Count > 0 Then
                MessageBox.Show("المريض له أيصال نقدية ولا يمكن التعديل عليه", "أنتبة", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            Dim DA111 As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID_H.Text & "' AND STAT_COLORE = '3'", SqlConn)
            Dim DT111 As New DataTable
            DA111.Fill(DT111)
            If DT111.Rows.Count > 0 Then
                MessageBox.Show("المريض له أيصال نقدية ولا يمكن التعديل عليه", "أنتبة", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

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
                DR!ACTION = ""
                DR!EDIT_USER = HOME.T_USERS.Text
                DR!DATE_EDIT_USER = Date.Now
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
        End If

        '===================== التاكد من ان المريض ليس معمول له فاتورة من قبل ==========================
        Dim DA112 As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID_H.Text & "' AND STAT_COLORE = '2'", SqlConn)
        Dim DT112 As New DataTable
        DA112.Fill(DT112)
        If DT112.Rows.Count > 0 Then
            MessageBox.Show("المريض له أيصال نقدية ولا يمكن التعديل عليه", "أنتبة", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim DA111 As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID_H.Text & "' AND STAT_COLORE = '3'", SqlConn)
        Dim DT111 As New DataTable
        DA111.Fill(DT111)
        If DT111.Rows.Count > 0 Then
            MessageBox.Show("المريض له أيصال نقدية ولا يمكن التعديل عليه", "أنتبة", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If TXT_CALL_WITH.Text = "" Then
            MessageBox.Show("يرجى كتابة ما تم اثناء الاتصال", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_CALL_WITH.Select()
            Exit Sub
        End If

        If DataGridView1.SelectedRows.Count > 0 Then
            If MessageBox.Show("هل أنت متأكد أن المريض رقم " & TXT_NUM_H.Text & " تم الأتصال به الأن ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub

            Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID_H.Text & "'", SqlConn)
            Dim DT As New DataTable
            DA.Fill(DT)
            Dim DR = DT.Rows(0)
            DR!INFO_STAT = TXT_INFO_H_DATAGRID.Text & " , " & TXT_CALL_WITH.Text & Date.Now.ToShortTimeString
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            REFRESH_BTN_Click(sender, e)
            TXT_CALL_WITH.Text = ""
        End If

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click
        If TXT_ID_H.Text = "" Then
            MessageBox.Show("يرجى أختيار المريض  من الجدول بالأسفل", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            If DataGridView1.SelectedRows.Count > 0 Then
                If MessageBox.Show("هل أنت متأكد أن المريض رقم " & TXT_NUM_H.Text & " سيقوم بالدفع ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub

                'Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ WHERE ID = '" & TXT_ID_H.Text & "'", SqlConn)
                'Dim DT As New DataTable
                'DA.Fill(DT)
                'Dim DR = DT.Rows(0)
                'DR!STAT_COLORE = "2"
                'DR!EDIT_USER = HOME.T_USERS.Text
                'DR!DATE_EDIT_USER = Date.Now
                'Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                'DA.Update(DT)

            End If
            'If MessageBox.Show("هل ترغب في فتح أيصال استلام النقدية للمريض رقم  " & TXT_NUM_H.Text, "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub

            Try
                ROLES("M", ADD_MONY_DOCTOR)
            Catch EX As Exception

            End Try

            REFRESH_BTN_Click(sender, e)
        End If

    End Sub

    Private Sub PRINT_BTN_Click(sender As Object, e As EventArgs) Handles PRINT_BTN.Click

        If TXT_PRINT.Text = "" Then
            MessageBox.Show("يرجى أختيار المطلوب طباعتة", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_PRINT.Select()
            Exit Sub
        ElseIf TXT_PRINT.SelectedIndex = 0 Then

            If TXT_DOCTOR_CODE.Text = "" Then
                MessageBox.Show("يرجى أختيار الطبيب ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim H As String
            H = " SELECT  * FROM HAGEZ_DT WHERE STAT_COLORE ='4'  AND DOCTORS_CODE = '" & TXT_DOCTOR_CODE.Text & "'  AND DATE_HAGEZ = '" & TXT_DATE.Text & "' ORDER BY ID "
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter(H, SqlConn)
            DA.Fill(DT)

            Dim REP As New MALGHE_HAGEZ2
            REP.SetDataSource(DT)
            Dim FRM As New REPFORALL
            FRM.CrystalReportViewer1.ReportSource = REP
            FRM.ShowDialog()


        ElseIf TXT_PRINT.SelectedIndex = 1 Then
            Dim H As String
            H = " SELECT  * FROM HAGEZ_MONY WHERE STAT_COLORE ='2'  AND DATE_HAGEZ = '" & TXT_DATE.Text & "'  "
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter(H, SqlConn)
            DA.Fill(DT)

            Dim REP As New MALGHE_HAGEZ
            REP.SetDataSource(DT)
            Dim FRM As New REPFORALL
            FRM.CrystalReportViewer1.ReportSource = REP
            FRM.ShowDialog()


        ElseIf TXT_PRINT.SelectedIndex = 2 Then

            If TXT_DOCTOR_CODE.Text = "" Then
                MessageBox.Show("يرجى أختيار الطبيب ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If


            Dim H As String
            H = " SELECT  * FROM HAGEZ_MONY WHERE STAT_COLORE ='2'  AND DOCTORS_CODE = '" & TXT_DOCTOR_CODE.Text & "'  AND DATE_HAGEZ = '" & TXT_DATE.Text & "'  "
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter(H, SqlConn)
            DA.Fill(DT)

            Dim REP As New MALGHE_HAGEZ
            REP.SetDataSource(DT)
            Dim FRM As New REPFORALL
            FRM.CrystalReportViewer1.ReportSource = REP
            FRM.ShowDialog()

        ElseIf TXT_PRINT.SelectedIndex = 3 Then

            If TXT_DOCTOR_CODE.Text = "" Then
                MessageBox.Show("يرجى أختيار الطبيب ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Dim H As String
            H = " SELECT  * FROM HAGEZ_DT WHERE DOCTORS_CODE = '" & TXT_DOCTOR_CODE.Text & "'  AND DATE_HAGEZ = '" & TXT_DATE.Text & "' ORDER BY ID "
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter(H, SqlConn)
            DA.Fill(DT)

            Dim REP As New MALGHE_HAGEZ3
            REP.SetDataSource(DT)
            Dim FRM As New REPFORALL
            FRM.CrystalReportViewer1.ReportSource = REP
            FRM.ShowDialog()

            'ElseIf TXT_PRINT.SelectedIndex = 4 Then

            '    If TXT_PA_CODE_H.Text = "" Then
            '        MessageBox.Show("يرجى ادخال اسم المريض", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        Exit Sub
            '    End If
            '    '=================================================================
            '    Dim DT As New DataTable
            '    Dim DA As New SqlClient.SqlDataAdapter("SELECT  * FROM  HAGEZ_V WHERE CODE_PA_H_A ='" & TXT_PA_CODE_H.Text & "'", SqlConn)
            '    DA.Fill(DT)

            '    Dim REP As New HAGEZ_REP_CRS
            '    REP.SetDataSource(DT)
            '    REP.SetParameterValue(0, TXT_PA_CODE_H.Text)

            '    Dim FRM As New REPFORALL
            '    FRM.CrystalReportViewer1.ReportSource = REP
            '    FRM.ShowDialog()
        End If
    End Sub

    Private Sub TXT_DATE_ValueChanged(sender As Object, e As EventArgs) Handles TXT_DATE.ValueChanged
        DATE_NAME.Text = TXT_DATE.Text
        DATE_NAME_P3.Text = TXT_DATE.Text
        P_HAGEZ.Visible = False
    End Sub

    Private Sub BTN_CALL_COUNT_Click(sender As Object, e As EventArgs) Handles BTN_CALL_COUNT.Click
        If TXT_ID_H.Text = "" Then
            MessageBox.Show("يرجى أختيار المريض  من الجدول بالأسفل", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            MessageBox.Show(TXT_INFO_H_DATAGRID.Text)
        End If

    End Sub

    Private Sub CH_TEL_AQAREP_CheckedChanged(sender As Object, e As EventArgs) Handles CH_TEL_AQAREP.CheckedChanged
        If CH_TEL_AQAREP.Checked = True Then
            TXT_TEL_AQAREP.Enabled = False
            TXT_TEL_AQAREP.BackColor = Color.White
        Else
            TXT_TEL_AQAREP.Enabled = True
            TXT_TEL_AQAREP.BackColor = Color.Aqua
            CH_TEL_AQAREP.Visible = False
        End If
    End Sub

    Private Sub CH_TEL_AQAREP2_CheckedChanged(sender As Object, e As EventArgs) Handles CH_TEL_AQAREP2.CheckedChanged
        If CH_TEL_AQAREP2.Checked = True Then
            TXT_TEL_AQAREP2.Enabled = False
            TXT_TEL_AQAREP2.BackColor = Color.White
        Else
            TXT_TEL_AQAREP2.Enabled = True
            TXT_TEL_AQAREP2.BackColor = Color.Aqua
            CH_TEL_AQAREP2.Visible = False
        End If
    End Sub

    Private Sub BTN_PRINT_END_DAY_Click(sender As Object, e As EventArgs) Handles BTN_PRINT_END_DAY.Click
        Dim DTPAS As New DataTable
        Dim DAPASS As New SqlClient.SqlDataAdapter("SELECT * FROM ESS ", SqlConn)
        DAPASS.Fill(DTPAS)
        Dim DRPASS = DTPAS.Rows(0)
        TXT_PASS2.Text = DRPASS!PASS

        If TXT_PASS2.Text = TXT_PASS.Text Then
            FILL_DGV(DataGridView2, "SELECT * FROM KHAZINA_RASED_V WHERE STAT_KHAZINA='TRUE' AND CODE_DT2 = '2' AND KHAZINA_DATE ='" & TXT_DATE.Text & "'")

            Dim TOTAL_ As Double

            For I = 0 To DataGridView2.Rows.Count - 1
                TOTAL_ = Val(TOTAL_) + Val(DataGridView2.Rows(I).Cells(0).Value)
            Next
            TXT_MAML_RASED.Text = Val(TOTAL_)

            TOTAL_MAML.Text = Val(TXT_MAML_RASED.Text)

            FILL_DGV(DataGridView3, "SELECT * FROM MASROUF_DT_V WHERE OUT_STAT='TRUE'  AND OUT_DATE ='" & TXT_DATE.Text & "'AND OUT_TYPE='مصروفات' ")

            Dim TOTAL2_ As Double

            For I2 = 0 To DataGridView3.Rows.Count - 1
                TOTAL2_ = Val(TOTAL2_) + Val(DataGridView3.Rows(I2).Cells(1).Value)
            Next

            TXT_MASROUF_RASED.Text = Val(TOTAL2_)

            FILL_DGV(DataGridView4, "SELECT * FROM MASROUF_DT_V WHERE OUT_STAT='TRUE'  AND OUT_DATE ='" & TXT_DATE.Text & "'AND OUT_TYPE='أيرادات' ")

            Dim TOTAL3_ As Double

            For I3 = 0 To DataGridView4.Rows.Count - 1
                TOTAL3_ = Val(TOTAL3_) + Val(DataGridView4.Rows(I3).Cells(1).Value)
            Next

            TXT_ERAD_RASED.Text = Val(TOTAL3_)

            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM BADR_V WHERE DATE_HAGEZ='" & TXT_DATE.Text & "'AND ADD_STAT = 'TRUE'", SqlConn)
            DA.Fill(DT)

            Dim DT1 As New DataTable
            Dim DA1 As New SqlClient.SqlDataAdapter("SELECT * FROM MASROUF_DT_V WHERE OUT_STAT='TRUE'  AND OUT_DATE ='" & TXT_DATE.Text & "' AND OUT_TYPE='مصروفات'", SqlConn)
            DA1.Fill(DT1)

            Dim DT2 As New DataTable
            Dim DA2 As New SqlClient.SqlDataAdapter("SELECT * FROM estr WHERE ADD_DATE='" & TXT_DATE.Text & "' AND ADD_TYPE='أسترداد عيادات'", SqlConn)
            DA2.Fill(DT2)

            Dim DT3 As New DataTable
            Dim DA3 As New SqlClient.SqlDataAdapter("SELECT * FROM MASROUF_DT_V WHERE OUT_STAT='TRUE'  AND OUT_DATE ='" & TXT_DATE.Text & "' AND OUT_TYPE='أيرادات'", SqlConn)
            DA3.Fill(DT3)

            Dim REP1 As New MALGHE_HAGEZ4
            REP1.SetDataSource(DT)
            REP1.Subreports(0).SetDataSource(DT1)
            REP1.Subreports(1).SetDataSource(DT2)
            REP1.Subreports(2).SetDataSource(DT3)
            REP1.SetParameterValue(0, TOTAL_MAML.Text)
            REP1.SetParameterValue(1, TXT_MASROUF_RASED.Text)
            REP1.SetParameterValue(2, TXT_ERAD_RASED.Text)

            Dim FRM As New REPFORALL
            FRM.CrystalReportViewer1.ReportSource = REP1
            FRM.ShowDialog()
            TXT_PASS.Text = ""
        Else
            MessageBox.Show("من فضلك أدخل الرقم السري بشكل صحيح لعرض التقرير")
            TXT_PASS.Select()
        End If

    End Sub
End Class