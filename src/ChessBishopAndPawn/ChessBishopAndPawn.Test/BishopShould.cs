using ChessBishopAndPawn.Domain;
using Xunit;

namespace ChessBishopAndPawn.Test
{
    public class BishopShould
    {
        [Fact]
        public void BeAtBoard()
        {
            var sut = new Board();
            var isPresent = sut.Contains("Bishop");
            Assert.True(isPresent);
        }
        [Theory]
        [InlineData("A1", "B2")]
        [InlineData("A1", "C3")]
        public void BeAbleToMove(string origin, string exptected)
        {
            var sut = new Board();
            var bishop = sut.GetByName("Bishop");
            sut.Spawn(bishop, origin);
            var moves = sut.GetAvailableMoves(bishop);
            Assert.Contains(moves, m=>m.Contains(exptected));
        }

        [Fact]
        public void BeAtSpawnedPosition()
        {
            var origin = "A1";
            var sut = new Board();
            var bishop = sut.GetByName("Bishop");
            sut.Spawn(bishop, origin);
            Assert.True(sut.IsAtPosition(bishop, origin));
        }
    }
}
