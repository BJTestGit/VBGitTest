Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace BJTEST

    <TestClass>
    Public Class PrimesTest

        <TestMethod>
        Public Sub TestGeneratePrimes()

            Dim nullArray = Primes.GeneratePrimes.GeneratePrimeNumbers(0)
            Assert.AreEqual(0, nullArray.Length)

            '第一俥質數是 2
            Dim minArray = Primes.GeneratePrimes.GeneratePrimeNumbers(2)
            Assert.AreEqual(1, minArray.Length)
            Assert.AreEqual(2, minArray(0))


            Dim threeArray = Primes.GeneratePrimes.GeneratePrimeNumbers(3)
            Assert.AreEqual(2, threeArray.Length)
            Assert.AreEqual(2, threeArray(0))
            Assert.AreEqual(3, threeArray(1))

            Dim centArray = Primes.GeneratePrimes.GeneratePrimeNumbers(100)
            Assert.AreEqual(25, centArray.Length)
            Assert.AreEqual(97, centArray(24))

        End Sub

    End Class
End Namespace

