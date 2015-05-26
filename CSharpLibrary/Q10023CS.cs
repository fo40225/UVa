//-----------------------------------------------------------------------
// <copyright file="Q10023CS.cs" company="CompanyName">
//     Copyright (c) Ching Hsu, CompanyName. All rights reserved.
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
            // -----------------------------------------------------------------
            //    1 3                             result>>1                    
            //   ----                             v                            
            // 1 |169                            1 1 0 1                       
            // 1 |100  =>                     ----------                       
            // 23| 69                   1     | 10101001 <-num  ( BitLength: 8)
            //  3| 69                   1     |  1000000 <-mask ( 1 << 8-2 )   
            //   |  0      +=mask<<1-> 101    |  1101001 <-num-=               
            //               mask>>2->   1    |  1010000                       
            //                         1100   |    11001                       
            //                            0   |      0                         
            //                         11001  |    11001                       
            //                             1  |    11001                       
            //                                |        0                       
            //                                                                 
            //    1 7              1 0 0 0 1                                   
            //   ----             ----------                                   
            // 1 |289       1     |100100001 <-num  ( BitLength: 9)            
            // 1 |100       1     |100000000 <-mask ( 1 << 9-1 )               
            // 27|189      100    |   100001                                   
            //  7|189        0    |  0                                         
            //   |  0      1000   |   100001                                   
            //                0   |    0                                       
            //             10000  |   100001                                   
            //                 0  |      0                                     
            //             100001 |   100001                                   
            //                  1 |   100001                                   
            //                    |        0                                   
            // -----------------------------------------------------------------
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