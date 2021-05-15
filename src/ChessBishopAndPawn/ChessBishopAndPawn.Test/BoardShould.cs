using ChessBishopAndPawn.Domain;
using System;
using System.Linq;
using Xunit;

namespace ChessBishopAndPawn.Test
{
    public class BoardShould
    {
        [Fact]
        public void Have64Squares()
        {
            var exptectedCount = 64;
            var sut = new Board();
            var squareCollection = sut.GetAllSquare();
            Assert.Equal(exptectedCount, squareCollection.Count());
        }
        [Fact]
        public void ContainPieces()
        {
            var sut = new Board();
            var pieceCollection = sut.GetPieces();
            Assert.NotEmpty(pieceCollection);
        }
        [Theory]
        [InlineData("Bishop")]
        [InlineData("Pawn")]
        public void TellIfAPiecesIsPresent(string pieceName)
        {
            var sut = new Board();
            var result = sut.Contains(pieceName);
            Assert.True(result);
        }
    }
}
