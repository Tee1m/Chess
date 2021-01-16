using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Board;

namespace Chess.Pieces
{
    class King : Piece
    {
        public King(string team_color)
        {
            this.team_color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), team_color);
            this.name = "King";
            this.piece_index = "K";
        }
        public override void MarkLegalMove(Dashboard dashboard)
        {
            PieceFinder pieceFinder = new PieceFinder(dashboard);
            pieceFinder.FindPieceOnDashboard(name, Team_Color);

            if(pieceFinder.Row_Index < dashboard.line_size)
                dashboard.Board[pieceFinder.Column_Index , pieceFinder.Row_Index + 1].Next_Legal_Move = true;
            
            if (pieceFinder.Row_Index < dashboard.column_size)
                dashboard.Board[pieceFinder.Column_Index + 1, pieceFinder.Row_Index].Next_Legal_Move = true;

            if (pieceFinder.Column_Index < dashboard.column_size && pieceFinder.Row_Index < dashboard.line_size)
                dashboard.Board[pieceFinder.Column_Index + 1, pieceFinder.Row_Index + 1].Next_Legal_Move = true;

            if (pieceFinder.Column_Index < dashboard.column_size && pieceFinder.Row_Index > 0)
                dashboard.Board[pieceFinder.Column_Index + 1, pieceFinder.Row_Index - 1].Next_Legal_Move = true;

            if (pieceFinder.Column_Index > 0 && pieceFinder.Row_Index < dashboard.line_size)
                dashboard.Board[pieceFinder.Column_Index - 1, pieceFinder.Row_Index + 1].Next_Legal_Move = true;

            if (pieceFinder.Column_Index > 0 && pieceFinder.Row_Index > 0)
                dashboard.Board[pieceFinder.Column_Index - 1, pieceFinder.Row_Index - 1].Next_Legal_Move = true;      
        }

    }
}
