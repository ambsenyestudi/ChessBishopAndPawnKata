using ChessBishopAndPawn.Domain.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChessBishopAndPawn.Domain
{
    public class Board
    {
        private const int MAX_COUNT = 8;
        private readonly ChessPiece[] pieceList;
        private PieceCollection squareCollection;
        public Board()
        {
            pieceList = new ChessPiece[] { CreatePiece("Bishop"), CreatePiece("Pawn")};
            squareCollection = new PieceCollection(MAX_COUNT);

        }
        
        public List<int> GetAllSquare()
        {
            var squareCollection = new List<int>();
            for (int y = 0; y < MAX_COUNT; y++)
            {
                for (int x = 0; x < MAX_COUNT; x++)
                {
                    squareCollection.Add(0);
                }
            }
            return squareCollection;
        }

        public void Spawn(ChessPiece bishop, string origin)
        {
            squareCollection.Move(bishop, origin);
        }

        public IEnumerable<string> GetAvailableMoves(ChessPiece piece)
        {
            return new List<string> { "B2" };
        }

        public IEnumerable<string> GetPieces()
        {
            return pieceList.Select(p => p.ToString());
        }
        public ChessPiece GetByName(string name)
        {
            return pieceList.FirstOrDefault(x=>x.name == name);
        }
        public bool Contains(string pieceName)
        {
            return pieceList.Any(x=>x.Is(pieceName));
        }
        private ChessPiece CreatePiece(string pieceName) =>
            new ChessPiece(pieceName);
    }
}
