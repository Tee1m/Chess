using Chess.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Pawn:Piece
    {
        public Pawn(string team_color)
        {
            this.team_color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), team_color);
            this.name = "Pawn";
            this.piece_index = "P";
        }

        public override void MarkLegalMove(Dashboard dashboard)
        {
           //TODO implementacja pionka
        }
    }
}
