Public Class USERSFRM
    Sub SHOW_DETA(CODE_)
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM ESLAME WHERE CODE_USER = '" & CODE_ & "'  ", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("المستخدم غير موجودة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!CODE_USER
            TXT_USER.Text = DR!NAME_USER
            TXT_PASS.Text = DR!PASS_USER
            TXT_REAL_NAME.Text = DR!REAL_NAME
            EDITBTN.Enabled = True
            DELETBTN.Enabled = True
            SAVEBTN.Enabled = False
        End If
    End Sub
    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles NEWBTN.Click
        TXT_USER.Text = ""
        TXT_PASS.Text = ""
        TXT_REAL_NAME.Text = ""
        TXT_USER.Select()
        TXT_CODE.Text = CODE_GENE("ESLAME", "ID") + 1
        DELETBTN.Enabled = False
        EDITBTN.Enabled = False
        SAVEBTN.Enabled = True
        FILL_DGV(DataGridView1, "SELECT * FROM ESLAME WHERE STAT_USER='TRUE' ORDER BY CODE_USER")
    End Sub

    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub

    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("I1").ToString = True Then

                If TXT_USER.Text = "" Then
                    MessageBox.Show("يرجى ادخال اسم المستخدم", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_USER.Select()
                    Exit Sub
                End If
                If TXT_PASS.Text = "" Then
                    MessageBox.Show("يرجى ادخال الرقم السري للمستخدم", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_PASS.Select()
                    Exit Sub
                End If
                If TXT_REAL_NAME.Text = "" Then
                    MessageBox.Show("يرجى ادخال الأسم الحقيقي للمستخدم", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_REAL_NAME.Select()
                    Exit Sub
                End If

                '===== اجراء تخزين اسم  ==========
                Dim DT As New DataTable

                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ESLAME WHERE NAME_USER = '" & TXT_USER.Text & "'", SqlConn)

                DA.Fill(DT)

                If DT.Rows.Count > 0 Then
                    MessageBox.Show("اسم المستخدم موجود مسبقا", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    TXT_CODE.Text = CODE_GENE("ESLAME", "ID") + 1
                    Dim DR = DT.NewRow
                    DR!CODE_USER = TXT_CODE.Text
                    DR!NAME_USER = TXT_USER.Text
                    DR!PASS_USER = TXT_PASS.Text
                    DR!REAL_NAME = TXT_REAL_NAME.Text
                    DR!STAT_USER = True
                    DT.Rows.Add(DR)
                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    '==============================================================
                    Dim DT2 As New DataTable
                    Dim DS As New SqlClient.SqlDataAdapter("SELECT * FROM ESLAME_SLAH ", SqlConn)
                    DS.Fill(DT2)
                    Dim DR2 = DT2.NewRow
                    DR2!CODE1 = TXT_CODE.Text
                    DR2!KH_CODE = "1"
                    DR2!A = False
                    DR2!A1 = False
                    DR2!A2 = False
                    DR2!A3 = False
                    DR2!A4 = False
                    DR2!B = False
                    DR2!B1 = False
                    DR2!B2 = False
                    DR2!B3 = False
                    DR2!B4 = False
                    DR2!C = False
                    DR2!C1 = False
                    DR2!C2 = False
                    DR2!C3 = False
                    DR2!D = False
                    DR2!D1 = False
                    DR2!D2 = False
                    DR2!D3 = False
                    DR2!A = False
                    DR2!A1 = False
                    DR2!A2 = False
                    DR2!A3 = False
                    DR2!A4 = False
                    DR2!B = False
                    DR2!B1 = False
                    DR2!B2 = False
                    DR2!B3 = False
                    DR2!B4 = False
                    DR2!C = False
                    DR2!C1 = False
                    DR2!C2 = False
                    DR2!C3 = False
                    DR2!D = False
                    DR2!D1 = False
                    DR2!D2 = False
                    DR2!D3 = False
                    DR2!E0 = False
                    DR2!E1 = False
                    DR2!E2 = False
                    DR2!E3 = False
                    DR2!F = False
                    DR2!F1 = False
                    DR2!F2 = False
                    DR2!F3 = False
                    DR2!G = False
                    DR2!G1 = False
                    DR2!G2 = False
                    DR2!G3 = False
                    DR2!H = False
                    DR2!H1 = False
                    DR2!H2 = False
                    DR2!H3 = False
                    DR2!I = False
                    DR2!I1 = False
                    DR2!I2 = False
                    DR2!I3 = False
                    DR2!J = False
                    DR2!J1 = False
                    DR2!k = False
                    DR2!k1 = False
                    DR2!k2 = False
                    DR2!k3 = False
                    DR2!k4 = False
                    DR2!L = False
                    DR2!L1 = False
                    DR2!L2 = False
                    DR2!L3 = False
                    DR2!M = False
                    DR2!M1 = False
                    DR2!M2 = False
                    DR2!M3 = False
                    DR2!M4 = False
                    DR2!N = False
                    DR2!N1 = False
                    DR2!N2 = False
                    DR2!N3 = False
                    DR2!O = False
                    DR2!O1 = False
                    DR2!O2 = False
                    DR2!O3 = False
                    DR2!O4 = False
                    DR2!Q20 = False
                    DR2!Q21 = False
                    DR2!Q22 = False
                    DR2!Q23 = False
                    DR2!Q24 = False
                    DR2!P = False
                    DR2!P1 = False
                    DR2!P2 = False
                    DR2!P3 = False
                    DR2!P4 = False
                    DR2!Q = False
                    DR2!Q1 = False
                    DR2!Q2 = False
                    DR2!Q3 = False
                    DR2!Q4 = False
                    DR2!R = False
                    DR2!R1 = False
                    DR2!R2 = False
                    DR2!R3 = False
                    DR2!R4 = False
                    DR2!UP = False
                    DR2!S100 = False
                    DR2!S101 = False
                    DR2!S102 = False
                    DR2!S103 = False
                    DR2!S104 = False
                    DR2!M100 = False
                    DR2!M101 = False
                    DR2!M102 = False
                    DR2!M103 = False
                    DR2!N100 = False
                    DR2!N101 = False
                    DR2!N102 = False
                    DR2!N103 = False
                    DR2!U = False




                    DT2.Rows.Add(DR2)
                    Dim SAVE1 As New SqlClient.SqlCommandBuilder(DS)
                    DS.Update(DT2)

                    MessageBox.Show("تمت عملية حفظ المستخدم بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    NEWBTN_Click(sender, e)
                End If

            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(3, DataGridView1.CurrentRow.Index).Selected = True Then
            SHOW_DETA(DataGridView1.CurrentRow.Cells(0).Value)
        End If
    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(3).Value = "عرض"
            Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub

    Private Sub EDITBTN_Click(sender As Object, e As EventArgs) Handles EDITBTN.Click

        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("I2").ToString = True Then



                If TXT_USER.Text = "" Then
                    MessageBox.Show("يرجى ادخال اسم المستخدم", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_USER.Select()
                    Exit Sub
                End If
                If TXT_PASS.Text = "" Then
                    MessageBox.Show("يرجى ادخال الرقم السري للمستخدم", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_PASS.Select()
                    Exit Sub
                End If
                If TXT_REAL_NAME.Text = "" Then
                    MessageBox.Show("يرجى ادخال الأسم الحقيقي للمستخدم", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_REAL_NAME.Select()
                    Exit Sub
                End If

                '===== اجراء تعديل اسم الوحدة ==========
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ESLAME WHERE CODE_USER = '" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)

                If DT.Rows.Count = 0 Then
                    MessageBox.Show("اسم المستخدم غير موجود ", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim DR = DT.Rows(0)
                    DR!CODE_USER = TXT_CODE.Text
                    DR!NAME_USER = TXT_USER.Text
                    DR!PASS_USER = TXT_PASS.Text
                    DR!REAL_NAME = TXT_REAL_NAME.Text
                    DR!STAT_USER = True
                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    MessageBox.Show("تمت عملية تعديل المستخدم بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    NEWBTN_Click(sender, e)
                End If

            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub DELETBTN_Click(sender As Object, e As EventArgs) Handles DELETBTN.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("I3").ToString = True Then

                If MessageBox.Show("هل ترغب في حذف المستخدم ؟", "رسالة تنبيه", MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ESLAME WHERE CODE_USER = '" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)

                If DT.Rows.Count = 0 Or 1 Then
                    MessageBox.Show("اسم المستخدم غير موجود أو لا يمكن حذفه ", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim DR = DT.Rows(0)
                    DR!STAT_USER = False

                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    MessageBox.Show("تمت عملية حذف المستخدم بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    NEWBTN_Click(sender, e)
                End If
            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub USERSFRM_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.S AndAlso e.Control Then
            SAVEBTN_Click(sender, e)
        End If
        If e.KeyCode = Keys.E AndAlso e.Control Then
            EDITBTN_Click(sender, e)
        End If
    End Sub

    Private Sub TXT_PASS_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_PASS.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub TXT_REAL_NAME_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_REAL_NAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub TXT_USER_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_USER.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub USERSFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEWBTN_Click(sender, e)
    End Sub
End Class