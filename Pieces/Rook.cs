using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Board;
using Chess.Game.TeamFolder;

namespace Chess.Pieces
{
    public class Rook:Piece
    {
        public Rook(string Name, string PieceSignature, TeamColor Color) : base(Name, PieceSignature, Color)
        {
            this.Name = Name;
            this.PieceSignature = PieceSignature;
            this.Color = Color;
        }
        public override void GenerateLegalMove(Dashboard Board)
        {
                PieceFinder pieceFinder = new PieceFinder(Board);
                pieceFinder.FindPieceOnDashboard(Name, Color);
            
            for (int i = pieceFinder.RowIndex; i < 8; i++)
            {
                    Board.Field[pieceFinder.RowIndex, i].SetNextLegalMove = true;
            }

            for (int i = pieceFinder.RowIndex; i >= 0; i--)
            {
                    Board.Field[pieceFinder.RowIndex, i].SetNextLegalMove = true;
            }

            for (int i = pieceFinder.ColumnIndex; i < 8; i++)
            {
                   Board.Field[i, pieceFinder.ColumnIndex].SetNextLegalMove = true;
            }

            for (int i = pieceFinder.ColumnIndex; i >= 0; i--)
            {
                    Board.Field[i, pieceFinder.ColumnIndex].SetNextLegalMove = true;
            }
        }
    }
}
