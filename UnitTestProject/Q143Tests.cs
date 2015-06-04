//-----------------------------------------------------------------------
// <copyright file="Q143Tests.cs" company="CompanyName">
//     Copyright (c) Ching Hsu, CompanyName. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

// https://uva.onlinejudge.org/external/1/143.pdf
// Q143 Orchard Trees
// An Orchardist has planted an orchard in a rectangle with trees uniformly spaced in both directions.
// Thus the trees form a rectangular grid and we can consider the trees to have integer coordinates. The
// origin of the coordinate system is at the bottom left of the following diagram:
// Consider that we now overlay a series of triangles on to this grid. The vertices of the triangle can
// have any real coordinates in the range 0.0 to 100.0, thus trees can have coordinates in the range 1 to 99.
// Two possible triangles are shown.
// Write a program that will determine how many trees are contained within a given triangle. For the
// purposes of this problem, you may assume that the trees are of point size, and that any tree (point)
// lying exactly on the border of a triangle is considered to be in the triangle.

// Input and Output
// Input will consist of a series of lines. Each line will contain 6 real numbers in the range 0.00 to 100.00
// representing the coordinates of a triangle. The entire file will be terminated by a line containing 6 zeroes
// (0 0 0 0 0 0).
// Output will consist of one line for each triangle, containing the number of trees for that triangle right
// justified in a field of width 4.

// Sample input
// 1.5 1.5 1.5 6.8 6.8 1.5
// 10.7 6.9 8.5 1.5 14.5 1.5
// 0 0 0 0 0 0

// Sample output
// 15
// 17
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

        [TestMethod]
        public void CSTestMethod4()
        {
            // arrange
            var input = new double[] { 73.00, 98.22, 8.50, 95.66, 66.27, 13.55 };
            var expected = 2720;

            // act
            var actual = Q143CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CSTestMethod5()
        {
            // arrange
            var input = new double[] { 64.27, 41.32, 80.08, 78.29, 22.12, 28.56 };
            var expected = 677;

            // act
            var actual = Q143CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CSTestMethod6()
        {
            // arrange
            var input = new double[] { 28.63, 91.29, 99.35, 12.04, 48.30, 74.61 };
            var expected = 189;

            // act
            var actual = Q143CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CSTestMethod7()
        {
            // arrange
            var input = new double[] { 19.23, 91.24, 60.25, 46.96, 77.53, 12.41 };
            var expected = 327;

            // act
            var actual = Q143CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}