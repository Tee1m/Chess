using System;
using Chess.Board;
using Chess.Game.TeamFolder;

namespace Chess.Game.GUI
{
    class CursorOnDashboard
    {
        private int ColumnPosittion = 4;
        private int RowPosittion = 4;
        Dashboard Board;

        public CursorOnDashboard(Dashboard Board)
        {
            this.Board = Board;
        }

        public Dashboard ChosingPiece(Team Team)
        {
            ConsoleKeyInfo Key = new ConsoleKeyInfo();
            Console.CursorVisible = false;
            
            while (Key.Key != ConsoleKey.Escape)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (i == ColumnPosittion && j == RowPosittion)
                            Board.Field[i, j].Color = CellColor.DarkYellow;
                        else
                            Board.Field[i, j].SetCellColor();
                    }
                }

                Board.ShowDashBoard();
                Key = Console.ReadKey(true);

                if (Key.Key == ConsoleKey.LeftArrow && RowPosittion > 0)
                    RowPosittion--;

                else if (Key.Key == ConsoleKey.RightArrow && RowPosittion < 8 - 1)
                    RowPosittion++;

                else if (Key.Key == ConsoleKey.DownArrow && ColumnPosittion < 8 - 1)
                    ColumnPosittion++;

                else if (Key.Key == ConsoleKey.UpArrow && ColumnPosittion > 0)
                    ColumnPosittion--;

                else if (Key.Key == ConsoleKey.Enter)
                {
                    ConsoleColor color_who_play = (ConsoleColor)Team.Color;

                    if (color_who_play == (ConsoleColor)Board.Field[ColumnPosittion, RowPosittion].Piece.Color)
                    {
                        Board.Field[ColumnPosittion, RowPosittion].Piece.GenerateLegalMove(Board);
                        Board.ShowDashBoard();
                    }
                }
            }

            Console.CursorVisible = true;
            return Board;
        }
    }
    //TODO PlaceChanger class
}
