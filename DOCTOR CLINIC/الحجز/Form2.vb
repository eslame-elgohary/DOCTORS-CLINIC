Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DOCTOR_CLINICDataSet.IMG_PATIENT' table. You can move, or remove it, as needed.
        'Me.IMG_PATIENTTableAdapter.Fill(Me.DOCTOR_CLINICDataSet.IMG_PATIENT)
        open_connection()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FILL_DGV(DataGridView2, "SELECT PA_NAME, COUNT(PA_NAME) AS nbr FROM PATIENT GROUP BY PA_NAME HAVING (COUNT(PA_NAME) > 1)")
        For Each r As DataGridViewRow In DataGridView2.Rows
            Dim nam As String = r.Cells(1).Value
            Dim tb As New DataTable
            Dim da As New SqlClient.SqlDataAdapter("select id from patient where pa_name='" & nam & "'", SqlConn)
            da.Fill(tb)
            For i As Integer = 1 To tb.Rows.Count - 1
                Dim sql As String = "delete from patient where id=" & CInt(tb.Rows(i)(0))
                Dim cmd As New SqlClient.SqlCommand(sql, SqlConn)
                If SqlConn.State <> ConnectionState.Open Then
                    SqlConn.Open()
                End If
                cmd.ExecuteNonQuery()
            Next
        Next
        MessageBox.Show("TRUE", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        FILL_DGV(DataGridView2, "SELECT PA_NAME, COUNT(PA_NAME) AS nbr FROM PATIENT GROUP BY PA_NAME HAVING (COUNT(PA_NAME) > 1)")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.Filter = "JPG|*.jpg|PNG|*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBox1.Load(OpenFileDialog1.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '        Dim img = IMGPATIENTBindingSource.AddNew

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'IMGPATIENTBindingSource.EndEdit()
        'IMG_PATIENTTableAdapter.Update(DOCTOR_CLINICDataSet.IMG_PATIENT.GetChanges)
    End Sub
End Class