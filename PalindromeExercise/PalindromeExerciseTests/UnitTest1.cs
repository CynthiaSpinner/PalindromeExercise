using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("kayak", true)]
        [InlineData("deed", true)]
        [InlineData("deified", true)]
        [InlineData("rotate",  false)]
        [InlineData("garage", false)]
        [InlineData("ridge", false)]
        public void IsAPalindromeTest(string palin, bool expected)
        {
            var palindrome = new WordSmith();

            var actual = palindrome.IsAPalinedrome(palin);

            Assert.Equal(expected, actual);
        }
    }
}
