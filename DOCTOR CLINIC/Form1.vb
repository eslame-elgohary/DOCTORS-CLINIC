Imports System.Data.SqlClient

Public Class Form1
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dread As SqlDataReader

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ''جملة الاتصال
        'con = New SqlConnection("server=.\SQLEXPRESS;database=master;integrated security=true")
        'con.Open()
        'cmd = New SqlCommand("select *  from sysservers  where srvproduct='SQL Server'", con)
        'dread = cmd.ExecuteReader
        'While dread.Read
        '    cmbserver.Items.Add(dread(2))
        'End While
        'dread.Close()
        cmbserver.Text = ".\SQLEXPRESS"
        connection()
        cmbdatabase.Text = "DOCTOR_CLINIC"

    End Sub

    Sub server(ByVal str As String)
       
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

    Private Sub cmbserver_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbserver.SelectedIndexChanged
        connection()
    End Sub

    Sub query(ByVal que As String)
        On Error Resume Next
        cmd = New SqlCommand(que, con)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.WindowState = FormWindowState.Minimized Then
            Me.ShowInTaskbar = False
        Else
            Me.ShowInTaskbar = True
        End If
    End Sub

    Sub blank(ByVal str As String)
        If cmbserver.Text = "" Or cmbdatabase.Text = "" Then
            MsgBox("Server Name & Database Blank Field")
            Exit Sub
        Else
            If str = "backup" Then

                SaveFileDialog1.FileName = cmbdatabase.Text

                SaveFileDialog1.ShowDialog()
                Dim s As String
                s = SaveFileDialog1.FileName & DateTime.Now.ToShortDateString.Replace("/", "-") & "-" & DateTime.Now.ToLongTimeString.Replace(":", "-") & ".BAK"
                Timer2.Enabled = True
                query("backup database " & cmbdatabase.Text & " to disk='" & s & "'")

            ElseIf str = "restore" Then
                OpenFileDialog1.ShowDialog()
            Timer2.Enabled = True
            query("RESTORE DATABASE " & cmbdatabase.Text & " FROM disk='" & OpenFileDialog1.FileName & "'")
        End If
        End If
    End Sub

    Private Sub cmbbackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbbackup.Click
        blank("backup")
    End Sub

    Private Sub cmdrestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdrestore.Click
        'blank("restore")
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Backup.MouseDoubleClick
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub RestoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("سيتم الخروج من البرنامج نهائيا .. هل تريد الاستمرار", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "رسالة تاكيد") = MsgBoxResult.No Then Exit Sub
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

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

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Interval = 1000



        Dim b As Integer
        b = Val(txt_after.Text)
        Dim a As Integer
        If RadioButton1.Checked = True Then
            a = Timer3.Interval * 86400 * b
        ElseIf RadioButton2.Checked = True Then
            a = Timer3.Interval * 3600 * b
        ElseIf RadioButton3.Checked = True Then
            a = Timer3.Interval * 60 * b
        End If
        Timer3.Interval = a
        Label5.Text = a / 1000

        'Timer4.Enabled = True

        Dim filename As String = String.Format("{0}\" & cmbdatabase.Text & "  - {1} - {2}", TextBox1.Text, DateTime.Now.ToShortDateString.Replace("/", "-"), DateTime.Now.ToLongTimeString.Replace(":", "-"))
        Dim strquery As String = "Backup Database " & cmbdatabase.Text & "  to Disk='" & filename & ".Bak'"
        Dim Command = New SqlCommand(strquery, con)
        con.Close()
        con.Open()
        Command.ExecuteNonQuery()
        con.Close()

        'MsgBox("تم عمل نسخة من قاعدة البيانات بنجاح")

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If cmbserver.Text = "" Or cmbdatabase.Text = "" Then
            MsgBox(" برجاء تحديد اسم السيرفر وقاعدة البيانات اولا")
            Exit Sub
        End If
        If CheckBox1.Checked = False Then
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            txt_after.Text = ""
        End If

    End Sub

    Private Sub cmbdatabase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdatabase.SelectedIndexChanged
        If cmbserver.Text <> "" Or cmbdatabase.Text <> "" Then
            CheckBox1.Enabled = True
        Else
            CheckBox1.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ofd As New FolderBrowserDialog
        If ofd.ShowDialog = DialogResult.OK Then
            TextBox1.Text = ofd.SelectedPath
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

        'Label5.Text = Label5.Text - 1

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try


            If CheckBox1.Checked = True And RadioButton1.Checked = True Or RadioButton2.Checked = True Or RadioButton3.Checked = True And txt_after.Text <> "" Then
                If TextBox1.Text = String.Empty Then MessageBox.Show("المسار غير معروف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) : Exit Sub
                Timer3.Enabled = True
                'Dim b As Integer
                'b = Val(txt_after.Text)
                'Dim a As Integer
                'If RadioButton1.Checked = True Then
                '    a = Timer3.Interval * 86400 * b
                'ElseIf RadioButton2.Checked = True Then
                '    a = Timer3.Interval * 3600 * b
                'ElseIf RadioButton3.Checked = True Then
                '    a = Timer3.Interval * 60 * b
                'End If


            Else
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label5.Text = 0
        Timer3.Enabled = False
        'Timer4.Enabled = False

        'Timer3.Stop()
        'Timer4.Stop()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub
End Class