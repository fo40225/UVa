//-----------------------------------------------------------------------
// <copyright file="Q263CS.cs">
//     Copyright (c) Ching Hsu. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace CSharpLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Q263CS
    {
        public static void GetAnswer(int input)
        {
            Console.WriteLine("Original number was {0}", input.ToString());
            HashSet<int> set = new HashSet<int>() { input };
            int max;
            int min;
            int ans;
            do
            {
                max = GetMax(input);
                min = GetMin(input);
                ans = max - min;
                Console.WriteLine("{0} - {1} = {2}", max.ToString(), min.ToString(), ans.ToString());
            } while (((Func<bool>)(() =>
            {
                if (set.Contains(ans))
                {
                    return false;
                }
                else
                {
                    set.Add(ans);
                    input = ans;
                    return true;
                }
            }))());
            Console.WriteLine("Chain length {0}", set.Count.ToString());
        }

        private static int GetMin(int i)
        {
            return Convert.ToInt32(string.Concat(i.ToString().OrderBy(x => Convert.ToInt32(x))));
        }

        private static int GetMax(int i)
        {
            return Convert.ToInt32(string.Concat(i.ToString().OrderByDescending(x => Convert.ToInt32(x))));
        }
    }
}