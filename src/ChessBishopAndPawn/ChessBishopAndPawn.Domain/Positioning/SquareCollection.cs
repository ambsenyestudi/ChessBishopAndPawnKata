﻿using ChessBishopAndPawn.Domain.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChessBishopAndPawn.Domain.Positioning
{
    public class SquareCollection
    {
        public static SquareCollection Empty = new SquareCollection(new List<Square>());
        
        private readonly List<Square> squareCollection;

        private SquareCollection(List<Square> squareCollection)
        {
            this.squareCollection = squareCollection;
        }
        public SquareCollection(int size)
        {
            squareCollection = CreateEmpty(size);
        }
        private List<Square> CreateEmpty(int size)
        {
            var squareCollection = new List<Square>();
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    var column = ((BoardColumns)(x + 1)).ToString();
                    var row = y + 1;
                    var square = new Square(column, row, ChessPiece.Empty);
                    squareCollection.Add(square);
                }
            }
            return squareCollection;
        }

        public void Move(ChessPiece piece, string targenPosition)
        {
            squareCollection[0] = squareCollection[0].AddPiece(piece);
        }

        internal bool ContainsAt(ChessPiece piece, string pos)
        {
            var matchCollection = squareCollection.Where(s => s.Equals(pos));
            if(matchCollection.Any())
            {

                var found = matchCollection.First();
                return found.Contains(piece);
            }
            return false;
        }

        internal List<string> ToPosList() =>
            squareCollection.Select(x => x.ToString()).ToList();

        internal SquareCollection FromDirection(ChessPiece piece, Directions directions)
        {
            var originSquare = getSquare(piece);
            if(originSquare == null)
            {
                return Empty;
            }
            var result = new List<Square>();
            try
            {
                var col = IncrementBy(originSquare, 1);
                var row = originSquare.Row + 1;
                var pos = $"{col}{row}";
                var square = squareCollection.FirstOrDefault(sq => sq.Equals(pos));
                result.Add(square);
                
            }
            catch(Exception ex)
            {
                return Empty;
            }
            return new SquareCollection(result);
        }

        private static BoardColumns IncrementBy(Square pos, int offset)
        {
            var result = Enum.Parse<BoardColumns>(pos.Column) + offset;
            return (BoardColumns)result;
        }

        private Square getSquare(ChessPiece piece) =>
            squareCollection.FirstOrDefault(sq => sq.Contains(piece));
    }
}