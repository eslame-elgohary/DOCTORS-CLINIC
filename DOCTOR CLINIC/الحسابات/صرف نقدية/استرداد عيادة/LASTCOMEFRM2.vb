Public Class LASTCOMEFRM2
    Private Sub LASTCOMEFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim KARMA As String
        KARMA = "SELECT        dbo.ADD_MONY_DOCTOR.ADD_CODE, dbo.ADD_MONY_DOCTOR.ADD_DATE, dbo.ADD_MONY_DT_DOCTOR.NAME_ACTION, dbo.ADD_MONY_DOCTOR.ADD_PA_CODE, dbo.ADD_MONY_DOCTOR.ADD_DOCTOR_CODE, 
                         dbo.ADD_MONY_DOCTOR.ADD_TYPE_MONY, dbo.ADD_MONY_DOCTOR.ADD_STAT, dbo.ADD_MONY_DOCTOR.ID
From dbo.ADD_MONY_DOCTOR INNER Join
              dbo.ADD_MONY_DT_DOCTOR ON dbo.ADD_MONY_DOCTOR.ADD_CODE = dbo.ADD_MONY_DT_DOCTOR.ADD_CODE And dbo.ADD_MONY_DOCTOR.ADD_DATE = dbo.ADD_MONY_DT_DOCTOR.ADD_DATE
WHERE        (dbo.ADD_MONY_DOCTOR.ADD_PA_CODE ='" & ADD_MONY2_DOCTOR.PA_CODE.Text & "') AND (dbo.ADD_MONY_DOCTOR.ADD_DOCTOR_CODE = '" & ADD_MONY2_DOCTOR.CODE_DOCTOR.Text & "') ORDER BY dbo.ADD_MONY_DOCTOR.ID DESC "
        FILL_DGV(DataGridView2, KARMA)

        For Each r As DataGridViewRow In DataGridView2.Rows
            Select Case r.Cells.Item(4).Value
                Case "true" 'المريض حضر
                    r.Cells.Item(5).Value = ""
                Case Else
                    r.Cells.Item(5).Value = "تم إسترداده"
            End Select
        Next

    End Sub
End Class