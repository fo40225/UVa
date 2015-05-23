//-----------------------------------------------------------------------
// <copyright file="Q557Tests.cs">
//     Copyright (c) Ching Hsu. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

// http://uva.onlinejudge.org/external/5/557.pdf
// Q557 Burger
// When Mr. and Mrs. Clinton's twin sons Ben and Bill had their tenth birthday, the party was held
// at the McDonald's restaurant at South Broadway 202, New York. There were 20 kids at the party,
// including Ben and Bill. Ronald McDonald had made 10 hamburgers and 10 cheeseburgers and when he
// served the kids he started with the girl directly sitting left of Bill. Ben was sitting to the right of Bill.
// Ronald flipped a (fair) coin to decide if the girl should have a hamburger or a cheeseburger, head for
// hamburger, tail for cheeseburger. He repeated this procedure with all the other 17 kids before serving
// Ben and Bill last. Though, when coming to Ben he didn't have to flip the coin anymore because there
// were no cheeseburgers left, only 2 hamburgers.
// Ronald McDonald was quite surprised this happened, so he would like to know what the probability
// is of this kind of events. Calculate the probability that Ben and Bill will get the same type of burger
// using the procedure described above. Ronald McDonald always grills the same number of hamburgers
// and cheeseburgers.

// Input
// The first line of the input-file contains the number of problems n, followed by n times:
// a line with an even number [2,4,6,...,1000], which indicates the number of guests present at the party
// including Ben and Bill.

// Output
// The output consists of n lines with on each line the probability (4 decimals precise) that Ben and Bill
// get the same type of burger.
// Note: a variance of +-0.0001 is allowed in the output due to rounding differences.

// Sample Input
// 3
// 6
// 10
// 256

// Sample Output
// 0.6250
// 0.7266
// 0.9500

namespace UnitTestProject
{
    using System;
    using CSharpLibrary;
    using FSharpLibrary;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Q557Tests
    {
        [TestMethod]
        public void CSTestMethod1()
        {
            //arrange
            var input = 6;
            var expected = 0.6250;

            //act
            var actual = Q557CS.GetAnswer(input);
            var IsEqual = (Math.Max(actual, expected) - Math.Min(actual, expected)) < 0.0001;

            //assert
            Assert.IsTrue(IsEqual);
        }

        [TestMethod]
        public void CSTestMethod2()
        {
            //arrange
            var input = 10;
            var expected = 0.7266;

            //act
            var actual = Q557CS.GetAnswer(input);
            var IsEqual = (Math.Max(actual, expected) - Math.Min(actual, expected)) < 0.0001;

            //assert
            Assert.IsTrue(IsEqual);
        }

        [TestMethod]
        public void CSTestMethod3()
        {
            //arrange
            var input = 256;
            var expected = 0.9500;

            //act
            var actual = Q557CS.GetAnswer(input);
            var IsEqual = (Math.Max(actual, expected) - Math.Min(actual, expected)) < 0.0001;

            //assert
            Assert.IsTrue(IsEqual);
        }

        [TestMethod]
        public void CSTestMethod4()
        {
            //arrange
            var input = 50000;
            var expected = 0.9964;

            //act
            var actual = Q557CS.GetAnswer(input);
            var IsEqual = (Math.Max(actual, expected) - Math.Min(actual, expected)) < 0.0001;

            //assert
            Assert.IsTrue(IsEqual);
        }

        [TestMethod]
        public void CSTestMethod5()
        {
            //arrange
            var input = 100000;
            var expected = 0.9975;

            //act
            var actual = Q557CS.GetAnswer(input);
            var IsEqual = (Math.Max(actual, expected) - Math.Min(actual, expected)) < 0.0001;

            //assert
            Assert.IsTrue(IsEqual);
        }

        [TestMethod]
        public void CSTestMethod6()
        {
            //arrange
            var input = 2;
            var expected = 0.0000;

            //act
            var actual = Q557CS.GetAnswer(input);
            var IsEqual = (Math.Max(actual, expected) - Math.Min(actual, expected)) < 0.0001;

            //assert
            Assert.IsTrue(IsEqual);
        }

        [TestMethod]
        public void CSTestMethod7()
        {
            //arrange
            var input = 4;
            var expected = 0.5000;

            //act
            var actual = Q557CS.GetAnswer(input);
            var IsEqual = (Math.Max(actual, expected) - Math.Min(actual, expected)) < 0.0001;

            //assert
            Assert.IsTrue(IsEqual);
        }

        [TestMethod]
        public void CSTestMethod8()
        {
            //arrange
            var input = 8;
            var expected = 0.6875;

            //act
            var actual = Q557CS.GetAnswer(input);
            var IsEqual = (Math.Max(actual, expected) - Math.Min(actual, expected)) < 0.0001;

            //assert
            Assert.IsTrue(IsEqual);
        }

        [TestMethod]
        public void CSTestMethod9()
        {
            //arrange
            var input = 20;
            var expected = 0.8145;

            //act
            var actual = Q557CS.GetAnswer(input);
            var IsEqual = (Math.Max(actual, expected) - Math.Min(actual, expected)) < 0.0001;

            //assert
            Assert.IsTrue(IsEqual);
        }

        [TestMethod]
        public void CSTestMethod10()
        {
            //arrange
            var input = 50;
            var expected = 0.8854;

            //act
            var actual = Q557CS.GetAnswer(input);
            var IsEqual = (Math.Max(actual, expected) - Math.Min(actual, expected)) < 0.0001;

            //assert
            Assert.IsTrue(IsEqual);
        }

        [TestMethod]
        public void CSTestMethod11()
        {
            //arrange
            var input = 100;
            var expected = 0.9196;

            //act
            var actual = Q557CS.GetAnswer(input);
            var IsEqual = (Math.Max(actual, expected) - Math.Min(actual, expected)) < 0.0001;

            //assert
            Assert.IsTrue(IsEqual);
        }

        [TestMethod]
        public void CSTestMethod12()
        {
            //arrange
            var input = 200;
            var expected = 0.9434;

            //act
            var actual = Q557CS.GetAnswer(input);
            var IsEqual = (Math.Max(actual, expected) - Math.Min(actual, expected)) < 0.0001;

            //assert
            Assert.IsTrue(IsEqual);
        }

        [TestMethod]
        public void CSTestMethod13()
        {
            //arrange
            var input = 500;
            var expected = 0.9643;

            //act
            var actual = Q557CS.GetAnswer(input);
            var IsEqual = (Math.Max(actual, expected) - Math.Min(actual, expected)) < 0.0001;

            //assert
            Assert.IsTrue(IsEqual);
        }

        [TestMethod]
        public void CSTestMethod14()
        {
            //arrange
            var input = 1000;
            var expected = 0.9747;

            //act
            var actual = Q557CS.GetAnswer(input);
            var IsEqual = (Math.Max(actual, expected) - Math.Min(actual, expected)) < 0.0001;

            //assert
            Assert.IsTrue(IsEqual);
        }

        [TestMethod]
        public void CSTestMethod15()
        {
            //arrange
            var input = 2000;
            var expected = 0.9822;

            //act
            var actual = Q557CS.GetAnswer(input);
            var IsEqual = (Math.Max(actual, expected) - Math.Min(actual, expected)) < 0.0001;

            //assert
            Assert.IsTrue(IsEqual);
        }

        [TestMethod]
        public void CSTestMethod16()
        {
            //arrange
            var input = 3000;
            var expected = 0.9854;

            //act
            var actual = Q557CS.GetAnswer(input);
            var IsEqual = (Math.Max(actual, expected) - Math.Min(actual, expected)) < 0.0001;

            //assert
            Assert.IsTrue(IsEqual);
        }

        [TestMethod]
        public void CSTestMethod17()
        {
            //arrange
            var input = 4000;
            var expected = 0.9874;

            //act
            var actual = Q557CS.GetAnswer(input);
            var IsEqual = (Math.Max(actual, expected) - Math.Min(actual, expected)) < 0.0001;

            //assert
            Assert.IsTrue(IsEqual);
        }

        [TestMethod]
        public void CSTestMethod18()
        {
            //arrange
            var input = 5000;
            var expected = 0.9887;

            //act
            var actual = Q557CS.GetAnswer(input);
            var IsEqual = (Math.Max(actual, expected) - Math.Min(actual, expected)) < 0.0001;

            //assert
            Assert.IsTrue(IsEqual);
        }

        [TestMethod]
        public void CSTestMethod19()
        {
            //arrange
            var input = 6000;
            var expected = 0.9897;

            //act
            var actual = Q557CS.GetAnswer(input);
            var IsEqual = (Math.Max(actual, expected) - Math.Min(actual, expected)) < 0.0001;

            //assert
            Assert.IsTrue(IsEqual);
        }

        [TestMethod]
        public void CSTestMethod20()
        {
            //arrange
            var input = 7000;
            var expected = 0.9905;

            //act
            var actual = Q557CS.GetAnswer(input);
            var IsEqual = (Math.Max(actual, expected) - Math.Min(actual, expected)) < 0.0001;

            //assert
            Assert.IsTrue(IsEqual);
        }

        [TestMethod]
        public void CSTestMethod21()
        {
            //arrange
            var input = 8000;
            var expected = 0.9911;

            //act
            var actual = Q557CS.GetAnswer(input);
            var IsEqual = (Math.Max(actual, expected) - Math.Min(actual, expected)) < 0.0001;

            //assert
            Assert.IsTrue(IsEqual);
        }

        [TestMethod]
        public void CSTestMethod22()
        {
            //arrange
            var input = 9000;
            var expected = 0.9916;

            //act
            var actual = Q557CS.GetAnswer(input);
            var IsEqual = (Math.Max(actual, expected) - Math.Min(actual, expected)) < 0.0001;

            //assert
            Assert.IsTrue(IsEqual);
        }

        [TestMethod]
        public void CSTestMethod23()
        {
            //arrange
            var input = 10000;
            var expected = 0.9920;

            //act
            var actual = Q557CS.GetAnswer(input);
            var IsEqual = (Math.Max(actual, expected) - Math.Min(actual, expected)) < 0.0001;

            //assert
            Assert.IsTrue(IsEqual);
        }
    }
}