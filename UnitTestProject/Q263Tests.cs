﻿//-----------------------------------------------------------------------
// <copyright file="Q263Tests.cs">
//     Copyright (c) Ching Hsu. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

// http://uva.onlinejudge.org/external/2/263.pdf
// Q263 Number Chains
// Given a number, we can form a number chain by
// 1. arranging its digits in descending order
// 2. arranging its digits in ascending order
// 3. subtracting the number obtained in (2) from the number obtained (1) to form a new number
// 4. and repeat these steps unless the new number has already appeared in the chain
// Note that 0 is a permitted digit. The number of distinct numbers in the chain is the length of the
// chain. You are to write a program that reads numbers and outputs the number chain and the length of
// that chain for each number read.

// Input and Output
// The input consists of a sequence of positive numbers, all less than 10^9, each on its own line, terminated
// by 0. The input le contains at most 10 numbers.
// The output consists of the number chains generated by the input numbers, followed by their lengths
// exactly in the format indicated below. After each number chain and chain length, including the last one,
// there should be a blank line. No chain will contain more than 1000 distinct numbers.

// Sample Input
// 123456789
// 1234
// 444
// 0

// Sample Output
// Original number was 123456789
// 987654321 - 123456789 = 864197532
// 987654321 - 123456789 = 864197532
// Chain length 2

// Original number was 1234
// 4321 - 1234 = 3087
// 8730 - 378 = 8352
// 8532 - 2358 = 6174
// 7641 - 1467 = 6174
// Chain length 4

// Original number was 444
// 444 - 444 = 0
// 0 - 0 = 0
// Chain length 2

namespace UnitTestProject
{
    using System;
    using System.IO;
    using CSharpLibrary;
    using FSharpLibrary;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class Q263Tests
    {
        #region CSharp

        [TestMethod]
        public void CSTestMethod1()
        {
            // arrange
            int input = 123456789;
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                string expected =
@"Original number was 123456789
987654321 - 123456789 = 864197532
987654321 - 123456789 = 864197532
Chain length 2
";

                // act
                Q263CS.GetAnswer(input);
                string actual = sw.ToString();

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void CSTestMethod2()
        {
            // arrange
            int input = 1234;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                string expected =
@"Original number was 1234
4321 - 1234 = 3087
8730 - 378 = 8352
8532 - 2358 = 6174
7641 - 1467 = 6174
Chain length 4
";

                // act
                Q263CS.GetAnswer(input);
                string actual = sw.ToString();

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void CSTestMethod3()
        {
            // arrange
            int input = 444;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                string expected =
@"Original number was 444
444 - 444 = 0
0 - 0 = 0
Chain length 2
";

                // act
                Q263CS.GetAnswer(input);
                string actual = sw.ToString();

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void CSTestMethod4()
        {
            // arrange
            int input = 92482438;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                string expected =
@"Original number was 92482438
98844322 - 22344889 = 76499433
99764433 - 33446799 = 66317634
76664331 - 13346667 = 63317664
76664331 - 13346667 = 63317664
Chain length 4
";

                // act
                Q263CS.GetAnswer(input);
                string actual = sw.ToString();

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void CSTestMethod5()
        {
            // arrange
            int input = 57878377;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                string expected =
@"Original number was 57878377
88777753 - 35777788 = 52999965
99996552 - 25569999 = 74426553
76554432 - 23445567 = 53108865
88655310 - 1355688 = 87299622
99876222 - 22267899 = 77608323
87763320 - 2336778 = 85426542
86554422 - 22445568 = 64108854
88654410 - 1445688 = 87208722
88772220 - 2227788 = 86544432
86544432 - 23444568 = 63099864
99866430 - 3466899 = 96399531
99965331 - 13356999 = 86608332
88663320 - 2336688 = 86326632
86663322 - 22336668 = 64326654
66654432 - 23445666 = 43208766
87664320 - 2346678 = 85317642
87654321 - 12345678 = 75308643
87654330 - 3345678 = 84308652
88654320 - 2345688 = 86308632
88663320 - 2336688 = 86326632
Chain length 20
";

                // act
                Q263CS.GetAnswer(input);
                string actual = sw.ToString();

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void CSTestMethod6()
        {
            // arrange
            int input = 34131232;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                string expected =
@"Original number was 34131232
43332211 - 11223334 = 32108877
88773210 - 1237788 = 87535422
87554322 - 22345578 = 65208744
87654420 - 2445678 = 85208742
88754220 - 2245788 = 86508432
88654320 - 2345688 = 86308632
88663320 - 2336688 = 86326632
86663322 - 22336668 = 64326654
66654432 - 23445666 = 43208766
87664320 - 2346678 = 85317642
87654321 - 12345678 = 75308643
87654330 - 3345678 = 84308652
88654320 - 2345688 = 86308632
Chain length 13
";

                // act
                Q263CS.GetAnswer(input);
                string actual = sw.ToString();

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void CSTestMethod7()
        {
            // arrange
            int input = 3434453;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                string expected =
@"Original number was 3434453
5444333 - 3334445 = 2109888
9888210 - 128889 = 9759321
9975321 - 1235799 = 8739522
9875322 - 2235789 = 7639533
9765333 - 3335679 = 6429654
9665442 - 2445669 = 7219773
9777321 - 1237779 = 8539542
9855432 - 2345589 = 7509843
9875430 - 345789 = 9529641
9965421 - 1245699 = 8719722
9877221 - 1227789 = 8649432
9864432 - 2344689 = 7519743
9775431 - 1345779 = 8429652
9865422 - 2245689 = 7619733
9776331 - 1336779 = 8439552
9855432 - 2345589 = 7509843
Chain length 16
";

                // act
                Q263CS.GetAnswer(input);
                string actual = sw.ToString();

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void CSTestMethod8()
        {
            // arrange
            int input = 9833;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                string expected =
@"Original number was 9833
9833 - 3389 = 6444
6444 - 4446 = 1998
9981 - 1899 = 8082
8820 - 288 = 8532
8532 - 2358 = 6174
7641 - 1467 = 6174
Chain length 6
";

                // act
                Q263CS.GetAnswer(input);
                string actual = sw.ToString();

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void CSTestMethod9()
        {
            // arrange
            int input = 1;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                string expected =
@"Original number was 1
1 - 1 = 0
0 - 0 = 0
Chain length 2
";

                // act
                Q263CS.GetAnswer(input);
                string actual = sw.ToString();

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void CSTestMethod10()
        {
            // arrange
            int input = 3589458;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                string expected =
@"Original number was 3589458
9885543 - 3455889 = 6429654
9665442 - 2445669 = 7219773
9777321 - 1237779 = 8539542
9855432 - 2345589 = 7509843
9875430 - 345789 = 9529641
9965421 - 1245699 = 8719722
9877221 - 1227789 = 8649432
9864432 - 2344689 = 7519743
9775431 - 1345779 = 8429652
9865422 - 2245689 = 7619733
9776331 - 1336779 = 8439552
9855432 - 2345589 = 7509843
Chain length 12
";

                // act
                Q263CS.GetAnswer(input);
                string actual = sw.ToString();

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

        #endregion CSharp

        #region FSharp

        [TestMethod]
        public void FSTestMethod1()
        {
            // arrange
            int input = 123456789;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                string expected =
@"Original number was 123456789
987654321 - 123456789 = 864197532
987654321 - 123456789 = 864197532
Chain length 2
";

                // act
                Q263FS.GetAnswer(input);
                string actual = sw.ToString();

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void FSTestMethod2()
        {
            // arrange
            int input = 1234;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                string expected =
@"Original number was 1234
4321 - 1234 = 3087
8730 - 378 = 8352
8532 - 2358 = 6174
7641 - 1467 = 6174
Chain length 4
";

                // act
                Q263FS.GetAnswer(input);
                string actual = sw.ToString();

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void FSTestMethod3()
        {
            // arrange
            int input = 444;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                string expected =
@"Original number was 444
444 - 444 = 0
0 - 0 = 0
Chain length 2
";

                // act
                Q263FS.GetAnswer(input);
                string actual = sw.ToString();

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void FSTestMethod4()
        {
            // arrange
            int input = 92482438;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                string expected =
@"Original number was 92482438
98844322 - 22344889 = 76499433
99764433 - 33446799 = 66317634
76664331 - 13346667 = 63317664
76664331 - 13346667 = 63317664
Chain length 4
";

                // act
                Q263FS.GetAnswer(input);
                string actual = sw.ToString();

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void FSTestMethod5()
        {
            // arrange
            int input = 57878377;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                string expected =
@"Original number was 57878377
88777753 - 35777788 = 52999965
99996552 - 25569999 = 74426553
76554432 - 23445567 = 53108865
88655310 - 1355688 = 87299622
99876222 - 22267899 = 77608323
87763320 - 2336778 = 85426542
86554422 - 22445568 = 64108854
88654410 - 1445688 = 87208722
88772220 - 2227788 = 86544432
86544432 - 23444568 = 63099864
99866430 - 3466899 = 96399531
99965331 - 13356999 = 86608332
88663320 - 2336688 = 86326632
86663322 - 22336668 = 64326654
66654432 - 23445666 = 43208766
87664320 - 2346678 = 85317642
87654321 - 12345678 = 75308643
87654330 - 3345678 = 84308652
88654320 - 2345688 = 86308632
88663320 - 2336688 = 86326632
Chain length 20
";

                // act
                Q263FS.GetAnswer(input);
                string actual = sw.ToString();

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void FSTestMethod6()
        {
            // arrange
            int input = 34131232;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                string expected =
@"Original number was 34131232
43332211 - 11223334 = 32108877
88773210 - 1237788 = 87535422
87554322 - 22345578 = 65208744
87654420 - 2445678 = 85208742
88754220 - 2245788 = 86508432
88654320 - 2345688 = 86308632
88663320 - 2336688 = 86326632
86663322 - 22336668 = 64326654
66654432 - 23445666 = 43208766
87664320 - 2346678 = 85317642
87654321 - 12345678 = 75308643
87654330 - 3345678 = 84308652
88654320 - 2345688 = 86308632
Chain length 13
";

                // act
                Q263FS.GetAnswer(input);
                string actual = sw.ToString();

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void FSTestMethod7()
        {
            // arrange
            int input = 3434453;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                string expected =
@"Original number was 3434453
5444333 - 3334445 = 2109888
9888210 - 128889 = 9759321
9975321 - 1235799 = 8739522
9875322 - 2235789 = 7639533
9765333 - 3335679 = 6429654
9665442 - 2445669 = 7219773
9777321 - 1237779 = 8539542
9855432 - 2345589 = 7509843
9875430 - 345789 = 9529641
9965421 - 1245699 = 8719722
9877221 - 1227789 = 8649432
9864432 - 2344689 = 7519743
9775431 - 1345779 = 8429652
9865422 - 2245689 = 7619733
9776331 - 1336779 = 8439552
9855432 - 2345589 = 7509843
Chain length 16
";

                // act
                Q263FS.GetAnswer(input);
                string actual = sw.ToString();

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void FSTestMethod8()
        {
            // arrange
            int input = 9833;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                string expected =
@"Original number was 9833
9833 - 3389 = 6444
6444 - 4446 = 1998
9981 - 1899 = 8082
8820 - 288 = 8532
8532 - 2358 = 6174
7641 - 1467 = 6174
Chain length 6
";

                // act
                Q263FS.GetAnswer(input);
                string actual = sw.ToString();

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void FSTestMethod9()
        {
            // arrange
            int input = 1;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                string expected =
@"Original number was 1
1 - 1 = 0
0 - 0 = 0
Chain length 2
";

                // act
                Q263FS.GetAnswer(input);
                string actual = sw.ToString();

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

        [TestMethod]
        public void FSTestMethod10()
        {
            // arrange
            int input = 3589458;

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                string expected =
@"Original number was 3589458
9885543 - 3455889 = 6429654
9665442 - 2445669 = 7219773
9777321 - 1237779 = 8539542
9855432 - 2345589 = 7509843
9875430 - 345789 = 9529641
9965421 - 1245699 = 8719722
9877221 - 1227789 = 8649432
9864432 - 2344689 = 7519743
9775431 - 1345779 = 8429652
9865422 - 2245689 = 7619733
9776331 - 1336779 = 8439552
9855432 - 2345589 = 7509843
Chain length 12
";

                // act
                Q263FS.GetAnswer(input);
                string actual = sw.ToString();

                // assert
                Assert.AreEqual(expected, actual);
            }
        }

        #endregion FSharp
    }
}