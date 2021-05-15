﻿using System;

namespace ChessBishopAndPawn.Domain.Pieces
{
    public class ChessPiece
    {
        private readonly Guid id;
        public readonly string name;

        public ChessPiece(Guid id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public ChessPiece(string name):this(Guid.NewGuid(), name)
        {
        }
        public bool Is(string name) =>
            this.name == name;

        public override string ToString() =>
            name;
    }
}
