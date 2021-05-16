namespace ChessBishopAndPawn.Domain.Positioning
{
    public record UnitOffset: Position
    {
        public static UnitOffset Forward { get; } = new UnitOffset(0, 1);
        public static UnitOffset ForwardRight { get; } = new UnitOffset(1, 1);
        public static UnitOffset Right { get; } = new UnitOffset(1, 0);
        public static UnitOffset BackwardsRight { get; } = new UnitOffset(1, -1);
        public static UnitOffset Backwards { get; } = new UnitOffset(0, -1);
        public static UnitOffset BackwardsLeft { get; } = new UnitOffset(-1, -1);
        public static UnitOffset Left { get; } = new UnitOffset(-1, 0);
        public static UnitOffset ForwardLeft { get; } = new UnitOffset(-1, 1);

        private UnitOffset(int x, int y): base(x, y)
        {

        }

        public static UnitOffset FromDirection(Directions direction)
        {
            if(direction == Directions.Forward)
            {
                return Forward;
            }
            if (direction == Directions.ForwardRight)
            {
                return ForwardRight;
            }
            if (direction == Directions.BackwardsRight)
            {
                return BackwardsRight;
            }
            if (direction == Directions.Backwards)
            {
                return Backwards;
            }
            if (direction == Directions.BackwardsLeft)
            {
                return BackwardsLeft;
            }
            if (direction == Directions.Left)
            {
                return Left;
            }
            if (direction == Directions.ForwardLeft)
            {
                return ForwardLeft;
            }
            return (UnitOffset)Empty;
        }

        


        
    }
}
