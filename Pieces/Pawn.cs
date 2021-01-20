using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Board;
using Chess.Game.TeamFolder;

namespace Chess.Pieces
{
    class Pawn:Piece
    {
        public Pawn(string Name, string PieceSignature, TeamColor Color) : base(Name, PieceSignature, Color)
        {
            this.Name = Name;
            this.PieceSignature = PieceSignature;
            this.Color = Color;
        }

        public override void GenerateLegalMove(Dashboard Board)
        {
           //TODO implementacja pionka
        }
    }
}
