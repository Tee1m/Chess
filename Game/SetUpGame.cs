using Chess.Board;
using Chess.Game.TeamFolder;

namespace Chess.Game
{
    class SetUpGame
    {   
        public TeamGenerator WhiteTeam;
        public TeamGenerator BlackTeam;
        public Dashboard SetUpBoard;

        public SetUpGame(TeamGenerator FirstTeam, TeamGenerator SecondTeam)
        {
            WhiteTeam = FirstTeam;
            BlackTeam = SecondTeam;
            SetUpBoard = new Dashboard();   
        }

        public Cell[,] SetUpDashboard()
        {
            Cell[] tab = new Cell[8];
            for (int j = 0; j < 8; j++)
            {
                tab[j] = new Cell(j,0);
            }

            tab = WhiteTeam.TeamLineFormationKingRow(tab);
            SetUpRow(tab, 7);
            tab = WhiteTeam.FirstLineFormationPawnsRow(tab);
            SetUpRow(tab, 6);
            
            tab = BlackTeam.TeamLineFormationKingRow(tab);
            SetUpRow(tab, 0);
            tab = BlackTeam.FirstLineFormationPawnsRow(tab);
            SetUpRow(tab, 1);

            return SetUpBoard.Field;
        }

        void SetUpRow(Cell[]tab,int row)
        {
            for (int i = 0; i < 8; i++)
            {
                SetUpBoard.Field[row, i].Piece=tab[i].Piece;
            }
        }
    }
}
