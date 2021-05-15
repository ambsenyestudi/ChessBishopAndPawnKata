﻿using ChessBishopAndPawn.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ChessBishopAndPawn.Test
{
    public class BishopShould
    {
        [Fact]
        public void BeAtBoard()
        {
            var sut = new Board();
            var isPresent = sut.Contains("Bishop");
            Assert.True(isPresent);
        }
        [Theory]
        [InlineData("A1","B2")]
        public void BeAbleToMove(string origin, string exptected)
        {
            var sut = new Board();
            var bishop = sut.GetByName("Bishop");
            sut.Spawn(bishop, origin);
            var moves = sut.GetAvailableMoves(bishop);
            Assert.Contains(moves, m=>m.Contains(exptected));
        }
    }
}
