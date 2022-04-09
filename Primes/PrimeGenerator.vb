''' <summary>
''' 質數產生器
''' 1. 無瑕的程式碼 學習 - CH.05 重構 與 單元測試
''' </summary>
Public Class PrimeGenerator

    Private Shared limitNumber As Integer
    Private Shared arrNumberIsPrime() As Boolean
    Private Shared primes() As Integer

    ''' <summary>
    ''' 產生質數
    ''' </summary>
    Public Shared Function GeneratePrimeNumbers(ByVal maxValue As Integer) As Integer()

        If maxValue < 2 Then
            Return Array.Empty(Of Integer)()
        Else
            InitializeSieve(maxValue)
            Sieve()
            LoadPrimes()
            Return Primes
        End If

    End Function

    Public Shared Sub InitializeSieve(ByVal maxValue As Integer)

        limitNumber = maxValue
        arrNumberIsPrime = New Boolean(limitNumber) {}
        Dim i As Integer
        For i = 0 To limitNumber
            arrNumberIsPrime(i) = True
        Next
        ' 去除已知的非質數
        arrNumberIsPrime(0) = False
        arrNumberIsPrime(1) = False

    End Sub


    Private Shared Sub Sieve()

        ' 過濾 -數值的倍數一定不是質數
        Dim i, j As Integer
        Dim iterationLimit As Double = Math.Sqrt(limitNumber) + 1
        For i = 2 To iterationLimit
            If arrNumberIsPrime(i) Then
                For j = i * 2 To limitNumber Step +i
                    arrNumberIsPrime(j) = False
                Next
            End If
        Next

    End Sub

    Private Shared Sub LoadPrimes()

        Dim i, j As Integer
        Dim count As Integer = -1

        '有多少個質數
        For i = 0 To limitNumber
            If arrNumberIsPrime(i) Then
                count += 1
            End If
        Next

        primes = New Integer(count) {}

        j = 0
        For i = 0 To limitNumber
            If arrNumberIsPrime(i) Then
                primes(j) = i
                j += 1
            End If
        Next

    End Sub


End Class
