using System.Collections.Generic;

namespace ChessBishopAndPawn.Domain.Positioning
{
    public record BoardColumn
    {
        private static List<BoardColumn> columns = new List<BoardColumn>
        {
            new BoardColumn(0, "None"),
            new BoardColumn(1, "A"),
            new BoardColumn(2, "B"),
            new BoardColumn(3, "C"),
            new BoardColumn(4, "D"),
            new BoardColumn(5, "E"),
            new BoardColumn(6, "F"),
            new BoardColumn(7, "G"),
            new BoardColumn(8, "H")
        };
        public static BoardColumn None { get; } = columns[0];

        public static BoardColumn A { get; } = columns[1];
        public static BoardColumn B { get; } = columns[2];
        public static BoardColumn C { get; } = columns[3];
        public static BoardColumn D { get; } = columns[4];
        public static BoardColumn E { get; } = columns[5];
        public static BoardColumn F { get; } = columns[6];
        public static BoardColumn G { get; } = columns[7];
        public static BoardColumn H { get; } = columns[8];

        const int offset = 1;
        public int Index { get; }
        public string Letter { get; }
        private BoardColumn(int index, string letter) => (Index, Letter) = (index, Letter);
        public int ToYPositionCoordinate() =>
            Index - offset;

        public override string ToString() =>
            Letter;

        public BoardColumn FromXPositionCooridnate(int x) =>
            columns[x + offset];
     


    }
}
