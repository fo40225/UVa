//-----------------------------------------------------------------------
// <copyright file="Q12844CS.cs" company="CompanyName">
//     Copyright (c) Ching Hsu, CompanyName. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CSharpLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Q12844 in C#
    /// </summary>
    public static class Q12844CS
    {
        public static string GetAnswer(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input", "input is null");
            }

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException("input is empty or all whitespace", "input");
            }

            var sums = input.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(x => x.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(y => int.Parse(y.ToString())).ToArray()).ToList();
            StringBuilder sb = new StringBuilder();
            int count = 1;
            foreach (var sum in sums)
            {
                Array.Sort(sum);
                int sumAll = sum.Sum();
                int abcde = sumAll / 4;
                int ab = sum[0];
                int ac = sum[1];
                int ce = sum[8];
                int de = sum[9];
                int c = abcde - ab - de;
                int a = ac - c;
                int b = ab - a;
                int e = ce - c;
                int d = de - e;
                sb.AppendLine(string.Format("Case {0}: {1}", count, string.Join(" ", a, b, c, d, e)));
                count++;
            }

            return sb.ToString();
        }
    }
}