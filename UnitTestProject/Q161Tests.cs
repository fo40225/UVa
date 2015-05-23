//-----------------------------------------------------------------------
// <copyright file="Q161Tests.cs">
//     Copyright (c) Ching Hsu. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

// http://uva.onlinejudge.org/external/1/161.pdf
// Q161 Trac Lights
// One way of achieving a smooth and economical drive to work is to 'catch' every trac light, that is have
// every signal change to green as you approach it. One day you notice as you come over the brow of a hill
// that every trac light you can see has just changed to green and that therefore your chances of catching
// every signal is slight. As you wait at a red light you begin to wonder how long it will be before all the
// lights again show green, not necessarily all turn green, merely all show green simultaneously, even if it
// is only for a second.
// Write a program that will determine whether this event occurs within a reasonable time. Time is
// measured from the instant when they all turned green simultaneously, although the initial portion while
// they are all still green is excluded from the reckoning.

// Input
// Input will consist of a series of scenarios. Data for each scenario will consist of a series of integers
// representing the cycle times of the trac lights, possibly spread over many lines, with no line being
// longer than 100 characters. Each number represents the cycle time of a single signal. The cycle time is
// the time that trac may move in one direction; note that the last 5 seconds of a green cycle is actually
// orange. Thus the number 25 means a signal that (for a particular direction) will spend 20 seconds green,
// 5 seconds orange and 25 seconds red. Cycle times will not be less than 10 seconds, nor more than 90
// seconds. There will always be at least two signals in a scenario and never more than 100. Each scenario
// will be terminated by a zero (0). The file will be terminated by a line consisting of three zeroes (0 0 0).

// Output
// Output will consist of a series of lines, one for each scenario in the input. Each line will consist of the
// time in hours, minutes and seconds that it takes for all the signals to show green again after at least
// one of them changes to orange. Follow the format shown in the examples. Time is measured from the
// instant they all turn green simultaneously. If it takes more than five hours before they all show green
// simultaneously, the message "Signals fail to synchronise in 5 hours" should be written instead.

// Sample input
// 19 20 0
// 30 25 35 0
// 0 0 0

// Sample output
// 00:00:40
// 00:05:00

namespace UnitTestProject
{
    using System;
    using CSharpLibrary;
    using FSharpLibrary;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Q161Tests
    {
        #region CSharp

        [TestMethod]
        public void CSTestMethod1()
        {
            // arrange
            var input = new int[] { 19, 20 };
            var expected = new TimeSpan(0, 0, 40);

            // act
            var actual = Q161CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CSTestMethod2()
        {
            // arrange
            var input = new int[] { 30, 25, 35 };
            var expected = new TimeSpan(0, 5, 0);

            // act
            var actual = Q161CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CSTestMethod3()
        {
            // arrange
            var input = new int[] { 10, 10, 10 };
            var expected = new TimeSpan(0, 0, 20);

            // act
            var actual = Q161CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CSTestMethod4()
        {
            // arrange
            var input = new int[] { 90, 75, 72, 60, 50, 40, 24, 18 };
            var expected = new TimeSpan(1, 0, 0);

            // act
            var actual = Q161CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(System.TimeoutException))]
        public void CSTestMethod5()
        {
            // arrange
            var input = new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 10, 11,
                12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27,
                28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43,
                44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59,
                60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75,
                76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 81,
                82, 83, 84, 85, 86, 87, 88, 89, 90 };

            // act
            Q161CS.GetAnswer(input);

            // assert
        }

        [TestMethod]
        public void CSTestMethod6()
        {
            // arrange
            var input = new int[] { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            var expected = new TimeSpan(2, 14, 24);

            // act
            var actual = Q161CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CSTestMethod7()
        {
            // arrange
            var input = new int[] { 10, 11, 37, 89, 43 };
            var expected = new TimeSpan(0, 0, 22);

            // act
            var actual = Q161CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CSTestMethod8()
        {
            // arrange
            var input = new int[] { 15, 17, 20, 24, 29, 30, 31, 37, 38, 39, 40,
                41, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 85, 86, 87,
                88, 89, 90 };
            var expected = new TimeSpan(0, 4, 8);

            // act
            var actual = Q161CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CSTestMethod9()
        {
            // arrange
            var input = new int[] { 15, 17, 20, 24, 29, 30, 31, 37, 38, 39, 40,
                41, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 85, 86, 87,
                88, 89, 90 };
            var expected = new TimeSpan(0, 4, 8);

            // act
            var actual = Q161CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CSTestMethod10()
        {
            // arrange
            var input = new int[] { 10, 11, 12, 15, 18, 20, 22, 23, 24, 25, 26,
                27, 29, 30, 31, 32, 35, 36, 37, 40, 42, 43, 45, 50, 52, 58, 60,
                62, 66, 67, 68, 69, 72, 73, 75, 76, 78, 81, 83, 84, 87, 88, 89,
                90 };
            var expected = new TimeSpan(5, 0, 0);

            // act
            var actual = Q161CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void CSTestMethod11()
        {
            // arrange
            var input = new int[] { 30, 58, 62, 32, 31, 32, 22, 64, 89, 90, 10,
                27, 10, 29, 56, 35, 28, 45, 56, 58, 29, 28, 54, 78, 58, 96, 32,
                10, 28, 35, 36, 98, 75, 32, 54, 85, 96, 32, 42, 45, 10, 27, 77,
                88, 28, 62, 52, 35, 53, 90, 50, 51, 52, 53, 56, 55, 56, 57, 58,
                59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74,
                75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90,
                31, 32, 33, 34, 35, 36, 37, 38, 41 };

            // act
            Q161CS.GetAnswer(input);

            // assert
        }

        [TestMethod]
        public void CSTestMethod12()
        {
            // arrange
            var input = new int[] { 10, 10 };
            var expected = new TimeSpan(0, 0, 20);

            // act
            var actual = Q161CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CSTestMethod13()
        {
            // arrange
            var input = new int[] { 11, 10, 12, 13, 14 };
            var expected = new TimeSpan(0, 25, 40);

            // act
            var actual = Q161CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(System.TimeoutException))]
        public void CSTestMethod14()
        {
            // arrange
            var input = new int[] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            // act
            Q161CS.GetAnswer(input);

            // assert
        }

        [TestMethod]
        public void CSTestMethod15()
        {
            // arrange
            var input = new int[] { 10, 26 };
            var expected = new TimeSpan(0, 00, 20);

            // act
            var actual = Q161CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CSTestMethod16()
        {
            // arrange
            var input = new int[] { 42, 87, 88, 90 };
            var expected = new TimeSpan(0, 3, 0);

            // act
            var actual = Q161CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CSTestMethod17()
        {
            // arrange
            var input = new int[] { 53, 54, 55, 68, 20 };
            var expected = new TimeSpan(0, 0, 40);

            // act
            var actual = Q161CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CSTestMethod18()
        {
            // arrange
            var input = new int[] { 50, 51, 52, 53, 54, 55, 56, 25, 18 };
            var expected = new TimeSpan(0, 1, 52);

            // act
            var actual = Q161CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CSTestMethod19()
        {
            // arrange
            var input = new int[] { 56, 90, 10, 25, 32, 64, 58, 52 };
            var expected = new TimeSpan(0, 19, 20);

            // act
            var actual = Q161CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        #endregion CSharp
    }
}