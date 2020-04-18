Public Class ClassConvertNO
    Public Function ConvertToArabic(ByVal Str As String) As String
        Dim IntStr As String = ""
        Dim Frac As String = ""
        Dim Result As String = ""
        Dim L As Integer = Str.Length ' To Get The Length Of The Original Text 
        Dim M As Integer = Str.IndexOf(".") ' To Get The location Of Decimal Sign
        If M > 0 Then
            IntStr = Str.Remove(M, L - M)  'To Get Number Without Fractions
            Frac = Str.Remove(0, M + 1)    'To Get Number With Fractions
        ElseIf M = 0 Then : Frac = Str.Remove(0, M + 1)
        ElseIf M < 0 Then : IntStr = Str : End If
        '===============================
        If IntStr <> Nothing Then IntStr = Get_IntStr_A(IntStr)
        'my addation Is here 
        '----------------------------------
        If Frac.Length = 1 Then Frac += "0"
        '----------------------------------
        If Frac <> Nothing Then Frac = Get_IntStr_A(Frac)
        If IntStr <> Nothing Then Result = " " & IntStr & " جنية "
        If Frac <> Nothing Then Result &= "و " & Frac & " قرش  "
        Result &= "فقط لا غير " & ""
        '===============================

        Return Result
    End Function

    Private Function Get_IntStr_A(ByRef S As String) As String
        Try
            Dim Result As String
            '=============================================
            'Chek If S >= 11 And <= 19
            If Val(S) >= 11 And Val(S) <= 19 Then
                S = Get_ValuesBN_11_19_A(S)
                S = S.Remove(0, 1) : Return S : Exit Function
            End If
            '===============================================
            Dim I As Integer
            ' Dim ROnes, RTens, RHun, RThus, RTenThus, RHunThus, RMln, RTenMln, RHunMln As String

            Dim ROnes As String = "" : Dim RTens As String = "" : Dim RHun As String = ""
            Dim RThus As String = "" : Dim RTenThus As String = "" : Dim RHunThus As String = ""
            Dim RMln As String = "" : Dim RTenMln As String = "" : Dim RHunMln As String = ""
            Dim SSS As String = "" : Dim J As Integer


            Dim L As Integer = S.Length
            For I = S.Length - 1 To 0 Step -1
                If Val(S.Chars(I)) > 0 Then
                    Select Case I
                        '===============================================
                        Case L - 1 : ROnes = Get_Ones_A(S.Chars(I))
                            '===============================================
                        Case L - 2
                            For J = 0 To 7
                                If L = J + 2 Then SSS = S.Substring(J, 2)
                            Next
                            If Val(SSS) >= 11 And Val(SSS) <= 19 Then
                                RTens = Get_ValuesBN_11_19_A(SSS) : ROnes = Nothing
                            Else : RTens = Get_Tens_A(S.Chars(I)) : End If
                            '===============================================
                        Case L - 3 : RHun = Get_Hundreds_A(S.Chars(I))
                            '===============================================
                        Case L - 4 : RThus = Get_Thousands_A(S.Chars(I))
                            '===============================================
                    End Select
                    If L > 4 Then
                        Select Case I
                            '===============================================
                            Case L - 4 : RThus = Get_Ones_A(S.Chars(I))
                                If (S.Chars(L - 5)) = "0" Then
                                    RThus &= " ألف "
                                End If
                                '===============================================
                            Case L - 5
                                For J = 0 To 4
                                    If L = J + 5 Then SSS = S.Substring(J, 2)
                                Next
                                If Val(SSS) >= 11 And Val(SSS) <= 19 Then
                                    RTenThus = Get_ValuesBN_11_19_A(SSS) : RThus = Nothing
                                Else : RTenThus = Get_Tens_A(S.Chars(I)) : End If
                                RTenThus &= " ألف "
                                '===============================================
                            Case L - 6 : RHunThus = Get_Hundreds_A(S.Chars(I))
                                If RTenThus = Nothing Then RHunThus &= " ألف "
                                '===============================================
                            Case L - 7
                                If L = 7 Then : RMln = Get_Ones_A(S.Chars(I)) & " مليون "
                                Else : RMln = Get_Ones_A(S.Chars(I)) : End If
                                '===============================================
                            Case L - 8
                                For J = 0 To 2
                                    If L = J + 8 Then SSS = S.Substring(J, 2)
                                Next
                                If Val(SSS) >= 11 And Val(SSS) <= 19 Then
                                    RTenMln = Get_ValuesBN_11_19_A(SSS) : RMln = Nothing
                                Else : RTenMln = Get_Tens_A(S.Chars(I)) : End If
                                If L = 8 Then RTenMln &= " مليون "
                                '===============================================
                            Case L - 9 : RHunMln = Get_Hundreds_A(S.Chars(I))
                                If L = 9 Then
                                    RHunMln &= RMln & RTenMln & " مليون "
                                    RTenMln = Nothing : RMln = Nothing
                                End If
                                '===============================================
                        End Select
                    End If
                End If
            Next
            Result = RHunMln & RMln & RTenMln & RHunThus & RThus & RTenThus & RHun & ROnes & RTens
            Result = Result.Remove(0, 1)
            Dim RR As String
            Dim II As Integer = Result.IndexOf("*")
            If II >= 0 Then : RR = Result.Replace("*", " و")
            Else : RR = Result
            End If
            Return RR
        Catch ex As Exception

        End Try
    End Function

    Private Function Get_ValuesBN_11_19_A(ByVal S As String) As String
        '=============================================
        Select Case Val(S)
            Case 11 : S = "*أحد عشر"
            Case 12 : S = "*إثنـى عشر"
            Case 13 : S = "*ثلاثة عشر"
            Case 14 : S = "*أربعة عشر"
            Case 15 : S = "*خمسة عشر"
            Case 16 : S = "*ستة عشر"
            Case 17 : S = "*سبعة عشر"
            Case 18 : S = "*ثمانية عشر"
            Case 19 : S = "*تسعة عشر"
        End Select
        Return S
        '=============================================
    End Function

    Private Function Get_Ones_A(ByVal S As String) As String
        '=============================================
        Select Case Val(S)
            Case 1 : S = "*واحد"
            Case 2 : S = "*إثنـين"
            Case 3 : S = "*ثلاثة"
            Case 4 : S = "*أربعة"
            Case 5 : S = "*خمسة"
            Case 6 : S = "*ستة"
            Case 7 : S = "*سبعة"
            Case 8 : S = "*ثمانية"
            Case 9 : S = "*تسعة"
        End Select
        Return S
        '===============================================
    End Function

    Private Function Get_Tens_A(ByVal S As String) As String
        '=============================================
        Select Case Val(S)
            Case 1 : S = "*عشره"
            Case 2 : S = "*عشرون"
            Case 3 : S = "*ثلاثون"
            Case 4 : S = "*أربعون"
            Case 5 : S = "*خمسون"
            Case 6 : S = "*ستون"
            Case 7 : S = "*سبعون"
            Case 8 : S = "*ثمانون"
            Case 9 : S = "*تسعون"
        End Select
        Return S
        '===============================================
    End Function

    Private Function Get_Hundreds_A(ByVal S As String) As String
        '=============================================
        Select Case Val(S)
            Case 1 : S = "*مائه"
            Case 2 : S = "*مائتان"
            Case 3 : S = "*ثلاثمائه"
            Case 4 : S = "*أربعمائه"
            Case 5 : S = "*خمسائه"
            Case 6 : S = "*ستمائه"
            Case 7 : S = "*سبعمائه"
            Case 8 : S = "*ثمانمائه"
            Case 9 : S = "*تسعمائه"
        End Select
        Return S
        '===============================================
    End Function

    Private Function Get_Thousands_A(ByVal S As String) As String
        '=============================================
        Select Case Val(S)
            Case 1 : S = "*ألف"
            Case 2 : S = "*الفان"
            Case 3 : S = "*ثلاثة آلاف"
            Case 4 : S = "*أربعة آلاف"
            Case 5 : S = "*خمسة آلاف"
            Case 6 : S = "*ستة آلاف"
            Case 7 : S = "*سبعة آلاف"
            Case 8 : S = "*ثمانية آلاف"
            Case 9 : S = "*تسعة آلاف"
        End Select
        Return S
        '===============================================
    End Function
    '============================================================================
    '============================================================================
    '============================================================================
    '============================================================================

    Public Function ConvertToEnglish(ByVal Str As String)
        Dim IntStr As String = "" : Dim Frac As String = ""
        Dim Result As String = ""
        Dim L As Integer = Str.Length ' To Get The Length Of The Original Text 
        Dim M As Integer = Str.IndexOf(".") ' To Get The location Of Decimal Sign
        If M > 0 Then
            IntStr = Str.Remove(M, L - M) 'To Get Number Without Fractions
            Frac = Str.Remove(0, M + 1)   'To Get Numbre of Fractions
        ElseIf M = 0 Then : Frac = Str.Remove(0, M + 1)
        ElseIf M < 0 Then : IntStr = Str : End If
        '===============================
        If IntStr <> Nothing Then IntStr = Get_IntStr_E(IntStr)
        If Frac <> Nothing Then Frac = Get_IntStr_E(Frac)
        If IntStr <> Nothing Then Result = "Only " & IntStr & " Riyals "
        If Frac <> Nothing Then Result &= ", " & Frac & " Halalah  "
        '===============================
        Return Result
    End Function

    Private Function Get_IntStr_E(ByRef S As String) As String
        Dim Result As String
        '=============================================
        'Chek If S >= 11 And <= 19
        If Val(S) >= 11 And Val(S) <= 19 Then
            S = Get_ValuesBN_11_19_E(S)
            S = S.Remove(0, 1) : Return S : Exit Function
        End If
        '===============================================
        Dim I As Integer
        Dim ROnes As String = "" : Dim RTens As String = "" : Dim RHun As String = ""
        Dim RThus As String = "" : Dim RTenThus As String = "" : Dim RHunThus As String = ""
        Dim RMln As String = "" : Dim RTenMln As String = "" : Dim RHunMln As String = ""
        Dim SSS As String = "" : Dim J As Integer

        Dim L As Integer = S.Length
        For I = S.Length - 1 To 0 Step -1
            If Val(S.Chars(I)) > 0 Then
                Select Case I
                    '===============================================
                    Case L - 1 : ROnes = Get_Ones_E(S.Chars(I))
                        '===============================================
                    Case L - 2
                        For J = 0 To 7
                            If L = J + 2 Then SSS = S.Substring(J, 2)
                        Next
                        If Val(SSS) >= 11 And Val(SSS) <= 19 Then
                            RTens = Get_ValuesBN_11_19_E(SSS) : ROnes = Nothing
                        Else : RTens = Get_Tens_E(S.Chars(I)) : End If
                        '===============================================
                    Case L - 3 : RHun = Get_Hundreds_E(S.Chars(I))
                        '===============================================
                    Case L - 4 : RThus = Get_Thousands_E(S.Chars(I))
                        '===============================================
                End Select
                If L > 4 Then
                    Select Case I
                        '===============================================
                        Case L - 4 : RThus = Get_Ones_E(S.Chars(I))
                            RThus &= " Thousand "
                            '===============================================
                        Case L - 5
                            For J = 0 To 4
                                If L = J + 5 Then SSS = S.Substring(J, 2)
                            Next
                            If Val(SSS) >= 11 And Val(SSS) <= 19 Then
                                RTenThus = Get_ValuesBN_11_19_E(SSS) : RThus = Nothing
                            Else : RTenThus = Get_Tens_E(S.Chars(I)) : End If
                            If RThus = Nothing Then RTenThus &= " Thousand "
                            '===============================================
                        Case L - 6 : RHunThus = Get_Hundreds_E(S.Chars(I))
                            If (RTenThus = Nothing) And (RThus = Nothing) Then RHunThus &= " Thousand "
                            '===============================================
                        Case L - 7
                            If L = 7 Then : RMln = Get_Ones_E(S.Chars(I))
                            Else : RMln = Get_Ones_E(S.Chars(I)) : End If
                            RMln &= " Million "
                            '===============================================
                        Case L - 8
                            For J = 0 To 2
                                If L = J + 8 Then SSS = S.Substring(J, 2)
                            Next
                            If Val(SSS) >= 11 And Val(SSS) <= 19 Then
                                RTenMln = Get_ValuesBN_11_19_E(SSS) : RMln = Nothing
                            Else : RTenMln = Get_Tens_E(S.Chars(I)) : End If

                            If (RMln = Nothing) Then RTenMln &= " Million "
                            '===============================================
                        Case L - 9 : RHunMln = Get_Hundreds_E(S.Chars(I))
                            If L = 9 Then
                                If (RMln = Nothing) And (RTenMln = Nothing) Then RHunMln &= " Million "
                            End If
                            '===============================================
                    End Select
                End If
            End If
        Next
        Result = RHunMln & RTenMln & RMln & RHunThus & RTenThus & RThus & RHun & RTens & ROnes
        Result = Result.Remove(0, 1)
        Dim RR As String
        Dim II As Integer = Result.IndexOf("*")
        If II >= 0 Then : RR = Result.Replace("*", " ")
        Else : RR = Result
        End If
        Return RR
    End Function

    Private Function Get_ValuesBN_11_19_E(ByVal S As String) As String
        '=============================================
        Select Case Val(S)
            Case 11 : S = "*Eleven"
            Case 12 : S = "*Twelve"
            Case 13 : S = "*Therteen"
            Case 14 : S = "*Fourteen"
            Case 15 : S = "*Fifteen"
            Case 16 : S = "*Sixteen"
            Case 17 : S = "*Seventeen"
            Case 18 : S = "*Eighteen"
            Case 19 : S = "*Nineteen"
        End Select
        Return S
        '=============================================
    End Function

    Private Function Get_Ones_E(ByVal S As String) As String
        '=============================================
        Select Case Val(S)
            Case 1 : S = "*One"
            Case 2 : S = "*Two"
            Case 3 : S = "*Three"
            Case 4 : S = "*Four"
            Case 5 : S = "*Five"
            Case 6 : S = "*Six"
            Case 7 : S = "*Seven"
            Case 8 : S = "*Eight"
            Case 9 : S = "*Nine"
        End Select
        Return S
        '===============================================
    End Function

    Private Function Get_Tens_E(ByVal S As String) As String
        '=============================================
        Select Case Val(S)
            Case 1 : S = "*Ten"
            Case 2 : S = "*Twenty"
            Case 3 : S = "*Thirty"
            Case 4 : S = "*Fourty"
            Case 5 : S = "*Fifty"
            Case 6 : S = "*Sixty"
            Case 7 : S = "*Seventy"
            Case 8 : S = "*Eighty"
            Case 9 : S = "*Ninety"
        End Select
        Return S
        '===============================================
    End Function

    Private Function Get_Hundreds_E(ByVal S As String) As String
        '=============================================
        Select Case Val(S)
            Case 1 : S = "*One Hundred"
            Case 2 : S = "*Two Hundred"
            Case 3 : S = "*Three Hundred"
            Case 4 : S = "*Four Hundred"
            Case 5 : S = "*Five Hundred"
            Case 6 : S = "*Six Hundred"
            Case 7 : S = "*Seven Hundred"
            Case 8 : S = "*Eight Hundred"
            Case 9 : S = "*Nine Hundred"
        End Select
        Return S
        '===============================================
    End Function

    Private Function Get_Thousands_E(ByVal S As String) As String
        '=============================================
        Select Case Val(S)
            Case 1 : S = "*One Thousand"
            Case 2 : S = "*Two Thousand"
            Case 3 : S = "*Three Thousand"
            Case 4 : S = "*Four Thousand"
            Case 5 : S = "*Five Thousand"
            Case 6 : S = "*Six Thousand"
            Case 7 : S = "*Seven Thousand"
            Case 8 : S = "*Eight Thousand"
            Case 9 : S = "*Nine Thousand"
        End Select
        Return S
        '===============================================
    End Function
End Class
