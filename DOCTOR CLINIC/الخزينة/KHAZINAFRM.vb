Public Class KHAZINAFRM
    Sub SHOW_DETA(CODE_)
        Dim DT1 As New DataTable
        Dim DA1 As New SqlClient.SqlDataAdapter(" SELECT * FROM KHAZINA_DT WHERE KHAZINA_CODE = '" & CODE_ & "'  ", SqlConn)
        DA1.Fill(DT1)
        If DT1.Rows.Count > 1 Then
            MessageBox.Show("عفوا فانه يوجد حركات على هذه الخزينة لايمكن التعديل عليها", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM KHAZINA WHERE KHAZINA_CODE = '" & CODE_ & "'  ", SqlConn)
            DA.Fill(DT)
            If DT.Rows.Count = 0 Then
                MessageBox.Show("الخزينة غير موجودة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim DR = DT.Rows(0)
                TXT_CODE.Text = DR!KHAZINA_CODE
                TXT_NAME.Text = DR!KHAZINA_NAME
                TXT_START.Text = DR!KHAZINA_START
                TXT_RASED.Text = "0"

                EDITBTN.Enabled = True
                DELETBTN.Enabled = True
                SAVEBTN.Enabled = False
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
    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles NEWBTN.Click

        TXT_FINAL.Text = ""
        TXT_NAME.Text = ""
        TXT_RASED.Text = "0"
        TXT_START.Text = ""
        TXT_CODE.Text = CODE_GENE("KHAZINA", "ID") + 1
        TXT_NAME.Select()
        Timer1.Enabled = True
        DELETBTN.Enabled = False
        EDITBTN.Enabled = False
        SAVEBTN.Enabled = True
        FILL_DGV(DataGridView1, "SELECT * FROM KHAZINA WHERE STAT='TRUE' ORDER BY KHAZINA_CODE")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TXT_FINAL.Text = Val(TXT_RASED.Text) + Val(TXT_START.Text)
    End Sub

    Private Sub KHAZINAFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEWBTN_Click(sender, e)
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
            If DT0.Rows(0).Item("L1").ToString = True Then

                If TXT_NAME.Text = "" Then
                    MessageBox.Show("يرجى ادخال اسم الخزينة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_NAME.Select()
                    Exit Sub
                End If

                '===== اجراء تخزين اسم الوحدة ==========
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA WHERE KHAZINA_NAME = '" & TXT_NAME.Text & "'", SqlConn)
                DA.Fill(DT)

                If DT.Rows.Count > 0 Then
                    MessageBox.Show("اسم الخزينة موجود مسبقا", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    TXT_CODE.Text = CODE_GENE("KHAZINA", "ID") + 1

                    Dim DR = DT.NewRow
                    DR!KHAZINA_CODE = TXT_CODE.Text
                    DR!KHAZINA_NAME = TXT_NAME.Text

                    DR!KHAZINA_START = Val(TXT_START.Text)

                    DR!STAT = True
                    DT.Rows.Add(DR)
                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    '=============================حركة الخزينة =======================
                    If Val(TXT_START.Text) > 0 Then
                        Dim DTT As New DataTable
                        Dim DAT As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA_DT", SqlConn)
                        DAT.Fill(DTT)

                        Dim DR1 = DTT.NewRow
                        DR1!KHAZINA_CODE = TXT_CODE.Text
                        DR1!KHAZINA_DATE = TXT_DATE.Text
                        DR1!CODE_DT = TXT_CODE.Text
                        DR1!CODE_DT2 = "0"
                        DR1!KHAZINA_NAME_ACTION = "رصيد أفتتاحي"
                        DR1!KHAZINA_IN = Val(TXT_FINAL.Text)
                        DR1!KHAZINA_OUT = "0"
                        DR1!STAT_KHAZINA = True
                        DTT.Rows.Add(DR1)
                        Dim SAVE_ As New SqlClient.SqlCommandBuilder(DAT)
                        DAT.Update(DTT)

                    End If
                    '===============================================================================================

                    MessageBox.Show("تمت عملية حفظ الخزينة بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    NEWBTN_Click(sender, e)
                End If

            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub TXT_START_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_START.KeyPress
        If Char.IsControl(e.KeyChar) = False Then
            If Char.IsDigit(e.KeyChar) Then
            Else
                MsgBox("من فضلك ادخل رقم صحيح فقط")
                e.Handled = True
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
            If DT0.Rows(0).Item("L2").ToString = True Then

                If TXT_NAME.Text = "" Then
                    MessageBox.Show("يرجى ادخال اسم الخزينة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    TXT_NAME.Select()
                    Exit Sub
                End If

                '===== اجراء تخزين اسم الوحدة ==========
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA WHERE KHAZINA_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)

                If DT.Rows.Count = 0 Then
                    MessageBox.Show("اسم الخزينة موجود مسبقا", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim DR = DT.Rows(0)
                    DR!KHAZINA_CODE = TXT_CODE.Text
                    DR!KHAZINA_NAME = TXT_NAME.Text
                    DR!KHAZINA_START = Val(TXT_START.Text)
                    DR!STAT = True

                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    '================ حذف تفاصيل الفاتورة أولاً ثم إضافتها ==========
                    Dim CMD_DEL As New SqlClient.SqlCommand
                    CMD_DEL.Connection = SqlConn
                    CMD_DEL.CommandText = "DELETE FROM KHAZINA_DT WHERE KHAZINA_CODE ='" & TXT_CODE.Text & "'AND CODE_DT2 = '0'"
                    CMD_DEL.ExecuteNonQuery()

                    '=============================حركة الخزينة =======================
                    If Val(TXT_START.Text) > 0 Then
                        Dim DTT As New DataTable
                        Dim DAT As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA_DT", SqlConn)
                        DAT.Fill(DTT)

                        Dim DR1 = DTT.NewRow
                        DR1!KHAZINA_CODE = TXT_CODE.Text
                        DR1!KHAZINA_DATE = TXT_DATE.Text
                        DR1!CODE_DT = TXT_CODE.Text
                        DR1!CODE_DT2 = "0"
                        DR1!KHAZINA_NAME_ACTION = "رصيد أفتتاحي"
                        DR1!KHAZINA_IN = Val(TXT_FINAL.Text)
                        DR1!KHAZINA_OUT = "0"
                        DR1!STAT_KHAZINA = True
                        DTT.Rows.Add(DR1)
                        Dim SAVE_ As New SqlClient.SqlCommandBuilder(DAT)
                        DAT.Update(DTT)

                    End If
                    '===============================================================================================

                    MessageBox.Show("تمت عملية تعديل الخزينة بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            If DT0.Rows(0).Item("L3").ToString = True Then
                If MessageBox.Show("هل ترغب في حذف اسم الدواء ؟", "رسالة تنبيه", MessageBoxButtons.YesNo) = DialogResult.No Then Exit Sub
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA WHERE KHAZINA_CODE = '" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)

                If DT.Rows.Count = 0 Then
                    MessageBox.Show("اسم الخزينة غير موجود ", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim DR = DT.Rows(0)
                    DR!STAT = False
                    Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                    DA.Update(DT)
                    MessageBox.Show("تمت عملية حذف الخزينة بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    NEWBTN_Click(sender, e)
                End If

            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub TXT_NAME_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_NAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub TXT_START_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_START.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub KHAZINAFRM_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.S AndAlso e.Control Then
            SAVEBTN_Click(sender, e)
        End If
        If e.KeyCode = Keys.E AndAlso e.Control Then
            EDITBTN_Click(sender, e)
        End If
    End Sub
End Class