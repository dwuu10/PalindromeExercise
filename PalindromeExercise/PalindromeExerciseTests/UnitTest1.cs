using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("aaa", true)] // ← you will need to put some test data and expected result here.  
        [InlineData("racecar", true)]
        [InlineData("true", false)]
        [InlineData("T", true)]
        public void Test1(string word, bool expected)
        {
            //arrange
            var test = new WordSmith();
            //act
            var actual = test.IsAPalindrome(word);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
