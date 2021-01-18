using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Board;

namespace Chess.Pieces
{
    class Queen : Piece
    {
        public Queen(string team_color)
        {
            this.team_color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), team_color);
            this.name = "Queen";
            this.piece_index = "Q";
        }

        public override void MarkLegalMove(Dashboard dashboard)
        {
            PieceFinder pieceFinder = new PieceFinder(dashboard);
            pieceFinder.FindPieceOnDashboard(name, Team_Color);
            //TODO Implementacja przemieszczania się

           for (int i = pieceFinder.Row_Index; i < dashboard.column_size; i++)
           {
                    dashboard.Board[pieceFinder.Row_Index, i].Next_Legal_Move = true;
           }

           for (int i = pieceFinder.Row_Index ; i >= 0; i--)
           {
                    dashboard.Board[pieceFinder.Row_Index, i].Next_Legal_Move = true;
           }

           for (int i = pieceFinder.Column_Index; i < dashboard.line_size; i++)
           {
                    dashboard.Board[i, pieceFinder.Column_Index].Next_Legal_Move = true;
           }
            
           for (int i = pieceFinder.Column_Index ; i >= 0; i--)
           { 
                    dashboard.Board[i, pieceFinder.Column_Index].Next_Legal_Move = true;
           }
            

        }
    }
}
