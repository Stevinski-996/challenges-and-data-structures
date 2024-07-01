using System;
using Xunit;
using Common_Elements;

namespace Common_Elements.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestCommonElements_Case1()
        {
            int[] arr1 = { 1, 2, 3, 0 };
            int[] arr2 = { 2, 3, 4, 9 };
            int[] expected = { 2, 3 };

            int[] result = Program.CommonElements(arr1, arr2);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCommonElements_Case2()
        {
            int[] arr1 = { 79, 8, 15 };
            int[] arr2 = { 23, 79, 8 };
            int[] expected = { 79, 8 };

            int[] result = Program.CommonElements(arr1, arr2);

            Assert.Equal(expected, result);
        }
    }
}