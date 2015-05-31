//-----------------------------------------------------------------------
// <copyright file="Q143Tests.cs" company="CompanyName">
//     Copyright (c) Ching Hsu, CompanyName. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace UnitTestProject
{
    using System;
    using CSharpLibrary;
    using FSharpLibrary;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Q143Tests
    {
        [TestMethod]
        public void CSTestMethod1()
        {
            // arrange
            var input = new double[] { 1.5, 1.5, 1.5, 6.8, 6.8, 1.5 };
            var expected = 15;

            // act
            var actual = Q143CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CSTestMethod2()
        {
            // arrange
            var input = new double[] { 10.7, 6.9, 8.5, 1.5, 14.5, 1.5 };
            var expected = 17;

            // act
            var actual = Q143CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CSTestMethod3()
        {
            // arrange
            var input = new double[] { 0, 100, 100, 0, 0, 0 };
            var expected = 4950;

            // act
            var actual = Q143CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}