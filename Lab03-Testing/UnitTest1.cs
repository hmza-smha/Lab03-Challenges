using System;
using Xunit;
using Lab03_Challenges;

namespace Lab03_Testing
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(480, "4 8 15")]
        [InlineData(480, "4 8 15 50")]
        [InlineData(0, "4 8")]
        [InlineData(-4, "-4 1 1")]
        public void Test_Multiplying(int expectedValue, string inputValue)
        {
            Assert.Equal(expectedValue, Challenge1.Multiplying(inputValue));
        }


        [Theory]
        [InlineData(10, new int[] { 4, 8, 15, 16 })]
        [InlineData(0, new int[] { 0, 0, 0, 0 })]
        [InlineData(2, new int[] { 1, 2, 3 })]
        public void Test_Avg(int expectedValue, int[] inputValue)
        {
            Assert.Equal(expectedValue, Challenge2.GetAvg(inputValue));
        }


        [Theory]
        [InlineData(1, new int[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 })]
        [InlineData(0, new int[] { 0, 0, 0, 0 })]
        [InlineData(1, new int[] { 1, 2, 3 })]
        [InlineData(1, new int[] { 1, 1, 3, 3, 5 })]
        public void Get_Most_Repeated(int expectedValue, int[] inputValue)
        {
            Assert.Equal(expectedValue, Challenge4.GetMostRepeated(inputValue));
        }

        [Theory]
        [InlineData(2, new int[] { -2, -1, 0, 1, 2 })]
        [InlineData(5, new int[] { 5, 5, 5, 5, 5 })]
        public void Get_Max(int expectedValue, int[] inputValue)
        {
            Assert.Equal(expectedValue, Challenge5.GetMax(inputValue));
        }


        [Theory]
        [InlineData(new string[] { "This:4", "is:2", "a:1", "sentance:8" }, "This is a sentance")]
        [InlineData(new string[] { "Hello:5", "world:5" }, "Hello world")]

        public void Count_Letters(string[] expectedValue, string inputValue)
        {
            Assert.Equal(expectedValue, Challenge9.CountLetters(inputValue));
        }


    }
}
