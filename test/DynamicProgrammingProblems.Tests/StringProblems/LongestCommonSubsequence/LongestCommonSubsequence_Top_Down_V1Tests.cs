using DynamicProgrammingProblems.StringProblems.LongestCommonSubsequence;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgrammingProblems.Tests.StringProblems.LongestCommonSubsequence
{
    [TestClass]
    public class LongestCommonSubsequence_Top_Down_V1Tests
    {
        [TestMethod]
        public void Given_TwoStrings_When_Calculate_Then_ShouldReturnLongestCommonSubsequence()
        {
            //Given
            var strOne = "abcde";
            var strTwo = "ace";
            var problem = new LongestCommonSubsequence_Top_Down_V1();
            var expectedResult = 3;

            //When
            var actualResult = problem.Calculate(strOne, strTwo);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
