using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgrammingProblems.StringProblems.LongestCommonSubsequence
{
    /// <summary>
    /// https://leetcode.com/problems/longest-common-subsequence/
    /// </summary>
    public class LongestCommonSubsequence_Recursion_V1
    {
        private string str1;
        private string str2;

        public int Calculate(string strOne, string strTwo)
        {
            str1 = strOne;
            str2 = strTwo;
            return Calculate(0, 0);
        }

        private int Calculate(int indexOne, int indexTwo)
        {
            if (indexOne >= str1.Length || indexTwo >= str2.Length)
            {
                return 0;
            }

            //Case 1 : When indexOne is equal to indexTwo
            if (str1[indexOne] == str2[indexTwo])
            {
                return 1 + Calculate(indexOne + 1, indexTwo + 1);
            }
            else
            {
                return Math.Max(Calculate(indexOne, indexTwo + 1), Calculate(indexOne + 1, indexTwo));
            }
        }
    }
}
