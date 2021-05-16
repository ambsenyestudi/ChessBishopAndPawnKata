using ChessBishopAndPawn.Domain.Positioning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBishopAndPawn.Domain
{
    public class BoardBounds:Bounds
    {
        public BoardBounds(BoardColumns column, int row, BoardColumns end, int endRow) : base (((int)column - 1), row - 1)
        {

        }
    }
}
