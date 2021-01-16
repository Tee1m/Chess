using Chess.Board;

namespace Chess.Game
{
    class SetUpLoadedGame : SetUpGame
    {
        public SetUpLoadedGame()
        {
            SetUpDashBoard = new Dashboard(8, 8);
        }
        public override Cell[,] SetUpDashboard()//TODO Load Game and save game class
        {
            return SetUpDashBoard.Board;
        }
    }

}
