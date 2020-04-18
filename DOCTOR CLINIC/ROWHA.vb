Imports System.Management

Public Class ROWHA
    Dim Idp As String
    Dim Idp1 As String
    Dim idp2 As String
    Private Sub REG_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ma_name.Text = My.Computer.Name
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM MAML_T_DT WHERE K ='" & ma_name.Text & "'", SqlConn)
        DA.Fill(DT)
        For I = 0 To DT.Rows.Count - 1
            TextBoxAct2.Text = DT.Rows(I).Item("N")
            TextBoxAct.Text = DT.Rows(I).Item("N")
        Next


        If TextBoxAct.Text = "" Then
            ACTINBTN1.Visible = True
            ACTINBTN2.Visible = False
        Else
            ACTINBTN1.Visible = False
            ACTINBTN2.Visible = True
        End If
        ES()
        If TextBoxAct.Text = Str2Int(TextBoxId.Text + "ESLAMEELGOHARYLOVEREEM") Then

            Me.Close()
        Else
            Dim Searcher As ManagementObjectSearcher
            Searcher = New ManagementObjectSearcher("Select ProcessorId From Win32_Processor")
            For Each Device As ManagementObject In Searcher.Get
                For Each Prop As PropertyData In Device.Properties
                    TextBoxId.Text = (Prop.Value.ToString)
                Next
            Next
            TextBoxId.Text = Str2Int(TextBoxId.Text)
        End If
    End Sub
    Function Str2Int(ByVal InStrng As Object) As String
        Dim StrLn As Integer
        Dim Cntr As Integer
        Dim NewStr As String
        Str2Int = ""
        StrLn = Len(InStrng)
        If StrLn = 0 Then Exit Function
        NewStr = ""
        For Cntr = 1 To StrLn
            Select Case Mid(InStrng, Cntr, 1)
                Case "0" To "z"
                    NewStr = NewStr & Asc(Mid(InStrng, Cntr, 1))
            End Select
        Next Cntr
        Str2Int = NewStr
    End Function
    Sub ES()
        Dim Searcher As ManagementObjectSearcher
        Searcher = New ManagementObjectSearcher("Select ProcessorId From Win32_Processor")
        For Each Device As ManagementObject In Searcher.Get
            For Each Prop As PropertyData In Device.Properties
                TextBoxId.Text = (Prop.Value.ToString)
            Next
        Next
        TextBoxId.Text = Str2Int(TextBoxId.Text)
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles ACTINBTN1.Click

        If TextBoxAct.Text = Str2Int(TextBoxId.Text + "ESLAMEELGOHARYLOVEREEM") Then
            TextBoxAct2.Text = TextBoxAct.Text
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM MAML_T_DT ", SqlConn)
            DA.Fill(DT)
            Dim DR = DT.NewRow
            DR!N = TextBoxAct2.Text
            DR!K = My.Computer.Name
            DT.Rows.Add(DR)
            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            MsgBox("تم التسجيل بنجاح ... شكرا لك")
            Me.Close()
        Else
            MsgBox("التسجيل خاطيء ... يرجي المحاولة مرة أخري", vbCritical)
        End If

        '  If TextBoxUser.Text = TextBoxAct.Text Then
        'MsgBox("تم تفعيل البرنامج شكراً لك")
        '  Else
        'MsgBox("الرقم المدخل خاطئ")
        '  End If

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
        LOGIN.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ACT1.ForeColor = Color.Red Then
            ACT1.ForeColor = Color.Black
        Else
            ACT1.ForeColor = Color.Red
        End If

        If DangerousLAB.ForeColor = Color.Red Then
            DangerousLAB.ForeColor = Color.White
        Else
            DangerousLAB.ForeColor = Color.Red
        End If

    End Sub
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If TextBoxId.Text = Nothing Then MsgBox("Please click the Serial Number Generation button", MsgBoxStyle.Critical, "Error Copying") : Exit Sub
        Clipboard.SetText(TextBoxId.Text)
        TextBoxId.Focus()
        TextBoxId.SelectAll()
        MsgBox("تم نسخ السيريال نمبر يرجى ارسالة للشركة للتفعيل", MsgBoxStyle.Information, "موافق")
    End Sub

    Private Sub SimpleButton4_Click_1(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        TextBoxAct.Text = Clipboard.GetText
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        My.Settings.NAMEPRO = TextBox1.Text
        MsgBox("تم تسجيل أسم العيادة بنجاح ... شكرا لك")
        My.Settings.Save()

    End Sub

    Private Sub ACTINBTN2_Click(sender As Object, e As EventArgs) Handles ACTINBTN2.Click
        If TextBoxAct.Text = Str2Int(TextBoxId.Text + "ESLAMEELGOHARYLOVEREEM") Then
            TextBoxAct2.Text = TextBoxAct.Text
            Dim DT As New DataTable
            Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM MAML_T_DT WHERE K = '" & My.Computer.Name & "'  ", SqlConn)
            DA.Fill(DT)
            Dim DR = DT.Rows(0)
            DR!N = TextBoxAct2.Text
            DR!K = My.Computer.Name

            Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
            DA.Update(DT)
            MsgBox("تم التسجيل بنجاح ... شكرا لك")
            Me.Close()
        Else
            MsgBox("التسجيل خاطيء ... يرجي المحاولة مرة أخري", vbCritical)
        End If
    End Sub

End Class