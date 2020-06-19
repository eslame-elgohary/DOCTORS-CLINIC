Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PATIENTDATA.PATIENT' table. You can move, or remove it, as needed.
        Me.PATIENTTableAdapter.Fill(Me.PATIENTDATA2020.PATIENT)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PATIENTDATA2020.Clear()
        PATIENTTableAdapter.Fill(PATIENTDATA2020.PATIENT)
        DataGridView1.Refresh()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" Then
            BindingSource1.Filter = "pa_code like '%" & TextBox1.Text & "%' or pa_name like '%" & TextBox1.Text & "%'"
        Else
            BindingSource1.Filter = ""
        End If
        DataGridView1.Refresh()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        MsgBox(DataGridView1.SelectedRows.Item(0).Cells.Item(0).Value)
    End Sub
End Class