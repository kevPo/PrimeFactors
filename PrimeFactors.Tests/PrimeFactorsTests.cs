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
    }
}
