using System;
using Chess.Board;
namespace Chess.Pieces
{
    class EmptyPlaceForPiece :Piece
    {
        public EmptyPlaceForPiece()
        {
            this.name = " ";
            this.piece_index = " ";
        }
        public override void MarkLegalMove(Dashboard dashboard)
        {
            throw new Exception("There is no piece here.");
        }
    }
}
