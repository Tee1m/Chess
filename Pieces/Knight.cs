using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Board;
using Chess.Game.TeamFolder;

namespace Chess.Pieces
{
    public class Knight:Piece
    {
        public Knight(string Name, string PieceSignature, TeamColor Color) : base(Name, PieceSignature, Color)
        {
            this.Name = Name;
            this.PieceSignature = PieceSignature;
            this.Color = Color;
        }

        public override void GenerateLegalMove(Dashboard Board)
        {
            PieceFinder pieceFinder = new PieceFinder(Board);
            pieceFinder.FindPieceOnDashboard(Name, Color);

            if (pieceFinder.RowIndex - 1 > 0 && pieceFinder.ColumnIndex > 0)
            {
                Board.Field[pieceFinder.RowIndex - 2, pieceFinder.ColumnIndex - 1].SetNextLegalMove = true;
            }

            if (pieceFinder.RowIndex + 2 < 8 && pieceFinder.ColumnIndex + 1 < 8)
            {
                Board.Field[pieceFinder.RowIndex + 2, pieceFinder.ColumnIndex + 1].SetNextLegalMove = true;
            }

            if (pieceFinder.RowIndex - 1 > 0 && pieceFinder.ColumnIndex < 8 - 1)
            {
                Board.Field[pieceFinder.RowIndex - 2, pieceFinder.ColumnIndex + 1].SetNextLegalMove = true;
            }

            if (pieceFinder.RowIndex + 2 < 8 && pieceFinder.ColumnIndex > 0)
            {
                Board.Field[pieceFinder.RowIndex + 2, pieceFinder.ColumnIndex - 1].SetNextLegalMove = true;
            }

            if (pieceFinder.RowIndex + 1 < 8 && pieceFinder.ColumnIndex -1 > 0)
            {
                Board.Field[pieceFinder.RowIndex + 1, pieceFinder.ColumnIndex - 2].SetNextLegalMove = true;
            }

            if (pieceFinder.RowIndex > 0 && pieceFinder.ColumnIndex -1 > 0)
            {
                Board.Field[pieceFinder.RowIndex - 1, pieceFinder.ColumnIndex - 2].SetNextLegalMove = true;
            }

            if (pieceFinder.RowIndex + 1 < 8 && pieceFinder.ColumnIndex + 2 < 8)
            {
                Board.Field[pieceFinder.RowIndex + 1, pieceFinder.ColumnIndex + 2].SetNextLegalMove = true;
            }

            if (pieceFinder.RowIndex > 0 && pieceFinder.ColumnIndex + 2 < 8)
            {
                Board.Field[pieceFinder.RowIndex - 1, pieceFinder.ColumnIndex + 2].SetNextLegalMove = true;
            }
        }
    }
}
