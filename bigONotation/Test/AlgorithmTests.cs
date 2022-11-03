using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bigONotation.Algoritimos;
using bigONotation.Test.Comun;
using Xunit;
using FluentAssertions;

namespace bigONotation.Test
{
    public class AlgorithmTests
    {
        [Theory]
        [InlineData(0, false)]
        [InlineData(1, true)]
        [InlineData(2, false)]
        public void When_call_IsEven_Shoul_Return_respe(int index, bool expectedResult)
        {
            // Given
            var array = DataGenerator.GetInts();
            // When
            var result = Constant.IsEven(array, index);
            // Then
            result.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(new int[] { 59, 10 }, 10)]
        [InlineData(new int[] { 59, 10, 20, 50, 57, 10, 9 }, 9)]
        public void When_call_GetMin_should_return_expected_result(int[] array, int expectedResult)
        {
            // Given

            // When
            var result = Linear.GetMin(array);
            // Then
            result.Should().Be(expectedResult);
        }
        [Theory]
        [InlineData(new int[] { 1, 2, 1 }, true)]
        [InlineData(new int[] { 1, 2, 0, 500, 3404, 55, 23 }, false)]
        public void When_call_hasDuplicates_should_return_expected_result(int[] array, bool expected)
        {
            // Given

            // When
            var result = Quadratic.hasDuplicates(array);
            // Then
            result.Should().Be(expected);
        }
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 7)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 3)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 }, 4)]
        [InlineData(new int[] { 1, 2, 7, 4, 5, 6, 3, 8 }, 7)]
        public void When_call_BinarySearch_should_return_expectedResult(int[] array, int value)
        {
            // Given

            // When
            var result = Logarithmic.BinarySearch(array, value);
            // Then
            result.Should().Be(value);
        }
        [Theory]
        [InlineData(new int[] { 9, 3, 2, 1, 5, 8 }, new int[] { 1, 2, 3, 5, 8, 9 })]
        public void When_call_bubbleSort_Should_return_expected_resuld(int[] parameters, int[] expected)
        {
            // Given

            // When
            int[] result = Polinomial.BubbleSort(parameters);
            // Then
            result.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
        }
    }
}