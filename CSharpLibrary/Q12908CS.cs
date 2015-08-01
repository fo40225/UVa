//-----------------------------------------------------------------------
// <copyright file="Q12908CS.cs" company="CompanyName">
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
    /// Q12908 in C#
    /// </summary>
    public static class Q12908CS
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

            var books = input.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(y => int.Parse(y));

            StringBuilder sb = new StringBuilder();
            foreach (var book in books)
            {
                int page = 0;
                int sum = 0;

                while (!(sum > book))
                {
                    page++;
                    sum += page;
                }

                int lostPage = sum - book;
                sb.AppendLine(lostPage.ToString() + " " + page.ToString());
            }
            return sb.ToString();
        }
    }
}