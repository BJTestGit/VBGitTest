Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace BJTEST

    <TestClass>
    Public Class PrimesTest

        <TestMethod>
        Public Sub TestGeneratePrimes()

            Dim nullArray = Primes.PrimeGenerator.GeneratePrimeNumbers(0)
            Assert.AreEqual(0, nullArray.Length)

            '第一俥質數是 2
            Dim minArray = Primes.PrimeGenerator.GeneratePrimeNumbers(2)
            Assert.AreEqual(1, minArray.Length)
            Assert.AreEqual(2, minArray(0))


            Dim threeArray = Primes.PrimeGenerator.GeneratePrimeNumbers(3)
            Assert.AreEqual(2, threeArray.Length)
            Assert.AreEqual(2, threeArray(0))
            Assert.AreEqual(3, threeArray(1))

            Dim centArray = Primes.PrimeGenerator.GeneratePrimeNumbers(100)
            Assert.AreEqual(25, centArray.Length)
            Assert.AreEqual(97, centArray(24))

        End Sub


        <TestMethod>
        Public Sub TestExhaustive()

            For i As Integer = 2 To 500
                VerifyPrimeList(Primes.PrimeGenerator.GeneratePrimeNumbers(i))
            Next

        End Sub

        Private Sub VerifyPrimeList(ByVal list() As Integer)
            For i As Integer = 0 To list.Length - 1
                VerifyPrime(list(i))
            Next
        End Sub

        Private Sub VerifyPrime(ByVal n As Integer)
            For factor As Integer = 2 To n - 1
                Assert.IsTrue(n Mod factor <> 0)
            Next
        End Sub

    End Class
End Namespace

