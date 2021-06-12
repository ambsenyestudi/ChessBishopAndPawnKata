using System;

namespace ChessBishopAndPawn.Domain
{
    public class PieceCapture
    {
        private PiecePostition AttackerPosition { get; }

        public PieceCapture(PiecePostition attackerPosition) =>
            (AttackerPosition) = (attackerPosition);
        public bool IsCapture(PiecePostition defenderPosition)
        {
            if(IsSameColumn(defenderPosition))
            {
                return false;
            }
            return true;
        }

        private bool IsSameColumn(PiecePostition defenderPosition) =>
            AttackerPosition.IsColumnAligned(defenderPosition);
    }
}
