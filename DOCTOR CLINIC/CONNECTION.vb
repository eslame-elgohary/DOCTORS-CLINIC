
Imports System.Data.SqlClient
Module CONNECTION
    Public StrID As Integer
    Public SqlConn As New SqlClient.SqlConnection
    '""""""""""""" الاتصال بالسيرفر """""""""""""""
    Public Sub open_connection()
        If SqlConn.State = 1 Then SqlConn.Close()
        Try
            SqlConn = New SqlConnection(My.Settings.sqlconn1)
            SqlConn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    '""""""""""""""""" الترقيم التلقائي """"""""
    Public Function CODE_GENE(TBLNAME, ID_) As Integer
        CODE_GENE = 0
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM " & TBLNAME & " ORDER BY " & ID_ & "", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count <> 0 Then
            Dim I = DT.Rows.Count - 1
            CODE_GENE = Val(DT.Rows(I).Item(ID_))

        End If
    End Function

    '=========== تعبئة الداتا جريد ===================
    Public Sub FILL_DGV(DGV As DataGridView, SQL As String)
        DGV.DataSource = ""
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter(SQL, SqlConn)
        DA.Fill(DT)
        DGV.AutoGenerateColumns = False
        DGV.DataSource = DT.DefaultView
    End Sub
    Public Function CODE_GENE2(TBLNAME, ID2_, DATE_) As Integer
        CODE_GENE2 = 0
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM " & TBLNAME & " WHERE " & DATE_ & " = " & HOME.T_DATE.Text & "  ORDER BY " & ID2_ & "", SqlConn)
        DA.Fill(DT)
        If DT.Rows.Count <> 0 Then
            Dim I = DT.Rows.Count - 1
            CODE_GENE2 = Val(DT.Rows(I).Item(ID2_))

        End If
    End Function

    Public Sub ROLES(ROLEINTBL As String, FRM As Form)

        Dim SQL = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP As New SqlClient.SqlDataAdapter(SQL, SqlConn)
        Dim DS As New DataSet
        ADP.Fill(DS)
        Dim DT = DS.Tables(0)
        If DT.Rows.Count > 0 Then
            If DT.Rows(0).Item("" & ROLEINTBL & "").ToString = True Then
                FRM.ShowDialog()

            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If


    End Sub
    Public Function STRSQL(ByVal ESCAPESQL As String) As String
        ESCAPESQL = ESCAPESQL.Replace("'", "''")
        ESCAPESQL = "'" & ESCAPESQL & "'"
        Return ESCAPESQL
    End Function


End Module
