Imports MySql.Data.MySqlClient
Public Class NETFRM
    Private Sub NETFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlConn2.Close()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        open_connection2()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If SqlConn2.State = 1 Then
            STNET.Text = "متصل"
            STNET.ForeColor = Color.Green
            Dim DTMY As New DataTable
            Dim DAMY As New MySqlDataAdapter(" SELECT  AIADA_STAT FROM aiada ORDER BY ID DESC ", SqlConn2)
            DAMY.Fill(DTMY)
            If DTMY.Rows.Count > 0 Then
                Dim DR2 = DTMY.Rows(0)
                STAT_LAST.Text = DR2!AIADA_STAT

            End If
        Else
            STNET.Text = "غير متصل"
            STNET.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub BTNSEND_Click(sender As Object, e As EventArgs) Handles BTNSEND.Click
        Dim DTMY As New DataTable
        Dim DAMY As New MySqlDataAdapter("SELECT * FROM aiada ", SqlConn2)
        DAMY.Fill(DTMY)
        Dim DR10 = DTMY.NewRow
        DR10!AIADA_STAT = TXT_MASS.Text
        DTMY.Rows.Add(DR10)
        Dim SAVE2 As New MySqlCommandBuilder(DAMY)
        DAMY.Update(DTMY)
        TXT_MASS.Text = ""
    End Sub

    Private Sub SEND_CLOSE_Click(sender As Object, e As EventArgs) Handles SEND_CLOSE.Click
        Dim DTMY As New DataTable
        Dim DAMY As New MySqlDataAdapter("SELECT * FROM aiada ", SqlConn2)
        DAMY.Fill(DTMY)
        Dim DR10 = DTMY.NewRow
        DR10!AIADA_STAT = "العيادة مغلقة الأن"
        DTMY.Rows.Add(DR10)
        Dim SAVE2 As New MySqlCommandBuilder(DAMY)
        DAMY.Update(DTMY)
    End Sub
End Class