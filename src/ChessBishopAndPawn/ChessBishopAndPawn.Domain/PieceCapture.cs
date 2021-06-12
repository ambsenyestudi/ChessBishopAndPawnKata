namespace ChessBishopAndPawn.Domain
{
    public class PieceCapture
    {
        private readonly char attackerColumn;
        private readonly int attakerRow;

        public PieceCapture(char attackerColumn, int attakerRow)
        {
            this.attackerColumn = attackerColumn;
            this.attakerRow = attakerRow;
        }
        public bool IsCapture(char defenderColumn, int defenderRow)
        {
            return false;
        }
    }
}
