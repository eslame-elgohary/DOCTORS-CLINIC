Public Class USERSLAHFRM
    Private Sub TXT_USER_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXT_USER.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ESLAME WHERE NAME_USER = '" & TXT_USER.Text & "'", SqlConn)
        DA.Fill(DT)
        For S = 0 To DT.Rows.Count - 1
            TXT_CODE.Text = DT.Rows(S).Item("CODE_USER")
        Next
        GRS.Visible = False
    End Sub

    Private Sub USERSLAHFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FILL_USERS()
        FILL_KHAZINA()
        GRS.Visible = False
        TXT_CODE.Text = ""
        TXT_USER.Text = ""
        TXT_USER.Select()
    End Sub
    Sub FILL_USERS()
        TXT_USER.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ESLAME WHERE STAT_USER ='TRUE'", SqlConn)
        DA.Fill(DT)
        For IA = 0 To DT.Rows.Count - 1
            TXT_USER.Items.Add(DT.Rows(IA).Item("NAME_USER"))
        Next
    End Sub

    Private Sub BTNACTIVE_Click(sender As Object, e As EventArgs) Handles BTNACTIVE.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("J1").ToString = True Then
                GRS.Visible = True
                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter(" SELECT * FROM ESLAME_SLAH WHERE CODE1 = '" & TXT_CODE.Text & "'  ", SqlConn)
                DA.Fill(DT)

                Dim DR = DT.Rows(0)
                KHAZINA_CODE.Text = DR!KH_CODE
                A.Checked = DR!A
                A1.Checked = DR!A1
                A2.Checked = DR!A2
                A3.Checked = DR!A3
                A4.Checked = DR!A4

                B.Checked = DR!B
                B1.Checked = DR!B1
                B2.Checked = DR!B2
                B3.Checked = DR!B3
                B4.Checked = DR!B4

                C.Checked = DR!C
                C1.Checked = DR!C1
                C2.Checked = DR!C2
                C3.Checked = DR!C3

                D.Checked = DR!D
                D1.Checked = DR!D1
                D2.Checked = DR!D2
                D3.Checked = DR!D3

                E0.Checked = DR!E0
                E1.Checked = DR!E1
                E2.Checked = DR!E2
                E3.Checked = DR!E3

                F.Checked = DR!F
                F1.Checked = DR!F1
                F2.Checked = DR!F2
                F3.Checked = DR!F3

                G.Checked = DR!G
                G1.Checked = DR!G1
                G2.Checked = DR!G2
                G3.Checked = DR!G3

                H.Checked = DR!H
                H1.Checked = DR!H1
                H2.Checked = DR!H2
                H3.Checked = DR!H3

                I.Checked = DR!I
                I1.Checked = DR!I1
                I2.Checked = DR!I2
                I3.Checked = DR!I3

                J.Checked = DR!J
                J1.Checked = DR!J1

                K.Checked = DR!K
                K1.Checked = DR!K1
                K2.Checked = DR!K2
                K3.Checked = DR!K3
                K4.Checked = DR!K4

                L.Checked = DR!L
                L1.Checked = DR!L1
                L2.Checked = DR!L2
                L3.Checked = DR!L3

                M.Checked = DR!M
                M1.Checked = DR!M1
                M2.Checked = DR!M2
                M3.Checked = DR!M3
                M4.Checked = DR!M4

                N.Checked = DR!N
                N1.Checked = DR!N1
                N2.Checked = DR!N2
                N3.Checked = DR!N3

                O.Checked = DR!O
                O1.Checked = DR!O1
                O2.Checked = DR!O2
                O3.Checked = DR!O3
                O4.Checked = DR!O4

                P.Checked = DR!P
                P1.Checked = DR!P1
                P2.Checked = DR!P2
                P3.Checked = DR!P3
                P4.Checked = DR!P4

                Q.Checked = DR!Q
                Q1.Checked = DR!Q1
                Q2.Checked = DR!Q2
                Q3.Checked = DR!Q3
                Q4.Checked = DR!Q4

                R.Checked = DR!R
                R1.Checked = DR!R1
                R2.Checked = DR!R2
                R3.Checked = DR!R3
                R4.Checked = DR!R4

                UP.Checked = DR!UP

                Q20.Checked = DR!Q20
                Q21.Checked = DR!Q21
                Q22.Checked = DR!Q22
                Q23.Checked = DR!Q23
                Q24.Checked = DR!Q24

                N100.Checked = DR!N100
                N101.Checked = DR!N101
                N102.Checked = DR!N102
                N103.Checked = DR!N103

                M100.Checked = DR!M100
                M101.Checked = DR!M101
                M102.Checked = DR!M102
                M103.Checked = DR!M103

                S100.Checked = DR!S100
                S101.Checked = DR!S101
                S102.Checked = DR!S102
                S103.Checked = DR!S103
                S104.Checked = DR!S104

                U.Checked = DR!U

                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub A_CheckedChanged(sender As Object, e As EventArgs) Handles A.CheckedChanged
        If A.Checked = False Then

            A1.Checked = False
            A2.Checked = False
            A3.Checked = False
            A4.Checked = False

            A1.Enabled = False
            A2.Enabled = False
            A3.Enabled = False
            A4.Enabled = False
        Else
            A1.Enabled = True
            A2.Enabled = True
            A3.Enabled = True
            A4.Enabled = True

        End If
    End Sub

    Private Sub SAVEBTN_Click(sender As Object, e As EventArgs) Handles SAVEBTN.Click
        Dim SQL0 = "SELECT* FROM ESLAME_SLAH WHERE CODE1 ='" & (HOME.CODE_USERBT.Text) & "' "
        Dim ADP0 As New SqlClient.SqlDataAdapter(SQL0, SqlConn)
        Dim DS0 As New DataSet
        ADP0.Fill(DS0)
        Dim DT0 = DS0.Tables(0)
        If DT0.Rows.Count > 0 Then
            If DT0.Rows(0).Item("J1").ToString = True Then
                If KHAZINA_NAME.Text = "" Then
                    MessageBox.Show("يرجى أدخال أسم الخزينة الأفتراضية ؟", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    KHAZINA_NAME.Select()
                    Exit Sub
                End If

                Dim DT As New DataTable
                Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM ESLAME_SLAH WHERE CODE1 = '" & TXT_CODE.Text & "'", SqlConn)
                DA.Fill(DT)

                Dim DR = DT.Rows(0)
                DR!KH_CODE = KHAZINA_CODE.Text
                DR!CODE1 = TXT_CODE.Text
                DR!A = A.Checked
                DR!A1 = A1.Checked
                DR!A2 = A2.Checked
                DR!A3 = A3.Checked
                DR!A4 = A4.Checked

                DR!B = B.Checked
                DR!B1 = B1.Checked
                DR!B2 = B2.Checked
                DR!B3 = B3.Checked
                DR!B4 = B4.Checked

                DR!C = C.Checked
                DR!C1 = C1.Checked
                DR!C2 = C2.Checked
                DR!C3 = C3.Checked

                DR!D = D.Checked
                DR!D1 = D1.Checked
                DR!D2 = D2.Checked
                DR!D3 = D3.Checked

                DR!E0 = E0.Checked
                DR!E1 = E1.Checked
                DR!E2 = E2.Checked
                DR!E3 = E3.Checked

                DR!F = F.Checked
                DR!F1 = F1.Checked
                DR!F2 = F2.Checked
                DR!F3 = F3.Checked

                DR!G = G.Checked
                DR!G1 = G1.Checked
                DR!G2 = G2.Checked
                DR!G3 = G3.Checked

                DR!H = H.Checked
                DR!H1 = H1.Checked
                DR!H2 = H2.Checked
                DR!H3 = H3.Checked

                DR!I = I.Checked
                DR!I1 = I1.Checked
                DR!I2 = I2.Checked
                DR!I3 = I3.Checked

                DR!J = J.Checked
                DR!J1 = J1.Checked

                DR!K = K.Checked
                DR!K1 = K1.Checked
                DR!K2 = K2.Checked
                DR!K3 = K3.Checked
                DR!K4 = K4.Checked

                DR!L = L.Checked
                DR!L1 = L1.Checked
                DR!L2 = L2.Checked
                DR!L3 = L3.Checked

                DR!M = M.Checked
                DR!M1 = M1.Checked
                DR!M2 = M2.Checked
                DR!M3 = M3.Checked
                DR!M4 = M4.Checked

                DR!N = N.Checked
                DR!N1 = N1.Checked
                DR!N2 = N2.Checked
                DR!N3 = N3.Checked

                DR!O = O.Checked
                DR!O1 = O1.Checked
                DR!O2 = O2.Checked
                DR!O3 = O3.Checked
                DR!O4 = O4.Checked

                DR!P = P.Checked
                DR!P1 = P1.Checked
                DR!P2 = P2.Checked
                DR!P3 = P3.Checked
                DR!P4 = P4.Checked

                DR!Q = Q.Checked
                DR!Q1 = Q1.Checked
                DR!Q2 = Q2.Checked
                DR!Q3 = Q3.Checked
                DR!Q4 = Q4.Checked

                DR!R = R.Checked
                DR!R1 = R1.Checked
                DR!R2 = R2.Checked
                DR!R3 = R3.Checked
                DR!R4 = R4.Checked

                DR!UP = UP.Checked

                DR!Q20 = Q20.Checked
                DR!Q21 = Q21.Checked
                DR!Q22 = Q22.Checked
                DR!Q23 = Q23.Checked
                DR!Q24 = Q24.Checked

                DR!N100 = N100.Checked
                DR!N101 = N101.Checked
                DR!N102 = N102.Checked
                DR!N103 = N103.Checked

                DR!M100 = M100.Checked
                DR!M101 = M101.Checked
                DR!M102 = M102.Checked
                DR!M103 = M103.Checked

                DR!S100 = S100.Checked
                DR!S101 = S101.Checked
                DR!S102 = S102.Checked
                DR!S103 = S103.Checked
                DR!S104 = S104.Checked

                DR!U = U.Checked

                Dim SAVE As New SqlClient.SqlCommandBuilder(DA)
                DA.Update(DT)
                MessageBox.Show("تمت عملية حفظ الصلاحيات بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GRS.Visible = False
                TXT_CODE.Text = ""
                TXT_USER.Text = ""
                TXT_USER.Select()

            Else
                MessageBox.Show("عفوا ليس لديك صلاحية برجاء مراجعة الأدارة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub

    Private Sub B_CheckedChanged(sender As Object, e As EventArgs) Handles B.CheckedChanged
        If B.Checked = False Then
            B1.Checked = False
            B2.Checked = False
            B3.Checked = False
            B4.Checked = False
            B1.Enabled = False
            B2.Enabled = False
            B3.Enabled = False
            B4.Enabled = False
        Else
            B1.Enabled = True
            B2.Enabled = True
            B3.Enabled = True
            B4.Enabled = True

        End If
    End Sub

    Private Sub C_CheckedChanged(sender As Object, e As EventArgs) Handles C.CheckedChanged
        If C.Checked = False Then
            C1.Checked = False
            C2.Checked = False
            C3.Checked = False

            C1.Enabled = False
            C2.Enabled = False
            C3.Enabled = False
        Else
            C1.Enabled = True
            C2.Enabled = True
            C3.Enabled = True


        End If
    End Sub

    Private Sub D_CheckedChanged(sender As Object, e As EventArgs) Handles D.CheckedChanged
        If D.Checked = False Then
            D1.Checked = False
            D2.Checked = False
            D3.Checked = False
            D1.Enabled = False
            D2.Enabled = False
            D3.Enabled = False
        Else
            D1.Enabled = True
            D2.Enabled = True
            D3.Enabled = True
        End If
    End Sub

    Private Sub E0_CheckedChanged(sender As Object, e As EventArgs) Handles E0.CheckedChanged
        If E0.Checked = False Then
            E1.Checked = False
            E2.Checked = False
            E3.Checked = False
            E1.Enabled = False
            E2.Enabled = False
            E3.Enabled = False
        Else
            E1.Enabled = True
            E2.Enabled = True
            E3.Enabled = True
        End If
    End Sub

    Private Sub F_CheckedChanged(sender As Object, e As EventArgs) Handles F.CheckedChanged
        If F.Checked = False Then
            F1.Checked = False
            F2.Checked = False
            F3.Checked = False
            F1.Enabled = False
            F2.Enabled = False
            F3.Enabled = False
        Else
            F1.Enabled = True
            F2.Enabled = True
            F3.Enabled = True
        End If
    End Sub

    Private Sub G_CheckedChanged(sender As Object, e As EventArgs) Handles G.CheckedChanged
        If G.Checked = False Then
            G1.Checked = False
            G2.Checked = False
            G3.Checked = False
            G1.Enabled = False
            G2.Enabled = False
            G3.Enabled = False
        Else
            G1.Enabled = True
            G2.Enabled = True
            G3.Enabled = True
        End If
    End Sub

    Private Sub H_CheckedChanged(sender As Object, e As EventArgs) Handles H.CheckedChanged
        If H.Checked = False Then
            H1.Checked = False
            H2.Checked = False
            H3.Checked = False
            H1.Enabled = False
            H2.Enabled = False
            H3.Enabled = False
        Else
            H1.Enabled = True
            H2.Enabled = True
            H3.Enabled = True
        End If
    End Sub

    Private Sub I_CheckedChanged(sender As Object, e As EventArgs) Handles I.CheckedChanged
        If I.Checked = False Then
            I1.Checked = False
            I2.Checked = False
            I3.Checked = False
            I1.Enabled = False
            I2.Enabled = False
            I3.Enabled = False
        Else
            I1.Enabled = True
            I2.Enabled = True
            I3.Enabled = True
        End If
    End Sub

    Private Sub J_CheckedChanged(sender As Object, e As EventArgs) Handles J.CheckedChanged
        If J.Checked = False Then
            J1.Checked = False
            J1.Enabled = False

        Else
            J1.Enabled = True

        End If
    End Sub

    Private Sub EXITBTN_Click(sender As Object, e As EventArgs) Handles EXITBTN.Click
        Me.Close()
    End Sub

    Private Sub K_CheckedChanged(sender As Object, e As EventArgs) Handles K.CheckedChanged
        If K.Checked = False Then
            K1.Checked = False
            K2.Checked = False
            K3.Checked = False
            K4.Checked = False
            K1.Enabled = False
            K2.Enabled = False
            K3.Enabled = False
            K4.Enabled = False
        Else
            K1.Enabled = True
            K2.Enabled = True
            K3.Enabled = True
            K4.Enabled = True
        End If
    End Sub

    Private Sub L_CheckedChanged(sender As Object, e As EventArgs) Handles L.CheckedChanged
        If L.Checked = False Then
            L1.Checked = False
            L2.Checked = False
            L3.Checked = False

            L1.Enabled = False
            L2.Enabled = False
            L3.Enabled = False

        Else
            L1.Enabled = True
            L2.Enabled = True
            L3.Enabled = True

        End If
    End Sub

    Sub FILL_KHAZINA()
        KHAZINA_NAME.Items.Clear()
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA WHERE STAT ='TRUE'", SqlConn)
        DA.Fill(DT)
        For IA = 0 To DT.Rows.Count - 1
            KHAZINA_NAME.Items.Add(DT.Rows(IA).Item("KHAZINA_NAME"))
        Next
    End Sub

    Private Sub KHAZINA_NAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KHAZINA_NAME.SelectedIndexChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA WHERE KHAZINA_NAME ='" & (KHAZINA_NAME.Text) & "' ", SqlConn)
        DA.Fill(DT)
        For I9 = 0 To DT.Rows.Count - 1
            KHAZINA_CODE.Text = DT.Rows(I9).Item("KHAZINA_CODE")
        Next
    End Sub

    Private Sub KHAZINA_CODE_TextChanged(sender As Object, e As EventArgs) Handles KHAZINA_CODE.TextChanged
        Dim DT As New DataTable
        Dim DA As New SqlClient.SqlDataAdapter("SELECT * FROM KHAZINA WHERE KHAZINA_CODE ='" & (KHAZINA_CODE.Text) & "' ", SqlConn)
        DA.Fill(DT)
        For I9 = 0 To DT.Rows.Count - 1
            KHAZINA_NAME.Text = DT.Rows(I9).Item("KHAZINA_NAME")
        Next
    End Sub

    Private Sub N_CheckedChanged(sender As Object, e As EventArgs) Handles N.CheckedChanged
        If N.Checked = False Then
            N1.Checked = False
            N2.Checked = False
            N3.Checked = False

            N1.Enabled = False
            N2.Enabled = False
            N3.Enabled = False

        Else
            N1.Enabled = True
            N2.Enabled = True
            N3.Enabled = True

        End If
    End Sub

    Private Sub M_CheckedChanged(sender As Object, e As EventArgs) Handles M.CheckedChanged
        If M.Checked = False Then
            M1.Checked = False
            M2.Checked = False
            M3.Checked = False
            M4.Checked = False

            M1.Enabled = False
            M2.Enabled = False
            M3.Enabled = False
            M4.Enabled = False

        Else
            M1.Enabled = True
            M2.Enabled = True
            M3.Enabled = True
            M4.Enabled = True

        End If
    End Sub

    Private Sub O_CheckedChanged(sender As Object, e As EventArgs) Handles O.CheckedChanged
        If O.Checked = False Then
            O1.Checked = False
            O2.Checked = False
            O3.Checked = False
            O4.Checked = False

            O1.Enabled = False
            O2.Enabled = False
            O3.Enabled = False
            O4.Enabled = False

        Else
            O1.Enabled = True
            O2.Enabled = True
            O3.Enabled = True
            O4.Enabled = True

        End If
    End Sub

    Private Sub P_CheckedChanged(sender As Object, e As EventArgs) Handles P.CheckedChanged
        If P.Checked = False Then
            P1.Checked = False
            P2.Checked = False
            P3.Checked = False
            P4.Checked = False

            P1.Enabled = False
            P2.Enabled = False
            P3.Enabled = False
            P4.Enabled = False

        Else
            P1.Enabled = True
            P2.Enabled = True
            P3.Enabled = True
            P4.Enabled = True

        End If
    End Sub

    Private Sub Q_CheckedChanged(sender As Object, e As EventArgs) Handles Q.CheckedChanged
        If Q.Checked = False Then
            Q1.Checked = False
            Q2.Checked = False
            Q3.Checked = False
            Q4.Checked = False

            Q1.Enabled = False
            Q2.Enabled = False
            Q3.Enabled = False
            Q4.Enabled = False

        Else
            Q1.Enabled = True
            Q2.Enabled = True
            Q3.Enabled = True
            Q4.Enabled = True

        End If
    End Sub

    Private Sub R_CheckedChanged(sender As Object, e As EventArgs) Handles R.CheckedChanged
        If R.Checked = False Then
            R1.Checked = False
            R2.Checked = False
            R3.Checked = False
            R4.Checked = False

            R1.Enabled = False
            R2.Enabled = False
            R3.Enabled = False
            R4.Enabled = False

        Else
            R1.Enabled = True
            R2.Enabled = True
            R3.Enabled = True
            R4.Enabled = True

        End If
    End Sub

    Private Sub Q20_CheckedChanged(sender As Object, e As EventArgs) Handles Q20.CheckedChanged
        If Q20.Checked = False Then
            Q21.Checked = False
            Q22.Checked = False
            Q23.Checked = False
            Q24.Checked = False

            Q21.Enabled = False
            Q22.Enabled = False
            Q23.Enabled = False
            Q24.Enabled = False

        Else
            Q21.Enabled = True
            Q22.Enabled = True
            Q23.Enabled = True
            Q24.Enabled = True

        End If
    End Sub

    Private Sub N100_CheckedChanged(sender As Object, e As EventArgs) Handles N100.CheckedChanged
        If N100.Checked = False Then
            N101.Checked = False
            N102.Checked = False
            N103.Checked = False

            N101.Enabled = False
            N102.Enabled = False
            N103.Enabled = False


        Else
            N101.Enabled = True
            N102.Enabled = True
            N103.Enabled = True

        End If
    End Sub

    Private Sub M100_CheckedChanged(sender As Object, e As EventArgs) Handles M100.CheckedChanged
        If M100.Checked = False Then
            M101.Checked = False
            M102.Checked = False
            M103.Checked = False

            M101.Enabled = False
            M102.Enabled = False
            M103.Enabled = False

        Else
            M101.Enabled = True
            M102.Enabled = True
            M103.Enabled = True

        End If
    End Sub

    Private Sub S100_CheckedChanged(sender As Object, e As EventArgs) Handles S100.CheckedChanged
        If S100.Checked = False Then
            S101.Checked = False
            S102.Checked = False
            S103.Checked = False
            S104.Checked = False

            S101.Enabled = False
            S102.Enabled = False
            S103.Enabled = False
            S104.Enabled = False

        Else
            S101.Enabled = True
            S102.Enabled = True
            S103.Enabled = True
            S104.Enabled = True

        End If
    End Sub
End Class