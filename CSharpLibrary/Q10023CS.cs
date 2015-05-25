//-----------------------------------------------------------------------
// <copyright file="Q10023CS.cs">
//     Copyright (c) Ching Hsu. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CSharpLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Q10023 Square root in C#
    /// </summary>
    public static class Q10023CS
    {
        public static BigInteger GetAnswer(BigInteger input)
        {
            return input.Sqrt();
        }

        /// <summary>
        /// Returns the square root of a specified number.
        /// </summary>
        /// <param name="num">The number whose square root is to be found.</param>
        /// <returns>The positive square root of number.</returns>
        private static BigInteger Sqrt(this BigInteger num)
        {
            int numBitLength = num.BitLength();
            BigInteger result = BigInteger.Zero;
            BigInteger mask = BigInteger.One << (((numBitLength & 1) == 0) ? (numBitLength - 2) : (numBitLength - 1));

            while (mask > 0)
            {
                if (num >= result + mask)
                {
                    num -= result + mask;
                    result += mask << 1;
                }
                result >>= 1;
                mask >>= 2;
            }
            return result;
        }

        /// <summary>
        /// Returns the number of bits in the bi.
        /// </summary>
        /// <param name="bi">The number whose number of bits is to be found.</param>
        /// <returns>Number of bits in bi.</returns>
        private static int BitLength(this BigInteger bi)
        {
            int l = 0;
            while (bi > 0)
            {
                bi >>= 1;
                l++;
            }
            return l;
        }
    }
}