Public Class REPORT_KHAZINAFRM
    Private Sub REPORT_KHAZINAFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FILL_KHAZINA()
        FILL_DGV(DataGridView1, "SELECT * FROM KHAZINA,KHAZINA_DT WHERE KHAZINA_DT.KHAZINA_CODE = KHAZINA.KHAZINA_CODE AND KHAZINA_DATE > = '" & DATE_START.Text & "' AND KHAZINA_DATE < = '" & DATE_END.Text & "' AND STAT='TRUE' AND STAT_KHAZINA='TRUE' ORDER BY KHAZINA_DATE")
        SELECT_KHAZINA.Checked = False
        KHAZINA_NAME.Enabled = False
        KHAZINA_NAME.Text = ""
        KHAZINA_CODE.Text = ""
        DATE_START.Text = Date.Today
        DATE_END.Text = Date.Today

    End Sub
    Private Sub SELECT_KHAZINA_CheckedChanged(sender As Object, e As EventArgs) Handles SELECT_KHAZINA.CheckedChanged
        If SELECT_KHAZINA.Checked = True Then
            KHAZINA_NAME.Enabled = True
        Else
            KHAZINA_NAME.Enabled = False
            KHAZINA_NAME.Text = ""
            KHAZINA_CODE.Text = ""
        End If
    End Sub

    Private Sub KHAZINA_CODE_TextChanged(sender As Object, e As EventArgs) Handles KHAZINA_CODE.TextChanged
        If GRU.Text = "" Then
            If KHAZINA_CODE.Text = "" Then
                FILL_DGV(DataGridView1, "SELECT * FROM KHAZINA,KHAZINA_DT WHERE KHAZINA_DT.KHAZINA_CODE = KHAZINA.KHAZINA_CODE AND KHAZINA_DATE > = '" & DATE_START.Text & "' AND KHAZINA_DATE < = '" & DATE_END.Text & "' AND STAT='TRUE' AND STAT_KHAZINA='TRUE' ORDER BY KHAZINA_DATE")

            Else
                FILL_DGV(DataGridView1, "SELECT * FROM KHAZINA,KHAZINA_DT WHERE KHAZINA_DT.KHAZINA_CODE = KHAZINA.KHAZINA_CODE AND KHAZINA.KHAZINA_CODE='" & KHAZINA_CODE.Text & "' AND KHAZINA_DATE > = '" & DATE_START.Text & "' AND KHAZINA_DATE < = '" & DATE_END.Text & "'AND STAT='TRUE' AND STAT_KHAZINA='TRUE' ORDER BY KHAZINA_DATE")

            End If
        Else
            If KHAZINA_CODE.Text = "" Then
                FILL_DGV(DataGridView1, "SELECT * FROM KHAZINA,KHAZINA_DT WHERE KHAZINA_DT.KHAZINA_CODE = KHAZINA.KHAZINA_CODE AND KHAZINA_DT.CODE_DT2='" & GRU_CODE.Text & "' AND  KHAZINA_DATE > = '" & DATE_START.Text & "' AND KHAZINA_DATE < = '" & DATE_END.Text & "' AND STAT='TRUE' AND STAT_KHAZINA='TRUE' ORDER BY KHAZINA_DATE")

            Else
                FILL_DGV(DataGridView1, "SELECT * FROM KHAZINA,KHAZINA_DT WHERE KHAZINA_DT.KHAZINA_CODE = KHAZINA.KHAZINA_CODE AND KHAZINA_DT.CODE_DT2='" & GRU_CODE.Text & "' AND KHAZINA.KHAZINA_CODE='" & KHAZINA_CODE.Text & "' AND KHAZINA_DATE > = '" & DATE_START.Text & "' AND KHAZINA_DATE < = '" & DATE_END.Text & "'AND STAT='TRUE' AND STAT_KHAZINA='TRUE' ORDER BY KHAZINA_DATE")

            End If
        End If
    End Sub

    Private Sub DATE_START_ValueChanged(sender As Object, e As EventArgs) Handles DATE_START.ValueChanged
        If GRU.Text = "" Then
            If KHAZINA_CODE.Text = "" Then
                FILL_DGV(DataGridView1, "SELECT * FROM KHAZINA,KHAZINA_DT WHERE KHAZINA_DT.KHAZINA_CODE = KHAZINA.KHAZINA_CODE AND KHAZINA_DATE > = '" & DATE_START.Text & "' AND KHAZINA_DATE < = '" & DATE_END.Text & "' AND STAT='TRUE' AND STAT_KHAZINA='TRUE' ORDER BY KHAZINA_DATE")

            Else
                FILL_DGV(DataGridView1, "SELECT * FROM KHAZINA,KHAZINA_DT WHERE KHAZINA_DT.KHAZINA_CODE = KHAZINA.KHAZINA_CODE AND KHAZINA.KHAZINA_CODE='" & KHAZINA_CODE.Text & "' AND KHAZINA_DATE > = '" & DATE_START.Text & "' AND KHAZINA_DATE < = '" & DATE_END.Text & "'AND STAT='TRUE' AND STAT_KHAZINA='TRUE' ORDER BY KHAZINA_DATE")

            End If
        Else
            If KHAZINA_CODE.Text = "" Then
                FILL_DGV(DataGridView1, "SELECT * FROM KHAZINA,KHAZINA_DT WHERE KHAZINA_DT.KHAZINA_CODE = KHAZINA.KHAZINA_CODE AND KHAZINA_DT.CODE_DT2='" & GRU_CODE.Text & "' AND  KHAZINA_DATE > = '" & DATE_START.Text & "' AND KHAZINA_DATE < = '" & DATE_END.Text & "' AND STAT='TRUE' AND STAT_KHAZINA='TRUE' ORDER BY KHAZINA_DATE")

            Else
                FILL_DGV(DataGridView1, "SELECT * FROM KHAZINA,KHAZINA_DT WHERE KHAZINA_DT.KHAZINA_CODE = KHAZINA.KHAZINA_CODE AND KHAZINA_DT.CODE_DT2='" & GRU_CODE.Text & "' AND KHAZINA.KHAZINA_CODE='" & KHAZINA_CODE.Text & "' AND KHAZINA_DATE > = '" & DATE_START.Text & "' AND KHAZINA_DATE < = '" & DATE_END.Text & "'AND STAT='TRUE' AND STAT_KHAZINA='TRUE' ORDER BY KHAZINA_DATE")

            End If
        End If
    End Sub

    Private Sub DATE_END_ValueChanged(sender As Object, e As EventArgs) Handles DATE_END.ValueChanged
        If GRU.Text = "" Then
            If KHAZINA_CODE.Text = "" Then
                FILL_DGV(DataGridView1, "SELECT * FROM KHAZINA,KHAZINA_DT WHERE KHAZINA_DT.KHAZINA_CODE = KHAZINA.KHAZINA_CODE AND KHAZINA_DATE > = '" & DATE_START.Text & "' AND KHAZINA_DATE < = '" & DATE_END.Text & "' AND STAT='TRUE' AND STAT_KHAZINA='TRUE' ORDER BY KHAZINA_DATE")

            Else
                FILL_DGV(DataGridView1, "SELECT * FROM KHAZINA,KHAZINA_DT WHERE KHAZINA_DT.KHAZINA_CODE = KHAZINA.KHAZINA_CODE AND KHAZINA.KHAZINA_CODE='" & KHAZINA_CODE.Text & "' AND KHAZINA_DATE > = '" & DATE_START.Text & "' AND KHAZINA_DATE < = '" & DATE_END.Text & "'AND STAT='TRUE' AND STAT_KHAZINA='TRUE' ORDER BY KHAZINA_DATE")

            End If
        Else
            If KHAZINA_CODE.Text = "" Then
                FILL_DGV(DataGridView1, "SELECT * FROM KHAZINA,KHAZINA_DT WHERE KHAZINA_DT.KHAZINA_CODE = KHAZINA.KHAZINA_CODE AND KHAZINA_DT.CODE_DT2='" & GRU_CODE.Text & "' AND  KHAZINA_DATE > = '" & DATE_START.Text & "' AND KHAZINA_DATE < = '" & DATE_END.Text & "' AND STAT='TRUE' AND STAT_KHAZINA='TRUE' ORDER BY KHAZINA_DATE")

            Else
                FILL_DGV(DataGridView1, "SELECT * FROM KHAZINA,KHAZINA_DT WHERE KHAZINA_DT.KHAZINA_CODE = KHAZINA.KHAZINA_CODE AND KHAZINA_DT.CODE_DT2='" & GRU_CODE.Text & "' AND KHAZINA.KHAZINA_CODE='" & KHAZINA_CODE.Text & "' AND KHAZINA_DATE > = '" & DATE_START.Text & "' AND KHAZINA_DATE < = '" & DATE_END.Text & "'AND STAT='TRUE' AND STAT_KHAZINA='TRUE' ORDER BY KHAZINA_DATE")

            End If
        End If
    End Sub
    Sub FILL_KHAZINA()
        KHAZINA_NAME.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA WHERE STAT ='TRUE'", SqlConn)
        DA.Fill(DT)
        For IA = 0 To DT.Rows.Count - 1
            KHAZINA_NAME.Items.Add(DT.Rows(IA).Item("KHAZINA_NAME"))
        Next
    End Sub

    Private Sub KHAZINA_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KHAZINA_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA WHERE KHAZINA_NAME ='" & (KHAZINA_NAME.Text) & "' AND STAT = 'TRUE' ", SqlConn)
        DA.Fill(DT)
        For I9 = 0 To DT.Rows.Count - 1
            KHAZINA_CODE.Text = DT.Rows(I9).Item("KHAZINA_CODE")
        Next
    End Sub

    Private Sub BTN_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_CLOSE.Click
        Me.Close()
    End Sub
    Private Sub PREVIWBTN_Click(sender As Object, e As EventArgs) Handles PREVIWBTN.Click
        Dim DT As New DataTable
        With DT
            .Columns.Add("KHAZINA_DATE")
            .Columns.Add("KHAZINA_NAME")
            .Columns.Add("KHAZINA_CODE")
            .Columns.Add("KHAZINA_NAME_ACTION")
            .Columns.Add("KHAZINA_IN")
            .Columns.Add("KHAZINA_OUT")


        End With
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(I).Cells(0).Value <> Nothing Then
                DT.Rows.Add(DataGridView1.Rows(I).Cells(0).Value, DataGridView1.Rows(I).Cells(1).Value, DataGridView1.Rows(I).Cells(2).Value, DataGridView1.Rows(I).Cells(3).Value, DataGridView1.Rows(I).Cells(4).Value, DataGridView1.Rows(I).Cells(5).Value)
            End If
        Next
        Dim REP As New KHAZINA_CRS
        REP.SetDataSource(DT)
        REP.SetParameterValue(0, DATE_START.Text)
        REP.SetParameterValue(1, DATE_END.Text)
        Dim FRM As New REP_KHAZINA
        FRM.CrystalReportViewer1.ReportSource = REP
        FRM.ShowDialog()
    End Sub

    Private Sub GRU_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GRU.SelectedIndexChanged
        If GRU.SelectedIndex = 0 Then
            GRU_CODE.Text = "1"
        ElseIf GRU.SelectedIndex = 1 Then
            GRU_CODE.Text = "2"
        ElseIf GRU.SelectedIndex = 2 Then
            GRU_CODE.Text = "3"
        ElseIf GRU.SelectedIndex = 3 Then
            GRU_CODE.Text = "4"
        ElseIf GRU.SelectedIndex = 4 Then
            GRU_CODE.Text = "5"
        ElseIf GRU.Text = "" Then
            GRU_CODE.Text = ""
        End If
    End Sub

    Private Sub CH_GRU_CheckedChanged(sender As Object, e As EventArgs) Handles CH_GRU.CheckedChanged
        If CH_GRU.Checked = True Then
            GRU.Enabled = True
        Else
            GRU.Enabled = False
            GRU.Text = ""
            GRU_CODE.Text = ""
        End If
    End Sub

    Private Sub GRU_CODE_TextChanged(sender As Object, e As EventArgs) Handles GRU_CODE.TextChanged
        If GRU.Text = "" Then
            If KHAZINA_CODE.Text = "" Then
                FILL_DGV(DataGridView1, "SELECT * FROM KHAZINA,KHAZINA_DT WHERE KHAZINA_DT.KHAZINA_CODE = KHAZINA.KHAZINA_CODE AND KHAZINA_DATE > = '" & DATE_START.Text & "' AND KHAZINA_DATE < = '" & DATE_END.Text & "' AND STAT='TRUE' AND STAT_KHAZINA='TRUE' ORDER BY KHAZINA_DATE")

            Else
                FILL_DGV(DataGridView1, "SELECT * FROM KHAZINA,KHAZINA_DT WHERE KHAZINA_DT.KHAZINA_CODE = KHAZINA.KHAZINA_CODE AND KHAZINA.KHAZINA_CODE='" & KHAZINA_CODE.Text & "' AND KHAZINA_DATE > = '" & DATE_START.Text & "' AND KHAZINA_DATE < = '" & DATE_END.Text & "'AND STAT='TRUE' AND STAT_KHAZINA='TRUE' ORDER BY KHAZINA_DATE")

            End If
        Else
            If KHAZINA_CODE.Text = "" Then
                FILL_DGV(DataGridView1, "SELECT * FROM KHAZINA,KHAZINA_DT WHERE KHAZINA_DT.KHAZINA_CODE = KHAZINA.KHAZINA_CODE AND KHAZINA_DT.CODE_DT2='" & GRU_CODE.Text & "' AND  KHAZINA_DATE > = '" & DATE_START.Text & "' AND KHAZINA_DATE < = '" & DATE_END.Text & "' AND STAT='TRUE' AND STAT_KHAZINA='TRUE' ORDER BY KHAZINA_DATE")

            Else
                FILL_DGV(DataGridView1, "SELECT * FROM KHAZINA,KHAZINA_DT WHERE KHAZINA_DT.KHAZINA_CODE = KHAZINA.KHAZINA_CODE AND KHAZINA_DT.CODE_DT2='" & GRU_CODE.Text & "' AND KHAZINA.KHAZINA_CODE='" & KHAZINA_CODE.Text & "' AND KHAZINA_DATE > = '" & DATE_START.Text & "' AND KHAZINA_DATE < = '" & DATE_END.Text & "'AND STAT='TRUE' AND STAT_KHAZINA='TRUE' ORDER BY KHAZINA_DATE")

            End If
        End If
    End Sub
End Class