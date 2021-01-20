using System;
using Chess.Board;
using Chess.Game.TeamFolder;
namespace Chess.Pieces
{
    class EmptyPlaceForPiece :Piece
    {
        public EmptyPlaceForPiece(string Name, string PieceSignature, TeamColor Color) : base(Name, PieceSignature, Color)
        {
            this.Name = Name;
            this.PieceSignature = PieceSignature;
            this.Color = Color;
        }

        public override void GenerateLegalMove(Dashboard Board)
        {
            throw new Exception("There is no piece here.");
        }
    }
}
