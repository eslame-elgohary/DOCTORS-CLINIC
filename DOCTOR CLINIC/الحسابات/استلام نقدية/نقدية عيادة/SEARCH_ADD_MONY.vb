﻿Public Class SEARCH_ADD_MONY
    Private Sub SEARCH_ADD_MONY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FILL_DGV(DataGridView1, "SELECT        dbo.ADD_MONY_DOCTOR.ADD_CODE, dbo.ADD_MONY_DOCTOR.ADD_DATE, dbo.PATIENT.PA_NAME, dbo.ADD_MONY_DOCTOR.ADD_SAFY, dbo.KHAZINA_DT.KHAZINA_IN, dbo.ADD_MONY_DOCTOR.ADD_STAT
FROM            dbo.ADD_MONY_DOCTOR INNER JOIN
                         dbo.PATIENT ON dbo.ADD_MONY_DOCTOR.ADD_PA_CODE = dbo.PATIENT.PA_CODE INNER JOIN
                         dbo.KHAZINA_DT ON dbo.ADD_MONY_DOCTOR.ADD_DATE = dbo.KHAZINA_DT.KHAZINA_DATE AND dbo.ADD_MONY_DOCTOR.ADD_CODE = dbo.KHAZINA_DT.CODE_DT 
WHERE PA_CODE = ADD_PA_CODE AND ADD_STAT='TRUE' AND ADD_DATE > = '" & DATE_START.Text & "' AND ADD_DATE < = '" & DATE_END.Text & "' ORDER BY ADD_MONY_DOCTOR.ID DESC")
        K1.SelectedIndex = 1
        DATE_START.Value = Date.Today
        DATE_END.Value = Date.Today
    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(5).Value = "عرض"
            Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(5, DataGridView1.CurrentRow.Index).Selected = True Then
            ADD_MONY_DOCTOR.SHOW_DETA(DataGridView1.CurrentRow.Cells(0).Value)
            Me.Close()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If K1.SelectedIndex = 0 Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter("SELECT        dbo.ADD_MONY_DOCTOR.ADD_CODE, dbo.ADD_MONY_DOCTOR.ADD_DATE, dbo.PATIENT.PA_NAME, dbo.ADD_MONY_DOCTOR.ADD_SAFY, dbo.KHAZINA_DT.KHAZINA_IN, dbo.ADD_MONY_DOCTOR.ADD_STAT
FROM            dbo.ADD_MONY_DOCTOR INNER JOIN
                         dbo.PATIENT ON dbo.ADD_MONY_DOCTOR.ADD_PA_CODE = dbo.PATIENT.PA_CODE INNER JOIN
                         dbo.KHAZINA_DT ON dbo.ADD_MONY_DOCTOR.ADD_DATE = dbo.KHAZINA_DT.KHAZINA_DATE AND dbo.ADD_MONY_DOCTOR.ADD_CODE = dbo.KHAZINA_DT.CODE_DT 
WHERE ADD_STAT='TRUE' AND ADD_DATE > = '" & DATE_START.Text & "' AND ADD_DATE < = '" & DATE_END.Text & "' AND ADD_CODE LIKE '%" & TextBox1.Text & "%'", SqlConn)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
        If K1.SelectedIndex = 1 Then
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter
            DT.Clear()
            DA = New SqlClient.SqlDataAdapter("SELECT        dbo.ADD_MONY_DOCTOR.ADD_CODE, dbo.ADD_MONY_DOCTOR.ADD_DATE, dbo.PATIENT.PA_NAME, dbo.ADD_MONY_DOCTOR.ADD_SAFY, dbo.KHAZINA_DT.KHAZINA_IN, dbo.ADD_MONY_DOCTOR.ADD_STAT
FROM            dbo.ADD_MONY_DOCTOR INNER JOIN
                         dbo.PATIENT ON dbo.ADD_MONY_DOCTOR.ADD_PA_CODE = dbo.PATIENT.PA_CODE INNER JOIN
                         dbo.KHAZINA_DT ON dbo.ADD_MONY_DOCTOR.ADD_DATE = dbo.KHAZINA_DT.KHAZINA_DATE AND dbo.ADD_MONY_DOCTOR.ADD_CODE = dbo.KHAZINA_DT.CODE_DT 
WHERE  ADD_STAT='TRUE' AND ADD_DATE > = '" & DATE_START.Text & "' AND ADD_DATE < = '" & DATE_END.Text & "' AND PA_NAME LIKE '%" & TextBox1.Text & "%'", SqlConn)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
    End Sub

    Private Sub ADD_DATE_VAL_Click(sender As Object, e As EventArgs) Handles ADD_DATE_VAL.Click
        FILL_DGV(DataGridView1, "SELECT        dbo.ADD_MONY_DOCTOR.ADD_CODE, dbo.ADD_MONY_DOCTOR.ADD_DATE, dbo.PATIENT.PA_NAME, dbo.ADD_MONY_DOCTOR.ADD_SAFY, dbo.KHAZINA_DT.KHAZINA_IN, dbo.ADD_MONY_DOCTOR.ADD_STAT
FROM            dbo.ADD_MONY_DOCTOR INNER JOIN
                         dbo.PATIENT ON dbo.ADD_MONY_DOCTOR.ADD_PA_CODE = dbo.PATIENT.PA_CODE INNER JOIN
                         dbo.KHAZINA_DT ON dbo.ADD_MONY_DOCTOR.ADD_DATE = dbo.KHAZINA_DT.KHAZINA_DATE AND dbo.ADD_MONY_DOCTOR.ADD_CODE = dbo.KHAZINA_DT.CODE_DT
WHERE  ADD_STAT='TRUE' AND ADD_DATE > = '" & DATE_START.Text & "' AND ADD_DATE < = '" & DATE_END.Text & "' ORDER BY ADD_MONY_DOCTOR.ID DESC")
    End Sub
End Class
