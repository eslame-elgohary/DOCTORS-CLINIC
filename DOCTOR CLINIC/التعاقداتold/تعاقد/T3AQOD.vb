Imports System.IO

Public Class T3AQOD
    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub
    Private Sub ADD_PHOTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADD_PHOTO.Click

        Dim OFD As New OpenFileDialog
        OFD.Filter = "JPG|*.jpg|PNG|*.png"
        OFD.Multiselect = False
        OFD.Title = "قم بأختيار الصورة"
        If OFD.ShowDialog() = DialogResult.OK Then
            PictureBox1.Load(OFD.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

            Dim A As String = "D:\IMAGE\" & TXT_CODE.Text & "-" & DateTime.Now.ToShortDateString.Replace("/", "-") & "-" & DateTime.Now.ToLongTimeString.Replace(":", "-") & ".jpg"
            PictureBox1.Image.Save(A)

            Dim ARRAY As Byte()
            Dim MS As New IO.MemoryStream
            PictureBox1.Image.Save(MS, PictureBox1.Image.RawFormat)
            ARRAY = MS.GetBuffer

            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM T3AQOD_IMG ", SqlConn)
            DA.Fill(DT)
            Dim DR = DT.NewRow
            DR!CODE_T3AQOD = TXT_CODE.Text
            DR!IMG = ARRAY
            DR!URL = A
            DT.Rows.Add(DR)
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            NEWBTN_Click(sender, e)

        End If
    End Sub

    Private Sub T3AQOD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NEWBTN_Click(sender, e)
    End Sub

    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles NEWBTN.Click

        TXT_CODE.Text = CODE_GENE("T3AKODAT", "ID") + 1
        '=============================================================
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM T3AQOD_IMG WHERE CODE_T3AQOD ='" & TXT_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        DataGridView2.AutoGenerateColumns = False
        DataGridView2.DataSource = DT.DefaultView

    End Sub
    Private Sub DataGridView2_Click(sender As Object, e As EventArgs) Handles DataGridView2.Click
        For Each ROW As DataGridViewRow In DataGridView2.Rows
            If DataGridView2(0, DataGridView2.CurrentRow.Index).Selected = True Then
                SHOW_DETA(DataGridView2.CurrentRow.Cells(1).Value)
            End If
        Next
    End Sub
    Sub SHOW_DETA(CODE_)
        Dim ARRIMG() As Byte
        Dim MS As New IO.MemoryStream
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM T3AQOD_IMG WHERE URL = '" & CODE_ & "' ", SqlConn)
        Dim DT As New DataTable
        DA.Fill(DT)
        If DT.Rows.Count <> 0 Then
            If Not IsDBNull(DT.Rows(0).Item("IMG")) Then
                ARRIMG = DT.Rows(0).Item("IMG")
                For Each ARR As Byte In ARRIMG
                    MS.WriteByte(ARR)
                Next
                PictureBox1.Image = System.Drawing.Image.FromStream(MS)
            End If
        End If
    End Sub

    Private Sub BTN_PRINT_Click(sender As Object, e As EventArgs) Handles BTN_PRINT.Click
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM T3AQOD_IMG WHERE CODE_T3AQOD ='" & TXT_CODE.Text & "'", SqlConn)
        DA.Fill(DT)
        Dim REP As New IMGT3AQOD_CRS
        REP.SetDataSource(DT)
        Dim FRM As New IMGV
        FRM.CrystalReportViewer1.ReportSource = REP
        FRM.ShowDialog()

    End Sub

    Private Sub BTN_DELET_Click(sender As Object, e As EventArgs) Handles BTN_DELET.Click

    End Sub

    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click

    End Sub
End Class

