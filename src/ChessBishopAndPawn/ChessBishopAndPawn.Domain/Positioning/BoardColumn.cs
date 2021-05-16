namespace ChessBishopAndPawn.Domain.Positioning
{
    public record BoardColumn
    {
        public static BoardColumn None { get; } = new BoardColumn(0, "None");
        public static BoardColumn A { get; } = new BoardColumn(1, "A");
        public static BoardColumn B { get; } = new BoardColumn(2, "B");
        public static BoardColumn C { get; } = new BoardColumn(3, "C");
        public static BoardColumn D { get; } = new BoardColumn(4, "D");
        public static BoardColumn E { get; } = new BoardColumn(5, "E");
        public static BoardColumn F { get; } = new BoardColumn(6, "F");
        public static BoardColumn G { get; } = new BoardColumn(7, "G");
        public static BoardColumn H { get; } = new BoardColumn(8, "H");

        const int offset = 1;
        public int Index { get; }
        public string Letter { get;}
        private BoardColumn(int index, string letter) => (Index, Letter) = (index, Letter);
        public int ToYPositionCoordinate() =>
            Index - offset;

        public override string ToString() =>
            Letter;

        public BoardColumn FromXPositionCooridnate(int x) =>
            None;
            //todo


    }
}
