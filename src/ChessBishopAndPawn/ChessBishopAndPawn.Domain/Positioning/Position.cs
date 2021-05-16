using System.Collections.Generic;

namespace ChessBishopAndPawn.Domain.Positioning
{
    public record Position
    {
        public static Position Empty { get; } = new Position(0, 0);
        protected int X { get; }
        protected int Y { get; }
        protected Position(int x, int y) => (X, Y) = (x, y);

        public static IEnumerable<Position> FromDirection(Directions directions, int maxIterations = 8)
        {
            var unit = UnitOffset.FromDirection(directions);
            var result = new List<Position>();
            for (int i = 0; i < maxIterations; i++)
            {
                var currOffest = unit.Multiply(i + 1);
                result.Add(currOffest);
            }
            return result;
        }
                
        public Position Multiply(int scalar) =>
            new Position(X * scalar, Y * scalar);



    }
}
