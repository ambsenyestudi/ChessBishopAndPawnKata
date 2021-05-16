using ChessBishopAndPawn.Domain.Positioning;
using Xunit;

namespace ChessBishopAndPawn.Test
{
    public class PositionShould
    {
        [Theory]
        [InlineData(BoardColumns.A, 1, Directions.Forward, "A2", 1)]
        [InlineData(BoardColumns.A, 1, Directions.Forward, "A8", 7)]
        [InlineData(BoardColumns.A, 1, Directions.ForwardRight, "B2", 1)]
        [InlineData(BoardColumns.A, 1, Directions.ForwardRight, "H8", 7)]
        [InlineData(BoardColumns.A, 1, Directions.Right, "B1", 1)]
        [InlineData(BoardColumns.A, 1, Directions.Right, "H1", 7)]
        [InlineData(BoardColumns.H, 1, Directions.Left, "G1", 1)]
        [InlineData(BoardColumns.H, 1, Directions.Left, "A1", 7)]
        [InlineData(BoardColumns.H, 1, Directions.ForwardLeft, "G2", 1)]
        [InlineData(BoardColumns.H, 1, Directions.ForwardLeft, "A8", 7)]
        [InlineData(BoardColumns.H, 8, Directions.Backwards, "H7", 1)]
        [InlineData(BoardColumns.H, 8, Directions.Backwards, "H1", 7)]
        [InlineData(BoardColumns.H, 8, Directions.BackwardsLeft, "G7", 1)]
        [InlineData(BoardColumns.H, 8, Directions.BackwardsLeft, "A1", 7)]
        [InlineData(BoardColumns.A, 8, Directions.BackwardsRight, "B7", 1)]
        [InlineData(BoardColumns.A, 8, Directions.BackwardsRight, "H1", 7)]
        public void MoveTo(BoardColumns originCol, int originRow, Directions direction, string exptected, int iterations)
        {
            var originPostion = new BoardPosition(originCol, originRow);
            var result = originPostion.GetFromDirectionIterations(direction, iterations);
            
            Assert.Contains(result, x => x.ToString() == exptected);

        }
    }
}
