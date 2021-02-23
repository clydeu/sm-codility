using codility_test;
using FluentAssertions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace test
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper output;

        public UnitTest1(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Theory]
        [InlineData(new int[] { 5, 8 }, 8)]
        [InlineData(new int[] { 1, 3, 2, 1, 2, 1, 5, 3, 3, 4, 2 }, 9)]
        [InlineData(new int[] { 1, 1, 1, 1 }, 1)]
        [InlineData(new int[] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2 }, 6)]
        [InlineData(new int[] { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3 }, 11)]
        [InlineData(new int[] { 0, 0 }, 0)]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 1, 1, 0, 1 }, 2)]
        public void Task1_test(int[] A, int result)
        {
            var timer = new Stopwatch();
            timer.Start();
            var actual = Task1.Function(A);
            timer.Stop();

            actual.Should().Be(result);
            output.WriteLine("Execution time: {0}ms", timer.Elapsed.TotalMilliseconds);
        }

        public static IEnumerable<object[]> Test2TestData()
        {
            yield return new object[] { Enumerable.Repeat(1, 1000000).ToArray(), 0 };

            var a = new int[7501];
            for (var i = 0; i <= 7500; i++)
            {
                a[i] = i;
            }

            yield return new object[] { a, 7500 };
        }

        [Theory]
        [InlineData(new int[] { 4, 6, 2, 2, 6, 6, 4 }, 5)]
        [MemberData(nameof(Test2TestData))]
        public void Task2_test(int[] A, int result)
        {
            var array = Enumerable.Repeat(1, 1000000).ToArray();

            Task2.Function(A).Should().Be(result);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4 }, 7)]
        [InlineData(new int[] { 1, 1, 3, 3, 3, 4, 5, 5, 5, 5 }, 5)]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 3, 3, 3, 4, 5, 5, 5, 5 }, 7)]
        public void Task3_test(int[] A, int result)
        {
            Task3.Function(A, 2).Should().Be(result);
        }
    }
}