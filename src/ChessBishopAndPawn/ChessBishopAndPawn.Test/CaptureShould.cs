
using ChessBishopAndPawn.Domain;
using Xunit;

namespace ChessBishopAndPawn.Test
{
    public class CaptureShould
    {
        [Fact]
        public void DetectPawnCapture()
        {
            var bishopRow = 1;
            var bishopColumn = 'A';
            var pawnRow = 3;
            var pawnColumn = 'C';
            var sut = new PieceCapture(bishopColumn, bishopRow);
            Assert.True(sut.IsCapture(pawnColumn, pawnRow));

        }
    }
}
