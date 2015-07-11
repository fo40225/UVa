//-----------------------------------------------------------------------
// <copyright file="Q12854CS.cs" company="CompanyName">
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
    /// Q12854 in C#
    /// </summary>
    public static class Q12854CS
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

            var plugs = input.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Where(y => y != ' ')
                        .Select(y => int.Parse(y.ToString())).ToArray()).ToList();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < plugs.Count; i = i + 2)
            {
                var first = plugs[i];
                var second = plugs[i + 1];
                var isCompatible = first.Zip(second, (a, b) => a ^ b).All(x => x == 1);
                sb.AppendLine(isCompatible ? "Y" : "N");
            }

            return sb.ToString();
        }
    }
}