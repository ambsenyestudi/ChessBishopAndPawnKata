namespace ChessBishopAndPawn.Domain.Positioning
{
    public record Position
    {
        public static Position Empty { get; } = new Position(0, 0);
        protected int X { get; }
        protected int Y { get; }
        protected Position(int x, int y) => (X, Y) = (x, y);

        public static Position FromDirection(Directions directions, int scalar)
        {
            var unit = UnitOffset.FromDirection(directions);
            return unit.Multiply(scalar);
        }
                
        public Position Multiply(int scalar) =>
            new Position(X * scalar, Y * scalar);

        public Position Add(Position other) =>
            new Position(X + other.X, Y + other.Y);

    }
}
