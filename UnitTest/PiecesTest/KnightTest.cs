using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Chess.Pieces;
using Chess.Board;
using Chess.Game.TeamFolder;

namespace UnitTest.PiecesTest
{
    public class KnightTest
    {
        Piece KnightPiece = new Knight("KnightTest", "H", TeamColor.NoColor);
        Dashboard Board = new Dashboard();

        [Fact]
        public void InicializationIsProper()
        {
            //given

            //when

            //then
            Assert.NotNull(KnightPiece);
        }

        [Theory]
        [InlineData(6, 5)]
        [InlineData(6, 3)]
        [InlineData(2, 5)]
        [InlineData(2, 3)]
        [InlineData(5, 6)]
        [InlineData(3, 6)]
        [InlineData(5, 2)]
        [InlineData(3, 2)]

        public void GenerateProperLegalMoves(int x, int y)
        {
            //given
            Board.Field[4, 4].Piece = KnightPiece;
            //when
            Board.Field[4, 4].Piece.GenerateLegalMove(Board);
            //then
            Assert.True(Board.Field[x, y].NextLegalMove);
        }

    }
}
