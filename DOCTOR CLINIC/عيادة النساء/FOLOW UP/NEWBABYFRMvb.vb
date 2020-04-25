Public Class NEWBABYFRMvb
    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub

    Private Sub NEWBABYFRMvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_NAME_PA.Text = FOLOUP.TXT_PA_NAME.Text
        TXT_PA_CODE.Text = FOLOUP.TXT_PA_CODE.Text
        TXT_BABY_NO.Text = "1"
        TXT_DATE.Text = Date.Today
    End Sub

    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click
        If MessageBox.Show("هل انت متأكد انه تم الولادة بالفعل ؟ ", "رسالة تنبية", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        '===================== FOLOWUP MASTER ==============================
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("INSERT INTO FOLOWUP_DT_TEMP SELECT * FROM FOLOWUP_DT WHERE PA_CODE_FOLOWUP='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        '=================================================
        Dim CMD_DEL As New SqlClient.SqlCommand
        CMD_DEL.Connection = SqlConn
        CMD_DEL.CommandText = "DELETE FROM FOLOWUP_DT WHERE PA_CODE_FOLOWUP ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL.ExecuteNonQuery()

        '===================== FOLOWUP DETELS ==============================
        Dim DT1 As New DataTable
        Dim DA1 As New SqlClient.SqlDataAdapter("INSERT INTO FOLOWUP_DTELS_TEMP SELECT * FROM FOLOWUP_DTELS WHERE PA_CODE_FOLOWUP_DS ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA1.Fill(DT1)
        '=================================================
        Dim CMD_DEL1 As New SqlClient.SqlCommand
        CMD_DEL1.Connection = SqlConn
        CMD_DEL1.CommandText = "DELETE FROM FOLOWUP_DTELS WHERE PA_CODE_FOLOWUP_DS ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL1.ExecuteNonQuery()

        '===================== 4D ==============================
        Dim DT2 As New DataTable
        Dim DA2 As New SqlClient.SqlDataAdapter("INSERT INTO E4D_HISTORY_TEMP SELECT * FROM E4D_HISTORY WHERE PA_CODE_4D ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA2.Fill(DT2)
        '=================================================
        Dim CMD_DEL2 As New SqlClient.SqlCommand
        CMD_DEL2.Connection = SqlConn
        CMD_DEL2.CommandText = "DELETE FROM E4D_HISTORY WHERE PA_CODE_4D ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL2.ExecuteNonQuery()

        '===================== FETAL DOPPLER ==============================
        Dim DT3 As New DataTable
        Dim DA3 As New SqlClient.SqlDataAdapter("INSERT INTO FETAL_HISTORY_TEMP SELECT * FROM FETAL_HISTORY WHERE PA_CODE_FETAL ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA3.Fill(DT3)
        '=================================================
        Dim CMD_DEL3 As New SqlClient.SqlCommand
        CMD_DEL3.Connection = SqlConn
        CMD_DEL3.CommandText = "DELETE FROM FETAL_HISTORY WHERE PA_CODE_FETAL ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL3.ExecuteNonQuery()

        '===================== OBSTETRIC HISTORY ==============================
        Dim DT4 As New DataTable
        Dim DA4 As New SqlClient.SqlDataAdapter("INSERT INTO OBSTETRIC_HISTORY_TEMP SELECT * FROM OBSTETRIC_HISTORY WHERE PA_CODE_OBSTETRIC ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA4.Fill(DT4)
        '=================================================
        Dim CMD_DEL4 As New SqlClient.SqlCommand
        CMD_DEL4.Connection = SqlConn
        CMD_DEL4.CommandText = "DELETE FROM OBSTETRIC_HISTORY WHERE PA_CODE_OBSTETRIC  ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL4.ExecuteNonQuery()

        '===================== 1ST ==============================
        Dim DT5 As New DataTable
        Dim DA5 As New SqlClient.SqlDataAdapter("INSERT INTO ST1_TEST_TEMP SELECT * FROM ST1_TEST WHERE CODE_PA_ST1 ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA5.Fill(DT5)
        '=================================================
        Dim CMD_DEL5 As New SqlClient.SqlCommand
        CMD_DEL5.Connection = SqlConn
        CMD_DEL5.CommandText = "DELETE FROM ST1_TEST WHERE CODE_PA_ST1  ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL5.ExecuteNonQuery()

        '===================== 2ND ==============================
        Dim DT6 As New DataTable
        Dim DA6 As New SqlClient.SqlDataAdapter("INSERT INTO ND2_TEST_TEMP SELECT * FROM ND2_TEST WHERE CODE_PA_ND2 ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA6.Fill(DT6)
        '=================================================
        Dim CMD_DEL6 As New SqlClient.SqlCommand
        CMD_DEL6.Connection = SqlConn
        CMD_DEL6.CommandText = "DELETE FROM ND2_TEST WHERE CODE_PA_ND2 ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL6.ExecuteNonQuery()

        '===================== 3RD ==============================
        Dim DT7 As New DataTable
        Dim DA7 As New SqlClient.SqlDataAdapter("INSERT INTO RD3_TEST_TEMP SELECT * FROM RD3_TEST WHERE CODE_PA_RD3 ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA7.Fill(DT7)
        '=================================================
        Dim CMD_DEL7 As New SqlClient.SqlCommand
        CMD_DEL7.Connection = SqlConn
        CMD_DEL7.CommandText = "DELETE FROM RD3_TEST WHERE CODE_PA_RD3 ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL7.ExecuteNonQuery()

        '===================== PERSONAL HISTORY ==============================
        Dim DT8 As New DataTable
        Dim DA8 As New SqlClient.SqlDataAdapter("INSERT INTO PERSONAL_HISTORY_TEMP SELECT * FROM PERSONAL_HISTORY WHERE CODE_PA_PERS ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA8.Fill(DT8)
        '=================================================
        Dim CMD_DEL8 As New SqlClient.SqlCommand
        CMD_DEL8.Connection = SqlConn
        CMD_DEL8.CommandText = "DELETE FROM PERSONAL_HISTORY WHERE CODE_PA_PERS  ='" & TXT_PA_CODE.Text & "'"
        CMD_DEL8.ExecuteNonQuery()
        '====================== ADD TO PATION DTELS =====
        Dim DT100 As New DataTable
        Dim DA100 As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_CODE ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA100.Fill(DT100)
        Dim DR = DT100.Rows(0)
        DR!PA_OP_R1 = True
        DR!PA_OP = TXT_LAST_OP.Text & " & تمت الولادة بتاريخ" & TXT_DATE.Text
        DR!PA_CHI_R1 = True
        DR!PA_CHI = Val(TXT_CHI.Text) + 1
        '=========================================================================================
        MessageBox.Show(" Your insert has been successfully save ", "confirmation message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Me.Close()

    End Sub

    Private Sub TXT_PA_CODE_TextChanged(sender As Object, e As EventArgs) Handles TXT_PA_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_CODE ='" & TXT_PA_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_LAST_OP.Text = DT.Rows(I).Item("PA_OP")
            TXT_CHI.Text = DT.Rows(I).Item("PA_CHI")

        Next
        If TXT_CHI.Text = "" Then
            TXT_CHI.Text = "0"
        End If
        If TXT_CHI.Text = "لا يوجد" Then
            TXT_CHI.Text = "0"
        End If
    End Sub
End Class