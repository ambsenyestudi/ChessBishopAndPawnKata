using ChessBishopAndPawn.Domain.Positioning;

namespace ChessBishopAndPawn.Domain
{
    public class Bounds
    {
        private readonly Position origin;
        private readonly Position globalEndPositions;

        public Bounds(int x, int y, int width, int height)
        {
            origin = new Position(x, y);
            globalEndPositions = new Position(x + width, y + height);
        }
        public bool IsInside(Position position) =>

            position.IsGreaterOrEqualTo(origin) &&
            position.IsSmallerThan(globalEndPositions);
        
    }
}
