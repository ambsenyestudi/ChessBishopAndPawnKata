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
    }
}
