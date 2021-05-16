﻿using System;
using System.Collections.Generic;

namespace ChessBishopAndPawn.Domain.Positioning
{
    public record BoardPosition : Position
    {

        private readonly BoardColumn column;
        private int Row { get => Y + 1; }

        public BoardPosition(BoardColumn column, int row) : base(column.ToYPositionCoordinate(), row - 1)
        {
            this.column = column;
        }
        private BoardPosition(Position position) : base(position)
        {
            column = ToColumn(X);
        }

        public IEnumerable<BoardPosition> GetFromDirectionIterations(Directions directions, int maxIterations = 7)
        {
            var offset = 1;
            var result = new List<BoardPosition>();
            for (int i = 0; i < maxIterations; i++)
            {
                var multiplyer = offset + i;
                var delta = FromDirection(directions, multiplyer);
                var position = this.Add(delta);
                var boardPosition = new BoardPosition(position);
                result.Add(boardPosition);
            }
            return result;
        }

        public override string ToString() =>
            column.ToString() + Row;


    }
}