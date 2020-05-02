Public Class ENGABFRM
    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Close()

    End Sub

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

    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles NEWBTN.Click
        TXT_DATE_VISITNEW.Text = Date.Today
        TXT_DATE_VISITLAST.Text = Date.Today
        TXT_DATE_VISITNEW1.Text = Date.Today
        TXT_DATE_VISITLAST1.Text = Date.Today

    End Sub

    Private Sub TXT_DATE_VISITNEW1_ValueChanged(sender As Object, e As EventArgs) Handles TXT_DATE_VISITNEW1.ValueChanged
        CALCDATE1()
    End Sub

    Private Sub TXT_DATE_VISITLAST1_ValueChanged(sender As Object, e As EventArgs) Handles TXT_DATE_VISITLAST1.ValueChanged
        CALCDATE1()
    End Sub
End Class