using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBishopAndPawn.Domain.Positioning
{
    public record BoardPosition: Position
    {
        private BoardColumns Column { get => (BoardColumns)X; }
        private int Row { get => Y; }
        
        public BoardPosition(BoardColumns column, int row) : base((int)column, row)
        {
        }
        public bool TryMove(Directions directions, out BoardPosition position)
        {
            //Todo check if in bounds
            var (column, row) = GetOffsetFromDirection(directions);
            if (column == 0 && row == 0)
            {
                position = null;
                return false;
            }

        }

        public UnitOffset Add(UnitOffset offset)
        {
            throw new NotImplementedException();
        }

        private bool CanIncrementColumn(BoardColumns column, int offset) =>
             Enum.IsDefined(typeof(BoardColumns), column + offset);

        
    }
}
