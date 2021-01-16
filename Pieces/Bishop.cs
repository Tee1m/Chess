using Chess.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    class Bishop:Piece
    {
        public Bishop(string team_color)
        {
            this.team_color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), team_color);
            this.name = "Bishop";
            this.piece_index = "B";
        }

        public override void MarkLegalMove(Dashboard dashboard)
        {
            PieceFinder pieceFinder = new PieceFinder(dashboard);
            pieceFinder.FindPieceOnDashboard(name, Team_Color);

            for (int i = pieceFinder.Row_Index; i < dashboard.column_size; i++)
            {
                for (int j = pieceFinder.Column_Index; j > 0; j--)
                    dashboard.Board[j, i].Next_Legal_Move = true;
            }

            for (int i = pieceFinder.Row_Index; i < dashboard.column_size; i++)
            {
                for (int j = pieceFinder.Row_Index; j < dashboard.line_size; j++)
                    dashboard.Board[j, i].Next_Legal_Move = true;
            }

            for (int i = pieceFinder.Row_Index; i < dashboard.column_size; i++)
            {
                for (int j = pieceFinder.Column_Index; j > 0; j--)
                    dashboard.Board[i, j].Next_Legal_Move = true;
            }

            for (int i = pieceFinder.Row_Index; i < dashboard.column_size; i++)
            {
                for (int j = pieceFinder.Row_Index; j < dashboard.line_size; j++)
                    dashboard.Board[i, j].Next_Legal_Move = true;
            }
        }
    }
}
