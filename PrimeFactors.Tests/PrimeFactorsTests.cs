using System;
using System.Collections.Generic;
using NUnit.Framework;


namespace PrimeFactors.Tests
{
    [TestFixture]
    public class PrimeFactorsTests
    {
        [Test]
        public void TestGenerateForOne()
        {
            Assert.That(new List<Int32>(), Is.EqualTo(PrimeFactors.Generate(1)));
        }

        [Test]
        public void TestGenerateForTwo()
        {
            Assert.That(new List<Int32>{2}, Is.EqualTo(PrimeFactors.Generate(2)));
        }

        [Test]
        public void TestGenerateForThree()
        {
            Assert.That(new List<Int32> { 3 }, Is.EqualTo(PrimeFactors.Generate(3)));
        }
    }
}
