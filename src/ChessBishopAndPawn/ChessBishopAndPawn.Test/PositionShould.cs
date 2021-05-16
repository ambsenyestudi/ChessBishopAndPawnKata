using ChessBishopAndPawn.Domain.Positioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ChessBishopAndPawn.Test
{
    public class PositionShould
    {
        [Theory]
        [InlineData(BoardColumns.A, 1, Directions.Forward, "A2")]
        public void MoveTo(BoardColumns originCol, int originRow, Directions direction, string exptected)
        {
            var originPostion = new BoardPosition(originCol, originRow);
            var offset = UnitOffset.FromDirection(direction);
            var postion = offset.OffsetPostion(originPostion);
            Assert.Equal(exptected, postion.ToString());

        }
    }
}
