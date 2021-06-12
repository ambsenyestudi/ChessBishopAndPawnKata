namespace ChessBishopAndPawn.Domain
{
    public class PieceCapture
    {
        private PiecePostition AttackerPosition { get; }

        public PieceCapture(PiecePostition attackerPosition) =>
            (AttackerPosition) = (attackerPosition);
        public bool IsCapture(PiecePostition defenderPosition)
        {
            return true;
        }
    }
}
