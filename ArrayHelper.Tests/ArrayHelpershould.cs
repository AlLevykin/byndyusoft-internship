using System;
using Xunit;
using ByndyusoftInternship;

namespace Tests
{
    public class ArrayHelperShould
    {
        [Theory]
        [InlineData(new int[] {1, 2, 3, 4, 5, 4, 3, 2, 1}, 2)]
        [InlineData(new int[] {1, 2, 3, 4, 5, 4, 3, 2, -1}, 0)]
        [InlineData(new int[] {-1, 2, 3, 4, 5, 4, 3, 2, -1}, -2)]
        [InlineData(new int[] {int.MaxValue, 0}, int.MaxValue)]
        [InlineData(new int[] {int.MinValue, 0}, int.MinValue)]
        public void Should_GetMinSum(int[] arr, int s)
        {
            Assert.Equal<int>(s, ArrayHelper.GetMinSum(arr));
        }

        [Theory]
        [InlineData(null)]
        [InlineData(new int[] {})]
        [InlineData(new int[] {0})]
        public void Should_ThrowArgumentException(int[] arr)
        {
            Assert.Throws<ArgumentException>(()=>ArrayHelper.GetMinSum(arr));
        }

        [Theory]
        [InlineData(new int[] {int.MaxValue, 1})]
        [InlineData(new int[] {int.MinValue, -1})]
        public void Should_ThrowOverflowException(int[] arr)
        {
            Assert.Throws<OverflowException>(()=>ArrayHelper.GetMinSum(arr));
        }
    }
}
