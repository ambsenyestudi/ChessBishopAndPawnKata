using ChessBishopAndPawn.Domain.Pieces;
using System.Collections.Generic;
using System.Linq;

namespace ChessBishopAndPawn.Domain.Positioning
{
    public class SquareCollection
    {
        
        private readonly List<Square> squareCollection;

        public SquareCollection(int size)
        {
            squareCollection = CreateEmpty(size);
        }
        private List<Square> CreateEmpty(int size)
        {
            var squareCollection = new List<Square>();
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    var column = ((BoardColumns)(x + 1)).ToString();
                    var row = y + 1;
                    var square = new Square(column, row, ChessPiece.Empty);
                    squareCollection.Add(square);
                }
            }
            return squareCollection;
        }

        public void Move(ChessPiece piece, string targenPosition)
        {
            squareCollection[0] = squareCollection[0].AddPiece(piece);
        }


        internal bool ContainsAt(ChessPiece piece, string pos)
        {
            var matchCollection = squareCollection.Where(s => s.Equals(pos));
            if(matchCollection.Any())
            {

                var found = matchCollection.First();
                return found.Contains(piece);
            }
            return false;
        }
    }
}
