using ChessBishopAndPawn.Domain.Pieces;

namespace ChessBishopAndPawn.Domain.Positioning
{
    public class Square
    {
        public int Row { get; }

        private ChessPiece piece;

        public string Column { get; }

        public Square(string column, int row, ChessPiece piece)
        {
            this.Column = column;
            this.Row = row;
            this.piece = piece;
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
            Column + Row;

        public override int GetHashCode() =>
            this.ToString().GetHashCode();
        internal Square AddPiece(ChessPiece piece) =>
            new Square(Column, Row, piece);
    }
}
