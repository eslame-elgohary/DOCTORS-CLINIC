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
        FILL_PATION()
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

    Private Sub TXT_PA_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_PA_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME ='" & TXT_PA_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA_CODE.Text = DT.Rows(I).Item("PA_CODE")
        Next
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
End Class