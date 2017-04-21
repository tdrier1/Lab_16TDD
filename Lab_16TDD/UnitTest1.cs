using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab_16TDD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodIsNotPrime1()
        {
            bool Expected = false;

            Assert.AreEqual(Expected, Lab_16Test.PrimeTest(1));
        }

        [TestMethod]
        public void TestMethodIsNotPrime2()
        {
            bool Expected = true;

            Assert.AreEqual(Expected, Lab_16Test.PrimeTest(7));
        }

        [TestMethod]
        public void TestMethodIsAPrime3()
        {
            bool Expected = false;

            Assert.AreEqual(Expected, Lab_16Test.PrimeTest(8));
        }
    }
    }

