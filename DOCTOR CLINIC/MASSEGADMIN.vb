Public Class MASSEGADMIN
    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub

    Private Sub SENDBTN_Click(sender As Object, e As EventArgs) Handles SENDBTN.Click
        If MASEG_TXT.Text = "" Then
            MsgBox("يجب ان تحتوى الرسالة على كلمات لارسالها ... شكرا لك")
            Exit Sub
        Else
            '================= تخزين بيانات الصنف في قاعدة البيانات =============
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM TP_MASEG ", SqlConn)
            DA.Fill(DT)
            Dim DR = DT.NewRow
            DR!MASSSS = "{" & MASEG_TXT.Text & "}" & Label1.Text
            DR!CODE_U = CODE_U.Text
            DT.Rows.Add(DR)
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            MsgBox("تم أرسال الرسالة بنجاح ... شكرا لك")

            CODE_U.Text = ""
            NAME_U.Text = ""
            MASEG_TXT.Text = ""
        End If
    End Sub

    Private Sub MASSEGADMIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FILL_USERS()
        Label1.Text = HOME.T_USERS.Text
        CODE_U.Text = ""
        NAME_U.Text = ""
        MASEG_TXT.Text = ""
    End Sub
    Sub FILL_USERS()
        NAME_U.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ESLAME WHERE STAT_USER = 'TRUE'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            NAME_U.Items.Add(DT.Rows(I).Item("REAL_NAME"))
        Next
    End Sub
    Private Sub NAME_U_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NAME_U.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ESLAME WHERE REAL_NAME='" & NAME_U.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            CODE_U.Text = DT.Rows(I).Item("CODE_USER")
        Next
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If CODE_U.Text = "" Then
            MsgBox("يرجي أختيار أسم المرسل إليه")
            Exit Sub
        Else
            If MessageBox.Show("هل ترغب في حذف الرسائل المرسلة ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Error) = DialogResult.No Then Exit Sub
            Dim CMD_DEL As New SqlClient.SqlCommand
            CMD_DEL.Connection = SqlConn
            CMD_DEL.CommandText = "DELETE FROM TP_MASEG WHERE CODE_U ='" & CODE_U.Text & "'"
            CMD_DEL.ExecuteNonQuery()
            MsgBox("تم حذف الرسالة بنجاح ... شكرا لك")

            CODE_U.Text = ""
            NAME_U.Text = ""
            MASEG_TXT.Text = ""
        End If
    End Sub

End Class