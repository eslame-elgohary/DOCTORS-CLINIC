Public Class EMP_FRM
    Sub SHOW_DETA(CODE_)
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM EMP WHERE EMP_CODE = '" & CODE_ & "'", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("الدواء غير موجودة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            TXT_CODE.Text = DR!EMP_CODE
            TXT_NAME.Text = DR!EMP_NAME
            TXT_HDOR.Text = DR!EMP_HDOR
            TXT_ENSRAF.Text = DR!EMP_ENSRAF
            TXT_RATEB.Text = DR!EMP_MORTAB
            TXT_DQAQ.Text = DR!EMP_DQAQ
            TXT_DQAQ_MONY.Text = DR!EMP_MONY_DQAQ
            SAVEBTN.Enabled = False
            EDITBTN.Enabled = True
            DELETBTN.Enabled = True
        End If

    End Sub
    Private Sub EMP_FRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEWBTN_Click(sender, e)
    End Sub
    Sub D2E2A()

        Dim time1 As Date = Date.Parse(Me.TXT_HDOR.Text)
        Dim time2 As Date = Date.Parse(Me.TXT_ENSRAF.Text)

        TXT_DQAQ.Text = DateDiff(DateInterval.Minute, time1, time2)

    End Sub
    Sub THWEL()
        Dim TOTAL As Double
        TOTAL = Val(TXT_RATEB.Text) \ 26

        TXT_DQAQ_MONY.Text = Val(TOTAL) / Val(TXT_DQAQ.Text)

    End Sub

    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click
        D2E2A()
        If TXT_DQAQ.Text < 420 Then
            MessageBox.Show("لا يمكن عمل الموظف أقل من 7 ساعات")
            Exit Sub
        End If
        THWEL()
        If TXT_DQAQ_MONY.Text = 0 Then
            MessageBox.Show("يجب أن يحصل الموظف على راتب")
            Exit Sub
        End If
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM EMP WHERE EMP_NAME = '" & TXT_NAME.Text & "'", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.NewRow
        DR!EMP_CODE = TXT_CODE.Text
        DR!EMP_NAME = TXT_NAME.Text
        DR!EMP_HDOR = TXT_HDOR.Text
        DR!EMP_ENSRAF = TXT_ENSRAF.Text
        DR!EMP_MORTAB = TXT_RATEB.Text
        DR!EMP_DQAQ = TXT_DQAQ.Text
        DR!EMP_MONY_DQAQ = TXT_DQAQ_MONY.Text
        DR!EMP_STAT = True
        DT.Rows.Add(DR)
        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)

        MessageBox.Show("تمت عملية الحفظ بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        NEWBTN_Click(sender, e)

    End Sub

    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Dispose()
    End Sub

    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles NEWBTN.Click
        '""""""""""""""" تنظيف الشاشة """""""""""""
        For I = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(I) Is TextBox Then GroupBox1.Controls(I).Text = ""
        Next
        TXT_HDOR.Text = Date.Now.ToString("HH:mm")
        TXT_ENSRAF.Text = Date.Now.ToString("HH:mm")
        '=========================================================
        TXT_CODE.Text = CODE_GENE("EMP", "ID") + 1
        FILL_DGV(DataGridView1, "SELECT * FROM EMP WHERE EMP_STAT='TRUE'")
        TXT_NAME.Select()
        SAVEBTN.Enabled = True
        EDITBTN.Enabled = False
        DELETBTN.Enabled = False
    End Sub

    Private Sub EDITBTN_Click(sender As Object, e As EventArgs) Handles EDITBTN.Click
        D2E2A()
        If TXT_DQAQ.Text < 420 Then
            MessageBox.Show("لا يمكن عمل الموظف أقل من 7 ساعات")
            Exit Sub
        End If
        THWEL()
        If TXT_DQAQ_MONY.Text = 0 Then
            MessageBox.Show("يجب أن يحصل الموظف على راتب")
            Exit Sub
        End If

        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM EMP WHERE EMP_CODE = '" & TXT_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        Dim DR = DT.Rows(0)
        DR!EMP_CODE = TXT_CODE.Text
        DR!EMP_NAME = TXT_NAME.Text
        DR!EMP_HDOR = TXT_HDOR.Text
        DR!EMP_ENSRAF = TXT_ENSRAF.Text
        DR!EMP_MORTAB = TXT_RATEB.Text
        DR!EMP_DQAQ = TXT_DQAQ.Text
        DR!EMP_MONY_DQAQ = TXT_DQAQ_MONY.Text
        DR!EMP_STAT = True

        Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
        DA.Update(DT)

        MessageBox.Show("تمت عملية التعديل بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        NEWBTN_Click(sender, e)
    End Sub

    Private Sub DELETBTN_Click(sender As Object, e As EventArgs) Handles DELETBTN.Click
        If MessageBox.Show("هل ترغب فى حذف بيانات الموظف", "أنتبه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        Else

            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM EMP WHERE EMP_CODE = '" & TXT_CODE.Text & "'", SqlConn)
            DA.Fill(DT)
            Dim DR = DT.Rows(0)
            DR!EMP_STAT = False

            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)

            MessageBox.Show("تمت عملية الحذف بنجاح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            NEWBTN_Click(sender, e)

        End If

    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(4, DataGridView1.CurrentRow.Index).Selected = True Then
            SHOW_DETA(DataGridView1.CurrentRow.Cells(0).Value)
        End If
    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            DataGridView1.Rows(I).Cells(4).Value = "عرض"
            Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        Next
    End Sub

    Private Sub TXT_SEARCH_TextChanged(sender As Object, e As EventArgs) Handles TXT_SEARCH.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter
        DT.Clear()
        DA = New SqlClient.SqlDataAdapter("SELECT * FROM EMP WHERE EMP_STAT='TRUE' AND EMP_NAME LIKE '%" & TXT_SEARCH.Text & "%'", SqlConn)
        DA.Fill(DT)
        DataGridView1.DataSource = DT.DefaultView
    End Sub
End Class