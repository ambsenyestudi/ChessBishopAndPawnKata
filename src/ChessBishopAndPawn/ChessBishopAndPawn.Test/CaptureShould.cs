
using ChessBishopAndPawn.Domain;
using Xunit;

namespace ChessBishopAndPawn.Test
{
    public class CaptureShould
    {
        [Fact]
        public void DetectPawnCapture()
        {
            var bishopPostions = new PiecePostition('A', 1);

            var pawnPostions = new PiecePostition('C', 3);
            var sut = new PieceCapture(bishopPostions);
            Assert.True(sut.IsCapture(pawnPostions));

        }
    }
}
