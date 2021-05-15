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
    }
}
