using System;
using System.Collections.Generic;

namespace ChessBishopAndPawn.Domain.Pieces
{
    public class PieceCollection
    {
        
        private readonly List<ChessPiece> squareCollection;

        public PieceCollection(int size)
        {
            squareCollection = CreateEmpty(size);
        }
        private List<ChessPiece> CreateEmpty(int size)
        {
            var squareCollection = new List<ChessPiece>();
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    squareCollection.Add(ChessPiece.Empty);
                }
            }
            return squareCollection;
        }

        public void Move(ChessPiece piece, string targenPosition)
        {
            squareCollection[0] = piece;
        }
    }
}
