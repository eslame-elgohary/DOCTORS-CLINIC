Public Class SEARCH_PATIENT
    Private Sub SEARCH_PATIENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FILL_DGV(DataGridView1, "SELECT * FROM PATIENT WHERE STAT = 'TRUE' ORDER BY PA_CODE2")

        PATIENTDATA.Clear()
        PATIENTTableAdapter.Fill(PATIENTDATA.PATIENT)
        DataGridView1.Refresh()

        'SELECTORDER.SelectedIndex = 0
        TextBox1.Select()
    End Sub

    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        'For I As Integer = 0 To DataGridView1.Rows.Count - 1
        '    DataGridView1.Rows(I).Cells(6).Value = "عرض"
        '    Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
        'Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'If SELECTORDER.SelectedIndex = 0 Then
        '    Dim DT As New DataTable
        '    Dim DA As New SqlClient.SqlDataAdapter
        '    DT.Clear()
        '    DA = New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME LIKE '%" & TextBox1.Text & "%'", SqlConn)
        '    DA.Fill(DT)
        '    DataGridView1.DataSource = DT.DefaultView
        'End If
        'If SELECTORDER.SelectedIndex = 1 Then
        '    Dim DT As New DataTable
        '    Dim DA As New SqlClient.SqlDataAdapter
        '    DT.Clear()
        '    DA = New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_TEL LIKE '%" & TextBox1.Text & "%'", SqlConn)
        '    DA.Fill(DT)
        '    DataGridView1.DataSource = DT.DefaultView
        'End If
        'If SELECTORDER.SelectedIndex = 2 Then
        '    Dim DT As New DataTable
        '    Dim DA As New SqlClient.SqlDataAdapter
        '    DT.Clear()
        '    DA = New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_NAME2 LIKE '%" & TextBox1.Text & "%'", SqlConn)
        '    DA.Fill(DT)
        '    DataGridView1.DataSource = DT.DefaultView
        'End If
        'If SELECTORDER.SelectedIndex = 3 Then
        '    Dim DT As New DataTable
        '    Dim DA As New SqlClient.SqlDataAdapter
        '    DT.Clear()
        '    DA = New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_TEL2 LIKE '%" & TextBox1.Text & "%'", SqlConn)
        '    DA.Fill(DT)
        '    DataGridView1.DataSource = DT.DefaultView
        'End If
        'If SELECTORDER.SelectedIndex = 4 Then
        '    Dim DT As New DataTable
        '    Dim DA As New SqlClient.SqlDataAdapter
        '    DT.Clear()
        '    DA = New SqlClient.SqlDataAdapter("SELECT * FROM PATIENT WHERE PA_CODE2 LIKE '%" & TextBox1.Text & "%'", SqlConn)
        '    DA.Fill(DT)
        '    DataGridView1.DataSource = DT.DefaultView
        'End If

        If TextBox1.Text <> "" Then
            PATION_BINDING.Filter = "pa_code like '%" & TextBox1.Text & "%' "
        Else
            PATION_BINDING.Filter = ""
        End If
        DataGridView1.Refresh()



    End Sub
    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        If DataGridView1(6, DataGridView1.CurrentRow.Index).Selected = True Then
            PATIENT.SHOW_DETA(DataGridView1.CurrentRow.Cells(0).Value)
            Me.Close()
        End If
    End Sub

End Class