using System;
using Xunit;
using Chess.Pieces;
using Chess.Board;
using Chess.Game.TeamFolder;

namespace UnitTest.PiecesTest
{
    public class BishopTest
    {
        Piece BishopPiece = new Bishop("TestBishop", "B", TeamColor.NoColor);
        Dashboard Board = new Dashboard();

        [Fact]
        public void InicializationIsProper()
        {
            //given

            //when

            //then
            Assert.NotNull(BishopPiece);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(5, 5)]
        [InlineData(6, 6)]
        [InlineData(7, 7)]
        [InlineData(1, 7)]
        [InlineData(7, 1)]
        public void GenerateProperLegalMovesForXconstY(int x, int y)
        {
            //given
            Board.Field[4, 4].Piece = BishopPiece;
            //when
            Board.Field[4, 4].Piece.GenerateLegalMove(Board);
            //then
            Assert.True(Board.Field[x, y].NextLegalMove);
        }

        [Theory]
        [InlineData(1, 7)]
        [InlineData(2, 6)]
        [InlineData(3, 5)]
        [InlineData(4, 4)]
        [InlineData(6, 2)]
        [InlineData(7, 1)]
        [InlineData(4, 2)]
        [InlineData(6, 4)]
        [InlineData(7, 5)]
        [InlineData(3, 1)]
        [InlineData(2, 0)]
        public void GenerateProperLegalMovesForRandomXandRandomY(int x, int y)
        {
            //given
            Board.Field[5, 3].Piece = BishopPiece;
            //when
            Board.Field[5, 3].Piece.GenerateLegalMove(Board);
            //then
            Assert.True(Board.Field[x, y].NextLegalMove);
        }

        [Theory]
        [InlineData(6, 0)]
        [InlineData(5, 1)]
        [InlineData(4, 2)]
        [InlineData(3, 3)]
        [InlineData(2, 4)]
        [InlineData(0, 6)]
        public void GenerateProperLegalMovesForYgreaterThanX(int x, int y)
        {
            //given
            Board.Field[1, 5].Piece = BishopPiece;
            //when
            Board.Field[1, 5].Piece.GenerateLegalMove(Board);
            //then
            Assert.True(Board.Field[x, y].NextLegalMove);
        }

        [Theory]
        [InlineData(6, 0)]
        [InlineData(4, 2)]
        [InlineData(3, 3)]
        [InlineData(2, 4)]
        [InlineData(1, 5)]
        [InlineData(0, 6)]
        [InlineData(7, 3)]
        [InlineData(4, 0)]
        public void GenerateProperLegalMovesForXgreaterThanY(int x, int y)
        {
            //given
            Board.Field[5, 1].Piece = BishopPiece;
            //when
            Board.Field[5, 1].Piece.GenerateLegalMove(Board);
            //then
            Assert.True(Board.Field[x, y].NextLegalMove);
        }
    }
}
