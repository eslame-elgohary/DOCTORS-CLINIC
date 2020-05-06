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
    End Sub
End Class