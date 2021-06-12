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
            return IsAtDiagonal(defenderPosition);
        }

        private bool IsSameRow(PiecePostition defenderPosition) =>
            AttackerPosition.IsRowAligned(defenderPosition);

        private bool IsSameColumn(PiecePostition defenderPosition) =>
            AttackerPosition.IsColumnAligned(defenderPosition);

        private bool IsAtDiagonal(PiecePostition defenderPosition)
        {
            var deltaColum = GetDelta(AttackerPosition.Column, defenderPosition.Column);
            var deltaRow = GetDelta(AttackerPosition.Row, defenderPosition.Row);
            return Math.Abs(deltaColum) == Math.Abs(deltaRow);
        }

        private int GetDelta(int rowOrigin, int rowEnd) =>
            rowEnd - rowOrigin;

        private int GetDelta(char columnOrigin, char columnEnd) =>
            GetDelta((int)columnOrigin, (int)columnEnd);
    }
}
