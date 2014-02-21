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
            Assert.That(PrimeFactors.Generate(2), Is.EqualTo(new[] { 2 }));
        }

        [Test]
        public void TestGenerateForThree()
        {
            Assert.That(PrimeFactors.Generate(3), Is.EqualTo(new[] { 3 }));
        }

        [Test]
        public void TestGenerateForFour()
        {
            Assert.That(PrimeFactors.Generate(4), Is.EqualTo(new[] { 2, 2 }));
        }

        [Test]
        public void TestGenerateForSix()
        {
            Assert.That(PrimeFactors.Generate(6), Is.EqualTo(new[] { 2, 3 }));
        }

        [Test]
        public void TestGenerateForEight()
        {
            Assert.That(PrimeFactors.Generate(8), Is.EqualTo(new[] { 2, 2, 2 }));
        }

        [Test]
        public void TestGenerateForNine()
        {
            Assert.That(PrimeFactors.Generate(9), Is.EqualTo(new[] { 3, 3 }));
        }
    }
}
