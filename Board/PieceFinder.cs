using System;

namespace Chess.Board
{
    class PieceFinder
    {
        private int column_index;
        private int row_index;
        public int Column_Index { get => column_index; }
        public int Row_Index { get => row_index; }
        Dashboard dashboard;
        public PieceFinder(Dashboard board)
        {
            this.dashboard = board;
        }
        public void FindPieceOnDashboard(string name, ConsoleColor team_color)
        {
            for (int i = 0; i < dashboard.column_size; i++)
            {
                for (int j = 0; j < dashboard.line_size; j++)
                {
                    if(name == dashboard.Board[i , j].piece.name)
                    {
                        if(team_color == dashboard.Board[i , j].piece.Team_Color)
                        {
                            column_index = i - 1;
                            row_index = j + 1;
                        }
                    }
                }
            }
        }
    }
}