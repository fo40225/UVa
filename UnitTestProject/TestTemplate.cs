//-----------------------------------------------------------------------
// <copyright file="$$Tests.cs">
//     Copyright (c) Ching Hsu. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace UnitTestProject
{
    using System;
    using CSharpLibrary;
    using FSharpLibrary;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class $$Tests
    {
        [TestMethod]
        public void CSTestMethod1()
        {
            //arrange
            var input ;
            var expected ;

            //act
            var actual = $$CS.GetAnswer(input);

            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}