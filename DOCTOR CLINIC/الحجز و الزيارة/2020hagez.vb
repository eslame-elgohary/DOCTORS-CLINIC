Public Class h2020hagez

    Private Sub h2020hagez_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FILL_TKHASOS()
        TXT_DATE.Text = Date.Today
        CH_DATE.Checked = True
        TXT_ID.Text = ""
        TXT_HAGEZ.Text = ""
        REFRESHHAGEZ()
        RefreshCountHagz()
    End Sub

    Sub FILL_TKHASOS()
        TXT_TKHSOS.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM TKHASOS WHERE STAT='TRUE' ", SqlConn)
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
    Sub ACTION_DOCTORS()
        TXT_ACTION.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORSDT WHERE DO_CODE = '" & TXT_DOCTOR_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_ACTION.Items.Add(DT.Rows(I).Item("DOT_NAME"))
        Next
    End Sub
    Private Sub TXT_TKHSOS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_TKHSOS.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM TKHASOS WHERE TAKH_NAME='" & TXT_TKHSOS.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_TKHASOS_CODE.Text = DT.Rows(I).Item("TAKH_CODE")
        Next
        TXT_ACTION.Items.Clear()
        FILL_DOCTOR()
    End Sub

    Private Sub TXT_TKHASOS_CODE_TextChanged(sender As Object, e As EventArgs) Handles TXT_TKHASOS_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM TKHASOS WHERE TAKH_CODE='" & TXT_TKHASOS_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_TKHSOS.Text = DT.Rows(I).Item("TAKH_NAME")
        Next
    End Sub
    Private Sub TXT_DOCTOR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_DOCTOR.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORS WHERE  DO_NAME='" & TXT_DOCTOR.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_DOCTOR_CODE.Text = DT.Rows(I).Item("DO_CODE")
        Next

        '""""""""""""""" الترقيم التلقائي """"""""""""""
        Dim DT00 As New DataTable
        Dim DA00 As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ_DOCTOR WHERE CODE_DOC_H = '" & TXT_DOCTOR_CODE.Text & "'  AND DATE_H = '" & TXT_DATE.Text & "' ORDER BY ID ", SqlConn)
        DA00.Fill(DT00)
        If DT00.Rows.Count <> 0 Then
            Dim I0 = DT00.Rows.Count - 1
            TXT_CODE.Text = Val(DT00.Rows(I0).Item("CODE_H")) + 1
        Else
            TXT_CODE.Text = "1"
        End If

        '""""""""""""""""""""""""""""""
        PATIENTDATA.Clear()
        PATIENTTableAdapter.Fill(PATIENTDATA.PATIENT)
        ACTION_DOCTORS()
    End Sub
    Private Sub TXT_DOCTOR_CODE_TextChanged(sender As Object, e As EventArgs) Handles TXT_DOCTOR_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM DOCTORS WHERE DO_CODE='" & TXT_DOCTOR_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_DOCTOR.Text = DT.Rows(I).Item("DO_NAME")
        Next
        RefreshCountHagz()
        REFRESHHAGEZ()
        COLOR_STAT()
    End Sub
    Private Sub CH_DATE_CheckedChanged(sender As Object, e As EventArgs) Handles CH_DATE.CheckedChanged
        If CH_DATE.Checked = False Then
            TXT_DATE.Enabled = True
        Else
            TXT_DATE.Text = Date.Today
            TXT_DATE.Enabled = False

        End If
    End Sub

    Private Sub TXT_DATE_ValueChanged(sender As Object, e As EventArgs) Handles TXT_DATE.ValueChanged

        '""""""""""""""" الترقيم التلقائي """"""""""""""
        Dim DT00 As New DataTable
        Dim DA00 As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ_DOCTOR WHERE CODE_DOC_H = '" & TXT_DOCTOR_CODE.Text & "'  AND DATE_H = '" & TXT_DATE.Text & "' ORDER BY ID ", SqlConn)
        DA00.Fill(DT00)
        If DT00.Rows.Count <> 0 Then
            Dim I0 = DT00.Rows.Count - 1
            TXT_CODE.Text = Val(DT00.Rows(I0).Item("CODE_H")) + 1
        Else
            TXT_CODE.Text = "1"
        End If
        RefreshCountHagz()
        REFRESHHAGEZ()
        COLOR_STAT()
    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click
        ADD_MONY_DOCTOR.ShowDialog()
    End Sub
    Private Sub COLOR_STAT()
        Dim sql10 As String
        sql10 = "SELECT     COUNT(STAT_COLOR) AS count_color, DATE_H, CODE_DOC_H
FROM         dbo.HAGEZ_DOCTOR
WHERE     (STAT_COLOR = '1' and CODE_DOC_H ='" & TXT_DOCTOR_CODE.Text & "'and DATE_H='" & (TXT_DATE.Text) & "')
GROUP BY DATE_H, CODE_DOC_H
HAVING      (NOT (COUNT(STAT_COLOR) IS NULL))"

        FILL_DGV(DGCOLORIN, sql10)

        For Each r As DataGridViewRow In DGCOLORIN.Rows
            TXT_COME_PA.Text = r.Cells.Item(0).Value
        Next

        Dim sql11 As String
        sql11 = "SELECT     COUNT(STAT_COLOR) AS count_color, DATE_H, CODE_DOC_H
FROM         dbo.HAGEZ_DOCTOR
WHERE     (STAT_COLOR = '5' and CODE_DOC_H ='" & TXT_DOCTOR_CODE.Text & "'and DATE_H='" & (TXT_DATE.Text) & "')
GROUP BY DATE_H, CODE_DOC_H
HAVING      (NOT (COUNT(STAT_COLOR) IS NULL))"

        FILL_DGV(DGCOLORDELET, sql11)
        For Each r As DataGridViewRow In DGCOLORDELET.Rows
            TXT_DELETCOME_PA.Text = r.Cells.Item(0).Value
        Next


        Dim sql12 As String
        sql12 = "SELECT     COUNT(STAT_COLOR) AS count_color, DATE_H, CODE_DOC_H
FROM         dbo.HAGEZ_DOCTOR
WHERE     (STAT_COLOR = '4' and CODE_DOC_H ='" & TXT_DOCTOR_CODE.Text & "'and DATE_H='" & (TXT_DATE.Text) & "')
GROUP BY DATE_H, CODE_DOC_H
HAVING      (NOT (COUNT(STAT_COLOR) IS NULL))"

        FILL_DGV(DGCOLORTOIN, sql12)
        For Each r As DataGridViewRow In DGCOLORTOIN.Rows
            TXT_NOTCOME_PA.Text = r.Cells.Item(0).Value
        Next
    End Sub

    Private Sub REFRESHHAGEZ()
        FILL_DGV(DataGridView1, "SELECT * FROM HAGEZ_DOCTOR,DOCTORS,PATIENT WHERE CODE_PA_H = PA_CODE AND CODE_DOC_H = DO_CODE AND CODE_DOC_H = '" & TXT_DOCTOR_CODE.Text & "'  AND DATE_H = '" & TXT_DATE.Text & "' ORDER BY HAGEZ_DOCTOR.ID ")
        For Each r As DataGridViewRow In DataGridView1.Rows
            Select Case r.Cells.Item(8).Value
                Case "1" 'm
                    r.Cells.Item(1).Style.BackColor = Panel1.BackColor
                Case "5"
                    r.DefaultCellStyle.BackColor = Panel5.BackColor
                Case "4"
                    r.DefaultCellStyle.BackColor = Panel4.BackColor
                Case Else

            End Select
        Next



    End Sub
    Private Sub RefreshCountHagz()

        Dim sql As String
        sql = "SELECT     dbo.HAGEZ_DOCTOR.CODE_DOC_H, dbo.HAGEZ_DOCTOR.DATE_H, dbo.HAGEZ_DOCTOR.DOT_NAME, COUNT(dbo.HAGEZ_DOCTOR.DOT_NAME) 
                      AS H_COUNT, dbo.DOCTORSDT.DOT_PA, dbo.DOCTORSDT.DOT_PA * COUNT(dbo.HAGEZ_DOCTOR.DOT_NAME) AS total, 
                      dbo.DOCTORSDT.DOT_DOCTORS, dbo.DOCTORSDT.DOT_DOCTORS * COUNT(dbo.HAGEZ_DOCTOR.DOT_NAME) AS TOTAL_DOC
FROM         dbo.HAGEZ_DOCTOR INNER JOIN
                      dbo.DOCTORSDT ON dbo.HAGEZ_DOCTOR.CODE_DOC_H = dbo.DOCTORSDT.DO_CODE AND 
                      dbo.HAGEZ_DOCTOR.DOT_NAME = dbo.DOCTORSDT.DOT_NAME
WHERE     (dbo.HAGEZ_DOCTOR.STAT_COLOR = N'1')
GROUP BY dbo.HAGEZ_DOCTOR.DATE_H, dbo.HAGEZ_DOCTOR.DOT_NAME, dbo.HAGEZ_DOCTOR.CODE_DOC_H, dbo.DOCTORSDT.DOT_PA, 
                      dbo.DOCTORSDT.DOT_DOCTORS
HAVING      (NOT (dbo.HAGEZ_DOCTOR.DOT_NAME IS NULL))"

        If Trim(TXT_DOCTOR_CODE.Text) <> "" Then
            sql = sql & " and CODE_DOC_H ='" & TXT_DOCTOR_CODE.Text & "'"
        End If
        If IsDate(TXT_DATE.Text) AndAlso CDate(TXT_DATE.Text) > CDate("2000/01/01") Then
            sql = sql & " and DATE_H='" & (TXT_DATE.Text) & "'"
        End If

        FILL_DGV(DG2, sql)


    End Sub
    Private Sub TabNavigationPage3_Click(sender As Object, e As EventArgs) Handles TabNavigationPage3.Click
        RefreshCountHagz()
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click
        If TXT_ID.Text = "" Then
            MessageBox.Show("يرجى أختيار المريض  من الجدول بالأسفل", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            If DataGridView1.SelectedRows.Count > 0 Then
                If MessageBox.Show("هل أنت متأكد أن المريض رقم " & TXT_HAGEZ.Text & " حضر ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub

                For Each r As DataGridViewRow In DataGridView1.SelectedRows
                    r.Cells.Item(1).Style.BackColor = Panel1.BackColor
                Next

                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ_DOCTOR WHERE ID = '" & TXT_ID.Text & "'", SqlConn)
                Dim DT As New DataTable
                DA.Fill(DT)
                Dim DR = DT.Rows(0)
                DR!STAT_COLOR = "1"

                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                REFRESHHAGEZ()
                RefreshCountHagz()
                COLOR_STAT()

            End If
        End If
    End Sub


    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click

        If TXT_ID.Text = "" Then
            MessageBox.Show("يرجى أختيار المريض  من الجدول بالأسفل", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            If DataGridView1.SelectedRows.Count > 0 Then
                If MessageBox.Show("هل أنت متأكد أن المريض رقم " & TXT_HAGEZ.Text & " يرغب فى التأجيل ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub

                For Each r As DataGridViewRow In DataGridView1.SelectedRows
                    r.DefaultCellStyle.BackColor = Panel4.BackColor
                Next
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ_DOCTOR WHERE ID = '" & TXT_ID.Text & "'", SqlConn)
                Dim DT As New DataTable
                DA.Fill(DT)
                Dim DR = DT.Rows(0)
                DR!STAT_COLOR = "4"

                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                REFRESHHAGEZ()
                RefreshCountHagz()
                COLOR_STAT()
            End If
        End If
    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click

        If TXT_ID.Text = "" Then
            MessageBox.Show("يرجى أختيار المريض  من الجدول بالأسفل", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            If DataGridView1.SelectedRows.Count > 0 Then
                If MessageBox.Show("هل أنت متأكد أن المريض رقم " & TXT_HAGEZ.Text & " يرغب فى الألغاء ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub

                For Each r As DataGridViewRow In DataGridView1.SelectedRows
                    r.DefaultCellStyle.BackColor = Panel5.BackColor
                Next

                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ_DOCTOR WHERE ID = '" & TXT_ID.Text & "'", SqlConn)
                Dim DT As New DataTable
                DA.Fill(DT)
                Dim DR = DT.Rows(0)
                DR!STAT_COLOR = "5"

                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                REFRESHHAGEZ()
                RefreshCountHagz()
                COLOR_STAT()
            End If
        End If
    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click
        If TXT_ID.Text = "" Then
            MessageBox.Show("يرجى أختيار المريض  من الجدول بالأسفل", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            If DataGridView1.SelectedRows.Count > 0 Then

                For Each r As DataGridViewRow In DataGridView1.SelectedRows
                    r.DefaultCellStyle.BackColor = Panel3.BackColor
                Next

                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ_DOCTOR WHERE ID = '" & TXT_ID.Text & "'", SqlConn)
                Dim DT As New DataTable
                DA.Fill(DT)
                Dim DR = DT.Rows(0)
                DR!STAT_COLOR = "3"

                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                REFRESHHAGEZ()
                RefreshCountHagz()
                COLOR_STAT()
            End If
        End If
    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click

        If TXT_ID.Text = "" Then
            MessageBox.Show("يرجى أختيار المريض  من الجدول بالأسفل", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else

            If DataGridView1.SelectedRows.Count > 0 Then
                If MessageBox.Show("هل أنت متأكد أن المريض رقم " & TXT_HAGEZ.Text & " لم يحضر ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub

                For Each r As DataGridViewRow In DataGridView1.SelectedRows
                    r.DefaultCellStyle.BackColor = Panel6.BackColor
                Next

                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ_DOCTOR WHERE ID = '" & TXT_ID.Text & "'", SqlConn)
                Dim DT As New DataTable
                DA.Fill(DT)
                Dim DR = DT.Rows(0)
                DR!STAT_COLOR = ""

                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                REFRESHHAGEZ()
                RefreshCountHagz()
                COLOR_STAT()
            End If
        End If
    End Sub

    Private Sub CH_TEL_CheckedChanged(sender As Object, e As EventArgs) Handles CH_TEL.CheckedChanged
        If CH_TEL.Checked = True Then
            TXT_TEL.Enabled = False
            TXT_TEL.BackColor = Color.White
            CH_TEL.Visible = True
        Else
            TXT_TEL.Enabled = True
            TXT_TEL.BackColor = Color.Aqua
            CH_TEL.Visible = False
        End If
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            For Each r As DataGridViewRow In DataGridView1.SelectedRows
                TXT_ID.Text = r.Cells.Item(0).Value
                TXT_HAGEZ.Text = r.Cells.Item(1).Value
            Next
        End If
    End Sub

    Private Sub DataGridView1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.ColumnHeaderMouseClick
        REFRESHHAGEZ()
        RefreshCountHagz()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If TXT_ID.Text = "" Then
            MessageBox.Show("يرجى أختيار المريض  من الجدول بالأسفل", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            If DataGridView1.SelectedRows.Count > 0 Then
                If MessageBox.Show("هل أنت متأكد أنه تم الأتصال بالمريض رقم " & TXT_HAGEZ.Text & "  ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub

                For Each r As DataGridViewRow In DataGridView1.SelectedRows
                    r.Cells.Item(7).Style.BackColor = Panel7.BackColor
                Next

                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM HAGEZ_DOCTOR WHERE ID = '" & TXT_ID.Text & "'", SqlConn)
                Dim DT As New DataTable
                DA.Fill(DT)
                Dim DR = DT.Rows(0)
                DR!INFO_H = Date.Now

                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                REFRESHHAGEZ()
                RefreshCountHagz()
                COLOR_STAT()
            End If

        End If
    End Sub

    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles NEWBTN.Click
        COLOR_STAT()
        CH_TEL.Visible = True
    End Sub

    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click

    End Sub

    Private Sub EDITBTN_Click(sender As Object, e As EventArgs) Handles EDITBTN.Click

    End Sub

    Private Sub DELETBTN_Click(sender As Object, e As EventArgs) Handles DELETBTN.Click

    End Sub

    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub

    Private Sub TabNavigationPage1_Click(sender As Object, e As EventArgs) Handles TabNavigationPage1.Click
        REFRESHHAGEZ()
        COLOR_STAT()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DG2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG2.CellContentClick

    End Sub
End Class