Public Class test
    Dim da As SqlClient.SqlDataAdapter
    Dim tb As DataTable
    Dim selectcmd As SqlClient.SqlCommand
    Dim bld As SqlClient.SqlCommandBuilder
    Dim bnew As Boolean
    Dim row As DataRow
    Dim lastupdate As Guid
    Private Sub test_Load(sender As Object, e As EventArgs) Handles Me.Load

        selectcmd = New SqlClient.SqlCommand("select * from test", SqlConn)
        da = New SqlClient.SqlDataAdapter(selectcmd)
        bld = New SqlClient.SqlCommandBuilder(da)

        da.UpdateCommand = bld.GetUpdateCommand
        da.InsertCommand = bld.GetInsertCommand
        da.DeleteCommand = bld.GetDeleteCommand
        tb = New DataTable
        da.Fill(tb)

        read()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        bnew = True
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If bnew Then
            row = tb.NewRow
        End If
        row.BeginEdit()
        row("Code") = TextBox1.Text
        row("Name") = TextBox2.Text
        If bnew = False Then
            Dim cmdupd As New SqlClient.SqlCommand("select lastupdate,CODE from test where code='" & TextBox1.Text & "'", SqlConn)
            Dim s As Guid
            If Guid.TryParse(cmdupd.ExecuteScalar().ToString, s) Then
                If s.ToString <> lastupdate.ToString And lastupdate.ToString IsNot Guid.Empty.ToString Then
                    MsgBox("your data is modified by another user, press read to get last changes of data")
                    Exit Sub
                End If
            End If
            row("lastupdate") = Guid.NewGuid
        End If
        row.EndEdit()
        If bnew Then
            tb.Rows.Add(row)
        End If
        Try

            da.Update(tb.GetChanges)
            Button2_Click(Nothing, Nothing)
        Catch ex As Exception

            MsgBox("your data is modified by another user, press read to get last changes of data" & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tb.Clear()
        row = Nothing
        da.Fill(tb)
        If TextBox1.Text <> "" Then
            Dim f = (From lst As DataRow In tb.Rows Where lst("Code") = TextBox1.Text).FirstOrDefault
            If f Is Nothing Then
                MsgBox("not exist")
            Else
                row = f
                TextBox1.Text = row("Code")
                TextBox2.Text = row("Name")
                Try
                    Guid.TryParse(row("lastupdate").ToString, lastupdate)
                Catch ex As Exception

                End Try

                bnew = False
                TextBox2.Focus()
            End If
        End If
    End Sub
    Private Sub read()
        Dim da2 As SqlClient.SqlDataAdapter
        If TextBox3.Text = "" Then
            da2 = New SqlClient.SqlDataAdapter("select * from test", SqlConn)
        Else
            da2 = New SqlClient.SqlDataAdapter("select * from test where code='" & TextBox3.Text & "' or name like '%" & TextBox3.Text & "%'", SqlConn)
        End If
        tb.Clear()
        da2.Fill(tb)
        Me.DataGridView1.DataSource = tb
        DataGridView1.Refresh()
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cmd As New SqlClient.SqlCommand()
        cmd.Connection = SqlConn
        For i As Integer = 2 To 10000
            cmd.CommandText = "insert into test (code,name) values(" & i & "," & (New Random).NextDouble & ")"
            cmd.ExecuteNonQuery()
        Next
        MsgBox("termine")
    End Sub

    Private Sub TextBox3_LostFocus(sender As Object, e As EventArgs) Handles TextBox3.LostFocus
        read()
    End Sub
End Class