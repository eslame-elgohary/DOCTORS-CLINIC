Public Class LOGIN
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        open_connection()
        'open_connection2()
        FILL_USERS()
        If My.Settings.SERIALUSER = "" Then
            ROWHA.ShowDialog()
        Else
            If My.Settings.SERIALUSER = ROWHA.TextBoxAct.Text Then
                USER1.Select()
            Else
                ROWHA.ShowDialog()
            End If
        End If

    End Sub

    Private Sub password_KeyDown(sender As Object, e As KeyEventArgs) Handles password.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub
    Sub FILL_USERS()
        USER1.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ESLAME WHERE STAT_USER = 'TRUE'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            USER1.Items.Add(DT.Rows(I).Item("NAME_USER"))
        Next

    End Sub

    Private Sub USER1_KeyDown(sender As Object, e As KeyEventArgs) Handles USER1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub USER1_TextChanged(sender As Object, e As EventArgs) Handles USER1.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ESLAME WHERE NAME_USER = '" & USER1.Text & "'", SqlConn)
        DA.Fill(DT)
        For S = 0 To DT.Rows.Count - 1
            PASS1.Text = DT.Rows(S).Item("PASS_USER")
            REALY_NAME.Text = DT.Rows(S).Item("REAL_NAME")
            CODE_USER.Text = DT.Rows(S).Item("CODE_USER")
            'TXT_TYPE.Text = DT.Rows(S).Item("USER_TYPE")
        Next
    End Sub

    Private Sub EXITBUTTON_Click_1(sender As Object, e As EventArgs) Handles EXITBUTTON.Click
        Me.Close()
    End Sub

    Private Sub ENTERBUTTON_Click_1(sender As Object, e As EventArgs) Handles ENTERBUTTON.Click
        If USER1.Text = "" Then
            MessageBox.Show(" برجاء كتابة أختيار أسم المستخدم ", "أنتبة!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            USER1.Select()
        Else
            If password.Text = "" Then
                MessageBox.Show(" برجاء كتابة كلمة السر ", "أنتبة!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                password.Select()
            Else
                If password.Text = Val(PASS1.Text) Then
                    ProgressBar1.Visible = True
                    Timer2.Enabled = True


                    '"""""""""""""""""""""""""""""""""""""""""""""
                    Dim DT As New DataTable
                    Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ESLAME_LO ", SqlConn)
                    DA.Fill(DT)
                    Dim DR = DT.NewRow
                    DR!REALY_NAME = REALY_NAME.Text
                    DR!CODE_USER = CODE_USER.Text
                    DR!DATE_LOGIN = Date.Today
                    DR!MA = My.Computer.Name
                    DT.Rows.Add(DR)
                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    '"""""""""""""""""""""""""""""""""""""""""""""""""""""""""
                Else
                    MessageBox.Show(" كلمة السر غير صحيحة ", "أنتبة!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    password.Text = ""
                    password.Select()
                End If
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If NAMEPROLAB.ForeColor = Color.Maroon Then
            NAMEPROLAB.ForeColor = Color.White
        Else
            NAMEPROLAB.ForeColor = Color.Maroon
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If ProgressBar1.Value = 100 Then
            ProgressBar1.Visible = False
            Timer2.Enabled = False
            HOME.Show()
            Me.Close()
            ProgressBar1.Value = 0.25
        Else
            ProgressBar1.Value = ProgressBar1.Value + 5
        End If
    End Sub
End Class