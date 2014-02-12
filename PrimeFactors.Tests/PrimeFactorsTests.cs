﻿using System;
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

        [Test]
        public void TestGenerateForFour()
        {
            Assert.That(new List<Int32> { 2, 2 }, Is.EqualTo(PrimeFactors.Generate(4)));
        }

        [Test]
        public void TestGenerateForSix()
        {
            Assert.That(new List<Int32> { 2, 3 }, Is.EqualTo(PrimeFactors.Generate(6)));
        }

        [Test]
        public void TestGenerateForEight()
        {
            Assert.That(new List<Int32> { 2, 2, 2 }, Is.EqualTo(PrimeFactors.Generate(8)));
        }

        [Test]
        public void TestGenerateForNine()
        {
            Assert.That(new List<Int32> { 3, 3 }, Is.EqualTo(PrimeFactors.Generate(9)));
        }
    }
}
