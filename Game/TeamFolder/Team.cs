using Chess.Pieces;

namespace Chess.Game.TeamFolder
{
    class Team
    {
        public King KingPiece;
        public Queen QueenPiece;
        public Bishop LeftBishopPiece;
        public Bishop RightBishopPiece;
        public Rook LeftRookPiece;
        public Rook RightRookPiece;
        public Knight LeftKnightPiece;
        public Knight RightKnightPiece;
        public Pawn PawnOne;
        public Pawn PawnTwo;
        public Pawn PawnThree;
        public Pawn PawnFour;
        public Pawn PawnFive;
        public Pawn PawnSix;
        public Pawn PawnSeven;
        public Pawn PawnEight;
        public TeamColor Color;

        public Team(TeamColor Color)
        {
            KingPiece = new King("King", "K", Color);
            QueenPiece = new Queen("Queen", "Q", Color);
            LeftBishopPiece = new Bishop("LeftBishop", "B", Color);
            RightBishopPiece = new Bishop("RightBishop", "B", Color);
            LeftRookPiece = new Rook("LeftRook", "R", Color);
            RightRookPiece = new Rook("RightRook", "R", Color);
            LeftKnightPiece = new Knight("LeftKnigh" ,"K", Color);
            RightKnightPiece = new Knight("RightKnight" ,"K", Color);
            PawnOne = new Pawn("PawnOne", "P", Color);
            PawnTwo = new Pawn("PawnTwo", "P", Color);
            PawnThree = new Pawn("PawnThree", "P", Color);
            PawnFour = new Pawn("PawnFour", "P", Color);
            PawnFive = new Pawn("PawnFive", "P", Color);
            PawnSix = new Pawn("PawnSix", "P", Color);
            PawnSeven = new Pawn("PawnSeven", "P", Color);
            PawnEight = new Pawn("PawnEight", "P", Color);
            this.Color = Color;        
        }
    }
}
