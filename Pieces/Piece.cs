using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Board;
using Chess.Game.TeamFolder;

namespace Chess.Pieces
{
    public abstract class Piece
    {
        public string Name;
        protected bool FirstMoveExecuted = false;
        public string PieceSignature { get; protected set; }
        public TeamColor Color { get; protected set; }

        public Piece(string Name, string PieceSignature, TeamColor Color)
        {
            this.Name = Name;
            this.PieceSignature = PieceSignature;
            this.Color = Color;
        }

        public abstract void GenerateLegalMove(Dashboard Board);
    }
}

