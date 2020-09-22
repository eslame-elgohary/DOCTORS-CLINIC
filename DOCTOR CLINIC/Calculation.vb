Public Class Calculation
#Region " Calculate Differ Time "

    Public Shared Function CalculatedifferTime(ByVal Time1 As DateTime,
        ByVal Time2 As DateTime) As String

        Dim Value As Integer = DateDiff("s", CDate(Time1), CDate(Time2))

        'let's examine the Time Compartion
        Dim ComDate As Integer = Date.Compare(Time1, Time2)
        If ComDate = 0 Then
            Return "0"

        ElseIf ComDate = 1 Then
            Return "خطأ فى الأحتساب"

        Else
            'Will be -1 That's a valid Value 
            '( Complete Executing All Below Script )
        End If

        Dim Hour, Minute, allSeconds, Second As Integer
        Dim HourCount, MinuteCount, SecondCount, Result As String
        allSeconds = Value \ 60
        Hour = allSeconds \ 60
        Minute = (allSeconds - (Hour * 60))
        Second = Value - (allSeconds * 60)

        Result = Nothing


        If Hour >= 1 Then
            If Hour > 10 Then HourCount = Hour.ToString
            If Hour <= 10 Then HourCount = Hour.ToString
            If Hour = 2 Then HourCount = "02"
            If Hour = 1 Then HourCount = "01"
            Result = HourCount
        End If

        If Minute >= 1 Then

            If Minute > 10 Then MinuteCount = Minute.ToString
            If Minute <= 10 Then MinuteCount = Minute.ToString
            If Minute = 2 Then MinuteCount = "02"
            If Minute = 1 Then MinuteCount = "01"
            If MinuteCount <> "" AndAlso Hour >= 1 Then
                Result += ", "
            End If
            Result += MinuteCount
        End If

        'If Second >= 1 Then
        '    If Second > 10 Then SecondCount = Second.ToString & " ثانية "
        '    If Second <= 10 Then SecondCount = Second.ToString & " ثانية "
        '    If Second = 2 Then SecondCount = " ثانيتان "
        '    If Second = 1 Then SecondCount = "ثانية"
        '    If SecondCount <> "" AndAlso Minute >= 1 Then
        '        Result += ", "
        '    End If
        '    Result += SecondCount
        'End If

        Return Result
    End Function
#End Region

End Class
