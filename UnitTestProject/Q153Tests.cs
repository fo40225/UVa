//-----------------------------------------------------------------------
// <copyright file="Q153Tests.cs" company="CompanyName">
//     Copyright (c) Ching Hsu, CompanyName. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

// https://uva.onlinejudge.org/external/1/153.pdf
// Q153 Permalex
// Given a string of characters, we can permute the individual characters to make new strings. If we
// can impose an ordering on the characters (say alphabetic sequence), then the strings themselves can
// be ordered and any given permutation can be given a unique number designating its position in that
// ordering. For example the string 'acab' gives rise to the following 12 distinct permutations:
// aabc 1 acab 5 bcaa 9
// aacb 2 acba 6 caab 10
// abac 3 baac 7 caba 11
// abca 4 baca 8 cbaa 12
// Thus the string 'acab' can be characterised in this sequence as 5.
// Write a program that will read in a string and determine its position in the ordered sequence of
// permutations of its constituent characters. Note that numbers of permutations can get very large;
// however we guarantee that no string will be given whose position is more than 2^31 - 1 = 2147483647.

// Input and Output
// Input will consist of a series of lines, each line containing one string. Each string will consist of up to 30
// lower case letters, not necessarily distinct. The file will be terminated by a line consisting of a single #.
// Output will consist of a series of lines, one for each line of the input. Each line will consist of the
// position of the string in its sequence, right justified in a field of width 10.

// Sample input
// bacaa
// abc
// cba
// #

// Sample output
// 15
// 1
// 6

namespace UnitTestProject
{
    using System;
    using CSharpLibrary;
    using FSharpLibrary;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Q153Tests
    {
        [TestMethod]
        public void Q153CSTest1()
        {
            // arrange
            var input = "bacaa";
            var expected = 15;

            // act
            var actual = Q153CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Q153CSTest2()
        {
            // arrange
            var input = "abc";
            var expected = 1;

            // act
            var actual = Q153CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Q153CSTest3()
        {
            // arrange
            var input = "cba";
            var expected = 6;

            // act
            var actual = Q153CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}