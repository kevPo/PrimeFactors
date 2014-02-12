using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;

namespace PrimeFactors.Tests
{
    [TestFixture]
    public class PrimeFactorsTests
    {
        [Test]
        public void TestGenerateForOne()
        {
            Assert.That(Enumerable.Empty<Int32>(), Is.EqualTo(PrimeFactors.Generate(1)));
        }

        [Test]
        public void TestGenerateForTwo()
        {
            Assert.That(new[] { 2 }, Is.EqualTo(PrimeFactors.Generate(2)));
        }

        [Test]
        public void TestGenerateForThree()
        {
            Assert.That(new[] { 3 }, Is.EqualTo(PrimeFactors.Generate(3)));
        }

        [Test]
        public void TestGenerateForFour()
        {
            Assert.That(new[] { 2, 2 }, Is.EqualTo(PrimeFactors.Generate(4)));
        }

        [Test]
        public void TestGenerateForSix()
        {
            Assert.That(new[] { 2, 3 }, Is.EqualTo(PrimeFactors.Generate(6)));
        }

        [Test]
        public void TestGenerateForEight()
        {
            Assert.That(new[] { 2, 2, 2 }, Is.EqualTo(PrimeFactors.Generate(8)));
        }

        [Test]
        public void TestGenerateForNine()
        {
            Assert.That(new[] { 3, 3 }, Is.EqualTo(PrimeFactors.Generate(9)));
        }
    }
}
