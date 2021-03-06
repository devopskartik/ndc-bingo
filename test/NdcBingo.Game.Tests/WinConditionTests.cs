using System;
using System.Collections.Generic;
using Xunit;

namespace NdcBingo.Game.Tests
{
    public class WinConditionTests
    {
        [Theory]
        [MemberData(nameof(WinningHorizontalLines))]
        public void HorizontalLinesWin(int[] claims)
        {
            Assert.Equal(1, WinCondition.Check(claims).Horizontal);
        }

        [Theory]
        [MemberData(nameof(WinningVerticalLines))]
        public void VerticalLinesWin(int[] claims)
        {
            Assert.Equal(1, WinCondition.Check(claims).Vertical);
        }

        [Theory]
        [MemberData(nameof(WinningDiagonalLines))]
        public void DiagonalLinesWin(int[] claims)
        {
            Assert.Equal(1, WinCondition.Check(claims).Diagonal);
        }

        public static IEnumerable<object[]> WinningHorizontalLines()
        {
            yield return Claims(
                    1, 1, 1, 1,
                    0, 0, 0, 0,
                    0, 0, 0, 0,
                    0, 0, 0, 0
            );
            yield return Claims(
                    0, 0, 0, 0,
                    1, 1, 1, 1,
                    0, 0, 0, 0,
                    0, 0, 0, 0
            );
            yield return Claims(
                    0, 0, 0, 0,
                    0, 0, 0, 0,
                    1, 1, 1, 1,
                    0, 0, 0, 0
            );
            yield return Claims(
                    0, 0, 0, 0,
                    0, 0, 0, 0,
                    0, 0, 0, 0,
                    1, 1, 1, 1
            );
        }

        public static IEnumerable<object[]> WinningVerticalLines()
        {
            yield return Claims(
                    1, 0, 0, 0,
                    1, 0, 0, 0,
                    1, 0, 0, 0,
                    1, 0, 0, 0
            );
            yield return Claims(
                    0, 1, 0, 0,
                    0, 1, 0, 0,
                    0, 1, 0, 0,
                    0, 1, 0, 0
            );
            yield return Claims(
                    0, 0, 1, 0,
                    0, 0, 1, 0,
                    0, 0, 1, 0,
                    0, 0, 1, 0
            );
            yield return Claims(
                    0, 0, 0, 1,
                    0, 0, 0, 1,
                    0, 0, 0, 1,
                    0, 0, 0, 1
            );
        }

        public static IEnumerable<object[]> WinningDiagonalLines()
        {
            yield return Claims(
                    1, 0, 0, 0,
                    0, 1, 0, 0,
                    0, 0, 1, 0,
                    0, 0, 0, 1
            );
            yield return Claims(
                    0, 0, 0, 1,
                    0, 0, 1, 0,
                    0, 1, 0, 0,
                    1, 0, 0, 0
            );
        }

        private static object[] Claims(params int[] claims)
        {
            return new object[] { claims };
        }
    }
}