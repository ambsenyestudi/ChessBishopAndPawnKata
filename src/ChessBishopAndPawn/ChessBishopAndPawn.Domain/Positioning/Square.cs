using ChessBishopAndPawn.Domain.Pieces;

namespace ChessBishopAndPawn.Domain.Positioning
{
    public class Square
    {
        private BoardPosition position;
        private ChessPiece piece;

        public Square(BoardPosition position, ChessPiece piece)
        {
            this.position = position;
            this.piece = piece;
        }
        public Square(BoardColumns column, int row, ChessPiece piece): this(new BoardPosition(column, row), piece)
        {
        }

        public bool Contains(ChessPiece piece) =>
            this.piece == piece;
        public bool IsEmpty() =>
            piece == null || piece == ChessPiece.Empty;
        public override bool Equals(object obj)
        {
            if(obj is string)
            {
                var squarePos = (string)obj;
                return squarePos == this.ToString();
            }
            if(obj is Square)
            {
                var square = (Square)obj;
                return this.GetHashCode() == square.GetHashCode();
            }
            return false;
        }
        public override string ToString() =>
            position.ToString();

        public override int GetHashCode() =>
            this.ToString().GetHashCode();
        internal Square AddPiece(ChessPiece piece) =>
            new Square(position, piece);

        internal BoardPosition ToPosition() => position;
    }
}
