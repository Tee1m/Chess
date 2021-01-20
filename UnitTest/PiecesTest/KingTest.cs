using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Chess.Game.TeamFolder;
using Chess.Pieces;
using Chess.Board;

namespace UnitTest.PiecesTest
{
    public class KingTest
    {
        Piece KingPiece = new King("TestKing", "K", TeamColor.NoColor);
        Dashboard Board = new Dashboard();
        
        [Fact]
        public void IncicializationIsProper()
        {
            //given

            //when

            //then
            Assert.NotNull(KingPiece);
        }

        [Theory]
        [InlineData(3, 5)]
        [InlineData(3, 4)]
        [InlineData(3, 3)]
        [InlineData(4, 3)]
        [InlineData(5, 4)]
        [InlineData(4, 5)]
        [InlineData(5, 5)]
        [InlineData(5, 3)]

        public void GenerateProperLegalMoves(int x, int y)
        {
            //given
            Board.Field[4, 4].Piece = KingPiece;
            //when
            Board.Field[4, 4].Piece.GenerateLegalMove(Board);
            //then
            Assert.True(Board.Field[x, y].NextLegalMove);
            
        }

    }
}
