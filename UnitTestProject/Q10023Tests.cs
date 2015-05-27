﻿//-----------------------------------------------------------------------
// <copyright file="Q10023Tests.cs" company="CompanyName">
//     Copyright (c) Ching Hsu, CompanyName. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

// http: //uva.onlinejudge.org/external/100/10023.pdf Q10023 Square root _ You are to determinate X
// by given Y , from expression X = √Y

// Input The first line is the number of test cases, followed by a blank line. Each test case of the
// input contains a positive integer Y (1 ≤ Y ≤ 10^1000), with no blanks or leading zeroes in it. It
// is guaranteed, that for given Y , X will be always an integer. Each test case will be separated
// by a single line.

// Output For each test case, your program should print X in the same format as Y was given in
// input. Print a blank line between the outputs for two consecutive test cases.

// Sample Input 1 7206604678144

// Sample Output 2684512

namespace UnitTestProject
{
    using System;
    using System.Globalization;
    using System.Numerics;
    using CSharpLibrary;
    using FSharpLibrary;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Q10023Tests
    {
        #region CSharp

        [TestMethod]
        public void CSTestMethod1()
        {
            // arrange
            var input = new BigInteger(7206604678144);
            var expected = new BigInteger(2684512);

            // act
            var actual = Q10023CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CSTestMethod2()
        {
            // arrange 10^500 - 1
            var expected = BigInteger.Subtract(BigInteger.Parse("1.0E+500", NumberStyles.Float), BigInteger.One);
            var input = BigInteger.Pow(expected, 2);

            // act
            var actual = Q10023CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CSTestMethod3()
        {
            // arrange
            var input = new BigInteger(4);
            var expected = new BigInteger(2);

            // act
            var actual = Q10023CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CSTestMethod4()
        {
            // arrange
            var input = new BigInteger(100);
            var expected = new BigInteger(10);

            // act
            var actual = Q10023CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CSTestMethod5()
        {
            // arrange
            var input = new BigInteger(289);
            var expected = new BigInteger(17);

            // act
            var actual = Q10023CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        #endregion
        #region FSharp

        [TestMethod]
        public void FSTestMethod1()
        {
            // arrange
            var input = new BigInteger(7206604678144);
            var expected = new BigInteger(2684512);

            // act
            var actual = Q10023FS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FSTestMethod2()
        {
            // arrange 10^500 - 1
            var expected = BigInteger.Subtract(BigInteger.Parse("1.0E+500", NumberStyles.Float), BigInteger.One);
            var input = BigInteger.Pow(expected, 2);

            // act
            var actual = Q10023FS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FSTestMethod3()
        {
            // arrange
            var input = new BigInteger(4);
            var expected = new BigInteger(2);

            // act
            var actual = Q10023FS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FSTestMethod4()
        {
            // arrange
            var input = new BigInteger(100);
            var expected = new BigInteger(10);

            // act
            var actual = Q10023FS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FSTestMethod5()
        {
            // arrange
            var input = new BigInteger(289);
            var expected = new BigInteger(17);

            // act
            var actual = Q10023FS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        #endregion
    }
}