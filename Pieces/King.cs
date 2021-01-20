using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Board;
using Chess.Game.TeamFolder;

namespace Chess.Pieces
{
    public class King : Piece
    {
        public King(string Name, string PieceSignature, TeamColor Color) : base(Name, PieceSignature, Color)
        {
            this.Name = Name;
            this.PieceSignature = PieceSignature;
            this.Color = Color;
        }

        public override void GenerateLegalMove(Dashboard Board)
        {
            PieceFinder pieceFinder = new PieceFinder(Board);
            pieceFinder.FindPieceOnDashboard(Name, Color);

            if(pieceFinder.ColumnIndex < 7)
                Board.Field[pieceFinder.RowIndex, pieceFinder.ColumnIndex + 1].SetNextLegalMove = true;

            if(pieceFinder.RowIndex < 7)
                Board.Field[pieceFinder.RowIndex + 1, pieceFinder.ColumnIndex].SetNextLegalMove = true;

            if(pieceFinder.RowIndex > 0)
                Board.Field[pieceFinder.RowIndex - 1, pieceFinder.ColumnIndex].SetNextLegalMove = true;

            if (pieceFinder.ColumnIndex > 0)
                Board.Field[pieceFinder.RowIndex, pieceFinder.ColumnIndex - 1].SetNextLegalMove = true;

            if(pieceFinder.RowIndex < 7 && pieceFinder.ColumnIndex < 7)
                Board.Field[pieceFinder.RowIndex + 1, pieceFinder.ColumnIndex + 1].SetNextLegalMove = true;

            if (pieceFinder.RowIndex > 0 && pieceFinder.ColumnIndex > 0)
                Board.Field[pieceFinder.RowIndex - 1, pieceFinder.ColumnIndex - 1].SetNextLegalMove = true;

            if (pieceFinder.RowIndex < 7 && pieceFinder.ColumnIndex > 0)
                Board.Field[pieceFinder.RowIndex + 1, pieceFinder.ColumnIndex - 1].SetNextLegalMove = true;

            if (pieceFinder.RowIndex > 0 && pieceFinder.ColumnIndex < 7)
                Board.Field[pieceFinder.RowIndex - 1, pieceFinder.ColumnIndex + 1].SetNextLegalMove = true;
        }
        //TODO Fix implementation of movement

    }
}
