''' <summary>
''' 產生質數
''' </summary>
Public Class GeneratePrimes

    ''' <summary>
    ''' 產生最大質數
    ''' </summary>
    Public Shared Function GeneratePrimeNumbers(ByVal maxValue As Integer) As Integer()
        If maxValue >= 2 Then

            '索引從 0 開始, 數值也從 0 開始
            Dim f() As Boolean = New Boolean(maxValue) {}
            Dim i As Integer

            For i = 0 To maxValue
                f(i) = True
            Next

            ' 去除已知的非質數
            f(0) = False
            f(1) = False

            ' 過濾
            Dim j As Integer
            Dim iterationLimit As Double = Math.Sqrt(maxValue)
            For i = 2 To iterationLimit
                '傳入數伹的倍數一定不是質數
                'VB 索引值從 0 開始
                If f(i) Then
                    For j = i * 2 To maxValue Step +i
                        f(j) = False
                    Next
                End If
            Next

            '有多少個質數
            Dim Count As Integer = -1
            For i = 0 To maxValue
                If f(i) Then
                    Count += 1
                End If
            Next

            Dim primes() As Integer = New Integer(Count) {}

            j = 0
            For i = 0 To maxValue
                If f(i) Then
                    primes(j) = i
                    j += 1
                End If
            Next

            Return primes

        Else
            Return Array.Empty(Of Integer)()
        End If
    End Function


End Class
