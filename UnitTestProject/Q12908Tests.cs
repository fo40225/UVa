//-----------------------------------------------------------------------
// <copyright file="Q12908Tests.cs" company="CompanyName">
//     Copyright (c) Ching Hsu, CompanyName. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

// https://uva.onlinejudge.org/external/129/12908.pdf
// Q12908 The book thief
// On February 18, 2014, Red Matemática proposed the following mathematical challenge on their twitter
// account(@redmatematicant): "While Anita read: The book thief by Markus Zusak, She added all the
// page numbers starting from 1. When she finished the book, she got a sum equal to 9.000 but she
// realized that one page number was forgotten in the process.What is such number? and, how many
// pages does the book have?"
// Using this interesting puzzle as our starting point, the problem you are asked to solve now is: Given
// a positive integer s (1 ≤ s ≤ 108 ) representing the result obtained by Anita, find out the number of the
// forgotten page and the total number of pages in the book.

// Input
// The input may contain several test cases.Each test case is presented on a single line, and contains
// one positive integer s. The input ends with a test case in which s is zero, and this case must not be
// processed.

// Output
// For each test case, your program must print two positive integers denoting the number of the forgotten
// page and the total number pages in the book. Each valid test case must generate just one output line.

// Sample Input
// 1
// 2
// 3
// 4
// 5
// 6
// 9000
// 499977
// 49999775
// 0

// Sample Output
// 2 2
// 1 2
// 3 3
// 2 3
// 1 3
// 4 4
// 45 134
// 523 1000
// 5225 10000
namespace UnitTestProject
{
    using System;
    using CSharpLibrary;
    using FSharpLibrary;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Q12908Tests
    {
        [TestMethod]
        public void Q12908CSTest1()
        {
            // arrange
            var input =
@"1
2
3
4
5
6
9000
499977
49999775";
            var expected =
@"2 2
1 2
3 3
2 3
1 3
4 4
45 134
523 1000
5225 10000
";

            // act
            var actual = Q12908CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Q12908CSTest2()
        {
            // arrange
            var input =
@"1
24
100000000
8239
345
974243
12312
36437312
2783424";
            var expected =
@"2 2
4 7
5153 14142
17 128
6 26
863 1396
91 157
7141 8537
196 2359
";

            // act
            var actual = Q12908CS.GetAnswer(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}