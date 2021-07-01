using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgrammingProblems.StringProblems.LongestCommonSubsequence
{
    /// <summary>
    /// https://www.geeksforgeeks.org/longest-common-subsequence-dp-using-memoization/
    /// </summary>
    public class LongestCommonSubsequence_Top_Down_V1
    {
        private string str1;
        private string str2;
        private int[,] memoryTable;
        public int Calculate(string strOne, string strTwo)
        {
            str1 = strOne;
            str2 = strTwo;
            memoryTable = new int[strOne.Length, strTwo.Length];
            for (var row = 0; row < strOne.Length; row++)
            {
                for (var column = 0; column < strTwo.Length; column++)
                {
                    memoryTable[row, column] = -1;
                }
            }

            return Calculate(strOne.Length - 1, strTwo.Length - 1);
        }

        private int Calculate(int indexOne, int indexTwo)
        {
            if (indexOne < 0 || indexTwo < 0)
            {
                return 0;
            }

            if (memoryTable[indexOne, indexTwo] > -1)
            {
                return memoryTable[indexOne, indexTwo];
            }

            if (str1[indexOne] == str2[indexTwo])
            {
                memoryTable[indexOne, indexTwo] = 1 + Calculate(indexOne - 1, indexTwo - 1);
                return memoryTable[indexOne, indexTwo];
            }

            memoryTable[indexOne, indexTwo] = Math.Max(Calculate(indexOne, indexTwo - 1), Calculate(indexOne - 1, indexTwo));
            return memoryTable[indexOne, indexTwo];
        }
    }
}
