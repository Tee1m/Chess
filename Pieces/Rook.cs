using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Board;

namespace Chess.Pieces
{
    class Rook:Piece
    {
        public Rook(string team_color)
        {
            this.team_color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), team_color);
            this.name = "Rook";
            this.piece_index = "R";
        }
        public override void MarkLegalMove(Dashboard dashboard)
        {
                PieceFinder pieceFinder = new PieceFinder(dashboard);
                pieceFinder.FindPieceOnDashboard(name, Team_Color);

                for (int i = pieceFinder.Column_Index; i < dashboard.line_size; i++)
                {
                    dashboard.Board[i, pieceFinder.Row_Index].Next_Legal_Move = true;
                }

                for (int i = pieceFinder.Column_Index; i > 0; i++)
                {
                    dashboard.Board[i, pieceFinder.Row_Index].Next_Legal_Move = true;
                }

                for (int i = pieceFinder.Row_Index; i < dashboard.line_size; i++)
                {
                    dashboard.Board[i, pieceFinder.Column_Index].Next_Legal_Move = true;
                }

                for (int i = pieceFinder.Row_Index; i > 0; i++)
                {
                    dashboard.Board[i, pieceFinder.Column_Index].Next_Legal_Move = true;
                }  
        }
    }
}
