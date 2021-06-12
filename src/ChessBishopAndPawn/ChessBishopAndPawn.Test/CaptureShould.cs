
using ChessBishopAndPawn.Domain;
using Xunit;

namespace ChessBishopAndPawn.Test
{
    public class CaptureShould
    {
        [Theory]
        [InlineData('A', 1, 'C', 3)]
        [InlineData('B', 2, 'C', 4)]
        public void DetectPawnCapture(char attackCol, int attackRow, char defCol, int defRow)
        {
            var bishopPostions = new PiecePostition(attackCol,attackRow);
            var pawnPostions = new PiecePostition(defCol, defRow);
            var sut = new PieceCapture(bishopPostions);
            Assert.True(sut.IsCapture(pawnPostions));

        }
        [Fact]
        public void NotCapturePawnInFront()
        {
            var bishopPostions = new PiecePostition('H', 1);

            var pawnPostions = new PiecePostition('H', 3);
            var sut = new PieceCapture(bishopPostions);
            Assert.False(sut.IsCapture(pawnPostions));

        }
        [Theory]
        [InlineData('A', 1, 'C', 1)]
        public void NotCaturePawnAside(char attackCol, int attackRow, char defCol, int defRow)
        {
            var bishopPostions = new PiecePostition(attackCol, attackRow);
            var pawnPostions = new PiecePostition(defCol, defRow);
            var sut = new PieceCapture(bishopPostions);
            Assert.False(sut.IsCapture(pawnPostions));
        }
    }
}
