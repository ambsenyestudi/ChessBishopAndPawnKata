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
            if(IsSameColumn(defenderPosition)
                || IsSameRow(defenderPosition))
            {
                return false;
            }
            return true;
        }

        private bool IsSameRow(PiecePostition defenderPosition) =>
            AttackerPosition.IsRowAligned(defenderPosition);

        private bool IsSameColumn(PiecePostition defenderPosition) =>
            AttackerPosition.IsColumnAligned(defenderPosition);
    }
}
