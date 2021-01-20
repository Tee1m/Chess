using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Chess.Pieces;
using Chess.Game.TeamFolder;
using Chess.Board;

namespace UnitTest.PiecesTest
{
    public class QueenTest
    {
        Piece QueenPiece = new Queen("TestQueen", "Q", TeamColor.NoColor);
        Dashboard Board = new Dashboard();

        [Fact]
        public void InicializationIsProper()
        {
            //given

            //when

            //then
            Assert.NotNull(QueenPiece);
        }

        [Theory]
        [InlineData(4, 7)]
        [InlineData(4, 5)]
        [InlineData(3, 4)]
        [InlineData(4, 0)]
        [InlineData(0, 4)]
        [InlineData(7, 4)]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(5, 5)]
        [InlineData(6, 6)]
        [InlineData(7, 7)]
        [InlineData(1, 7)]
        [InlineData(7, 1)]
        public void GenerateProperLegamMoves(int x, int y)
        {
            //given
            Board.Field[4, 4].Piece = QueenPiece;
            //when
            Board.Field[4, 4].Piece.GenerateLegalMove(Board);
            //then
            Assert.True(Board.Field[x, y].NextLegalMove);
        }
    }
}
