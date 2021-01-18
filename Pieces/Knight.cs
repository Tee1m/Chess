using Chess.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Knight:Piece
    {
        public Knight(string team_color)
        {
            this.team_color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), team_color);
            this.name = "Knight";
            this.piece_index = "H";
        }

        public override void MarkLegalMove(Dashboard dashboard)
        {
            PieceFinder pieceFinder = new PieceFinder(dashboard);
            pieceFinder.FindPieceOnDashboard(name, Team_Color);

            if (pieceFinder.Row_Index - 1 > 0 && pieceFinder.Column_Index > 0)
            {
                dashboard.Board[pieceFinder.Row_Index - 2, pieceFinder.Column_Index - 1].Next_Legal_Move = true;
            }

            if (pieceFinder.Row_Index + 2 < dashboard.column_size && pieceFinder.Column_Index + 1 < dashboard.column_size)
            {
                dashboard.Board[pieceFinder.Row_Index + 2, pieceFinder.Column_Index + 1].Next_Legal_Move = true;
            }

            if (pieceFinder.Row_Index - 1 > 0 && pieceFinder.Column_Index < dashboard.column_size - 1)
            {
                dashboard.Board[pieceFinder.Row_Index - 2, pieceFinder.Column_Index + 1].Next_Legal_Move = true;
            }

            if (pieceFinder.Row_Index + 2 < dashboard.column_size && pieceFinder.Column_Index > 0)
            {
                dashboard.Board[pieceFinder.Row_Index + 2, pieceFinder.Column_Index - 1].Next_Legal_Move = true;
            }
            if (pieceFinder.Row_Index + 1 < dashboard.column_size && pieceFinder.Column_Index -1 > 0)
            {
                dashboard.Board[pieceFinder.Row_Index + 1, pieceFinder.Column_Index - 2].Next_Legal_Move = true;
            }

            if (pieceFinder.Row_Index > 0 && pieceFinder.Column_Index -1 > 0)
            {
                dashboard.Board[pieceFinder.Row_Index - 1, pieceFinder.Column_Index - 2].Next_Legal_Move = true;
            }

            if (pieceFinder.Row_Index + 1 < dashboard.column_size && pieceFinder.Column_Index + 2 < dashboard.column_size)
            {
                dashboard.Board[pieceFinder.Row_Index + 1, pieceFinder.Column_Index + 2].Next_Legal_Move = true;
            }

            if (pieceFinder.Row_Index > 0 && pieceFinder.Column_Index + 2 < dashboard.column_size)
            {
                dashboard.Board[pieceFinder.Row_Index - 1, pieceFinder.Column_Index + 2].Next_Legal_Move = true;
            }
        }
    }
}
