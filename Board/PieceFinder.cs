using System;
using Chess.Game.TeamFolder;

namespace Chess.Board
{
    class PieceFinder
    {
        public int ColumnIndex { get; private set; }
        public int RowIndex { get; private set; }
        Dashboard Board;

        public PieceFinder(Dashboard Board)
        {
            this.Board = Board;
        }

        public void FindPieceOnDashboard(string Name, TeamColor Color)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if(Name == Board.Field[i, j].Piece.Name)
                    {
                        if(Color == Board.Field[i, j].Piece.Color)
                        {
                            ColumnIndex = j;
                            RowIndex = i;
                        }
                    }
                }
            }
        }
    }
}