Public Class AMLIAT_FRM
    Private Sub AMLIAT_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PATIENTTableAdapter.Fill(Me.PATIENTDATA.PATIENT)

    End Sub

    Private Sub TXT_PA_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_PA_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME = '" & TXT_PA_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_PA_CODE.Text = DT.Rows(I).Item("PA_CODE")
            TXT_PA_CODE2.Text = DT.Rows(I).Item("PA_CODE2")
        Next
    End Sub

    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Dispose()
    End Sub
End Class