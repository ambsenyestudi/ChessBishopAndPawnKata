namespace ChessBishopAndPawn.Domain
{
    public record PiecePostition
    {
        public char Column { get; }
        public int Row { get; }

        public PiecePostition(char column, int row) =>
            (Column, Row) = (column, row);

        
    }
}
