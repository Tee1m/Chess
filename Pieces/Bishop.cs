using Chess.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    public class Bishop:Piece
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

            if (pieceFinder.Row_Index != 1 || pieceFinder.Column_Index != 1)
            {
                if (pieceFinder.Row_Index <= pieceFinder.Column_Index)
                {
                    for (int i = pieceFinder.Row_Index; i > 0; i--)
                    {
                        dashboard.Board[pieceFinder.Row_Index - i, pieceFinder.Column_Index - i].Next_Legal_Move = true;
                    }
                }

                if (pieceFinder.Row_Index > pieceFinder.Column_Index)
                {
                    for (int i = pieceFinder.Column_Index; i > 0; i--)
                    {
                        dashboard.Board[pieceFinder.Row_Index - i, pieceFinder.Column_Index - i].Next_Legal_Move = true;
                    }
                }
            }

            if (pieceFinder.Row_Index + 1 != 8 || pieceFinder.Column_Index + 1 != 8)
            {
                if (pieceFinder.Row_Index >= pieceFinder.Column_Index)
                {
                    for (int i = 0 ; pieceFinder.Row_Index + i < dashboard.column_size ; i++)
                    {
                        dashboard.Board[pieceFinder.Row_Index + i, pieceFinder.Column_Index + i].Next_Legal_Move = true;
                    }
                }
                else if (pieceFinder.Row_Index < pieceFinder.Column_Index)
                {
                    for (int i = pieceFinder.Column_Index; i >= dashboard.line_size ; i++)
                    {
                      dashboard.Board[pieceFinder.Row_Index + (pieceFinder.Row_Index - i), pieceFinder.Column_Index + (pieceFinder.Column_Index - i)].Next_Legal_Move = true;
                    }
                }
            }

            if (pieceFinder.Row_Index != 1 || pieceFinder.Column_Index != 8)
            {
                if (pieceFinder.Row_Index < pieceFinder.Column_Index)
                {
                    for (int i = 0; i < (dashboard.column_size - pieceFinder.Column_Index); i++)
                    {
                        dashboard.Board[pieceFinder.Row_Index - i, pieceFinder.Column_Index + i].Next_Legal_Move = true;
                    }
                }

                if (pieceFinder.Row_Index >= pieceFinder.Column_Index)
                {
                    for (int i = 0; i < (dashboard.column_size - pieceFinder.Column_Index); i++)
                    {
                        dashboard.Board[pieceFinder.Row_Index - i, pieceFinder.Column_Index + i].Next_Legal_Move = true;
                    }
                }
            }






        }
    }
}
