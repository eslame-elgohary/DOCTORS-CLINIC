Imports System.IO
Public Class T3AQOD

    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub
    Private Sub ADD_PHOTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADD_PHOTO.Click
        Try
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
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM IMGS", SqlConn2)
                DA.Fill(DT)
                Dim DR = DT.NewRow
                DR!CODE_T3AKOD = TXT_CODE.Text
                DR!PIC = ARRAY
                DR!URL = A
                DR!STAT = True
                DT.Rows.Add(DR)
                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                NEWBTN_Click(sender, e)
            End If
        Catch ex As Exception
        MessageBox.Show("عفوا هذة ليست صورة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub T3AQOD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NEWBTN_Click(sender, e)
    End Sub

    Private Sub NEWBTN_Click(sender As Object, e As EventArgs) Handles NEWBTN.Click
        FILL_DGV2(DataGridView2, "SELECT * FROM IMGS WHERE CODE_T3AKOD = '" & TXT_CODE.Text & "' AND STAT='TRUE'")
        TXT_CODE.Text = CODE_GENE("T3AKODAT", "ID") + 1
    End Sub
End Class

