using NUnit.Framework;
using PrimeFactors;
namespace ProgramPrimeFactorsUT
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Prime_factors_of_4()
        {
            string actualResult = Program.primeFactors(4);
            string expectedResult = "2 x 2";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Prime_factors_of_7()
        {
            string actualResult = Program.primeFactors(7);
            string expectedResult = "7";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Prime_factors_of_30()
        {
            string actualResult = Program.primeFactors(30);
            string expectedResult = "2 x 3 x 5";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Prime_factors_of_40()
        {
            string actualResult = Program.primeFactors(40);
            string expectedResult = "2 x 2 x 2 x 5";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Prime_factors_of_50()
        {
            string actualResult = Program.primeFactors(50);
            string expectedResult = "2 x 5 x 5";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}