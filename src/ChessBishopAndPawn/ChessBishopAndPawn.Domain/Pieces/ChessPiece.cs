using ChessBishopAndPawn.Domain.Positioning;
using System;

namespace ChessBishopAndPawn.Domain.Pieces
{
    public class ChessPiece
    {
        public static ChessPiece Empty = new ChessPiece(Guid.Empty, string.Empty); 
        private readonly Guid id;
        public readonly string name;

        public ChessPiece(Guid id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public ChessPiece(string name):this(Guid.NewGuid(), name)
        {
        }
        public bool Is(string name) =>
            this.name == name;

        public override string ToString() =>
            name;

        public override bool Equals(object obj)
        {
            var piece = obj as ChessPiece;
            if(piece == null)
            {
                return false;
            }
            return piece.id == id;
        }

        public override int GetHashCode() =>
            name.GetHashCode() + id.GetHashCode();
                
    }
}
