using System;
using System.Collections.Generic;
using System.Linq;

namespace ChessBishopAndPawn.Domain
{
    public class Board
    {
        private const int MAX_COUNT = 8;
        public IEnumerable<int> GetAllSquare()
        {
            var squareCollection = new List<int>();
            for (int y = 0; y < MAX_COUNT; y++)
            {
                for (int x = 0; x < MAX_COUNT; x++)
                {
                    squareCollection.Add(0);
                }
            }
            return squareCollection;
        }
    }
}
