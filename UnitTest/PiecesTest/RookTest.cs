using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Chess.Board;
using Chess.Pieces;
using Chess.Game.TeamFolder;

namespace UnitTest.PiecesTest
{
    public class RookTest
    {
        Piece RookPiece = new Rook("TestRook", "R", TeamColor.NoColor);
        
        [Fact]
        public void InicializationIsProper()
        {
            //given

            //when

            //then
            Assert.NotNull(RookPiece);
        }

        [Theory]
        [InlineData(4, 7)]
        [InlineData(4, 5)]
        [InlineData(3, 4)]
        [InlineData(4, 0)]
        [InlineData(0, 4)]
        [InlineData(7, 4)]
        public void GenerateProperLegalMoves(int x, int y)
        {
            //given
            Dashboard Board = new Dashboard();
            Board.Field[4, 4].Piece = RookPiece;
            //when
            Board.Field[4, 4].Piece.GenerateLegalMove(Board);
            //then
            Assert.True(Board.Field[x, y].NextLegalMove);
        }

    }
}
