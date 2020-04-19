Imports System.Data.SqlClient
Public Class BACKUPFRM
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dread As SqlDataReader
    Private Sub BACKUPFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbserver.Text = ".\SQLEXPRESS"
        CONNECTION()
        cmbdatabase.Text = "DOCTOR_CLINIC"
    End Sub
    Sub connection()
        con = New SqlConnection("Data Source=.\SQLEXPRESS; User ID=sa;Password=xyz.1234")

        con.Open()
        cmbdatabase.Items.Clear()
        cmd = New SqlCommand("select * from sysdatabases", con)
        dread = cmd.ExecuteReader
        While dread.Read
            cmbdatabase.Items.Add(dread(0))
        End While
        dread.Close()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If ProgressBar1.Value = 100 Then
            Timer2.Enabled = False
            MsgBox("تمت العملية بنجاح")
            ProgressBar1.Value = 0.25
        Else
            ProgressBar1.Value = ProgressBar1.Value + 5
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        SaveFileDialog1.FileName = cmbdatabase.Text
        'cmbdatabase.Text = "D:\BACKUP"
        'SaveFileDialog1.ShowDialog()
        Dim s As String
        s = "\\192.168.1.111\backup\KARMA-SOFT-DOCTORS-CLINIC-" & DateTime.Now.ToShortDateString.Replace("/", "-") & "-" & DateTime.Now.ToLongTimeString.Replace(":", "-") & ".BAK"
        Timer2.Enabled = True
        query("backup database " & cmbdatabase.Text & " to disk='" & s & "'")
    End Sub
    Sub query(ByVal que As String)
        On Error Resume Next
        cmd = New SqlCommand(que, con)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
End Class