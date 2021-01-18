using Chess.Pieces;
namespace Chess.Game.TeamFolder
{
    class Team
    {
        public King king_piece;
        public Queen queen_piece;
        public Bishop left_bishop_piece;
        public Bishop right_bishop_piece;
        public Rook left_rook_piece;
        public Rook right_rook_piece;
        public Knight left_knight_piece;
        public Knight right_knight_piece;
        public Pawn pawn_one;
        public Pawn pawn_two;
        public Pawn pawn_three;
        public Pawn pawn_four;
        public Pawn pawn_five;
        public Pawn pawn_six;
        public Pawn pawn_seven;
        public Pawn pawn_eight;
        public string team_color;

        public Team(string team_color)
        {
            king_piece = new King(team_color);
            queen_piece = new Queen(team_color);
            left_bishop_piece = new Bishop(team_color);
            right_bishop_piece = new Bishop(team_color);
            left_rook_piece = new Rook(team_color);
            right_rook_piece = new Rook(team_color);
            left_knight_piece = new Knight(team_color);
            right_knight_piece = new Knight(team_color);
            pawn_one = new Pawn(team_color);
            pawn_two = new Pawn(team_color);
            pawn_three = new Pawn(team_color);
            pawn_four = new Pawn(team_color);
            pawn_five = new Pawn(team_color);
            pawn_six = new Pawn(team_color);
            pawn_seven = new Pawn(team_color);
            pawn_eight = new Pawn(team_color);
            this.team_color = team_color;        
        }
    }
}
