using System;
using Chess.Board;
using Chess.Game.TeamFolder;

namespace Chess.Game.GUI
{
    class CursorOnDashboard
    {
        private int column_pos = 4;
        private int row_pos = 4;
        Dashboard dashboard;
        public CursorOnDashboard(Dashboard dashboard)
        {
            this.dashboard = dashboard;
        }
        public Dashboard ChosingPiece(Team team)
        {
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            Console.CursorVisible = false;
            while (key.Key != ConsoleKey.Escape)
            {
                for (int i = 0; i < dashboard.column_size; i++)
                {
                    for (int j = 0; j < dashboard.line_size; j++)
                    {
                        if (i == column_pos && j == row_pos)
                            dashboard.Board[i, j].color_of_cell = ConsoleColor.DarkYellow;
                        else
                            dashboard.Board[i, j].SetCellColor();
                    }
                }

                dashboard.ShowDashBoard();
                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.LeftArrow && row_pos > 0)
                    row_pos--;

                else if (key.Key == ConsoleKey.RightArrow && row_pos < dashboard.line_size - 1)
                    row_pos++;

                else if (key.Key == ConsoleKey.DownArrow && column_pos < dashboard.column_size - 1)
                    column_pos++;

                else if (key.Key == ConsoleKey.UpArrow && column_pos > 0)
                    column_pos--;

                else if (key.Key == ConsoleKey.Enter)
                {
                    ConsoleColor color_who_play = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), team.team_color);

                    if (color_who_play == dashboard.Board[column_pos, row_pos].piece.Team_Color)
                    {
                        dashboard.Board[column_pos, row_pos].piece.MarkLegalMove(dashboard);
                        dashboard.ShowDashBoard();
                    }
                }
            }
            Console.CursorVisible = true;
            return dashboard;
        }
    }
    //TODO PlaceChanger class
}
