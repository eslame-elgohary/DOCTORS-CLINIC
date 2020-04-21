Public Class PRICE_THL_FRM
    Sub SHOW_DETA(CODE_)
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM PRICETHLEL WHERE ES_CODE = '" & CODE_ & "'  ", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("الدواء غير موجودة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!ES_CODE
            TXT_MAML_CODE.Text = DR!MAML_CODE
            TXT_MAML_NAME.Text = DR!MAML_NAME
            TXT_THLIL_CODE.Text = DR!THLIL_CODE
            TXT_THLEL_NAME.Text = DR!THLIL_NAME
            PRICE_EG.Text = DR!PRICEEG
            PRICE_LAP.Text = DR!PRICELAP

            EDITBTN.Enabled = True
            DELETBTN.Enabled = True
            SAVEBTN.Enabled = False
        End If
    End Sub
    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles NEWBTN.Click
        TXT_MAML_NAME.Text = ""
        TXT_THLEL_NAME.Text = ""
        PRICE_EG.Text = ""
        PRICE_LAP.Text = ""
        TXT_MAML_CODE.Text = ""
        TXT_THLIL_CODE.Text = ""
        TXT_CODE.Text = ""
        TextBox1.Text = ""
        TXT_MAML_NAME.Select()
        TXT_CODE.Text = CODE_GENE("PRICETHLEL", "ID") + 1
        DELETBTN.Enabled = False
        EDITBTN.Enabled = False
        SAVEBTN.Enabled = True
        FILL_DGV(DataGridView1, "SELECT * FROM PRICETHLEL WHERE STAT='TRUE' ORDER BY ID")
        FILL_MAML()
        FILL_THLEL()
    End Sub
    Sub FILL_MAML()
        TXT_MAML_NAME.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM MAML WHERE STAT = 'TRUE'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_MAML_NAME.Items.Add(DT.Rows(I).Item("MAML_NAME"))
        Next
    End Sub
    Sub FILL_THLEL()
        TXT_THLEL_NAME.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM THALEL WHERE STAT ='TRUE'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TXT_THLEL_NAME.Items.Add(DT.Rows(I).Item("TAH_NAME"))
        Next
    End Sub
    Private Sub PRICE_THL_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEWBTN_Click(sender, e)
    End Sub

    Private Sub PRICE_EG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PRICE_EG.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Then
            Else
                MsgBox("من فضلك ادخل رقم صحيح فقط")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PRICE_LAP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PRICE_LAP.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Then
            Else
                MsgBox("من فضلك ادخل رقم صحيح فقط")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TXT_MAML_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_MAML_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM MAML WHERE MAML_NAME = '" & TXT_MAML_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For S = 0 To DT.Rows.Count - 1
            TXT_MAML_CODE.Text = DT.Rows(S).Item("MAML_CODE")
        Next
    End Sub

    Private Sub TXT_THLEL_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_THLEL_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM THALEL WHERE TAH_NAME = '" & TXT_THLEL_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        For S = 0 To DT.Rows.Count - 1
            TXT_THLIL_CODE.Text = DT.Rows(S).Item("TAH_CODE")
        Next
    End Sub

    Private Sub TXT_MAML_NAME_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_MAML_NAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub TXT_THLEL_NAME_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_THLEL_NAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(7, DataGridView1.CurrentRow.Index).Selected = True Then
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
            DataGridView1.Rows(I).Cells(7).Value = "عرض"
            Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub

    Private Sub PRICE_THL_FRM_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.S AndAlso e.Control Then
            SAVEBTN_Click(sender, e)
        End If
        If e.KeyCode = Keys.E AndAlso e.Control Then
            EDITBTN_Click(sender, e)
        End If
    End Sub

    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("H1").ToString = True Then
                If TXT_MAML_NAME.Text = "" Then
            MessageBox.Show("يرجى ادخال أسم المعمل", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_MAML_NAME.Select()
            Exit Sub
        End If
        If TXT_THLEL_NAME.Text = "" Then
            MessageBox.Show("يرجى ادخال اسم التحليل", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_THLEL_NAME.Select()
            Exit Sub
        End If
        If PRICE_EG.Text = "" Then
            MessageBox.Show("يرجى ادخال سعر مصريين للتحليل", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PRICE_EG.Select()
            Exit Sub
        End If
        If PRICE_LAP.Text = "" Then
            MessageBox.Show("يرجى ادخال سعر معامل التحليل", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PRICE_LAP.Select()
            Exit Sub
        End If

        '===== اجراء تخزين اسم الوحدة ==========
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PRICETHLEL WHERE MAML_NAME = '" & TXT_MAML_NAME.Text & "' AND THLIL_NAME = '" & TXT_THLEL_NAME.Text & "'", SqlConn)
        DA.Fill(DT)

                If DT.Rows.Count > 0 Then
                    MessageBox.Show("أسعار التحاليل موجود مسبقا", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim DR = DT.NewRow
                    DR!ES_CODE = TXT_CODE.Text
                    DR!MAML_CODE = TXT_MAML_CODE.Text
                    DR!MAML_NAME = TXT_MAML_NAME.Text
                    DR!THLIL_CODE = TXT_THLIL_CODE.Text
                    DR!THLIL_NAME = TXT_THLEL_NAME.Text
                    DR!PRICEEG = PRICE_EG.Text
                    DR!PRICELAP = PRICE_LAP.Text
                    DR!STAT = True
                    DT.Rows.Add(DR)
                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    MessageBox.Show("تمت عملية حفظ أسعار التحاليل بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            If DT0.Rows(0).Item("H2").ToString = True Then
                If TXT_MAML_NAME.Text = "" Then
            MessageBox.Show("يرجى ادخال اسم المعمل", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_MAML_NAME.Select()
            Exit Sub
        End If
        If TXT_THLEL_NAME.Text = "" Then
            MessageBox.Show("يرجى ادخال اسم التحليل", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXT_THLEL_NAME.Select()
            Exit Sub
        End If
        If PRICE_EG.Text = "" Then
            MessageBox.Show("يرجى ادخال سعر مصريين للتحليل", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PRICE_EG.Select()
            Exit Sub
        End If
        If PRICE_LAP.Text = "" Then
            MessageBox.Show("يرجى ادخال سعر معامل التحليل", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PRICE_LAP.Select()
            Exit Sub
        End If
        '===== اجراء تعديل اسم الوحدة ==========
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PRICETHLEL WHERE ES_CODE = '" & TXT_CODE.Text & "'", SqlConn)
        DA.Fill(DT)

                If DT.Rows.Count = 0 Then
                    MessageBox.Show("اسم الدواء غير موجود ", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim DR = DT.Rows(0)
                    DR!ES_CODE = TXT_CODE.Text
                    DR!MAML_CODE = TXT_MAML_CODE.Text
                    DR!MAML_NAME = TXT_MAML_NAME.Text
                    DR!THLIL_CODE = TXT_THLIL_CODE.Text
                    DR!THLIL_NAME = TXT_THLEL_NAME.Text
                    DR!PRICEEG = PRICE_EG.Text
                    DR!PRICELAP = PRICE_LAP.Text
                    DR!STAT = True
                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    MessageBox.Show("تمت عملية تعديل سعر التحليل بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            If DT0.Rows(0).Item("H3").ToString = True Then
                If MessageBox.Show("هل ترغب في حذف اسعار التحاليل ؟", "رسالة تنبيه", MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM PRICETHLEL WHERE ES_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)

                If DT.Rows.Count = 0 Then
                    MessageBox.Show("اسعار التحليل غير موجودة ", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim DR = DT.Rows(0)
                    DR!STAT = False

                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    MessageBox.Show("تمت عملية حذف اسعار التحليل بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    NEWBTN_Click(sender, e)
                End If

            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter
        DT.Clear()
        DA = New SqlClient.SqlDataAdapter("SELECT * FROM PRICETHLEL WHERE STAT='TRUE' AND THLIL_NAME LIKE '%" & TextBox1.Text & "%'", SqlConn)
        DA.Fill(DT)
        DataGridView1.DataSource = DT.DefaultView
    End Sub
End Class