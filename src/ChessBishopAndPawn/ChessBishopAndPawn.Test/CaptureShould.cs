
using ChessBishopAndPawn.Domain;
using Xunit;

namespace ChessBishopAndPawn.Test
{
    public class CaptureShould
    {
        [Theory]
        [InlineData('A', 1, 'C', 3)]
        [InlineData('C', 3, 'A', 1)]
        [InlineData('B', 2, 'D', 4)]
        [InlineData('D', 4, 'B', 2)]
        public void Detect_pawn_capture_when_in_diagonal(char attackCol, int attackRow, char defCol, int defRow)
        {
            var bishopPostions = new PiecePostition(attackCol,attackRow);
            var pawnPostions = new PiecePostition(defCol, defRow);
            var sut = new PieceCapture(bishopPostions);
            Assert.True(sut.IsCapture(pawnPostions));

        }

        [Theory]
        [InlineData('A', 1, 'C', 4)]
        [InlineData('B', 1, 'C', 3)]
        public void Not_capture_pawn_when_ot_of_diagonal(char attackCol, int attackRow, char defCol, int defRow)
        {
            var bishopPostions = new PiecePostition(attackCol, attackRow);
            var pawnPostions = new PiecePostition(defCol, defRow);
            var sut = new PieceCapture(bishopPostions);
            Assert.False(sut.IsCapture(pawnPostions));

        }

        [Fact]
        public void Not_capture_pawn_in_front()
        {
            var bishopPostions = new PiecePostition('H', 1);

            var pawnPostions = new PiecePostition('H', 3);
            var sut = new PieceCapture(bishopPostions);
            Assert.False(sut.IsCapture(pawnPostions));

        }
        [Theory]
        [InlineData('A', 1, 'C', 1)]
        public void Not_capture_pawn_aside(char attackCol, int attackRow, char defCol, int defRow)
        {
            var bishopPostions = new PiecePostition(attackCol, attackRow);
            var pawnPostions = new PiecePostition(defCol, defRow);
            var sut = new PieceCapture(bishopPostions);
            Assert.False(sut.IsCapture(pawnPostions));
        }
    }
}
