using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Board;
namespace Chess.Pieces
{
    abstract class Piece
    {   
        protected bool first_move = true;
        public string name;
        protected string piece_index;
        protected ConsoleColor team_color;
        public ConsoleColor Team_Color { get => team_color; }
        public string Piece_Index { get => piece_index; }
        public Piece()
        {
            this.name = " ";
            this.piece_index = " ";
            this.team_color = Console.ForegroundColor = ConsoleColor.DarkGray;
        }
        public abstract void MarkLegalMove(Dashboard dashboard);
        //TODO change implementation of all pieces !!!! without knight. Knight is good.
    }
}
