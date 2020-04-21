Public Class PHARM
    Sub SHOW_DETA(CODE_)
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM PHARM WHERE PH_CODE = '" & CODE_ & "'  ", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("الدواء غير موجودة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!PH_CODE
            TXT_NAME.Text = DR!PH_NAME
            TXT_NO3.Text = DR!PH_NO3
            EDITBTN.Enabled = True
            DELETBTN.Enabled = True
            SAVEBTN.Enabled = False
        End If
    End Sub
    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub

    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles NEWBTN.Click
        TXT_NAME.Text = ""
        TXT_NO3.Text = ""
        TXT_NO3.Select()
        TXT_CODE.Text = CODE_GENE("PHARM", "ID") + 1
        DELETBTN.Enabled = False
        EDITBTN.Enabled = False
        SAVEBTN.Enabled = True
        FILL_DGV(DataGridView1, "SELECT * FROM PHARM WHERE STAT='TRUE' ORDER BY PH_CODE")
    End Sub

    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("D1").ToString = True Then
                If TXT_NO3.Text = "" Then
            MessageBox.Show("يرجى ادخال نوع الدواء", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_NO3.Select()
            Exit Sub
        End If
        If TXT_NAME.Text = "" Then
            MessageBox.Show("يرجى ادخال اسم الدواء", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_NAME.Select()
            Exit Sub
        End If

        '===== اجراء تخزين اسم الوحدة ==========
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PHARM WHERE PH_NAME = '" & TXT_NAME.Text & "'", SqlConn)
        DA.Fill(DT)

                If DT.Rows.Count > 0 Then
                    MessageBox.Show("اسم الدواء موجود مسبقا", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim DR = DT.NewRow
                    DR!PH_CODE = TXT_CODE.Text
                    DR!PH_NAME = TXT_NAME.Text
                    DR!PH_NO3 = TXT_NO3.Text
                    DR!STAT = True
                    DT.Rows.Add(DR)
                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    MessageBox.Show("تمت عملية حفظ الدواء بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    NEWBTN_Click(sender, e)
                End If

            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub EDITBTN_Click(sender As Object, e As EventArgs) Handles EDITBTN.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("D2").ToString = True Then
                If TXT_NO3.Text = "" Then
                    MessageBox.Show("يرجى ادخال نوع الدواء", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_NO3.Select()
                    Exit Sub
                End If
                If TXT_NAME.Text = "" Then
                    MessageBox.Show("يرجى ادخال اسم التخصص", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_NAME.Select()
                    Exit Sub
                End If

                '===== اجراء تعديل اسم الوحدة ==========
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PHARM WHERE PH_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)

                If DT.Rows.Count = 0 Then
                    MessageBox.Show("اسم الدواء غير موجود ", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim DR = DT.Rows(0)
                    DR!PH_CODE = TXT_CODE.Text
                    DR!PH_NAME = TXT_NAME.Text
                    DR!PH_NO3 = TXT_NO3.Text
                    DR!STAT = True
                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    MessageBox.Show("تمت عملية تعديل الدواء بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            If DT0.Rows(0).Item("D3").ToString = True Then
                If MessageBox.Show("هل ترغب في حذف اسم الدواء ؟", "رسالة تنبيه", MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PHARM WHERE PH_CODE = '" & TXT_CODE.Text & "'", SqlConn)
        DA.Fill(DT)

                If DT.Rows.Count = 0 Then
                    MessageBox.Show("اسم الدواء غير موجود ", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim DR = DT.Rows(0)
                    DR!STAT = False

                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    MessageBox.Show("تمت عملية حذف الدواء بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        ''==== اظهار اسم الوحدة في شاشة الاصناف ==========
        'If DataGridView1(2, DataGridView1.CurrentRow.Index).Selected = True Then
        '    ITEMS.TXT_UNIT.Text = DataGridView1.CurrentRow.Cells(0).Value
        '    Me.Close()
        'End If

    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        'For I As Integer = 0 To DataGridView1.Rows.Count - 1
        '    DataGridView1.Rows(I).Cells(2).Value = "إدراج"
        '    Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        'Next
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(3).Value = "عرض"
            Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub

    Private Sub PHARM_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.S AndAlso e.Control Then
            SAVEBTN_Click(sender, e)
        End If
        If e.KeyCode = Keys.E AndAlso e.Control Then
            EDITBTN_Click(sender, e)
        End If
    End Sub

    Private Sub PHARM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEWBTN_Click(sender, e)
    End Sub

    Private Sub TXT_NO3_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_NO3.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub TXT_NAME_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_NAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter
        DT.Clear()
        DA = New SqlClient.SqlDataAdapter("SELECT * FROM PHARM WHERE STAT='TRUE' AND PH_NAME LIKE '%" & TextBox1.Text & "%'", SqlConn)
        DA.Fill(DT)
        DataGridView1.DataSource = DT.DefaultView
    End Sub
End Class